namespace Show10.Windows {
    public partial class Form_Settings : Form {
        public Form_Settings() {
            InitializeComponent();
            SetTextbox();

            ToolTip tool = new();
            tool.SetToolTip(icon_DeleteDB, "Xoá HẾT TOÀN BỘ cơ sở dữ liệu");
            tool.SetToolTip(icon_Reset, "Đặt lại các thông số về giá trị mặc định");
            tool.SetToolTip(icon_Luu, "Lưu thay đổi các thông số");
        }
        private void Icon_Luu_Click(object sender, EventArgs e) {
            Properties.Settings.Default.minNhap = int.Parse(textBox_minNhap.Text);
            Properties.Settings.Default.maxSLSach = int.Parse(textBox_maxSLSach.Text);
            Properties.Settings.Default.maxNo = double.Parse(textBox_maxNo.Text);
            Properties.Settings.Default.minSLSach = int.Parse(textBox_minSLSach.Text);
            Properties.Settings.Default.thuTienVuotNo = checkBox_thuTienVuotNo.Checked;
            Properties.Settings.Default.Save();
            MessageBox.Show("Lưu thay đổi các thông số thành công !!!",
                "Lưu thay đổi các thông số thành công !!!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

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
            var result = MessageBox.Show(
                "CẢNH BÁO!!!\n\n" +
                "Thao tác này sẽ xoá hết TOÀN BỘ dữ liệu!!!\n(trừ thông tin tài khoản)\n\n" +
                "Bạn sẽ không thể khôi phục lại được dữ liệu!!!\n\n" +
                "Bạn có thực sự muốn xoá???",
                "Xoá cơ sở dữ liệu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                NhaSachContext db = new();

                db.Sachs.RemoveRange(db.Sachs);
                db.PhieuNhapSachs.RemoveRange(db.PhieuNhapSachs);
                db.HoaDonBanSachs.RemoveRange(db.HoaDonBanSachs);

                db.KhachHangs.RemoveRange(db.KhachHangs);
                db.PhieuThuTiens.RemoveRange(db.PhieuThuTiens);

                db.BaoCaoTons.RemoveRange(db.BaoCaoTons);
                db.BaoCaoNos.RemoveRange(db.BaoCaoNos);

                db.SaveChanges();

                MessageBox.Show(
                    "Xoá hết toàn bộ (trừ thông tin tài khoản) cơ sở dữ liệu thành công !!!",
                    "Xoá cơ sở dữ liệu thành công !!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
