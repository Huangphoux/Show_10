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
            panel_Menu = new Panel();
            icon_FullScreen = new FontAwesome.Sharp.IconButton();
            icon_Book = new FontAwesome.Sharp.IconButton();
            icon_User = new FontAwesome.Sharp.IconButton();
            panel_Brand = new Panel();
            icon_Brand = new FontAwesome.Sharp.IconPictureBox();
            panel_ChildForm = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            panel_Menu.SuspendLayout();
            panel_Brand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_Brand).BeginInit();
            panel_ChildForm.SuspendLayout();
            SuspendLayout();
            // 
            // timer_Clock
            // 
            timer_Clock.Enabled = true;
            timer_Clock.Interval = 1000;
            timer_Clock.Tick += Timer_Tick;
            // 
            // panel_Menu
            // 
            panel_Menu.BorderStyle = BorderStyle.FixedSingle;
            panel_Menu.Controls.Add(icon_FullScreen);
            panel_Menu.Controls.Add(icon_Book);
            panel_Menu.Controls.Add(icon_User);
            panel_Menu.Controls.Add(panel_Brand);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 0);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(280, 673);
            panel_Menu.TabIndex = 2;
            // 
            // icon_FullScreen
            // 
            icon_FullScreen.Dock = DockStyle.Bottom;
            icon_FullScreen.FlatAppearance.BorderSize = 0;
            icon_FullScreen.FlatStyle = FlatStyle.Flat;
            icon_FullScreen.IconChar = FontAwesome.Sharp.IconChar.Expand;
            icon_FullScreen.IconColor = Color.Black;
            icon_FullScreen.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_FullScreen.IconSize = 30;
            icon_FullScreen.Location = new Point(0, 591);
            icon_FullScreen.Name = "icon_FullScreen";
            icon_FullScreen.Size = new Size(278, 80);
            icon_FullScreen.TabIndex = 3;
            icon_FullScreen.Text = "Toàn màn hình";
            icon_FullScreen.TextAlign = ContentAlignment.MiddleRight;
            icon_FullScreen.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_FullScreen.UseVisualStyleBackColor = true;
            icon_FullScreen.Click += Icon_Fullscreen_Click;
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
            panel_Brand.Controls.Add(icon_Brand);
            panel_Brand.Dock = DockStyle.Top;
            panel_Brand.Location = new Point(0, 0);
            panel_Brand.Name = "panel_Brand";
            panel_Brand.Size = new Size(278, 200);
            panel_Brand.TabIndex = 0;
            // 
            // icon_Brand
            // 
            icon_Brand.BackColor = SystemColors.Control;
            icon_Brand.BorderStyle = BorderStyle.FixedSingle;
            icon_Brand.Dock = DockStyle.Fill;
            icon_Brand.ForeColor = SystemColors.ControlText;
            icon_Brand.IconChar = FontAwesome.Sharp.IconChar.Store;
            icon_Brand.IconColor = SystemColors.ControlText;
            icon_Brand.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Brand.IconSize = 200;
            icon_Brand.Location = new Point(0, 0);
            icon_Brand.Name = "icon_Brand";
            icon_Brand.Size = new Size(278, 200);
            icon_Brand.SizeMode = PictureBoxSizeMode.CenterImage;
            icon_Brand.TabIndex = 1;
            icon_Brand.TabStop = false;
            // 
            // panel_ChildForm
            // 
            panel_ChildForm.Controls.Add(iconButton2);
            panel_ChildForm.Controls.Add(iconButton1);
            panel_ChildForm.Controls.Add(label3);
            panel_ChildForm.Controls.Add(checkBox1);
            panel_ChildForm.Controls.Add(label2);
            panel_ChildForm.Controls.Add(label1);
            panel_ChildForm.Controls.Add(maskedTextBox1);
            panel_ChildForm.Controls.Add(textBox1);
            panel_ChildForm.Dock = DockStyle.Fill;
            panel_ChildForm.Location = new Point(280, 0);
            panel_ChildForm.Name = "panel_ChildForm";
            panel_ChildForm.Size = new Size(902, 673);
            panel_ChildForm.TabIndex = 4;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(360, 440);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(200, 80);
            iconButton2.TabIndex = 7;
            iconButton2.Text = "Đăng ký";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(360, 360);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(200, 80);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "Đăng nhập";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.None;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(902, 80);
            label3.TabIndex = 5;
            label3.Text = "Đăng nhập";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Location = new Point(291, 300);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(320, 40);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Tôi là quản trị viên";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Location = new Point(151, 220);
            label2.Margin = new Padding(3, 0, 20, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 40);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(151, 140);
            label1.Margin = new Padding(3, 0, 20, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 2;
            label1.Text = "Tên người dùng";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.None;
            maskedTextBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(391, 220);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PasswordChar = '•';
            maskedTextBox1.Size = new Size(360, 43);
            maskedTextBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(391, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 43);
            textBox1.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 673);
            Controls.Add(panel_ChildForm);
            Controls.Add(panel_Menu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show 10 !";
            panel_Menu.ResumeLayout(false);
            panel_Brand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon_Brand).EndInit();
            panel_ChildForm.ResumeLayout(false);
            panel_ChildForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer_Clock;
        private Panel panel_Menu;
        private Panel panel_Brand;
        private FontAwesome.Sharp.IconButton icon_User;
        private FontAwesome.Sharp.IconPictureBox icon_Brand;
        private FontAwesome.Sharp.IconButton icon_Book;
        private Panel panel_ChildForm;
        private FontAwesome.Sharp.IconButton icon_FullScreen;
        private CheckBox checkBox1;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
