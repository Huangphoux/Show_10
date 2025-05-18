using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Show10.Models;
using System.Runtime.CompilerServices;

namespace Show10.Child_Forms {
    public partial class Form_Sach : Form {
        private NhaSachContext? db;
        bool isLoc_Sach = false;
        bool isLoc_PNS = false;
        bool isLoc_HD = false;

        public Form_Sach() {
            InitializeComponent();
        }
        private void Form_Sach_Load(object sender, EventArgs e) {
            db = new NhaSachContext();

            // Dòng dưới sẽ luôn xoá DB mỗi khi load form
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.Sachs.Load();
            sachBindingSource.DataSource = db.Sachs.Local.ToBindingList();
            dataGridView_Sach.Refresh();

            db.PhieuNhapSachs.Load();
            phieuNhapSachBindingSource.DataSource = db.PhieuNhapSachs.Local.ToBindingList();
            dataGridView_PhieuNhapSach.Refresh();

            db.HoaDonBanSachs.Load();
            hoaDonBanSachBindingSource.DataSource = db.HoaDonBanSachs.Local.ToBindingList();
            dataGridView_HoaDonBanSach.Refresh();
        }
        private void Form_Sach_FormClosing(object sender, FormClosingEventArgs e) {
            db?.Dispose();
            db = null;
        }

        #region Quản lý sách
        private Sach GetSach() {
            string maSach = textBox_Sach_MaSach.Text;
            string tenSach = textBox_Sach_TenSach.Text;
            string soLuong = textBox_Sach_SoLuong.Text;
            string tacGia = textBox_Sach_TacGia.Text;
            string theLoai = textBox_Sach_TheLoai.Text;

            return new Sach {
                MaSach = int.Parse(maSach),
                TenSach = tenSach,
                SoLuong = int.Parse(soLuong),
                TacGia = tacGia,
                TheLoai = theLoai
            };
        }
        private void SetSach(Sach sach) {
            textBox_Sach_MaSach.Text = sach.MaSach.ToString();
            textBox_Sach_TenSach.Text = sach.TenSach;
            textBox_Sach_SoLuong.Text = sach.SoLuong.ToString();
            textBox_Sach_TacGia.Text = sach.TacGia;
            textBox_Sach_TheLoai.Text = sach.TheLoai;
        }
        private void Icon_Sach_Them_Click(object sender, EventArgs e) {
            Sach sach = GetSach();

            if (string.IsNullOrEmpty(sach.TenSach) || string.IsNullOrEmpty(sach.TacGia) || string.IsNullOrEmpty(sach.TheLoai)) {
                MessageBox.Show(
                    "Nhập đủ tên sách, tác giả và thể loại\ntrước khi thêm vào cơ sở dữ liệu.",
                    "Chưa điền đầy đủ các thông tin cần thiết",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (db.Sachs.Any(s => s.MaSach == sach.MaSach)) {
                var result = MessageBox.Show(
                    "Tồn tại sách với mã sách này.\n" +
                    "Ghi đè thông tin của sách?",
                    "Ghi đè thông tin của sách",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {
                    var existingSach = db.Sachs.First(s => s.MaSach == sach.MaSach);

                    existingSach.TenSach = sach.TenSach;
                    existingSach.TacGia = sach.TacGia;
                    existingSach.TheLoai = sach.TheLoai;

                    db.SaveChanges();
                    dataGridView_Sach.Refresh();
                }
            } else {
                _ = db.Add(sach);
                _ = db.SaveChanges();
                dataGridView_Sach.Refresh();
            }
        }
        private void Icon_Sach_Xoa_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "Xoá sách?",
                "Trước khi xoá sách",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                // Use a HashSet to avoid duplicate row indices
                var rowsToDelete = new HashSet<int>();

                foreach (DataGridViewCell cell in dataGridView_Sach.SelectedCells) {
                    rowsToDelete.Add(cell.RowIndex);
                }

                foreach (int rowIndex in rowsToDelete) {
                    if (dataGridView_Sach.Rows[rowIndex].DataBoundItem is Sach sach) {
                        db.Sachs.Remove(sach);
                    }
                }

                db.SaveChanges();
                dataGridView_Sach.Refresh();
            }
        }
        private void Icon_Sach_Loc_Click(object sender, EventArgs e) {
            icon_Sach_Loc.IconChar = (icon_Sach_Loc.IconChar == IconChar.Filter) ? IconChar.FilterCircleXmark : IconChar.Filter;
            isLoc_Sach = !isLoc_Sach;

            List<Button> icon_Sach = [icon_Sach_Them, icon_Sach_Xoa, icon_Sach_Tim];

            icon_Sach.ForEach(icon => icon.Enabled = !isLoc_Sach);


            if (!isLoc_Sach) {
                dataGridView_Sach.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dataGridView_Sach.DataSource = sachBindingSource;
            } else {
                ApplyFilter_Sach();
            }
        }
        #region Detech changes in Sach
        private void TextBox_Sach_MaSach_TextChanged(object sender, EventArgs e) {
            ApplyFilter_Sach();
        }
        private void TextBox_Sach_TenSach_TextChanged(object sender, EventArgs e) {
            ApplyFilter_Sach();
        }
        private void TextBox_Sach_TacGia_TextChanged(object sender, EventArgs e) {
            ApplyFilter_Sach();
        }
        private void TextBox_Sach_TheLoai_TextChanged(object sender, EventArgs e) {
            ApplyFilter_Sach();
        }
        #endregion
        private void ApplyFilter_Sach() {
            if (isLoc_Sach && dataGridView_Sach != null) {
                var filteredData = db.Sachs.Local.AsQueryable();

                if (!string.IsNullOrEmpty(textBox_Sach_MaSach.Text)) {
                    if (int.TryParse(textBox_Sach_MaSach.Text, out int maSach)) {
                        filteredData = filteredData.Where(s => s.MaSach == maSach);
                    }
                }

                if (!string.IsNullOrEmpty(textBox_Sach_TenSach.Text)) {
                    filteredData = filteredData.Where(s => s.TenSach.Contains(textBox_Sach_TenSach.Text));
                }

                if (!string.IsNullOrEmpty(textBox_Sach_TacGia.Text)) {
                    filteredData = filteredData.Where(s => s.TacGia.Contains(textBox_Sach_TacGia.Text));
                }

                if (!string.IsNullOrEmpty(textBox_Sach_TheLoai.Text)) {
                    filteredData = filteredData.Where(s => s.TheLoai.Contains(textBox_Sach_TheLoai.Text));
                }

                // Update DataGridView
                dataGridView_Sach.DataSource = new BindingSource { DataSource = filteredData.ToList() };
            }
        }
        private void Icon_Sach_Tim_Click(object sender, EventArgs e) {
            var filteredData = db.Sachs.Local.AsQueryable();

            if (!string.IsNullOrEmpty(textBox_Sach_MaSach.Text)) {
                if (int.TryParse(textBox_Sach_MaSach.Text, out int maSach)) {
                    filteredData = filteredData.Where(s => s.MaSach == maSach);
                }
            }

            if (!string.IsNullOrEmpty(textBox_Sach_TenSach.Text)) {
                filteredData = filteredData.Where(s => s.TenSach.Contains(textBox_Sach_TenSach.Text));
            }

            if (!string.IsNullOrEmpty(textBox_Sach_TacGia.Text)) {
                filteredData = filteredData.Where(s => s.TacGia.Contains(textBox_Sach_TacGia.Text));
            }

            if (!string.IsNullOrEmpty(textBox_Sach_TheLoai.Text)) {
                filteredData = filteredData.Where(s => s.TheLoai.Contains(textBox_Sach_TheLoai.Text));
            }

            var filteredList = filteredData.ToList();
            if (filteredList.Count == 0)
                return;

            var firstSach = filteredList[0];

            foreach (DataGridViewRow row in dataGridView_Sach.Rows) {
                if (row.DataBoundItem is Sach rowSach &&
                    rowSach.MaSach == firstSach.MaSach) // Compare by unique key
                {
                    row.Selected = true;
                    dataGridView_Sach.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }
        private void Icon_Sach_Clear_Click(object sender, EventArgs e) {
            SetSach(new Sach { MaSach = 0, TenSach = "", SoLuong = 0, TacGia = "", TheLoai = "" });
            textBox_Sach_MaSach.Text = "";
            textBox_Sach_SoLuong.Text = "";
        }
        private void DataGridView_Sach_SelectionChanged(object sender, EventArgs e) {
            if (db == null || db is IDisposable { } && (this.IsDisposed || this.Disposing))
                return;
            if (dataGridView_Sach.CurrentRow?.DataBoundItem is Sach sach) {
                SetSach(sach);
            }
        }
        private void DataGridView_Sach_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            db?.SaveChanges();
        }

        #endregion
        #region Quản lý phiếu nhập sách
        private PhieuNhapSach GetPhieuNhapSach() {
            string maPN = textBox_PNS_MaPhieu.Text;
            string maSach = textBox_PNS_MaSach.Text;
            string soLuong = textBox_PNS_SoLuong.Text;
            string giaNhap = textBox_PNS_GiaNhap.Text;
            string ngayNhap = date_PNS_NgayNhap.Text;

            return new PhieuNhapSach {
                MaPN = int.Parse(maPN),
                MaSach = int.Parse(maSach),
                GiaNhap = double.Parse(giaNhap),
                SoLuong = int.Parse(soLuong),
                NgayNhap = DateTime.Parse(ngayNhap)
            };
        }
        private void SetPhieuNhapSach(PhieuNhapSach phieu) {
            textBox_PNS_MaPhieu.Text = phieu.MaPN.ToString();
            textBox_PNS_MaSach.Text = phieu.MaSach.ToString();
            textBox_PNS_SoLuong.Text = phieu.SoLuong.ToString();
            textBox_PNS_GiaNhap.Text = phieu.GiaNhap.ToString();
            date_PNS_NgayNhap.Text = phieu.NgayNhap.ToShortDateString();
        }
        private void Icon_PNS_Them_Click(object sender, EventArgs e) {
            PhieuNhapSach phieu = GetPhieuNhapSach();

            if (!db!.Sachs.Any(sach => sach.MaSach == phieu.MaSach)) {
                MessageBox.Show(
                    $"Không tồn tại sách với mã số {phieu.MaSach}.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            int minNhap = int.Parse(Properties.Settings.Default.minNhap);
            if (phieu.SoLuong < minNhap) {
                MessageBox.Show(
                    $"Số lượng nhập yêu cầu ít nhất {minNhap} quyển.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            int maxSLSach = int.Parse(Properties.Settings.Default.maxSLSach);
            if (db!.Sachs.First(tk => tk.MaSach == phieu.MaSach).SoLuong > maxSLSach) {
                MessageBox.Show(
                    $"Không được nhập các sách có số lượng tồn khô trên {maxSLSach} quyển.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_PNS_MaPhieu.Text) ||
                string.IsNullOrWhiteSpace(textBox_PNS_MaSach.Text) ||
                string.IsNullOrWhiteSpace(textBox_PNS_SoLuong.Text) ||
                string.IsNullOrWhiteSpace(textBox_PNS_GiaNhap.Text) ||
                string.IsNullOrWhiteSpace(date_PNS_NgayNhap.Text)) {
                MessageBox.Show(
                    "Nhập đủ mã phiếu, mã sách, số lượng, giá nhập và ngày nhập\ntrước khi thêm vào cơ sở dữ liệu.",
                    "Chưa điền đầy đủ các thông tin cần thiết",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (db!.PhieuNhapSachs.Any(p => p.MaPN == phieu.MaPN)) {
                var result = MessageBox.Show(
                    "Tồn tại phiếu nhập với mã phiếu này.\n" +
                    "Ghi đè thông tin của phiếu nhập?",
                    "Ghi đè thông tin của phiếu nhập",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {
                    var existingPhieu = db.PhieuNhapSachs.First(p => p.MaPN == phieu.MaPN);

                    existingPhieu.MaSach = phieu.MaSach;
                    existingPhieu.SoLuong = phieu.SoLuong;
                    existingPhieu.GiaNhap = phieu.GiaNhap;
                    existingPhieu.NgayNhap = phieu.NgayNhap;

                    db.SaveChanges();
                    dataGridView_PhieuNhapSach.Refresh();
                }
            } else {
                _ = db.Add(phieu);
                _ = db.SaveChanges();
                dataGridView_PhieuNhapSach.Refresh();
            }
        }
        private void Icon_PNS_Xoa_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "Xoá phiếu nhập sách?",
                "Trước khi xoá phiếu nhập",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                // Use a HashSet to avoid duplicate row indices
                var rowsToDelete = new HashSet<int>();

                foreach (DataGridViewCell cell in dataGridView_PhieuNhapSach.SelectedCells) {
                    rowsToDelete.Add(cell.RowIndex);
                }

                foreach (int rowIndex in rowsToDelete) {
                    if (dataGridView_PhieuNhapSach.Rows[rowIndex].DataBoundItem is PhieuNhapSach phieu) {
                        db!.PhieuNhapSachs.Remove(phieu);
                    }
                }

                db!.SaveChanges();
                dataGridView_PhieuNhapSach.Refresh();
            }
        }
        private void Icon_PNS_Clear_Click(object sender, EventArgs e) {
            textBox_PNS_MaPhieu.Text = "";
            textBox_PNS_MaSach.Text = "";
            textBox_PNS_SoLuong.Text = "";
            textBox_PNS_GiaNhap.Text = "";
            date_PNS_NgayNhap.Text = DateTime.Now.ToShortDateString();
        }
        private void Icon_PNS_Loc_Click(object sender, EventArgs e) {
            icon_PNS_Loc.IconChar = (icon_PNS_Loc.IconChar == IconChar.Filter) ? IconChar.FilterCircleXmark : IconChar.Filter;
            isLoc_PNS = !isLoc_PNS;

            List<Button> icon_PNS = [icon_PNS_Them, icon_PNS_Xoa, icon_PNS_Tim];

            icon_PNS.ForEach(icon => icon.Enabled = !isLoc_PNS);

            if (!isLoc_PNS) {
                dataGridView_PhieuNhapSach.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dataGridView_PhieuNhapSach.DataSource = phieuNhapSachBindingSource;
            } else {
                ApplyFilter_PhieuNhapSach();
            }
        }
        private void ApplyFilter_PhieuNhapSach() {
            if (isLoc_PNS && dataGridView_PhieuNhapSach != null) {
                var filteredData = db!.PhieuNhapSachs.Local.AsQueryable();

                if (!string.IsNullOrEmpty(textBox_PNS_MaPhieu.Text)) {
                    if (int.TryParse(textBox_PNS_MaPhieu.Text, out int maPN)) {
                        filteredData = filteredData.Where(p => p.MaPN == maPN);
                    }
                }

                if (!string.IsNullOrEmpty(textBox_PNS_MaSach.Text)) {
                    if (int.TryParse(textBox_PNS_MaSach.Text, out int maSach)) {
                        filteredData = filteredData.Where(p => p.MaSach == maSach);
                    }
                }

                dataGridView_PhieuNhapSach.DataSource = new BindingSource { DataSource = filteredData.ToList() };
            }
        }
        #region Detect changes in phieuNhapSach
        private void TextBox_PNS_MaPhieu_TextChanged(object sender, EventArgs e) {
            ApplyFilter_PhieuNhapSach();
        }
        private void TextBox_PNS_MaSach_TextChanged(object sender, EventArgs e) {
            ApplyFilter_PhieuNhapSach();
        }
        private void TextBox_PNS_SoLuong_TextChanged(object sender, EventArgs e) {
            ApplyFilter_PhieuNhapSach();
        }
        private void TextBox_PNS_GiaNhap_TextChanged(object sender, EventArgs e) {
            ApplyFilter_PhieuNhapSach();
        }
        private void Date_PNS_NgayNhap_ValueChanged(object sender, EventArgs e) {
            ApplyFilter_PhieuNhapSach();
        }
        #endregion
        private void Icon_PNS_Tim_Click(object sender, EventArgs e) {
            var filteredData = db!.PhieuNhapSachs.Local.AsQueryable();

            if (!string.IsNullOrEmpty(textBox_PNS_MaPhieu.Text)) {
                if (int.TryParse(textBox_PNS_MaPhieu.Text, out int maPN)) {
                    filteredData = filteredData.Where(p => p.MaPN == maPN);
                }
            }

            if (!string.IsNullOrEmpty(textBox_PNS_MaSach.Text)) {
                if (int.TryParse(textBox_PNS_MaSach.Text, out int maSach)) {
                    filteredData = filteredData.Where(p => p.MaSach == maSach);
                }
            }

            if (!string.IsNullOrEmpty(textBox_PNS_SoLuong.Text)) {
                if (int.TryParse(textBox_PNS_SoLuong.Text, out int soLuong)) {
                    filteredData = filteredData.Where(p => p.SoLuong == soLuong);
                }
            }

            if (!string.IsNullOrEmpty(textBox_PNS_GiaNhap.Text)) {
                if (double.TryParse(textBox_PNS_GiaNhap.Text, out double giaNhap)) {
                    filteredData = filteredData.Where(p => p.GiaNhap == giaNhap);
                }
            }

            if (!string.IsNullOrEmpty(date_PNS_NgayNhap.Text)) {
                if (DateTime.TryParse(date_PNS_NgayNhap.Text, out DateTime ngayNhap)) {
                    filteredData = filteredData.Where(p => p.NgayNhap.Date == ngayNhap.Date);
                }
            }

            var filteredList = filteredData.ToList();
            if (filteredList.Count == 0)
                return;

            var firstPhieu = filteredList[0];

            foreach (DataGridViewRow row in dataGridView_PhieuNhapSach.Rows) {
                if (row.DataBoundItem is PhieuNhapSach rowPhieu &&
                    rowPhieu.MaPN == firstPhieu.MaPN) // Compare by unique key
                {
                    row.Selected = true;
                    dataGridView_PhieuNhapSach.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }
        private void DataGridView_PhieuNhapSach_SelectionChanged(object sender, EventArgs e) {
            if (db == null || db is IDisposable { } && (this.IsDisposed || this.Disposing))
                return;
            if (dataGridView_PhieuNhapSach.CurrentRow?.DataBoundItem is PhieuNhapSach phieuNhapSachh) {
                SetPhieuNhapSach(phieuNhapSachh);
            }
        }
        private void DataGridView_PhieuNhapSach_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            db?.SaveChanges();
        }
        #endregion
        #region Quản lý hoá đơn bán sách
        private HoaDonBanSach GetHoaDonBanSach() {
            string maHD = textBox_HD_MaHD.Text;
            string maKH = textBox_HD_MaKH.Text;
            string maSach = textBox_HD_MaSach.Text;
            string soLuong = textBox_HD_SoLuong.Text;
            string giaBan = textBox_HD_GiaBan.Text;
            string ngayBan = date_HD_NgayBan.Text;

            return new HoaDonBanSach {
                SoHD = int.Parse(maHD),
                MaKH = int.Parse(maKH),
                MaSach = int.Parse(maSach),
                SoLuong = int.Parse(soLuong),
                GiaBan = double.Parse(giaBan),
                NgayHD = DateTime.Parse(ngayBan)
            };
        }
        private void SetHoaDonBanSach(HoaDonBanSach hoaDon) {
            textBox_HD_MaHD.Text = hoaDon.SoHD.ToString();
            textBox_HD_MaKH.Text = hoaDon.MaKH.ToString();
            textBox_HD_MaSach.Text = hoaDon.MaSach.ToString();
            textBox_HD_SoLuong.Text = hoaDon.SoLuong.ToString();
            textBox_HD_GiaBan.Text = hoaDon.GiaBan.ToString();
            date_HD_NgayBan.Text = hoaDon.NgayHD.ToShortDateString();
        }
        #endregion
    }
}
