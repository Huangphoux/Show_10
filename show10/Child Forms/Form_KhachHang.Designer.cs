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
            groupBox_KhachHang = new GroupBox();
            textBox_KH_SDT = new TextBox();
            label_KH_SDT = new Label();
            textBox_KH_TienNo = new TextBox();
            label_KH_TienNo = new Label();
            icon_Sach_Ban = new FontAwesome.Sharp.IconButton();
            icon_KH_Loc = new FontAwesome.Sharp.IconButton();
            icon_KH_Tim = new FontAwesome.Sharp.IconButton();
            icon_KH_Xoa = new FontAwesome.Sharp.IconButton();
            icon_KH_Them = new FontAwesome.Sharp.IconButton();
            textBox_TheLoai = new TextBox();
            label_KH_DiaChi = new Label();
            textBox_SoLuong = new TextBox();
            label_KH_Email = new Label();
            textBox_Sach_TacGia = new TextBox();
            textBox_Sach_TenSach = new TextBox();
            label_KH_GioiTinh = new Label();
            label_KH_TenKH = new Label();
            label_KH_MaKH = new Label();
            textBox_Sach_MaSach = new TextBox();
            dataGridView_KhachHang = new DataGridView();
            maKHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenKHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gioiTinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaChiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tienNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            khachHangBindingSource = new BindingSource(components);
            groupBox_KhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_KhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khachHangBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox_KhachHang
            // 
            groupBox_KhachHang.Controls.Add(textBox_KH_SDT);
            groupBox_KhachHang.Controls.Add(label_KH_SDT);
            groupBox_KhachHang.Controls.Add(textBox_KH_TienNo);
            groupBox_KhachHang.Controls.Add(label_KH_TienNo);
            groupBox_KhachHang.Controls.Add(icon_Sach_Ban);
            groupBox_KhachHang.Controls.Add(icon_KH_Loc);
            groupBox_KhachHang.Controls.Add(icon_KH_Tim);
            groupBox_KhachHang.Controls.Add(icon_KH_Xoa);
            groupBox_KhachHang.Controls.Add(icon_KH_Them);
            groupBox_KhachHang.Controls.Add(textBox_TheLoai);
            groupBox_KhachHang.Controls.Add(label_KH_DiaChi);
            groupBox_KhachHang.Controls.Add(textBox_SoLuong);
            groupBox_KhachHang.Controls.Add(label_KH_Email);
            groupBox_KhachHang.Controls.Add(textBox_Sach_TacGia);
            groupBox_KhachHang.Controls.Add(textBox_Sach_TenSach);
            groupBox_KhachHang.Controls.Add(label_KH_GioiTinh);
            groupBox_KhachHang.Controls.Add(label_KH_TenKH);
            groupBox_KhachHang.Controls.Add(label_KH_MaKH);
            groupBox_KhachHang.Controls.Add(textBox_Sach_MaSach);
            groupBox_KhachHang.Dock = DockStyle.Top;
            groupBox_KhachHang.Location = new Point(0, 0);
            groupBox_KhachHang.Name = "groupBox_KhachHang";
            groupBox_KhachHang.Size = new Size(782, 406);
            groupBox_KhachHang.TabIndex = 0;
            groupBox_KhachHang.TabStop = false;
            groupBox_KhachHang.Text = "Nhập liệu";
            // 
            // textBox_KH_SDT
            // 
            textBox_KH_SDT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_KH_SDT.Font = new Font("Segoe UI", 12F);
            textBox_KH_SDT.Location = new Point(185, 335);
            textBox_KH_SDT.Name = "textBox_KH_SDT";
            textBox_KH_SDT.Size = new Size(380, 34);
            textBox_KH_SDT.TabIndex = 53;
            // 
            // label_KH_SDT
            // 
            label_KH_SDT.Font = new Font("Segoe UI", 12F);
            label_KH_SDT.Location = new Point(27, 333);
            label_KH_SDT.Margin = new Padding(3, 0, 20, 0);
            label_KH_SDT.Name = "label_KH_SDT";
            label_KH_SDT.Size = new Size(135, 40);
            label_KH_SDT.TabIndex = 52;
            label_KH_SDT.Text = "SDT";
            label_KH_SDT.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_KH_TienNo
            // 
            textBox_KH_TienNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_KH_TienNo.Font = new Font("Segoe UI", 12F);
            textBox_KH_TienNo.Location = new Point(185, 283);
            textBox_KH_TienNo.Name = "textBox_KH_TienNo";
            textBox_KH_TienNo.Size = new Size(380, 34);
            textBox_KH_TienNo.TabIndex = 51;
            // 
            // label_KH_TienNo
            // 
            label_KH_TienNo.Font = new Font("Segoe UI", 12F);
            label_KH_TienNo.Location = new Point(27, 281);
            label_KH_TienNo.Margin = new Padding(3, 0, 20, 0);
            label_KH_TienNo.Name = "label_KH_TienNo";
            label_KH_TienNo.Size = new Size(135, 40);
            label_KH_TienNo.TabIndex = 50;
            label_KH_TienNo.Text = "Tiền nợ";
            label_KH_TienNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // icon_Sach_Ban
            // 
            icon_Sach_Ban.Anchor = AnchorStyles.Right;
            icon_Sach_Ban.BackColor = Color.FromArgb(0, 192, 192);
            icon_Sach_Ban.FlatAppearance.BorderSize = 0;
            icon_Sach_Ban.FlatStyle = FlatStyle.Flat;
            icon_Sach_Ban.Font = new Font("Segoe UI", 12F);
            icon_Sach_Ban.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            icon_Sach_Ban.IconColor = Color.Black;
            icon_Sach_Ban.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Sach_Ban.IconSize = 30;
            icon_Sach_Ban.ImageAlign = ContentAlignment.BottomCenter;
            icon_Sach_Ban.Location = new Point(589, 39);
            icon_Sach_Ban.Margin = new Padding(10);
            icon_Sach_Ban.Name = "icon_Sach_Ban";
            icon_Sach_Ban.Size = new Size(174, 84);
            icon_Sach_Ban.TabIndex = 49;
            icon_Sach_Ban.Text = "Thu tiền";
            icon_Sach_Ban.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_Sach_Ban.UseVisualStyleBackColor = false;
            // 
            // icon_KH_Loc
            // 
            icon_KH_Loc.Anchor = AnchorStyles.Right;
            icon_KH_Loc.BackColor = Color.FromArgb(255, 192, 128);
            icon_KH_Loc.FlatAppearance.BorderSize = 0;
            icon_KH_Loc.FlatStyle = FlatStyle.Flat;
            icon_KH_Loc.Font = new Font("Segoe UI", 12F);
            icon_KH_Loc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            icon_KH_Loc.IconColor = Color.Black;
            icon_KH_Loc.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_KH_Loc.IconSize = 30;
            icon_KH_Loc.Location = new Point(689, 293);
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
            icon_KH_Tim.Anchor = AnchorStyles.Right;
            icon_KH_Tim.BackColor = Color.FromArgb(128, 128, 255);
            icon_KH_Tim.FlatAppearance.BorderSize = 0;
            icon_KH_Tim.FlatStyle = FlatStyle.Flat;
            icon_KH_Tim.Font = new Font("Segoe UI", 12F);
            icon_KH_Tim.IconChar = FontAwesome.Sharp.IconChar.Search;
            icon_KH_Tim.IconColor = Color.Black;
            icon_KH_Tim.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_KH_Tim.IconSize = 30;
            icon_KH_Tim.Location = new Point(589, 293);
            icon_KH_Tim.Margin = new Padding(10);
            icon_KH_Tim.Name = "icon_KH_Tim";
            icon_KH_Tim.Size = new Size(80, 80);
            icon_KH_Tim.TabIndex = 47;
            icon_KH_Tim.TextAlign = ContentAlignment.MiddleRight;
            icon_KH_Tim.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_KH_Tim.UseVisualStyleBackColor = false;
            // 
            // icon_KH_Xoa
            // 
            icon_KH_Xoa.Anchor = AnchorStyles.Right;
            icon_KH_Xoa.BackColor = Color.FromArgb(255, 128, 128);
            icon_KH_Xoa.FlatAppearance.BorderSize = 0;
            icon_KH_Xoa.FlatStyle = FlatStyle.Flat;
            icon_KH_Xoa.Font = new Font("Segoe UI", 12F);
            icon_KH_Xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            icon_KH_Xoa.IconColor = Color.Black;
            icon_KH_Xoa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_KH_Xoa.IconSize = 30;
            icon_KH_Xoa.Location = new Point(689, 195);
            icon_KH_Xoa.Margin = new Padding(10);
            icon_KH_Xoa.Name = "icon_KH_Xoa";
            icon_KH_Xoa.Size = new Size(80, 80);
            icon_KH_Xoa.TabIndex = 46;
            icon_KH_Xoa.TextAlign = ContentAlignment.MiddleRight;
            icon_KH_Xoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_KH_Xoa.UseVisualStyleBackColor = false;
            // 
            // icon_KH_Them
            // 
            icon_KH_Them.Anchor = AnchorStyles.Right;
            icon_KH_Them.BackColor = Color.FromArgb(128, 255, 128);
            icon_KH_Them.FlatAppearance.BorderSize = 0;
            icon_KH_Them.FlatStyle = FlatStyle.Flat;
            icon_KH_Them.Font = new Font("Segoe UI", 12F);
            icon_KH_Them.IconChar = FontAwesome.Sharp.IconChar.Add;
            icon_KH_Them.IconColor = Color.Black;
            icon_KH_Them.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_KH_Them.IconSize = 30;
            icon_KH_Them.Location = new Point(589, 193);
            icon_KH_Them.Margin = new Padding(10);
            icon_KH_Them.Name = "icon_KH_Them";
            icon_KH_Them.Size = new Size(80, 80);
            icon_KH_Them.TabIndex = 45;
            icon_KH_Them.TextAlign = ContentAlignment.MiddleRight;
            icon_KH_Them.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_KH_Them.UseVisualStyleBackColor = false;
            // 
            // textBox_TheLoai
            // 
            textBox_TheLoai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_TheLoai.Font = new Font("Segoe UI", 12F);
            textBox_TheLoai.Location = new Point(185, 237);
            textBox_TheLoai.Name = "textBox_TheLoai";
            textBox_TheLoai.Size = new Size(380, 34);
            textBox_TheLoai.TabIndex = 44;
            // 
            // label_KH_DiaChi
            // 
            label_KH_DiaChi.Font = new Font("Segoe UI", 12F);
            label_KH_DiaChi.Location = new Point(27, 235);
            label_KH_DiaChi.Margin = new Padding(3, 0, 20, 0);
            label_KH_DiaChi.Name = "label_KH_DiaChi";
            label_KH_DiaChi.Size = new Size(135, 40);
            label_KH_DiaChi.TabIndex = 43;
            label_KH_DiaChi.Text = "Địa chỉ";
            label_KH_DiaChi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_SoLuong
            // 
            textBox_SoLuong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_SoLuong.Font = new Font("Segoe UI", 12F);
            textBox_SoLuong.Location = new Point(185, 188);
            textBox_SoLuong.Name = "textBox_SoLuong";
            textBox_SoLuong.Size = new Size(380, 34);
            textBox_SoLuong.TabIndex = 42;
            // 
            // label_KH_Email
            // 
            label_KH_Email.Font = new Font("Segoe UI", 12F);
            label_KH_Email.Location = new Point(27, 186);
            label_KH_Email.Margin = new Padding(3, 0, 20, 0);
            label_KH_Email.Name = "label_KH_Email";
            label_KH_Email.Size = new Size(135, 40);
            label_KH_Email.TabIndex = 41;
            label_KH_Email.Text = "Email";
            label_KH_Email.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_Sach_TacGia
            // 
            textBox_Sach_TacGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Sach_TacGia.Font = new Font("Segoe UI", 12F);
            textBox_Sach_TacGia.Location = new Point(185, 139);
            textBox_Sach_TacGia.Name = "textBox_Sach_TacGia";
            textBox_Sach_TacGia.Size = new Size(380, 34);
            textBox_Sach_TacGia.TabIndex = 40;
            // 
            // textBox_Sach_TenSach
            // 
            textBox_Sach_TenSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Sach_TenSach.Font = new Font("Segoe UI", 12F);
            textBox_Sach_TenSach.Location = new Point(185, 90);
            textBox_Sach_TenSach.Name = "textBox_Sach_TenSach";
            textBox_Sach_TenSach.Size = new Size(380, 34);
            textBox_Sach_TenSach.TabIndex = 39;
            // 
            // label_KH_GioiTinh
            // 
            label_KH_GioiTinh.Font = new Font("Segoe UI", 12F);
            label_KH_GioiTinh.Location = new Point(27, 137);
            label_KH_GioiTinh.Margin = new Padding(3, 0, 20, 0);
            label_KH_GioiTinh.Name = "label_KH_GioiTinh";
            label_KH_GioiTinh.Size = new Size(135, 40);
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
            label_KH_TenKH.Size = new Size(135, 40);
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
            label_KH_MaKH.Size = new Size(135, 40);
            label_KH_MaKH.TabIndex = 36;
            label_KH_MaKH.Text = "Mã KH";
            label_KH_MaKH.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_Sach_MaSach
            // 
            textBox_Sach_MaSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Sach_MaSach.Font = new Font("Segoe UI", 12F);
            textBox_Sach_MaSach.Location = new Point(185, 39);
            textBox_Sach_MaSach.Name = "textBox_Sach_MaSach";
            textBox_Sach_MaSach.Size = new Size(380, 34);
            textBox_Sach_MaSach.TabIndex = 35;
            // 
            // dataGridView_KhachHang
            // 
            dataGridView_KhachHang.AllowUserToAddRows = false;
            dataGridView_KhachHang.AllowUserToDeleteRows = false;
            dataGridView_KhachHang.AllowUserToResizeColumns = false;
            dataGridView_KhachHang.AllowUserToResizeRows = false;
            dataGridView_KhachHang.AutoGenerateColumns = false;
            dataGridView_KhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_KhachHang.BackgroundColor = Color.White;
            dataGridView_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_KhachHang.Columns.AddRange(new DataGridViewColumn[] { maKHDataGridViewTextBoxColumn, tenKHDataGridViewTextBoxColumn, gioiTinhDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, diaChiDataGridViewTextBoxColumn, tienNoDataGridViewTextBoxColumn });
            dataGridView_KhachHang.DataSource = khachHangBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_KhachHang.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_KhachHang.Dock = DockStyle.Fill;
            dataGridView_KhachHang.GridColor = SystemColors.ScrollBar;
            dataGridView_KhachHang.Location = new Point(0, 406);
            dataGridView_KhachHang.Name = "dataGridView_KhachHang";
            dataGridView_KhachHang.RightToLeft = RightToLeft.No;
            dataGridView_KhachHang.RowHeadersVisible = false;
            dataGridView_KhachHang.RowHeadersWidth = 51;
            dataGridView_KhachHang.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_KhachHang.Size = new Size(782, 147);
            dataGridView_KhachHang.TabIndex = 3;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            maKHDataGridViewTextBoxColumn.HeaderText = "Mã KH";
            maKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
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
            // Form_KhachHang
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(dataGridView_KhachHang);
            Controls.Add(groupBox_KhachHang);
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_KhachHang;
        private TextBox textBox_TheLoai;
        private Label label_KH_DiaChi;
        private TextBox textBox_SoLuong;
        private Label label_KH_Email;
        private TextBox textBox_Sach_TacGia;
        private TextBox textBox_Sach_TenSach;
        private Label label_KH_GioiTinh;
        private Label label_KH_TenKH;
        private Label label_KH_MaKH;
        private TextBox textBox_Sach_MaSach;
        private FontAwesome.Sharp.IconButton icon_KH_Loc;
        private FontAwesome.Sharp.IconButton icon_KH_Tim;
        private FontAwesome.Sharp.IconButton icon_KH_Xoa;
        private FontAwesome.Sharp.IconButton icon_KH_Them;
        private FontAwesome.Sharp.IconButton icon_Sach_Ban;
        private TextBox textBox_KH_SDT;
        private Label label_KH_SDT;
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
    }
}