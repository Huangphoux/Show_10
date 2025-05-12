namespace Show10.Child_Forms {
    partial class Form_Sach {
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
            groupBox_Sach = new GroupBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Sach
            // 
            groupBox_Sach.Dock = DockStyle.Top;
            groupBox_Sach.Location = new Point(0, 0);
            groupBox_Sach.Name = "groupBox_Sach";
            groupBox_Sach.Size = new Size(782, 355);
            groupBox_Sach.TabIndex = 0;
            groupBox_Sach.TabStop = false;
            groupBox_Sach.Text = "Nhập liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(163, 398);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 1;
            // 
            // Form_Sach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox_Sach);
            Name = "Form_Sach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sách";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Sach;
        private DataGridView dataGridView1;
    }
}