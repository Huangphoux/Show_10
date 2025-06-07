namespace Show10.Windows {
    partial class Form_DangNhap {
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
            panel_DangNhap = new Panel();
            panel_DangNhap_Phai = new Panel();
            icon_ShowPass = new FontAwesome.Sharp.IconPictureBox();
            label_DangNhap = new Label();
            label_TenTK = new Label();
            checkBox_enableTab = new CheckBox();
            label_ChaoDon = new Label();
            icon_DangKy = new FontAwesome.Sharp.IconButton();
            label_MatKhau = new Label();
            textBox_MatKhau = new TextBox();
            textBox_TenTK = new TextBox();
            icon_DangNhap = new FontAwesome.Sharp.IconButton();
            panel_Welcome = new Panel();
            label_Clock = new Label();
            label_Welcome = new Label();
            timer_Clock = new System.Windows.Forms.Timer(components);
            panel_DangNhap_Phai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_ShowPass).BeginInit();
            panel_Welcome.SuspendLayout();
            SuspendLayout();
            // 
            // panel_DangNhap
            // 
            panel_DangNhap.BackColor = Color.DarkGreen;
            panel_DangNhap.Dock = DockStyle.Fill;
            panel_DangNhap.Location = new Point(0, 0);
            panel_DangNhap.Name = "panel_DangNhap";
            panel_DangNhap.Size = new Size(1262, 853);
            panel_DangNhap.TabIndex = 11;
            // 
            // panel_DangNhap_Phai
            // 
            panel_DangNhap_Phai.Anchor = AnchorStyles.None;
            panel_DangNhap_Phai.BackColor = Color.White;
            panel_DangNhap_Phai.Controls.Add(icon_ShowPass);
            panel_DangNhap_Phai.Controls.Add(label_DangNhap);
            panel_DangNhap_Phai.Controls.Add(label_TenTK);
            panel_DangNhap_Phai.Controls.Add(checkBox_enableTab);
            panel_DangNhap_Phai.Controls.Add(label_ChaoDon);
            panel_DangNhap_Phai.Controls.Add(icon_DangKy);
            panel_DangNhap_Phai.Controls.Add(label_MatKhau);
            panel_DangNhap_Phai.Controls.Add(textBox_MatKhau);
            panel_DangNhap_Phai.Controls.Add(textBox_TenTK);
            panel_DangNhap_Phai.Controls.Add(icon_DangNhap);
            panel_DangNhap_Phai.Location = new Point(336, 90);
            panel_DangNhap_Phai.Name = "panel_DangNhap_Phai";
            panel_DangNhap_Phai.Size = new Size(591, 673);
            panel_DangNhap_Phai.TabIndex = 0;
            // 
            // icon_ShowPass
            // 
            icon_ShowPass.BackColor = Color.White;
            icon_ShowPass.ForeColor = Color.Green;
            icon_ShowPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            icon_ShowPass.IconColor = Color.Green;
            icon_ShowPass.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_ShowPass.IconSize = 40;
            icon_ShowPass.Location = new Point(486, 309);
            icon_ShowPass.Name = "icon_ShowPass";
            icon_ShowPass.Size = new Size(40, 40);
            icon_ShowPass.TabIndex = 13;
            icon_ShowPass.TabStop = false;
            icon_ShowPass.Click += Icon_ShowPass_Click;
            // 
            // label_DangNhap
            // 
            label_DangNhap.Dock = DockStyle.Top;
            label_DangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DangNhap.ForeColor = Color.Green;
            label_DangNhap.Location = new Point(0, 128);
            label_DangNhap.Name = "label_DangNhap";
            label_DangNhap.Size = new Size(591, 116);
            label_DangNhap.TabIndex = 1;
            label_DangNhap.Text = "Vui lòng đăng nhập trước khi truy cập hệ thống.";
            label_DangNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_TenTK
            // 
            label_TenTK.Location = new Point(65, 241);
            label_TenTK.Margin = new Padding(3, 0, 20, 0);
            label_TenTK.Name = "label_TenTK";
            label_TenTK.Size = new Size(132, 40);
            label_TenTK.TabIndex = 2;
            label_TenTK.Text = "Tên tài khoản";
            label_TenTK.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBox_enableTab
            // 
            checkBox_enableTab.Appearance = Appearance.Button;
            checkBox_enableTab.Dock = DockStyle.Bottom;
            checkBox_enableTab.FlatAppearance.BorderColor = Color.Black;
            checkBox_enableTab.FlatAppearance.BorderSize = 0;
            checkBox_enableTab.FlatStyle = FlatStyle.Flat;
            checkBox_enableTab.ForeColor = Color.White;
            checkBox_enableTab.Location = new Point(0, 582);
            checkBox_enableTab.Name = "checkBox_enableTab";
            checkBox_enableTab.Size = new Size(591, 91);
            checkBox_enableTab.TabIndex = 10;
            checkBox_enableTab.Text = "Bật các tab";
            checkBox_enableTab.TextAlign = ContentAlignment.MiddleCenter;
            checkBox_enableTab.UseVisualStyleBackColor = true;
            checkBox_enableTab.CheckedChanged += CheckBox_enableTab_CheckedChanged;
            // 
            // label_ChaoDon
            // 
            label_ChaoDon.AccessibleRole = AccessibleRole.None;
            label_ChaoDon.BackColor = Color.Green;
            label_ChaoDon.Dock = DockStyle.Top;
            label_ChaoDon.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ChaoDon.ForeColor = Color.White;
            label_ChaoDon.Location = new Point(0, 0);
            label_ChaoDon.Name = "label_ChaoDon";
            label_ChaoDon.Size = new Size(591, 128);
            label_ChaoDon.TabIndex = 0;
            label_ChaoDon.Text = "Xin được chào đón !";
            label_ChaoDon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // icon_DangKy
            // 
            icon_DangKy.Anchor = AnchorStyles.Top;
            icon_DangKy.BackColor = Color.Transparent;
            icon_DangKy.FlatStyle = FlatStyle.Flat;
            icon_DangKy.ForeColor = Color.Green;
            icon_DangKy.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            icon_DangKy.IconColor = Color.Green;
            icon_DangKy.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_DangKy.IconSize = 30;
            icon_DangKy.Location = new Point(307, 381);
            icon_DangKy.Name = "icon_DangKy";
            icon_DangKy.Size = new Size(200, 80);
            icon_DangKy.TabIndex = 7;
            icon_DangKy.Text = "Đăng ký";
            icon_DangKy.TextAlign = ContentAlignment.MiddleRight;
            icon_DangKy.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_DangKy.UseVisualStyleBackColor = false;
            icon_DangKy.Click += Icon_DangKy_Click;
            // 
            // label_MatKhau
            // 
            label_MatKhau.Location = new Point(65, 309);
            label_MatKhau.Margin = new Padding(3, 0, 20, 0);
            label_MatKhau.Name = "label_MatKhau";
            label_MatKhau.Size = new Size(132, 40);
            label_MatKhau.TabIndex = 4;
            label_MatKhau.Text = "Mật khẩu";
            label_MatKhau.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_MatKhau.BorderStyle = BorderStyle.FixedSingle;
            textBox_MatKhau.Font = new Font("Segoe UI", 12F);
            textBox_MatKhau.Location = new Point(200, 312);
            textBox_MatKhau.MaxLength = 500;
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.PasswordChar = '•';
            textBox_MatKhau.Size = new Size(280, 34);
            textBox_MatKhau.TabIndex = 5;
            textBox_MatKhau.WordWrap = false;
            // 
            // textBox_TenTK
            // 
            textBox_TenTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_TenTK.BorderStyle = BorderStyle.FixedSingle;
            textBox_TenTK.Font = new Font("Segoe UI", 12F);
            textBox_TenTK.Location = new Point(200, 247);
            textBox_TenTK.MaxLength = 500;
            textBox_TenTK.Name = "textBox_TenTK";
            textBox_TenTK.Size = new Size(280, 34);
            textBox_TenTK.TabIndex = 3;
            textBox_TenTK.WordWrap = false;
            // 
            // icon_DangNhap
            // 
            icon_DangNhap.Anchor = AnchorStyles.Top;
            icon_DangNhap.BackColor = Color.Green;
            icon_DangNhap.FlatAppearance.BorderSize = 0;
            icon_DangNhap.FlatStyle = FlatStyle.Flat;
            icon_DangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icon_DangNhap.ForeColor = Color.White;
            icon_DangNhap.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            icon_DangNhap.IconColor = Color.White;
            icon_DangNhap.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icon_DangNhap.IconSize = 30;
            icon_DangNhap.Location = new Point(83, 381);
            icon_DangNhap.Name = "icon_DangNhap";
            icon_DangNhap.Size = new Size(200, 80);
            icon_DangNhap.TabIndex = 6;
            icon_DangNhap.Text = "Đăng nhập";
            icon_DangNhap.TextAlign = ContentAlignment.MiddleRight;
            icon_DangNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            icon_DangNhap.UseVisualStyleBackColor = false;
            icon_DangNhap.Click += Icon_DangNhap_Click;
            // 
            // panel_Welcome
            // 
            panel_Welcome.BackColor = Color.DarkGreen;
            panel_Welcome.Controls.Add(label_Clock);
            panel_Welcome.Controls.Add(label_Welcome);
            panel_Welcome.Dock = DockStyle.Fill;
            panel_Welcome.Location = new Point(0, 0);
            panel_Welcome.Name = "panel_Welcome";
            panel_Welcome.Size = new Size(1262, 853);
            panel_Welcome.TabIndex = 10;
            // 
            // label_Clock
            // 
            label_Clock.Anchor = AnchorStyles.None;
            label_Clock.BackColor = Color.Green;
            label_Clock.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_Clock.ForeColor = Color.White;
            label_Clock.Location = new Point(397, 211);
            label_Clock.Name = "label_Clock";
            label_Clock.Size = new Size(468, 104);
            label_Clock.TabIndex = 1;
            label_Clock.Text = "Bây giờ là mấy giờ?";
            label_Clock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Welcome
            // 
            label_Welcome.Anchor = AnchorStyles.None;
            label_Welcome.BackColor = Color.Green;
            label_Welcome.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Welcome.ForeColor = Color.White;
            label_Welcome.Location = new Point(397, 385);
            label_Welcome.Name = "label_Welcome";
            label_Welcome.Size = new Size(468, 257);
            label_Welcome.TabIndex = 0;
            label_Welcome.Text = "Xin chào!";
            label_Welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer_Clock
            // 
            timer_Clock.Enabled = true;
            timer_Clock.Interval = 1000;
            timer_Clock.Tick += Timer_Clock_Tick;
            // 
            // Form_DangNhap
            // 
            AcceptButton = icon_DangNhap;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 853);
            Controls.Add(panel_Welcome);
            Controls.Add(panel_DangNhap_Phai);
            Controls.Add(panel_DangNhap);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form_DangNhap";
            Text = "Form_DangNhap";
            FormClosing += Form_DangNhap_FormClosing;
            Load += Form_DangNhap_Load;
            panel_DangNhap_Phai.ResumeLayout(false);
            panel_DangNhap_Phai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon_ShowPass).EndInit();
            panel_Welcome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_DangNhap;
        private Panel panel_DangNhap_Phai;
        private FontAwesome.Sharp.IconPictureBox icon_ShowPass;
        private Label label_DangNhap;
        private Label label_TenTK;
        private CheckBox checkBox_enableTab;
        private Label label_ChaoDon;
        private FontAwesome.Sharp.IconButton icon_DangKy;
        private Label label_MatKhau;
        private TextBox textBox_MatKhau;
        private TextBox textBox_TenTK;
        private FontAwesome.Sharp.IconButton icon_DangNhap;
        private Panel panel_Welcome;
        private Label label_Clock;
        private Label label_Welcome;
        private System.Windows.Forms.Timer timer_Clock;
    }
}