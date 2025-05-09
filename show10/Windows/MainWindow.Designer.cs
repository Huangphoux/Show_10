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
            icon_BaoCao = new FontAwesome.Sharp.IconButton();
            icon_KhachHang = new FontAwesome.Sharp.IconButton();
            icon_FullScreen = new FontAwesome.Sharp.IconButton();
            icon_Sach = new FontAwesome.Sharp.IconButton();
            icon_TaiKhoan = new FontAwesome.Sharp.IconButton();
            panel_Brand = new Panel();
            icon_Brand = new FontAwesome.Sharp.IconPictureBox();
            panel_ChildForm = new Panel();
            icon_ShowPassword = new FontAwesome.Sharp.IconPictureBox();
            icon_DangKy = new FontAwesome.Sharp.IconButton();
            icon_DangNhap = new FontAwesome.Sharp.IconButton();
            label_Welcome = new Label();
            label_MatKhau = new Label();
            label_TenTK = new Label();
            maskedTextBox_MatKhau = new MaskedTextBox();
            textBox_TenTK = new TextBox();
            panel_Menu.SuspendLayout();
            panel_Brand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_Brand).BeginInit();
            panel_ChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_ShowPassword).BeginInit();
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
            panel_Menu.Controls.Add(icon_BaoCao);
            panel_Menu.Controls.Add(icon_KhachHang);
            panel_Menu.Controls.Add(icon_FullScreen);
            panel_Menu.Controls.Add(icon_Sach);
            panel_Menu.Controls.Add(icon_TaiKhoan);
            panel_Menu.Controls.Add(panel_Brand);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 0);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(280, 673);
            panel_Menu.TabIndex = 2;
            // 
            // icon_BaoCao
            // 
            icon_BaoCao.Dock = DockStyle.Top;
            icon_BaoCao.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            icon_BaoCao.FlatStyle = FlatStyle.Flat;
            icon_BaoCao.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            icon_BaoCao.IconColor = Color.Black;
            icon_BaoCao.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_BaoCao.IconSize = 30;
            icon_BaoCao.Location = new Point(0, 440);
            icon_BaoCao.Name = "icon_BaoCao";
            icon_BaoCao.Size = new Size(278, 80);
            icon_BaoCao.TabIndex = 5;
            icon_BaoCao.Text = "Báo cáo";
            icon_BaoCao.TextAlign = ContentAlignment.MiddleRight;
            icon_BaoCao.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_BaoCao.UseVisualStyleBackColor = true;
            // 
            // icon_KhachHang
            // 
            icon_KhachHang.Dock = DockStyle.Top;
            icon_KhachHang.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            icon_KhachHang.FlatStyle = FlatStyle.Flat;
            icon_KhachHang.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            icon_KhachHang.IconColor = Color.Black;
            icon_KhachHang.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_KhachHang.IconSize = 30;
            icon_KhachHang.Location = new Point(0, 360);
            icon_KhachHang.Name = "icon_KhachHang";
            icon_KhachHang.Size = new Size(278, 80);
            icon_KhachHang.TabIndex = 4;
            icon_KhachHang.Text = "Khách hàng";
            icon_KhachHang.TextAlign = ContentAlignment.MiddleRight;
            icon_KhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_KhachHang.UseVisualStyleBackColor = true;
            // 
            // icon_FullScreen
            // 
            icon_FullScreen.Dock = DockStyle.Bottom;
            icon_FullScreen.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
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
            // icon_Sach
            // 
            icon_Sach.Dock = DockStyle.Top;
            icon_Sach.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            icon_Sach.FlatStyle = FlatStyle.Flat;
            icon_Sach.IconChar = FontAwesome.Sharp.IconChar.Book;
            icon_Sach.IconColor = Color.Black;
            icon_Sach.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Sach.IconSize = 30;
            icon_Sach.Location = new Point(0, 280);
            icon_Sach.Name = "icon_Sach";
            icon_Sach.Size = new Size(278, 80);
            icon_Sach.TabIndex = 2;
            icon_Sach.Text = "Sách";
            icon_Sach.TextAlign = ContentAlignment.MiddleRight;
            icon_Sach.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_Sach.UseVisualStyleBackColor = true;
            icon_Sach.Click += Icon_Book_Click;
            // 
            // icon_TaiKhoan
            // 
            icon_TaiKhoan.Dock = DockStyle.Top;
            icon_TaiKhoan.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            icon_TaiKhoan.FlatStyle = FlatStyle.Flat;
            icon_TaiKhoan.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            icon_TaiKhoan.IconColor = Color.Black;
            icon_TaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_TaiKhoan.IconSize = 30;
            icon_TaiKhoan.Location = new Point(0, 200);
            icon_TaiKhoan.Name = "icon_TaiKhoan";
            icon_TaiKhoan.Size = new Size(278, 80);
            icon_TaiKhoan.TabIndex = 1;
            icon_TaiKhoan.Text = "Tài khoản";
            icon_TaiKhoan.TextAlign = ContentAlignment.MiddleRight;
            icon_TaiKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_TaiKhoan.UseVisualStyleBackColor = true;
            icon_TaiKhoan.Click += Icon_User_Click;
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
            panel_ChildForm.Controls.Add(icon_ShowPassword);
            panel_ChildForm.Controls.Add(icon_DangKy);
            panel_ChildForm.Controls.Add(icon_DangNhap);
            panel_ChildForm.Controls.Add(label_Welcome);
            panel_ChildForm.Controls.Add(label_MatKhau);
            panel_ChildForm.Controls.Add(label_TenTK);
            panel_ChildForm.Controls.Add(maskedTextBox_MatKhau);
            panel_ChildForm.Controls.Add(textBox_TenTK);
            panel_ChildForm.Dock = DockStyle.Fill;
            panel_ChildForm.Location = new Point(280, 0);
            panel_ChildForm.Name = "panel_ChildForm";
            panel_ChildForm.Size = new Size(902, 673);
            panel_ChildForm.TabIndex = 4;
            // 
            // icon_ShowPassword
            // 
            icon_ShowPassword.BackColor = SystemColors.Control;
            icon_ShowPassword.ForeColor = SystemColors.ControlText;
            icon_ShowPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            icon_ShowPassword.IconColor = SystemColors.ControlText;
            icon_ShowPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_ShowPassword.IconSize = 40;
            icon_ShowPassword.Location = new Point(634, 189);
            icon_ShowPassword.Name = "icon_ShowPassword";
            icon_ShowPassword.Size = new Size(59, 40);
            icon_ShowPassword.TabIndex = 8;
            icon_ShowPassword.TabStop = false;
            icon_ShowPassword.Click += Icon_ShowPassword_Click;
            // 
            // icon_DangKy
            // 
            icon_DangKy.FlatAppearance.BorderSize = 0;
            icon_DangKy.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            icon_DangKy.IconColor = Color.Black;
            icon_DangKy.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_DangKy.IconSize = 30;
            icon_DangKy.Location = new Point(428, 281);
            icon_DangKy.Name = "icon_DangKy";
            icon_DangKy.Size = new Size(200, 80);
            icon_DangKy.TabIndex = 7;
            icon_DangKy.Text = "Đăng ký";
            icon_DangKy.TextAlign = ContentAlignment.MiddleRight;
            icon_DangKy.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_DangKy.UseVisualStyleBackColor = true;
            // 
            // icon_DangNhap
            // 
            icon_DangNhap.FlatAppearance.BorderSize = 0;
            icon_DangNhap.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            icon_DangNhap.IconColor = Color.Black;
            icon_DangNhap.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_DangNhap.IconSize = 30;
            icon_DangNhap.Location = new Point(222, 281);
            icon_DangNhap.Name = "icon_DangNhap";
            icon_DangNhap.Size = new Size(200, 80);
            icon_DangNhap.TabIndex = 6;
            icon_DangNhap.Text = "Đăng nhập";
            icon_DangNhap.TextAlign = ContentAlignment.MiddleRight;
            icon_DangNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_DangNhap.UseVisualStyleBackColor = true;
            // 
            // label_Welcome
            // 
            label_Welcome.AccessibleRole = AccessibleRole.None;
            label_Welcome.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Welcome.Location = new Point(0, 0);
            label_Welcome.Name = "label_Welcome";
            label_Welcome.Size = new Size(902, 80);
            label_Welcome.TabIndex = 5;
            label_Welcome.Text = "Đăng nhập";
            label_Welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_MatKhau
            // 
            label_MatKhau.Anchor = AnchorStyles.None;
            label_MatKhau.Location = new Point(222, 189);
            label_MatKhau.Margin = new Padding(3, 0, 20, 0);
            label_MatKhau.Name = "label_MatKhau";
            label_MatKhau.Size = new Size(142, 40);
            label_MatKhau.TabIndex = 3;
            label_MatKhau.Text = "Mật khẩu";
            label_MatKhau.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_TenTK
            // 
            label_TenTK.Anchor = AnchorStyles.None;
            label_TenTK.Location = new Point(222, 128);
            label_TenTK.Margin = new Padding(3, 0, 20, 0);
            label_TenTK.Name = "label_TenTK";
            label_TenTK.Size = new Size(142, 40);
            label_TenTK.TabIndex = 2;
            label_TenTK.Text = "Tên tài khoản";
            label_TenTK.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // maskedTextBox_MatKhau
            // 
            maskedTextBox_MatKhau.Anchor = AnchorStyles.None;
            maskedTextBox_MatKhau.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox_MatKhau.Location = new Point(374, 189);
            maskedTextBox_MatKhau.Name = "maskedTextBox_MatKhau";
            maskedTextBox_MatKhau.PasswordChar = '•';
            maskedTextBox_MatKhau.Size = new Size(254, 43);
            maskedTextBox_MatKhau.TabIndex = 1;
            // 
            // textBox_TenTK
            // 
            textBox_TenTK.Anchor = AnchorStyles.None;
            textBox_TenTK.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TenTK.Location = new Point(374, 128);
            textBox_TenTK.Name = "textBox_TenTK";
            textBox_TenTK.Size = new Size(254, 43);
            textBox_TenTK.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)icon_ShowPassword).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer_Clock;
        private Panel panel_Menu;
        private Panel panel_Brand;
        private FontAwesome.Sharp.IconButton icon_TaiKhoan;
        private FontAwesome.Sharp.IconPictureBox icon_Brand;
        private FontAwesome.Sharp.IconButton icon_Sach;
        private Panel panel_ChildForm;
        private FontAwesome.Sharp.IconButton icon_FullScreen;
        private Label label_MatKhau;
        private Label label_TenTK;
        private MaskedTextBox maskedTextBox_MatKhau;
        private TextBox textBox_TenTK;
        private Label label_Welcome;
        private FontAwesome.Sharp.IconButton icon_DangNhap;
        private FontAwesome.Sharp.IconButton icon_DangKy;
        private FontAwesome.Sharp.IconPictureBox icon_ShowPassword;
        private FontAwesome.Sharp.IconButton icon_BaoCao;
        private FontAwesome.Sharp.IconButton icon_KhachHang;
    }
}
