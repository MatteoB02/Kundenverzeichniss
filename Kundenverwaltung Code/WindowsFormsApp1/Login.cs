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


namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        private MySqlConnection conn;

        private string server;
        private string database;
        private string uid;
        private string password;

        public Login()
        {
            server = "localhost";
            database = "mydb";
            uid = "root";
            password = "";

            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            conn = new MySqlConnection(connectionString);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string user = TxtBoxBenutzername.Text;
            string pass = TxtBoxPasswort.Text;

            if (IsLogin(user, pass))
            {
                MessageBox.Show($"Willkommen {user}! du bist jetzt eingeloggt");
            }
            else
            {
                MessageBox.Show($"Benutzername oder Passwort ist falsch");
            }

        }

        public bool IsLogin(string user, string pass)
        {
            string query = $"SELECT * FROM tbllogin WHERE Benutzername = '{user}' && Passwort = '{pass}'";

            try
            {
                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;


                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        private void MsgBoxPasswort_TextChanged(object sender, EventArgs e)
        {

        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;

            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Keine Verbindung zum Server");
                        break;
                    case 1045:
                        MessageBox.Show("Server Benutzername oder Passwort ist falsch");
                        break;
                }
                return false;
            }
        }
    }
}
