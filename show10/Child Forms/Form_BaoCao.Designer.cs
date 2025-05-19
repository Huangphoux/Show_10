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
            this.icon_BCTon_In = new FontAwesome.Sharp.IconButton();
            this.label_BCTon_Nam = new Label();
            this.label_BCTon_Thang = new Label();
            tabPage_BCNo = new TabPage();
            dataGridView_BCNo = new DataGridView();
            textBox_BCTon_Thang = new TextBox();
            this.textBox_BCTon_Nam = new TextBox();
            groupBox_BCNo = new GroupBox();
            textBox_BCNo_Nam = new TextBox();
            textBox_BCNo_Thang = new TextBox();
            this.icon_BCNo_In = new FontAwesome.Sharp.IconButton();
            this.label_BCNo_Nam = new Label();
            this.label_BCNo_Thang = new Label();
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
            groupBox_BCTon.Controls.Add(this.textBox_BCTon_Nam);
            groupBox_BCTon.Controls.Add(textBox_BCTon_Thang);
            groupBox_BCTon.Controls.Add(this.icon_BCTon_In);
            groupBox_BCTon.Controls.Add(this.label_BCTon_Nam);
            groupBox_BCTon.Controls.Add(this.label_BCTon_Thang);
            groupBox_BCTon.Dock = DockStyle.Top;
            groupBox_BCTon.Location = new Point(3, 3);
            groupBox_BCTon.Name = "groupBox_BCTon";
            groupBox_BCTon.Size = new Size(766, 228);
            groupBox_BCTon.TabIndex = 1;
            groupBox_BCTon.TabStop = false;
            groupBox_BCTon.Text = "Nhập liệu";
            // 
            // icon_BCTon_In
            // 
            this.icon_BCTon_In.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.icon_BCTon_In.BackColor = Color.FromArgb(128, 255, 128);
            this.icon_BCTon_In.FlatAppearance.BorderSize = 0;
            this.icon_BCTon_In.FlatStyle = FlatStyle.Flat;
            this.icon_BCTon_In.Font = new Font("Segoe UI", 12F);
            this.icon_BCTon_In.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.icon_BCTon_In.IconColor = Color.Black;
            this.icon_BCTon_In.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.icon_BCTon_In.IconSize = 30;
            this.icon_BCTon_In.ImageAlign = ContentAlignment.BottomCenter;
            this.icon_BCTon_In.Location = new Point(299, 131);
            this.icon_BCTon_In.Margin = new Padding(10);
            this.icon_BCTon_In.Name = "icon_BCTon_In";
            this.icon_BCTon_In.Size = new Size(168, 84);
            this.icon_BCTon_In.TabIndex = 36;
            this.icon_BCTon_In.Text = "In báo cáo";
            this.icon_BCTon_In.TextImageRelation = TextImageRelation.ImageAboveText;
            this.icon_BCTon_In.UseVisualStyleBackColor = false;
            // 
            // label_BCTon_Nam
            // 
            this.label_BCTon_Nam.Location = new Point(177, 79);
            this.label_BCTon_Nam.Name = "label_BCTon_Nam";
            this.label_BCTon_Nam.Size = new Size(116, 34);
            this.label_BCTon_Nam.TabIndex = 3;
            this.label_BCTon_Nam.Text = "Năm";
            this.label_BCTon_Nam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_BCTon_Thang
            // 
            this.label_BCTon_Thang.Location = new Point(177, 33);
            this.label_BCTon_Thang.Name = "label_BCTon_Thang";
            this.label_BCTon_Thang.Size = new Size(116, 34);
            this.label_BCTon_Thang.TabIndex = 1;
            this.label_BCTon_Thang.Text = "Tháng";
            this.label_BCTon_Thang.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPage_BCNo
            // 
            tabPage_BCNo.BorderStyle = BorderStyle.FixedSingle;
            tabPage_BCNo.Controls.Add(groupBox_BCNo);
            tabPage_BCNo.Controls.Add(dataGridView_BCNo);
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
            dataGridView_BCNo.Location = new Point(3, 3);
            dataGridView_BCNo.Name = "dataGridView_BCNo";
            dataGridView_BCNo.ReadOnly = true;
            dataGridView_BCNo.RowHeadersWidth = 51;
            dataGridView_BCNo.Size = new Size(766, 504);
            dataGridView_BCNo.TabIndex = 3;
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
            // textBox_BCTon_Nam
            // 
            this.textBox_BCTon_Nam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.textBox_BCTon_Nam.Font = new Font("Segoe UI", 12F);
            this.textBox_BCTon_Nam.Location = new Point(299, 84);
            this.textBox_BCTon_Nam.Name = "textBox_BCTon_Nam";
            this.textBox_BCTon_Nam.Size = new Size(271, 34);
            this.textBox_BCTon_Nam.TabIndex = 38;
            // 
            // groupBox_BCNo
            // 
            groupBox_BCNo.Controls.Add(textBox_BCNo_Nam);
            groupBox_BCNo.Controls.Add(textBox_BCNo_Thang);
            groupBox_BCNo.Controls.Add(this.icon_BCNo_In);
            groupBox_BCNo.Controls.Add(this.label_BCNo_Nam);
            groupBox_BCNo.Controls.Add(this.label_BCNo_Thang);
            groupBox_BCNo.Dock = DockStyle.Top;
            groupBox_BCNo.Location = new Point(3, 3);
            groupBox_BCNo.Name = "groupBox_BCNo";
            groupBox_BCNo.Size = new Size(766, 228);
            groupBox_BCNo.TabIndex = 4;
            groupBox_BCNo.TabStop = false;
            groupBox_BCNo.Text = "Nhập liệu";
            // 
            // textBox_BCNo_Nam
            // 
            textBox_BCNo_Nam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_BCNo_Nam.Font = new Font("Segoe UI", 12F);
            textBox_BCNo_Nam.Location = new Point(299, 84);
            textBox_BCNo_Nam.Name = "textBox_BCNo_Nam";
            textBox_BCNo_Nam.Size = new Size(280, 34);
            textBox_BCNo_Nam.TabIndex = 38;
            // 
            // textBox_BCNo_Thang
            // 
            textBox_BCNo_Thang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_BCNo_Thang.Font = new Font("Segoe UI", 12F);
            textBox_BCNo_Thang.Location = new Point(299, 33);
            textBox_BCNo_Thang.Name = "textBox_BCNo_Thang";
            textBox_BCNo_Thang.Size = new Size(280, 34);
            textBox_BCNo_Thang.TabIndex = 37;
            // 
            // icon_BCNo_In
            // 
            this.icon_BCNo_In.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.icon_BCNo_In.BackColor = Color.FromArgb(128, 255, 128);
            this.icon_BCNo_In.FlatAppearance.BorderSize = 0;
            this.icon_BCNo_In.FlatStyle = FlatStyle.Flat;
            this.icon_BCNo_In.Font = new Font("Segoe UI", 12F);
            this.icon_BCNo_In.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.icon_BCNo_In.IconColor = Color.Black;
            this.icon_BCNo_In.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.icon_BCNo_In.IconSize = 30;
            this.icon_BCNo_In.ImageAlign = ContentAlignment.BottomCenter;
            this.icon_BCNo_In.Location = new Point(299, 131);
            this.icon_BCNo_In.Margin = new Padding(10);
            this.icon_BCNo_In.Name = "icon_BCNo_In";
            this.icon_BCNo_In.Size = new Size(177, 84);
            this.icon_BCNo_In.TabIndex = 36;
            this.icon_BCNo_In.Text = "In báo cáo";
            this.icon_BCNo_In.TextImageRelation = TextImageRelation.ImageAboveText;
            this.icon_BCNo_In.UseVisualStyleBackColor = false;
            // 
            // label_BCNo_Nam
            // 
            this.label_BCNo_Nam.Location = new Point(177, 79);
            this.label_BCNo_Nam.Name = "label_BCNo_Nam";
            this.label_BCNo_Nam.Size = new Size(116, 34);
            this.label_BCNo_Nam.TabIndex = 3;
            this.label_BCNo_Nam.Text = "Năm";
            this.label_BCNo_Nam.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_BCNo_Thang
            // 
            this.label_BCNo_Thang.Location = new Point(177, 33);
            this.label_BCNo_Thang.Name = "label_BCNo_Thang";
            this.label_BCNo_Thang.Size = new Size(116, 34);
            this.label_BCNo_Thang.TabIndex = 1;
            this.label_BCNo_Thang.Text = "Tháng";
            this.label_BCNo_Thang.TextAlign = ContentAlignment.MiddleLeft;
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
            groupBox_BCTon.PerformLayout();
            tabPage_BCNo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_BCNo).EndInit();
            groupBox_BCNo.ResumeLayout(false);
            groupBox_BCNo.PerformLayout();
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
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker date_BCNo_KetThuc;
        private FontAwesome.Sharp.IconButton icon_BCNo;
        private Label label_BCNo_KetThuc;
        private Label label_BCNo_BatDau;
        private DateTimePicker date_BCNo_BatDau;
        private TextBox textBox1;
        private TextBox textBox_BCTon_Thang;
        private GroupBox groupBox_BCNo;
        private TextBox textBox_BCNo_Nam;
        private TextBox textBox_BCNo_Thang;
    }
}