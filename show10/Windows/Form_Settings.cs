using System.ComponentModel;

namespace Show10.Windows {
    public partial class Form_Settings : Form {
        BindingList<string> theLoai = new(Properties.Settings.Default.theLoai.Split(',').ToList());
        BindingList<string> nhaCungCap = new(Properties.Settings.Default.nhaCungCap.Split(',').ToList());

        public Form_Settings() {
            InitializeComponent();
            SetTextbox();

            ToolTip tool = new();
            tool.SetToolTip(icon_DeleteDB, "Xoá HẾT TOÀN BỘ cơ sở dữ liệu");
            tool.SetToolTip(icon_Reset, "Đặt lại các thông số về giá trị mặc định");
            tool.SetToolTip(icon_Luu, "Lưu thay đổi các thông số");

            listBox_theLoai.DataSource = theLoai;
            listBox_nhaCungCap.DataSource = nhaCungCap;
        }
        private void Icon_Luu_Click(object sender, EventArgs e) {
            Properties.Settings.Default.minNhap = int.Parse(textBox_minNhap.Text);
            Properties.Settings.Default.maxSLSach = int.Parse(textBox_maxSLSach.Text);
            Properties.Settings.Default.maxNo = double.Parse(textBox_maxNo.Text);
            Properties.Settings.Default.minSLSach = int.Parse(textBox_minSLSach.Text);
            Properties.Settings.Default.thuTienVuotNo = checkBox_thuTienVuotNo.Checked;

            Properties.Settings.Default.theLoai = String.Join(",", theLoai);
            Properties.Settings.Default.nhaCungCap = String.Join(",", nhaCungCap);

            Properties.Settings.Default.Save();

            MessageBox.Show("Các thông số đã được lưu vào cài đặt một cách mĩ mãn.",
                "Lưu thay đổi các thông số thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void Icon_Reset_Click(object sender, EventArgs e) {
            Properties.Settings.Default.Reset();

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
                    "Đã xoá toàn bộ cơ sở dữ liệu thành công (trừ thông tin tài khoản).\n" +
                    "Tiến hành khởi động lại chương trình.",
                    "Xoá cơ sở dữ liệu thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Restart();
            }
        }

        private void Form_Settings_FormClosing(object sender, FormClosingEventArgs e) {
            var result = MessageBox.Show("Các thông số sẽ không được lưu nếu bạn tắt cửa sổ này.\n" +
                "Lưu các thông số?", "Chưa lưu các thông số", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                Icon_Luu_Click(sender, e);
            } else if (result == DialogResult.Cancel) {
                e.Cancel = true;
            }
        }

        private void Button_TheLoai_Them_Click(object sender, EventArgs e) {
            theLoai.Add(textBox_TheLoai_Them.Text.Trim());

            textBox_TheLoai_Them.Text = "";
            listBox_theLoai.Refresh();
        }

        private void Button_TheLoai_Xoa_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Bạn muốn xoá thể loại sách này?",
                "Trước khi xoá thể loại sách", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                theLoai.RemoveAt(listBox_theLoai.SelectedIndex);
            }
        }

        private void Button_NCC_Them_Click(object sender, EventArgs e) {
            nhaCungCap.Add(textBox_TheLoai_Them.Text.Trim());

            textBox_NCC_Them.Text = "";
            listBox_nhaCungCap.Refresh();
        }

        private void Button_NCC_Xoa_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Bạn muốn xoá nhà cung cấp này?",
                "Trước khi xoá nhà cung cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                nhaCungCap.RemoveAt(listBox_nhaCungCap.SelectedIndex);
            }
        }
    }
}
