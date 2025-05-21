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
        private void InitializeComponent()
        {
            label_Settings = new Label();
            textBox_minNhap = new TextBox();
            label_minNhap = new Label();
            label_maxNo = new Label();
            textBox_maxNo = new TextBox();
            label_maxSLSach = new Label();
            textBox_maxSLSach = new TextBox();
            label_minSLSach = new Label();
            textBox_minSLSach = new TextBox();
            button_Save = new Button();
            SuspendLayout();
            // 
            // label_Settings
            // 
            label_Settings.Dock = DockStyle.Top;
            label_Settings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Settings.Location = new Point(0, 0);
            label_Settings.Name = "label_Settings";
            label_Settings.Size = new Size(800, 28);
            label_Settings.TabIndex = 0;
            label_Settings.Text = "Cài đặt";
            label_Settings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_minNhap
            // 
            textBox_minNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_minNhap.Location = new Point(158, 47);
            textBox_minNhap.Name = "textBox_minNhap";
            textBox_minNhap.Size = new Size(125, 34);
            textBox_minNhap.TabIndex = 1;
            textBox_minNhap.TextChanged += textBox_minNhap_TextChanged;
            // 
            // label_minNhap
            // 
            label_minNhap.AutoSize = true;
            label_minNhap.Location = new Point(15, 57);
            label_minNhap.Name = "label_minNhap";
            label_minNhap.Size = new Size(140, 20);
            label_minNhap.TabIndex = 2;
            label_minNhap.Text = "Lượng tồn tối thiểu ";
            // 
            // label_maxNo
            // 
            label_maxNo.AutoSize = true;
            label_maxNo.Location = new Point(15, 97);
            label_maxNo.Name = "label_maxNo";
            label_maxNo.Size = new Size(101, 20);
            label_maxNo.TabIndex = 4;
            label_maxNo.Text = "Tiền nợ tối đa";
            // 
            // textBox_maxNo
            // 
            textBox_maxNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_maxNo.Location = new Point(158, 87);
            textBox_maxNo.Name = "textBox_maxNo";
            textBox_maxNo.Size = new Size(125, 34);
            textBox_maxNo.TabIndex = 3;
            // 
            // label_maxSLSach
            // 
            label_maxSLSach.AutoSize = true;
            label_maxSLSach.Location = new Point(15, 137);
            label_maxSLSach.Name = "label_maxSLSach";
            label_maxSLSach.Size = new Size(100, 20);
            label_maxSLSach.TabIndex = 6;
            label_maxSLSach.Text = "SL sách tối đa";
            // 
            // textBox_maxSLSach
            // 
            textBox_maxSLSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_maxSLSach.Location = new Point(158, 127);
            textBox_maxSLSach.Name = "textBox_maxSLSach";
            textBox_maxSLSach.Size = new Size(125, 34);
            textBox_maxSLSach.TabIndex = 5;
            // 
            // label_minSLSach
            // 
            label_minSLSach.AutoSize = true;
            label_minSLSach.Location = new Point(15, 177);
            label_minSLSach.Name = "label_minSLSach";
            label_minSLSach.Size = new Size(116, 20);
            label_minSLSach.TabIndex = 8;
            label_minSLSach.Text = "SL sách tối thiểu";
            // 
            // textBox_minSLSach
            // 
            textBox_minSLSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_minSLSach.Location = new Point(158, 167);
            textBox_minSLSach.Name = "textBox_minSLSach";
            textBox_minSLSach.Size = new Size(125, 34);
            textBox_minSLSach.TabIndex = 7;
            // 
            // button_Save
            // 
            button_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Save.Location = new Point(623, 367);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(106, 33);
            button_Save.TabIndex = 9;
            button_Save.Text = "Lưu";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button1_Click;
            // 
            // Form_Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Save);
            Controls.Add(label_minSLSach);
            Controls.Add(textBox_minSLSach);
            Controls.Add(label_maxSLSach);
            Controls.Add(textBox_maxSLSach);
            Controls.Add(label_maxNo);
            Controls.Add(textBox_maxNo);
            Controls.Add(label_minNhap);
            Controls.Add(textBox_minNhap);
            Controls.Add(label_Settings);
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
        private Button button_Save;
    }
}