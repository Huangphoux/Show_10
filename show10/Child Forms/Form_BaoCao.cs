using Microsoft.EntityFrameworkCore;

namespace Show10.Child_Forms {
    public partial class Form_BaoCao : Form {
        private NhaSachContext? db;
        public Form_BaoCao() {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void LoadMonthsToComboBox() {
            var months = db!.PhieuNhapSachs
                .Select(p => p.NgayNhap.Month)
                .Distinct()
                .OrderBy(y => y)
                .ToList();

            comboBox_BCTon_Thang.Items.Clear();

            foreach (var m in months) {
                comboBox_BCTon_Thang.Items.Add(m.ToString());
            }

            if (comboBox_BCTon_Thang.Items.Count > 0)
                comboBox_BCTon_Thang.SelectedIndex = 0;
        }

        private void LoadYearsToComboBox() {
            var years = db!.PhieuNhapSachs
                .Select(p => p.NgayNhap.Year)
                .Distinct()
                .OrderBy(y => y)
                .ToList();

            comboBox_BCTon_Nam.Items.Clear();

            foreach (var y in years) {
                comboBox_BCTon_Nam.Items.Add(y.ToString());
            }

            if (comboBox_BCTon_Nam.Items.Count > 0)
                comboBox_BCTon_Nam.SelectedIndex = 0;
        }

        private void Form_BaoCao_Load(object sender, EventArgs e) {
            db = new NhaSachContext();

            // Dòng dưới sẽ luôn xoá DB mỗi khi load form
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.BaoCaoTons.Load();
            baoCaoTonBindingSource.DataSource = db.BaoCaoTons.Local.ToBindingList();
            dataGridView_BCTon.Refresh();

            LoadMonthsToComboBox();
            LoadYearsToComboBox();
        }

        private void Form_BaoCao_FormClosing(object sender, FormClosingEventArgs e) {
            db?.Dispose();
            db = null;
        }

        private void TabControl_BaoCao_SelectedIndexChanged(object sender, EventArgs e) {
            LoadMonthsToComboBox();
            LoadYearsToComboBox();
        }

    }
}
