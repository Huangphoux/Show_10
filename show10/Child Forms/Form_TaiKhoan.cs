using Microsoft.EntityFrameworkCore;
using Show10.Data_Access;
using System.Windows.Media;
using static System.Net.Mime.MediaTypeNames;
using Color = System.Drawing.Color;

namespace Show10.Child_Forms {
    public partial class Form_TaiKhoan : Form {
        private TaiKhoanContext? db;

        public Form_TaiKhoan() {
            InitializeComponent();
        }

        private void Form_Account_FormClosing(object sender, FormClosingEventArgs e) {
            db?.Dispose();
            db = null;
        }

        private void Form_Account_Load(object sender, EventArgs e) {
            db = new TaiKhoanContext();

            // Dòng dưới sẽ luôn xoá DB mỗi khi chạy chương trình
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.TaiKhoans.Load();

            taiKhoanBindingSource.DataSource = db.TaiKhoans.Local.ToBindingList();

            dataGridView_TaiKhoan.Refresh();
        }

        private void CheckBox_TK_TimKiem_CheckedChanged(object sender, EventArgs e) {
            icon_TK_Them.Enabled = !checkBox_TK_TimKiem.Checked;
            icon_TK_Xoa.Enabled = !checkBox_TK_TimKiem.Checked;
        }

        private void Icon_TK_Them_Click(object sender, EventArgs e) {
            string tenTK = textBox_TK_TenTK.Text;
            string matKhau = textBox_TK_MatKhau.Text;
            string hoTen = textBox_TK_HoTen.Text;
            string vaiTro = checkBox_TK_QTV.Checked ? "admin" : "user";

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(hoTen)) {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên tài khoản, mật khẩu và họ tên trước khi thêm vào cơ sở dữ liệu.\n" +
                    "Mặc định tài khoản không đánh vào ô \"Là quản trị viên\" sẽ thành tài khoản người dùng.",
                    "Chưa điền tên tài khoản hoặc mật khẩu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (db.TaiKhoans.Any(tk => tk.TenTK == tenTK)) {
                _ = MessageBox.Show("Tên tài khoản này đã được sử dụng.\n" +
                    "Vui lòng sử dụng tên tài khoản khác.",
                    "Trùng lặp tên tài khoản",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            } else {
                _ = db.Add(new TaiKhoan { TenTK = tenTK, MatKhau = matKhau, VaiTro = vaiTro, HoTen = hoTen });
                _ = db.SaveChanges();
                dataGridView_TaiKhoan.Refresh();
            }
        }
    }
}
