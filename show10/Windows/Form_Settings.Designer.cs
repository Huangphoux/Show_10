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
            textBox_minNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_minNhap.Location = new Point(442, 86);
            textBox_minNhap.Margin = new Padding(4);
            textBox_minNhap.Name = "textBox_minNhap";
            textBox_minNhap.Size = new Size(312, 34);
            textBox_minNhap.TabIndex = 1;
            // 
            // label_minNhap
            // 
            label_minNhap.AutoSize = true;
            label_minNhap.Location = new Point(21, 89);
            label_minNhap.Margin = new Padding(4, 0, 4, 0);
            label_minNhap.Name = "label_minNhap";
            label_minNhap.Size = new Size(267, 28);
            label_minNhap.TabIndex = 2;
            label_minNhap.Text = "Số lượng nhập sách tối thiểu ";
            // 
            // label_maxNo
            // 
            label_maxNo.AutoSize = true;
            label_maxNo.Location = new Point(21, 145);
            label_maxNo.Margin = new Padding(4, 0, 4, 0);
            label_maxNo.Name = "label_maxNo";
            label_maxNo.Size = new Size(132, 28);
            label_maxNo.TabIndex = 4;
            label_maxNo.Text = "Tiền nợ tối đa";
            // 
            // textBox_maxNo
            // 
            textBox_maxNo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_maxNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_maxNo.Location = new Point(442, 142);
            textBox_maxNo.Margin = new Padding(4);
            textBox_maxNo.Name = "textBox_maxNo";
            textBox_maxNo.Size = new Size(312, 34);
            textBox_maxNo.TabIndex = 3;
            // 
            // label_maxSLSach
            // 
            label_maxSLSach.AutoSize = true;
            label_maxSLSach.Location = new Point(21, 201);
            label_maxSLSach.Margin = new Padding(4, 0, 4, 0);
            label_maxSLSach.Name = "label_maxSLSach";
            label_maxSLSach.Size = new Size(396, 28);
            label_maxSLSach.TabIndex = 6;
            label_maxSLSach.Text = "Số lượng sách tồn kho tối đa trước khi nhập";
            // 
            // textBox_maxSLSach
            // 
            textBox_maxSLSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_maxSLSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_maxSLSach.Location = new Point(442, 198);
            textBox_maxSLSach.Margin = new Padding(4);
            textBox_maxSLSach.Name = "textBox_maxSLSach";
            textBox_maxSLSach.Size = new Size(312, 34);
            textBox_maxSLSach.TabIndex = 5;
            // 
            // label_minSLSach
            // 
            label_minSLSach.AutoSize = true;
            label_minSLSach.Location = new Point(21, 257);
            label_minSLSach.Margin = new Padding(4, 0, 4, 0);
            label_minSLSach.Name = "label_minSLSach";
            label_minSLSach.Size = new Size(346, 28);
            label_minSLSach.TabIndex = 8;
            label_minSLSach.Text = "Số lượng tồn kho tối thiểu sau khi bán";
            // 
            // textBox_minSLSach
            // 
            textBox_minSLSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_minSLSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_minSLSach.Location = new Point(442, 254);
            textBox_minSLSach.Margin = new Padding(4);
            textBox_minSLSach.Name = "textBox_minSLSach";
            textBox_minSLSach.Size = new Size(312, 34);
            textBox_minSLSach.TabIndex = 7;
            // 
            // label_thuTienVuotNo
            // 
            label_thuTienVuotNo.AutoSize = true;
            label_thuTienVuotNo.Location = new Point(21, 313);
            label_thuTienVuotNo.Margin = new Padding(4, 0, 4, 0);
            label_thuTienVuotNo.Name = "label_thuTienVuotNo";
            label_thuTienVuotNo.Size = new Size(340, 28);
            label_thuTienVuotNo.TabIndex = 11;
            label_thuTienVuotNo.Text = "Có thể thu vượt tiền nợ được không ?";
            // 
            // checkBox_thuTienVuotNo
            // 
            checkBox_thuTienVuotNo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBox_thuTienVuotNo.Location = new Point(442, 313);
            checkBox_thuTienVuotNo.Margin = new Padding(4);
            checkBox_thuTienVuotNo.Name = "checkBox_thuTienVuotNo";
            checkBox_thuTienVuotNo.Size = new Size(312, 37);
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
            icon_Luu.Location = new Point(684, 388);
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
            icon_Reset.Location = new Point(596, 388);
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
            icon_DeleteDB.Location = new Point(21, 388);
            icon_DeleteDB.Name = "icon_DeleteDB";
            icon_DeleteDB.Padding = new Padding(10);
            icon_DeleteDB.Size = new Size(70, 70);
            icon_DeleteDB.TabIndex = 15;
            icon_DeleteDB.UseVisualStyleBackColor = false;
            icon_DeleteDB.Click += Icon_DeleteDB_Click;
            // 
            // Form_Settings
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 470);
            Controls.Add(icon_DeleteDB);
            Controls.Add(icon_Reset);
            Controls.Add(icon_Luu);
            Controls.Add(checkBox_thuTienVuotNo);
            Controls.Add(label_thuTienVuotNo);
            Controls.Add(label_minSLSach);
            Controls.Add(textBox_minSLSach);
            Controls.Add(label_maxSLSach);
            Controls.Add(textBox_maxSLSach);
            Controls.Add(label_maxNo);
            Controls.Add(textBox_maxNo);
            Controls.Add(label_minNhap);
            Controls.Add(textBox_minNhap);
            Controls.Add(label_Settings);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form_Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
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
    }
}