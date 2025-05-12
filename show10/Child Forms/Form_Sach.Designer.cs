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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox_Sach = new GroupBox();
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
            dataGridViewTextBoxColumn_TenSach = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn_TacGia = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn_SoLuong = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn_TheLoai = new DataGridViewTextBoxColumn();
            groupBox_Sach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sachBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Sach).BeginInit();
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
            groupBox_Sach.Location = new Point(0, 0);
            groupBox_Sach.Name = "groupBox_Sach";
            groupBox_Sach.Size = new Size(782, 396);
            groupBox_Sach.TabIndex = 0;
            groupBox_Sach.TabStop = false;
            groupBox_Sach.Text = "Nhập liệu";
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
            icon_Sach_Ban.Location = new Point(595, 133);
            icon_Sach_Ban.Margin = new Padding(10);
            icon_Sach_Ban.Name = "icon_Sach_Ban";
            icon_Sach_Ban.Size = new Size(168, 84);
            icon_Sach_Ban.TabIndex = 36;
            icon_Sach_Ban.Text = "Bán sách";
            icon_Sach_Ban.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_Sach_Ban.UseVisualStyleBackColor = false;
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
            icon_Sach_Nhap.Location = new Point(595, 33);
            icon_Sach_Nhap.Margin = new Padding(10);
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
            textBox_TheLoai.Size = new Size(380, 34);
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
            textBox_SoLuong.Size = new Size(380, 34);
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
            icon_Sach_Loc.Location = new Point(484, 291);
            icon_Sach_Loc.Margin = new Padding(10);
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
            icon_Sach_Tim.Location = new Point(384, 291);
            icon_Sach_Tim.Margin = new Padding(10);
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
            textBox_Sach_TacGia.Size = new Size(380, 34);
            textBox_Sach_TacGia.TabIndex = 28;
            // 
            // textBox_Sach_TenSach
            // 
            textBox_Sach_TenSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Sach_TenSach.Font = new Font("Segoe UI", 12F);
            textBox_Sach_TenSach.Location = new Point(184, 86);
            textBox_Sach_TenSach.Name = "textBox_Sach_TenSach";
            textBox_Sach_TenSach.Size = new Size(380, 34);
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
            textBox_Sach_MaSach.Size = new Size(380, 34);
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
            icon_Sach_Xoa.Location = new Point(284, 291);
            icon_Sach_Xoa.Margin = new Padding(10);
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
            icon_Sach_Them.Location = new Point(184, 291);
            icon_Sach_Them.Margin = new Padding(10);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_Sach.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Sach.Dock = DockStyle.Fill;
            dataGridView_Sach.GridColor = SystemColors.ScrollBar;
            dataGridView_Sach.Location = new Point(0, 396);
            dataGridView_Sach.Name = "dataGridView_Sach";
            dataGridView_Sach.RightToLeft = RightToLeft.No;
            dataGridView_Sach.RowHeadersVisible = false;
            dataGridView_Sach.RowHeadersWidth = 51;
            dataGridView_Sach.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_Sach.Size = new Size(782, 157);
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
            // Form_Sach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(dataGridView_Sach);
            Controls.Add(groupBox_Sach);
            Name = "Form_Sach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sách";
            FormClosing += Form_Sach_FormClosing;
            Load += Form_Sach_Load;
            groupBox_Sach.ResumeLayout(false);
            groupBox_Sach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sachBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Sach).EndInit();
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
        private FontAwesome.Sharp.IconButton icon_Sach_Ban;
    }
}