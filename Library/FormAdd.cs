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

    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;

        List<Genres> genres;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadGenre()
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = mySqlConnection;

            mySqlCommand.CommandText = "select * from `genres`";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            genres = new List<Genres>();
            while (reader.Read())
            {
                int id = reader.GetInt32("Id");
                string genre = reader.GetString("Genre");

                genres.Add(new Genres()
                {
                    Id=id,Genre=genre
                });
            }
            reader.Close();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;



                if (textBoxAuthor.Text == null || textBoxNameBook.Text == null || textBoxPageCount.Text == null||comboBoxGenre.Text==null) 
                {
                    MessageBox.Show("Пожайлуста заполните все поля");
                    return;
                }

                int idGenre = ((Genres)(comboBoxGenre.SelectedItem)).Id;

                mySqlCommand.CommandText = $"insert into `bookmanager` (`Id`,`NameBook`,`Author`,`Page`,`IdGenre`,`OnHand`) values (0,'{textBoxNameBook.Text}','{textBoxAuthor.Text}','{textBoxPageCount.Text}','{idGenre}',0)";
                mySqlCommand.ExecuteNonQuery();


                this.Hide();
                new FormBook().Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении");
            }
        }

        private void buttonCancelAddBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormBook().Show();
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            genres =new List<Genres>();
            LoadGenre();
            comboBoxGenre.DataSource = genres;
            comboBoxGenre.DisplayMember = "Genre";
        }

        private void FormAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
