using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTemplate.BACKEND;
using MySql.Data.MySqlClient;

namespace AppTemplate
{
    public partial class addUser : Form
    {
        

        public addUser()
        {
            InitializeComponent();
        }

        private void addUser_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text.Trim()== "" || txt_firstname.Text.Trim()=="" || txt_lastname.Text.Trim()=="" )
                   {
                    MessageBox.Show("Please input all fields.");
                    return;
                }
                        
               
                string query = "INSERT INTO `users`(`id`, `username`, `Firstname`, `Lastname`, `password`, `admin`) " +
                               "VALUES (NULL, @username, @firstname, @lastname, @password, 0)";

                int rows = DBHelper.ExecuteNonQuery(query,
                    new MySqlParameter("@username", txt_username.Text),
                    new MySqlParameter("@firstname", txt_firstname.Text),
                    new MySqlParameter("@lastname", txt_lastname.Text),
                     new MySqlParameter("@password",""));

                if (rows > 0)
                {
                    MessageBox.Show("User added successfully!");
                }
                else
                {
                    MessageBox.Show("No rows inserted.");
                }
                cleartext();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       void cleartext()
        {
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_username.Clear();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}