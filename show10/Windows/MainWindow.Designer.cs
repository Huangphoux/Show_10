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
            icon_CaiDat = new FontAwesome.Sharp.IconButton();
            icon_BaoCao = new FontAwesome.Sharp.IconButton();
            icon_KhachHang = new FontAwesome.Sharp.IconButton();
            icon_Sach = new FontAwesome.Sharp.IconButton();
            icon_TaiKhoan = new FontAwesome.Sharp.IconButton();
            panel_Brand = new Panel();
            icon_Brand = new FontAwesome.Sharp.IconButton();
            panel_ChildForm = new Panel();
            label_ChaoDon = new Label();
            label_TenTK = new Label();
            checkBox_enableTab = new CheckBox();
            textBox_TenTK = new TextBox();
            icon_DangNhap = new FontAwesome.Sharp.IconButton();
            textBox_MatKhau = new TextBox();
            icon_DangKy = new FontAwesome.Sharp.IconButton();
            label_MatKhau = new Label();
            panel_Welcome = new Panel();
            label_Clock = new Label();
            label_Welcome = new Label();
            panel_DangNhap = new Panel();
            panel1 = new Panel();
            icon_ShowPass = new FontAwesome.Sharp.IconPictureBox();
            label_DangNhap = new Label();
            panel_Menu.SuspendLayout();
            panel_Brand.SuspendLayout();
            panel_Welcome.SuspendLayout();
            panel_DangNhap.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_ShowPass).BeginInit();
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
            panel_Menu.AutoScroll = true;
            panel_Menu.BackColor = Color.Green;
            panel_Menu.BorderStyle = BorderStyle.FixedSingle;
            panel_Menu.Controls.Add(icon_FullScreen);
            panel_Menu.Controls.Add(icon_CaiDat);
            panel_Menu.Controls.Add(icon_BaoCao);
            panel_Menu.Controls.Add(icon_KhachHang);
            panel_Menu.Controls.Add(icon_Sach);
            panel_Menu.Controls.Add(icon_TaiKhoan);
            panel_Menu.Controls.Add(panel_Brand);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 0);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(280, 853);
            panel_Menu.TabIndex = 2;
            // 
            // icon_FullScreen
            // 
            icon_FullScreen.Dock = DockStyle.Bottom;
            icon_FullScreen.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            icon_FullScreen.FlatAppearance.BorderSize = 0;
            icon_FullScreen.FlatStyle = FlatStyle.Flat;
            icon_FullScreen.ForeColor = Color.White;
            icon_FullScreen.IconChar = FontAwesome.Sharp.IconChar.Expand;
            icon_FullScreen.IconColor = Color.White;
            icon_FullScreen.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_FullScreen.IconSize = 30;
            icon_FullScreen.ImageAlign = ContentAlignment.MiddleLeft;
            icon_FullScreen.Location = new Point(0, 691);
            icon_FullScreen.Margin = new Padding(0);
            icon_FullScreen.Name = "icon_FullScreen";
            icon_FullScreen.Padding = new Padding(50, 0, 0, 0);
            icon_FullScreen.Size = new Size(278, 80);
            icon_FullScreen.TabIndex = 3;
            icon_FullScreen.Text = "Toàn màn hình";
            icon_FullScreen.TextAlign = ContentAlignment.MiddleRight;
            icon_FullScreen.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_FullScreen.UseVisualStyleBackColor = true;
            icon_FullScreen.Click += Icon_Fullscreen_Click;
            // 
            // icon_CaiDat
            // 
            icon_CaiDat.Dock = DockStyle.Bottom;
            icon_CaiDat.Enabled = false;
            icon_CaiDat.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            icon_CaiDat.FlatAppearance.BorderSize = 0;
            icon_CaiDat.FlatStyle = FlatStyle.Flat;
            icon_CaiDat.ForeColor = Color.White;
            icon_CaiDat.IconChar = FontAwesome.Sharp.IconChar.Cog;
            icon_CaiDat.IconColor = Color.White;
            icon_CaiDat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_CaiDat.IconSize = 30;
            icon_CaiDat.ImageAlign = ContentAlignment.MiddleLeft;
            icon_CaiDat.Location = new Point(0, 771);
            icon_CaiDat.Margin = new Padding(0);
            icon_CaiDat.Name = "icon_CaiDat";
            icon_CaiDat.Padding = new Padding(50, 0, 0, 0);
            icon_CaiDat.Size = new Size(278, 80);
            icon_CaiDat.TabIndex = 6;
            icon_CaiDat.Text = "Cài đặt";
            icon_CaiDat.TextAlign = ContentAlignment.MiddleRight;
            icon_CaiDat.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_CaiDat.UseVisualStyleBackColor = true;
            icon_CaiDat.Click += icon_CaiDat_Click;
            // 
            // icon_BaoCao
            // 
            icon_BaoCao.Dock = DockStyle.Top;
            icon_BaoCao.FlatAppearance.BorderColor = Color.Khaki;
            icon_BaoCao.FlatAppearance.BorderSize = 0;
            icon_BaoCao.FlatStyle = FlatStyle.Flat;
            icon_BaoCao.ForeColor = Color.White;
            icon_BaoCao.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            icon_BaoCao.IconColor = Color.White;
            icon_BaoCao.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_BaoCao.IconSize = 30;
            icon_BaoCao.ImageAlign = ContentAlignment.MiddleLeft;
            icon_BaoCao.Location = new Point(0, 440);
            icon_BaoCao.Name = "icon_BaoCao";
            icon_BaoCao.Padding = new Padding(50, 0, 0, 0);
            icon_BaoCao.Size = new Size(278, 80);
            icon_BaoCao.TabIndex = 5;
            icon_BaoCao.Text = "Báo cáo";
            icon_BaoCao.TextAlign = ContentAlignment.MiddleRight;
            icon_BaoCao.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_BaoCao.UseVisualStyleBackColor = true;
            icon_BaoCao.Click += Icon_BaoCao_Click;
            // 
            // icon_KhachHang
            // 
            icon_KhachHang.Dock = DockStyle.Top;
            icon_KhachHang.FlatAppearance.BorderColor = Color.Khaki;
            icon_KhachHang.FlatAppearance.BorderSize = 0;
            icon_KhachHang.FlatStyle = FlatStyle.Flat;
            icon_KhachHang.ForeColor = Color.White;
            icon_KhachHang.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            icon_KhachHang.IconColor = Color.White;
            icon_KhachHang.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_KhachHang.IconSize = 30;
            icon_KhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            icon_KhachHang.Location = new Point(0, 360);
            icon_KhachHang.Name = "icon_KhachHang";
            icon_KhachHang.Padding = new Padding(50, 0, 0, 0);
            icon_KhachHang.Size = new Size(278, 80);
            icon_KhachHang.TabIndex = 4;
            icon_KhachHang.Text = "Khách hàng";
            icon_KhachHang.TextAlign = ContentAlignment.MiddleRight;
            icon_KhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_KhachHang.UseVisualStyleBackColor = true;
            icon_KhachHang.Click += Icon_KhachHang_Click;
            // 
            // icon_Sach
            // 
            icon_Sach.Dock = DockStyle.Top;
            icon_Sach.FlatAppearance.BorderColor = Color.Khaki;
            icon_Sach.FlatAppearance.BorderSize = 0;
            icon_Sach.FlatStyle = FlatStyle.Flat;
            icon_Sach.ForeColor = Color.White;
            icon_Sach.IconChar = FontAwesome.Sharp.IconChar.Book;
            icon_Sach.IconColor = Color.White;
            icon_Sach.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Sach.IconSize = 30;
            icon_Sach.ImageAlign = ContentAlignment.MiddleLeft;
            icon_Sach.Location = new Point(0, 280);
            icon_Sach.Name = "icon_Sach";
            icon_Sach.Padding = new Padding(50, 0, 0, 0);
            icon_Sach.Size = new Size(278, 80);
            icon_Sach.TabIndex = 2;
            icon_Sach.Text = "Sách";
            icon_Sach.TextAlign = ContentAlignment.MiddleRight;
            icon_Sach.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_Sach.UseVisualStyleBackColor = true;
            icon_Sach.Click += Icon_Sach_Click;
            // 
            // icon_TaiKhoan
            // 
            icon_TaiKhoan.Dock = DockStyle.Top;
            icon_TaiKhoan.FlatAppearance.BorderColor = Color.Khaki;
            icon_TaiKhoan.FlatAppearance.BorderSize = 0;
            icon_TaiKhoan.FlatStyle = FlatStyle.Flat;
            icon_TaiKhoan.ForeColor = Color.White;
            icon_TaiKhoan.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            icon_TaiKhoan.IconColor = Color.White;
            icon_TaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_TaiKhoan.IconSize = 30;
            icon_TaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            icon_TaiKhoan.Location = new Point(0, 200);
            icon_TaiKhoan.Name = "icon_TaiKhoan";
            icon_TaiKhoan.Padding = new Padding(50, 0, 0, 0);
            icon_TaiKhoan.Size = new Size(278, 80);
            icon_TaiKhoan.TabIndex = 1;
            icon_TaiKhoan.Text = "Tài khoản";
            icon_TaiKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_TaiKhoan.UseVisualStyleBackColor = true;
            icon_TaiKhoan.Click += Icon_TaiKhoan_Click;
            // 
            // panel_Brand
            // 
            panel_Brand.Controls.Add(icon_Brand);
            panel_Brand.Dock = DockStyle.Top;
            panel_Brand.ForeColor = Color.White;
            panel_Brand.Location = new Point(0, 0);
            panel_Brand.Name = "panel_Brand";
            panel_Brand.Size = new Size(278, 200);
            panel_Brand.TabIndex = 0;
            // 
            // icon_Brand
            // 
            icon_Brand.Dock = DockStyle.Fill;
            icon_Brand.FlatAppearance.BorderSize = 0;
            icon_Brand.FlatStyle = FlatStyle.Flat;
            icon_Brand.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icon_Brand.IconChar = FontAwesome.Sharp.IconChar.Store;
            icon_Brand.IconColor = Color.White;
            icon_Brand.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Brand.IconSize = 120;
            icon_Brand.Location = new Point(0, 0);
            icon_Brand.Name = "icon_Brand";
            icon_Brand.Size = new Size(278, 200);
            icon_Brand.TabIndex = 9;
            icon_Brand.Text = "Show 10 !";
            icon_Brand.TextAlign = ContentAlignment.BottomCenter;
            icon_Brand.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_Brand.UseVisualStyleBackColor = true;
            icon_Brand.Click += Icon_Brand_Click;
            // 
            // panel_ChildForm
            // 
            panel_ChildForm.Dock = DockStyle.Fill;
            panel_ChildForm.Location = new Point(280, 0);
            panel_ChildForm.Name = "panel_ChildForm";
            panel_ChildForm.Size = new Size(1302, 853);
            panel_ChildForm.TabIndex = 4;
            // 
            // label_ChaoDon
            // 
            label_ChaoDon.AccessibleRole = AccessibleRole.None;
            label_ChaoDon.BackColor = Color.Green;
            label_ChaoDon.BorderStyle = BorderStyle.FixedSingle;
            label_ChaoDon.Dock = DockStyle.Top;
            label_ChaoDon.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ChaoDon.ForeColor = Color.White;
            label_ChaoDon.Location = new Point(0, 0);
            label_ChaoDon.Name = "label_ChaoDon";
            label_ChaoDon.Size = new Size(591, 128);
            label_ChaoDon.TabIndex = 5;
            label_ChaoDon.Text = "Xin được chào đón !";
            label_ChaoDon.TextAlign = ContentAlignment.MiddleCenter;
            label_ChaoDon.Click += Label_ChaoDon_Click;
            // 
            // label_TenTK
            // 
            label_TenTK.Location = new Point(107, 242);
            label_TenTK.Margin = new Padding(3, 0, 20, 0);
            label_TenTK.Name = "label_TenTK";
            label_TenTK.Size = new Size(142, 40);
            label_TenTK.TabIndex = 2;
            label_TenTK.Text = "Tên tài khoản";
            label_TenTK.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBox_enableTab
            // 
            checkBox_enableTab.Appearance = Appearance.Button;
            checkBox_enableTab.FlatStyle = FlatStyle.Flat;
            checkBox_enableTab.Location = new Point(107, 689);
            checkBox_enableTab.Name = "checkBox_enableTab";
            checkBox_enableTab.Size = new Size(424, 83);
            checkBox_enableTab.TabIndex = 10;
            checkBox_enableTab.Text = "Bật các tab";
            checkBox_enableTab.TextAlign = ContentAlignment.MiddleCenter;
            checkBox_enableTab.UseVisualStyleBackColor = true;
            checkBox_enableTab.CheckedChanged += CheckBox_enableTab_CheckedChanged;
            // 
            // textBox_TenTK
            // 
            textBox_TenTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_TenTK.Font = new Font("Segoe UI", 12F);
            textBox_TenTK.Location = new Point(272, 247);
            textBox_TenTK.MaxLength = 500;
            textBox_TenTK.Name = "textBox_TenTK";
            textBox_TenTK.Size = new Size(259, 34);
            textBox_TenTK.TabIndex = 0;
            textBox_TenTK.WordWrap = false;
            // 
            // icon_DangNhap
            // 
            icon_DangNhap.Anchor = AnchorStyles.Top;
            icon_DangNhap.BackColor = Color.Green;
            icon_DangNhap.FlatAppearance.BorderSize = 0;
            icon_DangNhap.FlatStyle = FlatStyle.Flat;
            icon_DangNhap.ForeColor = Color.White;
            icon_DangNhap.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            icon_DangNhap.IconColor = Color.White;
            icon_DangNhap.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_DangNhap.IconSize = 30;
            icon_DangNhap.Location = new Point(107, 396);
            icon_DangNhap.Name = "icon_DangNhap";
            icon_DangNhap.Size = new Size(200, 80);
            icon_DangNhap.TabIndex = 6;
            icon_DangNhap.Text = "Đăng nhập";
            icon_DangNhap.TextAlign = ContentAlignment.MiddleRight;
            icon_DangNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_DangNhap.UseVisualStyleBackColor = false;
            icon_DangNhap.Click += Icon_DangNhap_Click;
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_MatKhau.Font = new Font("Segoe UI", 12F);
            textBox_MatKhau.Location = new Point(272, 305);
            textBox_MatKhau.MaxLength = 500;
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.PasswordChar = '•';
            textBox_MatKhau.Size = new Size(259, 34);
            textBox_MatKhau.TabIndex = 9;
            textBox_MatKhau.WordWrap = false;
            // 
            // icon_DangKy
            // 
            icon_DangKy.Anchor = AnchorStyles.Top;
            icon_DangKy.BackColor = Color.Transparent;
            icon_DangKy.FlatStyle = FlatStyle.Flat;
            icon_DangKy.ForeColor = Color.Green;
            icon_DangKy.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            icon_DangKy.IconColor = Color.Green;
            icon_DangKy.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_DangKy.IconSize = 30;
            icon_DangKy.Location = new Point(331, 396);
            icon_DangKy.Name = "icon_DangKy";
            icon_DangKy.Size = new Size(200, 80);
            icon_DangKy.TabIndex = 7;
            icon_DangKy.Text = "Đăng ký";
            icon_DangKy.TextAlign = ContentAlignment.MiddleRight;
            icon_DangKy.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_DangKy.UseVisualStyleBackColor = false;
            icon_DangKy.Click += Icon_DangKy_Click;
            // 
            // label_MatKhau
            // 
            label_MatKhau.Location = new Point(107, 302);
            label_MatKhau.Margin = new Padding(3, 0, 20, 0);
            label_MatKhau.Name = "label_MatKhau";
            label_MatKhau.Size = new Size(142, 40);
            label_MatKhau.TabIndex = 3;
            label_MatKhau.Text = "Mật khẩu";
            label_MatKhau.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_Welcome
            // 
            panel_Welcome.Controls.Add(label_Clock);
            panel_Welcome.Controls.Add(label_Welcome);
            panel_Welcome.Dock = DockStyle.Fill;
            panel_Welcome.Location = new Point(280, 0);
            panel_Welcome.Name = "panel_Welcome";
            panel_Welcome.Size = new Size(1302, 853);
            panel_Welcome.TabIndex = 9;
            // 
            // label_Clock
            // 
            label_Clock.BackColor = Color.White;
            label_Clock.Dock = DockStyle.Fill;
            label_Clock.Location = new Point(0, 259);
            label_Clock.Name = "label_Clock";
            label_Clock.Size = new Size(1302, 594);
            label_Clock.TabIndex = 1;
            label_Clock.Text = "Bây giờ là mấy giờ?";
            label_Clock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Welcome
            // 
            label_Welcome.BackColor = Color.Green;
            label_Welcome.Dock = DockStyle.Top;
            label_Welcome.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Welcome.ForeColor = Color.White;
            label_Welcome.Location = new Point(0, 0);
            label_Welcome.Name = "label_Welcome";
            label_Welcome.Size = new Size(1302, 259);
            label_Welcome.TabIndex = 0;
            label_Welcome.Text = "Xin chào!";
            label_Welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_DangNhap
            // 
            panel_DangNhap.Controls.Add(panel1);
            panel_DangNhap.Dock = DockStyle.Fill;
            panel_DangNhap.Location = new Point(280, 0);
            panel_DangNhap.Name = "panel_DangNhap";
            panel_DangNhap.Size = new Size(1302, 853);
            panel_DangNhap.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(icon_ShowPass);
            panel1.Controls.Add(label_DangNhap);
            panel1.Controls.Add(label_TenTK);
            panel1.Controls.Add(checkBox_enableTab);
            panel1.Controls.Add(label_ChaoDon);
            panel1.Controls.Add(icon_DangKy);
            panel1.Controls.Add(label_MatKhau);
            panel1.Controls.Add(textBox_MatKhau);
            panel1.Controls.Add(textBox_TenTK);
            panel1.Controls.Add(icon_DangNhap);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(711, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 853);
            panel1.TabIndex = 12;
            // 
            // icon_ShowPass
            // 
            icon_ShowPass.BackColor = Color.White;
            icon_ShowPass.ForeColor = Color.Green;
            icon_ShowPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            icon_ShowPass.IconColor = Color.Green;
            icon_ShowPass.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_ShowPass.IconSize = 40;
            icon_ShowPass.Location = new Point(537, 302);
            icon_ShowPass.Name = "icon_ShowPass";
            icon_ShowPass.Size = new Size(40, 40);
            icon_ShowPass.TabIndex = 13;
            icon_ShowPass.TabStop = false;
            icon_ShowPass.Click += icon_ShowPass_Click;
            // 
            // label_DangNhap
            // 
            label_DangNhap.Dock = DockStyle.Top;
            label_DangNhap.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DangNhap.ForeColor = Color.Green;
            label_DangNhap.Location = new Point(0, 128);
            label_DangNhap.Name = "label_DangNhap";
            label_DangNhap.Size = new Size(591, 116);
            label_DangNhap.TabIndex = 12;
            label_DangNhap.Text = "Đăng nhập !";
            label_DangNhap.TextAlign = ContentAlignment.MiddleCenter;
            label_DangNhap.Click += Label_DangNhap_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel_Welcome);
            Controls.Add(panel_DangNhap);
            Controls.Add(panel_ChildForm);
            Controls.Add(panel_Menu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show 10 !";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            panel_Menu.ResumeLayout(false);
            panel_Brand.ResumeLayout(false);
            panel_Welcome.ResumeLayout(false);
            panel_DangNhap.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon_ShowPass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer_Clock;
        private Panel panel_Menu;
        private Panel panel_Brand;
        private FontAwesome.Sharp.IconButton icon_TaiKhoan;
        private FontAwesome.Sharp.IconButton icon_Sach;
        private Panel panel_ChildForm;
        private FontAwesome.Sharp.IconButton icon_FullScreen;
        private Label label_ChaoDon;
        private FontAwesome.Sharp.IconButton icon_BaoCao;
        private FontAwesome.Sharp.IconButton icon_KhachHang;
        private Panel panel_Welcome;
        private Label label_Welcome;
        private Label label_Clock;
        private FontAwesome.Sharp.IconButton icon_Brand;
        private FontAwesome.Sharp.IconButton icon_CaiDat;
        private Label label_TenTK;
        private CheckBox checkBox_enableTab;
        private TextBox textBox_TenTK;
        private FontAwesome.Sharp.IconButton icon_DangNhap;
        private TextBox textBox_MatKhau;
        private FontAwesome.Sharp.IconButton icon_DangKy;
        private Label label_MatKhau;
        private Panel panel_DangNhap;
        private Panel panel1;
        private Label label_DangNhap;
        private FontAwesome.Sharp.IconPictureBox icon_ShowPass;
    }
}
