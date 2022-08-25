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
    public partial class FormUpdate : Form
    {
        MySqlConnection connection;
        MySqlCommand command;

        List<Reader> readers;
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"Select * from `reader` where `id`={Global.Reader.Id}";
            MySqlDataReader reader = command.ExecuteReader();

            readers = new List<Reader>();
            textBoxNameReader.Text = Global.Reader.Name;
            textBoxSecondName.Text = Global.Reader.SecondName;
            textBoxPatronymic.Text = Global.Reader.Patronymic;
            textBoxTicket.Text = Global.Reader.ReadersTicket;
            maskedTextBoxPhone.Text = Global.Reader.Phone;
            textBoxPlace.Text = Global.Reader.ResidentPlace;

            reader.Close();
        }

        private void buttonUpdateReader_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=libraryone";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"update `reader` set `Name`='{ textBoxNameReader.Text}',`SecondName`='{ textBoxSecondName.Text}',`Patronymic`='{ textBoxPatronymic.Text}',`ReadersTicket`='{textBoxTicket.Text}',`Phone`='{ maskedTextBoxPhone.Text}',`ResidentPlace`='{textBoxPlace.Text}' where id={Global.Reader.Id}";
            MySqlDataReader reader = command.ExecuteReader();

            reader.Close();

            MessageBox.Show("Данные обновленны");

            this.Hide();
            new Readers().Show();
        }

        private void buttonCancelAddReader_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Readers().Show();
        }

        private void FormUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
