using Microsoft.EntityFrameworkCore;
using Show10.Data_Access;

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
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.TaiKhoans.Load();

            taiKhoanBindingSource.DataSource = db.TaiKhoans.Local.ToBindingList();
        }

        private void CheckBox_TK_TimKiem_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_TK_TimKiem.Checked) {
                icon_TK_Them.Enabled = false;
                icon_TK_Xoa.Enabled = false;
            } else {
                icon_TK_Them.Enabled = true;
                icon_TK_Xoa.Enabled = true;
            }

        }
    }
}
