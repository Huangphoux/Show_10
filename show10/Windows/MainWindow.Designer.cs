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
            label_TabName = new Label();
            panel_Menu.SuspendLayout();
            panel_Brand.SuspendLayout();
            panel_ChildForm.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Menu
            // 
            panel_Menu.AutoScroll = true;
            panel_Menu.BackColor = Color.Green;
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
            icon_FullScreen.Location = new Point(0, 693);
            icon_FullScreen.Margin = new Padding(0);
            icon_FullScreen.Name = "icon_FullScreen";
            icon_FullScreen.Padding = new Padding(50, 0, 0, 0);
            icon_FullScreen.Size = new Size(280, 80);
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
            icon_CaiDat.Location = new Point(0, 773);
            icon_CaiDat.Margin = new Padding(0);
            icon_CaiDat.Name = "icon_CaiDat";
            icon_CaiDat.Padding = new Padding(50, 0, 0, 0);
            icon_CaiDat.Size = new Size(280, 80);
            icon_CaiDat.TabIndex = 6;
            icon_CaiDat.Text = "Cài đặt";
            icon_CaiDat.TextAlign = ContentAlignment.MiddleRight;
            icon_CaiDat.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_CaiDat.UseVisualStyleBackColor = true;
            icon_CaiDat.Click += Icon_CaiDat_Click;
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
            icon_BaoCao.Size = new Size(280, 80);
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
            icon_KhachHang.Size = new Size(280, 80);
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
            icon_Sach.Size = new Size(280, 80);
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
            icon_TaiKhoan.Size = new Size(280, 80);
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
            panel_Brand.Size = new Size(280, 200);
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
            icon_Brand.Size = new Size(280, 200);
            icon_Brand.TabIndex = 9;
            icon_Brand.Text = "Show 10 !";
            icon_Brand.TextAlign = ContentAlignment.BottomCenter;
            icon_Brand.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_Brand.UseVisualStyleBackColor = true;
            icon_Brand.Click += Icon_Brand_Click;
            // 
            // panel_ChildForm
            // 
            panel_ChildForm.Controls.Add(label_TabName);
            panel_ChildForm.Dock = DockStyle.Fill;
            panel_ChildForm.Location = new Point(280, 0);
            panel_ChildForm.Name = "panel_ChildForm";
            panel_ChildForm.Size = new Size(1302, 853);
            panel_ChildForm.TabIndex = 4;
            // 
            // label_TabName
            // 
            label_TabName.BackColor = Color.Green;
            label_TabName.Dock = DockStyle.Top;
            label_TabName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TabName.ForeColor = Color.White;
            label_TabName.Location = new Point(0, 0);
            label_TabName.Name = "label_TabName";
            label_TabName.Size = new Size(1302, 50);
            label_TabName.TabIndex = 0;
            label_TabName.Text = "(Chưa chọn tab)";
            label_TabName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel_ChildForm);
            Controls.Add(panel_Menu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show 10 !";
            panel_Menu.ResumeLayout(false);
            panel_Brand.ResumeLayout(false);
            panel_ChildForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_Menu;
        private Panel panel_Brand;
        private FontAwesome.Sharp.IconButton icon_TaiKhoan;
        private FontAwesome.Sharp.IconButton icon_Sach;
        private Panel panel_ChildForm;
        private FontAwesome.Sharp.IconButton icon_FullScreen;
        private FontAwesome.Sharp.IconButton icon_BaoCao;
        private FontAwesome.Sharp.IconButton icon_KhachHang;
        private FontAwesome.Sharp.IconButton icon_Brand;
        private FontAwesome.Sharp.IconButton icon_CaiDat;
        private Label label_TabName;
    }
}
