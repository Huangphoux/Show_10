using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Show10.Models;
using System.Data;

namespace Show10.Child_Forms {
    public partial class Form_BaoCao : Form {
        private NhaSachContext? db;
        public Form_BaoCao() {
            InitializeComponent();
            DoubleBuffered = true;

            dataGridView_BCNo.RowTemplate.Height = 50;
            dataGridView_BCTon.RowTemplate.Height = 50;
        }
        private void Form_BaoCao_Load(object sender, EventArgs e) {
            db = new NhaSachContext();

            // Dòng dưới sẽ luôn xoá DB mỗi khi load form
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db!.BaoCaoTons.RemoveRange(db.BaoCaoTons);
            db!.BaoCaoNos.RemoveRange(db.BaoCaoNos);

            db.BaoCaoTons.Load();
            baoCaoTonBindingSource.DataSource = db.BaoCaoTons.Local.ToBindingList();
            dataGridView_BCTon.Refresh();

            db.BaoCaoNos.Load();
            baoCaoNoBindingSource.DataSource = db.BaoCaoNos.Local.ToBindingList();
            dataGridView_BCNo.Refresh();

            LoadMonthsToComboBox_BaoCaoTon();
            LoadYearsToComboBox_BaoCaoTon();

            LoadMonthsToComboBox_BaoCaoNo();
            LoadYearsToComboBox_BaoCaoNo();
        }
        private void Form_BaoCao_FormClosing(object sender, FormClosingEventArgs e) {

            db?.Dispose();
            db = null;
        }
        private static void InBaoCao(DataGridView dataGridView) {
            if (dataGridView == null) {
                MessageBox.Show(
                    "Vui lòng tạo dữ liệu trước khi in báo cáo!",
                    "Chưa tạo dữ liệu để in báo cáo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = new();

            foreach (DataGridViewColumn column in dataGridView.Columns) {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            foreach (DataGridViewRow row in dataGridView.Rows) {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells) {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            SaveFileDialog saveFileDialog1 = new() {
                Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FileName = $"baocao_{DateTime.Now:yyyyMMddTHHmmss}.xlsx"
            };

            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK) {
                string filename = saveFileDialog1.FileName;

                using XLWorkbook wb = new();
                wb.Worksheets.Add(dt, "Báo cáo");

                wb.Worksheet(1).Columns().AdjustToContents();
                wb.SaveAs(filename);
                MessageBox.Show("Lưu báo cáo thành công.", "Lưu báo cáo thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #region Báo cáo tồn
        private void LoadMonthsToComboBox_BaoCaoTon() {
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
        private void LoadYearsToComboBox_BaoCaoTon() {
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
        private static int GetTonCuoi(int tonDau, int phatSinh) {
            if (tonDau + phatSinh < 0) {
                return tonDau - phatSinh;
            } else {
                return tonDau + phatSinh;
            }
        }
        private int GetPhatSinh(int ma, int thang, int nam) {
            int tongNhap = db!.PhieuNhapSachs
                .Where(p => p.MaSach == ma && p.NgayNhap.Month == thang && p.NgayNhap.Year == nam)
                .Sum(p => (int?)p.SoLuong) ?? 0;

            int tongBan = db!.HoaDonBanSachs
                .Where(p => p.MaSach == ma && p.NgayHD.Month == thang && p.NgayHD.Year == nam)
                .Sum(p => (int?)p.SoLuong) ?? 0;

            return tongNhap - tongBan;
        }
        private void Icon_BCTon_TaoMoi_Click(object sender, EventArgs e) {
            db!.BaoCaoTons.RemoveRange(db.BaoCaoTons);

            var maSachs = db.Sachs
                .Select(s => s.MaSach)
                .ToList();

            int thang = int.Parse(comboBox_BCTon_Thang.Text);
            int nam = int.Parse(comboBox_BCTon_Nam.Text);

            foreach (var ma in maSachs) {
                int tonDau = 0;

                var thangNhapSach = db!.PhieuNhapSachs
                    .Where(p => p.MaSach == ma && p.NgayNhap.Month < thang)
                    .Select(p => p.NgayNhap.Month)
                    .Distinct()
                    .OrderBy(m => m)
                    .ToList();

                foreach (var month in thangNhapSach) {
                    var phatSinhMonthly = GetPhatSinh(ma, month, nam);
                    tonDau = GetTonCuoi(tonDau, phatSinhMonthly);
                }

                int phatSinh = GetPhatSinh(ma, thang, nam);
                int tonCuoi = GetTonCuoi(tonDau, phatSinh);

                db.BaoCaoTons.Add(new BaoCaoTon {
                    MaSach = ma,
                    TonDau = tonDau,
                    PhatSinh = phatSinh,
                    TonCuoi = tonCuoi
                });
            }

            // Save changes to the database
            db.SaveChanges();
            dataGridView_BCTon.Refresh();
        }
        private void Icon_BCTon_In_Click(object sender, EventArgs e) {
            InBaoCao(dataGridView_BCTon);
        }
        #endregion
        #region Báo cáo nợ
        private void LoadMonthsToComboBox_BaoCaoNo() {
            var months = db!.PhieuThuTiens
                .Select(p => p.NgayThu.Month)
                .Distinct()
                .OrderBy(m => m)
                .ToList();

            comboBox_BCNo_Thang.Items.Clear();

            foreach (var m in months) {
                comboBox_BCNo_Thang.Items.Add(m.ToString());
            }

            if (comboBox_BCNo_Thang.Items.Count > 0)
                comboBox_BCNo_Thang.SelectedIndex = 0;
        }
        private void LoadYearsToComboBox_BaoCaoNo() {
            var years = db!.PhieuThuTiens
                .Select(p => p.NgayThu.Year)
                .Distinct()
                .OrderBy(y => y)
                .ToList();

            comboBox_BCNo_Nam.Items.Clear();

            foreach (var y in years) {
                comboBox_BCNo_Nam.Items.Add(y.ToString());
            }

            if (comboBox_BCNo_Nam.Items.Count > 0)
                comboBox_BCNo_Nam.SelectedIndex = 0;
        }
        private double getNoCuoi(double noDau, double phatSinh) {
            if (noDau + phatSinh < 0) {
                return noDau - phatSinh;
            } else {
                return noDau + phatSinh;
            }
        }
        private double getPhatSinhNo(int maKH, int thang, int nam) {
            double tongBan = db!.HoaDonBanSachs
                .Where(p => p.MaKH == maKH && p.NgayHD.Month == thang && p.NgayHD.Year == nam)
                .Sum(p => (double?)p.ConLai) ?? 1;

            double tongThu = db!.PhieuThuTiens
                .Where(p => p.MaKH == maKH && p.NgayThu.Month == thang && p.NgayThu.Year == nam)
                .Sum(p => (double?)p.SoTien) ?? 0;

            return tongBan - tongThu;
        }
        private void Icon_BCNo_TaoMoi_Click(object sender, EventArgs e) {
            db!.BaoCaoNos.RemoveRange(db.BaoCaoNos);

            var maKHs = db.KhachHangs
                .Select(kh => kh.MaKH)
                .ToList();

            int thang = int.Parse(comboBox_BCNo_Thang.Text);
            int nam = int.Parse(comboBox_BCNo_Nam.Text);

            foreach (var maKH in maKHs) {
                double noDau = 0;

                var thangThuTien = db!.PhieuThuTiens
                    .Where(p => p.MaKH == maKH && p.NgayThu.Month < thang && p.NgayThu.Year == nam)
                    .Select(p => p.NgayThu.Month)
                    .Distinct()
                    .OrderBy(m => m)
                    .ToList();

                foreach (var month in thangThuTien) {
                    var phatSinhMonthly = getPhatSinhNo(maKH, month, nam);
                    noDau = getNoCuoi(noDau, phatSinhMonthly);
                }

                double phatSinh = getPhatSinhNo(maKH, thang, nam);
                double noCuoi = getNoCuoi(noDau, phatSinh);

                db.BaoCaoNos.Add(new BaoCaoNo {
                    MaKH = maKH,
                    NoDau = noDau,
                    PhatSinh = phatSinh,
                    NoCuoi = noCuoi
                });
            }

            // Save changes to the database
            db.SaveChanges();
            dataGridView_BCNo.Refresh();
        }
        private void IconButton_BCNo_In_Click(object sender, EventArgs e) {
            InBaoCao(dataGridView_BCNo);
        }
        #endregion
    }
}
