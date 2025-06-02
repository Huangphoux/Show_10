using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Show10.Windows {
    public partial class Form_Settings : Form {
        public Form_Settings() {
            InitializeComponent();
            SetTextbox();
        }

        private void Icon_Luu_Click(object sender, EventArgs e) {
            Properties.Settings.Default.minNhap = int.Parse(textBox_minNhap.Text);
            Properties.Settings.Default.maxSLSach = int.Parse(textBox_maxSLSach.Text);
            Properties.Settings.Default.maxNo = double.Parse(textBox_maxNo.Text);
            Properties.Settings.Default.minSLSach = int.Parse(textBox_minSLSach.Text);
            Properties.Settings.Default.thuTienVuotNo = checkBox_thuTienVuotNo.Checked;
            Properties.Settings.Default.Save();
            MessageBox.Show("Lưu thành công !", "Lưu thành công !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void Icon_Reset_Click(object sender, EventArgs e) {
            Properties.Settings.Default.minNhap = 150;
            Properties.Settings.Default.maxSLSach = 300;
            Properties.Settings.Default.maxNo = 1000000;
            Properties.Settings.Default.minSLSach = 20;
            Properties.Settings.Default.thuTienVuotNo = false;
            Properties.Settings.Default.Save();
            SetTextbox();
        }

        private void SetTextbox() {
            textBox_minNhap.Text = Properties.Settings.Default.minNhap.ToString();
            textBox_maxSLSach.Text = Properties.Settings.Default.maxSLSach.ToString();
            textBox_maxNo.Text = Properties.Settings.Default.maxNo.ToString();
            textBox_minSLSach.Text = Properties.Settings.Default.minSLSach.ToString();
            checkBox_thuTienVuotNo.Checked = Properties.Settings.Default.thuTienVuotNo;
        }

        private void Icon_DeleteDB_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Bạn muốn xoá TOÀN BỘ dữ liệu?\n" +
                "(CẢNH BÁO: Sẽ không thể phục hổi được dữ liệu !)",
                "Xoá cơ sở dữ liệu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes) {
                NhaSachContext db = new();

                db.TaiKhoans.RemoveRange(db.TaiKhoans);
                db.Sachs.RemoveRange(db.Sachs);
                db.KhachHangs.RemoveRange(db.KhachHangs);
                db.PhieuThuTiens.RemoveRange(db.PhieuThuTiens);
                db.PhieuNhapSachs.RemoveRange(db.PhieuNhapSachs);
                db.HoaDonBanSachs.RemoveRange(db.HoaDonBanSachs);
                db.BaoCaoTons.RemoveRange(db.BaoCaoTons);
                db.BaoCaoNos.RemoveRange(db.BaoCaoNos);

                db.SaveChanges();
            }
        }
    }
}
