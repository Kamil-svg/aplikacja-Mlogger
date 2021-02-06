using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Task_1727
{
    public partial class Logowanie : Form
    {
        MySqlConnection connection;
      

        public Logowanie()
        {
            InitializeComponent();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEnter(object sender, EventArgs e)
        {
            if(Username.Text.Equals(@"Nazwa użytkownika"))
            {
                Username.Text = "";
            }
                
        }

        private void textLeave(object sender, EventArgs e)
        {
            if (Username.Text.Equals(""))
            {
                Username.Text = @"Nazwa użytkownika";
            }
        }

        private void textEnter1(object sender, EventArgs e)
        {
            if(Password.Text.Equals("Hasło"))
            {
                Password.Text = "";
            }
        }

        private void textLeave1(object sender, EventArgs e)
        {
            if (Password.Text.Equals(""))
            {
                Password.Text = "Hasło";
            }
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                connection = new MySqlConnection("Server=db4free.net;Database=testmlogger;Uid=jitsiteam;Pwd=jitsi1234;old guids=true;");
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    
                    MessageBox.Show("Zalogowano pomyślnie", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                    Aplikacja a = new Aplikacja();
                    a.Show();
                }
                else 
                {
                    MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     connection.Close();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
    }
}
