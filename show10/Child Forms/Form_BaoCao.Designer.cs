namespace Show10.Child_Forms {
    partial class Form_BaoCao {
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
            tabControl_BaoCao = new TabControl();
            tabPage_BCTon = new TabPage();
            dataGridView_BCTon = new DataGridView();
            maSachDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tonDauDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phatSinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tonCuoiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            baoCaoTonBindingSource = new BindingSource(components);
            groupBox_BCTon = new GroupBox();
            icon_BCTon_TaoMoi = new FontAwesome.Sharp.IconButton();
            label_BCTon_Nam = new Label();
            label_BCTon_Thang = new Label();
            comboBox_BCTon_Nam = new ComboBox();
            comboBox_BCTon_Thang = new ComboBox();
            icon_BCTon_In = new FontAwesome.Sharp.IconButton();
            tabPage_BCNo = new TabPage();
            dataGridView_BCNo = new DataGridView();
            maKHDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noDauDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phatSinhDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            noCuoiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            baoCaoNoBindingSource = new BindingSource(components);
            groupBox_BCNo = new GroupBox();
            icon_BCNo_TaoMoi = new FontAwesome.Sharp.IconButton();
            label_BCNo_Nam = new Label();
            label_BCNo_Thang = new Label();
            comboBox_BCNo_Nam = new ComboBox();
            comboBox_BCNo_Thang = new ComboBox();
            iconButton_BCNo_In = new FontAwesome.Sharp.IconButton();
            textBox_BCTon_Thang = new TextBox();
            tabControl_BaoCao.SuspendLayout();
            tabPage_BCTon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_BCTon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baoCaoTonBindingSource).BeginInit();
            groupBox_BCTon.SuspendLayout();
            tabPage_BCNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_BCNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baoCaoNoBindingSource).BeginInit();
            groupBox_BCNo.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl_BaoCao
            // 
            tabControl_BaoCao.Controls.Add(tabPage_BCTon);
            tabControl_BaoCao.Controls.Add(tabPage_BCNo);
            tabControl_BaoCao.Dock = DockStyle.Fill;
            tabControl_BaoCao.Location = new Point(0, 0);
            tabControl_BaoCao.Name = "tabControl_BaoCao";
            tabControl_BaoCao.SelectedIndex = 0;
            tabControl_BaoCao.Size = new Size(782, 553);
            tabControl_BaoCao.TabIndex = 0;
            // 
            // tabPage_BCTon
            // 
            tabPage_BCTon.BorderStyle = BorderStyle.FixedSingle;
            tabPage_BCTon.Controls.Add(dataGridView_BCTon);
            tabPage_BCTon.Controls.Add(groupBox_BCTon);
            tabPage_BCTon.Location = new Point(4, 37);
            tabPage_BCTon.Name = "tabPage_BCTon";
            tabPage_BCTon.Padding = new Padding(3);
            tabPage_BCTon.Size = new Size(774, 512);
            tabPage_BCTon.TabIndex = 0;
            tabPage_BCTon.Text = "Báo cáo tồn";
            tabPage_BCTon.UseVisualStyleBackColor = true;
            // 
            // dataGridView_BCTon
            // 
            dataGridView_BCTon.AllowUserToAddRows = false;
            dataGridView_BCTon.AllowUserToDeleteRows = false;
            dataGridView_BCTon.AutoGenerateColumns = false;
            dataGridView_BCTon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_BCTon.BackgroundColor = Color.White;
            dataGridView_BCTon.BorderStyle = BorderStyle.None;
            dataGridView_BCTon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Green;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_BCTon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_BCTon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_BCTon.Columns.AddRange(new DataGridViewColumn[] { maSachDataGridViewTextBoxColumn, tonDauDataGridViewTextBoxColumn, phatSinhDataGridViewTextBoxColumn, tonCuoiDataGridViewTextBoxColumn });
            dataGridView_BCTon.DataSource = baoCaoTonBindingSource;
            dataGridView_BCTon.Dock = DockStyle.Fill;
            dataGridView_BCTon.EnableHeadersVisualStyles = false;
            dataGridView_BCTon.GridColor = Color.Black;
            dataGridView_BCTon.Location = new Point(3, 159);
            dataGridView_BCTon.Name = "dataGridView_BCTon";
            dataGridView_BCTon.ReadOnly = true;
            dataGridView_BCTon.RowHeadersVisible = false;
            dataGridView_BCTon.RowHeadersWidth = 51;
            dataGridView_BCTon.Size = new Size(766, 348);
            dataGridView_BCTon.TabIndex = 2;
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            maSachDataGridViewTextBoxColumn.HeaderText = "Mã sách";
            maSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            maSachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tonDauDataGridViewTextBoxColumn
            // 
            tonDauDataGridViewTextBoxColumn.DataPropertyName = "TonDau";
            tonDauDataGridViewTextBoxColumn.HeaderText = "Tồn đầu";
            tonDauDataGridViewTextBoxColumn.MinimumWidth = 6;
            tonDauDataGridViewTextBoxColumn.Name = "tonDauDataGridViewTextBoxColumn";
            tonDauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phatSinhDataGridViewTextBoxColumn
            // 
            phatSinhDataGridViewTextBoxColumn.DataPropertyName = "PhatSinh";
            phatSinhDataGridViewTextBoxColumn.HeaderText = "Phát sinh";
            phatSinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            phatSinhDataGridViewTextBoxColumn.Name = "phatSinhDataGridViewTextBoxColumn";
            phatSinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tonCuoiDataGridViewTextBoxColumn
            // 
            tonCuoiDataGridViewTextBoxColumn.DataPropertyName = "TonCuoi";
            tonCuoiDataGridViewTextBoxColumn.HeaderText = "Tồn cuối";
            tonCuoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            tonCuoiDataGridViewTextBoxColumn.Name = "tonCuoiDataGridViewTextBoxColumn";
            tonCuoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // baoCaoTonBindingSource
            // 
            baoCaoTonBindingSource.DataSource = typeof(Models.BaoCaoTon);
            // 
            // groupBox_BCTon
            // 
            groupBox_BCTon.Controls.Add(icon_BCTon_TaoMoi);
            groupBox_BCTon.Controls.Add(label_BCTon_Nam);
            groupBox_BCTon.Controls.Add(label_BCTon_Thang);
            groupBox_BCTon.Controls.Add(comboBox_BCTon_Nam);
            groupBox_BCTon.Controls.Add(comboBox_BCTon_Thang);
            groupBox_BCTon.Controls.Add(icon_BCTon_In);
            groupBox_BCTon.Dock = DockStyle.Top;
            groupBox_BCTon.Location = new Point(3, 3);
            groupBox_BCTon.Name = "groupBox_BCTon";
            groupBox_BCTon.Size = new Size(766, 156);
            groupBox_BCTon.TabIndex = 1;
            groupBox_BCTon.TabStop = false;
            groupBox_BCTon.Text = "Nhập liệu";
            // 
            // icon_BCTon_TaoMoi
            // 
            icon_BCTon_TaoMoi.Anchor = AnchorStyles.Right;
            icon_BCTon_TaoMoi.BackColor = Color.Green;
            icon_BCTon_TaoMoi.FlatAppearance.BorderSize = 0;
            icon_BCTon_TaoMoi.FlatStyle = FlatStyle.Flat;
            icon_BCTon_TaoMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icon_BCTon_TaoMoi.ForeColor = Color.White;
            icon_BCTon_TaoMoi.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            icon_BCTon_TaoMoi.IconColor = Color.White;
            icon_BCTon_TaoMoi.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_BCTon_TaoMoi.IconSize = 30;
            icon_BCTon_TaoMoi.ImageAlign = ContentAlignment.BottomCenter;
            icon_BCTon_TaoMoi.Location = new Point(349, 40);
            icon_BCTon_TaoMoi.Margin = new Padding(10);
            icon_BCTon_TaoMoi.Name = "icon_BCTon_TaoMoi";
            icon_BCTon_TaoMoi.Size = new Size(174, 91);
            icon_BCTon_TaoMoi.TabIndex = 55;
            icon_BCTon_TaoMoi.Text = "Tạo mới";
            icon_BCTon_TaoMoi.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_BCTon_TaoMoi.UseVisualStyleBackColor = false;
            icon_BCTon_TaoMoi.Click += Icon_BCTon_TaoMoi_Click;
            // 
            // label_BCTon_Nam
            // 
            label_BCTon_Nam.Location = new Point(48, 95);
            label_BCTon_Nam.Name = "label_BCTon_Nam";
            label_BCTon_Nam.Size = new Size(80, 36);
            label_BCTon_Nam.TabIndex = 54;
            label_BCTon_Nam.Text = "Năm";
            label_BCTon_Nam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_BCTon_Thang
            // 
            label_BCTon_Thang.Location = new Point(48, 40);
            label_BCTon_Thang.Name = "label_BCTon_Thang";
            label_BCTon_Thang.Size = new Size(80, 36);
            label_BCTon_Thang.TabIndex = 53;
            label_BCTon_Thang.Text = "Tháng";
            label_BCTon_Thang.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox_BCTon_Nam
            // 
            comboBox_BCTon_Nam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_BCTon_Nam.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_BCTon_Nam.FormattingEnabled = true;
            comboBox_BCTon_Nam.Location = new Point(151, 95);
            comboBox_BCTon_Nam.Name = "comboBox_BCTon_Nam";
            comboBox_BCTon_Nam.Size = new Size(174, 36);
            comboBox_BCTon_Nam.TabIndex = 52;
            // 
            // comboBox_BCTon_Thang
            // 
            comboBox_BCTon_Thang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_BCTon_Thang.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_BCTon_Thang.FormattingEnabled = true;
            comboBox_BCTon_Thang.Location = new Point(151, 40);
            comboBox_BCTon_Thang.Name = "comboBox_BCTon_Thang";
            comboBox_BCTon_Thang.Size = new Size(174, 36);
            comboBox_BCTon_Thang.TabIndex = 51;
            // 
            // icon_BCTon_In
            // 
            icon_BCTon_In.Anchor = AnchorStyles.Right;
            icon_BCTon_In.BackColor = Color.White;
            icon_BCTon_In.FlatAppearance.BorderColor = Color.Green;
            icon_BCTon_In.FlatStyle = FlatStyle.Flat;
            icon_BCTon_In.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            icon_BCTon_In.ForeColor = Color.Green;
            icon_BCTon_In.IconChar = FontAwesome.Sharp.IconChar.Print;
            icon_BCTon_In.IconColor = Color.Green;
            icon_BCTon_In.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_BCTon_In.IconSize = 30;
            icon_BCTon_In.ImageAlign = ContentAlignment.BottomCenter;
            icon_BCTon_In.Location = new Point(547, 40);
            icon_BCTon_In.Margin = new Padding(10);
            icon_BCTon_In.Name = "icon_BCTon_In";
            icon_BCTon_In.Size = new Size(174, 91);
            icon_BCTon_In.TabIndex = 50;
            icon_BCTon_In.Text = "Lưu báo cáo";
            icon_BCTon_In.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_BCTon_In.UseVisualStyleBackColor = false;
            icon_BCTon_In.Click += Icon_BCTon_In_Click;
            // 
            // tabPage_BCNo
            // 
            tabPage_BCNo.BorderStyle = BorderStyle.FixedSingle;
            tabPage_BCNo.Controls.Add(dataGridView_BCNo);
            tabPage_BCNo.Controls.Add(groupBox_BCNo);
            tabPage_BCNo.Location = new Point(4, 29);
            tabPage_BCNo.Name = "tabPage_BCNo";
            tabPage_BCNo.Padding = new Padding(3);
            tabPage_BCNo.Size = new Size(774, 520);
            tabPage_BCNo.TabIndex = 1;
            tabPage_BCNo.Text = "Báo cáo công nợ";
            tabPage_BCNo.UseVisualStyleBackColor = true;
            // 
            // dataGridView_BCNo
            // 
            dataGridView_BCNo.AllowUserToAddRows = false;
            dataGridView_BCNo.AllowUserToDeleteRows = false;
            dataGridView_BCNo.AutoGenerateColumns = false;
            dataGridView_BCNo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_BCNo.BackgroundColor = Color.White;
            dataGridView_BCNo.BorderStyle = BorderStyle.None;
            dataGridView_BCNo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Green;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_BCNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_BCNo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_BCNo.Columns.AddRange(new DataGridViewColumn[] { maKHDataGridViewTextBoxColumn, noDauDataGridViewTextBoxColumn, phatSinhDataGridViewTextBoxColumn1, noCuoiDataGridViewTextBoxColumn });
            dataGridView_BCNo.DataSource = baoCaoNoBindingSource;
            dataGridView_BCNo.Dock = DockStyle.Fill;
            dataGridView_BCNo.EnableHeadersVisualStyles = false;
            dataGridView_BCNo.GridColor = Color.Black;
            dataGridView_BCNo.Location = new Point(3, 231);
            dataGridView_BCNo.Name = "dataGridView_BCNo";
            dataGridView_BCNo.ReadOnly = true;
            dataGridView_BCNo.RowHeadersVisible = false;
            dataGridView_BCNo.RowHeadersWidth = 51;
            dataGridView_BCNo.Size = new Size(766, 284);
            dataGridView_BCNo.TabIndex = 3;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            maKHDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            maKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            maKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noDauDataGridViewTextBoxColumn
            // 
            noDauDataGridViewTextBoxColumn.DataPropertyName = "NoDau";
            noDauDataGridViewTextBoxColumn.HeaderText = "Nợ đầu";
            noDauDataGridViewTextBoxColumn.MinimumWidth = 6;
            noDauDataGridViewTextBoxColumn.Name = "noDauDataGridViewTextBoxColumn";
            noDauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phatSinhDataGridViewTextBoxColumn1
            // 
            phatSinhDataGridViewTextBoxColumn1.DataPropertyName = "PhatSinh";
            phatSinhDataGridViewTextBoxColumn1.HeaderText = "Phát sinh";
            phatSinhDataGridViewTextBoxColumn1.MinimumWidth = 6;
            phatSinhDataGridViewTextBoxColumn1.Name = "phatSinhDataGridViewTextBoxColumn1";
            phatSinhDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // noCuoiDataGridViewTextBoxColumn
            // 
            noCuoiDataGridViewTextBoxColumn.DataPropertyName = "NoCuoi";
            noCuoiDataGridViewTextBoxColumn.HeaderText = "Nợ cuối";
            noCuoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            noCuoiDataGridViewTextBoxColumn.Name = "noCuoiDataGridViewTextBoxColumn";
            noCuoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // baoCaoNoBindingSource
            // 
            baoCaoNoBindingSource.DataSource = typeof(Models.BaoCaoNo);
            // 
            // groupBox_BCNo
            // 
            groupBox_BCNo.Controls.Add(icon_BCNo_TaoMoi);
            groupBox_BCNo.Controls.Add(label_BCNo_Nam);
            groupBox_BCNo.Controls.Add(label_BCNo_Thang);
            groupBox_BCNo.Controls.Add(comboBox_BCNo_Nam);
            groupBox_BCNo.Controls.Add(comboBox_BCNo_Thang);
            groupBox_BCNo.Controls.Add(iconButton_BCNo_In);
            groupBox_BCNo.Dock = DockStyle.Top;
            groupBox_BCNo.Location = new Point(3, 3);
            groupBox_BCNo.Name = "groupBox_BCNo";
            groupBox_BCNo.Size = new Size(766, 228);
            groupBox_BCNo.TabIndex = 4;
            groupBox_BCNo.TabStop = false;
            groupBox_BCNo.Text = "Nhập liệu";
            // 
            // icon_BCNo_TaoMoi
            // 
            icon_BCNo_TaoMoi.Anchor = AnchorStyles.Right;
            icon_BCNo_TaoMoi.BackColor = Color.Green;
            icon_BCNo_TaoMoi.FlatAppearance.BorderSize = 0;
            icon_BCNo_TaoMoi.FlatStyle = FlatStyle.Flat;
            icon_BCNo_TaoMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icon_BCNo_TaoMoi.ForeColor = Color.White;
            icon_BCNo_TaoMoi.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            icon_BCNo_TaoMoi.IconColor = Color.White;
            icon_BCNo_TaoMoi.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_BCNo_TaoMoi.IconSize = 30;
            icon_BCNo_TaoMoi.ImageAlign = ContentAlignment.BottomCenter;
            icon_BCNo_TaoMoi.Location = new Point(370, 40);
            icon_BCNo_TaoMoi.Margin = new Padding(10);
            icon_BCNo_TaoMoi.Name = "icon_BCNo_TaoMoi";
            icon_BCNo_TaoMoi.Size = new Size(174, 91);
            icon_BCNo_TaoMoi.TabIndex = 55;
            icon_BCNo_TaoMoi.Text = "Tạo mới";
            icon_BCNo_TaoMoi.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_BCNo_TaoMoi.UseVisualStyleBackColor = false;
            icon_BCNo_TaoMoi.Click += Icon_BCNo_TaoMoi_Click;
            // 
            // label_BCNo_Nam
            // 
            label_BCNo_Nam.Location = new Point(48, 95);
            label_BCNo_Nam.Name = "label_BCNo_Nam";
            label_BCNo_Nam.Size = new Size(80, 36);
            label_BCNo_Nam.TabIndex = 54;
            label_BCNo_Nam.Text = "Năm";
            label_BCNo_Nam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_BCNo_Thang
            // 
            label_BCNo_Thang.Location = new Point(48, 40);
            label_BCNo_Thang.Name = "label_BCNo_Thang";
            label_BCNo_Thang.Size = new Size(80, 36);
            label_BCNo_Thang.TabIndex = 53;
            label_BCNo_Thang.Text = "Tháng";
            label_BCNo_Thang.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox_BCNo_Nam
            // 
            comboBox_BCNo_Nam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_BCNo_Nam.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_BCNo_Nam.FormattingEnabled = true;
            comboBox_BCNo_Nam.Location = new Point(151, 95);
            comboBox_BCNo_Nam.Name = "comboBox_BCNo_Nam";
            comboBox_BCNo_Nam.Size = new Size(174, 36);
            comboBox_BCNo_Nam.TabIndex = 52;
            // 
            // comboBox_BCNo_Thang
            // 
            comboBox_BCNo_Thang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_BCNo_Thang.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_BCNo_Thang.FormattingEnabled = true;
            comboBox_BCNo_Thang.Location = new Point(151, 40);
            comboBox_BCNo_Thang.Name = "comboBox_BCNo_Thang";
            comboBox_BCNo_Thang.Size = new Size(174, 36);
            comboBox_BCNo_Thang.TabIndex = 51;
            // 
            // iconButton_BCNo_In
            // 
            iconButton_BCNo_In.Anchor = AnchorStyles.Right;
            iconButton_BCNo_In.BackColor = Color.White;
            iconButton_BCNo_In.FlatAppearance.BorderColor = Color.Green;
            iconButton_BCNo_In.FlatStyle = FlatStyle.Flat;
            iconButton_BCNo_In.Font = new Font("Segoe UI", 12F);
            iconButton_BCNo_In.ForeColor = Color.Green;
            iconButton_BCNo_In.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconButton_BCNo_In.IconColor = Color.Green;
            iconButton_BCNo_In.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton_BCNo_In.IconSize = 30;
            iconButton_BCNo_In.ImageAlign = ContentAlignment.BottomCenter;
            iconButton_BCNo_In.Location = new Point(558, 40);
            iconButton_BCNo_In.Margin = new Padding(10);
            iconButton_BCNo_In.Name = "iconButton_BCNo_In";
            iconButton_BCNo_In.Size = new Size(174, 91);
            iconButton_BCNo_In.TabIndex = 50;
            iconButton_BCNo_In.Text = "In báo cáo";
            iconButton_BCNo_In.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton_BCNo_In.UseVisualStyleBackColor = false;
            iconButton_BCNo_In.Click += IconButton_BCNo_In_Click;
            // 
            // textBox_BCTon_Thang
            // 
            textBox_BCTon_Thang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_BCTon_Thang.Font = new Font("Segoe UI", 12F);
            textBox_BCTon_Thang.Location = new Point(299, 33);
            textBox_BCTon_Thang.Name = "textBox_BCTon_Thang";
            textBox_BCTon_Thang.Size = new Size(271, 34);
            textBox_BCTon_Thang.TabIndex = 37;
            // 
            // Form_BaoCao
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(tabControl_BaoCao);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form_BaoCao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo";
            FormClosing += Form_BaoCao_FormClosing;
            Load += Form_BaoCao_Load;
            tabControl_BaoCao.ResumeLayout(false);
            tabPage_BCTon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_BCTon).EndInit();
            ((System.ComponentModel.ISupportInitialize)baoCaoTonBindingSource).EndInit();
            groupBox_BCTon.ResumeLayout(false);
            tabPage_BCNo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_BCNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)baoCaoNoBindingSource).EndInit();
            groupBox_BCNo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl_BaoCao;
        private TabPage tabPage_BCTon;
        private TabPage tabPage_BCNo;
        private GroupBox groupBox_BCTon;
        private DataGridView dataGridView_BCTon;
        private Label label_BCTon_KetThuc;
        private Label label_BCTon_BatDau;
        private FontAwesome.Sharp.IconButton icon_BCTon;
        private DataGridView dataGridView_BCNo;
        private FontAwesome.Sharp.IconButton icon_BCTon_TaoMoi;
        private Label label_BCTon_Thang;
        private DateTimePicker dateTimePicker1;
        private Label label_BCTon_Nam;
        private DateTimePicker date_BCNo_KetThuc;
        private FontAwesome.Sharp.IconButton icon_BCNo;
        private Label label_BCNo_KetThuc;
        private Label label_BCNo_BatDau;
        private DateTimePicker date_BCNo_BatDau;
        private TextBox textBox1;
        private TextBox textBox_BCTon_Thang;
        private ComboBox comboBox_BCTon_Nam;
        private ComboBox comboBox_BCTon_Thang;
        private FontAwesome.Sharp.IconButton icon_BCTon_In;
        private GroupBox groupBox_BCNo;
        private FontAwesome.Sharp.IconButton icon_BCNo_TaoMoi;
        private Label label_BCNo_Nam;
        private Label label_BCNo_Thang;
        private ComboBox comboBox_BCNo_Nam;
        private ComboBox comboBox_BCNo_Thang;
        private FontAwesome.Sharp.IconButton iconButton_BCNo_In;
        private BindingSource baoCaoTonBindingSource;
        private DataGridViewTextBoxColumn tenTKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vaiTroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tonDauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phatSinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tonCuoiDataGridViewTextBoxColumn;
        private BindingSource baoCaoNoBindingSource;
        private DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noDauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phatSinhDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn noCuoiDataGridViewTextBoxColumn;
    }
}