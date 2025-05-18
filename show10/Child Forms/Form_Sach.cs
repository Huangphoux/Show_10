using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Show10.Models;

namespace Show10.Child_Forms {
    public partial class Form_Sach : Form {
        private NhaSachContext? db;
        bool isLoc_Sach = false;
        bool isLoc_PNS = false;
        bool isLoc_HD = false;

        public Form_Sach() {
            InitializeComponent();
            DoubleBuffered = true;
        }
        private void Form_Sach_Load(object sender, EventArgs e) {
            db = new NhaSachContext();

            // Dòng dưới sẽ luôn xoá DB mỗi khi load form
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            KiemTraSLSach();
            db.Sachs.Load();
            sachBindingSource.DataSource = db.Sachs.Local.ToBindingList();
            dataGridView_Sach.Refresh();

            KiemTraMaSachTonTai();
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

        private void KiemTraSLSach() {
            if (db == null) return;
            foreach (var sach in db.Sachs) {
                int soLuongNhap = db.PhieuNhapSachs
                    .Where(p => p.MaSach == sach.MaSach)
                    .Sum(p => p.SoLuong);
                int soLuongBan = db.HoaDonBanSachs
                    .Where(p => p.MaSach == sach.MaSach)
                    .Sum(p => p.SoLuong);

                sach.SoLuong = soLuongNhap - soLuongBan;
            }
            db.SaveChanges();
            dataGridView_Sach.Refresh();
        }
        private void KiemTraMaSachTonTai() {
            if (db == null) return;

            // Use a HashSet to avoid duplicate row indices
            var rowsToDelete = new HashSet<int>();

            foreach (var phieu in db.PhieuNhapSachs) {
                if (!db.Sachs.Any(p => p.MaSach == phieu.MaSach)) {
                    rowsToDelete.Add(phieu.MaPN);
                }
            }

            // if hashSet is not empty
            if (rowsToDelete.Any(x => true)) {
                var result = MessageBox.Show(
                     $"Phát hiện các phiếu ({string.Join(" ", rowsToDelete)}) chứa mã sách không tồn tại.\n" +
                     $"Xoá phiếu?",
                     "Phát hiện phiếu nhập sách không tồn tại",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) {
                    foreach (int rowIndex in rowsToDelete) {
                        // nếu là rowIndex thì sẽ xoá dòng dưới dòng cần xoá
                        if (dataGridView_PhieuNhapSach.Rows[rowIndex - 1].DataBoundItem is PhieuNhapSach phieu) {
                            db.PhieuNhapSachs.Remove(phieu);
                        }
                    }
                    db.SaveChanges();
                }
            }
        }
        private void TabControl_Sach_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl_Sach.SelectedTab == tabPage_Sach) {
                KiemTraSLSach();
            }
            if (tabControl_Sach.SelectedTab == tabPage_PhieuNhapSach) {
                KiemTraMaSachTonTai();
            }
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

                Icon_Sach_Clear_Click(sender, e);
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
        private void Icon_Sach_Nhap_Click(object sender, EventArgs e) {
            tabControl_Sach.SelectedTab = tabPage_PhieuNhapSach;
            Icon_PNS_Clear_Click(sender, e);

            int lastMaPhieu = db.PhieuNhapSachs
                .OrderByDescending(p => p.MaPN)
                .FirstOrDefault()?.MaPN ?? 0;
            textBox_PNS_MaPhieu.Text = (lastMaPhieu + 1).ToString();

            if (dataGridView_Sach.CurrentRow?.DataBoundItem is Sach sach) {
                textBox_PNS_MaSach.Text = sach.MaSach.ToString();
            }
        }
        private void Icon_Sach_Ban_Click(object sender, EventArgs e) {
            tabControl_Sach.SelectedTab = tabPage_HoaDonBanSach;
            Icon_HD_Clear_Click(sender, e);

            int lastMaHD = db.HoaDonBanSachs
                .OrderByDescending(hd => hd.MaHD)
                .FirstOrDefault()?.MaHD ?? 0;
            textBox_HD_MaHD.Text = (lastMaHD + 1).ToString();

            if (dataGridView_Sach.CurrentRow?.DataBoundItem is Sach sach) {
                textBox_HD_MaSach.Text = sach.MaSach.ToString();
            }
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

                Icon_PNS_Clear_Click(sender, e);
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
                MaHD = int.Parse(maHD),
                MaKH = int.Parse(maKH),
                MaSach = int.Parse(maSach),
                SoLuong = int.Parse(soLuong),
                GiaBan = double.Parse(giaBan),
                NgayHD = DateTime.Parse(ngayBan)
            };
        }
        private void SetHoaDonBanSach(HoaDonBanSach hoaDon) {
            textBox_HD_MaHD.Text = hoaDon.MaHD.ToString();
            textBox_HD_MaKH.Text = hoaDon.MaKH.ToString();
            textBox_HD_MaSach.Text = hoaDon.MaSach.ToString();
            textBox_HD_SoLuong.Text = hoaDon.SoLuong.ToString();
            textBox_HD_GiaBan.Text = hoaDon.GiaBan.ToString();
            date_HD_NgayBan.Text = hoaDon.NgayHD.ToShortDateString();
        }
        private void Icon_HD_Them_Click(object sender, EventArgs e) {
            HoaDonBanSach hoaDon = GetHoaDonBanSach();

            if (!db!.Sachs.Any(sach => sach.MaSach == hoaDon.MaSach)) {
                MessageBox.Show(
                    $"Không tồn tại sách với mã số {hoaDon.MaSach}.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            if (!db!.KhachHangs.Any(kh => kh.MaKH == hoaDon.MaKH)) {
                MessageBox.Show(
                    $"Không tồn tại khách hàng với mã số {hoaDon.MaKH}.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            int maxNo = int.Parse(Properties.Settings.Default.maxNo);
            var khachHang = db.KhachHangs.First(p => p.MaKH == hoaDon.MaKH);
            if (khachHang.TienNo > maxNo) {
                MessageBox.Show(
                    $"Không thể bán sách cho khách hàng mã số {hoaDon.MaKH}\n" +
                    $"vì khách hàng đang nợ {khachHang.TienNo}, quá mức tối đa của cửa hàng là {maxNo}.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            int minSLSach = int.Parse(Properties.Settings.Default.minSLSach);
            var sach = db!.Sachs.First(s => s.MaSach == hoaDon.MaSach);
            if (sach.SoLuong - hoaDon.SoLuong < minSLSach) {
                MessageBox.Show(
                    $"Không thể bán sách này do số lượng tồn kho sẽ chỉ còn" +
                    $"{sach.SoLuong} (số lượng tồn) - {hoaDon.SoLuong} (số lượng bán) = {sach.SoLuong - hoaDon.SoLuong} quyển,\n" +
                    $"dưới mức quy định của cửa hàng là {minSLSach}.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_HD_MaHD.Text) ||
                string.IsNullOrWhiteSpace(textBox_HD_MaKH.Text) ||
                string.IsNullOrWhiteSpace(textBox_HD_MaSach.Text) ||
                string.IsNullOrWhiteSpace(textBox_HD_SoLuong.Text) ||
                string.IsNullOrWhiteSpace(textBox_HD_GiaBan.Text) ||
                string.IsNullOrWhiteSpace(date_HD_NgayBan.Text)) {
                MessageBox.Show(
                    "Nhập đủ mã hoá đơn, mã khách hàng, mã sách, số lượng, giá bán và ngày bán\ntrước khi thêm vào cơ sở dữ liệu.",
                    "Chưa điền đầy đủ các thông tin cần thiết",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (db!.HoaDonBanSachs.Any(hd => hd.MaHD == hoaDon.MaHD)) {
                var result = MessageBox.Show(
                    "Tồn tại hoá đơn với mã hoá đơn này.\n" +
                    "Ghi đè thông tin của hoá đơn?",
                    "Ghi đè thông tin của hoá đơn",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {
                    var existingHD = db.HoaDonBanSachs.First(hd => hd.MaHD == hoaDon.MaHD);

                    // Cộng lại số lượng sách cũ trước khi trừ số mới
                    var sachCu = db.Sachs.First(s => s.MaSach == existingHD.MaSach);
                    sachCu.SoLuong += existingHD.SoLuong;

                    existingHD.MaKH = hoaDon.MaKH;
                    existingHD.MaSach = hoaDon.MaSach;
                    existingHD.SoLuong = hoaDon.SoLuong;
                    existingHD.GiaBan = hoaDon.GiaBan;
                    existingHD.NgayHD = hoaDon.NgayHD;

                    // Trừ số lượng sách mới
                    sach.SoLuong -= hoaDon.SoLuong;

                    db.SaveChanges();
                    dataGridView_HoaDonBanSach.Refresh();
                }
            } else {
                // Trừ số lượng sách khi bán
                sach.SoLuong -= hoaDon.SoLuong;
                _ = db.Add(hoaDon);
                _ = db.SaveChanges();
                dataGridView_HoaDonBanSach.Refresh();

                textBox_HD_MaHD.Text = "";
                textBox_HD_MaKH.Text = "";
                textBox_HD_MaSach.Text = "";
                textBox_HD_SoLuong.Text = "";
                textBox_HD_GiaBan.Text = "";
                date_HD_NgayBan.Text = DateTime.Now.ToShortDateString();
            }
        }
        private void Icon_HD_Xoa_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "Xoá hoá đơn bán sách?",
                "Trước khi xoá hoá đơn",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                // Use a HashSet to avoid duplicate row indices
                var rowsToDelete = new HashSet<int>();

                foreach (DataGridViewCell cell in dataGridView_HoaDonBanSach.SelectedCells) {
                    rowsToDelete.Add(cell.RowIndex);
                }

                foreach (int rowIndex in rowsToDelete) {
                    if (dataGridView_HoaDonBanSach.Rows[rowIndex].DataBoundItem is HoaDonBanSach hoaDon) {
                        db!.HoaDonBanSachs.Remove(hoaDon);
                    }
                }

                db!.SaveChanges();
                dataGridView_HoaDonBanSach.Refresh();
            }
        }
        private void Icon_HD_Clear_Click(object sender, EventArgs e) {
            textBox_HD_MaHD.Text = "";
            textBox_HD_MaKH.Text = "";
            textBox_HD_MaSach.Text = "";
            textBox_HD_SoLuong.Text = "";
            textBox_HD_GiaBan.Text = "";
            date_HD_NgayBan.Text = DateTime.Now.ToShortDateString();
        }
        private void Icon_HD_Loc_Click(object sender, EventArgs e) {
            icon_HD_Loc.IconChar = (icon_HD_Loc.IconChar == IconChar.Filter) ? IconChar.FilterCircleXmark : IconChar.Filter;
            isLoc_HD = !isLoc_HD;

            List<Button> icon_HD = [icon_HD_Them, icon_HD_Xoa, icon_HD_Tim];

            icon_HD.ForEach(icon => icon.Enabled = !isLoc_HD);

            if (!isLoc_HD) {
                dataGridView_HoaDonBanSach.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dataGridView_HoaDonBanSach.DataSource = hoaDonBanSachBindingSource;
            } else {
                ApplyFilter_HoaDonBanSach();
            }
        }

        private void ApplyFilter_HoaDonBanSach() {
            if (isLoc_HD && dataGridView_HoaDonBanSach != null) {
                var filteredData = db!.HoaDonBanSachs.Local.AsQueryable();

                if (!string.IsNullOrEmpty(textBox_HD_MaHD.Text)) {
                    if (int.TryParse(textBox_HD_MaHD.Text, out int soHD)) {
                        filteredData = filteredData.Where(hd => hd.MaHD == soHD);
                    }
                }

                if (!string.IsNullOrEmpty(textBox_HD_MaKH.Text)) {
                    if (int.TryParse(textBox_HD_MaKH.Text, out int maKH)) {
                        filteredData = filteredData.Where(hd => hd.MaKH == maKH);
                    }
                }

                if (!string.IsNullOrEmpty(textBox_HD_MaSach.Text)) {
                    if (int.TryParse(textBox_HD_MaSach.Text, out int maSach)) {
                        filteredData = filteredData.Where(hd => hd.MaSach == maSach);
                    }
                }

                if (!string.IsNullOrEmpty(textBox_HD_SoLuong.Text)) {
                    if (int.TryParse(textBox_HD_SoLuong.Text, out int soLuong)) {
                        filteredData = filteredData.Where(hd => hd.SoLuong == soLuong);
                    }
                }

                if (!string.IsNullOrEmpty(textBox_HD_GiaBan.Text)) {
                    if (double.TryParse(textBox_HD_GiaBan.Text, out double giaBan)) {
                        filteredData = filteredData.Where(hd => hd.GiaBan == giaBan);
                    }
                }

                if (!string.IsNullOrEmpty(date_HD_NgayBan.Text)) {
                    if (DateTime.TryParse(date_HD_NgayBan.Text, out DateTime ngayBan)) {
                        filteredData = filteredData.Where(hd => hd.NgayHD.Date == ngayBan.Date);
                    }
                }

                dataGridView_HoaDonBanSach.DataSource = new BindingSource { DataSource = filteredData.ToList() };
            }
        }
        #region Detect changes in hoaDonBanSach
        private void TextBox_HD_MaHD_TextChanged(object sender, EventArgs e) {
            ApplyFilter_HoaDonBanSach();
        }

        private void TextBox_HD_MaKH_TextChanged(object sender, EventArgs e) {
            ApplyFilter_HoaDonBanSach();
        }

        private void TextBox_HD_MaSach_TextChanged(object sender, EventArgs e) {
            ApplyFilter_HoaDonBanSach();
        }

        private void TextBox_HD_SoLuong_TextChanged(object sender, EventArgs e) {
            ApplyFilter_HoaDonBanSach();
        }

        private void TextBox_HD_GiaBan_TextChanged(object sender, EventArgs e) {
            ApplyFilter_HoaDonBanSach();
        }

        private void Date_HD_NgayBan_ValueChanged(object sender, EventArgs e) {
            ApplyFilter_HoaDonBanSach();
        }
        #endregion

        private void Icon_HD_Tim_Click(object sender, EventArgs e) {
            var filteredData = db!.HoaDonBanSachs.Local.AsQueryable();

            if (!string.IsNullOrEmpty(textBox_HD_MaHD.Text)) {
                if (int.TryParse(textBox_HD_MaHD.Text, out int soHD)) {
                    filteredData = filteredData.Where(hd => hd.MaHD == soHD);
                }
            }

            if (!string.IsNullOrEmpty(textBox_HD_MaKH.Text)) {
                if (int.TryParse(textBox_HD_MaKH.Text, out int maKH)) {
                    filteredData = filteredData.Where(hd => hd.MaKH == maKH);
                }
            }

            if (!string.IsNullOrEmpty(textBox_HD_MaSach.Text)) {
                if (int.TryParse(textBox_HD_MaSach.Text, out int maSach)) {
                    filteredData = filteredData.Where(hd => hd.MaSach == maSach);
                }
            }

            if (!string.IsNullOrEmpty(textBox_HD_SoLuong.Text)) {
                if (int.TryParse(textBox_HD_SoLuong.Text, out int soLuong)) {
                    filteredData = filteredData.Where(hd => hd.SoLuong == soLuong);
                }
            }

            if (!string.IsNullOrEmpty(textBox_HD_GiaBan.Text)) {
                if (double.TryParse(textBox_HD_GiaBan.Text, out double giaBan)) {
                    filteredData = filteredData.Where(hd => hd.GiaBan == giaBan);
                }
            }

            if (!string.IsNullOrEmpty(date_HD_NgayBan.Text)) {
                if (DateTime.TryParse(date_HD_NgayBan.Text, out DateTime ngayBan)) {
                    filteredData = filteredData.Where(hd => hd.NgayHD.Date == ngayBan.Date);
                }
            }

            var filteredList = filteredData.ToList();
            if (filteredList.Count == 0)
                return;

            var firstHD = filteredList[0];

            foreach (DataGridViewRow row in dataGridView_HoaDonBanSach.Rows) {
                if (row.DataBoundItem is HoaDonBanSach rowHD &&
                    rowHD.MaHD == firstHD.MaHD) // Compare by unique key
                {
                    row.Selected = true;
                    dataGridView_HoaDonBanSach.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }
        private void DataGridView_HoaDonBanSach_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            db?.SaveChanges();

        }
        private void DataGridView_HoaDonBanSach_SelectionChanged(object sender, EventArgs e) {
            if (db == null || db is IDisposable { } && (this.IsDisposed || this.Disposing))
                return;
            if (dataGridView_HoaDonBanSach.CurrentRow?.DataBoundItem is HoaDonBanSach hoaDonBanSach) {
                SetHoaDonBanSach(hoaDonBanSach);
            }
        }

        #endregion

    }
}
