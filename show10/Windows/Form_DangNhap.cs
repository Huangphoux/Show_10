using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Show10.Models;


namespace Show10.Windows {
    public partial class Form_DangNhap : Form {
        private NhaSachContext? db;
        private readonly List<IconButton> iconTab;

        public Form_DangNhap(List<IconButton> iconTab) {
            InitializeComponent();
            this.iconTab = iconTab;
        }
        private void Form_DangNhap_Load(object sender, EventArgs e) {
            panel_DangNhap.BringToFront();
            panel_DangNhap_Phai.BringToFront();

            db = new NhaSachContext();

            //Comment dòng dưới để không tạo lại DB mỗi khi chạy chương trình
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.TaiKhoans.Load();
        }
        private void Form_DangNhap_FormClosing(object sender, FormClosingEventArgs e) {
            db?.Dispose();
            db = null;
        }
        private void Timer_Clock_Tick(object sender, EventArgs e) {
            label_Clock.Text = "Bây giờ là " + DateTime.Now.ToString("t");
        }
        private static string GetGreetings() {
            var chaoHoi = "Xin chào";
            var hour = DateTime.Now.Hour;

            if (hour >= 0 && hour < 12) {
                chaoHoi = "Chào buổi sáng ☀️";
            } else if (hour >= 12 && hour < 18) {
                chaoHoi = "Chào buổi chiều ☀️";
            } else if (hour >= 18) {
                chaoHoi = "Chào buổi tối 🌙";
            }
            return chaoHoi;
        }
        private void Icon_DangNhap_Click(object sender, EventArgs e) {
            string tenTK = textBox_TenTK.Text;
            string matKhau = textBox_MatKhau.Text;

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau)) {
                MessageBox.Show(
                    "Nhập đủ tên tài khoản và mật khẩu trước khi đăng nhập.",
                    "Cần nhập đầy đủ tên tài khoản hoặc mật khẩu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!db!.TaiKhoans.Any(tk => tk.TenTK == tenTK && tk.MatKhau == matKhau)) {
                MessageBox.Show(
                    "Không tìm thấy tài khoản.\n" +
                    "Kiểm tra tên tài khoản và mật khẩu đúng như đã đăng ký.",
                    "Không tìm thấy tài khoản",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                return;
            }

            var found = db.TaiKhoans.First(tk => tk.TenTK == tenTK);

            if (found.VaiTro == "admin") {
                iconTab.ForEach(tab => tab.Enabled = true);
            }

            if (found.VaiTro == "staff") {
                iconTab.ForEach(tab => tab.Enabled = true);
                iconTab[1].Enabled = false;
                iconTab[5].Enabled = false;
            }

            panel_DangNhap.SendToBack();

            panel_Welcome.Visible = true;
            panel_Welcome.BringToFront();

            label_Welcome.Text = $"{GetGreetings()},\n{found.HoTen}";

            iconTab[0].IconChar = IconChar.SignOut;
            iconTab[0].Text = "Đăng xuất";

            textBox_TenTK.Text = "";
            textBox_MatKhau.Text = "";
        }
        private void Icon_DangKy_Click(object sender, EventArgs e) {
            string tenTK = textBox_TenTK.Text;
            string matKhau = textBox_MatKhau.Text;

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau)) {
                MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản và mật khẩu trước khi đăng ký.",
                    "Chưa điền tên tài khoản hoặc mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (db.TaiKhoans.Any(tk => tk.TenTK == tenTK)) {
                _ = MessageBox.Show("Tên tài khoản này đã được sử dụng.\n" +
                    "Vui lòng sử dụng tên tài khoản khác.",
                    "Trùng lặp tên tài khoản",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                textBox_TenTK.Text = "";


            } else {
                // trường HoTen giải quyết sao ?!
                db.Add(new TaiKhoan { TenTK = tenTK, MatKhau = matKhau, VaiTro = "staff", HoTen = "" });
                db.SaveChanges();

                MessageBox.Show("Đăng ký hoàn tất.\nVui lòng đăng nhập lại.", "Đăng ký hoàn tất",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                textBox_TenTK.Text = "";
                textBox_MatKhau.Text = "";
            }
        }
        bool isShowPass = false;

        private void Icon_ShowPass_Click(object sender, EventArgs e) {
            if (isShowPass == false) {
                textBox_MatKhau.PasswordChar = '\0';
                isShowPass = true;
                icon_ShowPass.IconChar = IconChar.EyeSlash;
            } else {
                textBox_MatKhau.PasswordChar = '•';
                isShowPass = false;
                icon_ShowPass.IconChar = IconChar.Eye;
            }
        }

        private void CheckBox_enableTab_CheckedChanged(object sender, EventArgs e) {
            iconTab.ForEach(tab => tab.Enabled = checkBox_enableTab.Checked);
        }
    }
}
