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
    public partial class Records : Form
    {
        MySqlCommand command;
        MySqlConnection connection;
        List<Reader> readers;
        List<Books> books;
        List<Record> records;

        public Records()
        {
            InitializeComponent();
        }

        public void UpdateBook()
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            books = new List<Books>();
            int idBook = int.Parse(dataGridViewSearch.SelectedRows[0].Cells[0].Value.ToString());

            command.CommandText = $"update `bookmanager` set `OnHand`=1 where id = {idBook}";
            command.ExecuteNonQuery();

        }

        public void UpdateBookVer2()
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            books = new List<Books>();
            int idBook = int.Parse(dataGridViewRecords.SelectedRows[0].Cells[1].Value.ToString());

            command.CommandText = $"update `bookmanager` set `OnHand`=0 where `Id`= {idBook}";
            command.ExecuteNonQuery();

        }


        public void FillDataGridView()
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            //records = new List<Record>();
            //int idSelected = int.Parse(dataGridViewSearch.SelectedRows[0].Cells[0].Value.ToString());


            //command.CommandText = $"SELECT* From `bookmanager` as bm join `records` as r  join `reader` as re on bm.id=r.id_Book where r.Id=8";
            records = new List<Record>();
            int idSelected = int.Parse(dataGridViewSearch.SelectedRows[0].Cells[0].Value.ToString());
            command.CommandText = $"Select * from `records` where id={idSelected}";

            MySqlDataReader reader = command.ExecuteReader();

            dataGridViewRecords.Rows.Clear();


            while (reader.Read())
            {
                int id = reader.GetInt32("Id");
                int idBook = reader.GetInt32("id_Book");
                int idReader = reader.GetInt32("id_Reader");
                DateTime dateToIssue1 = reader.GetDateTime(3);
                DateTime dateToRelease1 = reader.GetDateTime(4);
                //string nameBook = reader.GetString("NameBook");
                //string author = reader.GetString("Author");
                //string nameReader = reader.GetString("Name");
                //DateTime dateToIssue = reader.GetDateTime(9);
                //DateTime dateToRelease = reader.GetDateTime(10);
                //int idRecord = reader.GetInt32(6);

                //dataGridViewRecords.Rows.Add(id, nameBook, author, nameReader, dateToIssue, dateToRelease);
                dataGridViewRecords.Rows.Add(id,idBook,idReader,dateToIssue1,dateToRelease1);

            }

            reader.Close();
        }

        public void LoadRecord()
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"Select * from `records` as rec join `reader` as r on rec.id_Reader=r.Id  join `bookmanager` as book on rec.id_Book=book.Id  where rec.id_Reader={Global.Reader.Id}";
            MySqlDataReader reader = command.ExecuteReader();

            dataGridViewRecords.Rows.Clear();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int idBook = reader.GetInt32(1);
                string book = reader.GetString(13);
                string author = reader.GetString(14);
                string readerName = reader.GetString(6);
                DateTime dateToIssue1 = reader.GetDateTime(3);
                DateTime dateToRelease1 = reader.GetDateTime(4);

                dataGridViewRecords.Rows.Add(id,idBook, book,author, readerName, dateToIssue1, dateToRelease1);
            }
            reader.Close();

            LoadBookAndAuthor();

            readers = new List<Reader>();
            textBoxNameReader.Text = Global.Reader.Name;

            reader.Close();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            LoadRecord();
           
        }

        public void LoadBookAndAuthor()
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = $"SELECT* From `bookmanager` as bm join `genres` as g on g.Id=bm.IdGenre where `OnHand`=0";

            MySqlDataReader reader = command.ExecuteReader();
            dataGridViewSearch.Rows.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32("Id");
                string name = reader.GetString("NameBook");
                string genre = reader.GetString("Genre");
                string author = reader.GetString("Author");

                dataGridViewSearch.Rows.Add(id, name,genre, author);
            }
            reader.Close();
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            string searchPerson = textBoxSearchBook.Text;

            if (searchPerson.Length == 0 && textBoxSearchAuthor.TextLength==0 && textBoxSearchGanre.Text.Length==0)
            {
                command.CommandText = $"SELECT* From `bookmanager` as bm join `genres` as g on g.Id=bm.IdGenre where bm.OnHand=0";
            }
            else
            {
                if (searchPerson.Length > 0)
                {
                    command.CommandText = $"Select * from `bookmanager` as bm join `genres` as g on g.Id=bm.IdGenre where bm.NameBook like '%{searchPerson}%' and bm.OnHand=0";
                }
                if (textBoxSearchAuthor.TextLength>0)
                {
                    command.CommandText = $"Select * from `bookmanager` as bm join `genres` as g on g.Id=bm.IdGenre where bm.Author like '%{textBoxSearchAuthor.Text}%' and bm.OnHand=0";
                }
                if (textBoxSearchGanre.TextLength>0)
                {
                    command.CommandText = $"Select * from `bookmanager` as bm join `genres` as g on g.Id=bm.IdGenre where g.Genre like '%{textBoxSearchGanre.Text}%' and bm.OnHand=0";
                }
                if (searchPerson.Length > 0 && textBoxSearchAuthor.TextLength > 0)
                {
                    command.CommandText = $"Select * from `bookmanager` as bm join `genres` as g on g.Id=bm.IdGenre where bm.NameBook like '%{searchPerson}%' and bm.Author like '%{textBoxSearchAuthor.Text}%' and bm.OnHand=0";
                }
                if (searchPerson.Length > 0 && textBoxSearchGanre.TextLength > 0)
                {
                    command.CommandText = $"Select * from `bookmanager` as bm join `genres` as g on g.Id=bm.IdGenre where bm.NameBook like '%{searchPerson}%' and g.Genre like '%{textBoxSearchGanre.Text}%' and bm.OnHand=0";
                }
                if (textBoxSearchAuthor.TextLength > 0 && textBoxSearchGanre.TextLength > 0)
                {
                    command.CommandText = $"Select * from `bookmanager` as bm join `genres` as g on g.Id=bm.IdGenre where g.Genre like '%{textBoxSearchGanre.Text}%' and bm.Author like '%{textBoxSearchAuthor.Text}%' and bm.OnHand=0";
                }
                if (searchPerson.Length > 0 && textBoxSearchAuthor.TextLength > 0 && textBoxSearchGanre.TextLength > 0)
                {
                    command.CommandText = $"Select * from `bookmanager` as bm join genres as g on g.Id=bm.IdGenre where bm.NameBook like '%{searchPerson}%' and bm.Author like '%{textBoxSearchAuthor.Text}%' and g.Genre like '%{textBoxSearchGanre.Text}%' and bm.OnHand=0";
                }
            }


            MySqlDataReader reader = command.ExecuteReader();

            dataGridViewSearch.Rows.Clear();

            while (reader.Read())
            {
                dataGridViewSearch.Rows.Add(reader.GetInt32("Id"), reader.GetString("NameBook"),reader.GetString("Genre"), reader.GetString("Author"));
            }

            reader.Close();
        }

        private void Records_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Readers().Show();
        }

        private void dataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewSearch.SelectedRows[0];
                textBoxBook.Text = row.Cells[1].Value.ToString();
                textBoxGenre.Text = row.Cells[2].Value.ToString();
                textBoxAuth.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите книгу");
                return;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            UpdateBookVer2();

            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            int selectedId = int.Parse(dataGridViewRecords.SelectedRows[0].Cells[0].Value.ToString());
            command.CommandText = $"delete from `records` where `id`={selectedId}";
            command.ExecuteNonQuery();

            LoadRecord();
            MessageBox.Show("Запись удалена");


            LoadBookAndAuthor();
            
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            


            int idBook =int.Parse(dataGridViewSearch.SelectedRows[0].Cells[0].Value.ToString());

            DateTime date = dateTimePickerOfIssue.Value;
            DateTime dateTime = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
            string dt = dateTime.ToString("yyyy-MM-dd H:mm:ss");

            DateTime dateRelease = dateTimePickerOfReleas.Value;
            DateTime dateTimeRelease = new DateTime(dateRelease.Year, dateRelease.Month, dateRelease.Day, 0, 0, 0);
            string dtRelease = dateTimeRelease.ToString("yyyy-MM-dd H:mm:ss");



            if (dt == dtRelease)
            {
                MessageBox.Show("Дата взятия книги и дата возврата книги должны быть разными");
                return;
            }
            else if ((dateRelease.Year < date.Year) || (dateRelease.Month < date.Month) || ((dateRelease.Day < date.Day)&&(dateRelease.Month<date.Day)))
            {
                MessageBox.Show("Дата взятия книги должна быть меньше чем дата возврата книги");
                return;
            }
            else
            {
                command.CommandText = $"insert into `records` (`id`,`id_Book`,`id_Reader`,`dateOfIssue`,`dateRelease`) values(0,'{idBook}','{Global.Reader.Id}','{dt}','{dtRelease}')";
                command.ExecuteNonQuery();


                MessageBox.Show("Запись добавлена");
                UpdateBook();
                LoadRecord();
                LoadBookAndAuthor();
            }

            

        }
    }

}
