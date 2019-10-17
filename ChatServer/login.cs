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


namespace ChatServer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtUser.Text == string.Empty))
                {
                    if (!(txtPass.Text == string.Empty))
                    {
                        string str = "server=lochnagar.abertay.ac.uk;user id=sql1806055;persistsecurityinfo=True;password=3SjwV6FUwTPL;database=sql1806055";
                        string query = "select * from 307_users where username = '" + this.txtUser.Text + "'and password = '" + this.txtPass.Text + "'";
                        MySqlConnection con = new MySqlConnection(str);
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlDataReader dbr;
                        con.Open();
                        dbr = cmd.ExecuteReader();
                        int s = 0; 
                        while (dbr.Read())
                        {
                            s += 1;
                        }
                        if (s == 1)
                        {
                           // this.Hide(); //hide the login window
                            Chat f2 = new Chat(); //creates a new instance of the chat window
                            f2.ShowDialog();
                        }
                        else if (s > 1)
                        {
                            MessageBox.Show("Duplicate username and password", "login page");
                        }
                        else
                        {
                            MessageBox.Show("Please enter the correct username + password", "login page");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter your password", "login page");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your username", "login page");
                }
                // con.Close();  
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}