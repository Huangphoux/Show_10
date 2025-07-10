namespace Show10.Windows
{
    partial class Form_Settings
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
            label_Settings = new Label();
            textBox_minNhap = new TextBox();
            label_minNhap = new Label();
            label_maxNo = new Label();
            textBox_maxNo = new TextBox();
            label_maxSLSach = new Label();
            textBox_maxSLSach = new TextBox();
            label_minSLSach = new Label();
            textBox_minSLSach = new TextBox();
            label_thuTienVuotNo = new Label();
            checkBox_thuTienVuotNo = new CheckBox();
            icon_Luu = new FontAwesome.Sharp.IconButton();
            icon_Reset = new FontAwesome.Sharp.IconButton();
            icon_DeleteDB = new FontAwesome.Sharp.IconButton();
            listBox_theLoai = new ListBox();
            button_TheLoai_Them = new Button();
            textBox_TheLoai_Them = new TextBox();
            button_TheLoai_Xoa = new Button();
            tabControl_CaiDat = new TabControl();
            tabPage_QuiDinh = new TabPage();
            tabPage_TheLoai = new TabPage();
            tabPage_NhaCungCap = new TabPage();
            listBox_nhaCungCap = new ListBox();
            textBox_NCC_Them = new TextBox();
            button_NCC_Them = new Button();
            button_NCC_Xoa = new Button();
            tabControl_CaiDat.SuspendLayout();
            tabPage_QuiDinh.SuspendLayout();
            tabPage_TheLoai.SuspendLayout();
            tabPage_NhaCungCap.SuspendLayout();
            SuspendLayout();
            // 
            // label_Settings
            // 
            label_Settings.BackColor = Color.Green;
            label_Settings.Dock = DockStyle.Top;
            label_Settings.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Settings.ForeColor = Color.White;
            label_Settings.Location = new Point(0, 0);
            label_Settings.Margin = new Padding(4, 0, 4, 0);
            label_Settings.Name = "label_Settings";
            label_Settings.Size = new Size(782, 62);
            label_Settings.TabIndex = 0;
            label_Settings.Text = "Cài đặt !";
            label_Settings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_minNhap
            // 
            textBox_minNhap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_minNhap.BorderStyle = BorderStyle.FixedSingle;
            textBox_minNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_minNhap.Location = new Point(438, 21);
            textBox_minNhap.Margin = new Padding(4);
            textBox_minNhap.Name = "textBox_minNhap";
            textBox_minNhap.Size = new Size(310, 34);
            textBox_minNhap.TabIndex = 1;
            // 
            // label_minNhap
            // 
            label_minNhap.AutoSize = true;
            label_minNhap.Location = new Point(17, 24);
            label_minNhap.Margin = new Padding(4, 0, 4, 0);
            label_minNhap.Name = "label_minNhap";
            label_minNhap.Size = new Size(267, 28);
            label_minNhap.TabIndex = 2;
            label_minNhap.Text = "Số lượng nhập sách tối thiểu ";
            // 
            // label_maxNo
            // 
            label_maxNo.AutoSize = true;
            label_maxNo.Location = new Point(17, 80);
            label_maxNo.Margin = new Padding(4, 0, 4, 0);
            label_maxNo.Name = "label_maxNo";
            label_maxNo.Size = new Size(132, 28);
            label_maxNo.TabIndex = 4;
            label_maxNo.Text = "Tiền nợ tối đa";
            // 
            // textBox_maxNo
            // 
            textBox_maxNo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_maxNo.BorderStyle = BorderStyle.FixedSingle;
            textBox_maxNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_maxNo.Location = new Point(438, 77);
            textBox_maxNo.Margin = new Padding(4);
            textBox_maxNo.Name = "textBox_maxNo";
            textBox_maxNo.Size = new Size(310, 34);
            textBox_maxNo.TabIndex = 3;
            // 
            // label_maxSLSach
            // 
            label_maxSLSach.AutoSize = true;
            label_maxSLSach.Location = new Point(17, 136);
            label_maxSLSach.Margin = new Padding(4, 0, 4, 0);
            label_maxSLSach.Name = "label_maxSLSach";
            label_maxSLSach.Size = new Size(396, 28);
            label_maxSLSach.TabIndex = 6;
            label_maxSLSach.Text = "Số lượng sách tồn kho tối đa trước khi nhập";
            // 
            // textBox_maxSLSach
            // 
            textBox_maxSLSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_maxSLSach.BorderStyle = BorderStyle.FixedSingle;
            textBox_maxSLSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_maxSLSach.Location = new Point(438, 133);
            textBox_maxSLSach.Margin = new Padding(4);
            textBox_maxSLSach.Name = "textBox_maxSLSach";
            textBox_maxSLSach.Size = new Size(310, 34);
            textBox_maxSLSach.TabIndex = 5;
            // 
            // label_minSLSach
            // 
            label_minSLSach.AutoSize = true;
            label_minSLSach.Location = new Point(17, 192);
            label_minSLSach.Margin = new Padding(4, 0, 4, 0);
            label_minSLSach.Name = "label_minSLSach";
            label_minSLSach.Size = new Size(346, 28);
            label_minSLSach.TabIndex = 8;
            label_minSLSach.Text = "Số lượng tồn kho tối thiểu sau khi bán";
            // 
            // textBox_minSLSach
            // 
            textBox_minSLSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_minSLSach.BorderStyle = BorderStyle.FixedSingle;
            textBox_minSLSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_minSLSach.Location = new Point(438, 189);
            textBox_minSLSach.Margin = new Padding(4);
            textBox_minSLSach.Name = "textBox_minSLSach";
            textBox_minSLSach.Size = new Size(310, 34);
            textBox_minSLSach.TabIndex = 7;
            // 
            // label_thuTienVuotNo
            // 
            label_thuTienVuotNo.AutoSize = true;
            label_thuTienVuotNo.Location = new Point(17, 248);
            label_thuTienVuotNo.Margin = new Padding(4, 0, 4, 0);
            label_thuTienVuotNo.Name = "label_thuTienVuotNo";
            label_thuTienVuotNo.Size = new Size(340, 28);
            label_thuTienVuotNo.TabIndex = 11;
            label_thuTienVuotNo.Text = "Có thể thu vượt tiền nợ được không ?";
            // 
            // checkBox_thuTienVuotNo
            // 
            checkBox_thuTienVuotNo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBox_thuTienVuotNo.FlatStyle = FlatStyle.Flat;
            checkBox_thuTienVuotNo.Location = new Point(438, 248);
            checkBox_thuTienVuotNo.Margin = new Padding(4);
            checkBox_thuTienVuotNo.Name = "checkBox_thuTienVuotNo";
            checkBox_thuTienVuotNo.Size = new Size(310, 37);
            checkBox_thuTienVuotNo.TabIndex = 12;
            checkBox_thuTienVuotNo.UseVisualStyleBackColor = true;
            // 
            // icon_Luu
            // 
            icon_Luu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            icon_Luu.BackColor = Color.Green;
            icon_Luu.FlatAppearance.BorderSize = 0;
            icon_Luu.FlatStyle = FlatStyle.Flat;
            icon_Luu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icon_Luu.ForeColor = Color.White;
            icon_Luu.IconChar = FontAwesome.Sharp.IconChar.Save;
            icon_Luu.IconColor = Color.White;
            icon_Luu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Luu.IconSize = 30;
            icon_Luu.Location = new Point(683, 557);
            icon_Luu.Name = "icon_Luu";
            icon_Luu.Padding = new Padding(10);
            icon_Luu.Size = new Size(70, 70);
            icon_Luu.TabIndex = 13;
            icon_Luu.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_Luu.UseVisualStyleBackColor = false;
            icon_Luu.Click += Icon_Luu_Click;
            // 
            // icon_Reset
            // 
            icon_Reset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            icon_Reset.BackColor = Color.White;
            icon_Reset.FlatAppearance.BorderColor = Color.Blue;
            icon_Reset.FlatAppearance.BorderSize = 2;
            icon_Reset.FlatStyle = FlatStyle.Flat;
            icon_Reset.ForeColor = Color.Blue;
            icon_Reset.IconChar = FontAwesome.Sharp.IconChar.RotateBack;
            icon_Reset.IconColor = Color.Blue;
            icon_Reset.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_Reset.IconSize = 30;
            icon_Reset.Location = new Point(17, 315);
            icon_Reset.Name = "icon_Reset";
            icon_Reset.Padding = new Padding(10);
            icon_Reset.Size = new Size(70, 70);
            icon_Reset.TabIndex = 14;
            icon_Reset.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_Reset.UseVisualStyleBackColor = false;
            icon_Reset.Click += Icon_Reset_Click;
            // 
            // icon_DeleteDB
            // 
            icon_DeleteDB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            icon_DeleteDB.BackColor = Color.White;
            icon_DeleteDB.FlatAppearance.BorderColor = Color.Red;
            icon_DeleteDB.FlatAppearance.BorderSize = 2;
            icon_DeleteDB.FlatStyle = FlatStyle.Flat;
            icon_DeleteDB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icon_DeleteDB.ForeColor = Color.Red;
            icon_DeleteDB.IconChar = FontAwesome.Sharp.IconChar.Trash;
            icon_DeleteDB.IconColor = Color.Red;
            icon_DeleteDB.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_DeleteDB.IconSize = 30;
            icon_DeleteDB.Location = new Point(22, 557);
            icon_DeleteDB.Name = "icon_DeleteDB";
            icon_DeleteDB.Padding = new Padding(10);
            icon_DeleteDB.Size = new Size(70, 70);
            icon_DeleteDB.TabIndex = 15;
            icon_DeleteDB.UseVisualStyleBackColor = false;
            icon_DeleteDB.Click += Icon_DeleteDB_Click;
            // 
            // listBox_theLoai
            // 
            listBox_theLoai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox_theLoai.BorderStyle = BorderStyle.FixedSingle;
            listBox_theLoai.FormattingEnabled = true;
            listBox_theLoai.Location = new Point(40, 100);
            listBox_theLoai.Name = "listBox_theLoai";
            listBox_theLoai.Size = new Size(530, 282);
            listBox_theLoai.TabIndex = 16;
            // 
            // button_TheLoai_Them
            // 
            button_TheLoai_Them.Anchor = AnchorStyles.Right;
            button_TheLoai_Them.BackColor = Color.FromArgb(128, 255, 128);
            button_TheLoai_Them.FlatStyle = FlatStyle.Flat;
            button_TheLoai_Them.Location = new Point(590, 40);
            button_TheLoai_Them.Name = "button_TheLoai_Them";
            button_TheLoai_Them.Size = new Size(158, 40);
            button_TheLoai_Them.TabIndex = 18;
            button_TheLoai_Them.Text = "Thêm";
            button_TheLoai_Them.UseVisualStyleBackColor = false;
            button_TheLoai_Them.Click += Button_TheLoai_Them_Click;
            // 
            // textBox_TheLoai_Them
            // 
            textBox_TheLoai_Them.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_TheLoai_Them.BorderStyle = BorderStyle.FixedSingle;
            textBox_TheLoai_Them.Location = new Point(40, 40);
            textBox_TheLoai_Them.Name = "textBox_TheLoai_Them";
            textBox_TheLoai_Them.Size = new Size(530, 34);
            textBox_TheLoai_Them.TabIndex = 19;
            // 
            // button_TheLoai_Xoa
            // 
            button_TheLoai_Xoa.Anchor = AnchorStyles.Right;
            button_TheLoai_Xoa.BackColor = Color.FromArgb(255, 128, 128);
            button_TheLoai_Xoa.FlatStyle = FlatStyle.Flat;
            button_TheLoai_Xoa.Location = new Point(590, 100);
            button_TheLoai_Xoa.Name = "button_TheLoai_Xoa";
            button_TheLoai_Xoa.Size = new Size(158, 40);
            button_TheLoai_Xoa.TabIndex = 20;
            button_TheLoai_Xoa.Text = "Xoá";
            button_TheLoai_Xoa.UseVisualStyleBackColor = false;
            button_TheLoai_Xoa.Click += Button_TheLoai_Xoa_Click;
            // 
            // tabControl_CaiDat
            // 
            tabControl_CaiDat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_CaiDat.Controls.Add(tabPage_QuiDinh);
            tabControl_CaiDat.Controls.Add(tabPage_TheLoai);
            tabControl_CaiDat.Controls.Add(tabPage_NhaCungCap);
            tabControl_CaiDat.Location = new Point(0, 62);
            tabControl_CaiDat.Name = "tabControl_CaiDat";
            tabControl_CaiDat.SelectedIndex = 0;
            tabControl_CaiDat.Size = new Size(782, 455);
            tabControl_CaiDat.TabIndex = 22;
            // 
            // tabPage_QuiDinh
            // 
            tabPage_QuiDinh.BorderStyle = BorderStyle.FixedSingle;
            tabPage_QuiDinh.Controls.Add(label_minNhap);
            tabPage_QuiDinh.Controls.Add(textBox_minNhap);
            tabPage_QuiDinh.Controls.Add(icon_Reset);
            tabPage_QuiDinh.Controls.Add(textBox_maxNo);
            tabPage_QuiDinh.Controls.Add(label_maxNo);
            tabPage_QuiDinh.Controls.Add(checkBox_thuTienVuotNo);
            tabPage_QuiDinh.Controls.Add(textBox_maxSLSach);
            tabPage_QuiDinh.Controls.Add(label_thuTienVuotNo);
            tabPage_QuiDinh.Controls.Add(label_maxSLSach);
            tabPage_QuiDinh.Controls.Add(label_minSLSach);
            tabPage_QuiDinh.Controls.Add(textBox_minSLSach);
            tabPage_QuiDinh.Location = new Point(4, 37);
            tabPage_QuiDinh.Name = "tabPage_QuiDinh";
            tabPage_QuiDinh.Padding = new Padding(3);
            tabPage_QuiDinh.Size = new Size(774, 414);
            tabPage_QuiDinh.TabIndex = 0;
            tabPage_QuiDinh.Text = "Qui định";
            tabPage_QuiDinh.UseVisualStyleBackColor = true;
            // 
            // tabPage_TheLoai
            // 
            tabPage_TheLoai.BorderStyle = BorderStyle.FixedSingle;
            tabPage_TheLoai.Controls.Add(listBox_theLoai);
            tabPage_TheLoai.Controls.Add(textBox_TheLoai_Them);
            tabPage_TheLoai.Controls.Add(button_TheLoai_Them);
            tabPage_TheLoai.Controls.Add(button_TheLoai_Xoa);
            tabPage_TheLoai.Location = new Point(4, 29);
            tabPage_TheLoai.Name = "tabPage_TheLoai";
            tabPage_TheLoai.Padding = new Padding(3);
            tabPage_TheLoai.Size = new Size(774, 422);
            tabPage_TheLoai.TabIndex = 1;
            tabPage_TheLoai.Text = "Thể loại sách";
            tabPage_TheLoai.UseVisualStyleBackColor = true;
            // 
            // tabPage_NhaCungCap
            // 
            tabPage_NhaCungCap.BorderStyle = BorderStyle.FixedSingle;
            tabPage_NhaCungCap.Controls.Add(listBox_nhaCungCap);
            tabPage_NhaCungCap.Controls.Add(textBox_NCC_Them);
            tabPage_NhaCungCap.Controls.Add(button_NCC_Them);
            tabPage_NhaCungCap.Controls.Add(button_NCC_Xoa);
            tabPage_NhaCungCap.Location = new Point(4, 29);
            tabPage_NhaCungCap.Name = "tabPage_NhaCungCap";
            tabPage_NhaCungCap.Padding = new Padding(3);
            tabPage_NhaCungCap.Size = new Size(774, 422);
            tabPage_NhaCungCap.TabIndex = 2;
            tabPage_NhaCungCap.Text = "Nhà cung cấp";
            tabPage_NhaCungCap.UseVisualStyleBackColor = true;
            // 
            // listBox_nhaCungCap
            // 
            listBox_nhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox_nhaCungCap.BorderStyle = BorderStyle.FixedSingle;
            listBox_nhaCungCap.FormattingEnabled = true;
            listBox_nhaCungCap.Location = new Point(40, 100);
            listBox_nhaCungCap.Name = "listBox_nhaCungCap";
            listBox_nhaCungCap.Size = new Size(530, 282);
            listBox_nhaCungCap.TabIndex = 21;
            // 
            // textBox_NCC_Them
            // 
            textBox_NCC_Them.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_NCC_Them.BorderStyle = BorderStyle.FixedSingle;
            textBox_NCC_Them.Location = new Point(40, 40);
            textBox_NCC_Them.Name = "textBox_NCC_Them";
            textBox_NCC_Them.Size = new Size(530, 34);
            textBox_NCC_Them.TabIndex = 23;
            // 
            // button_NCC_Them
            // 
            button_NCC_Them.Anchor = AnchorStyles.Right;
            button_NCC_Them.BackColor = Color.FromArgb(128, 255, 128);
            button_NCC_Them.FlatStyle = FlatStyle.Flat;
            button_NCC_Them.Location = new Point(590, 36);
            button_NCC_Them.Name = "button_NCC_Them";
            button_NCC_Them.Size = new Size(158, 40);
            button_NCC_Them.TabIndex = 22;
            button_NCC_Them.Text = "Thêm";
            button_NCC_Them.UseVisualStyleBackColor = false;
            button_NCC_Them.Click += Button_NCC_Them_Click;
            // 
            // button_NCC_Xoa
            // 
            button_NCC_Xoa.Anchor = AnchorStyles.Right;
            button_NCC_Xoa.BackColor = Color.FromArgb(255, 128, 128);
            button_NCC_Xoa.FlatStyle = FlatStyle.Flat;
            button_NCC_Xoa.Location = new Point(590, 96);
            button_NCC_Xoa.Name = "button_NCC_Xoa";
            button_NCC_Xoa.Size = new Size(158, 40);
            button_NCC_Xoa.TabIndex = 24;
            button_NCC_Xoa.Text = "Xoá";
            button_NCC_Xoa.UseVisualStyleBackColor = false;
            button_NCC_Xoa.Click += Button_NCC_Xoa_Click;
            // 
            // Form_Settings
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 653);
            Controls.Add(tabControl_CaiDat);
            Controls.Add(icon_DeleteDB);
            Controls.Add(icon_Luu);
            Controls.Add(label_Settings);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "Form_Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            FormClosing += Form_Settings_FormClosing;
            Load += Form_Settings_Load;
            tabControl_CaiDat.ResumeLayout(false);
            tabPage_QuiDinh.ResumeLayout(false);
            tabPage_QuiDinh.PerformLayout();
            tabPage_TheLoai.ResumeLayout(false);
            tabPage_TheLoai.PerformLayout();
            tabPage_NhaCungCap.ResumeLayout(false);
            tabPage_NhaCungCap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_Settings;
        private TextBox textBox_minNhap;
        private Label label_minNhap;
        private Label label_maxNo;
        private TextBox textBox_maxNo;
        private Label label_maxSLSach;
        private TextBox textBox_maxSLSach;
        private Label label_minSLSach;
        private TextBox textBox_minSLSach;
        private Label label_thuTienVuotNo;
        private CheckBox checkBox_thuTienVuotNo;
        private FontAwesome.Sharp.IconButton icon_Luu;
        private FontAwesome.Sharp.IconButton icon_Reset;
        private FontAwesome.Sharp.IconButton icon_DeleteDB;
        private ListBox listBox_theLoai;
        private Button button_TheLoai_Them;
        private TextBox textBox_TheLoai_Them;
        private Button button_TheLoai_Xoa;
        private TabControl tabControl_CaiDat;
        private TabPage tabPage_QuiDinh;
        private TabPage tabPage_TheLoai;
        private TabPage tabPage_NhaCungCap;
        private ListBox listBox_nhaCungCap;
        private TextBox textBox_NCC_Them;
        private Button button_NCC_Them;
        private Button button_NCC_Xoa;
    }
}
