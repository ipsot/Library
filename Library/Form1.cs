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
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
        }
        MySqlCommand command;
        MySqlConnection connection;
        private void FormBook_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"SELECT* From `bookmanager` as bm join `genres` as g on bm.idgenre=g.id";
            MySqlDataReader reader = command.ExecuteReader();

            dataGridViewBooks.Rows.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32("Id");
                string nameBook = reader.GetString("NameBook");
                string author = reader.GetString("Author");
                int page = reader.GetInt32("Page");
                string genre = reader.GetString("Genre");
                bool position = reader.GetBoolean("OnHand");

                dataGridViewBooks.Rows.Add(id, nameBook, author, page, genre, position == false ? "В библиотеке" : "На руках");
            }
            reader.Close();

            Load_Readers();
        }
        public void Load_Book()
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"SELECT* From `bookmanager` as bm join `genres` as g on bm.idgenre=g.id";
            MySqlDataReader reader = command.ExecuteReader();

            dataGridViewBooks.Rows.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32("Id");
                string nameBook = reader.GetString("NameBook");
                string author = reader.GetString("Author");
                int page = reader.GetInt32("Page");
                string genre = reader.GetString("Genre");
                bool position = reader.GetBoolean("OnHand");

                dataGridViewBooks.Rows.Add(id, nameBook, author, page, genre, position == false ? "В библиотеке" : "На руках");
            }
            reader.Close();
        }

        public void Load_Readers()
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"Select * from `records` as rec join `reader` as r on rec.id_Reader=r.Id  join `bookmanager` as book on rec.id_Book=book.Id WHERE book.OnHand=1 ";

            MySqlDataReader reader = command.ExecuteReader();
            dataGridViewReader.Rows.Clear();
            int dept = 0;
            while (reader.Read())
            {
                int id = reader.GetInt32("Id");
                string book = reader.GetString("NameBook");
                string name = reader.GetString("Name");
                string ticket = reader.GetString("ReadersTicket");
                DateTime dateToRelease = reader.GetDateTime("dateRelease");

                dataGridViewReader.Rows.Add(id, book, name, ticket, dateToRelease);

            }
            reader.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAdd().Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

                connection = new MySqlConnection(connectionString);
                connection.Open();

                command = new MySqlCommand();
                command.Connection = connection;

                int selectedId = int.Parse(dataGridViewBooks.SelectedRows[0].Cells[0].Value.ToString());
                command.CommandText = $"delete from `bookmanager` where `id`={selectedId}";
                command.ExecuteNonQuery();
                MessageBox.Show("Книга удалена");
                Load_Book();
                
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении книги");
                return;
            }

        }

        private void FormBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonGoToReaders_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Readers().Show();
        }

        private void dataGridViewReader_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewReader.Rows)
            {
                int days = (DateTime.Parse(row.Cells[4].Value.ToString()) - DateTime.Now).Days;
                if (days < 0)
                {
                    //row.Cells[1].Style.BackColor = Color.Red;
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }

            
        }

    }
}
