namespace show10
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer_Clock = new System.Windows.Forms.Timer(components);
            label_Clock = new Label();
            icon_Fullscreen = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)icon_Fullscreen).BeginInit();
            SuspendLayout();
            // 
            // timer_Clock
            // 
            timer_Clock.Enabled = true;
            timer_Clock.Interval = 1000;
            timer_Clock.Tick += Timer_Tick;
            // 
            // label_Clock
            // 
            label_Clock.Location = new Point(80, 200);
            label_Clock.Name = "label_Clock";
            label_Clock.Size = new Size(200, 80);
            label_Clock.TabIndex = 0;
            label_Clock.Text = "(Số giờ sử dụng)";
            label_Clock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // icon_Fullscreen
            // 
            icon_Fullscreen.Anchor = AnchorStyles.Right;
            icon_Fullscreen.BackColor = SystemColors.Control;
            icon_Fullscreen.ForeColor = SystemColors.ControlText;
            icon_Fullscreen.IconChar = FontAwesome.Sharp.IconChar.Expand;
            icon_Fullscreen.IconColor = SystemColors.ControlText;
            icon_Fullscreen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_Fullscreen.IconSize = 40;
            icon_Fullscreen.Location = new Point(1080, 40);
            icon_Fullscreen.Name = "icon_Fullscreen";
            icon_Fullscreen.Size = new Size(40, 40);
            icon_Fullscreen.TabIndex = 1;
            icon_Fullscreen.TabStop = false;
            icon_Fullscreen.Click += Icon_Fullscreen_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 673);
            Controls.Add(icon_Fullscreen);
            Controls.Add(label_Clock);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show 10 !";
            Resize += MainWindow_Resize;
            ((System.ComponentModel.ISupportInitialize)icon_Fullscreen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer_Clock;
        private Label label_Clock;
        private FontAwesome.Sharp.IconPictureBox icon_Fullscreen;
    }
}
