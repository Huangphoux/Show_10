namespace Show10.Child_Forms
{
    partial class Form_Account
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
            groupBox_User_Input = new GroupBox();
            checkBox_TK_LaQTV = new CheckBox();
            label3 = new Label();
            maskedTextBox_TK_HoTen = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            maskedTextBox_TK_MatKhau = new MaskedTextBox();
            textBox_TK_TenTK = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            accountBindingSource = new BindingSource(components);
            accountBindingSource1 = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenTKDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matKhauDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoTenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vaiTroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox_User_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBox_User_Input
            // 
            groupBox_User_Input.Controls.Add(checkBox_TK_LaQTV);
            groupBox_User_Input.Controls.Add(label3);
            groupBox_User_Input.Controls.Add(maskedTextBox_TK_HoTen);
            groupBox_User_Input.Controls.Add(label2);
            groupBox_User_Input.Controls.Add(label1);
            groupBox_User_Input.Controls.Add(maskedTextBox_TK_MatKhau);
            groupBox_User_Input.Controls.Add(textBox_TK_TenTK);
            groupBox_User_Input.Controls.Add(iconButton2);
            groupBox_User_Input.Controls.Add(iconButton1);
            groupBox_User_Input.Dock = DockStyle.Top;
            groupBox_User_Input.Location = new Point(0, 0);
            groupBox_User_Input.Margin = new Padding(0);
            groupBox_User_Input.Name = "groupBox_User_Input";
            groupBox_User_Input.Padding = new Padding(0);
            groupBox_User_Input.Size = new Size(782, 240);
            groupBox_User_Input.TabIndex = 0;
            groupBox_User_Input.TabStop = false;
            groupBox_User_Input.Text = "Nhập liệu";
            // 
            // checkBox_TK_LaQTV
            // 
            checkBox_TK_LaQTV.FlatStyle = FlatStyle.Flat;
            checkBox_TK_LaQTV.Location = new Point(200, 160);
            checkBox_TK_LaQTV.Name = "checkBox_TK_LaQTV";
            checkBox_TK_LaQTV.Size = new Size(200, 40);
            checkBox_TK_LaQTV.TabIndex = 15;
            checkBox_TK_LaQTV.Text = "Là quản trị viên";
            checkBox_TK_LaQTV.TextAlign = ContentAlignment.MiddleCenter;
            checkBox_TK_LaQTV.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Location = new Point(0, 120);
            label3.Margin = new Padding(3, 0, 20, 0);
            label3.Name = "label3";
            label3.Size = new Size(171, 40);
            label3.TabIndex = 14;
            label3.Text = "Họ tên";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // maskedTextBox_TK_HoTen
            // 
            maskedTextBox_TK_HoTen.Anchor = AnchorStyles.None;
            maskedTextBox_TK_HoTen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox_TK_HoTen.Location = new Point(200, 120);
            maskedTextBox_TK_HoTen.Name = "maskedTextBox_TK_HoTen";
            maskedTextBox_TK_HoTen.PasswordChar = '•';
            maskedTextBox_TK_HoTen.Size = new Size(200, 43);
            maskedTextBox_TK_HoTen.TabIndex = 13;
            // 
            // label2
            // 
            label2.Location = new Point(0, 80);
            label2.Margin = new Padding(3, 0, 20, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 40);
            label2.TabIndex = 12;
            label2.Text = "Mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(0, 40);
            label1.Margin = new Padding(3, 0, 20, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 40);
            label1.TabIndex = 11;
            label1.Text = "Tên người dùng";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // maskedTextBox_TK_MatKhau
            // 
            maskedTextBox_TK_MatKhau.Anchor = AnchorStyles.None;
            maskedTextBox_TK_MatKhau.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox_TK_MatKhau.Location = new Point(200, 80);
            maskedTextBox_TK_MatKhau.Name = "maskedTextBox_TK_MatKhau";
            maskedTextBox_TK_MatKhau.Size = new Size(200, 43);
            maskedTextBox_TK_MatKhau.TabIndex = 10;
            // 
            // textBox_TK_TenTK
            // 
            textBox_TK_TenTK.Anchor = AnchorStyles.None;
            textBox_TK_TenTK.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TK_TenTK.Location = new Point(200, 40);
            textBox_TK_TenTK.Name = "textBox_TK_TenTK";
            textBox_TK_TenTK.Size = new Size(200, 43);
            textBox_TK_TenTK.TabIndex = 9;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Right;
            iconButton2.BackColor = Color.FromArgb(255, 128, 128);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(480, 120);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(240, 80);
            iconButton2.TabIndex = 8;
            iconButton2.Text = "Đăng nhập";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Right;
            iconButton1.BackColor = Color.FromArgb(128, 255, 128);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(480, 40);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(240, 80);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Đăng nhập";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, tenTKDataGridViewTextBoxColumn, matKhauDataGridViewTextBoxColumn, hoTenDataGridViewTextBoxColumn, vaiTroDataGridViewTextBoxColumn });
            dataGridView1.DataSource = accountBindingSource1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(782, 313);
            dataGridView1.TabIndex = 1;
            // 
            // accountBindingSource
            // 
            accountBindingSource.DataSource = typeof(Data_Access.AccountContext);
            // 
            // accountBindingSource1
            // 
            accountBindingSource1.DataSource = typeof(Data_Access.Account);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenTKDataGridViewTextBoxColumn
            // 
            tenTKDataGridViewTextBoxColumn.DataPropertyName = "TenTK";
            tenTKDataGridViewTextBoxColumn.HeaderText = "TenTK";
            tenTKDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenTKDataGridViewTextBoxColumn.Name = "tenTKDataGridViewTextBoxColumn";
            tenTKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            matKhauDataGridViewTextBoxColumn.HeaderText = "MatKhau";
            matKhauDataGridViewTextBoxColumn.MinimumWidth = 6;
            matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vaiTroDataGridViewTextBoxColumn
            // 
            vaiTroDataGridViewTextBoxColumn.DataPropertyName = "VaiTro";
            vaiTroDataGridViewTextBoxColumn.HeaderText = "VaiTro";
            vaiTroDataGridViewTextBoxColumn.MinimumWidth = 6;
            vaiTroDataGridViewTextBoxColumn.Name = "vaiTroDataGridViewTextBoxColumn";
            vaiTroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_Account
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox_User_Input);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form_Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tài khoản";
            groupBox_User_Input.ResumeLayout(false);
            groupBox_User_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_User_Input;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenTKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vaiTroDataGridViewTextBoxColumn;
        private BindingSource accountBindingSource;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label3;
        private MaskedTextBox maskedTextBox_TK_HoTen;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox_TK_MatKhau;
        private TextBox textBox_TK_TenTK;
        private CheckBox checkBox_TK_LaQTV;
        private BindingSource accountBindingSource1;
    }
}