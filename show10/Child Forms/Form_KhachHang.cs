using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Show10.Models;
using System.Linq.Dynamic.Core;
using System.Media;

namespace Show10.Child_Forms {
    public partial class Form_KhachHang : Form {
        private NhaSachContext? db;
        bool isLoc_KH = false;
        bool isLoc_PTT = false;

        public Form_KhachHang() {
            InitializeComponent();
            DoubleBuffered = true;

            dataGridView_KhachHang.RowTemplate.Height = 50;
            dataGridView_PhieuThuTien.RowTemplate.Height = 50;

            string themTooltip_Text =
                "Thêm vào cơ sở dữ liệu.\n" +
                "Nếu chưa điền mã, sẽ tự động thêm mã để chống trùng lặp mã phân biệt.\n" +
                "Nếu phát hiện trùng mã, có thể ghi đè lên dữ liệu có sẵn.\n";

            ToolTip toolTip = new();
            toolTip.SetToolTip(icon_KH_Them, themTooltip_Text);
            toolTip.SetToolTip(icon_KH_Xoa, "Xoá khỏi cơ sở dữ liệu");
            toolTip.SetToolTip(icon_KH_Tim, "Tìm dữ liệu đầu tiên tương ứng với các ô dữ liệu");
            toolTip.SetToolTip(icon_KH_Loc, "Giới hạn hiển thị các dữ liệu dựa trên các điều kiện");
            toolTip.SetToolTip(icon_KH_Clear, "Làm trống các ô dữ liệu");

            toolTip.SetToolTip(icon_PTT_Them, themTooltip_Text);
            toolTip.SetToolTip(icon_PTT_Xoa, "Xoá khỏi cơ sở dữ liệu");
            toolTip.SetToolTip(icon_PTT_Tim, "Tìm dữ liệu đầu tiên tương ứng với các ô dữ liệu");
            toolTip.SetToolTip(icon_PTT_Loc, "Giới hạn hiển thị các dữ liệu dựa trên các điều kiện");
            toolTip.SetToolTip(icon_PTT_Clear, "Làm trống các ô dữ liệu");

            string soLuongToolTip =
                "Khi ở chế độ LỌC, sử dụng các biểu thức sau để giới hạn kết quả:\n" +
                "- Miền giá trị (x đại diện cho thuộc tính): 6 < x < 9, 4 <= x <= 20, 310 < x <= 105\n" +
                "- Tìm đúng số lượng: 31, 01, 05\n" +
                "- Giới hạn: > 69, <= 420, = 310, != 105";

            ToolTip soLuongTooltip = new();
            soLuongTooltip.SetToolTip(textBox_KH_TienNo, soLuongToolTip);
            soLuongTooltip.SetToolTip(textBox_PTT_SoTien, soLuongToolTip);

        }
        private void Form_KhachHang_Load(object sender, EventArgs e) {
            db = new NhaSachContext();

            // Dòng dưới sẽ luôn xoá DB mỗi khi load form
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            KiemTraNo();

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
        private void KiemTraNo() {
            if (db == null) return;
            foreach (var kh in db.KhachHangs) {
                double tienNo = db.HoaDonBanSachs
                    .Where(p => p.MaKH == kh.MaKH)
                    .Sum(p => p.ConLai);
                double tienTra = db.PhieuThuTiens
                    .Where(p => p.MaKH == kh.MaKH)
                    .Sum(p => p.SoTien);

                kh.TienNo = tienNo - tienTra;
            }
            db.SaveChanges();
            dataGridView_KhachHang.Refresh();
        }
        private static string FilterSoLuong(string input, string table) {
            string expr = "";

            try {
                input = input.Trim();
                var rangeMatch = System.Text.RegularExpressions.Regex.Match(input, @"^\s*(\d+)\s*(<|<=)\s*x\s*(<|<=)\s*(\d+)\s*$");
                if (rangeMatch.Success) {
                    int lower = int.Parse(rangeMatch.Groups[1].Value);
                    string lowerOp = rangeMatch.Groups[2].Value;
                    string upperOp = rangeMatch.Groups[3].Value;
                    int upper = int.Parse(rangeMatch.Groups[4].Value);
                    string lowerExpr = lowerOp == "<=" ? $"{table} >= {lower}" : $"{table} > {lower}";
                    string upperExpr = upperOp == "<=" ? $"{table} <= {upper}" : $"{table} < {upper}";
                    expr = $"{lowerExpr} && {upperExpr}";
                } else if (int.TryParse(input, out int value)) {
                    expr = $"{table} == {value}";
                } else if (input.StartsWith(">") || input.StartsWith("<") || input.StartsWith("=") || input.StartsWith("!")) {
                    if (input.StartsWith("=") && !input.StartsWith("==")) {
                        expr = $"{table} == {input.Substring(1).Trim()}";
                    } else if (input.StartsWith("!=")) {
                        expr = $"{table} != {input.Substring(2).Trim()}";
                    } else {
                        expr = $"{table} {input}";
                    }
                } else if (input.Contains("x")) {
                    expr = input.Replace("x", table);
                } else {
                    expr = $"{table} == {input}";
                }
            } catch {
                // Ignore invalid expressions  
            }

            return expr;
        }
        #region Quản lý khách hàng
        private void TabControl_KhachHang_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl_KhachHang.SelectedTab == tabPage_KhachHang) {
                KiemTraNo();
            }
        }
        private KhachHang GetKhachHang() {
            int lastMaKH = db!.KhachHangs
                .OrderByDescending(p => p.MaKH)
                .FirstOrDefault()?.MaKH ?? 0;

            string maKH = textBox_KH_MaKH.Text;
            string tenKH = textBox_KH_TenKH.Text;
            string gioiTinh = comboBox_KH_GioiTinh.Text;
            string email = textBox_KH_Email.Text;
            string diaChi = textBox_KH_DiaChi.Text;
            string tienNo = textBox_KH_TienNo.Text;

            return new KhachHang {
                MaKH = int.TryParse(maKH, out var parsedMaHD) ? parsedMaHD : lastMaKH + 1,
                TenKH = tenKH,
                GioiTinh = gioiTinh,
                Email = email,
                DiaChi = diaChi,
                TienNo = 0
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
                string.IsNullOrWhiteSpace(khachHang.DiaChi)
                ) {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên khách hàng, giới tính, email, địa chỉ, số điện thoại và tiền nợ\n" +
                    "trước khi thêm vào cơ sở dữ liệu.",
                    "Thiếu thông tin cần thiết",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (db!.KhachHangs.Any(kh => kh.MaKH == khachHang.MaKH)) {
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

                } else { return; }
            } else {
                db.Add(khachHang);
            }

            db!.SaveChanges();
            dataGridView_KhachHang.Refresh();

            SystemSounds.Beep.Play();
            foreach (DataGridViewRow row in dataGridView_KhachHang.Rows) {
                if (row.DataBoundItem is KhachHang rowKH &&
                    rowKH.MaKH == khachHang.MaKH) // Compare by unique key
                {
                    row.Selected = true;
                    dataGridView_KhachHang.CurrentCell = row.Cells[0];
                    break;
                }
            }

            Icon_KH_Clear_Click(sender, e);
        }
        private void Icon_KH_Xoa_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "Xoá khách hàng?\n(Sẽ không thể phục hồi được dữ liệu.)",
                "Trước khi xoá khách hàng",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                SystemSounds.Beep.Play();
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

            textBox_KH_TienNo.Enabled = isLoc_KH;

            if (!isLoc_KH) {
                dataGridView_KhachHang.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dataGridView_KhachHang.DataSource = khachHangBindingSource;
            } else {
                comboBox_KH_GioiTinh.Text = "";

                ApplyFilter_KhachHang();
                Icon_KH_Clear_Click(sender, e);
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
        private IQueryable<KhachHang> GetFilteredData_KH() {
            var filteredData = db!.KhachHangs.Local.AsQueryable();

            if (!string.IsNullOrEmpty(textBox_KH_MaKH.Text)) {
                if (int.TryParse(textBox_KH_MaKH.Text, out int maKH)) {
                    filteredData = filteredData.Where(kh => kh.MaKH == maKH);
                }
            }
            if (!string.IsNullOrEmpty(textBox_KH_TenKH.Text)) {
                filteredData = filteredData.Where(kh => kh.TenKH.Contains(textBox_KH_TenKH.Text));
            }
            if (!string.IsNullOrEmpty(comboBox_KH_GioiTinh.Text)) {
                filteredData = filteredData.Where(kh => kh.GioiTinh.Contains(comboBox_KH_GioiTinh.Text));
            }
            if (!string.IsNullOrEmpty(textBox_KH_Email.Text)) {
                filteredData = filteredData.Where(kh => kh.Email.Contains(textBox_KH_Email.Text));
            }
            if (!string.IsNullOrEmpty(textBox_KH_DiaChi.Text)) {
                filteredData = filteredData.Where(kh => kh.DiaChi.Contains(textBox_KH_DiaChi.Text));
            }
            if (!string.IsNullOrWhiteSpace(textBox_KH_TienNo.Text)) {
                try {
                    filteredData = filteredData.Where(FilterSoLuong(textBox_KH_TienNo.Text, "TienNo"));
                } catch {
                    // Ignore invalid expressions
                }
            }

            return filteredData;
        }
        private void ApplyFilter_KhachHang() {
            if (isLoc_KH && dataGridView_KhachHang != null) {
                dataGridView_KhachHang.DataSource = new BindingSource { DataSource = GetFilteredData_KH().ToList() };
            }
        }
        private void Icon_KH_Tim_Click(object sender, EventArgs e) {
            var filteredList = GetFilteredData_KH().ToList();
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
            comboBox_KH_GioiTinh.SelectedIndex = -1;
            textBox_KH_TienNo.Text = "";
        }
        private void DataGridView_KhachHang_SelectionChanged(object sender, EventArgs e) {
            if (db == null || this.IsDisposed || this.Disposing)
                return;
            if (!isLoc_KH && dataGridView_KhachHang.CurrentRow?.DataBoundItem is KhachHang khachHang) {
                SetKhachHang(khachHang);
            }
        }
        private void DataGridView_KhachHang_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            db?.SaveChanges();
        }
        private void Icon_KH_ThuTien_Click(object sender, EventArgs e) {
            if (dataGridView_KhachHang.CurrentRow?.DataBoundItem is KhachHang khachHang) {
                if (khachHang.TienNo <= 0) {
                    MessageBox.Show("Không thể thu tiền khách hàng\ndo khách hàng không có nợ.",
                        "Không thể thu tiền khách hàng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tabControl_KhachHang.SelectedTab = tabPage_PhieuThuTien;
                Icon_PTT_Clear_Click(sender, e);

                int lastMaPhieu = db!.PhieuThuTiens
                    .OrderByDescending(p => p.MaPT)
                    .FirstOrDefault()?.MaPT ?? 0;
                textBox_PTT_MaPhieu.Text = (lastMaPhieu + 1).ToString();

                textBox_PTT_MaKH.Text = khachHang.MaKH.ToString();
                textBox_PTT_SoTien.Text = khachHang.TienNo.ToString();
            }
        }
        #endregion
        #region Quản lý phiếu thu tiền
        private PhieuThuTien GetPhieuThuTien() {
            int lastMaPT = db!.PhieuThuTiens
                .OrderByDescending(p => p.MaPT)
                .FirstOrDefault()?.MaPT ?? 0;

            string maPT = textBox_PTT_MaPhieu.Text;
            string maKH = textBox_PTT_MaKH.Text;
            string ngayThu = date_PTT_NgayThu.Text;
            string soTien = textBox_PTT_SoTien.Text;

            return new PhieuThuTien {
                MaPT = int.TryParse(maPT, out var parsedMaHD) ? parsedMaHD : lastMaPT + 1,
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

                return;
            }

            if (db!.PhieuThuTiens.Any(ptt => ptt.MaPT == phieuThuTien.MaPT)) {
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

                } else { return; }

            } else {
                db.Add(phieuThuTien);
            }

            SystemSounds.Beep.Play();
            foreach (DataGridViewRow row in dataGridView_PhieuThuTien.Rows) {
                if (row.DataBoundItem is PhieuThuTien rowPTT &&
                    rowPTT.MaPT == phieuThuTien.MaPT) // Compare by unique key
                {
                    row.Selected = true;
                    dataGridView_PhieuThuTien.CurrentCell = row.Cells[0];
                    break;
                }
            }


            _ = db.SaveChanges();
            dataGridView_PhieuThuTien.Refresh();

            Icon_PTT_Clear_Click(sender, e);
        }
        private void Icon_PTT_Xoa_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "Xoá phiếu thu tiền?\n(Sẽ không thể phục hồi được dữ liệu.)",
                "Trước khi xoá phiếu thu tiền",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                SystemSounds.Beep.Play();
                // Use a HashSet to avoid duplicate row indices
                var rowsToDelete = new HashSet<int>();

                foreach (DataGridViewCell cell in dataGridView_PhieuThuTien.SelectedCells) {
                    rowsToDelete.Add(cell.RowIndex);
                }

                foreach (int rowIndex in rowsToDelete) {
                    if (dataGridView_PhieuThuTien.Rows[rowIndex].DataBoundItem is PhieuThuTien phieuThuTien) {
                        db!.PhieuThuTiens.Remove(phieuThuTien);
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
                Icon_PTT_Clear_Click(sender, e);
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
        private IQueryable<PhieuThuTien> GetFilteredData_PTT() {
            var filteredData = db!.PhieuThuTiens.Local.AsQueryable();

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
            if (!string.IsNullOrEmpty(textBox_PTT_SoTien.Text)) {
                if (double.TryParse(textBox_PTT_SoTien.Text, out double soTien)) {
                    filteredData = filteredData.Where(ptt => ptt.SoTien == soTien);
                }
            }

            DateTime from = DateTime.Parse(date_PTT_NgayThu.Text);
            DateTime to = DateTime.Parse(date_PTT_Filter.Text);
            filteredData = filteredData.Where(s => s.NgayThu >= from && s.NgayThu <= to);

            return filteredData;
        }
        private void ApplyFilter_PhieuThuTien() {
            if (isLoc_PTT && dataGridView_PhieuThuTien != null) {
                dataGridView_PhieuThuTien.DataSource = new BindingSource { DataSource = GetFilteredData_PTT().ToList() };
            }
        }
        private void Icon_PTT_Tim_Click(object sender, EventArgs e) {
            var filteredList = GetFilteredData_PTT().ToList();
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
            if (!isLoc_PTT && dataGridView_PhieuThuTien.CurrentRow?.DataBoundItem is PhieuThuTien phieuThuTien) {
                SetPhieuThuTien(phieuThuTien);
            }
        }
        private void DataGridView_PhieuThuTien_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView_PhieuThuTien.Rows.Count) {
                return; // Exit if RowIndex is invalid
            }

            if (db != null && dataGridView_PhieuThuTien.Rows[e.RowIndex].DataBoundItem is PhieuThuTien phieuThuTien) {
                if (e.ColumnIndex == 1 && !db.KhachHangs.Any(s => s.MaKH == phieuThuTien.MaKH)) {
                    MessageBox.Show($"Không tìm thấy khách hàng với mã số {phieuThuTien.MaKH}.", "Lỗi mã khách hàng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    var old = db.PhieuThuTiens.AsNoTracking().FirstOrDefault(p => p.MaPT == phieuThuTien.MaPT);
                    if (old != null) {
                        phieuThuTien.MaKH = old.MaKH;
                        dataGridView_PhieuThuTien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old.MaKH;
                    }
                }

            }

            db?.SaveChanges();
        }
        #endregion
    }
}
