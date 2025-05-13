using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;

namespace Show10.Child_Forms {
    public partial class Form_KhachHang : Form {
        private NhaSachContext? db;
        bool isLoc = false;
        public Form_KhachHang() {
            InitializeComponent();
        }

        private void Icon_KH_Loc_Click(object sender, EventArgs e) {
            icon_KH_Loc.IconChar = (icon_KH_Loc.IconChar == IconChar.Filter) ? IconChar.FilterCircleXmark : IconChar.Filter;
        }

        private void Form_KhachHang_FormClosing(object sender, FormClosingEventArgs e) {
            db?.Dispose();
            db = null;
        }

        private void Form_KhachHang_Load(object sender, EventArgs e) {
            db = new NhaSachContext();

            // Dòng dưới sẽ luôn xoá DB mỗi khi load form
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.KhachHangs.Load();
            khachHangBindingSource.DataSource = db.KhachHangs.Local.ToBindingList();
            dataGridView_KhachHang.Refresh();
        }

    }
}
