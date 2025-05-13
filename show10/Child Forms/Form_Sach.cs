using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;

namespace Show10.Child_Forms {
    public partial class Form_Sach : Form {
        private NhaSachContext? db;
        bool isLoc = false;

        public Form_Sach() {
            InitializeComponent();
        }

        private void Icon_Sach_Loc_Click(object sender, EventArgs e) {
            icon_Sach_Loc.IconChar = (icon_Sach_Loc.IconChar == IconChar.Filter) ? IconChar.FilterCircleXmark : IconChar.Filter;
        }

        private void Form_Sach_Load(object sender, EventArgs e) {
            db = new NhaSachContext();

            // Dòng dưới sẽ luôn xoá DB mỗi khi load form
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.Sachs.Load();
            sachBindingSource.DataSource = db.Sachs.Local.ToBindingList();
            dataGridView_Sach.Refresh();
        }

        private void Form_Sach_FormClosing(object sender, FormClosingEventArgs e) {
            db?.Dispose();
            db = null;
        }

    }
}
