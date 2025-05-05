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
            timer_Clock = new System.Windows.Forms.Timer(components);
            label_Clock = new Label();
            icon_Fullscreen = new FontAwesome.Sharp.IconPictureBox();
            panel_Menu = new Panel();
            icon_Book = new FontAwesome.Sharp.IconButton();
            icon_User = new FontAwesome.Sharp.IconButton();
            panel_Brand = new Panel();
            label_Brand = new Label();
            icon_Brand = new FontAwesome.Sharp.IconPictureBox();
            panel_TopBar = new Panel();
            panel_ChildForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)icon_Fullscreen).BeginInit();
            panel_Menu.SuspendLayout();
            panel_Brand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_Brand).BeginInit();
            panel_TopBar.SuspendLayout();
            SuspendLayout();
            // 
            // timer_Clock
            // 
            timer_Clock.Enabled = true;
            timer_Clock.Interval = 1000;
            timer_Clock.Tick += Timer_Tick;
            // 
            // label_Clock
            // 
            label_Clock.Dock = DockStyle.Fill;
            label_Clock.FlatStyle = FlatStyle.Flat;
            label_Clock.Location = new Point(0, 0);
            label_Clock.Name = "label_Clock";
            label_Clock.Size = new Size(860, 38);
            label_Clock.TabIndex = 0;
            label_Clock.Text = "(Số giờ sử dụng)";
            label_Clock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // icon_Fullscreen
            // 
            icon_Fullscreen.BackColor = SystemColors.Control;
            icon_Fullscreen.Dock = DockStyle.Right;
            icon_Fullscreen.ForeColor = SystemColors.ControlText;
            icon_Fullscreen.IconChar = FontAwesome.Sharp.IconChar.Expand;
            icon_Fullscreen.IconColor = SystemColors.ControlText;
            icon_Fullscreen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_Fullscreen.IconSize = 38;
            icon_Fullscreen.Location = new Point(860, 0);
            icon_Fullscreen.Name = "icon_Fullscreen";
            icon_Fullscreen.Size = new Size(40, 38);
            icon_Fullscreen.SizeMode = PictureBoxSizeMode.CenterImage;
            icon_Fullscreen.TabIndex = 1;
            icon_Fullscreen.TabStop = false;
            icon_Fullscreen.Click += Icon_Fullscreen_Click;
            // 
            // panel_Menu
            // 
            panel_Menu.BorderStyle = BorderStyle.FixedSingle;
            panel_Menu.Controls.Add(icon_Book);
            panel_Menu.Controls.Add(icon_User);
            panel_Menu.Controls.Add(panel_Brand);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 0);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(280, 673);
            panel_Menu.TabIndex = 2;
            // 
            // icon_Book
            // 
            icon_Book.Dock = DockStyle.Top;
            icon_Book.FlatAppearance.BorderSize = 0;
            icon_Book.FlatStyle = FlatStyle.Flat;
            icon_Book.IconChar = FontAwesome.Sharp.IconChar.Book;
            icon_Book.IconColor = Color.Black;
            icon_Book.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Book.IconSize = 30;
            icon_Book.Location = new Point(0, 280);
            icon_Book.Name = "icon_Book";
            icon_Book.Size = new Size(278, 80);
            icon_Book.TabIndex = 2;
            icon_Book.Text = "Sách";
            icon_Book.TextAlign = ContentAlignment.MiddleRight;
            icon_Book.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_Book.UseVisualStyleBackColor = true;
            icon_Book.Click += Icon_Book_Click;
            // 
            // icon_User
            // 
            icon_User.Dock = DockStyle.Top;
            icon_User.FlatAppearance.BorderSize = 0;
            icon_User.FlatStyle = FlatStyle.Flat;
            icon_User.IconChar = FontAwesome.Sharp.IconChar.User;
            icon_User.IconColor = Color.Black;
            icon_User.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_User.IconSize = 30;
            icon_User.Location = new Point(0, 200);
            icon_User.Name = "icon_User";
            icon_User.Size = new Size(278, 80);
            icon_User.TabIndex = 1;
            icon_User.Text = "Tài khoản";
            icon_User.TextAlign = ContentAlignment.MiddleRight;
            icon_User.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_User.UseVisualStyleBackColor = true;
            icon_User.Click += Icon_User_Click;
            // 
            // panel_Brand
            // 
            panel_Brand.Controls.Add(label_Brand);
            panel_Brand.Controls.Add(icon_Brand);
            panel_Brand.Dock = DockStyle.Top;
            panel_Brand.Location = new Point(0, 0);
            panel_Brand.Name = "panel_Brand";
            panel_Brand.Size = new Size(278, 200);
            panel_Brand.TabIndex = 0;
            // 
            // label_Brand
            // 
            label_Brand.Dock = DockStyle.Bottom;
            label_Brand.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Brand.Location = new Point(0, 120);
            label_Brand.Name = "label_Brand";
            label_Brand.Size = new Size(278, 80);
            label_Brand.TabIndex = 2;
            label_Brand.Text = "Show 10 !";
            label_Brand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // icon_Brand
            // 
            icon_Brand.BackColor = SystemColors.Control;
            icon_Brand.Dock = DockStyle.Top;
            icon_Brand.ForeColor = SystemColors.ControlText;
            icon_Brand.IconChar = FontAwesome.Sharp.IconChar.Store;
            icon_Brand.IconColor = SystemColors.ControlText;
            icon_Brand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_Brand.IconSize = 120;
            icon_Brand.Location = new Point(0, 0);
            icon_Brand.Name = "icon_Brand";
            icon_Brand.Size = new Size(278, 120);
            icon_Brand.SizeMode = PictureBoxSizeMode.CenterImage;
            icon_Brand.TabIndex = 1;
            icon_Brand.TabStop = false;
            // 
            // panel_TopBar
            // 
            panel_TopBar.BorderStyle = BorderStyle.FixedSingle;
            panel_TopBar.Controls.Add(label_Clock);
            panel_TopBar.Controls.Add(icon_Fullscreen);
            panel_TopBar.Dock = DockStyle.Top;
            panel_TopBar.Location = new Point(280, 0);
            panel_TopBar.Name = "panel_TopBar";
            panel_TopBar.Size = new Size(902, 40);
            panel_TopBar.TabIndex = 3;
            // 
            // panel_ChildForm
            // 
            panel_ChildForm.Dock = DockStyle.Fill;
            panel_ChildForm.Location = new Point(280, 40);
            panel_ChildForm.Name = "panel_ChildForm";
            panel_ChildForm.Size = new Size(902, 633);
            panel_ChildForm.TabIndex = 4;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 673);
            Controls.Add(panel_ChildForm);
            Controls.Add(panel_TopBar);
            Controls.Add(panel_Menu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show 10 !";
            ((System.ComponentModel.ISupportInitialize)icon_Fullscreen).EndInit();
            panel_Menu.ResumeLayout(false);
            panel_Brand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon_Brand).EndInit();
            panel_TopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer_Clock;
        private Label label_Clock;
        private FontAwesome.Sharp.IconPictureBox icon_Fullscreen;
        private Panel panel_Menu;
        private Panel panel_Brand;
        private FontAwesome.Sharp.IconButton icon_User;
        private Panel panel_TopBar;
        private Label label_Brand;
        private FontAwesome.Sharp.IconPictureBox icon_Brand;
        private FontAwesome.Sharp.IconButton icon_Book;
        private Panel panel_ChildForm;
    }
}
