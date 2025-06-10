using FontAwesome.Sharp;
using Show10;
using Show10.Child_Forms;
using Show10.Windows;

namespace show10 {
    public partial class MainWindow : Form {
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;
        private NhaSachContext? db;

        private readonly List<IconButton> icon_Tab;

        public MainWindow() {
            InitializeComponent();
            DoubleBuffered = true;

            leftBorderBtn = new Panel { Size = new Size(10, 80) };
            panel_Menu.Controls.Add(leftBorderBtn);

            icon_Tab = [icon_Brand, icon_TaiKhoan, icon_Sach, icon_KhachHang, icon_BaoCao, icon_CaiDat];
            icon_Tab.ForEach(tab => tab.Enabled = false);
            icon_Brand.Enabled = true;

            icon_Brand.IconSize = 100;

            OpenChildForm(new Form_DangNhap(icon_Tab));
            label_TabName.Text = "Đăng nhập !";
        }
        private bool isFullScreen = false;
        private void Icon_Fullscreen_Click(object sender, EventArgs e) {
            FullScreen fullScreen = new();

            if (!isFullScreen) {
                FullScreen.EnterFullScreenMode(this);
                isFullScreen = true;
            } else {
                FullScreen.LeaveFullScreenMode(this);
                isFullScreen = false;
            }
        }
        private void ActivateButton(object senderBtn) {
            if (senderBtn != null) {
                DisableButton();

                //Button
                currentBtn = (IconButton)senderBtn;

                currentBtn.ForeColor = Color.Black;
                currentBtn.BackColor = Color.White;
                currentBtn.IconColor = Color.Black;

                //Left border button
                leftBorderBtn.BackColor = Color.Black;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton() {
            if (currentBtn != null) {
                currentBtn.ForeColor = Color.White;
                currentBtn.BackColor = Color.Green;
                currentBtn.IconColor = Color.White;
            }
        }
        private void OpenChildForm(Form childForm) {
            currentChildForm?.Close();

            currentChildForm = childForm;

            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_ChildForm.Controls.Add(childForm);
            panel_ChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        #region tab icon Click
        private void Icon_TaiKhoan_Click(object sender, EventArgs e) {
            ActivateButton(sender);
            OpenChildForm(new Form_TaiKhoan());
            label_TabName.Text = "Quản lý tài khoản !";
        }
        private void Icon_Sach_Click(object sender, EventArgs e) {
            ActivateButton(sender);
            OpenChildForm(new Form_Sach());
            label_TabName.Text = "Quản lý sách !";
        }
        private void Icon_KhachHang_Click(object sender, EventArgs e) {
            ActivateButton(sender);
            OpenChildForm(new Form_KhachHang());
            label_TabName.Text = "Quản lý khách hàng !";
        }
        private void Icon_BaoCao_Click(object sender, EventArgs e) {
            ActivateButton(sender);
            OpenChildForm(new Form_BaoCao());
            label_TabName.Text = "Tạo báo cáo !";
        }
        #endregion
        // Use a static field to persist index between clicks
        static int index = 1;
        static readonly string[] show10 = ["!", "?", ":)", ":D", "XD"];
        private void Icon_Brand_Click(object sender, EventArgs e) {
            if (icon_Brand.IconChar == IconChar.Store) {
                icon_Brand.Text = "Show 10 " + show10[index];
                // Increment the index and wrap around to 0 when reaching the end of the array.
                // This ensures we cycle through all elements in 'show10' repeatedly without going out of bounds.
                index = (index + 1) % show10.Length;
            }
            if (icon_Brand.IconChar == IconChar.SignOut) {
                var result = MessageBox.Show(
                    "Bạn muốn đăng xuất ?",
                    "Đăng xuất",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes) {
                    DisableButton();
                    leftBorderBtn.SendToBack();
                    icon_Brand.IconChar = IconChar.Store;

                    icon_Tab.ForEach(tab => tab.Enabled = false);
                    icon_Brand.Enabled = true;

                    OpenChildForm(new Form_DangNhap(icon_Tab));
                    label_TabName.Text = "Đăng nhập !";

                    icon_Brand.Text = "Show 10 !";
                }
            }
        }
        private void Icon_CaiDat_Click(object sender, EventArgs e) {
            Form_Settings form_Settings = new();
            form_Settings.Show();
        }
    }
}
