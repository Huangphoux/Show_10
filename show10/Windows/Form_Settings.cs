using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Show10.Windows
{
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            InitializeComponent();
            textBox_minNhap.Text = Properties.Settings.Default.minNhap;
            textBox_maxSLSach.Text = Properties.Settings.Default.maxSLSach;
            textBox_maxNo.Text = Properties.Settings.Default.maxNo;
            textBox_minSLSach.Text = Properties.Settings.Default.minSLSach;
            checkBox_thuTienVuotNo.Checked = Properties.Settings.Default.thuTienVuotNo;
        }

        private void Icon_Luu_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.minNhap = textBox_minNhap.Text;
            Properties.Settings.Default.maxSLSach = textBox_maxSLSach.Text;
            Properties.Settings.Default.maxNo = textBox_maxNo.Text;
            Properties.Settings.Default.minSLSach = textBox_minSLSach.Text;
            Properties.Settings.Default.thuTienVuotNo = checkBox_thuTienVuotNo.Checked;
            Properties.Settings.Default.Save();
            MessageBox.Show("Lưu thành công !", "Lưu thành công !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

    }
}
