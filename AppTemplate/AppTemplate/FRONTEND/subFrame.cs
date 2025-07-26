using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTemplate.FRONTEND.employee;
namespace AppTemplate
{
    public partial class subFrame : Form
    {
        public subFrame()
        {
            InitializeComponent();
        }

        public void display_inSub(Form newForm)
        {
            if (newForm == null)
                return;

            this.panelview.Controls.Clear();

            newForm.TopLevel = false;
            newForm.AutoScroll = true;
            newForm.AutoScrollMargin = new Size(50, 50);
            newForm.Dock = DockStyle.Fill;

            this.panelview.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();

            lbl_title.Text = string.IsNullOrWhiteSpace(newForm.Text) ? "Untitled" : newForm.Text;
        }


        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if already open
            Form openForm = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f is addUser);
            if (openForm == null)
            {
                addUser newForm = new addUser();
                newForm.Show();
            }
            else
            {
                openForm.BringToFront();
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (btn_user.ContextMenuStrip != null)
                btn_user.ContextMenuStrip.Show(btn_user, 0, btn_user.Height);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (btn_menu.ContextMenuStrip != null)
                btn_menu.ContextMenuStrip.Show(btn_menu, 0, btn_menu.Height);
        }

        private addnew_employee addEmpForm;

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addEmpForm == null || addEmpForm.IsDisposed)
                addEmpForm = new addnew_employee();

            display_inSub(addEmpForm);
        }
    }
}
