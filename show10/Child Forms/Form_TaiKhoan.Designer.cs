namespace Show10.Child_Forms
{
    partial class Form_TaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            groupBox_TaiKhoan = new GroupBox();
            textBox_TK_HoTen = new TextBox();
            textBox_TK_MatKhau = new TextBox();
            checkBox_TK_TimKiem = new CheckBox();
            checkBox_TK_QTV = new CheckBox();
            label_TK_HoTen = new Label();
            label_TK_MatKhau = new Label();
            label_TK_TenTK = new Label();
            textBox_TK_TenTK = new TextBox();
            icon_TK_Xoa = new FontAwesome.Sharp.IconButton();
            icon_TK_Them = new FontAwesome.Sharp.IconButton();
            dataGridView_TaiKhoan = new DataGridView();
            dataGridViewTextBoxColumn_TenTK = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn_MatKhau = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn_HoTen = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn_VaiTro = new DataGridViewCheckBoxColumn();
            taiKhoanBindingSource = new BindingSource(components);
            groupBox_TaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_TaiKhoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taiKhoanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox_TaiKhoan
            // 
            groupBox_TaiKhoan.Controls.Add(textBox_TK_HoTen);
            groupBox_TaiKhoan.Controls.Add(textBox_TK_MatKhau);
            groupBox_TaiKhoan.Controls.Add(checkBox_TK_TimKiem);
            groupBox_TaiKhoan.Controls.Add(checkBox_TK_QTV);
            groupBox_TaiKhoan.Controls.Add(label_TK_HoTen);
            groupBox_TaiKhoan.Controls.Add(label_TK_MatKhau);
            groupBox_TaiKhoan.Controls.Add(label_TK_TenTK);
            groupBox_TaiKhoan.Controls.Add(textBox_TK_TenTK);
            groupBox_TaiKhoan.Controls.Add(icon_TK_Xoa);
            groupBox_TaiKhoan.Controls.Add(icon_TK_Them);
            groupBox_TaiKhoan.Dock = DockStyle.Top;
            groupBox_TaiKhoan.Location = new Point(0, 0);
            groupBox_TaiKhoan.Margin = new Padding(0);
            groupBox_TaiKhoan.Name = "groupBox_TaiKhoan";
            groupBox_TaiKhoan.Padding = new Padding(0);
            groupBox_TaiKhoan.Size = new Size(782, 355);
            groupBox_TaiKhoan.TabIndex = 0;
            groupBox_TaiKhoan.TabStop = false;
            groupBox_TaiKhoan.Text = "Nhập liệu";
            // 
            // textBox_TK_HoTen
            // 
            textBox_TK_HoTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_TK_HoTen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TK_HoTen.Location = new Point(200, 139);
            textBox_TK_HoTen.Name = "textBox_TK_HoTen";
            textBox_TK_HoTen.Size = new Size(364, 43);
            textBox_TK_HoTen.TabIndex = 18;
            textBox_TK_HoTen.TextChanged += TextBox_TK_HoTen_TextChanged;
            // 
            // textBox_TK_MatKhau
            // 
            textBox_TK_MatKhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_TK_MatKhau.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TK_MatKhau.Location = new Point(200, 90);
            textBox_TK_MatKhau.Name = "textBox_TK_MatKhau";
            textBox_TK_MatKhau.Size = new Size(364, 43);
            textBox_TK_MatKhau.TabIndex = 17;
            textBox_TK_MatKhau.TextChanged += TextBox_TK_MatKhau_TextChanged;
            // 
            // checkBox_TK_TimKiem
            // 
            checkBox_TK_TimKiem.Anchor = AnchorStyles.Right;
            checkBox_TK_TimKiem.Location = new Point(591, 100);
            checkBox_TK_TimKiem.Name = "checkBox_TK_TimKiem";
            checkBox_TK_TimKiem.Size = new Size(179, 30);
            checkBox_TK_TimKiem.TabIndex = 16;
            checkBox_TK_TimKiem.Text = "Chế độ tìm kiếm";
            checkBox_TK_TimKiem.TextAlign = ContentAlignment.MiddleCenter;
            checkBox_TK_TimKiem.UseVisualStyleBackColor = true;
            checkBox_TK_TimKiem.CheckedChanged += CheckBox_TK_TimKiem_CheckedChanged;
            // 
            // checkBox_TK_QTV
            // 
            checkBox_TK_QTV.Anchor = AnchorStyles.None;
            checkBox_TK_QTV.Location = new Point(200, 186);
            checkBox_TK_QTV.Name = "checkBox_TK_QTV";
            checkBox_TK_QTV.Size = new Size(364, 60);
            checkBox_TK_QTV.TabIndex = 15;
            checkBox_TK_QTV.Text = "Tài khoản này là quản trị viên";
            checkBox_TK_QTV.TextAlign = ContentAlignment.MiddleCenter;
            checkBox_TK_QTV.UseVisualStyleBackColor = true;
            checkBox_TK_QTV.CheckStateChanged += CheckBox_TK_QTV_CheckStateChanged;
            // 
            // label_TK_HoTen
            // 
            label_TK_HoTen.Location = new Point(42, 137);
            label_TK_HoTen.Margin = new Padding(3, 0, 20, 0);
            label_TK_HoTen.Name = "label_TK_HoTen";
            label_TK_HoTen.Size = new Size(135, 40);
            label_TK_HoTen.TabIndex = 14;
            label_TK_HoTen.Text = "Họ tên";
            label_TK_HoTen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_TK_MatKhau
            // 
            label_TK_MatKhau.Location = new Point(42, 88);
            label_TK_MatKhau.Margin = new Padding(3, 0, 20, 0);
            label_TK_MatKhau.Name = "label_TK_MatKhau";
            label_TK_MatKhau.Size = new Size(135, 40);
            label_TK_MatKhau.TabIndex = 12;
            label_TK_MatKhau.Text = "Mật khẩu";
            label_TK_MatKhau.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_TK_TenTK
            // 
            label_TK_TenTK.Location = new Point(42, 39);
            label_TK_TenTK.Margin = new Padding(3, 0, 20, 0);
            label_TK_TenTK.Name = "label_TK_TenTK";
            label_TK_TenTK.Size = new Size(135, 40);
            label_TK_TenTK.TabIndex = 11;
            label_TK_TenTK.Text = "Tên tài khoản";
            label_TK_TenTK.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_TK_TenTK
            // 
            textBox_TK_TenTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_TK_TenTK.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TK_TenTK.Location = new Point(200, 39);
            textBox_TK_TenTK.Name = "textBox_TK_TenTK";
            textBox_TK_TenTK.Size = new Size(364, 43);
            textBox_TK_TenTK.TabIndex = 9;
            textBox_TK_TenTK.TextChanged += TextBox_TK_TenTK_TextChanged;
            // 
            // icon_TK_Xoa
            // 
            icon_TK_Xoa.Anchor = AnchorStyles.None;
            icon_TK_Xoa.BackColor = Color.FromArgb(255, 128, 128);
            icon_TK_Xoa.FlatAppearance.BorderSize = 0;
            icon_TK_Xoa.FlatStyle = FlatStyle.Flat;
            icon_TK_Xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            icon_TK_Xoa.IconColor = Color.Black;
            icon_TK_Xoa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_TK_Xoa.IconSize = 30;
            icon_TK_Xoa.Location = new Point(375, 259);
            icon_TK_Xoa.Margin = new Padding(10);
            icon_TK_Xoa.Name = "icon_TK_Xoa";
            icon_TK_Xoa.Size = new Size(220, 80);
            icon_TK_Xoa.TabIndex = 8;
            icon_TK_Xoa.Text = "Xoá tài khoản";
            icon_TK_Xoa.TextAlign = ContentAlignment.MiddleRight;
            icon_TK_Xoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_TK_Xoa.UseVisualStyleBackColor = false;
            icon_TK_Xoa.Click += Icon_TK_Xoa_Click;
            // 
            // icon_TK_Them
            // 
            icon_TK_Them.Anchor = AnchorStyles.None;
            icon_TK_Them.BackColor = Color.FromArgb(128, 255, 128);
            icon_TK_Them.FlatAppearance.BorderSize = 0;
            icon_TK_Them.FlatStyle = FlatStyle.Flat;
            icon_TK_Them.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            icon_TK_Them.IconColor = Color.Black;
            icon_TK_Them.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_TK_Them.IconSize = 30;
            icon_TK_Them.Location = new Point(135, 259);
            icon_TK_Them.Margin = new Padding(10);
            icon_TK_Them.Name = "icon_TK_Them";
            icon_TK_Them.Size = new Size(220, 80);
            icon_TK_Them.TabIndex = 7;
            icon_TK_Them.Text = "Thêm tài khoản";
            icon_TK_Them.TextAlign = ContentAlignment.MiddleRight;
            icon_TK_Them.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_TK_Them.UseVisualStyleBackColor = false;
            icon_TK_Them.Click += Icon_TK_Them_Click;
            // 
            // dataGridView_TaiKhoan
            // 
            dataGridView_TaiKhoan.AllowUserToAddRows = false;
            dataGridView_TaiKhoan.AllowUserToDeleteRows = false;
            dataGridView_TaiKhoan.AllowUserToResizeColumns = false;
            dataGridView_TaiKhoan.AllowUserToResizeRows = false;
            dataGridView_TaiKhoan.AutoGenerateColumns = false;
            dataGridView_TaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_TaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_TaiKhoan.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn_TenTK, dataGridViewTextBoxColumn_MatKhau, dataGridViewTextBoxColumn_HoTen, dataGridViewTextBoxColumn_VaiTro });
            dataGridView_TaiKhoan.DataSource = taiKhoanBindingSource;
            dataGridView_TaiKhoan.Dock = DockStyle.Fill;
            dataGridView_TaiKhoan.GridColor = SystemColors.ScrollBar;
            dataGridView_TaiKhoan.Location = new Point(0, 355);
            dataGridView_TaiKhoan.Name = "dataGridView_TaiKhoan";
            dataGridView_TaiKhoan.RightToLeft = RightToLeft.No;
            dataGridView_TaiKhoan.RowHeadersWidth = 51;
            dataGridView_TaiKhoan.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_TaiKhoan.Size = new Size(782, 198);
            dataGridView_TaiKhoan.TabIndex = 1;
            dataGridView_TaiKhoan.SelectionChanged += DataGridView_TaiKhoan_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn_TenTK
            // 
            dataGridViewTextBoxColumn_TenTK.DataPropertyName = "TenTK";
            dataGridViewTextBoxColumn_TenTK.HeaderText = "Tên TK";
            dataGridViewTextBoxColumn_TenTK.MinimumWidth = 6;
            dataGridViewTextBoxColumn_TenTK.Name = "dataGridViewTextBoxColumn_TenTK";
            // 
            // dataGridViewTextBoxColumn_MatKhau
            // 
            dataGridViewTextBoxColumn_MatKhau.DataPropertyName = "MatKhau";
            dataGridViewTextBoxColumn_MatKhau.HeaderText = "Mật khẩu";
            dataGridViewTextBoxColumn_MatKhau.MinimumWidth = 6;
            dataGridViewTextBoxColumn_MatKhau.Name = "dataGridViewTextBoxColumn_MatKhau";
            // 
            // dataGridViewTextBoxColumn_HoTen
            // 
            dataGridViewTextBoxColumn_HoTen.DataPropertyName = "HoTen";
            dataGridViewTextBoxColumn_HoTen.HeaderText = "Họ tên";
            dataGridViewTextBoxColumn_HoTen.MinimumWidth = 6;
            dataGridViewTextBoxColumn_HoTen.Name = "dataGridViewTextBoxColumn_HoTen";
            // 
            // dataGridViewTextBoxColumn_VaiTro
            // 
            dataGridViewTextBoxColumn_VaiTro.DataPropertyName = "VaiTro";
            dataGridViewTextBoxColumn_VaiTro.FalseValue = "user";
            dataGridViewTextBoxColumn_VaiTro.HeaderText = "Vai trò";
            dataGridViewTextBoxColumn_VaiTro.MinimumWidth = 6;
            dataGridViewTextBoxColumn_VaiTro.Name = "dataGridViewTextBoxColumn_VaiTro";
            dataGridViewTextBoxColumn_VaiTro.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn_VaiTro.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn_VaiTro.TrueValue = "admin";
            // 
            // taiKhoanBindingSource
            // 
            taiKhoanBindingSource.DataSource = typeof(Data_Access.TaiKhoan);
            // 
            // Form_TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(dataGridView_TaiKhoan);
            Controls.Add(groupBox_TaiKhoan);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form_TaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tài khoản";
            FormClosing += Form_Account_FormClosing;
            Load += Form_Account_Load;
            groupBox_TaiKhoan.ResumeLayout(false);
            groupBox_TaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_TaiKhoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)taiKhoanBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_TaiKhoan;
        private DataGridView dataGridView_TaiKhoan;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenTKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vaiTroDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton icon_TK_Xoa;
        private FontAwesome.Sharp.IconButton icon_TK_Them;
        private Label label_TK_HoTen;
        private Label label_TK_MatKhau;
        private Label label_TK_TenTK;
        private TextBox textBox_TK_TenTK;
        private CheckBox checkBox_TK_QTV;
        private CheckBox checkBox_TK_TimKiem;
        private BindingSource taiKhoanBindingSource;
        private TextBox textBox_TK_HoTen;
        private TextBox textBox_TK_MatKhau;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_TenTK;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_MatKhau;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_HoTen;
        private DataGridViewCheckBoxColumn dataGridViewTextBoxColumn_VaiTro;
    }
}