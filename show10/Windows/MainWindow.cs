using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Show10;
using Show10.Child_Forms;
using Show10.Models;

namespace show10 {
    public partial class MainWindow : Form {
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;
        private NhaSachContext? db;

        private readonly List<Button> icon_Tab;

        public MainWindow() {
            InitializeComponent();
            DoubleBuffered = true;

            leftBorderBtn = new Panel {
                Size = new Size(10, 80)
            };

            panel_Menu.Controls.Add(leftBorderBtn);

            icon_Tab = [icon_TaiKhoan, icon_Sach, icon_KhachHang, icon_BaoCao];

            icon_Tab.ForEach(tab => tab.Enabled = false);
            panel_Welcome.Visible = false;

            icon_Brand.IconSize = 100;

            panel_DangNhap.BringToFront();
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            db = new NhaSachContext();

            _ = db.Database.EnsureDeleted();
            _ = db.Database.EnsureCreated();

            db.TaiKhoans.Load();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            db?.Dispose();
            db = null;
        }


        private void Timer_Tick(object sender, EventArgs e) {
            label_Clock.Text = "Bây giờ là " + DateTime.Now.ToString("t");
        }

        private bool isFullScreen = false;

        private void Icon_Fullscreen_Click(object sender, EventArgs e) {
            FullScreen fullScreen = new FullScreen();

            if (!isFullScreen) {
                fullScreen.EnterFullScreenMode(this);
                isFullScreen = true;
            } else {
                fullScreen.LeaveFullScreenMode(this);
                isFullScreen = false;
            }
        }

        private struct RGBColors {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color) {
            if (senderBtn != null) {
                DisableButton();


                //Button
                currentBtn = (IconButton)senderBtn;

                currentBtn.ForeColor = color;
                currentBtn.BackColor = Color.Gainsboro;
                currentBtn.IconColor = color;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton() {
            if (currentBtn != null) {
                currentBtn.ForeColor = DefaultForeColor;
                currentBtn.BackColor = DefaultBackColor;
                currentBtn.IconColor = DefaultForeColor;
            }
        }

        private void OpenChildForm(Form childForm) {
            //open only form
            if (currentChildForm != null) {
                currentChildForm.Close();
            }

            currentChildForm = childForm;

            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_ChildForm.Controls.Add(childForm);
            panel_ChildForm.Tag = childForm;

            panel_DangNhap.SendToBack();
            panel_Welcome.SendToBack();
            childForm.BringToFront();
            childForm.Show();
        }

        #region icon Tab Click
        private void Icon_TaiKhoan_Click(object sender, EventArgs e) {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Form_TaiKhoan());
        }
        private void Icon_Sach_Click(object sender, EventArgs e) {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Form_Sach());
        }
        private void Icon_KhachHang_Click(object sender, EventArgs e) {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Form_KhachHang());
        }
        private void Icon_BaoCao_Click(object sender, EventArgs e) {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Form_BaoCao());
        }
        #endregion

        private void Icon_DangNhap_Click(object sender, EventArgs e) {
            string tenTK = textBox_TenTK.Text;
            string matKhau = textBox_MatKhau.Text;

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau)) {
                MessageBox.Show(
                    "Nhập đủ tên tài khoản và mật khẩu trước khi đăng nhập.",
                    "Chưa điền tên tài khoản hoặc mật khẩu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (!db.TaiKhoans.Any(tk => tk.TenTK == tenTK && tk.MatKhau == matKhau)) {
                _ = MessageBox.Show(
                    "Không tìm thấy tài khoản.\nKiểm tra tên tài khoản và mật khẩu đúng như đã đăng ký.",
                    "Không tìm thấy tài khoản",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            } else {
                var found = db.TaiKhoans.First(tk => tk.TenTK == tenTK);

                if (found.VaiTro == "admin") {
                    icon_Tab.ForEach(tab => tab.Enabled = true);
                } else {
                    icon_Sach.Enabled = true;
                    icon_KhachHang.Enabled = true;
                    icon_BaoCao.Enabled = true;
                }

                panel_DangNhap.SendToBack();

                panel_Welcome.Visible = true;
                panel_Welcome.BringToFront();
                label_Welcome.Text = $"Xin chào\n{found.HoTen}";
                icon_Brand.IconChar = IconChar.SignOut;
                icon_Brand.Text = "Đăng xuất";
            }
        }

        private void Icon_Brand_Click(object sender, EventArgs e) {

            if (icon_Brand.IconChar == IconChar.Store) {
                List<string> show10 = ["!", "?", ":)", ":D", "XD"];

                Random rnd = new Random();
                int r = rnd.Next(show10.Count);

                icon_Brand.Text = "Show 10 " + show10[r];
            }

            if (icon_Brand.IconChar == IconChar.SignOut) {
                var result = MessageBox.Show(
                    "Bạn có thực sự muốn đăng xuất?",
                    "Trước khi đăng xuất",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes) {
                    DisableButton();
                    icon_Brand.IconChar = IconChar.Store;

                    icon_Tab.ForEach(tab => tab.Enabled = false);
                    panel_Welcome.Visible = false;
                    leftBorderBtn.Visible = false;
                    panel_DangNhap.BringToFront();

                    currentChildForm?.Close();

                    icon_Brand.Text = "Show 10 !";

                }
            }
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
                _ = db.Add(new TaiKhoan { TenTK = tenTK, MatKhau = matKhau, VaiTro = "user", HoTen = "" });
                _ = db.SaveChanges();

                _ = MessageBox.Show("Đăng ký hoàn tất.\nVui lòng đăng nhập lại.", "Đăng ký hoàn tất",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                textBox_TenTK.Text = "";
                textBox_MatKhau.Text = "";
            }

        }

        private void CheckBox_enableTab_CheckedChanged(object sender, EventArgs e) {
            icon_Tab.ForEach(tab => tab.Enabled = checkBox_enableTab.Checked);
        }

        private void CheckBox_HienMK_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_HienMK.Checked) {
                textBox_MatKhau.PasswordChar = '\0';
            } else {
                textBox_MatKhau.PasswordChar = '•';
            }
        }

    }
}
