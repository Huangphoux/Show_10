namespace Show10.Child_Forms {
    partial class Form_KhachHang {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox_KhachHang = new GroupBox();
            icon_KH_Clear = new FontAwesome.Sharp.IconButton();
            comboBox_KH_GioiTinh = new ComboBox();
            textBox_KH_TienNo = new TextBox();
            label_KH_TienNo = new Label();
            icon_KH_ThuTien = new FontAwesome.Sharp.IconButton();
            icon_KH_Loc = new FontAwesome.Sharp.IconButton();
            icon_KH_Tim = new FontAwesome.Sharp.IconButton();
            icon_KH_Xoa = new FontAwesome.Sharp.IconButton();
            icon_KH_Them = new FontAwesome.Sharp.IconButton();
            textBox_KH_DiaChi = new TextBox();
            label_KH_DiaChi = new Label();
            textBox_KH_Email = new TextBox();
            label_KH_Email = new Label();
            textBox_KH_TenKH = new TextBox();
            label_KH_GioiTinh = new Label();
            label_KH_TenKH = new Label();
            label_KH_MaKH = new Label();
            textBox_KH_MaKH = new TextBox();
            dataGridView_KhachHang = new DataGridView();
            maKHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenKHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gioiTinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaChiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tienNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            khachHangBindingSource = new BindingSource(components);
            tabControl_KhachHang = new TabControl();
            tabPage_KhachHang = new TabPage();
            tabPage_PhieuThuTien = new TabPage();
            dataGridView_PhieuThuTien = new DataGridView();
            maPTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maKHDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ngayThuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soTienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phieuThuTienBindingSource = new BindingSource(components);
            groupBox_PhieuThuTien = new GroupBox();
            label_PTT_Filter = new Label();
            date_PTT_Filter = new DateTimePicker();
            date_PTT_NgayThu = new DateTimePicker();
            icon_PTT_Clear = new FontAwesome.Sharp.IconButton();
            textBox_PTT_SoTien = new TextBox();
            label_PTT_SoTien = new Label();
            icon_PTT_Loc = new FontAwesome.Sharp.IconButton();
            icon_PTT_Tim = new FontAwesome.Sharp.IconButton();
            icon_PTT_Xoa = new FontAwesome.Sharp.IconButton();
            icon_PTT_Them = new FontAwesome.Sharp.IconButton();
            textBox_PTT_MaKH = new TextBox();
            label_PTT_NgayThu = new Label();
            label_PTT_MaKH = new Label();
            label_PTT_MaPhieu = new Label();
            textBox_PTT_MaPhieu = new TextBox();
            groupBox_KhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_KhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khachHangBindingSource).BeginInit();
            tabControl_KhachHang.SuspendLayout();
            tabPage_KhachHang.SuspendLayout();
            tabPage_PhieuThuTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_PhieuThuTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phieuThuTienBindingSource).BeginInit();
            groupBox_PhieuThuTien.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_KhachHang
            // 
            groupBox_KhachHang.Controls.Add(icon_KH_Clear);
            groupBox_KhachHang.Controls.Add(comboBox_KH_GioiTinh);
            groupBox_KhachHang.Controls.Add(textBox_KH_TienNo);
            groupBox_KhachHang.Controls.Add(label_KH_TienNo);
            groupBox_KhachHang.Controls.Add(icon_KH_ThuTien);
            groupBox_KhachHang.Controls.Add(icon_KH_Loc);
            groupBox_KhachHang.Controls.Add(icon_KH_Tim);
            groupBox_KhachHang.Controls.Add(icon_KH_Xoa);
            groupBox_KhachHang.Controls.Add(icon_KH_Them);
            groupBox_KhachHang.Controls.Add(textBox_KH_DiaChi);
            groupBox_KhachHang.Controls.Add(label_KH_DiaChi);
            groupBox_KhachHang.Controls.Add(textBox_KH_Email);
            groupBox_KhachHang.Controls.Add(label_KH_Email);
            groupBox_KhachHang.Controls.Add(textBox_KH_TenKH);
            groupBox_KhachHang.Controls.Add(label_KH_GioiTinh);
            groupBox_KhachHang.Controls.Add(label_KH_TenKH);
            groupBox_KhachHang.Controls.Add(label_KH_MaKH);
            groupBox_KhachHang.Controls.Add(textBox_KH_MaKH);
            groupBox_KhachHang.Dock = DockStyle.Top;
            groupBox_KhachHang.Location = new Point(3, 3);
            groupBox_KhachHang.Name = "groupBox_KhachHang";
            groupBox_KhachHang.Size = new Size(768, 385);
            groupBox_KhachHang.TabIndex = 0;
            groupBox_KhachHang.TabStop = false;
            groupBox_KhachHang.Text = "Nhập liệu";
            // 
            // icon_KH_Clear
            // 
            icon_KH_Clear.Anchor = AnchorStyles.None;
            icon_KH_Clear.BackColor = Color.White;
            icon_KH_Clear.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 255);
            icon_KH_Clear.FlatAppearance.BorderSize = 2;
            icon_KH_Clear.FlatStyle = FlatStyle.Flat;
            icon_KH_Clear.Font = new Font("Segoe UI", 12F);
            icon_KH_Clear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            icon_KH_Clear.IconColor = Color.FromArgb(255, 128, 255);
            icon_KH_Clear.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_KH_Clear.IconSize = 30;
            icon_KH_Clear.Location = new Point(536, 292);
            icon_KH_Clear.Margin = new Padding(10);
            icon_KH_Clear.Name = "icon_KH_Clear";
            icon_KH_Clear.Size = new Size(80, 80);
            icon_KH_Clear.TabIndex = 55;
            icon_KH_Clear.TextAlign = ContentAlignment.MiddleRight;
            icon_KH_Clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_KH_Clear.UseVisualStyleBackColor = false;
            icon_KH_Clear.Click += Icon_KH_Clear_Click;
            // 
            // comboBox_KH_GioiTinh
            // 
            comboBox_KH_GioiTinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_KH_GioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_KH_GioiTinh.FormattingEnabled = true;
            comboBox_KH_GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox_KH_GioiTinh.Location = new Point(136, 141);
            comboBox_KH_GioiTinh.Name = "comboBox_KH_GioiTinh";
            comboBox_KH_GioiTinh.Size = new Size(371, 36);
            comboBox_KH_GioiTinh.TabIndex = 54;
            comboBox_KH_GioiTinh.SelectedIndexChanged += ComboBox_KH_GioiTinh_SelectedIndexChanged;
            // 
            // textBox_KH_TienNo
            // 
            textBox_KH_TienNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_KH_TienNo.BorderStyle = BorderStyle.FixedSingle;
            textBox_KH_TienNo.Enabled = false;
            textBox_KH_TienNo.Font = new Font("Segoe UI", 12F);
            textBox_KH_TienNo.Location = new Point(375, 42);
            textBox_KH_TienNo.Name = "textBox_KH_TienNo";
            textBox_KH_TienNo.Size = new Size(132, 34);
            textBox_KH_TienNo.TabIndex = 51;
            textBox_KH_TienNo.TextChanged += TextBox_KH_TienNo_TextChanged;
            // 
            // label_KH_TienNo
            // 
            label_KH_TienNo.Font = new Font("Segoe UI", 12F);
            label_KH_TienNo.Location = new Point(269, 39);
            label_KH_TienNo.Margin = new Padding(3, 0, 20, 0);
            label_KH_TienNo.Name = "label_KH_TienNo";
            label_KH_TienNo.Size = new Size(110, 40);
            label_KH_TienNo.TabIndex = 50;
            label_KH_TienNo.Text = "Tiền nợ";
            label_KH_TienNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // icon_KH_ThuTien
            // 
            icon_KH_ThuTien.Anchor = AnchorStyles.Right;
            icon_KH_ThuTien.BackColor = Color.Black;
            icon_KH_ThuTien.FlatAppearance.BorderColor = Color.Green;
            icon_KH_ThuTien.FlatAppearance.BorderSize = 0;
            icon_KH_ThuTien.FlatStyle = FlatStyle.Flat;
            icon_KH_ThuTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icon_KH_ThuTien.ForeColor = Color.White;
            icon_KH_ThuTien.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            icon_KH_ThuTien.IconColor = Color.White;
            icon_KH_ThuTien.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_KH_ThuTien.IconSize = 30;
            icon_KH_ThuTien.ImageAlign = ContentAlignment.BottomCenter;
            icon_KH_ThuTien.Location = new Point(556, 39);
            icon_KH_ThuTien.Margin = new Padding(10);
            icon_KH_ThuTien.Name = "icon_KH_ThuTien";
            icon_KH_ThuTien.Size = new Size(174, 233);
            icon_KH_ThuTien.TabIndex = 49;
            icon_KH_ThuTien.Text = "Thu tiền";
            icon_KH_ThuTien.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_KH_ThuTien.UseVisualStyleBackColor = false;
            icon_KH_ThuTien.Click += Icon_KH_ThuTien_Click;
            // 
            // icon_KH_Loc
            // 
            icon_KH_Loc.Anchor = AnchorStyles.None;
            icon_KH_Loc.BackColor = Color.White;
            icon_KH_Loc.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            icon_KH_Loc.FlatAppearance.BorderSize = 2;
            icon_KH_Loc.FlatStyle = FlatStyle.Flat;
            icon_KH_Loc.Font = new Font("Segoe UI", 12F);
            icon_KH_Loc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            icon_KH_Loc.IconColor = Color.FromArgb(255, 192, 128);
            icon_KH_Loc.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_KH_Loc.IconSize = 30;
            icon_KH_Loc.Location = new Point(436, 292);
            icon_KH_Loc.Margin = new Padding(10);
            icon_KH_Loc.Name = "icon_KH_Loc";
            icon_KH_Loc.Size = new Size(80, 80);
            icon_KH_Loc.TabIndex = 48;
            icon_KH_Loc.TextAlign = ContentAlignment.MiddleRight;
            icon_KH_Loc.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_KH_Loc.UseVisualStyleBackColor = false;
            icon_KH_Loc.Click += Icon_KH_Loc_Click;
            // 
            // icon_KH_Tim
            // 
            icon_KH_Tim.Anchor = AnchorStyles.None;
            icon_KH_Tim.BackColor = Color.White;
            icon_KH_Tim.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            icon_KH_Tim.FlatAppearance.BorderSize = 2;
            icon_KH_Tim.FlatStyle = FlatStyle.Flat;
            icon_KH_Tim.Font = new Font("Segoe UI", 12F);
            icon_KH_Tim.IconChar = FontAwesome.Sharp.IconChar.Search;
            icon_KH_Tim.IconColor = Color.FromArgb(128, 128, 255);
            icon_KH_Tim.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_KH_Tim.IconSize = 30;
            icon_KH_Tim.Location = new Point(336, 292);
            icon_KH_Tim.Margin = new Padding(10);
            icon_KH_Tim.Name = "icon_KH_Tim";
            icon_KH_Tim.Size = new Size(80, 80);
            icon_KH_Tim.TabIndex = 47;
            icon_KH_Tim.TextAlign = ContentAlignment.MiddleRight;
            icon_KH_Tim.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_KH_Tim.UseVisualStyleBackColor = false;
            icon_KH_Tim.Click += Icon_KH_Tim_Click;
            // 
            // icon_KH_Xoa
            // 
            icon_KH_Xoa.Anchor = AnchorStyles.None;
            icon_KH_Xoa.BackColor = Color.Brown;
            icon_KH_Xoa.FlatAppearance.BorderSize = 0;
            icon_KH_Xoa.FlatStyle = FlatStyle.Flat;
            icon_KH_Xoa.Font = new Font("Segoe UI", 12F);
            icon_KH_Xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            icon_KH_Xoa.IconColor = Color.White;
            icon_KH_Xoa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_KH_Xoa.IconSize = 30;
            icon_KH_Xoa.Location = new Point(236, 292);
            icon_KH_Xoa.Margin = new Padding(10);
            icon_KH_Xoa.Name = "icon_KH_Xoa";
            icon_KH_Xoa.Size = new Size(80, 80);
            icon_KH_Xoa.TabIndex = 46;
            icon_KH_Xoa.TextAlign = ContentAlignment.MiddleRight;
            icon_KH_Xoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_KH_Xoa.UseVisualStyleBackColor = false;
            icon_KH_Xoa.Click += Icon_KH_Xoa_Click;
            // 
            // icon_KH_Them
            // 
            icon_KH_Them.Anchor = AnchorStyles.None;
            icon_KH_Them.BackColor = Color.Green;
            icon_KH_Them.FlatAppearance.BorderSize = 0;
            icon_KH_Them.FlatStyle = FlatStyle.Flat;
            icon_KH_Them.Font = new Font("Segoe UI", 12F);
            icon_KH_Them.IconChar = FontAwesome.Sharp.IconChar.Add;
            icon_KH_Them.IconColor = Color.White;
            icon_KH_Them.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_KH_Them.IconSize = 30;
            icon_KH_Them.Location = new Point(136, 292);
            icon_KH_Them.Margin = new Padding(10);
            icon_KH_Them.Name = "icon_KH_Them";
            icon_KH_Them.Size = new Size(80, 80);
            icon_KH_Them.TabIndex = 45;
            icon_KH_Them.TextAlign = ContentAlignment.MiddleRight;
            icon_KH_Them.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_KH_Them.UseVisualStyleBackColor = false;
            icon_KH_Them.Click += Icon_KH_Them_Click;
            // 
            // textBox_KH_DiaChi
            // 
            textBox_KH_DiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_KH_DiaChi.BorderStyle = BorderStyle.FixedSingle;
            textBox_KH_DiaChi.Font = new Font("Segoe UI", 12F);
            textBox_KH_DiaChi.Location = new Point(136, 237);
            textBox_KH_DiaChi.Name = "textBox_KH_DiaChi";
            textBox_KH_DiaChi.Size = new Size(371, 34);
            textBox_KH_DiaChi.TabIndex = 44;
            textBox_KH_DiaChi.TextChanged += TextBox_KH_DiaChi_TextChanged;
            // 
            // label_KH_DiaChi
            // 
            label_KH_DiaChi.Font = new Font("Segoe UI", 12F);
            label_KH_DiaChi.Location = new Point(27, 235);
            label_KH_DiaChi.Margin = new Padding(3, 0, 20, 0);
            label_KH_DiaChi.Name = "label_KH_DiaChi";
            label_KH_DiaChi.Size = new Size(110, 40);
            label_KH_DiaChi.TabIndex = 43;
            label_KH_DiaChi.Text = "Địa chỉ";
            label_KH_DiaChi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_KH_Email
            // 
            textBox_KH_Email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_KH_Email.BorderStyle = BorderStyle.FixedSingle;
            textBox_KH_Email.Font = new Font("Segoe UI", 12F);
            textBox_KH_Email.Location = new Point(136, 188);
            textBox_KH_Email.Name = "textBox_KH_Email";
            textBox_KH_Email.Size = new Size(371, 34);
            textBox_KH_Email.TabIndex = 42;
            textBox_KH_Email.TextChanged += TextBox_KH_Email_TextChanged;
            // 
            // label_KH_Email
            // 
            label_KH_Email.Font = new Font("Segoe UI", 12F);
            label_KH_Email.Location = new Point(27, 186);
            label_KH_Email.Margin = new Padding(3, 0, 20, 0);
            label_KH_Email.Name = "label_KH_Email";
            label_KH_Email.Size = new Size(110, 40);
            label_KH_Email.TabIndex = 41;
            label_KH_Email.Text = "Email";
            label_KH_Email.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_KH_TenKH
            // 
            textBox_KH_TenKH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_KH_TenKH.BorderStyle = BorderStyle.FixedSingle;
            textBox_KH_TenKH.Font = new Font("Segoe UI", 12F);
            textBox_KH_TenKH.Location = new Point(136, 90);
            textBox_KH_TenKH.Name = "textBox_KH_TenKH";
            textBox_KH_TenKH.Size = new Size(371, 34);
            textBox_KH_TenKH.TabIndex = 39;
            textBox_KH_TenKH.TextChanged += TextBox_KH_TenKH_TextChanged;
            // 
            // label_KH_GioiTinh
            // 
            label_KH_GioiTinh.Font = new Font("Segoe UI", 12F);
            label_KH_GioiTinh.Location = new Point(27, 137);
            label_KH_GioiTinh.Margin = new Padding(3, 0, 20, 0);
            label_KH_GioiTinh.Name = "label_KH_GioiTinh";
            label_KH_GioiTinh.Size = new Size(110, 40);
            label_KH_GioiTinh.TabIndex = 38;
            label_KH_GioiTinh.Text = "Giới tính";
            label_KH_GioiTinh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_KH_TenKH
            // 
            label_KH_TenKH.Font = new Font("Segoe UI", 12F);
            label_KH_TenKH.Location = new Point(27, 88);
            label_KH_TenKH.Margin = new Padding(3, 0, 20, 0);
            label_KH_TenKH.Name = "label_KH_TenKH";
            label_KH_TenKH.Size = new Size(110, 40);
            label_KH_TenKH.TabIndex = 37;
            label_KH_TenKH.Text = "Tên KH";
            label_KH_TenKH.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_KH_MaKH
            // 
            label_KH_MaKH.Font = new Font("Segoe UI", 12F);
            label_KH_MaKH.Location = new Point(27, 39);
            label_KH_MaKH.Margin = new Padding(3, 0, 20, 0);
            label_KH_MaKH.Name = "label_KH_MaKH";
            label_KH_MaKH.Size = new Size(99, 40);
            label_KH_MaKH.TabIndex = 36;
            label_KH_MaKH.Text = "Mã KH";
            label_KH_MaKH.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_KH_MaKH
            // 
            textBox_KH_MaKH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_KH_MaKH.BorderStyle = BorderStyle.FixedSingle;
            textBox_KH_MaKH.Font = new Font("Segoe UI", 12F);
            textBox_KH_MaKH.Location = new Point(136, 42);
            textBox_KH_MaKH.Name = "textBox_KH_MaKH";
            textBox_KH_MaKH.Size = new Size(127, 34);
            textBox_KH_MaKH.TabIndex = 35;
            textBox_KH_MaKH.TextChanged += TextBox_KH_MaKH_TextChanged;
            // 
            // dataGridView_KhachHang
            // 
            dataGridView_KhachHang.AllowUserToAddRows = false;
            dataGridView_KhachHang.AllowUserToDeleteRows = false;
            dataGridView_KhachHang.AutoGenerateColumns = false;
            dataGridView_KhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_KhachHang.BackgroundColor = Color.White;
            dataGridView_KhachHang.BorderStyle = BorderStyle.None;
            dataGridView_KhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Green;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_KhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_KhachHang.Columns.AddRange(new DataGridViewColumn[] { maKHDataGridViewTextBoxColumn, tenKHDataGridViewTextBoxColumn, gioiTinhDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, diaChiDataGridViewTextBoxColumn, tienNoDataGridViewTextBoxColumn });
            dataGridView_KhachHang.DataSource = khachHangBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_KhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_KhachHang.Dock = DockStyle.Fill;
            dataGridView_KhachHang.EnableHeadersVisualStyles = false;
            dataGridView_KhachHang.GridColor = Color.Black;
            dataGridView_KhachHang.Location = new Point(3, 388);
            dataGridView_KhachHang.Name = "dataGridView_KhachHang";
            dataGridView_KhachHang.RightToLeft = RightToLeft.No;
            dataGridView_KhachHang.RowHeadersVisible = false;
            dataGridView_KhachHang.RowHeadersWidth = 51;
            dataGridView_KhachHang.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_KhachHang.Size = new Size(768, 121);
            dataGridView_KhachHang.TabIndex = 3;
            dataGridView_KhachHang.CellValueChanged += DataGridView_KhachHang_CellValueChanged;
            dataGridView_KhachHang.SelectionChanged += DataGridView_KhachHang_SelectionChanged;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            maKHDataGridViewTextBoxColumn.HeaderText = "Mã KH";
            maKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            maKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            tenKHDataGridViewTextBoxColumn.HeaderText = "Tên KH";
            tenKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // tienNoDataGridViewTextBoxColumn
            // 
            tienNoDataGridViewTextBoxColumn.DataPropertyName = "TienNo";
            tienNoDataGridViewTextBoxColumn.HeaderText = "Tiền nợ";
            tienNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tienNoDataGridViewTextBoxColumn.Name = "tienNoDataGridViewTextBoxColumn";
            // 
            // khachHangBindingSource
            // 
            khachHangBindingSource.DataSource = typeof(Models.KhachHang);
            // 
            // tabControl_KhachHang
            // 
            tabControl_KhachHang.Controls.Add(tabPage_KhachHang);
            tabControl_KhachHang.Controls.Add(tabPage_PhieuThuTien);
            tabControl_KhachHang.Dock = DockStyle.Fill;
            tabControl_KhachHang.Location = new Point(0, 0);
            tabControl_KhachHang.Name = "tabControl_KhachHang";
            tabControl_KhachHang.SelectedIndex = 0;
            tabControl_KhachHang.Size = new Size(782, 553);
            tabControl_KhachHang.TabIndex = 54;
            tabControl_KhachHang.SelectedIndexChanged += TabControl_KhachHang_SelectedIndexChanged;
            // 
            // tabPage_KhachHang
            // 
            tabPage_KhachHang.Controls.Add(dataGridView_KhachHang);
            tabPage_KhachHang.Controls.Add(groupBox_KhachHang);
            tabPage_KhachHang.Location = new Point(4, 37);
            tabPage_KhachHang.Name = "tabPage_KhachHang";
            tabPage_KhachHang.Padding = new Padding(3);
            tabPage_KhachHang.Size = new Size(774, 512);
            tabPage_KhachHang.TabIndex = 0;
            tabPage_KhachHang.Text = "Quản lý khách hàng";
            tabPage_KhachHang.UseVisualStyleBackColor = true;
            // 
            // tabPage_PhieuThuTien
            // 
            tabPage_PhieuThuTien.Controls.Add(dataGridView_PhieuThuTien);
            tabPage_PhieuThuTien.Controls.Add(groupBox_PhieuThuTien);
            tabPage_PhieuThuTien.Location = new Point(4, 37);
            tabPage_PhieuThuTien.Name = "tabPage_PhieuThuTien";
            tabPage_PhieuThuTien.Padding = new Padding(3);
            tabPage_PhieuThuTien.Size = new Size(774, 512);
            tabPage_PhieuThuTien.TabIndex = 1;
            tabPage_PhieuThuTien.Text = "Quản lý phiếu thu tiền";
            tabPage_PhieuThuTien.UseVisualStyleBackColor = true;
            // 
            // dataGridView_PhieuThuTien
            // 
            dataGridView_PhieuThuTien.AllowUserToAddRows = false;
            dataGridView_PhieuThuTien.AllowUserToDeleteRows = false;
            dataGridView_PhieuThuTien.AutoGenerateColumns = false;
            dataGridView_PhieuThuTien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_PhieuThuTien.BackgroundColor = Color.White;
            dataGridView_PhieuThuTien.BorderStyle = BorderStyle.None;
            dataGridView_PhieuThuTien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Green;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_PhieuThuTien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_PhieuThuTien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_PhieuThuTien.Columns.AddRange(new DataGridViewColumn[] { maPTDataGridViewTextBoxColumn, maKHDataGridViewTextBoxColumn1, ngayThuDataGridViewTextBoxColumn, soTienDataGridViewTextBoxColumn });
            dataGridView_PhieuThuTien.DataSource = phieuThuTienBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView_PhieuThuTien.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_PhieuThuTien.Dock = DockStyle.Fill;
            dataGridView_PhieuThuTien.EnableHeadersVisualStyles = false;
            dataGridView_PhieuThuTien.GridColor = Color.Black;
            dataGridView_PhieuThuTien.Location = new Point(3, 266);
            dataGridView_PhieuThuTien.Name = "dataGridView_PhieuThuTien";
            dataGridView_PhieuThuTien.RightToLeft = RightToLeft.No;
            dataGridView_PhieuThuTien.RowHeadersVisible = false;
            dataGridView_PhieuThuTien.RowHeadersWidth = 51;
            dataGridView_PhieuThuTien.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_PhieuThuTien.Size = new Size(768, 243);
            dataGridView_PhieuThuTien.TabIndex = 4;
            dataGridView_PhieuThuTien.CellValueChanged += DataGridView_PhieuThuTien_CellValueChanged;
            dataGridView_PhieuThuTien.SelectionChanged += DataGridView_PhieuThuTien_SelectionChanged;
            // 
            // maPTDataGridViewTextBoxColumn
            // 
            maPTDataGridViewTextBoxColumn.DataPropertyName = "MaPT";
            maPTDataGridViewTextBoxColumn.HeaderText = "Mã phiếu";
            maPTDataGridViewTextBoxColumn.MinimumWidth = 6;
            maPTDataGridViewTextBoxColumn.Name = "maPTDataGridViewTextBoxColumn";
            maPTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maKHDataGridViewTextBoxColumn1
            // 
            maKHDataGridViewTextBoxColumn1.DataPropertyName = "MaKH";
            maKHDataGridViewTextBoxColumn1.HeaderText = "Mã khách hàng";
            maKHDataGridViewTextBoxColumn1.MinimumWidth = 6;
            maKHDataGridViewTextBoxColumn1.Name = "maKHDataGridViewTextBoxColumn1";
            // 
            // ngayThuDataGridViewTextBoxColumn
            // 
            ngayThuDataGridViewTextBoxColumn.DataPropertyName = "NgayThu";
            ngayThuDataGridViewTextBoxColumn.HeaderText = "Ngày thu";
            ngayThuDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngayThuDataGridViewTextBoxColumn.Name = "ngayThuDataGridViewTextBoxColumn";
            // 
            // soTienDataGridViewTextBoxColumn
            // 
            soTienDataGridViewTextBoxColumn.DataPropertyName = "SoTien";
            soTienDataGridViewTextBoxColumn.HeaderText = "Số tiền";
            soTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            soTienDataGridViewTextBoxColumn.Name = "soTienDataGridViewTextBoxColumn";
            // 
            // phieuThuTienBindingSource
            // 
            phieuThuTienBindingSource.DataSource = typeof(Models.PhieuThuTien);
            // 
            // groupBox_PhieuThuTien
            // 
            groupBox_PhieuThuTien.Controls.Add(label_PTT_Filter);
            groupBox_PhieuThuTien.Controls.Add(date_PTT_Filter);
            groupBox_PhieuThuTien.Controls.Add(date_PTT_NgayThu);
            groupBox_PhieuThuTien.Controls.Add(icon_PTT_Clear);
            groupBox_PhieuThuTien.Controls.Add(textBox_PTT_SoTien);
            groupBox_PhieuThuTien.Controls.Add(label_PTT_SoTien);
            groupBox_PhieuThuTien.Controls.Add(icon_PTT_Loc);
            groupBox_PhieuThuTien.Controls.Add(icon_PTT_Tim);
            groupBox_PhieuThuTien.Controls.Add(icon_PTT_Xoa);
            groupBox_PhieuThuTien.Controls.Add(icon_PTT_Them);
            groupBox_PhieuThuTien.Controls.Add(textBox_PTT_MaKH);
            groupBox_PhieuThuTien.Controls.Add(label_PTT_NgayThu);
            groupBox_PhieuThuTien.Controls.Add(label_PTT_MaKH);
            groupBox_PhieuThuTien.Controls.Add(label_PTT_MaPhieu);
            groupBox_PhieuThuTien.Controls.Add(textBox_PTT_MaPhieu);
            groupBox_PhieuThuTien.Dock = DockStyle.Top;
            groupBox_PhieuThuTien.Location = new Point(3, 3);
            groupBox_PhieuThuTien.Name = "groupBox_PhieuThuTien";
            groupBox_PhieuThuTien.Size = new Size(768, 263);
            groupBox_PhieuThuTien.TabIndex = 5;
            groupBox_PhieuThuTien.TabStop = false;
            groupBox_PhieuThuTien.Text = "Nhập liệu";
            // 
            // label_PTT_Filter
            // 
            label_PTT_Filter.Font = new Font("Segoe UI", 12F);
            label_PTT_Filter.ImageAlign = ContentAlignment.BottomLeft;
            label_PTT_Filter.Location = new Point(354, 109);
            label_PTT_Filter.Margin = new Padding(4, 0, 28, 0);
            label_PTT_Filter.Name = "label_PTT_Filter";
            label_PTT_Filter.Size = new Size(93, 30);
            label_PTT_Filter.TabIndex = 59;
            label_PTT_Filter.Text = "→";
            label_PTT_Filter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // date_PTT_Filter
            // 
            date_PTT_Filter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            date_PTT_Filter.Enabled = false;
            date_PTT_Filter.Format = DateTimePickerFormat.Short;
            date_PTT_Filter.Location = new Point(495, 107);
            date_PTT_Filter.Name = "date_PTT_Filter";
            date_PTT_Filter.Size = new Size(137, 34);
            date_PTT_Filter.TabIndex = 58;
            // 
            // date_PTT_NgayThu
            // 
            date_PTT_NgayThu.Format = DateTimePickerFormat.Short;
            date_PTT_NgayThu.Location = new Point(169, 107);
            date_PTT_NgayThu.Name = "date_PTT_NgayThu";
            date_PTT_NgayThu.Size = new Size(137, 34);
            date_PTT_NgayThu.TabIndex = 57;
            // 
            // icon_PTT_Clear
            // 
            icon_PTT_Clear.Anchor = AnchorStyles.None;
            icon_PTT_Clear.BackColor = Color.White;
            icon_PTT_Clear.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 255);
            icon_PTT_Clear.FlatAppearance.BorderSize = 2;
            icon_PTT_Clear.FlatStyle = FlatStyle.Flat;
            icon_PTT_Clear.Font = new Font("Segoe UI", 12F);
            icon_PTT_Clear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            icon_PTT_Clear.IconColor = Color.FromArgb(255, 128, 255);
            icon_PTT_Clear.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_PTT_Clear.IconSize = 30;
            icon_PTT_Clear.Location = new Point(544, 170);
            icon_PTT_Clear.Margin = new Padding(10);
            icon_PTT_Clear.Name = "icon_PTT_Clear";
            icon_PTT_Clear.Size = new Size(80, 80);
            icon_PTT_Clear.TabIndex = 56;
            icon_PTT_Clear.TextAlign = ContentAlignment.MiddleRight;
            icon_PTT_Clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_PTT_Clear.UseVisualStyleBackColor = false;
            icon_PTT_Clear.Click += Icon_PTT_Clear_Click;
            // 
            // textBox_PTT_SoTien
            // 
            textBox_PTT_SoTien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_PTT_SoTien.BorderStyle = BorderStyle.FixedSingle;
            textBox_PTT_SoTien.Font = new Font("Segoe UI", 12F);
            textBox_PTT_SoTien.Location = new Point(624, 45);
            textBox_PTT_SoTien.Name = "textBox_PTT_SoTien";
            textBox_PTT_SoTien.Size = new Size(106, 34);
            textBox_PTT_SoTien.TabIndex = 50;
            textBox_PTT_SoTien.TextChanged += TextBox_PTT_SoTien_TextChanged;
            // 
            // label_PTT_SoTien
            // 
            label_PTT_SoTien.Font = new Font("Segoe UI", 12F);
            label_PTT_SoTien.Location = new Point(503, 42);
            label_PTT_SoTien.Margin = new Padding(3, 0, 20, 0);
            label_PTT_SoTien.Name = "label_PTT_SoTien";
            label_PTT_SoTien.Size = new Size(94, 40);
            label_PTT_SoTien.TabIndex = 49;
            label_PTT_SoTien.Text = "Số tiền";
            label_PTT_SoTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // icon_PTT_Loc
            // 
            icon_PTT_Loc.Anchor = AnchorStyles.None;
            icon_PTT_Loc.BackColor = Color.White;
            icon_PTT_Loc.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            icon_PTT_Loc.FlatAppearance.BorderSize = 2;
            icon_PTT_Loc.FlatStyle = FlatStyle.Flat;
            icon_PTT_Loc.Font = new Font("Segoe UI", 12F);
            icon_PTT_Loc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            icon_PTT_Loc.IconColor = Color.FromArgb(255, 192, 128);
            icon_PTT_Loc.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_PTT_Loc.IconSize = 30;
            icon_PTT_Loc.Location = new Point(444, 170);
            icon_PTT_Loc.Margin = new Padding(10);
            icon_PTT_Loc.Name = "icon_PTT_Loc";
            icon_PTT_Loc.Size = new Size(80, 80);
            icon_PTT_Loc.TabIndex = 48;
            icon_PTT_Loc.TextAlign = ContentAlignment.MiddleRight;
            icon_PTT_Loc.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_PTT_Loc.UseVisualStyleBackColor = false;
            icon_PTT_Loc.Click += Icon_PTT_Loc_Click;
            // 
            // icon_PTT_Tim
            // 
            icon_PTT_Tim.Anchor = AnchorStyles.None;
            icon_PTT_Tim.BackColor = Color.White;
            icon_PTT_Tim.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            icon_PTT_Tim.FlatAppearance.BorderSize = 2;
            icon_PTT_Tim.FlatStyle = FlatStyle.Flat;
            icon_PTT_Tim.Font = new Font("Segoe UI", 12F);
            icon_PTT_Tim.IconChar = FontAwesome.Sharp.IconChar.Search;
            icon_PTT_Tim.IconColor = Color.FromArgb(128, 128, 255);
            icon_PTT_Tim.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_PTT_Tim.IconSize = 30;
            icon_PTT_Tim.Location = new Point(344, 170);
            icon_PTT_Tim.Margin = new Padding(10);
            icon_PTT_Tim.Name = "icon_PTT_Tim";
            icon_PTT_Tim.Size = new Size(80, 80);
            icon_PTT_Tim.TabIndex = 47;
            icon_PTT_Tim.TextAlign = ContentAlignment.MiddleRight;
            icon_PTT_Tim.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_PTT_Tim.UseVisualStyleBackColor = false;
            icon_PTT_Tim.Click += Icon_PTT_Tim_Click;
            // 
            // icon_PTT_Xoa
            // 
            icon_PTT_Xoa.Anchor = AnchorStyles.None;
            icon_PTT_Xoa.BackColor = Color.Brown;
            icon_PTT_Xoa.FlatAppearance.BorderSize = 0;
            icon_PTT_Xoa.FlatStyle = FlatStyle.Flat;
            icon_PTT_Xoa.Font = new Font("Segoe UI", 12F);
            icon_PTT_Xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            icon_PTT_Xoa.IconColor = Color.White;
            icon_PTT_Xoa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_PTT_Xoa.IconSize = 30;
            icon_PTT_Xoa.Location = new Point(244, 170);
            icon_PTT_Xoa.Margin = new Padding(10);
            icon_PTT_Xoa.Name = "icon_PTT_Xoa";
            icon_PTT_Xoa.Size = new Size(80, 80);
            icon_PTT_Xoa.TabIndex = 46;
            icon_PTT_Xoa.TextAlign = ContentAlignment.MiddleRight;
            icon_PTT_Xoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_PTT_Xoa.UseVisualStyleBackColor = false;
            icon_PTT_Xoa.Click += Icon_PTT_Xoa_Click;
            // 
            // icon_PTT_Them
            // 
            icon_PTT_Them.Anchor = AnchorStyles.None;
            icon_PTT_Them.BackColor = Color.Green;
            icon_PTT_Them.FlatAppearance.BorderSize = 0;
            icon_PTT_Them.FlatStyle = FlatStyle.Flat;
            icon_PTT_Them.Font = new Font("Segoe UI", 12F);
            icon_PTT_Them.IconChar = FontAwesome.Sharp.IconChar.Add;
            icon_PTT_Them.IconColor = Color.White;
            icon_PTT_Them.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_PTT_Them.IconSize = 30;
            icon_PTT_Them.Location = new Point(144, 170);
            icon_PTT_Them.Margin = new Padding(10);
            icon_PTT_Them.Name = "icon_PTT_Them";
            icon_PTT_Them.Size = new Size(80, 80);
            icon_PTT_Them.TabIndex = 45;
            icon_PTT_Them.TextAlign = ContentAlignment.MiddleRight;
            icon_PTT_Them.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_PTT_Them.UseVisualStyleBackColor = false;
            icon_PTT_Them.Click += Icon_PTT_Them_Click;
            // 
            // textBox_PTT_MaKH
            // 
            textBox_PTT_MaKH.BorderStyle = BorderStyle.FixedSingle;
            textBox_PTT_MaKH.Font = new Font("Segoe UI", 12F);
            textBox_PTT_MaKH.Location = new Point(386, 45);
            textBox_PTT_MaKH.Name = "textBox_PTT_MaKH";
            textBox_PTT_MaKH.Size = new Size(106, 34);
            textBox_PTT_MaKH.TabIndex = 39;
            textBox_PTT_MaKH.TextChanged += TextBox_PTT_MaKH_TextChanged;
            // 
            // label_PTT_NgayThu
            // 
            label_PTT_NgayThu.Font = new Font("Segoe UI", 12F);
            label_PTT_NgayThu.Location = new Point(27, 104);
            label_PTT_NgayThu.Margin = new Padding(3, 0, 20, 0);
            label_PTT_NgayThu.Name = "label_PTT_NgayThu";
            label_PTT_NgayThu.Size = new Size(94, 40);
            label_PTT_NgayThu.TabIndex = 38;
            label_PTT_NgayThu.Text = "Ngày thu";
            label_PTT_NgayThu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_PTT_MaKH
            // 
            label_PTT_MaKH.Font = new Font("Segoe UI", 12F);
            label_PTT_MaKH.Location = new Point(265, 42);
            label_PTT_MaKH.Margin = new Padding(3, 0, 20, 0);
            label_PTT_MaKH.Name = "label_PTT_MaKH";
            label_PTT_MaKH.Size = new Size(94, 40);
            label_PTT_MaKH.TabIndex = 37;
            label_PTT_MaKH.Text = "Mã KH";
            label_PTT_MaKH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_PTT_MaPhieu
            // 
            label_PTT_MaPhieu.Font = new Font("Segoe UI", 12F);
            label_PTT_MaPhieu.Location = new Point(27, 42);
            label_PTT_MaPhieu.Margin = new Padding(3, 0, 20, 0);
            label_PTT_MaPhieu.Name = "label_PTT_MaPhieu";
            label_PTT_MaPhieu.Size = new Size(94, 40);
            label_PTT_MaPhieu.TabIndex = 36;
            label_PTT_MaPhieu.Text = "Mã phiếu";
            label_PTT_MaPhieu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_PTT_MaPhieu
            // 
            textBox_PTT_MaPhieu.BorderStyle = BorderStyle.FixedSingle;
            textBox_PTT_MaPhieu.Font = new Font("Segoe UI", 12F);
            textBox_PTT_MaPhieu.Location = new Point(148, 45);
            textBox_PTT_MaPhieu.Name = "textBox_PTT_MaPhieu";
            textBox_PTT_MaPhieu.Size = new Size(106, 34);
            textBox_PTT_MaPhieu.TabIndex = 35;
            textBox_PTT_MaPhieu.TextChanged += TextBox_PTT_MaPhieu_TextChanged;
            // 
            // Form_KhachHang
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(tabControl_KhachHang);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form_KhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_KhachHang";
            FormClosing += Form_KhachHang_FormClosing;
            Load += Form_KhachHang_Load;
            groupBox_KhachHang.ResumeLayout(false);
            groupBox_KhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_KhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)khachHangBindingSource).EndInit();
            tabControl_KhachHang.ResumeLayout(false);
            tabPage_KhachHang.ResumeLayout(false);
            tabPage_PhieuThuTien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_PhieuThuTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)phieuThuTienBindingSource).EndInit();
            groupBox_PhieuThuTien.ResumeLayout(false);
            groupBox_PhieuThuTien.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_KhachHang;
        private TextBox textBox_KH_DiaChi;
        private Label label_KH_DiaChi;
        private TextBox textBox_KH_Email;
        private Label label_KH_Email;
        private TextBox textBox_KH_TenKH;
        private Label label_KH_GioiTinh;
        private Label label_KH_TenKH;
        private Label label_KH_MaKH;
        private TextBox textBox_KH_MaKH;
        private FontAwesome.Sharp.IconButton icon_KH_Loc;
        private FontAwesome.Sharp.IconButton icon_KH_Tim;
        private FontAwesome.Sharp.IconButton icon_KH_Xoa;
        private FontAwesome.Sharp.IconButton icon_KH_Them;
        private FontAwesome.Sharp.IconButton icon_KH_ThuTien;
        private TextBox textBox_KH_TienNo;
        private Label label_KH_TienNo;
        private DataGridView dataGridView_KhachHang;
        private DataGridViewTextBoxColumn tenTKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vaiTroDataGridViewTextBoxColumn;
        private BindingSource khachHangBindingSource;
        private DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tienNoDataGridViewTextBoxColumn;
        private TabControl tabControl_KhachHang;
        private TabPage tabPage_KhachHang;
        private TabPage tabPage_PhieuThuTien;
        private DataGridView dataGridView_PhieuThuTien;
        private GroupBox groupBox_PhieuThuTien;
        private FontAwesome.Sharp.IconButton icon_PTT_Loc;
        private FontAwesome.Sharp.IconButton icon_PTT_Tim;
        private FontAwesome.Sharp.IconButton icon_PTT_Xoa;
        private FontAwesome.Sharp.IconButton icon_PTT_Them;
        private TextBox textBox_PTT_MaKH;
        private Label label_PTT_NgayThu;
        private Label label_PTT_MaKH;
        private Label label_PTT_MaPhieu;
        private TextBox textBox_PTT_MaPhieu;
        private ComboBox comboBox_KH_GioiTinh;
        private FontAwesome.Sharp.IconButton icon_KH_Clear;
        private TextBox textBox_PTT_SoTien;
        private Label label_PTT_SoTien;
        private FontAwesome.Sharp.IconButton icon_PTT_Clear;
        private BindingSource phieuThuTienBindingSource;
        private DataGridViewTextBoxColumn maPTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ngayThuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soTienDataGridViewTextBoxColumn;
        private DateTimePicker date_PTT_NgayThu;
        private Label label_PTT_Filter;
        private DateTimePicker date_PTT_Filter;
    }
}