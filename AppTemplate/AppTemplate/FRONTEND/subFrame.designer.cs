namespace AppTemplate
{
    partial class subFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subFrame));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btn_user = new Guna.UI2.WinForms.Guna2ImageButton();
            this.menu_user = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.masterlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panelview = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_menu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.emplToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterlistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2GradientPanel1.SuspendLayout();
            this.menu_user.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GradientPanel1.BorderThickness = 1;
            this.guna2GradientPanel1.Controls.Add(this.btn_menu);
            this.guna2GradientPanel1.Controls.Add(this.btn_user);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightGray;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1061, 51);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.Transparent;
            this.btn_user.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_user.ContextMenuStrip = this.menu_user;
            this.btn_user.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_user.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btn_user.HoverState.ImageSize = new System.Drawing.Size(33, 33);
            this.btn_user.Image = ((System.Drawing.Image)(resources.GetObject("btn_user.Image")));
            this.btn_user.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_user.ImageRotate = 0F;
            this.btn_user.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_user.Location = new System.Drawing.Point(0, 0);
            this.btn_user.Name = "btn_user";
            this.btn_user.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btn_user.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btn_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_user.Size = new System.Drawing.Size(51, 51);
            this.btn_user.TabIndex = 2;
            this.btn_user.UseTransparentBackground = true;
            this.btn_user.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // menu_user
            // 
            this.menu_user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.administratorToolStripMenuItem});
            this.menu_user.Name = "menu_Masterlist";
            this.menu_user.Size = new System.Drawing.Size(177, 56);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.toolStripMenuItem1.Text = "User";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.administratorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.administratorToolStripMenuItem.Text = "Administrator";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterlistToolStripMenuItem,
            this.emplToolStripMenuItem});
            this.menu.Name = "menu_Masterlist";
            this.menu.Size = new System.Drawing.Size(154, 56);
            // 
            // masterlistToolStripMenuItem
            // 
            this.masterlistToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterlistToolStripMenuItem.Name = "masterlistToolStripMenuItem";
            this.masterlistToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.masterlistToolStripMenuItem.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 533);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2GradientPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 48);
            this.panel2.TabIndex = 2;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderRadius = 5;
            this.guna2GradientPanel2.Controls.Add(this.lbl_title);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.ForestGreen;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(27, 3);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(265, 29);
            this.guna2GradientPanel2.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(5, 4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(47, 21);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Form";
            // 
            // panelview
            // 
            this.panelview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelview.Location = new System.Drawing.Point(27, 99);
            this.panelview.Name = "panelview";
            this.panelview.Size = new System.Drawing.Size(1034, 533);
            this.panelview.TabIndex = 3;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_menu.ContextMenuStrip = this.menu;
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_menu.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_menu.HoverState.ImageSize = new System.Drawing.Size(33, 33);
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_menu.ImageRotate = 0F;
            this.btn_menu.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_menu.Location = new System.Drawing.Point(51, 0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btn_menu.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btn_menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_menu.Size = new System.Drawing.Size(51, 51);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.UseTransparentBackground = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // emplToolStripMenuItem
            // 
            this.emplToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterlistToolStripMenuItem1,
            this.addNewToolStripMenuItem});
            this.emplToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplToolStripMenuItem.Name = "emplToolStripMenuItem";
            this.emplToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.emplToolStripMenuItem.Text = "Employees";
            // 
            // masterlistToolStripMenuItem1
            // 
            this.masterlistToolStripMenuItem1.Name = "masterlistToolStripMenuItem1";
            this.masterlistToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.masterlistToolStripMenuItem1.Text = "Masterlist";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // subFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 632);
            this.Controls.Add(this.panelview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "subFrame";
            this.Text = "subFrame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2GradientPanel1.ResumeLayout(false);
            this.menu_user.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem masterlistToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menu_user;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2Panel panelview;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton btn_user;
        private Guna.UI2.WinForms.Guna2ImageButton btn_menu;
        private System.Windows.Forms.ToolStripMenuItem emplToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterlistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
    }
}