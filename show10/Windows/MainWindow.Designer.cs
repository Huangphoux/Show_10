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
        private void InitializeComponent() {
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
            checkBox_HienMK = new CheckBox();
            label_DangNhap = new Label();
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
            panel_Menu.SuspendLayout();
            panel_Brand.SuspendLayout();
            panel_Welcome.SuspendLayout();
            panel_DangNhap.SuspendLayout();
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
            icon_FullScreen.FlatStyle = FlatStyle.Flat;
            icon_FullScreen.IconChar = FontAwesome.Sharp.IconChar.Expand;
            icon_FullScreen.IconColor = Color.Black;
            icon_FullScreen.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_FullScreen.IconSize = 30;
            icon_FullScreen.Location = new Point(0, 691);
            icon_FullScreen.Name = "icon_FullScreen";
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
            icon_CaiDat.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            icon_CaiDat.FlatStyle = FlatStyle.Flat;
            icon_CaiDat.IconChar = FontAwesome.Sharp.IconChar.Cog;
            icon_CaiDat.IconColor = Color.Black;
            icon_CaiDat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_CaiDat.IconSize = 30;
            icon_CaiDat.Location = new Point(0, 771);
            icon_CaiDat.Name = "icon_CaiDat";
            icon_CaiDat.Size = new Size(278, 80);
            icon_CaiDat.TabIndex = 6;
            icon_CaiDat.Text = "Cài đặt";
            icon_CaiDat.TextAlign = ContentAlignment.MiddleRight;
            icon_CaiDat.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_CaiDat.UseVisualStyleBackColor = true;
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
            icon_BaoCao.Click += Icon_BaoCao_Click;
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
            icon_KhachHang.Click += Icon_KhachHang_Click;
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
            icon_Sach.Click += Icon_Sach_Click;
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
            icon_TaiKhoan.Click += Icon_TaiKhoan_Click;
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
            icon_Brand.Dock = DockStyle.Fill;
            icon_Brand.FlatAppearance.BorderSize = 0;
            icon_Brand.FlatStyle = FlatStyle.Flat;
            icon_Brand.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icon_Brand.IconChar = FontAwesome.Sharp.IconChar.Store;
            icon_Brand.IconColor = Color.Black;
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
            // checkBox_HienMK
            // 
            checkBox_HienMK.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBox_HienMK.Location = new Point(309, 271);
            checkBox_HienMK.Name = "checkBox_HienMK";
            checkBox_HienMK.Size = new Size(623, 54);
            checkBox_HienMK.TabIndex = 11;
            checkBox_HienMK.Text = "Hiện mật khẩu";
            checkBox_HienMK.TextAlign = ContentAlignment.MiddleCenter;
            checkBox_HienMK.UseVisualStyleBackColor = true;
            checkBox_HienMK.CheckedChanged += CheckBox_HienMK_CheckedChanged;
            // 
            // label_DangNhap
            // 
            label_DangNhap.AccessibleRole = AccessibleRole.None;
            label_DangNhap.BackColor = Color.Gainsboro;
            label_DangNhap.BorderStyle = BorderStyle.FixedSingle;
            label_DangNhap.Dock = DockStyle.Top;
            label_DangNhap.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DangNhap.Location = new Point(0, 0);
            label_DangNhap.Name = "label_DangNhap";
            label_DangNhap.Size = new Size(1302, 128);
            label_DangNhap.TabIndex = 5;
            label_DangNhap.Text = "Đăng nhập";
            label_DangNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_TenTK
            // 
            label_TenTK.Location = new Point(221, 161);
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
            checkBox_enableTab.Dock = DockStyle.Bottom;
            checkBox_enableTab.Location = new Point(0, 799);
            checkBox_enableTab.Name = "checkBox_enableTab";
            checkBox_enableTab.Size = new Size(1302, 54);
            checkBox_enableTab.TabIndex = 10;
            checkBox_enableTab.Text = "Bật các tab";
            checkBox_enableTab.TextAlign = ContentAlignment.MiddleCenter;
            checkBox_enableTab.UseVisualStyleBackColor = true;
            checkBox_enableTab.CheckedChanged += CheckBox_enableTab_CheckedChanged;
            // 
            // textBox_TenTK
            // 
            textBox_TenTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_TenTK.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TenTK.Location = new Point(386, 156);
            textBox_TenTK.MaxLength = 500;
            textBox_TenTK.Name = "textBox_TenTK";
            textBox_TenTK.Size = new Size(654, 43);
            textBox_TenTK.TabIndex = 0;
            textBox_TenTK.WordWrap = false;
            // 
            // icon_DangNhap
            // 
            icon_DangNhap.Anchor = AnchorStyles.Top;
            icon_DangNhap.BackColor = Color.FromArgb(255, 192, 128);
            icon_DangNhap.FlatAppearance.BorderSize = 0;
            icon_DangNhap.FlatStyle = FlatStyle.Flat;
            icon_DangNhap.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            icon_DangNhap.IconColor = Color.Black;
            icon_DangNhap.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_DangNhap.IconSize = 30;
            icon_DangNhap.Location = new Point(421, 335);
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
            textBox_MatKhau.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_MatKhau.Location = new Point(386, 209);
            textBox_MatKhau.MaxLength = 500;
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.PasswordChar = '•';
            textBox_MatKhau.Size = new Size(654, 43);
            textBox_MatKhau.TabIndex = 9;
            textBox_MatKhau.WordWrap = false;
            // 
            // icon_DangKy
            // 
            icon_DangKy.Anchor = AnchorStyles.Top;
            icon_DangKy.BackColor = Color.FromArgb(128, 128, 255);
            icon_DangKy.FlatAppearance.BorderSize = 0;
            icon_DangKy.FlatStyle = FlatStyle.Flat;
            icon_DangKy.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            icon_DangKy.IconColor = Color.Black;
            icon_DangKy.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_DangKy.IconSize = 30;
            icon_DangKy.Location = new Point(640, 335);
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
            label_MatKhau.Location = new Point(221, 212);
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
            label_Welcome.Dock = DockStyle.Top;
            label_Welcome.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Welcome.Location = new Point(0, 0);
            label_Welcome.Name = "label_Welcome";
            label_Welcome.Size = new Size(1302, 259);
            label_Welcome.TabIndex = 0;
            label_Welcome.Text = "Xin chào!";
            label_Welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_DangNhap
            // 
            panel_DangNhap.Controls.Add(label_MatKhau);
            panel_DangNhap.Controls.Add(icon_DangKy);
            panel_DangNhap.Controls.Add(textBox_MatKhau);
            panel_DangNhap.Controls.Add(icon_DangNhap);
            panel_DangNhap.Controls.Add(textBox_TenTK);
            panel_DangNhap.Controls.Add(checkBox_enableTab);
            panel_DangNhap.Controls.Add(label_TenTK);
            panel_DangNhap.Controls.Add(label_DangNhap);
            panel_DangNhap.Controls.Add(checkBox_HienMK);
            panel_DangNhap.Dock = DockStyle.Fill;
            panel_DangNhap.Location = new Point(280, 0);
            panel_DangNhap.Name = "panel_DangNhap";
            panel_DangNhap.Size = new Size(1302, 853);
            panel_DangNhap.TabIndex = 10;
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
            panel_DangNhap.PerformLayout();
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
        private Label label_DangNhap;
        private FontAwesome.Sharp.IconButton icon_BaoCao;
        private FontAwesome.Sharp.IconButton icon_KhachHang;
        private Panel panel_Welcome;
        private Label label_Welcome;
        private Label label_Clock;
        private FontAwesome.Sharp.IconButton icon_Brand;
        private FontAwesome.Sharp.IconButton icon_CaiDat;
        private CheckBox checkBox_HienMK;
        private Label label_TenTK;
        private CheckBox checkBox_enableTab;
        private TextBox textBox_TenTK;
        private FontAwesome.Sharp.IconButton icon_DangNhap;
        private TextBox textBox_MatKhau;
        private FontAwesome.Sharp.IconButton icon_DangKy;
        private Label label_MatKhau;
        private Panel panel_DangNhap;
    }
}
