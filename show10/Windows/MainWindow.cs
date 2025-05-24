using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Show10;
using Show10.Child_Forms;
using Show10.Models;
using Show10.Windows;

namespace show10 {
    public partial class MainWindow : Form
    {
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;
        private NhaSachContext? db;

        private readonly List<Button> icon_Tab;

        private ToolTip toolTipCaiDat = new ToolTip();
        private bool toolTipShown = false;

        public MainWindow() {
            InitializeComponent();
            DoubleBuffered = true;

            leftBorderBtn = new Panel {
                Size = new Size(10, 80)
            };

            panel_Menu.Controls.Add(leftBorderBtn);

            icon_Tab = new List<Button> { icon_TaiKhoan, icon_Sach, icon_KhachHang, icon_BaoCao, icon_CaiDat };

            icon_Tab.ForEach(tab => tab.Enabled = false);
            panel_Welcome.Visible = false;

            icon_Brand.IconSize = 100;

            panel_DangNhap.BringToFront();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            db = new NhaSachContext();

            _ = db.Database.EnsureDeleted();
            _ = db.Database.EnsureCreated();

            db.TaiKhoans.Load();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            db?.Dispose();
            db = null;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            label_Clock.Text = "Bây giờ là " + DateTime.Now.ToString("t");
        }

        private bool isFullScreen = false;

        private void Icon_Fullscreen_Click(object sender, EventArgs e)
        {
            FullScreen fullScreen = new FullScreen();

            if (!isFullScreen)
            {
                fullScreen.EnterFullScreenMode(this);
                isFullScreen = true;
            }
            else
            {
                fullScreen.LeaveFullScreenMode(this);
                isFullScreen = false;
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                //Button
                currentBtn = (IconButton)senderBtn;

                currentBtn.ForeColor = color;
                currentBtn.BackColor = ControlPaint.Dark(color);
                currentBtn.IconColor = color;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.White;
                currentBtn.BackColor = Color.Green;
                currentBtn.IconColor = Color.White;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            currentChildForm?.Close();

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
        private void Icon_TaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Form_TaiKhoan());
            label_TabName.Text = "Quản lý tài khoản";
        }
        private void Icon_Sach_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Form_Sach());
            label_TabName.Text = "Quản lý sách";
        }
        private void Icon_KhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Form_KhachHang());
            label_TabName.Text = "Quản lý khách hàng";
        }
        private void Icon_BaoCao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Form_BaoCao());
            label_TabName.Text = "Tạo báo cáo";
        }
        #endregion

        private string getGreetings() {
            var chaoHoi = "Xin chào";
            var hour = DateTime.Now.Hour;

            if (hour >= 0 && hour < 12) {
                chaoHoi = "Chào buổi sáng ☀️";
            } else if (hour >= 12 && hour < 18) {
                chaoHoi = "Chào buổi chiều ☀️";
            } else {
                chaoHoi = "Chào buổi tối 🌙";
            }
            return chaoHoi;
        }

        private void Icon_DangNhap_Click(object sender, EventArgs e)
        {
            string tenTK = textBox_TenTK.Text;
            string matKhau = textBox_MatKhau.Text;

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show(
                    "Nhập đủ tên tài khoản và mật khẩu trước khi đăng nhập.",
                    "Chưa điền tên tài khoản hoặc mật khẩu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!db.TaiKhoans.Any(tk => tk.TenTK == tenTK && tk.MatKhau == matKhau))
            {
                _ = MessageBox.Show(
                    "Không tìm thấy tài khoản.\nKiểm tra tên tài khoản và mật khẩu đúng như đã đăng ký.",
                    "Không tìm thấy tài khoản",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                var found = db.TaiKhoans.First(tk => tk.TenTK == tenTK);

                if (found.VaiTro == "admin")
                {
                    icon_Tab.ForEach(tab => tab.Enabled = true);
                    icon_CaiDat.Enabled = true;
                }
                else
                {
                    icon_Sach.Enabled = true;
                    icon_KhachHang.Enabled = true;
                    icon_BaoCao.Enabled = true;
                }

                panel_DangNhap.SendToBack();

                panel_Welcome.Visible = true;
                panel_Welcome.BringToFront();

                label_Welcome.Text = $"{getGreetings()},\n{found.HoTen}";

                icon_Brand.IconChar = IconChar.SignOut;
                icon_Brand.Text = "Đăng xuất";

                textBox_TenTK.Text = "";
                textBox_MatKhau.Text = "";
            }
        }

        // Use a static field to persist index between clicks
        static int index = 1;
        static readonly string[] show10 = ["!", "?", ":)", ":D", "XD"];

        private void Icon_Brand_Click(object sender, EventArgs e)
        {
            if (icon_Brand.IconChar == IconChar.Store)
            {
                icon_Brand.Text = "Show 10 " + show10[index];
                // Increment the index and wrap around to 0 when reaching the end of the array.
                // This ensures we cycle through all elements in 'show10' repeatedly without going out of bounds.
                index = (index + 1) % show10.Length;
            }

            if (icon_Brand.IconChar == IconChar.SignOut)
            {
                var result = MessageBox.Show(
                    "Đăng xuất ????????",
                    "Chắc chưa ????????",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
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

        private void Icon_DangKy_Click(object sender, EventArgs e)
        {
            string tenTK = textBox_TenTK.Text;
            string matKhau = textBox_MatKhau.Text;

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản và mật khẩu trước khi đăng ký.",
                    "Chưa điền tên tài khoản hoặc mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (db.TaiKhoans.Any(tk => tk.TenTK == tenTK))
            {
                _ = MessageBox.Show("Tên tài khoản này đã được sử dụng.\n" +
                    "Vui lòng sử dụng tên tài khoản khác.",
                    "Trùng lặp tên tài khoản",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                textBox_TenTK.Text = "";


            }
            else
            {
                // trường HoTen giải quyết sao ?!
                _ = db.Add(new TaiKhoan { TenTK = tenTK, MatKhau = matKhau, VaiTro = "user", HoTen = "" });
                _ = db.SaveChanges();

                _ = MessageBox.Show("Đăng ký hoàn tất.\nVui lòng đăng nhập lại.", "Đăng ký hoàn tất",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                textBox_TenTK.Text = "";
                textBox_MatKhau.Text = "";
            }
        }

        private void CheckBox_enableTab_CheckedChanged(object sender, EventArgs e)
        {
            icon_Tab.ForEach(tab => tab.Enabled = checkBox_enableTab.Checked);
        }

        private void icon_CaiDat_Click(object sender, EventArgs e)
        {
            Form_Settings form_Settings = new Form_Settings();
            form_Settings.Show();
        }

        private void Icon_CaiDat_Parent_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!icon_CaiDat.Enabled)
            {
                var pt = icon_CaiDat.Parent.PointToClient(Cursor.Position);
                if (icon_CaiDat.Bounds.Contains(pt))
                {
                    if (!toolTipShown)
                    {
                        toolTipCaiDat.Show("Chỉ admin mới có quyền cài đặt", icon_CaiDat, icon_CaiDat.Width / 2, icon_CaiDat.Height / 2, 5000);
                        toolTipShown = true;
                    }
                    return;
                }
            }
            toolTipCaiDat.Hide(icon_CaiDat);
            toolTipShown = false;
        }

        private void Icon_CaiDat_Parent_MouseLeave(object? sender, EventArgs e)
        {
            toolTipCaiDat.Hide(icon_CaiDat);
            toolTipShown = false;
        }

        private void Label_ChaoDon_Click(object sender, EventArgs e)
        {
            label_ChaoDon.Text = "Xin được chào đón " + show10[index];
            // Increment the index and wrap around to 0 when reaching the end of the array.
            // This ensures we cycle through all elements in 'show10' repeatedly without going out of bounds.
            index = (index + 1) % show10.Length;
        }

        private void Label_DangNhap_Click(object sender, EventArgs e)
        {
            label_DangNhap.Text = "Đăng nhập " + show10[index];
            // Increment the index and wrap around to 0 when reaching the end of the array.
            // This ensures we cycle through all elements in 'show10' repeatedly without going out of bounds.
            index = (index + 1) % show10.Length;
        }

        bool isShowPass = false;
        private void icon_ShowPass_Click(object sender, EventArgs e)
        {
            if (isShowPass == false)
            {
                textBox_MatKhau.PasswordChar = '\0';
                isShowPass = true;
                icon_ShowPass.IconChar = IconChar.EyeSlash;
            }
            else
            {
                textBox_MatKhau.PasswordChar = '•';
                isShowPass = false;
                icon_ShowPass.IconChar = IconChar.Eye;
            }
        }
    }
}
