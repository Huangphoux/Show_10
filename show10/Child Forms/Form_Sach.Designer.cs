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
            dataGridViewTextBoxColumn_TenSach = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn_TacGia = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn_SoLuong = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn_TheLoai = new DataGridViewTextBoxColumn();
            tabControl_Sach = new TabControl();
            tabPage_QuanLiSach = new TabPage();
            tabPage_PhieuNhapSach = new TabPage();
            dataGridView_PhieuNhapSach = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            icon_Sach_Ban = new FontAwesome.Sharp.IconButton();
            groupBox_Sach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sachBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Sach).BeginInit();
            tabControl_Sach.SuspendLayout();
            tabPage_QuanLiSach.SuspendLayout();
            tabPage_PhieuNhapSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_PhieuNhapSach).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Sach
            // 
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
            groupBox_Sach.Location = new Point(3, 3);
            groupBox_Sach.Name = "groupBox_Sach";
            groupBox_Sach.Size = new Size(768, 396);
            groupBox_Sach.TabIndex = 0;
            groupBox_Sach.TabStop = false;
            groupBox_Sach.Text = "Nhập liệu";
            // 
            // icon_Sach_Nhap
            // 
            icon_Sach_Nhap.Anchor = AnchorStyles.Right;
            icon_Sach_Nhap.BackColor = Color.FromArgb(255, 128, 255);
            icon_Sach_Nhap.FlatAppearance.BorderSize = 0;
            icon_Sach_Nhap.FlatStyle = FlatStyle.Flat;
            icon_Sach_Nhap.Font = new Font("Segoe UI", 12F);
            icon_Sach_Nhap.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            icon_Sach_Nhap.IconColor = Color.Black;
            icon_Sach_Nhap.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Sach_Nhap.IconSize = 30;
            icon_Sach_Nhap.ImageAlign = ContentAlignment.BottomCenter;
            icon_Sach_Nhap.Location = new Point(581, 33);
            icon_Sach_Nhap.Margin = new Padding(10, 10, 10, 10);
            icon_Sach_Nhap.Name = "icon_Sach_Nhap";
            icon_Sach_Nhap.Size = new Size(168, 84);
            icon_Sach_Nhap.TabIndex = 35;
            icon_Sach_Nhap.Text = "Nhập sách";
            icon_Sach_Nhap.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_Sach_Nhap.UseVisualStyleBackColor = false;
            // 
            // textBox_TheLoai
            // 
            textBox_TheLoai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_TheLoai.Font = new Font("Segoe UI", 12F);
            textBox_TheLoai.Location = new Point(184, 233);
            textBox_TheLoai.Name = "textBox_TheLoai";
            textBox_TheLoai.Size = new Size(366, 34);
            textBox_TheLoai.TabIndex = 34;
            // 
            // label_TheLoai
            // 
            label_TheLoai.Font = new Font("Segoe UI", 12F);
            label_TheLoai.Location = new Point(26, 231);
            label_TheLoai.Margin = new Padding(3, 0, 20, 0);
            label_TheLoai.Name = "label_TheLoai";
            label_TheLoai.Size = new Size(135, 40);
            label_TheLoai.TabIndex = 33;
            label_TheLoai.Text = "Thể loại";
            label_TheLoai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_SoLuong
            // 
            textBox_SoLuong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_SoLuong.Font = new Font("Segoe UI", 12F);
            textBox_SoLuong.Location = new Point(184, 184);
            textBox_SoLuong.Name = "textBox_SoLuong";
            textBox_SoLuong.Size = new Size(366, 34);
            textBox_SoLuong.TabIndex = 32;
            // 
            // label_SoLuong
            // 
            label_SoLuong.Font = new Font("Segoe UI", 12F);
            label_SoLuong.Location = new Point(26, 182);
            label_SoLuong.Margin = new Padding(3, 0, 20, 0);
            label_SoLuong.Name = "label_SoLuong";
            label_SoLuong.Size = new Size(135, 40);
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
            icon_Sach_Loc.Location = new Point(477, 291);
            icon_Sach_Loc.Margin = new Padding(10, 10, 10, 10);
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
            icon_Sach_Tim.Location = new Point(377, 291);
            icon_Sach_Tim.Margin = new Padding(10, 10, 10, 10);
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
            textBox_Sach_TacGia.Location = new Point(184, 135);
            textBox_Sach_TacGia.Name = "textBox_Sach_TacGia";
            textBox_Sach_TacGia.Size = new Size(366, 34);
            textBox_Sach_TacGia.TabIndex = 28;
            // 
            // textBox_Sach_TenSach
            // 
            textBox_Sach_TenSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Sach_TenSach.Font = new Font("Segoe UI", 12F);
            textBox_Sach_TenSach.Location = new Point(184, 86);
            textBox_Sach_TenSach.Name = "textBox_Sach_TenSach";
            textBox_Sach_TenSach.Size = new Size(366, 34);
            textBox_Sach_TenSach.TabIndex = 27;
            // 
            // label_Sach_TacGia
            // 
            label_Sach_TacGia.Font = new Font("Segoe UI", 12F);
            label_Sach_TacGia.Location = new Point(26, 133);
            label_Sach_TacGia.Margin = new Padding(3, 0, 20, 0);
            label_Sach_TacGia.Name = "label_Sach_TacGia";
            label_Sach_TacGia.Size = new Size(135, 40);
            label_Sach_TacGia.TabIndex = 24;
            label_Sach_TacGia.Text = "Tác giả";
            label_Sach_TacGia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_Sach_TenSach
            // 
            label_Sach_TenSach.Font = new Font("Segoe UI", 12F);
            label_Sach_TenSach.Location = new Point(26, 84);
            label_Sach_TenSach.Margin = new Padding(3, 0, 20, 0);
            label_Sach_TenSach.Name = "label_Sach_TenSach";
            label_Sach_TenSach.Size = new Size(135, 40);
            label_Sach_TenSach.TabIndex = 23;
            label_Sach_TenSach.Text = "Tên sách";
            label_Sach_TenSach.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_Sach_MaSach
            // 
            label_Sach_MaSach.Font = new Font("Segoe UI", 12F);
            label_Sach_MaSach.Location = new Point(26, 35);
            label_Sach_MaSach.Margin = new Padding(3, 0, 20, 0);
            label_Sach_MaSach.Name = "label_Sach_MaSach";
            label_Sach_MaSach.Size = new Size(135, 40);
            label_Sach_MaSach.TabIndex = 22;
            label_Sach_MaSach.Text = "Mã sách";
            label_Sach_MaSach.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_Sach_MaSach
            // 
            textBox_Sach_MaSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Sach_MaSach.Font = new Font("Segoe UI", 12F);
            textBox_Sach_MaSach.Location = new Point(184, 35);
            textBox_Sach_MaSach.Name = "textBox_Sach_MaSach";
            textBox_Sach_MaSach.Size = new Size(366, 34);
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
            icon_Sach_Xoa.Location = new Point(277, 291);
            icon_Sach_Xoa.Margin = new Padding(10, 10, 10, 10);
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
            icon_Sach_Them.Location = new Point(177, 291);
            icon_Sach_Them.Margin = new Padding(10, 10, 10, 10);
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
            dataGridView_Sach.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn_MaSach, dataGridViewTextBoxColumn_TenSach, dataGridViewTextBoxColumn_TacGia, dataGridViewTextBoxColumn_SoLuong, dataGridViewTextBoxColumn_TheLoai });
            dataGridView_Sach.DataSource = sachBindingSource;
            dataGridView_Sach.Dock = DockStyle.Fill;
            dataGridView_Sach.GridColor = SystemColors.ScrollBar;
            dataGridView_Sach.Location = new Point(3, 399);
            dataGridView_Sach.Name = "dataGridView_Sach";
            dataGridView_Sach.RightToLeft = RightToLeft.No;
            dataGridView_Sach.RowHeadersVisible = false;
            dataGridView_Sach.RowHeadersWidth = 51;
            dataGridView_Sach.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_Sach.Size = new Size(768, 118);
            dataGridView_Sach.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn_MaSach
            // 
            dataGridViewTextBoxColumn_MaSach.DataPropertyName = "MaSach";
            dataGridViewTextBoxColumn_MaSach.HeaderText = "Mã sách";
            dataGridViewTextBoxColumn_MaSach.MinimumWidth = 6;
            dataGridViewTextBoxColumn_MaSach.Name = "dataGridViewTextBoxColumn_MaSach";
            // 
            // dataGridViewTextBoxColumn_TenSach
            // 
            dataGridViewTextBoxColumn_TenSach.DataPropertyName = "TenSach";
            dataGridViewTextBoxColumn_TenSach.HeaderText = "Tên sách";
            dataGridViewTextBoxColumn_TenSach.MinimumWidth = 6;
            dataGridViewTextBoxColumn_TenSach.Name = "dataGridViewTextBoxColumn_TenSach";
            // 
            // dataGridViewTextBoxColumn_TacGia
            // 
            dataGridViewTextBoxColumn_TacGia.DataPropertyName = "TacGia";
            dataGridViewTextBoxColumn_TacGia.HeaderText = "Tác giả";
            dataGridViewTextBoxColumn_TacGia.MinimumWidth = 6;
            dataGridViewTextBoxColumn_TacGia.Name = "dataGridViewTextBoxColumn_TacGia";
            // 
            // dataGridViewTextBoxColumn_SoLuong
            // 
            dataGridViewTextBoxColumn_SoLuong.DataPropertyName = "SoLuong";
            dataGridViewTextBoxColumn_SoLuong.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn_SoLuong.MinimumWidth = 6;
            dataGridViewTextBoxColumn_SoLuong.Name = "dataGridViewTextBoxColumn_SoLuong";
            // 
            // dataGridViewTextBoxColumn_TheLoai
            // 
            dataGridViewTextBoxColumn_TheLoai.DataPropertyName = "TheLoai";
            dataGridViewTextBoxColumn_TheLoai.HeaderText = "Thể loại";
            dataGridViewTextBoxColumn_TheLoai.MinimumWidth = 6;
            dataGridViewTextBoxColumn_TheLoai.Name = "dataGridViewTextBoxColumn_TheLoai";
            // 
            // tabControl_Sach
            // 
            tabControl_Sach.Controls.Add(tabPage_QuanLiSach);
            tabControl_Sach.Controls.Add(tabPage_PhieuNhapSach);
            tabControl_Sach.Dock = DockStyle.Fill;
            tabControl_Sach.Location = new Point(0, 0);
            tabControl_Sach.Name = "tabControl_Sach";
            tabControl_Sach.SelectedIndex = 0;
            tabControl_Sach.Size = new Size(782, 553);
            tabControl_Sach.TabIndex = 37;
            // 
            // tabPage_QuanLiSach
            // 
            tabPage_QuanLiSach.Controls.Add(dataGridView_Sach);
            tabPage_QuanLiSach.Controls.Add(groupBox_Sach);
            tabPage_QuanLiSach.Location = new Point(4, 29);
            tabPage_QuanLiSach.Name = "tabPage_QuanLiSach";
            tabPage_QuanLiSach.Padding = new Padding(3, 3, 3, 3);
            tabPage_QuanLiSach.Size = new Size(774, 520);
            tabPage_QuanLiSach.TabIndex = 0;
            tabPage_QuanLiSach.Text = "Quản lý sách";
            tabPage_QuanLiSach.UseVisualStyleBackColor = true;
            // 
            // tabPage_PhieuNhapSach
            // 
            tabPage_PhieuNhapSach.Controls.Add(groupBox1);
            tabPage_PhieuNhapSach.Controls.Add(dataGridView_PhieuNhapSach);
            tabPage_PhieuNhapSach.Location = new Point(4, 29);
            tabPage_PhieuNhapSach.Name = "tabPage_PhieuNhapSach";
            tabPage_PhieuNhapSach.Padding = new Padding(3, 3, 3, 3);
            tabPage_PhieuNhapSach.Size = new Size(774, 520);
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
            dataGridView_PhieuNhapSach.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView_PhieuNhapSach.DataSource = sachBindingSource;
            dataGridView_PhieuNhapSach.Dock = DockStyle.Fill;
            dataGridView_PhieuNhapSach.GridColor = SystemColors.ScrollBar;
            dataGridView_PhieuNhapSach.Location = new Point(3, 3);
            dataGridView_PhieuNhapSach.Name = "dataGridView_PhieuNhapSach";
            dataGridView_PhieuNhapSach.RightToLeft = RightToLeft.No;
            dataGridView_PhieuNhapSach.RowHeadersVisible = false;
            dataGridView_PhieuNhapSach.RowHeadersWidth = 51;
            dataGridView_PhieuNhapSach.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_PhieuNhapSach.Size = new Size(768, 514);
            dataGridView_PhieuNhapSach.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "MaSach";
            dataGridViewTextBoxColumn1.HeaderText = "Mã sách";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TenSach";
            dataGridViewTextBoxColumn2.HeaderText = "Tên sách";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "TacGia";
            dataGridViewTextBoxColumn3.HeaderText = "Tác giả";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "SoLuong";
            dataGridViewTextBoxColumn4.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "TheLoai";
            dataGridViewTextBoxColumn5.HeaderText = "Thể loại";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(iconButton1);
            groupBox1.Controls.Add(iconButton2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(iconButton3);
            groupBox1.Controls.Add(iconButton4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(iconButton5);
            groupBox1.Controls.Add(iconButton6);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(768, 396);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập liệu";
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Right;
            iconButton1.BackColor = Color.FromArgb(0, 192, 192);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 12F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.BottomCenter;
            iconButton1.Location = new Point(607, 140);
            iconButton1.Margin = new Padding(10);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(168, 84);
            iconButton1.TabIndex = 36;
            iconButton1.Text = "Bán sách";
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Right;
            iconButton2.BackColor = Color.FromArgb(255, 128, 255);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 12F);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.BottomCenter;
            iconButton2.Location = new Point(607, 40);
            iconButton2.Margin = new Padding(10);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(168, 84);
            iconButton2.TabIndex = 35;
            iconButton2.Text = "Nhập sách";
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(184, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 34);
            textBox1.TabIndex = 34;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(26, 231);
            label1.Margin = new Padding(3, 0, 20, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 40);
            label1.TabIndex = 33;
            label1.Text = "Thể loại";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(184, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(404, 34);
            textBox2.TabIndex = 32;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(26, 182);
            label2.Margin = new Padding(3, 0, 20, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 40);
            label2.TabIndex = 31;
            label2.Text = "Số lượng";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.None;
            iconButton3.BackColor = Color.FromArgb(255, 192, 128);
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 12F);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Filter;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton3.IconSize = 30;
            iconButton3.Location = new Point(486, 303);
            iconButton3.Margin = new Padding(10);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(80, 80);
            iconButton3.TabIndex = 30;
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.None;
            iconButton4.BackColor = Color.FromArgb(128, 128, 255);
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 12F);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton4.IconSize = 30;
            iconButton4.Location = new Point(386, 303);
            iconButton4.Margin = new Padding(10);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(80, 80);
            iconButton4.TabIndex = 29;
            iconButton4.TextAlign = ContentAlignment.MiddleRight;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(184, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(404, 34);
            textBox3.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(184, 86);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(404, 34);
            textBox4.TabIndex = 27;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(26, 133);
            label3.Margin = new Padding(3, 0, 20, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 40);
            label3.TabIndex = 24;
            label3.Text = "Tác giả";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(26, 84);
            label4.Margin = new Padding(3, 0, 20, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 40);
            label4.TabIndex = 23;
            label4.Text = "Tên sách";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(26, 35);
            label5.Margin = new Padding(3, 0, 20, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 40);
            label5.TabIndex = 22;
            label5.Text = "Mã sách";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(184, 35);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(404, 34);
            textBox5.TabIndex = 21;
            // 
            // iconButton5
            // 
            iconButton5.Anchor = AnchorStyles.None;
            iconButton5.BackColor = Color.FromArgb(255, 128, 128);
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI", 12F);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton5.IconSize = 30;
            iconButton5.Location = new Point(286, 303);
            iconButton5.Margin = new Padding(10);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(80, 80);
            iconButton5.TabIndex = 20;
            iconButton5.TextAlign = ContentAlignment.MiddleRight;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            iconButton6.Anchor = AnchorStyles.None;
            iconButton6.BackColor = Color.FromArgb(128, 255, 128);
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Segoe UI", 12F);
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton6.IconColor = Color.Black;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton6.IconSize = 30;
            iconButton6.Location = new Point(186, 303);
            iconButton6.Margin = new Padding(10);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(80, 80);
            iconButton6.TabIndex = 19;
            iconButton6.TextAlign = ContentAlignment.MiddleRight;
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // icon_Sach_Ban
            // 
            icon_Sach_Ban.Anchor = AnchorStyles.Right;
            icon_Sach_Ban.BackColor = Color.FromArgb(0, 192, 192);
            icon_Sach_Ban.FlatAppearance.BorderSize = 0;
            icon_Sach_Ban.FlatStyle = FlatStyle.Flat;
            icon_Sach_Ban.Font = new Font("Segoe UI", 12F);
            icon_Sach_Ban.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            icon_Sach_Ban.IconColor = Color.Black;
            icon_Sach_Ban.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Sach_Ban.IconSize = 30;
            icon_Sach_Ban.ImageAlign = ContentAlignment.BottomCenter;
            icon_Sach_Ban.Location = new Point(581, 133);
            icon_Sach_Ban.Margin = new Padding(10);
            icon_Sach_Ban.Name = "icon_Sach_Ban";
            icon_Sach_Ban.Size = new Size(168, 84);
            icon_Sach_Ban.TabIndex = 36;
            icon_Sach_Ban.Text = "Bán sách";
            icon_Sach_Ban.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_Sach_Ban.UseVisualStyleBackColor = false;
            // 
            // Form_Sach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(tabControl_Sach);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_MaSach;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_TenSach;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_TacGia;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_SoLuong;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_TheLoai;
        private FontAwesome.Sharp.IconButton icon_Sach_Nhap;
        private TabControl tabControl_Sach;
        private TabPage tabPage_QuanLiSach;
        private TabPage tabPage_PhieuNhapSach;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private DataGridView dataGridView_PhieuNhapSach;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private FontAwesome.Sharp.IconButton icon_Sach_Ban;
    }
}