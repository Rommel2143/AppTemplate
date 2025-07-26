using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTemplate
{
    public partial class Mainframe : Form
    {
        public Mainframe()
        {
            InitializeComponent();
        }

        private void Mainframe_Load(object sender, EventArgs e)
        {
            display_inMain(new subFrame());
        }

        public void display_inMain(Form newForm)
        {
            // Clear existing controls
            this.panel1.Controls.Clear();

            // Set up the new form
            newForm.TopLevel = false;
            newForm.AutoScroll = true;
            newForm.AutoScrollMargin = new Size(50, 50);
            newForm.Dock = DockStyle.Fill; // Optional: Fill the panel

            // Add and show the new form
            this.panel1.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

    }
}
