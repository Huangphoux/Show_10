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
            tabControl_BaoCao = new TabControl();
            tabPage_BCTon = new TabPage();
            dataGridView_BCTon = new DataGridView();
            groupBox_BCTon = new GroupBox();
            icon_BCTon = new FontAwesome.Sharp.IconButton();
            label_BCTon_KetThuc = new Label();
            date_BCTon_KetThuc = new DateTimePicker();
            label_BCTon_BatDau = new Label();
            date_BCTon_BatDau = new DateTimePicker();
            tabPage_BCNo = new TabPage();
            dataGridView_BCNo = new DataGridView();
            groupBox_BCNo = new GroupBox();
            label_BCNo_KetThuc = new Label();
            label_BCNo_BatDau = new Label();
            date_BCNo_BatDau = new DateTimePicker();
            icon_BCNo = new FontAwesome.Sharp.IconButton();
            date_BCNo_KetThuc = new DateTimePicker();
            tabControl_BaoCao.SuspendLayout();
            tabPage_BCTon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_BCTon).BeginInit();
            groupBox_BCTon.SuspendLayout();
            tabPage_BCNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_BCNo).BeginInit();
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
            dataGridView_BCTon.BackgroundColor = Color.White;
            dataGridView_BCTon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_BCTon.Dock = DockStyle.Fill;
            dataGridView_BCTon.Location = new Point(3, 231);
            dataGridView_BCTon.Name = "dataGridView_BCTon";
            dataGridView_BCTon.ReadOnly = true;
            dataGridView_BCTon.RowHeadersWidth = 51;
            dataGridView_BCTon.Size = new Size(766, 276);
            dataGridView_BCTon.TabIndex = 2;
            // 
            // groupBox_BCTon
            // 
            groupBox_BCTon.Controls.Add(icon_BCTon);
            groupBox_BCTon.Controls.Add(label_BCTon_KetThuc);
            groupBox_BCTon.Controls.Add(date_BCTon_KetThuc);
            groupBox_BCTon.Controls.Add(label_BCTon_BatDau);
            groupBox_BCTon.Controls.Add(date_BCTon_BatDau);
            groupBox_BCTon.Dock = DockStyle.Top;
            groupBox_BCTon.Location = new Point(3, 3);
            groupBox_BCTon.Name = "groupBox_BCTon";
            groupBox_BCTon.Size = new Size(766, 228);
            groupBox_BCTon.TabIndex = 1;
            groupBox_BCTon.TabStop = false;
            groupBox_BCTon.Text = "Nhập liệu";
            // 
            // icon_BCTon
            // 
            icon_BCTon.Anchor = AnchorStyles.Right;
            icon_BCTon.BackColor = Color.FromArgb(0, 192, 192);
            icon_BCTon.FlatAppearance.BorderSize = 0;
            icon_BCTon.FlatStyle = FlatStyle.Flat;
            icon_BCTon.Font = new Font("Segoe UI", 12F);
            icon_BCTon.IconChar = FontAwesome.Sharp.IconChar.Print;
            icon_BCTon.IconColor = Color.Black;
            icon_BCTon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_BCTon.IconSize = 30;
            icon_BCTon.ImageAlign = ContentAlignment.BottomCenter;
            icon_BCTon.Location = new Point(299, 131);
            icon_BCTon.Margin = new Padding(10);
            icon_BCTon.Name = "icon_BCTon";
            icon_BCTon.Size = new Size(168, 84);
            icon_BCTon.TabIndex = 36;
            icon_BCTon.Text = "In báo cáo";
            icon_BCTon.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_BCTon.UseVisualStyleBackColor = false;
            // 
            // label_BCTon_KetThuc
            // 
            label_BCTon_KetThuc.Location = new Point(143, 79);
            label_BCTon_KetThuc.Name = "label_BCTon_KetThuc";
            label_BCTon_KetThuc.Size = new Size(150, 34);
            label_BCTon_KetThuc.TabIndex = 3;
            label_BCTon_KetThuc.Text = "Ngày kết thúc";
            label_BCTon_KetThuc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // date_BCTon_KetThuc
            // 
            date_BCTon_KetThuc.Anchor = AnchorStyles.Right;
            date_BCTon_KetThuc.Format = DateTimePickerFormat.Short;
            date_BCTon_KetThuc.Location = new Point(299, 79);
            date_BCTon_KetThuc.Name = "date_BCTon_KetThuc";
            date_BCTon_KetThuc.Size = new Size(295, 34);
            date_BCTon_KetThuc.TabIndex = 2;
            // 
            // label_BCTon_BatDau
            // 
            label_BCTon_BatDau.Location = new Point(143, 33);
            label_BCTon_BatDau.Name = "label_BCTon_BatDau";
            label_BCTon_BatDau.Size = new Size(150, 34);
            label_BCTon_BatDau.TabIndex = 1;
            label_BCTon_BatDau.Text = "Ngày bắt đầu";
            label_BCTon_BatDau.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // date_BCTon_BatDau
            // 
            date_BCTon_BatDau.Anchor = AnchorStyles.Right;
            date_BCTon_BatDau.Format = DateTimePickerFormat.Short;
            date_BCTon_BatDau.Location = new Point(299, 33);
            date_BCTon_BatDau.Name = "date_BCTon_BatDau";
            date_BCTon_BatDau.Size = new Size(295, 34);
            date_BCTon_BatDau.TabIndex = 0;
            // 
            // tabPage_BCNo
            // 
            tabPage_BCNo.BorderStyle = BorderStyle.FixedSingle;
            tabPage_BCNo.Controls.Add(dataGridView_BCNo);
            tabPage_BCNo.Controls.Add(groupBox_BCNo);
            tabPage_BCNo.Location = new Point(4, 37);
            tabPage_BCNo.Name = "tabPage_BCNo";
            tabPage_BCNo.Padding = new Padding(3);
            tabPage_BCNo.Size = new Size(774, 512);
            tabPage_BCNo.TabIndex = 1;
            tabPage_BCNo.Text = "Báo cáo công nợ";
            tabPage_BCNo.UseVisualStyleBackColor = true;
            // 
            // dataGridView_BCNo
            // 
            dataGridView_BCNo.AllowUserToAddRows = false;
            dataGridView_BCNo.AllowUserToDeleteRows = false;
            dataGridView_BCNo.BackgroundColor = Color.White;
            dataGridView_BCNo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_BCNo.Dock = DockStyle.Fill;
            dataGridView_BCNo.Location = new Point(3, 231);
            dataGridView_BCNo.Name = "dataGridView_BCNo";
            dataGridView_BCNo.ReadOnly = true;
            dataGridView_BCNo.RowHeadersWidth = 51;
            dataGridView_BCNo.Size = new Size(766, 276);
            dataGridView_BCNo.TabIndex = 3;
            // 
            // groupBox_BCNo
            // 
            groupBox_BCNo.Controls.Add(label_BCNo_KetThuc);
            groupBox_BCNo.Controls.Add(label_BCNo_BatDau);
            groupBox_BCNo.Controls.Add(date_BCNo_BatDau);
            groupBox_BCNo.Controls.Add(icon_BCNo);
            groupBox_BCNo.Controls.Add(date_BCNo_KetThuc);
            groupBox_BCNo.Dock = DockStyle.Top;
            groupBox_BCNo.Location = new Point(3, 3);
            groupBox_BCNo.Name = "groupBox_BCNo";
            groupBox_BCNo.Size = new Size(766, 228);
            groupBox_BCNo.TabIndex = 2;
            groupBox_BCNo.TabStop = false;
            groupBox_BCNo.Text = "Nhập liệu";
            // 
            // label_BCNo_KetThuc
            // 
            label_BCNo_KetThuc.Anchor = AnchorStyles.Left;
            label_BCNo_KetThuc.Location = new Point(143, 79);
            label_BCNo_KetThuc.Name = "label_BCNo_KetThuc";
            label_BCNo_KetThuc.Size = new Size(150, 34);
            label_BCNo_KetThuc.TabIndex = 40;
            label_BCNo_KetThuc.Text = "Ngày kết thúc";
            label_BCNo_KetThuc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_BCNo_BatDau
            // 
            label_BCNo_BatDau.Anchor = AnchorStyles.Left;
            label_BCNo_BatDau.Location = new Point(143, 33);
            label_BCNo_BatDau.Name = "label_BCNo_BatDau";
            label_BCNo_BatDau.Size = new Size(150, 34);
            label_BCNo_BatDau.TabIndex = 39;
            label_BCNo_BatDau.Text = "Ngày bắt đầu";
            label_BCNo_BatDau.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // date_BCNo_BatDau
            // 
            date_BCNo_BatDau.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            date_BCNo_BatDau.Format = DateTimePickerFormat.Short;
            date_BCNo_BatDau.Location = new Point(299, 33);
            date_BCNo_BatDau.Name = "date_BCNo_BatDau";
            date_BCNo_BatDau.Size = new Size(295, 34);
            date_BCNo_BatDau.TabIndex = 38;
            // 
            // icon_BCNo
            // 
            icon_BCNo.Anchor = AnchorStyles.Right;
            icon_BCNo.BackColor = Color.FromArgb(0, 192, 192);
            icon_BCNo.FlatAppearance.BorderSize = 0;
            icon_BCNo.FlatStyle = FlatStyle.Flat;
            icon_BCNo.Font = new Font("Segoe UI", 12F);
            icon_BCNo.IconChar = FontAwesome.Sharp.IconChar.Print;
            icon_BCNo.IconColor = Color.Black;
            icon_BCNo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_BCNo.IconSize = 30;
            icon_BCNo.ImageAlign = ContentAlignment.BottomCenter;
            icon_BCNo.Location = new Point(299, 131);
            icon_BCNo.Margin = new Padding(10);
            icon_BCNo.Name = "icon_BCNo";
            icon_BCNo.Size = new Size(168, 84);
            icon_BCNo.TabIndex = 37;
            icon_BCNo.Text = "In báo cáo";
            icon_BCNo.TextImageRelation = TextImageRelation.ImageAboveText;
            icon_BCNo.UseVisualStyleBackColor = false;
            // 
            // date_BCNo_KetThuc
            // 
            date_BCNo_KetThuc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            date_BCNo_KetThuc.Format = DateTimePickerFormat.Short;
            date_BCNo_KetThuc.Location = new Point(299, 84);
            date_BCNo_KetThuc.Name = "date_BCNo_KetThuc";
            date_BCNo_KetThuc.Size = new Size(295, 34);
            date_BCNo_KetThuc.TabIndex = 0;
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
            tabControl_BaoCao.ResumeLayout(false);
            tabPage_BCTon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_BCTon).EndInit();
            groupBox_BCTon.ResumeLayout(false);
            tabPage_BCNo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_BCNo).EndInit();
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
        private DateTimePicker date_BCTon_KetThuc;
        private Label label_BCTon_BatDau;
        private DateTimePicker date_BCTon_BatDau;
        private FontAwesome.Sharp.IconButton icon_BCTon;
        private DataGridView dataGridView_BCNo;
        private GroupBox groupBox_BCNo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker date_BCNo_KetThuc;
        private FontAwesome.Sharp.IconButton icon_BCNo;
        private Label label_BCNo_KetThuc;
        private Label label_BCNo_BatDau;
        private DateTimePicker date_BCNo_BatDau;
    }
}