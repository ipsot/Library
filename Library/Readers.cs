using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Library
{
    public partial class Readers : Form
    {
        public Readers()
        {
            InitializeComponent();
        }
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;
        public void FillDataGridView()
        {
            try
            {

                mySqlCommand.CommandText = "Select * from `reader`";

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                dataGridViewReaders.Rows.Clear();

                while (reader.Read())
                {
                    int id = reader.GetInt32("Id");
                    string name = reader.GetString("Name");
                    string SecondName = reader.GetString("SecondName");
                    string Patronymic = reader.GetString("Patronymic");
                    string ticket = reader.GetString("ReadersTicket");
                    string phone = reader.GetString("Phone");
                    string place = reader.GetString("ResidentPlace");

                    dataGridViewReaders.Rows.Add(id, name, SecondName, Patronymic, ticket, phone, place);
                }
                reader.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Произошла ошибка в загрузке");
            }
        }

        private void buttonAddReader_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAddReader().Show();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = mySqlConnection;



            int selectedId = int.Parse(dataGridViewReaders.SelectedRows[0].Cells[0].Value.ToString());

            mySqlCommand.CommandText = $"Delete from `reader` where (`Id`={selectedId})";
            mySqlCommand.ExecuteNonQuery();

            MessageBox.Show("Читатель удалён");


            FillDataGridView();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormBook().Show();
        }

        private void Readers_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = mySqlConnection;

            FillDataGridView();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = mySqlConnection;
            try
            {
                int idSelectedId = int.Parse(dataGridViewReaders.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Select* from `reader` where `Id`={idSelectedId}";
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                if (reader.HasRows == false)
                {
                    MessageBox.Show("Пожайлуста выберите читателя");
                    return;
                }
                else
                {
                    reader.Read();
                    Global.Reader = new Reader()
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("Name"),
                        SecondName = reader.GetString("SecondName"),
                        Patronymic = reader.GetString("Patronymic"),
                        Phone = reader.GetString("Phone"),
                        ReadersTicket = reader.GetString("ReadersTicket"),
                        ResidentPlace = reader.GetString("ResidentPlace"),

                    };
                    reader.Close();

                    this.Hide();
                    new FormUpdate().Show();
                }
            }
            catch
            {
                MessageBox.Show("Выберите читателя");
                return;
            }


        }

        private void Readers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = mySqlConnection;
            try
            {
                int selectedId = int.Parse(dataGridViewReaders.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Select* from `reader` where `Id`={selectedId}";
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                if (reader.HasRows == false)
                {
                    MessageBox.Show("Пожайлуста выберите читателя");
                    return;
                }
                else
                {
                    reader.Read();
                    Global.Reader = new Reader()
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("Name"),
                        SecondName = reader.GetString("SecondName"),
                        Patronymic = reader.GetString("Patronymic"),
                        Phone = reader.GetString("Phone"),
                        ReadersTicket = reader.GetString("ReadersTicket"),
                        ResidentPlace = reader.GetString("ResidentPlace"),

                    };
                    reader.Close();


                    this.Hide();
                    new Records().Show();
                }
            }
            catch
            {
                MessageBox.Show("Выберите читателя");
                return;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = mySqlConnection;

            string searchPerson = textBoxSearch.Text;

            if (searchPerson.Length == 0)
            {
                mySqlCommand.CommandText = $"SELECT * From `reader`";
            }
            else
            {
                mySqlCommand.CommandText = $"Select * from `reader` where Name like '{searchPerson}' or SecondName like '{searchPerson}' or Patronymic like '{searchPerson}' or ReadersTicket like '{searchPerson}' or Phone like '{searchPerson}' or ResidentPlace like '{searchPerson}' ";
            }


            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            dataGridViewReaders.Rows.Clear();

            while (reader.Read())
            {
                dataGridViewReaders.Rows.Add(reader.GetInt32("Id"), reader.GetString("Name"), reader.GetString("SecondName"),reader.GetString("Patronymic"),reader.GetString("ReadersTicket"),reader.GetString("Phone"),reader.GetString("ResidentPlace"));
            }

            reader.Close();
        }
    }
}
