using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Show10.Models;

namespace Show10.Child_Forms {
    public partial class Form_KhachHang : Form {
        private NhaSachContext? db;
        bool isLoc_KH = false;
        bool isLoc_PTT = false;
        public Form_KhachHang() {
            InitializeComponent();
            DoubleBuffered = true;

            //comboBox_KH_GioiTinh.Text = "";
        }
        private void Form_KhachHang_Load(object sender, EventArgs e) {
            db = new NhaSachContext();

            // Dòng dưới sẽ luôn xoá DB mỗi khi load form
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.KhachHangs.Load();
            khachHangBindingSource.DataSource = db.KhachHangs.Local.ToBindingList();
            dataGridView_KhachHang.Refresh();


            db.PhieuThuTiens.Load();
            phieuThuTienBindingSource.DataSource = db.PhieuThuTiens.Local.ToBindingList();
            dataGridView_PhieuThuTien.Refresh();
        }
        private void Form_KhachHang_FormClosing(object sender, FormClosingEventArgs e) {
            db?.Dispose();
            db = null;
        }

        #region Quản lý khách hàng
        private KhachHang GetKhachHang() {
            string maKH = textBox_KH_MaKH.Text;
            string tenKH = textBox_KH_TenKH.Text;
            string gioiTinh = comboBox_KH_GioiTinh.Text;
            string email = textBox_KH_Email.Text;
            string diaChi = textBox_KH_DiaChi.Text;
            string tienNo = textBox_KH_TienNo.Text;

            return new KhachHang {
                MaKH = int.Parse(maKH),
                TenKH = tenKH,
                GioiTinh = gioiTinh,
                Email = email,
                DiaChi = diaChi,
                TienNo = double.Parse(tienNo)
            };
        }
        private void SetKhachHang(KhachHang khachHang) {
            textBox_KH_MaKH.Text = khachHang.MaKH.ToString();
            textBox_KH_TenKH.Text = khachHang.TenKH;
            comboBox_KH_GioiTinh.Text = khachHang.GioiTinh;
            textBox_KH_Email.Text = khachHang.Email;
            textBox_KH_DiaChi.Text = khachHang.DiaChi;
            textBox_KH_TienNo.Text = khachHang.TienNo.ToString();
        }
        private void Icon_KH_Them_Click(object sender, EventArgs e) {
            KhachHang khachHang = GetKhachHang();

            if (string.IsNullOrWhiteSpace(khachHang.TenKH) ||
                string.IsNullOrWhiteSpace(khachHang.Email) ||
                string.IsNullOrWhiteSpace(khachHang.DiaChi) ||
                string.IsNullOrWhiteSpace(textBox_KH_TienNo.Text)
                ) {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên khách hàng, giới tính, email, địa chỉ, số điện thoại và tiền nợ\n" +
                    "trước khi thêm vào cơ sở dữ liệu.",
                    "Thiếu thông tin cần thiết",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (db.KhachHangs.Any(kh => kh.MaKH == khachHang.MaKH)) {
                var result = MessageBox.Show(
                    "Tồn tại khách hàng với mã khách hàng này.\n" +
                    "Ghi đè thông tin của khách hàng?",
                    "Ghi đè thông tin của khách hàng",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {
                    var existingKH = db.KhachHangs.First(kh => kh.MaKH == khachHang.MaKH);

                    existingKH.TenKH = khachHang.TenKH;
                    existingKH.GioiTinh = khachHang.GioiTinh;
                    existingKH.Email = khachHang.Email;
                    existingKH.DiaChi = khachHang.DiaChi;
                    existingKH.TienNo = khachHang.TienNo;

                    db.SaveChanges();
                    dataGridView_KhachHang.Refresh();
                }
            } else {
                _ = db.Add(khachHang);
                _ = db.SaveChanges();
                dataGridView_KhachHang.Refresh();

                // Optionally clear input fields after adding
                // Icon_KH_Clear_Click(sender, e);
            }
        }
        private void Icon_KH_Xoa_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "Xoá khách hàng?",
                "Trước khi xoá khách hàng",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                // Use a HashSet to avoid duplicate row indices
                var rowsToDelete = new HashSet<int>();

                foreach (DataGridViewCell cell in dataGridView_KhachHang.SelectedCells) {
                    rowsToDelete.Add(cell.RowIndex);
                }

                foreach (int rowIndex in rowsToDelete) {
                    if (dataGridView_KhachHang.Rows[rowIndex].DataBoundItem is KhachHang khachHang) {
                        db.KhachHangs.Remove(khachHang);
                    }
                }

                db.SaveChanges();
                dataGridView_KhachHang.Refresh();
            }
        }
        private void Icon_KH_Loc_Click(object sender, EventArgs e) {
            icon_KH_Loc.IconChar = (icon_KH_Loc.IconChar == IconChar.Filter) ? IconChar.FilterCircleXmark : IconChar.Filter;
            isLoc_KH = !isLoc_KH;

            List<Button> icon_KH = [icon_KH_Them, icon_KH_Xoa, icon_KH_Tim, icon_KH_ThuTien];

            icon_KH.ForEach(icon => icon.Enabled = !isLoc_KH);

            if (!isLoc_KH) {
                dataGridView_KhachHang.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dataGridView_KhachHang.DataSource = khachHangBindingSource;
            } else {
                comboBox_KH_GioiTinh.Text = "";

                ApplyFilter_KhachHang();
            }
        }
        private void ApplyFilter_KhachHang() {
            if (isLoc_KH && dataGridView_KhachHang != null) {
                var filteredData = db.KhachHangs.Local.AsQueryable();

                if (!string.IsNullOrEmpty(textBox_KH_MaKH.Text)) {
                    if (int.TryParse(textBox_KH_MaKH.Text, out int maKH)) {
                        filteredData = filteredData.Where(kh => kh.MaKH.ToString().Contains(maKH.ToString()));
                    }
                }

                if (!string.IsNullOrEmpty(textBox_KH_TenKH.Text)) {
                    filteredData = filteredData.Where(kh => kh.TenKH.Contains(textBox_KH_TenKH.Text));
                }

                if (!string.IsNullOrEmpty(comboBox_KH_GioiTinh.Text) && comboBox_KH_GioiTinh.Text != "Tất cả") {
                    filteredData = filteredData.Where(kh => kh.GioiTinh.Contains(comboBox_KH_GioiTinh.Text));
                }

                if (!string.IsNullOrEmpty(textBox_KH_Email.Text)) {
                    filteredData = filteredData.Where(kh => kh.Email.Contains(textBox_KH_Email.Text));
                }

                if (!string.IsNullOrEmpty(textBox_KH_DiaChi.Text)) {
                    filteredData = filteredData.Where(kh => kh.DiaChi.Contains(textBox_KH_DiaChi.Text));
                }


                dataGridView_KhachHang.DataSource = new BindingSource { DataSource = filteredData.ToList() };
            }
        }
        #region Detect changes in quản lý khách hàng
        private void TextBox_KH_MaKH_TextChanged(object sender, EventArgs e) {
            ApplyFilter_KhachHang();
        }

        private void TextBox_KH_TenKH_TextChanged(object sender, EventArgs e) {
            ApplyFilter_KhachHang();

        }

        private void ComboBox_KH_GioiTinh_SelectedIndexChanged(object sender, EventArgs e) {
            ApplyFilter_KhachHang();

        }

        private void TextBox_KH_Email_TextChanged(object sender, EventArgs e) {
            ApplyFilter_KhachHang();

        }

        private void TextBox_KH_DiaChi_TextChanged(object sender, EventArgs e) {
            ApplyFilter_KhachHang();

        }

        private void TextBox_KH_TienNo_TextChanged(object sender, EventArgs e) {
            ApplyFilter_KhachHang();

        }
        #endregion
        private void Icon_KH_Tim_Click(object sender, EventArgs e) {
            var filteredData = db.KhachHangs.Local.AsQueryable();

            if (!string.IsNullOrEmpty(textBox_KH_MaKH.Text)) {
                if (int.TryParse(textBox_KH_MaKH.Text, out int maKH)) {
                    filteredData = filteredData.Where(kh => kh.MaKH == maKH);
                }
            }

            if (!string.IsNullOrEmpty(textBox_KH_TenKH.Text)) {
                filteredData = filteredData.Where(kh => kh.TenKH == textBox_KH_TenKH.Text);
            }

            if (!string.IsNullOrEmpty(comboBox_KH_GioiTinh.Text) && comboBox_KH_GioiTinh.Text != "") {
                filteredData = filteredData.Where(kh => kh.GioiTinh == comboBox_KH_GioiTinh.Text);
            }

            if (!string.IsNullOrEmpty(textBox_KH_Email.Text)) {
                filteredData = filteredData.Where(kh => kh.Email == textBox_KH_Email.Text);
            }

            if (!string.IsNullOrEmpty(textBox_KH_DiaChi.Text)) {
                filteredData = filteredData.Where(kh => kh.DiaChi == textBox_KH_DiaChi.Text);
            }

            var filteredList = filteredData.ToList();
            if (filteredList.Count == 0)
                return;

            var firstKH = filteredList[0];

            foreach (DataGridViewRow row in dataGridView_KhachHang.Rows) {
                if (row.DataBoundItem is KhachHang rowKH &&
                    rowKH.MaKH == firstKH.MaKH) // Compare by unique key
                {
                    row.Selected = true;
                    dataGridView_KhachHang.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }
        private void Icon_KH_Clear_Click(object sender, EventArgs e) {
            SetKhachHang(new KhachHang { MaKH = 0, TenKH = "", GioiTinh = "", Email = "", DiaChi = "", TienNo = 0 });
            textBox_KH_MaKH.Text = "";
            comboBox_KH_GioiTinh.SelectedIndex = 0;
            textBox_KH_TienNo.Text = "";
        }
        private void DataGridView_KhachHang_SelectionChanged(object sender, EventArgs e) {
            if (db == null || this.IsDisposed || this.Disposing)
                return;
            if (dataGridView_KhachHang.CurrentRow?.DataBoundItem is KhachHang khachHang) {
                SetKhachHang(khachHang);
            }
        }
        private void DataGridView_KhachHang_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            db?.SaveChanges();
        }


        private void Icon_KH_ThuTien_Click(object sender, EventArgs e) {
            tabControl_KhachHang.SelectedTab = tabPage_PhieuThuTien;
            Icon_PTT_Clear_Click(sender, e);

            int lastMaPhieu = db!.PhieuThuTiens
                .OrderByDescending(p => p.MaPT)
                .FirstOrDefault()?.MaPT ?? 0;
            textBox_PTT_MaPhieu.Text = (lastMaPhieu + 1).ToString();

            if (dataGridView_KhachHang.CurrentRow?.DataBoundItem is KhachHang khachHang) {
                textBox_PTT_MaKH.Text = khachHang.MaKH.ToString();
            }
        }

        #endregion

        #region Quản lý phiếu thu tiền
        private PhieuThuTien GetPhieuThuTien() {
            string maPT = textBox_PTT_MaPhieu.Text;
            string maKH = textBox_PTT_MaKH.Text;
            string ngayThu = date_PTT_NgayThu.Text;
            string soTien = textBox_PTT_SoTien.Text;

            return new PhieuThuTien {
                MaPT = int.Parse(maPT),
                MaKH = int.Parse(maKH),
                NgayThu = DateTime.Parse(ngayThu),
                SoTien = double.Parse(soTien)
            };
        }
        private void SetPhieuThuTien(PhieuThuTien phieuThuTien) {
            textBox_PTT_MaPhieu.Text = phieuThuTien.MaPT.ToString();
            textBox_PTT_MaKH.Text = phieuThuTien.MaKH.ToString();
            date_PTT_NgayThu.Text = phieuThuTien.NgayThu.ToShortDateString();
            textBox_PTT_SoTien.Text = phieuThuTien.SoTien.ToString();
        }

        private void Icon_PTT_Them_Click(object sender, EventArgs e) {
            PhieuThuTien phieuThuTien = GetPhieuThuTien();

            if (!Properties.Settings.Default.thuTienVuotNo
                &&
                phieuThuTien.SoTien > db.KhachHangs.First(p => p.MaKH == phieuThuTien.MaKH).TienNo) {
                MessageBox.Show("Số tiền thu không thể vượt quá số tiền khách đang nợ!",
                    "Tiền thu vượt tiền nợ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_PTT_MaPhieu.Text) ||
                string.IsNullOrWhiteSpace(textBox_PTT_MaKH.Text) ||
                string.IsNullOrWhiteSpace(date_PTT_NgayThu.Text) ||
                string.IsNullOrWhiteSpace(textBox_PTT_SoTien.Text)
                ) {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ mã phiếu, mã khách hàng, ngày thu và số tiền\n" +
                    "trước khi thêm vào cơ sở dữ liệu.",
                    "Thiếu thông tin cần thiết",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (db.PhieuThuTiens.Any(ptt => ptt.MaPT == phieuThuTien.MaPT)) {
                var result = MessageBox.Show(
                    "Tồn tại phiếu thu tiền với mã phiếu này.\n" +
                    "Ghi đè thông tin của phiếu thu tiền?",
                    "Ghi đè thông tin của phiếu thu tiền",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {
                    var existingPTT = db.PhieuThuTiens.First(ptt => ptt.MaPT == phieuThuTien.MaPT);

                    existingPTT.MaKH = phieuThuTien.MaKH;
                    existingPTT.NgayThu = phieuThuTien.NgayThu;
                    existingPTT.SoTien = phieuThuTien.SoTien;

                    db.SaveChanges();
                    dataGridView_PhieuThuTien.Refresh();
                }
            } else {
                _ = db.Add(phieuThuTien);
                _ = db.SaveChanges();
                dataGridView_PhieuThuTien.Refresh();

                // Optionally clear input fields after adding
                // Icon_PTT_Clear_Click(sender, e);
            }
        }
        private void Icon_PTT_Xoa_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "Xoá phiếu thu tiền?",
                "Trước khi xoá phiếu thu tiền",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                // Use a HashSet to avoid duplicate row indices
                var rowsToDelete = new HashSet<int>();

                foreach (DataGridViewCell cell in dataGridView_PhieuThuTien.SelectedCells) {
                    rowsToDelete.Add(cell.RowIndex);
                }

                foreach (int rowIndex in rowsToDelete) {
                    if (dataGridView_PhieuThuTien.Rows[rowIndex].DataBoundItem is PhieuThuTien phieuThuTien) {
                        db.PhieuThuTiens.Remove(phieuThuTien);
                    }
                }

                db.SaveChanges();
                dataGridView_PhieuThuTien.Refresh();
            }
        }
        private void Icon_PTT_Loc_Click(object sender, EventArgs e) {
            icon_PTT_Loc.IconChar = (icon_PTT_Loc.IconChar == IconChar.Filter) ? IconChar.FilterCircleXmark : IconChar.Filter;
            isLoc_PTT = !isLoc_PTT;

            List<Button> icon_PTT = [icon_PTT_Them, icon_PTT_Xoa, icon_PTT_Tim];

            icon_PTT.ForEach(icon => icon.Enabled = !isLoc_PTT);

            if (!isLoc_PTT) {
                dataGridView_PhieuThuTien.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dataGridView_PhieuThuTien.DataSource = phieuThuTienBindingSource;
            } else {
                ApplyFilter_PhieuThuTien();
            }
        }
        private void ApplyFilter_PhieuThuTien() {
            if (isLoc_PTT && dataGridView_PhieuThuTien != null) {
                var filteredData = db.PhieuThuTiens.Local.AsQueryable();

                if (!string.IsNullOrEmpty(textBox_PTT_MaPhieu.Text)) {
                    if (int.TryParse(textBox_PTT_MaPhieu.Text, out int maPT)) {
                        filteredData = filteredData.Where(ptt => ptt.MaPT.ToString().Contains(maPT.ToString()));
                    }
                }

                if (!string.IsNullOrEmpty(textBox_PTT_MaKH.Text)) {
                    if (int.TryParse(textBox_PTT_MaKH.Text, out int maKH)) {
                        filteredData = filteredData.Where(ptt => ptt.MaKH.ToString().Contains(maKH.ToString()));
                    }
                }

                if (!string.IsNullOrEmpty(date_PTT_NgayThu.Text)) {
                    if (DateTime.TryParse(date_PTT_NgayThu.Text, out DateTime ngayThu)) {
                        filteredData = filteredData.Where(ptt => ptt.NgayThu.Date == ngayThu.Date);
                    }
                }

                if (!string.IsNullOrEmpty(textBox_PTT_SoTien.Text)) {
                    if (double.TryParse(textBox_PTT_SoTien.Text, out double soTien)) {
                        filteredData = filteredData.Where(ptt => ptt.SoTien == soTien);
                    }
                }

                dataGridView_PhieuThuTien.DataSource = new BindingSource { DataSource = filteredData.ToList() };
            }
        }
        #region Detect changes in quanLyPhieuThuTien
        private void TextBox_PTT_MaPhieu_TextChanged(object sender, EventArgs e) {
            ApplyFilter_PhieuThuTien();
        }

        private void TextBox_PTT_MaKH_TextChanged(object sender, EventArgs e) {
            ApplyFilter_PhieuThuTien();

        }

        private void TextBox_PTT_NgayThu_TextChanged(object sender, EventArgs e) {
            ApplyFilter_PhieuThuTien();

        }

        private void TextBox_PTT_SoTien_TextChanged(object sender, EventArgs e) {
            ApplyFilter_PhieuThuTien();

        }
        #endregion
        private void Icon_PTT_Tim_Click(object sender, EventArgs e) {
            var filteredData = db.PhieuThuTiens.Local.AsQueryable();

            if (!string.IsNullOrEmpty(textBox_PTT_MaPhieu.Text)) {
                if (int.TryParse(textBox_PTT_MaPhieu.Text, out int maPT)) {
                    filteredData = filteredData.Where(ptt => ptt.MaPT == maPT);
                }
            }

            if (!string.IsNullOrEmpty(textBox_PTT_MaKH.Text)) {
                if (int.TryParse(textBox_PTT_MaKH.Text, out int maKH)) {
                    filteredData = filteredData.Where(ptt => ptt.MaKH == maKH);
                }
            }

            if (!string.IsNullOrEmpty(date_PTT_NgayThu.Text)) {
                if (DateTime.TryParse(date_PTT_NgayThu.Text, out DateTime ngayThu)) {
                    filteredData = filteredData.Where(ptt => ptt.NgayThu.Date == ngayThu.Date);
                }
            }

            if (!string.IsNullOrEmpty(textBox_PTT_SoTien.Text)) {
                if (double.TryParse(textBox_PTT_SoTien.Text, out double soTien)) {
                    filteredData = filteredData.Where(ptt => ptt.SoTien == soTien);
                }
            }

            var filteredList = filteredData.ToList();
            if (filteredList.Count == 0)
                return;

            var firstPTT = filteredList[0];

            foreach (DataGridViewRow row in dataGridView_PhieuThuTien.Rows) {
                if (row.DataBoundItem is PhieuThuTien rowPTT &&
                    rowPTT.MaPT == firstPTT.MaPT) // Compare by unique key
                {
                    row.Selected = true;
                    dataGridView_PhieuThuTien.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void Icon_PTT_Clear_Click(object sender, EventArgs e) {
            textBox_PTT_MaPhieu.Text = "";
            textBox_PTT_MaKH.Text = "";
            date_PTT_NgayThu.Text = "";
            textBox_PTT_SoTien.Text = "";
        }

        private void DataGridView_PhieuThuTien_SelectionChanged(object sender, EventArgs e) {
            if (db == null || this.IsDisposed || this.Disposing)
                return;
            if (dataGridView_PhieuThuTien.CurrentRow?.DataBoundItem is PhieuThuTien phieuThuTien) {
                SetPhieuThuTien(phieuThuTien);
            }
        }
        private void DataGridView_PhieuThuTien_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            db?.SaveChanges();
        }

        #endregion

    }
}
