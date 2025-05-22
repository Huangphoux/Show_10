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
            setTextbox();
        }

        private void Icon_Luu_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.minNhap = int.Parse(textBox_minNhap.Text);
            Properties.Settings.Default.maxSLSach = int.Parse(textBox_maxSLSach.Text);
            Properties.Settings.Default.maxNo = double.Parse(textBox_maxNo.Text);
            Properties.Settings.Default.minSLSach = int.Parse(textBox_minSLSach.Text);
            Properties.Settings.Default.thuTienVuotNo = checkBox_thuTienVuotNo.Checked;
            Properties.Settings.Default.Save();
            MessageBox.Show("Lưu thành công !", "Lưu thành công !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void icon_Reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.minNhap = 150;
            Properties.Settings.Default.maxSLSach = 300;
            Properties.Settings.Default.maxNo = 1000000;
            Properties.Settings.Default.minSLSach = 20;
            Properties.Settings.Default.thuTienVuotNo = false;
            Properties.Settings.Default.Save();
            setTextbox();
        }

        private void setTextbox()
        {
            textBox_minNhap.Text = Properties.Settings.Default.minNhap.ToString();
            textBox_maxSLSach.Text = Properties.Settings.Default.maxSLSach.ToString();
            textBox_maxNo.Text = Properties.Settings.Default.maxNo.ToString();
            textBox_minSLSach.Text = Properties.Settings.Default.minSLSach.ToString();
            checkBox_thuTienVuotNo.Checked = Properties.Settings.Default.thuTienVuotNo;
        }
    }
}
