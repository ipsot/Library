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
    public partial class FormAddReader : Form
    {
        public FormAddReader()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;
       


        private void buttonCancelAddReader_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Readers().Show();
        }

        private void buttonAddReader_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;



                if (textBoxNameReader.Text == null || textBoxSecondName.Text == null || textBoxPatronymic.Text==null || textBoxPlace.Text==null ||textBoxTicket.Text==null|| maskedTextBoxPhone.Text==null)
                {
                    MessageBox.Show("Пожайлуста заполните все поля");
                    return;
                }

                mySqlCommand.CommandText = $"insert into `reader` (`Id`,`Name`, `SecondName`,`Patronymic`,`ReadersTicket`,`Phone`,`ResidentPlace`) values (0,'{textBoxNameReader.Text}','{textBoxSecondName.Text}','{textBoxPatronymic.Text}','{textBoxTicket.Text}','{maskedTextBoxPhone.Text}','{textBoxPlace.Text}')";
                mySqlCommand.ExecuteNonQuery();

                this.Hide();
                new Readers().Show();
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении");
            }

        }

        private void FormAddReader_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = mySqlConnection;
        }
    }
}
