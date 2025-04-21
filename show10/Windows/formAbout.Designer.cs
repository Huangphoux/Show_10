namespace Show10.Windows
{
    partial class formAbout
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
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(331, 182);
            label2.Name = "label2";
            label2.Size = new Size(108, 35);
            label2.TabIndex = 1;
            label2.Text = "About";
            // 
            // formAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formAbout";
            Text = "Form1";
            Load += formAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
    }
}