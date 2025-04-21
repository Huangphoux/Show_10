namespace show10
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btnHam = new PictureBox();
            pnDashboard = new Panel();
            dashboard = new Button();
            sidebar = new FlowLayoutPanel();
            menuContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            menu = new Button();
            panel7 = new Panel();
            submenu1 = new Button();
            panel8 = new Panel();
            submenu2 = new Button();
            pnAbout = new Panel();
            about = new Button();
            pnSetting = new Panel();
            setting = new Button();
            pnLogout = new Panel();
            logout = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            pnDashboard.SuspendLayout();
            sidebar.SuspendLayout();
            menuContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            pnAbout.SuspendLayout();
            pnSetting.SuspendLayout();
            pnLogout.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 36);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1050, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 7);
            label1.Name = "label1";
            label1.Size = new Size(26, 23);
            label1.TabIndex = 2;
            label1.Text = ":>";
            // 
            // btnHam
            // 
            btnHam.ErrorImage = Show10.Properties.Resources.Menu2;
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(6, 5);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(25, 26);
            btnHam.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // pnDashboard
            // 
            pnDashboard.BackColor = Color.Transparent;
            pnDashboard.Controls.Add(dashboard);
            pnDashboard.Location = new Point(3, 33);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Size = new Size(271, 56);
            pnDashboard.TabIndex = 3;
            pnDashboard.Paint += panel2_Paint;
            // 
            // dashboard
            // 
            dashboard.BackColor = Color.Black;
            dashboard.FlatAppearance.BorderSize = 0;
            dashboard.FlatStyle = FlatStyle.Flat;
            dashboard.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard.ForeColor = Color.White;
            dashboard.Image = Show10.Properties.Resources.Combo_Chart2;
            dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard.Location = new Point(0, 0);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(271, 56);
            dashboard.TabIndex = 0;
            dashboard.Text = "        Dashboard";
            dashboard.TextAlign = ContentAlignment.MiddleLeft;
            dashboard.UseVisualStyleBackColor = false;
            dashboard.Click += dashboard_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Black;
            sidebar.Controls.Add(pnDashboard);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(pnAbout);
            sidebar.Controls.Add(pnSetting);
            sidebar.Controls.Add(pnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 36);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(0, 30, 0, 0);
            sidebar.Size = new Size(225, 637);
            sidebar.TabIndex = 4;
            sidebar.Paint += sidebar_Paint;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.Black;
            menuContainer.Controls.Add(panel3);
            menuContainer.Controls.Add(panel7);
            menuContainer.Controls.Add(panel8);
            menuContainer.Location = new Point(0, 92);
            menuContainer.Margin = new Padding(0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(265, 56);
            menuContainer.TabIndex = 7;
            menuContainer.Paint += flowLayoutPanel2_Paint_2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(menu);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 56);
            panel3.TabIndex = 5;
            // 
            // menu
            // 
            menu.BackColor = Color.Black;
            menu.FlatAppearance.BorderSize = 0;
            menu.FlatStyle = FlatStyle.Flat;
            menu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu.ForeColor = Color.White;
            menu.Image = Show10.Properties.Resources.Home;
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(3, 0, 0, 0);
            menu.Size = new Size(271, 56);
            menu.TabIndex = 0;
            menu.Text = "        Menu";
            menu.TextAlign = ContentAlignment.MiddleLeft;
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Controls.Add(submenu1);
            panel7.Location = new Point(0, 56);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(271, 56);
            panel7.TabIndex = 8;
            // 
            // submenu1
            // 
            submenu1.BackColor = Color.Black;
            submenu1.FlatAppearance.BorderSize = 0;
            submenu1.FlatStyle = FlatStyle.Flat;
            submenu1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submenu1.ForeColor = Color.White;
            submenu1.Image = Show10.Properties.Resources.Round;
            submenu1.ImageAlign = ContentAlignment.MiddleLeft;
            submenu1.Location = new Point(0, 0);
            submenu1.Name = "submenu1";
            submenu1.Padding = new Padding(20, 0, 0, 0);
            submenu1.Size = new Size(271, 56);
            submenu1.TabIndex = 0;
            submenu1.Text = "        Sub Menu 1";
            submenu1.TextAlign = ContentAlignment.MiddleLeft;
            submenu1.UseVisualStyleBackColor = false;
            submenu1.Click += submenu1_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(submenu2);
            panel8.Location = new Point(0, 112);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(271, 56);
            panel8.TabIndex = 9;
            // 
            // submenu2
            // 
            submenu2.BackColor = Color.Black;
            submenu2.FlatAppearance.BorderSize = 0;
            submenu2.FlatStyle = FlatStyle.Flat;
            submenu2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submenu2.ForeColor = Color.White;
            submenu2.Image = Show10.Properties.Resources.Round;
            submenu2.ImageAlign = ContentAlignment.MiddleLeft;
            submenu2.Location = new Point(0, 0);
            submenu2.Name = "submenu2";
            submenu2.Padding = new Padding(20, 0, 0, 0);
            submenu2.Size = new Size(271, 56);
            submenu2.TabIndex = 0;
            submenu2.Text = "        Sub Menu 2";
            submenu2.TextAlign = ContentAlignment.MiddleLeft;
            submenu2.UseVisualStyleBackColor = false;
            submenu2.Click += submenu2_Click_1;
            // 
            // pnAbout
            // 
            pnAbout.BackColor = Color.Transparent;
            pnAbout.Controls.Add(about);
            pnAbout.Location = new Point(3, 151);
            pnAbout.Name = "pnAbout";
            pnAbout.Size = new Size(271, 56);
            pnAbout.TabIndex = 6;
            // 
            // about
            // 
            about.BackColor = Color.Black;
            about.FlatAppearance.BorderSize = 0;
            about.FlatStyle = FlatStyle.Flat;
            about.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            about.ForeColor = Color.White;
            about.Image = Show10.Properties.Resources.Info;
            about.ImageAlign = ContentAlignment.MiddleLeft;
            about.Location = new Point(0, 0);
            about.Name = "about";
            about.Size = new Size(271, 56);
            about.TabIndex = 0;
            about.Text = "        About";
            about.TextAlign = ContentAlignment.MiddleLeft;
            about.UseVisualStyleBackColor = false;
            about.Click += about_Click;
            // 
            // pnSetting
            // 
            pnSetting.BackColor = Color.Transparent;
            pnSetting.Controls.Add(setting);
            pnSetting.Location = new Point(3, 213);
            pnSetting.Name = "pnSetting";
            pnSetting.Size = new Size(271, 56);
            pnSetting.TabIndex = 9;
            // 
            // setting
            // 
            setting.BackColor = Color.Black;
            setting.FlatAppearance.BorderSize = 0;
            setting.FlatStyle = FlatStyle.Flat;
            setting.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setting.ForeColor = Color.White;
            setting.Image = Show10.Properties.Resources.Settings;
            setting.ImageAlign = ContentAlignment.MiddleLeft;
            setting.Location = new Point(0, 0);
            setting.Name = "setting";
            setting.Size = new Size(271, 56);
            setting.TabIndex = 0;
            setting.Text = "        Setting";
            setting.TextAlign = ContentAlignment.MiddleLeft;
            setting.UseVisualStyleBackColor = false;
            setting.Click += setting_Click;
            // 
            // pnLogout
            // 
            pnLogout.BackColor = Color.Transparent;
            pnLogout.Controls.Add(logout);
            pnLogout.Location = new Point(3, 275);
            pnLogout.Name = "pnLogout";
            pnLogout.Size = new Size(271, 56);
            pnLogout.TabIndex = 7;
            // 
            // logout
            // 
            logout.BackColor = Color.Black;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.White;
            logout.Image = Show10.Properties.Resources.Logout_Rounded_Left;
            logout.ImageAlign = ContentAlignment.MiddleLeft;
            logout.Location = new Point(0, 0);
            logout.Name = "logout";
            logout.Size = new Size(271, 56);
            logout.TabIndex = 0;
            logout.Text = "        Logout";
            logout.TextAlign = ContentAlignment.MiddleLeft;
            logout.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 673);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show 10!";
            Load += MainWindow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            pnDashboard.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            pnAbout.ResumeLayout(false);
            pnSetting.ResumeLayout(false);
            pnLogout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private PictureBox btnHam;
        private Panel pnDashboard;
        private FlowLayoutPanel sidebar;
        private Button dashboard;
        private Panel pnAbout;
        private Button about;
        private Panel pnLogout;
        private Button logout;
        private Panel pnSetting;
        private Button setting;
        private Panel panel7;
        private Button submenu1;
        private Panel panel3;
        private Button menu;
        private FlowLayoutPanel menuContainer;
        private Panel panel8;
        private Button submenu2;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}
