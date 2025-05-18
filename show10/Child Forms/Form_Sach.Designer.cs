namespace Show10.Child_Forms {
    partial class Form_Sach {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            groupBox_Sach = new GroupBox();
            icon_Sach_Clear = new FontAwesome.Sharp.IconButton();
            icon_Sach_Ban = new FontAwesome.Sharp.IconButton();
            icon_Sach_Nhap = new FontAwesome.Sharp.IconButton();
            textBox_TheLoai = new TextBox();
            label_TheLoai = new Label();
            textBox_SoLuong = new TextBox();
            label_SoLuong = new Label();
            icon_Sach_Loc = new FontAwesome.Sharp.IconButton();
            icon_Sach_Tim = new FontAwesome.Sharp.IconButton();
            textBox_Sach_TacGia = new TextBox();
            textBox_Sach_TenSach = new TextBox();
            label_Sach_TacGia = new Label();
            label_Sach_TenSach = new Label();
            label_Sach_MaSach = new Label();
            textBox_Sach_MaSach = new TextBox();
            icon_Sach_Xoa = new FontAwesome.Sharp.IconButton();
            icon_Sach_Them = new FontAwesome.Sharp.IconButton();
            sachBindingSource = new BindingSource(components);
            dataGridView_Sach = new DataGridView();
            dataGridViewTextBoxColumn_MaSach = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn_SoLuong = new DataGridViewTextBoxColumn();
            tabControl_Sach = new TabControl();
            tabPage_QuanLiSach = new TabPage();
            tabPage_PhieuNhapSach = new TabPage();
            dataGridView_PhieuNhapSach = new DataGridView();
            phieuNhapSachBindingSource = new BindingSource(components);
            groupBox_PhieuNhapSach = new GroupBox();
            date_PNS_NgayNhap = new DateTimePicker();
            icon_PNS_Clear = new FontAwesome.Sharp.IconButton();
            label_PNS_NgayNhap = new Label();
            textBox_PNS_GiaNhap = new TextBox();
            label_PNS_GiaNhap = new Label();
            icon_PNS_Loc = new FontAwesome.Sharp.IconButton();
            icon_PNS_Tim = new FontAwesome.Sharp.IconButton();
            textBox_PNS_SoLuong = new TextBox();
            textBox_PNS_MaSach = new TextBox();
            label_PNS_SoLuong = new Label();
            label_PNS_MaSach = new Label();
            label_PNS_MaPhieu = new Label();
            textBox_PNS_MaPhieu = new TextBox();
            icon_PNS_Xoa = new FontAwesome.Sharp.IconButton();
            icon_PNS_Them = new FontAwesome.Sharp.IconButton();
            tabPage_HoaDonBanSach = new TabPage();
            dataGridViewTextBoxColumn_TheLoai = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn_TacGia = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn_TenSach = new DataGridViewTextBoxColumn();
            maPNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maSachDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaNhapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngayNhapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox_Sach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sachBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Sach).BeginInit();
            tabControl_Sach.SuspendLayout();
            tabPage_QuanLiSach.SuspendLayout();
            tabPage_PhieuNhapSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_PhieuNhapSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phieuNhapSachBindingSource).BeginInit();
            groupBox_PhieuNhapSach.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Sach
            // 
            groupBox_Sach.Controls.Add(icon_Sach_Clear);
            groupBox_Sach.Controls.Add(icon_Sach_Ban);
            groupBox_Sach.Controls.Add(icon_Sach_Nhap);
            groupBox_Sach.Controls.Add(textBox_TheLoai);
            groupBox_Sach.Controls.Add(label_TheLoai);
            groupBox_Sach.Controls.Add(textBox_SoLuong);
            groupBox_Sach.Controls.Add(label_SoLuong);
            groupBox_Sach.Controls.Add(icon_Sach_Loc);
            groupBox_Sach.Controls.Add(icon_Sach_Tim);
            groupBox_Sach.Controls.Add(textBox_Sach_TacGia);
            groupBox_Sach.Controls.Add(textBox_Sach_TenSach);
            groupBox_Sach.Controls.Add(label_Sach_TacGia);
            groupBox_Sach.Controls.Add(label_Sach_TenSach);
            groupBox_Sach.Controls.Add(label_Sach_MaSach);
            groupBox_Sach.Controls.Add(textBox_Sach_MaSach);
            groupBox_Sach.Controls.Add(icon_Sach_Xoa);
            groupBox_Sach.Controls.Add(icon_Sach_Them);
            groupBox_Sach.Dock = DockStyle.Top;
            groupBox_Sach.Location = new Point(4, 4);
            groupBox_Sach.Margin = new Padding(4);
            groupBox_Sach.Name = "groupBox_Sach";
            groupBox_Sach.Padding = new Padding(4);
            groupBox_Sach.Size = new Size(766, 398);
            groupBox_Sach.TabIndex = 0;
            groupBox_Sach.TabStop = false;
            groupBox_Sach.Text = "Nhập liệu";
            // 
            // icon_Sach_Clear
            // 
            icon_Sach_Clear.Anchor = AnchorStyles.None;
            icon_Sach_Clear.BackColor = Color.FromArgb(255, 128, 255);
            icon_Sach_Clear.FlatAppearance.BorderSize = 0;
            icon_Sach_Clear.FlatStyle = FlatStyle.Flat;
            icon_Sach_Clear.Font = new Font("Segoe UI", 12F);
            icon_Sach_Clear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            icon_Sach_Clear.IconColor = Color.Black;
            icon_Sach_Clear.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Sach_Clear.IconSize = 30;
            icon_Sach_Clear.Location = new Point(490, 283);
            icon_Sach_Clear.Margin = new Padding(14);
            icon_Sach_Clear.Name = "icon_Sach_Clear";
            icon_Sach_Clear.Size = new Size(80, 80);
            icon_Sach_Clear.TabIndex = 37;
            icon_Sach_Clear.TextAlign = ContentAlignment.MiddleRight;
            icon_Sach_Clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_Sach_Clear.UseVisualStyleBackColor = false;
            icon_Sach_Clear.Click += Icon_Sach_Clear_Click;
            // 
            // icon_Sach_Ban
            // 
            icon_Sach_Ban.Anchor = AnchorStyles.Right;
            icon_Sach_Ban.BackColor = Color.FromArgb(255, 128, 128);
            icon_Sach_Ban.FlatAppearance.BorderSize = 0;
            icon_Sach_Ban.FlatStyle = FlatStyle.Flat;
            icon_Sach_Ban.Font = new Font("Segoe UI", 12F);
            icon_Sach_Ban.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            icon_Sach_Ban.IconColor = Color.Black;
            icon_Sach_Ban.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Sach_Ban.IconSize = 30;
            icon_Sach_Ban.ImageAlign = ContentAlignment.BottomCenter;
            icon_Sach_Ban.Location = new Point(586, 158);
            icon_Sach_Ban.Margin = new Padding(14);
            icon_Sach_Ban.Name = "icon_Sach_Ban";
            icon_Sach_Ban.Size = new Size(165, 85);
            icon_Sach_Ban.TabIndex = 36;
            icon_Sach_Ban.Text = "Bán sách";
            icon_Sach_Ban.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_Sach_Ban.UseVisualStyleBackColor = false;
            // 
            // icon_Sach_Nhap
            // 
            icon_Sach_Nhap.Anchor = AnchorStyles.Right;
            icon_Sach_Nhap.BackColor = Color.FromArgb(128, 255, 128);
            icon_Sach_Nhap.FlatAppearance.BorderSize = 0;
            icon_Sach_Nhap.FlatStyle = FlatStyle.Flat;
            icon_Sach_Nhap.Font = new Font("Segoe UI", 12F);
            icon_Sach_Nhap.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            icon_Sach_Nhap.IconColor = Color.Black;
            icon_Sach_Nhap.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Sach_Nhap.IconSize = 30;
            icon_Sach_Nhap.ImageAlign = ContentAlignment.BottomCenter;
            icon_Sach_Nhap.Location = new Point(586, 49);
            icon_Sach_Nhap.Margin = new Padding(14);
            icon_Sach_Nhap.Name = "icon_Sach_Nhap";
            icon_Sach_Nhap.Size = new Size(165, 85);
            icon_Sach_Nhap.TabIndex = 35;
            icon_Sach_Nhap.Text = "Nhập sách";
            icon_Sach_Nhap.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_Sach_Nhap.UseVisualStyleBackColor = false;
            // 
            // textBox_TheLoai
            // 
            textBox_TheLoai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_TheLoai.Font = new Font("Segoe UI", 12F);
            textBox_TheLoai.Location = new Point(166, 215);
            textBox_TheLoai.Margin = new Padding(4);
            textBox_TheLoai.Name = "textBox_TheLoai";
            textBox_TheLoai.Size = new Size(404, 34);
            textBox_TheLoai.TabIndex = 34;
            // 
            // label_TheLoai
            // 
            label_TheLoai.Font = new Font("Segoe UI", 12F);
            label_TheLoai.Location = new Point(36, 217);
            label_TheLoai.Margin = new Padding(4, 0, 28, 0);
            label_TheLoai.Name = "label_TheLoai";
            label_TheLoai.Size = new Size(116, 30);
            label_TheLoai.TabIndex = 33;
            label_TheLoai.Text = "Thể loại";
            label_TheLoai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_SoLuong
            // 
            textBox_SoLuong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_SoLuong.Font = new Font("Segoe UI", 12F);
            textBox_SoLuong.Location = new Point(166, 173);
            textBox_SoLuong.Margin = new Padding(4);
            textBox_SoLuong.Name = "textBox_SoLuong";
            textBox_SoLuong.Size = new Size(404, 34);
            textBox_SoLuong.TabIndex = 32;
            // 
            // label_SoLuong
            // 
            label_SoLuong.Font = new Font("Segoe UI", 12F);
            label_SoLuong.Location = new Point(36, 175);
            label_SoLuong.Margin = new Padding(4, 0, 28, 0);
            label_SoLuong.Name = "label_SoLuong";
            label_SoLuong.Size = new Size(116, 30);
            label_SoLuong.TabIndex = 31;
            label_SoLuong.Text = "Số lượng";
            label_SoLuong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // icon_Sach_Loc
            // 
            icon_Sach_Loc.Anchor = AnchorStyles.None;
            icon_Sach_Loc.BackColor = Color.FromArgb(255, 192, 128);
            icon_Sach_Loc.FlatAppearance.BorderSize = 0;
            icon_Sach_Loc.FlatStyle = FlatStyle.Flat;
            icon_Sach_Loc.Font = new Font("Segoe UI", 12F);
            icon_Sach_Loc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            icon_Sach_Loc.IconColor = Color.Black;
            icon_Sach_Loc.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Sach_Loc.IconSize = 30;
            icon_Sach_Loc.Location = new Point(382, 283);
            icon_Sach_Loc.Margin = new Padding(14);
            icon_Sach_Loc.Name = "icon_Sach_Loc";
            icon_Sach_Loc.Size = new Size(80, 80);
            icon_Sach_Loc.TabIndex = 30;
            icon_Sach_Loc.TextAlign = ContentAlignment.MiddleRight;
            icon_Sach_Loc.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_Sach_Loc.UseVisualStyleBackColor = false;
            icon_Sach_Loc.Click += Icon_Sach_Loc_Click;
            // 
            // icon_Sach_Tim
            // 
            icon_Sach_Tim.Anchor = AnchorStyles.None;
            icon_Sach_Tim.BackColor = Color.FromArgb(128, 128, 255);
            icon_Sach_Tim.FlatAppearance.BorderSize = 0;
            icon_Sach_Tim.FlatStyle = FlatStyle.Flat;
            icon_Sach_Tim.Font = new Font("Segoe UI", 12F);
            icon_Sach_Tim.IconChar = FontAwesome.Sharp.IconChar.Search;
            icon_Sach_Tim.IconColor = Color.Black;
            icon_Sach_Tim.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Sach_Tim.IconSize = 30;
            icon_Sach_Tim.Location = new Point(274, 283);
            icon_Sach_Tim.Margin = new Padding(14);
            icon_Sach_Tim.Name = "icon_Sach_Tim";
            icon_Sach_Tim.Size = new Size(80, 80);
            icon_Sach_Tim.TabIndex = 29;
            icon_Sach_Tim.TextAlign = ContentAlignment.MiddleRight;
            icon_Sach_Tim.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_Sach_Tim.UseVisualStyleBackColor = false;
            // 
            // textBox_Sach_TacGia
            // 
            textBox_Sach_TacGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Sach_TacGia.Font = new Font("Segoe UI", 12F);
            textBox_Sach_TacGia.Location = new Point(166, 131);
            textBox_Sach_TacGia.Margin = new Padding(4);
            textBox_Sach_TacGia.Name = "textBox_Sach_TacGia";
            textBox_Sach_TacGia.Size = new Size(404, 34);
            textBox_Sach_TacGia.TabIndex = 28;
            // 
            // textBox_Sach_TenSach
            // 
            textBox_Sach_TenSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Sach_TenSach.Font = new Font("Segoe UI", 12F);
            textBox_Sach_TenSach.Location = new Point(166, 89);
            textBox_Sach_TenSach.Margin = new Padding(4);
            textBox_Sach_TenSach.Name = "textBox_Sach_TenSach";
            textBox_Sach_TenSach.Size = new Size(404, 34);
            textBox_Sach_TenSach.TabIndex = 27;
            // 
            // label_Sach_TacGia
            // 
            label_Sach_TacGia.Font = new Font("Segoe UI", 12F);
            label_Sach_TacGia.Location = new Point(36, 133);
            label_Sach_TacGia.Margin = new Padding(4, 0, 28, 0);
            label_Sach_TacGia.Name = "label_Sach_TacGia";
            label_Sach_TacGia.Size = new Size(116, 30);
            label_Sach_TacGia.TabIndex = 24;
            label_Sach_TacGia.Text = "Tác giả";
            label_Sach_TacGia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_Sach_TenSach
            // 
            label_Sach_TenSach.Font = new Font("Segoe UI", 12F);
            label_Sach_TenSach.Location = new Point(36, 91);
            label_Sach_TenSach.Margin = new Padding(4, 0, 28, 0);
            label_Sach_TenSach.Name = "label_Sach_TenSach";
            label_Sach_TenSach.Size = new Size(116, 30);
            label_Sach_TenSach.TabIndex = 23;
            label_Sach_TenSach.Text = "Tên sách";
            label_Sach_TenSach.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_Sach_MaSach
            // 
            label_Sach_MaSach.Font = new Font("Segoe UI", 12F);
            label_Sach_MaSach.Location = new Point(36, 49);
            label_Sach_MaSach.Margin = new Padding(4, 0, 28, 0);
            label_Sach_MaSach.Name = "label_Sach_MaSach";
            label_Sach_MaSach.Size = new Size(116, 30);
            label_Sach_MaSach.TabIndex = 22;
            label_Sach_MaSach.Text = "Mã sách";
            label_Sach_MaSach.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_Sach_MaSach
            // 
            textBox_Sach_MaSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Sach_MaSach.Font = new Font("Segoe UI", 12F);
            textBox_Sach_MaSach.Location = new Point(166, 47);
            textBox_Sach_MaSach.Margin = new Padding(4);
            textBox_Sach_MaSach.Name = "textBox_Sach_MaSach";
            textBox_Sach_MaSach.Size = new Size(404, 34);
            textBox_Sach_MaSach.TabIndex = 21;
            // 
            // icon_Sach_Xoa
            // 
            icon_Sach_Xoa.Anchor = AnchorStyles.None;
            icon_Sach_Xoa.BackColor = Color.FromArgb(255, 128, 128);
            icon_Sach_Xoa.FlatAppearance.BorderSize = 0;
            icon_Sach_Xoa.FlatStyle = FlatStyle.Flat;
            icon_Sach_Xoa.Font = new Font("Segoe UI", 12F);
            icon_Sach_Xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            icon_Sach_Xoa.IconColor = Color.Black;
            icon_Sach_Xoa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Sach_Xoa.IconSize = 30;
            icon_Sach_Xoa.Location = new Point(166, 283);
            icon_Sach_Xoa.Margin = new Padding(14);
            icon_Sach_Xoa.Name = "icon_Sach_Xoa";
            icon_Sach_Xoa.Size = new Size(80, 80);
            icon_Sach_Xoa.TabIndex = 20;
            icon_Sach_Xoa.TextAlign = ContentAlignment.MiddleRight;
            icon_Sach_Xoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_Sach_Xoa.UseVisualStyleBackColor = false;
            // 
            // icon_Sach_Them
            // 
            icon_Sach_Them.Anchor = AnchorStyles.None;
            icon_Sach_Them.BackColor = Color.FromArgb(128, 255, 128);
            icon_Sach_Them.FlatAppearance.BorderSize = 0;
            icon_Sach_Them.FlatStyle = FlatStyle.Flat;
            icon_Sach_Them.Font = new Font("Segoe UI", 12F);
            icon_Sach_Them.IconChar = FontAwesome.Sharp.IconChar.Add;
            icon_Sach_Them.IconColor = Color.Black;
            icon_Sach_Them.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Sach_Them.IconSize = 30;
            icon_Sach_Them.Location = new Point(58, 283);
            icon_Sach_Them.Margin = new Padding(14);
            icon_Sach_Them.Name = "icon_Sach_Them";
            icon_Sach_Them.Size = new Size(80, 80);
            icon_Sach_Them.TabIndex = 19;
            icon_Sach_Them.TextAlign = ContentAlignment.MiddleRight;
            icon_Sach_Them.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_Sach_Them.UseVisualStyleBackColor = false;
            // 
            // sachBindingSource
            // 
            sachBindingSource.DataSource = typeof(Models.Sach);
            // 
            // dataGridView_Sach
            // 
            dataGridView_Sach.AllowUserToAddRows = false;
            dataGridView_Sach.AllowUserToDeleteRows = false;
            dataGridView_Sach.AllowUserToResizeColumns = false;
            dataGridView_Sach.AllowUserToResizeRows = false;
            dataGridView_Sach.AutoGenerateColumns = false;
            dataGridView_Sach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Sach.BackgroundColor = Color.White;
            dataGridView_Sach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Sach.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn_MaSach, dataGridViewTextBoxColumn_SoLuong, dataGridViewTextBoxColumn_TenSach, dataGridViewTextBoxColumn_TacGia, dataGridViewTextBoxColumn_TheLoai });
            dataGridView_Sach.DataSource = sachBindingSource;
            dataGridView_Sach.Dock = DockStyle.Fill;
            dataGridView_Sach.GridColor = SystemColors.ScrollBar;
            dataGridView_Sach.Location = new Point(4, 402);
            dataGridView_Sach.Margin = new Padding(4);
            dataGridView_Sach.Name = "dataGridView_Sach";
            dataGridView_Sach.RightToLeft = RightToLeft.No;
            dataGridView_Sach.RowHeadersVisible = false;
            dataGridView_Sach.RowHeadersWidth = 51;
            dataGridView_Sach.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_Sach.Size = new Size(766, 106);
            dataGridView_Sach.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn_MaSach
            // 
            dataGridViewTextBoxColumn_MaSach.DataPropertyName = "MaSach";
            dataGridViewTextBoxColumn_MaSach.HeaderText = "Mã sách";
            dataGridViewTextBoxColumn_MaSach.MinimumWidth = 6;
            dataGridViewTextBoxColumn_MaSach.Name = "dataGridViewTextBoxColumn_MaSach";
            // 
            // dataGridViewTextBoxColumn_SoLuong
            // 
            dataGridViewTextBoxColumn_SoLuong.DataPropertyName = "SoLuong";
            dataGridViewTextBoxColumn_SoLuong.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn_SoLuong.MinimumWidth = 6;
            dataGridViewTextBoxColumn_SoLuong.Name = "dataGridViewTextBoxColumn_SoLuong";
            // 
            // tabControl_Sach
            // 
            tabControl_Sach.Controls.Add(tabPage_QuanLiSach);
            tabControl_Sach.Controls.Add(tabPage_PhieuNhapSach);
            tabControl_Sach.Controls.Add(tabPage_HoaDonBanSach);
            tabControl_Sach.Dock = DockStyle.Fill;
            tabControl_Sach.Location = new Point(0, 0);
            tabControl_Sach.Margin = new Padding(4);
            tabControl_Sach.Name = "tabControl_Sach";
            tabControl_Sach.SelectedIndex = 0;
            tabControl_Sach.Size = new Size(782, 553);
            tabControl_Sach.TabIndex = 37;
            // 
            // tabPage_QuanLiSach
            // 
            tabPage_QuanLiSach.Controls.Add(dataGridView_Sach);
            tabPage_QuanLiSach.Controls.Add(groupBox_Sach);
            tabPage_QuanLiSach.Location = new Point(4, 37);
            tabPage_QuanLiSach.Margin = new Padding(4);
            tabPage_QuanLiSach.Name = "tabPage_QuanLiSach";
            tabPage_QuanLiSach.Padding = new Padding(4);
            tabPage_QuanLiSach.Size = new Size(774, 512);
            tabPage_QuanLiSach.TabIndex = 0;
            tabPage_QuanLiSach.Text = "Quản lý sách";
            tabPage_QuanLiSach.UseVisualStyleBackColor = true;
            // 
            // tabPage_PhieuNhapSach
            // 
            tabPage_PhieuNhapSach.Controls.Add(dataGridView_PhieuNhapSach);
            tabPage_PhieuNhapSach.Controls.Add(groupBox_PhieuNhapSach);
            tabPage_PhieuNhapSach.Location = new Point(4, 37);
            tabPage_PhieuNhapSach.Margin = new Padding(4);
            tabPage_PhieuNhapSach.Name = "tabPage_PhieuNhapSach";
            tabPage_PhieuNhapSach.Padding = new Padding(4);
            tabPage_PhieuNhapSach.Size = new Size(774, 512);
            tabPage_PhieuNhapSach.TabIndex = 1;
            tabPage_PhieuNhapSach.Text = "Quản lý phiếu nhập sách";
            tabPage_PhieuNhapSach.UseVisualStyleBackColor = true;
            // 
            // dataGridView_PhieuNhapSach
            // 
            dataGridView_PhieuNhapSach.AllowUserToAddRows = false;
            dataGridView_PhieuNhapSach.AllowUserToDeleteRows = false;
            dataGridView_PhieuNhapSach.AllowUserToResizeColumns = false;
            dataGridView_PhieuNhapSach.AllowUserToResizeRows = false;
            dataGridView_PhieuNhapSach.AutoGenerateColumns = false;
            dataGridView_PhieuNhapSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_PhieuNhapSach.BackgroundColor = Color.White;
            dataGridView_PhieuNhapSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_PhieuNhapSach.Columns.AddRange(new DataGridViewColumn[] { maPNDataGridViewTextBoxColumn, maSachDataGridViewTextBoxColumn, soLuongDataGridViewTextBoxColumn, giaNhapDataGridViewTextBoxColumn, ngayNhapDataGridViewTextBoxColumn });
            dataGridView_PhieuNhapSach.DataSource = phieuNhapSachBindingSource;
            dataGridView_PhieuNhapSach.Dock = DockStyle.Fill;
            dataGridView_PhieuNhapSach.GridColor = SystemColors.ScrollBar;
            dataGridView_PhieuNhapSach.Location = new Point(4, 402);
            dataGridView_PhieuNhapSach.Margin = new Padding(4);
            dataGridView_PhieuNhapSach.Name = "dataGridView_PhieuNhapSach";
            dataGridView_PhieuNhapSach.RightToLeft = RightToLeft.No;
            dataGridView_PhieuNhapSach.RowHeadersVisible = false;
            dataGridView_PhieuNhapSach.RowHeadersWidth = 51;
            dataGridView_PhieuNhapSach.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_PhieuNhapSach.Size = new Size(766, 106);
            dataGridView_PhieuNhapSach.TabIndex = 3;
            // 
            // phieuNhapSachBindingSource
            // 
            phieuNhapSachBindingSource.DataSource = typeof(Models.PhieuNhapSach);
            // 
            // groupBox_PhieuNhapSach
            // 
            groupBox_PhieuNhapSach.Controls.Add(date_PNS_NgayNhap);
            groupBox_PhieuNhapSach.Controls.Add(icon_PNS_Clear);
            groupBox_PhieuNhapSach.Controls.Add(label_PNS_NgayNhap);
            groupBox_PhieuNhapSach.Controls.Add(textBox_PNS_GiaNhap);
            groupBox_PhieuNhapSach.Controls.Add(label_PNS_GiaNhap);
            groupBox_PhieuNhapSach.Controls.Add(icon_PNS_Loc);
            groupBox_PhieuNhapSach.Controls.Add(icon_PNS_Tim);
            groupBox_PhieuNhapSach.Controls.Add(textBox_PNS_SoLuong);
            groupBox_PhieuNhapSach.Controls.Add(textBox_PNS_MaSach);
            groupBox_PhieuNhapSach.Controls.Add(label_PNS_SoLuong);
            groupBox_PhieuNhapSach.Controls.Add(label_PNS_MaSach);
            groupBox_PhieuNhapSach.Controls.Add(label_PNS_MaPhieu);
            groupBox_PhieuNhapSach.Controls.Add(textBox_PNS_MaPhieu);
            groupBox_PhieuNhapSach.Controls.Add(icon_PNS_Xoa);
            groupBox_PhieuNhapSach.Controls.Add(icon_PNS_Them);
            groupBox_PhieuNhapSach.Dock = DockStyle.Top;
            groupBox_PhieuNhapSach.Location = new Point(4, 4);
            groupBox_PhieuNhapSach.Margin = new Padding(4);
            groupBox_PhieuNhapSach.Name = "groupBox_PhieuNhapSach";
            groupBox_PhieuNhapSach.Padding = new Padding(4);
            groupBox_PhieuNhapSach.Size = new Size(766, 398);
            groupBox_PhieuNhapSach.TabIndex = 4;
            groupBox_PhieuNhapSach.TabStop = false;
            groupBox_PhieuNhapSach.Text = "Nhập liệu";
            // 
            // date_PNS_NgayNhap
            // 
            date_PNS_NgayNhap.Format = DateTimePickerFormat.Short;
            date_PNS_NgayNhap.Location = new Point(167, 217);
            date_PNS_NgayNhap.Name = "date_PNS_NgayNhap";
            date_PNS_NgayNhap.Size = new Size(512, 34);
            date_PNS_NgayNhap.TabIndex = 38;
            // 
            // icon_PNS_Clear
            // 
            icon_PNS_Clear.Anchor = AnchorStyles.None;
            icon_PNS_Clear.BackColor = Color.FromArgb(255, 128, 255);
            icon_PNS_Clear.FlatAppearance.BorderSize = 0;
            icon_PNS_Clear.FlatStyle = FlatStyle.Flat;
            icon_PNS_Clear.Font = new Font("Segoe UI", 12F);
            icon_PNS_Clear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            icon_PNS_Clear.IconColor = Color.Black;
            icon_PNS_Clear.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_PNS_Clear.IconSize = 30;
            icon_PNS_Clear.Location = new Point(599, 289);
            icon_PNS_Clear.Margin = new Padding(14);
            icon_PNS_Clear.Name = "icon_PNS_Clear";
            icon_PNS_Clear.Size = new Size(80, 80);
            icon_PNS_Clear.TabIndex = 37;
            icon_PNS_Clear.TextAlign = ContentAlignment.MiddleRight;
            icon_PNS_Clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_PNS_Clear.UseVisualStyleBackColor = false;
            // 
            // label_PNS_NgayNhap
            // 
            label_PNS_NgayNhap.Font = new Font("Segoe UI", 12F);
            label_PNS_NgayNhap.Location = new Point(36, 217);
            label_PNS_NgayNhap.Margin = new Padding(4, 0, 28, 0);
            label_PNS_NgayNhap.Name = "label_PNS_NgayNhap";
            label_PNS_NgayNhap.Size = new Size(116, 30);
            label_PNS_NgayNhap.TabIndex = 33;
            label_PNS_NgayNhap.Text = "Ngày nhập";
            label_PNS_NgayNhap.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_PNS_GiaNhap
            // 
            textBox_PNS_GiaNhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_PNS_GiaNhap.Font = new Font("Segoe UI", 12F);
            textBox_PNS_GiaNhap.Location = new Point(167, 174);
            textBox_PNS_GiaNhap.Margin = new Padding(4);
            textBox_PNS_GiaNhap.Name = "textBox_PNS_GiaNhap";
            textBox_PNS_GiaNhap.Size = new Size(512, 34);
            textBox_PNS_GiaNhap.TabIndex = 32;
            // 
            // label_PNS_GiaNhap
            // 
            label_PNS_GiaNhap.Font = new Font("Segoe UI", 12F);
            label_PNS_GiaNhap.Location = new Point(36, 175);
            label_PNS_GiaNhap.Margin = new Padding(4, 0, 28, 0);
            label_PNS_GiaNhap.Name = "label_PNS_GiaNhap";
            label_PNS_GiaNhap.Size = new Size(116, 30);
            label_PNS_GiaNhap.TabIndex = 31;
            label_PNS_GiaNhap.Text = "Giá nhập";
            label_PNS_GiaNhap.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // icon_PNS_Loc
            // 
            icon_PNS_Loc.Anchor = AnchorStyles.None;
            icon_PNS_Loc.BackColor = Color.FromArgb(255, 192, 128);
            icon_PNS_Loc.FlatAppearance.BorderSize = 0;
            icon_PNS_Loc.FlatStyle = FlatStyle.Flat;
            icon_PNS_Loc.Font = new Font("Segoe UI", 12F);
            icon_PNS_Loc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            icon_PNS_Loc.IconColor = Color.Black;
            icon_PNS_Loc.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_PNS_Loc.IconSize = 30;
            icon_PNS_Loc.Location = new Point(491, 289);
            icon_PNS_Loc.Margin = new Padding(14);
            icon_PNS_Loc.Name = "icon_PNS_Loc";
            icon_PNS_Loc.Size = new Size(80, 80);
            icon_PNS_Loc.TabIndex = 30;
            icon_PNS_Loc.TextAlign = ContentAlignment.MiddleRight;
            icon_PNS_Loc.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_PNS_Loc.UseVisualStyleBackColor = false;
            // 
            // icon_PNS_Tim
            // 
            icon_PNS_Tim.Anchor = AnchorStyles.None;
            icon_PNS_Tim.BackColor = Color.FromArgb(128, 128, 255);
            icon_PNS_Tim.FlatAppearance.BorderSize = 0;
            icon_PNS_Tim.FlatStyle = FlatStyle.Flat;
            icon_PNS_Tim.Font = new Font("Segoe UI", 12F);
            icon_PNS_Tim.IconChar = FontAwesome.Sharp.IconChar.Search;
            icon_PNS_Tim.IconColor = Color.Black;
            icon_PNS_Tim.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_PNS_Tim.IconSize = 30;
            icon_PNS_Tim.Location = new Point(383, 289);
            icon_PNS_Tim.Margin = new Padding(14);
            icon_PNS_Tim.Name = "icon_PNS_Tim";
            icon_PNS_Tim.Size = new Size(80, 80);
            icon_PNS_Tim.TabIndex = 29;
            icon_PNS_Tim.TextAlign = ContentAlignment.MiddleRight;
            icon_PNS_Tim.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_PNS_Tim.UseVisualStyleBackColor = false;
            // 
            // textBox_PNS_SoLuong
            // 
            textBox_PNS_SoLuong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_PNS_SoLuong.Font = new Font("Segoe UI", 12F);
            textBox_PNS_SoLuong.Location = new Point(167, 132);
            textBox_PNS_SoLuong.Margin = new Padding(4);
            textBox_PNS_SoLuong.Name = "textBox_PNS_SoLuong";
            textBox_PNS_SoLuong.Size = new Size(512, 34);
            textBox_PNS_SoLuong.TabIndex = 28;
            // 
            // textBox_PNS_MaSach
            // 
            textBox_PNS_MaSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_PNS_MaSach.Font = new Font("Segoe UI", 12F);
            textBox_PNS_MaSach.Location = new Point(167, 90);
            textBox_PNS_MaSach.Margin = new Padding(4);
            textBox_PNS_MaSach.Name = "textBox_PNS_MaSach";
            textBox_PNS_MaSach.Size = new Size(512, 34);
            textBox_PNS_MaSach.TabIndex = 27;
            // 
            // label_PNS_SoLuong
            // 
            label_PNS_SoLuong.Font = new Font("Segoe UI", 12F);
            label_PNS_SoLuong.Location = new Point(36, 133);
            label_PNS_SoLuong.Margin = new Padding(4, 0, 28, 0);
            label_PNS_SoLuong.Name = "label_PNS_SoLuong";
            label_PNS_SoLuong.Size = new Size(116, 30);
            label_PNS_SoLuong.TabIndex = 24;
            label_PNS_SoLuong.Text = "Số lượng";
            label_PNS_SoLuong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_PNS_MaSach
            // 
            label_PNS_MaSach.Font = new Font("Segoe UI", 12F);
            label_PNS_MaSach.Location = new Point(36, 91);
            label_PNS_MaSach.Margin = new Padding(4, 0, 28, 0);
            label_PNS_MaSach.Name = "label_PNS_MaSach";
            label_PNS_MaSach.Size = new Size(116, 30);
            label_PNS_MaSach.TabIndex = 23;
            label_PNS_MaSach.Text = "Mã sách";
            label_PNS_MaSach.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_PNS_MaPhieu
            // 
            label_PNS_MaPhieu.Font = new Font("Segoe UI", 12F);
            label_PNS_MaPhieu.Location = new Point(36, 49);
            label_PNS_MaPhieu.Margin = new Padding(4, 0, 28, 0);
            label_PNS_MaPhieu.Name = "label_PNS_MaPhieu";
            label_PNS_MaPhieu.Size = new Size(116, 30);
            label_PNS_MaPhieu.TabIndex = 22;
            label_PNS_MaPhieu.Text = "Mã phiếu";
            label_PNS_MaPhieu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_PNS_MaPhieu
            // 
            textBox_PNS_MaPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_PNS_MaPhieu.Font = new Font("Segoe UI", 12F);
            textBox_PNS_MaPhieu.Location = new Point(167, 48);
            textBox_PNS_MaPhieu.Margin = new Padding(4);
            textBox_PNS_MaPhieu.Name = "textBox_PNS_MaPhieu";
            textBox_PNS_MaPhieu.Size = new Size(512, 34);
            textBox_PNS_MaPhieu.TabIndex = 21;
            // 
            // icon_PNS_Xoa
            // 
            icon_PNS_Xoa.Anchor = AnchorStyles.None;
            icon_PNS_Xoa.BackColor = Color.FromArgb(255, 128, 128);
            icon_PNS_Xoa.FlatAppearance.BorderSize = 0;
            icon_PNS_Xoa.FlatStyle = FlatStyle.Flat;
            icon_PNS_Xoa.Font = new Font("Segoe UI", 12F);
            icon_PNS_Xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            icon_PNS_Xoa.IconColor = Color.Black;
            icon_PNS_Xoa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_PNS_Xoa.IconSize = 30;
            icon_PNS_Xoa.Location = new Point(275, 289);
            icon_PNS_Xoa.Margin = new Padding(14);
            icon_PNS_Xoa.Name = "icon_PNS_Xoa";
            icon_PNS_Xoa.Size = new Size(80, 80);
            icon_PNS_Xoa.TabIndex = 20;
            icon_PNS_Xoa.TextAlign = ContentAlignment.MiddleRight;
            icon_PNS_Xoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_PNS_Xoa.UseVisualStyleBackColor = false;
            // 
            // icon_PNS_Them
            // 
            icon_PNS_Them.Anchor = AnchorStyles.None;
            icon_PNS_Them.BackColor = Color.FromArgb(128, 255, 128);
            icon_PNS_Them.FlatAppearance.BorderSize = 0;
            icon_PNS_Them.FlatStyle = FlatStyle.Flat;
            icon_PNS_Them.Font = new Font("Segoe UI", 12F);
            icon_PNS_Them.IconChar = FontAwesome.Sharp.IconChar.Add;
            icon_PNS_Them.IconColor = Color.Black;
            icon_PNS_Them.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_PNS_Them.IconSize = 30;
            icon_PNS_Them.Location = new Point(167, 289);
            icon_PNS_Them.Margin = new Padding(14);
            icon_PNS_Them.Name = "icon_PNS_Them";
            icon_PNS_Them.Size = new Size(80, 80);
            icon_PNS_Them.TabIndex = 19;
            icon_PNS_Them.TextAlign = ContentAlignment.MiddleRight;
            icon_PNS_Them.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_PNS_Them.UseVisualStyleBackColor = false;
            // 
            // tabPage_HoaDonBanSach
            // 
            tabPage_HoaDonBanSach.Location = new Point(4, 29);
            tabPage_HoaDonBanSach.Margin = new Padding(4);
            tabPage_HoaDonBanSach.Name = "tabPage_HoaDonBanSach";
            tabPage_HoaDonBanSach.Padding = new Padding(4);
            tabPage_HoaDonBanSach.Size = new Size(774, 520);
            tabPage_HoaDonBanSach.TabIndex = 2;
            tabPage_HoaDonBanSach.Text = "Quản lý hoá đơn bán sách";
            tabPage_HoaDonBanSach.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn_TheLoai
            // 
            dataGridViewTextBoxColumn_TheLoai.DataPropertyName = "TheLoai";
            dataGridViewTextBoxColumn_TheLoai.HeaderText = "Thể loại";
            dataGridViewTextBoxColumn_TheLoai.MinimumWidth = 6;
            dataGridViewTextBoxColumn_TheLoai.Name = "dataGridViewTextBoxColumn_TheLoai";
            // 
            // dataGridViewTextBoxColumn_TacGia
            // 
            dataGridViewTextBoxColumn_TacGia.DataPropertyName = "TacGia";
            dataGridViewTextBoxColumn_TacGia.HeaderText = "Tác giả";
            dataGridViewTextBoxColumn_TacGia.MinimumWidth = 6;
            dataGridViewTextBoxColumn_TacGia.Name = "dataGridViewTextBoxColumn_TacGia";
            // 
            // dataGridViewTextBoxColumn_TenSach
            // 
            dataGridViewTextBoxColumn_TenSach.DataPropertyName = "TenSach";
            dataGridViewTextBoxColumn_TenSach.HeaderText = "Tên sách";
            dataGridViewTextBoxColumn_TenSach.MinimumWidth = 6;
            dataGridViewTextBoxColumn_TenSach.Name = "dataGridViewTextBoxColumn_TenSach";
            // 
            // maPNDataGridViewTextBoxColumn
            // 
            maPNDataGridViewTextBoxColumn.DataPropertyName = "MaPN";
            maPNDataGridViewTextBoxColumn.HeaderText = "Mã phiếu nhập";
            maPNDataGridViewTextBoxColumn.MinimumWidth = 6;
            maPNDataGridViewTextBoxColumn.Name = "maPNDataGridViewTextBoxColumn";
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            maSachDataGridViewTextBoxColumn.HeaderText = "Mã sách";
            maSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            giaNhapDataGridViewTextBoxColumn.HeaderText = "Giá nhập";
            giaNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            ngayNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            // 
            // Form_Sach
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(tabControl_Sach);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form_Sach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sách";
            FormClosing += Form_Sach_FormClosing;
            Load += Form_Sach_Load;
            groupBox_Sach.ResumeLayout(false);
            groupBox_Sach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sachBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Sach).EndInit();
            tabControl_Sach.ResumeLayout(false);
            tabPage_QuanLiSach.ResumeLayout(false);
            tabPage_PhieuNhapSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_PhieuNhapSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)phieuNhapSachBindingSource).EndInit();
            groupBox_PhieuNhapSach.ResumeLayout(false);
            groupBox_PhieuNhapSach.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Sach;
        private TextBox textBox_Sach_TacGia;
        private TextBox textBox_Sach_TenSach;
        private Label label_Sach_TacGia;
        private Label label_Sach_TenSach;
        private Label label_Sach_MaSach;
        private TextBox textBox_Sach_MaSach;
        private FontAwesome.Sharp.IconButton icon_Sach_Xoa;
        private FontAwesome.Sharp.IconButton icon_Sach_Them;
        private BindingSource sachBindingSource;
        private DataGridView dataGridView_Sach;
        private FontAwesome.Sharp.IconButton icon_Sach_Tim;
        private FontAwesome.Sharp.IconButton icon_Sach_Loc;
        private DataGridViewTextBoxColumn tenTKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vaiTroDataGridViewTextBoxColumn;
        private TextBox textBox_TheLoai;
        private Label label_TheLoai;
        private TextBox textBox_SoLuong;
        private Label label_SoLuong;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_MaSach;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_SoLuong;
        private FontAwesome.Sharp.IconButton icon_Sach_Nhap;
        private TabControl tabControl_Sach;
        private TabPage tabPage_QuanLiSach;
        private TabPage tabPage_PhieuNhapSach;
        private DataGridView dataGridView_PhieuNhapSach;
        private FontAwesome.Sharp.IconButton icon_Sach_Ban;
        private TabPage tabPage_HoaDonBanSach;
        private FontAwesome.Sharp.IconButton icon_Sach_Clear;
        private GroupBox groupBox_PhieuNhapSach;
        private FontAwesome.Sharp.IconButton icon_PNS_Clear;
        private Label label_PNS_NgayNhap;
        private TextBox textBox_PNS_GiaNhap;
        private Label label_PNS_GiaNhap;
        private FontAwesome.Sharp.IconButton icon_PNS_Loc;
        private FontAwesome.Sharp.IconButton icon_PNS_Tim;
        private TextBox textBox_PNS_SoLuong;
        private TextBox textBox_PNS_MaSach;
        private Label label_PNS_SoLuong;
        private Label label_PNS_MaSach;
        private Label label_PNS_MaPhieu;
        private TextBox textBox_PNS_MaPhieu;
        private FontAwesome.Sharp.IconButton icon_PNS_Xoa;
        private FontAwesome.Sharp.IconButton icon_PNS_Them;
        private DateTimePicker date_PNS_NgayNhap;
        private BindingSource phieuNhapSachBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_TenSach;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_TacGia;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_TheLoai;
        private DataGridViewTextBoxColumn maPNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
    }
}