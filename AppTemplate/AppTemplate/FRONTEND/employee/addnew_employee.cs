using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTemplate.FRONTEND.employee
{
    public partial class addnew_employee : Form
    {
        public addnew_employee()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addnew_employee_Load(object sender, EventArgs e)
        {
          
            month_hired.SelectedItem = DateTime.Now.ToString("MMM");
            day_hired.SelectedItem = DateTime.Now.ToString("dd");
            year_hired.Text = DateTime.Now.ToString("yyyy");
        }
    }
}
