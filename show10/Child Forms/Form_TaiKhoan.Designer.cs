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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox_TaiKhoan = new GroupBox();
            icon_TK_Clear = new FontAwesome.Sharp.IconButton();
            icon_TK_Loc = new FontAwesome.Sharp.IconButton();
            icon_TK_Tim = new FontAwesome.Sharp.IconButton();
            icon_TK_Xoa = new FontAwesome.Sharp.IconButton();
            icon_TK_Them = new FontAwesome.Sharp.IconButton();
            textBox_TK_HoTen = new TextBox();
            textBox_TK_MatKhau = new TextBox();
            checkBox_TK_QTV = new CheckBox();
            label_TK_HoTen = new Label();
            label_TK_MatKhau = new Label();
            label_TK_TenTK = new Label();
            textBox_TK_TenTK = new TextBox();
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
            groupBox_TaiKhoan.BackColor = Color.White;
            groupBox_TaiKhoan.Controls.Add(icon_TK_Clear);
            groupBox_TaiKhoan.Controls.Add(icon_TK_Loc);
            groupBox_TaiKhoan.Controls.Add(icon_TK_Tim);
            groupBox_TaiKhoan.Controls.Add(icon_TK_Xoa);
            groupBox_TaiKhoan.Controls.Add(icon_TK_Them);
            groupBox_TaiKhoan.Controls.Add(textBox_TK_HoTen);
            groupBox_TaiKhoan.Controls.Add(textBox_TK_MatKhau);
            groupBox_TaiKhoan.Controls.Add(checkBox_TK_QTV);
            groupBox_TaiKhoan.Controls.Add(label_TK_HoTen);
            groupBox_TaiKhoan.Controls.Add(label_TK_MatKhau);
            groupBox_TaiKhoan.Controls.Add(label_TK_TenTK);
            groupBox_TaiKhoan.Controls.Add(textBox_TK_TenTK);
            groupBox_TaiKhoan.Dock = DockStyle.Top;
            groupBox_TaiKhoan.FlatStyle = FlatStyle.Flat;
            groupBox_TaiKhoan.Location = new Point(0, 0);
            groupBox_TaiKhoan.Margin = new Padding(0);
            groupBox_TaiKhoan.Name = "groupBox_TaiKhoan";
            groupBox_TaiKhoan.Padding = new Padding(0);
            groupBox_TaiKhoan.Size = new Size(782, 362);
            groupBox_TaiKhoan.TabIndex = 0;
            groupBox_TaiKhoan.TabStop = false;
            groupBox_TaiKhoan.Text = "Nhập liệu";
            // 
            // icon_TK_Clear
            // 
            icon_TK_Clear.Anchor = AnchorStyles.None;
            icon_TK_Clear.BackColor = Color.White;
            icon_TK_Clear.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 255);
            icon_TK_Clear.FlatAppearance.BorderSize = 2;
            icon_TK_Clear.FlatStyle = FlatStyle.Flat;
            icon_TK_Clear.Font = new Font("Segoe UI", 12F);
            icon_TK_Clear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            icon_TK_Clear.IconColor = Color.FromArgb(255, 128, 255);
            icon_TK_Clear.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_TK_Clear.IconSize = 30;
            icon_TK_Clear.Location = new Point(600, 262);
            icon_TK_Clear.Margin = new Padding(10);
            icon_TK_Clear.Name = "icon_TK_Clear";
            icon_TK_Clear.Size = new Size(80, 80);
            icon_TK_Clear.TabIndex = 11;
            icon_TK_Clear.TextAlign = ContentAlignment.MiddleRight;
            icon_TK_Clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_TK_Clear.UseVisualStyleBackColor = false;
            icon_TK_Clear.Click += Icon_TK_Clear_Click;
            // 
            // icon_TK_Loc
            // 
            icon_TK_Loc.Anchor = AnchorStyles.None;
            icon_TK_Loc.BackColor = Color.White;
            icon_TK_Loc.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            icon_TK_Loc.FlatAppearance.BorderSize = 2;
            icon_TK_Loc.FlatStyle = FlatStyle.Flat;
            icon_TK_Loc.Font = new Font("Segoe UI", 12F);
            icon_TK_Loc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            icon_TK_Loc.IconColor = Color.FromArgb(255, 192, 128);
            icon_TK_Loc.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_TK_Loc.IconSize = 30;
            icon_TK_Loc.Location = new Point(500, 262);
            icon_TK_Loc.Margin = new Padding(10);
            icon_TK_Loc.Name = "icon_TK_Loc";
            icon_TK_Loc.Size = new Size(80, 80);
            icon_TK_Loc.TabIndex = 10;
            icon_TK_Loc.TextAlign = ContentAlignment.MiddleRight;
            icon_TK_Loc.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_TK_Loc.UseVisualStyleBackColor = false;
            icon_TK_Loc.Click += Icon_TK_Loc_Click;
            // 
            // icon_TK_Tim
            // 
            icon_TK_Tim.Anchor = AnchorStyles.None;
            icon_TK_Tim.BackColor = Color.White;
            icon_TK_Tim.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            icon_TK_Tim.FlatAppearance.BorderSize = 2;
            icon_TK_Tim.FlatStyle = FlatStyle.Flat;
            icon_TK_Tim.Font = new Font("Segoe UI", 12F);
            icon_TK_Tim.IconChar = FontAwesome.Sharp.IconChar.Search;
            icon_TK_Tim.IconColor = Color.FromArgb(128, 128, 255);
            icon_TK_Tim.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_TK_Tim.IconSize = 30;
            icon_TK_Tim.Location = new Point(400, 262);
            icon_TK_Tim.Margin = new Padding(10);
            icon_TK_Tim.Name = "icon_TK_Tim";
            icon_TK_Tim.Size = new Size(80, 80);
            icon_TK_Tim.TabIndex = 9;
            icon_TK_Tim.TextAlign = ContentAlignment.MiddleRight;
            icon_TK_Tim.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_TK_Tim.UseVisualStyleBackColor = false;
            icon_TK_Tim.Click += Icon_TK_Tim_Click;
            // 
            // icon_TK_Xoa
            // 
            icon_TK_Xoa.Anchor = AnchorStyles.None;
            icon_TK_Xoa.BackColor = Color.Brown;
            icon_TK_Xoa.FlatAppearance.BorderSize = 0;
            icon_TK_Xoa.FlatStyle = FlatStyle.Flat;
            icon_TK_Xoa.Font = new Font("Segoe UI", 12F);
            icon_TK_Xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            icon_TK_Xoa.IconColor = Color.White;
            icon_TK_Xoa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_TK_Xoa.IconSize = 30;
            icon_TK_Xoa.Location = new Point(300, 262);
            icon_TK_Xoa.Margin = new Padding(10);
            icon_TK_Xoa.Name = "icon_TK_Xoa";
            icon_TK_Xoa.Size = new Size(80, 80);
            icon_TK_Xoa.TabIndex = 8;
            icon_TK_Xoa.TextAlign = ContentAlignment.MiddleRight;
            icon_TK_Xoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_TK_Xoa.UseVisualStyleBackColor = false;
            icon_TK_Xoa.Click += Icon_TK_Xoa_Click;
            // 
            // icon_TK_Them
            // 
            icon_TK_Them.Anchor = AnchorStyles.None;
            icon_TK_Them.BackColor = Color.Green;
            icon_TK_Them.FlatAppearance.BorderSize = 0;
            icon_TK_Them.FlatStyle = FlatStyle.Flat;
            icon_TK_Them.Font = new Font("Segoe UI", 12F);
            icon_TK_Them.IconChar = FontAwesome.Sharp.IconChar.Add;
            icon_TK_Them.IconColor = Color.White;
            icon_TK_Them.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_TK_Them.IconSize = 30;
            icon_TK_Them.Location = new Point(200, 262);
            icon_TK_Them.Margin = new Padding(10);
            icon_TK_Them.Name = "icon_TK_Them";
            icon_TK_Them.Size = new Size(80, 80);
            icon_TK_Them.TabIndex = 7;
            icon_TK_Them.TextAlign = ContentAlignment.MiddleRight;
            icon_TK_Them.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_TK_Them.UseVisualStyleBackColor = false;
            icon_TK_Them.Click += Icon_TK_Them_Click;
            // 
            // textBox_TK_HoTen
            // 
            textBox_TK_HoTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_TK_HoTen.BorderStyle = BorderStyle.FixedSingle;
            textBox_TK_HoTen.Font = new Font("Segoe UI", 12F);
            textBox_TK_HoTen.Location = new Point(200, 146);
            textBox_TK_HoTen.Name = "textBox_TK_HoTen";
            textBox_TK_HoTen.Size = new Size(480, 34);
            textBox_TK_HoTen.TabIndex = 5;
            textBox_TK_HoTen.TextChanged += TextBox_TK_HoTen_TextChanged;
            // 
            // textBox_TK_MatKhau
            // 
            textBox_TK_MatKhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_TK_MatKhau.BorderStyle = BorderStyle.FixedSingle;
            textBox_TK_MatKhau.Font = new Font("Segoe UI", 12F);
            textBox_TK_MatKhau.Location = new Point(200, 99);
            textBox_TK_MatKhau.Name = "textBox_TK_MatKhau";
            textBox_TK_MatKhau.Size = new Size(480, 34);
            textBox_TK_MatKhau.TabIndex = 4;
            textBox_TK_MatKhau.TextChanged += TextBox_TK_MatKhau_TextChanged;
            // 
            // checkBox_TK_QTV
            // 
            checkBox_TK_QTV.Anchor = AnchorStyles.None;
            checkBox_TK_QTV.Location = new Point(200, 189);
            checkBox_TK_QTV.Name = "checkBox_TK_QTV";
            checkBox_TK_QTV.Size = new Size(480, 60);
            checkBox_TK_QTV.TabIndex = 6;
            checkBox_TK_QTV.Text = "Tài khoản là quản trị viên";
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
            label_TK_HoTen.TabIndex = 2;
            label_TK_HoTen.Text = "Họ tên";
            label_TK_HoTen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_TK_MatKhau
            // 
            label_TK_MatKhau.Location = new Point(42, 88);
            label_TK_MatKhau.Margin = new Padding(3, 0, 20, 0);
            label_TK_MatKhau.Name = "label_TK_MatKhau";
            label_TK_MatKhau.Size = new Size(135, 40);
            label_TK_MatKhau.TabIndex = 1;
            label_TK_MatKhau.Text = "Mật khẩu";
            label_TK_MatKhau.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_TK_TenTK
            // 
            label_TK_TenTK.Location = new Point(42, 39);
            label_TK_TenTK.Margin = new Padding(3, 0, 20, 0);
            label_TK_TenTK.Name = "label_TK_TenTK";
            label_TK_TenTK.Size = new Size(135, 40);
            label_TK_TenTK.TabIndex = 0;
            label_TK_TenTK.Text = "Tên tài khoản";
            label_TK_TenTK.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_TK_TenTK
            // 
            textBox_TK_TenTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_TK_TenTK.BorderStyle = BorderStyle.FixedSingle;
            textBox_TK_TenTK.Font = new Font("Segoe UI", 12F);
            textBox_TK_TenTK.Location = new Point(200, 45);
            textBox_TK_TenTK.Name = "textBox_TK_TenTK";
            textBox_TK_TenTK.Size = new Size(480, 34);
            textBox_TK_TenTK.TabIndex = 3;
            textBox_TK_TenTK.TextChanged += TextBox_TK_TenTK_TextChanged;
            // 
            // dataGridView_TaiKhoan
            // 
            dataGridView_TaiKhoan.AllowUserToAddRows = false;
            dataGridView_TaiKhoan.AllowUserToDeleteRows = false;
            dataGridView_TaiKhoan.AllowUserToOrderColumns = true;
            dataGridView_TaiKhoan.AutoGenerateColumns = false;
            dataGridView_TaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_TaiKhoan.BackgroundColor = Color.White;
            dataGridView_TaiKhoan.BorderStyle = BorderStyle.None;
            dataGridView_TaiKhoan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Green;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_TaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_TaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_TaiKhoan.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn_TenTK, dataGridViewTextBoxColumn_MatKhau, dataGridViewTextBoxColumn_HoTen, dataGridViewTextBoxColumn_VaiTro });
            dataGridView_TaiKhoan.DataSource = taiKhoanBindingSource;
            dataGridView_TaiKhoan.Dock = DockStyle.Fill;
            dataGridView_TaiKhoan.EnableHeadersVisualStyles = false;
            dataGridView_TaiKhoan.GridColor = Color.Black;
            dataGridView_TaiKhoan.Location = new Point(0, 362);
            dataGridView_TaiKhoan.Name = "dataGridView_TaiKhoan";
            dataGridView_TaiKhoan.RightToLeft = RightToLeft.No;
            dataGridView_TaiKhoan.RowHeadersVisible = false;
            dataGridView_TaiKhoan.RowHeadersWidth = 51;
            dataGridView_TaiKhoan.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_TaiKhoan.Size = new Size(782, 191);
            dataGridView_TaiKhoan.TabIndex = 1;
            dataGridView_TaiKhoan.CellValueChanged += DataGridView_TaiKhoan_CellValueChanged;
            dataGridView_TaiKhoan.SelectionChanged += DataGridView_TaiKhoan_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn_TenTK
            // 
            dataGridViewTextBoxColumn_TenTK.DataPropertyName = "TenTK";
            dataGridViewTextBoxColumn_TenTK.HeaderText = "Tên tài khoản";
            dataGridViewTextBoxColumn_TenTK.MinimumWidth = 6;
            dataGridViewTextBoxColumn_TenTK.Name = "dataGridViewTextBoxColumn_TenTK";
            dataGridViewTextBoxColumn_TenTK.ReadOnly = true;
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
            taiKhoanBindingSource.DataSource = typeof(Models.TaiKhoan);
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
            Text = "Quản lý tài khoản";
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
        private Label label_TK_HoTen;
        private Label label_TK_MatKhau;
        private Label label_TK_TenTK;
        private TextBox textBox_TK_TenTK;
        private CheckBox checkBox_TK_QTV;
        private BindingSource taiKhoanBindingSource;
        private TextBox textBox_TK_HoTen;
        private TextBox textBox_TK_MatKhau;
        private FontAwesome.Sharp.IconButton icon_TK_Loc;
        private FontAwesome.Sharp.IconButton icon_TK_Tim;
        private FontAwesome.Sharp.IconButton icon_TK_Xoa;
        private FontAwesome.Sharp.IconButton icon_TK_Them;
        private FontAwesome.Sharp.IconButton icon_TK_Clear;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_TenTK;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_MatKhau;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_HoTen;
        private DataGridViewCheckBoxColumn dataGridViewTextBoxColumn_VaiTro;
    }
}