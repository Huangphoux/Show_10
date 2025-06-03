using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Show10.Models;
using System.Linq.Dynamic.Core;
using System.Media;

namespace Show10.Child_Forms {
    public partial class Form_Sach : Form {
        private NhaSachContext? db;
        bool isLoc_Sach = false;
        bool isLoc_PNS = false;
        bool isLoc_HD = false;

        public Form_Sach() {
            InitializeComponent();
            DoubleBuffered = true;

            dataGridView_Sach.RowTemplate.Height = 50;
            dataGridView_PhieuNhapSach.RowTemplate.Height = 50;
            dataGridView_HoaDonBanSach.RowTemplate.Height = 50;

            string themTooltip_Text =
                "Thêm vào cơ sở dữ liệu.\n" +
                "Nếu chưa điền mã, sẽ tự động thêm mã để chống trùng lặp mã phân biệt.\n" +
                "Nếu phát hiện trùng mã, có thể ghi đè lên dữ liệu có sẵn.\n";

            ToolTip toolTip = new();
            toolTip.SetToolTip(icon_Sach_Them, themTooltip_Text);
            toolTip.SetToolTip(icon_Sach_Xoa, "Xoá khỏi cơ sở dữ liệu");
            toolTip.SetToolTip(icon_Sach_Tim, "Tìm dữ liệu đầu tiên tương ứng với các ô dữ liệu");
            toolTip.SetToolTip(icon_Sach_Loc, "Giới hạn hiển thị các dữ liệu dựa trên các điều kiện");
            toolTip.SetToolTip(icon_Sach_Clear, "Làm trống các ô dữ liệu");

            toolTip.SetToolTip(icon_PNS_Them, themTooltip_Text);
            toolTip.SetToolTip(icon_PNS_Xoa, "Xoá phiếu nhập sách khỏi cơ sở dữ liệu");
            toolTip.SetToolTip(icon_PNS_Tim, "Tìm phiếu nhập sách đầu tiên tương ứng với các ô dữ liệu");
            toolTip.SetToolTip(icon_PNS_Loc, "Giới hạn hiển thị các phiếu nhập sách dựa trên các điều kiện");
            toolTip.SetToolTip(icon_PNS_Clear, "Làm trống các ô dữ liệu phiếu nhập sách");

            toolTip.SetToolTip(icon_HD_Them, themTooltip_Text);
            toolTip.SetToolTip(icon_HD_Xoa, "Xoá hoá đơn bán sách khỏi cơ sở dữ liệu");
            toolTip.SetToolTip(icon_HD_Tim, "Tìm hoá đơn bán sách đầu tiên tương ứng với các ô dữ liệu");
            toolTip.SetToolTip(icon_HD_Loc, "Giới hạn hiển thị các hoá đơn bán sách dựa trên các điều kiện");
            toolTip.SetToolTip(icon_HD_Clear, "Làm trống các ô dữ liệu hoá đơn bán sách");
            toolTip.SetToolTip(icon_HD_Tinh, "Tính tổng tiền, số tiền trả và còn lại cho hoá đơn bán sách");


            string soLuongToolTip =
                "Khi ở chế độ LỌC, sử dụng các biểu thức sau để giới hạn kết quả:\n" +
                "- Miền giá trị (x đại diện cho thuộc tính): 6 < x < 9, 4 <= x <= 20, 310 < x <= 105\n" +
                "- Tìm đúng số lượng: 31, 01, 05\n" +
                "- Giới hạn: > 69, <= 420, = 310, != 105";

            toolTip.SetToolTip(textBox_Sach_SoLuong, soLuongToolTip);

            toolTip.SetToolTip(textBox_PNS_SoLuong, soLuongToolTip);
            toolTip.SetToolTip(textBox_PNS_GiaNhap, soLuongToolTip);

            toolTip.SetToolTip(textBox_HD_SoLuong, soLuongToolTip);
            toolTip.SetToolTip(textBox_HD_SoTienTra, soLuongToolTip);
            toolTip.SetToolTip(textBox_HD_TongTien, soLuongToolTip);
            toolTip.SetToolTip(textBox_HD_ConLai, soLuongToolTip);
            toolTip.SetToolTip(textBox_HD_GiaBan, soLuongToolTip);
        }
        private void Form_Sach_Load(object sender, EventArgs e) {
            db = new NhaSachContext();

            // Dòng dưới sẽ luôn xoá DB mỗi khi load form
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            KiemTraSoLuong();

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
        private void KiemTraSoLuong() {
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

        #region Quản lý sách
        private void TabControl_Sach_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl_Sach.SelectedTab == tabPage_Sach) {
                KiemTraSoLuong();
            }
        }
        private Sach GetSach() {
            int lastMaSach = db!.Sachs
                .OrderByDescending(p => p.MaSach)
                .FirstOrDefault()?.MaSach ?? 0;

            string maSach = textBox_Sach_MaSach.Text;
            string tenSach = textBox_Sach_TenSach.Text;
            string soLuong = textBox_Sach_SoLuong.Text;
            string tacGia = textBox_Sach_TacGia.Text;
            string theLoai = textBox_Sach_TheLoai.Text;

            return new Sach {
                MaSach = int.TryParse(maSach, out var parsedMaHD) ? parsedMaHD : lastMaSach + 1,
                TenSach = tenSach,
                SoLuong = 0,
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
                return;
            }

            if (db!.Sachs.Any(s => s.MaSach == sach.MaSach)) {
                var result = MessageBox.Show(
                    $"Đã có sách với mã số {sach.MaSach}.\n" +
                    "Bạn có muốn ghi đè thông tin có sẵn của sách?",
                    "Ghi đè thông tin có sẵn của sách",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {
                    var existingSach = db.Sachs.First(s => s.MaSach == sach.MaSach);

                    existingSach.TenSach = sach.TenSach;
                    existingSach.TacGia = sach.TacGia;
                    existingSach.TheLoai = sach.TheLoai;
                } else {
                    return;
                }
            } else {
                db.Add(sach);
                Icon_Sach_Clear_Click(sender, e);
            }

            SystemSounds.Beep.Play();

            db.SaveChanges();
            dataGridView_Sach.Refresh();

            foreach (DataGridViewRow row in dataGridView_Sach.Rows) {
                if (row.DataBoundItem is Sach rowSach &&
                    rowSach.MaSach == sach.MaSach) // Compare by unique key
                {
                    row.Selected = true;
                    dataGridView_Sach.CurrentCell = row.Cells[0];
                    break;
                }
            }

        }
        private void Icon_Sach_Xoa_Click(object sender, EventArgs e) {
            // Use a HashSet to avoid duplicate row indices
            var rowsToDelete = new HashSet<int>();
            var sachsToDelete = new HashSet<int>();

            foreach (DataGridViewCell cell in dataGridView_Sach.SelectedCells) {
                rowsToDelete.Add(cell.RowIndex);

                if (dataGridView_Sach.Rows[cell.RowIndex].DataBoundItem is Sach sach) {
                    sachsToDelete.Add(sach.MaSach);
                }
            }

            bool notInPNS = true;
            bool notInHD = true;

            foreach (var ma in sachsToDelete) {
                notInPNS = notInPNS && !db!.PhieuNhapSachs.Any(p => p.MaSach == ma);
                notInHD = notInHD && !db!.HoaDonBanSachs.Any(p => p.MaSach == ma);
            }

            if (!notInHD && !notInPNS) {
                MessageBox.Show("Mã sách có trong phiếu nhập sách hoặc hoá đơn bán sách.\n" +
                    "Không thể xoá sách !!!",
                    "Không thể xoá sách !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show(
                "Xoá sách?\n(Sẽ không thể phục hồi được dữ liệu.)",
                "Chuẩn bị xoá sách",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                SystemSounds.Beep.Play();

                foreach (int rowIndex in rowsToDelete) {
                    if (dataGridView_Sach.Rows[rowIndex].DataBoundItem is Sach sach) {
                        db!.Sachs.Remove(sach);
                    }
                }

                db!.SaveChanges();
                dataGridView_Sach.Refresh();
            }
        }
        private void Icon_Sach_Loc_Click(object sender, EventArgs e) {
            icon_Sach_Loc.IconChar = (icon_Sach_Loc.IconChar == IconChar.Filter) ? IconChar.FilterCircleXmark : IconChar.Filter;
            isLoc_Sach = !isLoc_Sach;

            List<Button> icon_Sach = [icon_Sach_Them, icon_Sach_Xoa, icon_Sach_Tim];

            icon_Sach.ForEach(icon => icon.Enabled = !isLoc_Sach);

            textBox_Sach_SoLuong.Enabled = isLoc_Sach;

            if (!isLoc_Sach) {
                dataGridView_Sach.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dataGridView_Sach.DataSource = sachBindingSource;
            } else {
                ApplyFilter_Sach();
                Icon_Sach_Clear_Click(sender, e);
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
        private void TextBox_Sach_SoLuong_TextChanged(object sender, EventArgs e) {
            ApplyFilter_Sach();
        }
        #endregion
        private IQueryable<Sach> GetFilteredData_Sach() {
            var filteredData = db!.Sachs.Local.AsQueryable();

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
            if (!string.IsNullOrWhiteSpace(textBox_Sach_SoLuong.Text)) {
                try {
                    filteredData = filteredData.Where(FilterSoLuong(textBox_Sach_SoLuong.Text, "SoLuong"));
                } catch {
                    // Ignore invalid expressions
                }
            }

            return filteredData;
        }
        private void ApplyFilter_Sach() {
            if (isLoc_Sach && dataGridView_Sach != null) {
                dataGridView_Sach.DataSource = new BindingSource { DataSource = GetFilteredData_Sach().ToList() };
            }
        }
        private void Icon_Sach_Tim_Click(object sender, EventArgs e) {
            var filteredList = GetFilteredData_Sach().ToList();

            if (filteredList.Count == 0)
                return;

            var firstSach = filteredList[0];

            foreach (DataGridViewRow row in dataGridView_Sach.Rows) {
                if (row.DataBoundItem is Sach rowSach &&
                    rowSach.MaSach == firstSach.MaSach) // Compare by unique key
                {
                    row.Selected = true;
                    dataGridView_Sach.CurrentCell = row.Cells[0];
                    SetSach(rowSach);
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
            if (!isLoc_Sach && dataGridView_Sach.CurrentRow?.DataBoundItem is Sach sach) {
                SetSach(sach);
            }
        }
        private void DataGridView_Sach_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            db?.SaveChanges();
        }
        private void Icon_Sach_Nhap_Click(object sender, EventArgs e) {
            if (dataGridView_Sach.CurrentRow?.DataBoundItem is Sach sach) {

                if (sach.SoLuong >= Properties.Settings.Default.maxSLSach) {
                    MessageBox.Show("Không thể nhập sách do đã đạt số lượng tồn kho cho phép.",
                        "Không thể nhập sách",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tabControl_Sach.SelectedTab = tabPage_PhieuNhapSach;
                Icon_PNS_Clear_Click(sender, e);

                int lastMaPhieu = db.PhieuNhapSachs
                    .OrderByDescending(p => p.MaPN)
                    .FirstOrDefault()?.MaPN ?? 0;
                textBox_PNS_MaPhieu.Text = (lastMaPhieu + 1).ToString();

                textBox_PNS_MaSach.Text = sach.MaSach.ToString();
            }
        }
        private void Icon_Sach_Ban_Click(object sender, EventArgs e) {
            if (dataGridView_Sach.CurrentRow?.DataBoundItem is Sach sach) {
                if (sach.SoLuong == 0) {
                    MessageBox.Show(
                        "Sách này chưa được nhập vào kho nên hiện tại chưa thể bán.\n" +
                        "Vui lòng nhập sách trước khi tiến hành bán sách.",
                        "Chưa có sách trong kho",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                tabControl_Sach.SelectedTab = tabPage_HoaDonBanSach;
                Icon_HD_Clear_Click(sender, e);

                int lastMaHD = db!.HoaDonBanSachs
                    .OrderByDescending(hd => hd.MaHD)
                    .FirstOrDefault()?.MaHD ?? 0;

                textBox_HD_MaHD.Text = (lastMaHD + 1).ToString();
                textBox_HD_MaSach.Text = sach.MaSach.ToString();
                textBox_HD_GiaBan.Text = GetGiaBan(sach.MaSach).ToString();
            }
        }

        #endregion
        #region Quản lý phiếu nhập sách
        private PhieuNhapSach GetPhieuNhapSach() {
            int lastMaPNS = db!.PhieuNhapSachs
                .OrderByDescending(p => p.MaPN)
                .FirstOrDefault()?.MaPN ?? 0;

            string maPN = textBox_PNS_MaPhieu.Text;
            string maSach = textBox_PNS_MaSach.Text;
            string soLuong = textBox_PNS_SoLuong.Text;
            string giaNhap = textBox_PNS_GiaNhap.Text;
            string ngayNhap = date_PNS_NgayNhap.Text;
            string nhaCungCap = textBox_PNS_NhaCungCap.Text;

            return new PhieuNhapSach {
                MaPN = int.TryParse(maPN, out var parsedMaHD) ? parsedMaHD : lastMaPNS + 1,
                MaSach = int.Parse(maSach),
                GiaNhap = double.Parse(giaNhap),
                SoLuong = int.Parse(soLuong),
                NgayNhap = DateTime.Parse(ngayNhap),
                NhaCungCap = nhaCungCap
            };
        }
        private void SetPhieuNhapSach(PhieuNhapSach phieu) {
            textBox_PNS_MaPhieu.Text = phieu.MaPN.ToString();
            textBox_PNS_MaSach.Text = phieu.MaSach.ToString();
            textBox_PNS_SoLuong.Text = phieu.SoLuong.ToString();
            textBox_PNS_GiaNhap.Text = phieu.GiaNhap.ToString();
            textBox_PNS_NhaCungCap.Text = phieu.NhaCungCap.ToString();
            date_PNS_NgayNhap.Text = phieu.NgayNhap.ToShortDateString();
        }
        private void Icon_PNS_Them_Click(object sender, EventArgs e) {
            PhieuNhapSach phieu = GetPhieuNhapSach();

            if (!db!.Sachs.Any(sach => sach.MaSach == phieu.MaSach)) {
                MessageBox.Show(
                    $"Không tìm thấy sách với mã số {phieu.MaSach}.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            int minNhap = Properties.Settings.Default.minNhap;
            if (phieu.SoLuong < minNhap) {
                MessageBox.Show(
                    $"Số lượng nhập yêu cầu ít nhất {minNhap} quyển.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            int maxSLSach = Properties.Settings.Default.maxSLSach;
            if (db!.Sachs.First(tk => tk.MaSach == phieu.MaSach).SoLuong > maxSLSach) {
                MessageBox.Show(
                    $"Không được nhập sách nếu sách có số lượng tồn kho trên {maxSLSach} quyển.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_PNS_MaSach.Text) ||
                string.IsNullOrWhiteSpace(textBox_PNS_SoLuong.Text) ||
                string.IsNullOrWhiteSpace(textBox_PNS_GiaNhap.Text) ||
                string.IsNullOrWhiteSpace(textBox_PNS_NhaCungCap.Text)
                ) {
                MessageBox.Show(
                    "Nhập đủ mã sách, số lượng, giá nhập, và nhà cung cấp\n" +
                    "trước khi thêm vào cơ sở dữ liệu.",
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
                } else {
                    return;
                }
            } else {
                db.Add(phieu);
            }

            SystemSounds.Beep.Play();

            db.SaveChanges();
            dataGridView_PhieuNhapSach.Refresh();

            foreach (DataGridViewRow row in dataGridView_PhieuNhapSach.Rows) {
                if (row.DataBoundItem is PhieuNhapSach rowPNS &&
                    rowPNS.MaPN == phieu.MaPN) // Compare by unique key
                {
                    row.Selected = true;
                    dataGridView_PhieuNhapSach.CurrentCell = row.Cells[0];
                    break;
                }
            }

            Icon_PNS_Clear_Click(sender, e);

        }
        private void Icon_PNS_Xoa_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "Xoá phiếu nhập sách?\n(Sẽ không thể phục hồi được dữ liệu.)",
                "Trước khi xoá phiếu nhập",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                SystemSounds.Beep.Play();
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
            textBox_PNS_NhaCungCap.Text = "";
            date_PNS_NgayNhap.Text = DateTime.Now.ToShortDateString();
        }
        private void Icon_PNS_Loc_Click(object sender, EventArgs e) {
            icon_PNS_Loc.IconChar = (icon_PNS_Loc.IconChar == IconChar.Filter) ? IconChar.FilterCircleXmark : IconChar.Filter;
            isLoc_PNS = !isLoc_PNS;

            List<Button> icon_PNS = [icon_PNS_Them, icon_PNS_Xoa, icon_PNS_Tim];

            icon_PNS.ForEach(icon => icon.Enabled = !isLoc_PNS);

            date_PNS_Filter.Enabled = isLoc_PNS;

            if (!isLoc_PNS) {
                dataGridView_PhieuNhapSach.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dataGridView_PhieuNhapSach.DataSource = phieuNhapSachBindingSource;
            } else {
                ApplyFilter_PhieuNhapSach();
                Icon_PNS_Clear_Click(sender, e);

                date_PNS_NgayNhap.Text = db!.PhieuNhapSachs
                                                 .OrderBy(s => s.NgayNhap)
                                                 .FirstOrDefault()?.NgayNhap.ToShortDateString();
                date_PNS_Filter.Text = db!.PhieuNhapSachs
                                                .OrderByDescending(s => s.NgayNhap)
                                                .FirstOrDefault()?.NgayNhap.ToShortDateString();
            }
        }
        private IQueryable<PhieuNhapSach> GetFilteredData_PNS() {
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

            if (!string.IsNullOrWhiteSpace(textBox_PNS_SoLuong.Text)) {
                try {
                    filteredData = filteredData.Where(FilterSoLuong(textBox_PNS_SoLuong.Text, "SoLuong"));
                } catch {
                    // Ignore invalid expressions
                }
            }
            if (!string.IsNullOrWhiteSpace(textBox_PNS_GiaNhap.Text)) {
                try {
                    filteredData = filteredData.Where(FilterSoLuong(textBox_PNS_GiaNhap.Text, "GiaNhap"));
                } catch {
                    // Ignore invalid expressions
                }
            }
            if (!string.IsNullOrEmpty(textBox_PNS_NhaCungCap.Text)) {
                filteredData = filteredData.Where(s => s.NhaCungCap.Contains(textBox_PNS_NhaCungCap.Text));
            }

            DateTime from = DateTime.Parse(date_PNS_NgayNhap.Text);
            DateTime to = DateTime.Parse(date_PNS_Filter.Text);
            filteredData = filteredData.Where(s => s.NgayNhap >= from && s.NgayNhap <= to);

            return filteredData;
        }
        private void ApplyFilter_PhieuNhapSach() {
            if (isLoc_PNS && dataGridView_PhieuNhapSach != null) {
                dataGridView_PhieuNhapSach.DataSource = new BindingSource { DataSource = GetFilteredData_PNS().ToList() };
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
        private void Date_PNS_Filter_ValueChanged(object sender, EventArgs e) {
            ApplyFilter_PhieuNhapSach();
        }
        private void TextBox_PNS_NhaCungCap_TextChanged(object sender, EventArgs e) {
            ApplyFilter_PhieuNhapSach();
        }
        #endregion
        private void Icon_PNS_Tim_Click(object sender, EventArgs e) {
            var filteredList = GetFilteredData_PNS().ToList();
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
            if (!isLoc_PNS && dataGridView_PhieuNhapSach.CurrentRow?.DataBoundItem is PhieuNhapSach phieuNhapSachh) {
                SetPhieuNhapSach(phieuNhapSachh);
            }
        }
        private void DataGridView_PhieuNhapSach_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView_PhieuNhapSach.Rows.Count) {
                return; // Exit if RowIndex is invalid
            }

            if (e.ColumnIndex == 1 && dataGridView_PhieuNhapSach.Rows[e.RowIndex].DataBoundItem is PhieuNhapSach phieu) {
                if (db != null && !db.Sachs.Any(s => s.MaSach == phieu.MaSach)) {
                    MessageBox.Show($"Không tìm thấy sách với mã số {phieu.MaSach}.", "Lỗi mã sách", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    var oldPhieu = db.PhieuNhapSachs.AsNoTracking().FirstOrDefault(p => p.MaPN == phieu.MaPN);
                    if (oldPhieu != null) {
                        phieu.MaSach = oldPhieu.MaSach;
                        dataGridView_PhieuNhapSach.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldPhieu.MaSach;
                    }
                }
            }

            db?.SaveChanges();
        }
        #endregion
        #region Quản lý hoá đơn bán sách
        private double GetGiaBan(int maSach) {
            double giaBan = db!.PhieuNhapSachs
                                        .Where(p => p.MaSach == maSach)
                                        .OrderByDescending(p => p.NgayNhap) // Assuming NgayNhap determines the order
                                        .FirstOrDefault()?.GiaNhap * 1.05 ?? 0;
            return giaBan;
        }
        private HoaDonBanSach GetHoaDonBanSach() {
            int lastMaHD = db!.HoaDonBanSachs
                .OrderByDescending(p => p.MaHD)
                .FirstOrDefault()?.MaHD ?? 0;

            string maHD = textBox_HD_MaHD.Text;
            string maKH = textBox_HD_MaKH.Text;
            string maSach = textBox_HD_MaSach.Text;
            string soLuong = textBox_HD_SoLuong.Text;
            string soTienTra = textBox_HD_SoTienTra.Text;
            string ngayBan = date_HD_NgayBan.Text;

            double parsedSoTienTra = double.TryParse(soTienTra, out var parsed) ? parsed : 0;

            double giaBan = GetGiaBan(int.Parse(maSach));
            double tongTien = int.Parse(soLuong) * giaBan;
            double conLai = tongTien - parsedSoTienTra;

            return new HoaDonBanSach {
                MaHD = int.TryParse(maHD, out var parsedMaHD) ? parsedMaHD : lastMaHD + 1,
                MaKH = int.Parse(maKH),
                MaSach = int.Parse(maSach),
                SoLuong = int.Parse(soLuong),
                GiaBan = giaBan,
                NgayHD = DateTime.Parse(ngayBan),
                TongTien = tongTien,
                SoTienTra = parsedSoTienTra,
                ConLai = conLai
            };
        }
        private void SetHoaDonBanSach(HoaDonBanSach hoaDon) {
            textBox_HD_MaHD.Text = hoaDon.MaHD.ToString();
            textBox_HD_MaKH.Text = hoaDon.MaKH.ToString();
            textBox_HD_MaSach.Text = hoaDon.MaSach.ToString();
            textBox_HD_SoLuong.Text = hoaDon.SoLuong.ToString();
            textBox_HD_GiaBan.Text = hoaDon.GiaBan.ToString();
            textBox_HD_TongTien.Text = hoaDon.TongTien.ToString();
            textBox_HD_SoTienTra.Text = hoaDon.SoTienTra.ToString();
            textBox_HD_ConLai.Text = hoaDon.ConLai.ToString();
            date_HD_NgayBan.Text = hoaDon.NgayHD.ToShortDateString();
        }
        private void Icon_HD_Them_Click(object sender, EventArgs e) {
            HoaDonBanSach hoaDon = GetHoaDonBanSach();

            // Không tìm thấy mã sách
            if (!db!.Sachs.Any(sach => sach.MaSach == hoaDon.MaSach)) {
                MessageBox.Show(
                    $"Không tồn tại sách với mã số {hoaDon.MaSach}.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            } else {
                if (db!.Sachs.First(sach => sach.MaSach == hoaDon.MaSach).SoLuong == 0) {
                    MessageBox.Show(
                        "Sách này chưa được nhập vào kho nên hiện tại chưa thể bán.\n" +
                        "Vui lòng nhập sách trước khi tiến hành bán sách.",
                        "Chưa có sách trong kho",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
            // Không tìm thấy mã KH
            if (!db!.KhachHangs.Any(kh => kh.MaKH == hoaDon.MaKH)) {
                MessageBox.Show(
                    $"Không tồn tại khách hàng với mã số {hoaDon.MaKH}.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            // Không bán cho khách hàng nợ vượt mức quy định
            double maxNo = Properties.Settings.Default.maxNo;
            var khachHang = db.KhachHangs.First(p => p.MaKH == hoaDon.MaKH);
            if (khachHang.TienNo > maxNo) {
                MessageBox.Show(
                    $"Không thể bán sách cho khách hàng mã số {hoaDon.MaKH}\n" +
                    $"vì khách hàng đang nợ {khachHang.TienNo}, quá mức tối đa của cửa hàng là {maxNo}.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            // Đảm bảo tồn sách không dưới mức quy định
            int minSLSach = Properties.Settings.Default.minSLSach;
            var sach = db!.Sachs.First(s => s.MaSach == hoaDon.MaSach);
            if (sach.SoLuong - hoaDon.SoLuong < minSLSach) {
                MessageBox.Show(
                    $"Không thể bán sách này do số lượng tồn kho sẽ chỉ còn\n" +
                    $"{sach.SoLuong} (số lượng tồn) - {hoaDon.SoLuong} (số lượng bán) = {sach.SoLuong - hoaDon.SoLuong} quyển,\n" +
                    $"dưới mức quy định của cửa hàng là {minSLSach}.",
                    null, MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_HD_MaKH.Text) ||
                string.IsNullOrWhiteSpace(textBox_HD_MaSach.Text) ||
                string.IsNullOrWhiteSpace(textBox_HD_SoLuong.Text) ||
                string.IsNullOrWhiteSpace(textBox_HD_SoTienTra.Text)) {
                MessageBox.Show(
                    "Nhập đủ mã khách hàng, mã sách, số lượng và số tiền trả\n" +
                    "trước khi thêm vào cơ sở dữ liệu.",
                    "Chưa điền đầy đủ các thông tin cần thiết",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            } else if (db!.HoaDonBanSachs.Any(hd => hd.MaHD == hoaDon.MaHD)) {
                var result = MessageBox.Show(
                    "Tồn tại hoá đơn với mã hoá đơn này.\n" +
                    "Ghi đè thông tin của hoá đơn?",
                    "Ghi đè thông tin của hoá đơn",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {
                    var existingHD = db.HoaDonBanSachs.First(hd => hd.MaHD == hoaDon.MaHD);

                    // Cộng lại số lượng sách cũ trước khi trừ số mới
                    // chưa hiểu lắm phần này...
                    var sachCu = db.Sachs.First(s => s.MaSach == existingHD.MaSach);
                    sachCu.SoLuong += existingHD.SoLuong;

                    existingHD.MaKH = hoaDon.MaKH;
                    existingHD.MaSach = hoaDon.MaSach;
                    existingHD.SoLuong = hoaDon.SoLuong;
                    existingHD.GiaBan = hoaDon.GiaBan;
                    existingHD.NgayHD = hoaDon.NgayHD;
                } else { return; }
            } else {
                db.Add(hoaDon);

                var khacHang = db!.KhachHangs.First(s => s.MaKH == hoaDon.MaKH);
                khachHang.TienNo += hoaDon.ConLai;
            }

            sach.SoLuong -= hoaDon.SoLuong;

            SystemSounds.Beep.Play();

            db.SaveChanges();
            dataGridView_HoaDonBanSach.Refresh();

            foreach (DataGridViewRow row in dataGridView_HoaDonBanSach.Rows) {
                if (row.DataBoundItem is HoaDonBanSach rowHD &&
                    rowHD.MaHD == hoaDon.MaHD) // Compare by unique key
                {
                    row.Selected = true;
                    dataGridView_HoaDonBanSach.CurrentCell = row.Cells[0];
                    break;
                }
            }

            textBox_HD_MaHD.Text = "";
            textBox_HD_MaKH.Text = "";
            textBox_HD_MaSach.Text = "";
            textBox_HD_SoLuong.Text = "";
            textBox_HD_GiaBan.Text = "";
            date_HD_NgayBan.Text = DateTime.Now.ToShortDateString();
        }
        private void Icon_HD_Xoa_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "Xoá hoá đơn bán sách?\n(Sẽ không thể phục hồi được dữ liệu.)",
                "Trước khi xoá hoá đơn",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                SystemSounds.Beep.Play();
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
            textBox_HD_SoTienTra.Text = "";
            textBox_HD_TongTien.Text = "";
            textBox_HD_ConLai.Text = "";
        }
        private void Icon_HD_Loc_Click(object sender, EventArgs e) {
            icon_HD_Loc.IconChar = (icon_HD_Loc.IconChar == IconChar.Filter) ? IconChar.FilterCircleXmark : IconChar.Filter;
            isLoc_HD = !isLoc_HD;

            List<Button> icon_HD = [icon_HD_Them, icon_HD_Xoa, icon_HD_Tim];

            icon_HD.ForEach(icon => icon.Enabled = !isLoc_HD);

            date_HD_Filter.Enabled = isLoc_HD;
            textBox_HD_GiaBan.Enabled = isLoc_HD;
            textBox_HD_TongTien.Enabled = isLoc_HD;
            textBox_HD_ConLai.Enabled = isLoc_HD;

            if (!isLoc_HD) {
                dataGridView_HoaDonBanSach.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dataGridView_HoaDonBanSach.DataSource = hoaDonBanSachBindingSource;
            } else {
                ApplyFilter_HoaDonBanSach();
                Icon_HD_Clear_Click(sender, e);

                date_HD_NgayBan.Text = db!.HoaDonBanSachs
                                                 .OrderBy(s => s.NgayHD)
                                                 .FirstOrDefault()?.NgayHD.ToShortDateString();
                date_HD_Filter.Text = db!.HoaDonBanSachs
                                                .OrderByDescending(s => s.NgayHD)
                                                .FirstOrDefault()?.NgayHD.ToShortDateString();
            }
        }
        private IQueryable<HoaDonBanSach> GetFilteredData_HD() {
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
                try {
                    filteredData = filteredData.Where(FilterSoLuong(textBox_HD_SoLuong.Text, "SoLuong"));
                } catch {
                    // Ignore invalid expressions
                }
            }
            if (!string.IsNullOrEmpty(textBox_HD_GiaBan.Text)) {
                try {
                    filteredData = filteredData.Where(FilterSoLuong(textBox_HD_GiaBan.Text, "GiaBan"));
                } catch {
                    // Ignore invalid expressions
                }
            }
            if (!string.IsNullOrEmpty(textBox_HD_SoTienTra.Text)) {
                try {
                    filteredData = filteredData.Where(FilterSoLuong(textBox_HD_SoTienTra.Text, "SoTienTra"));
                } catch {
                    // Ignore invalid expressions
                }
            }
            if (!string.IsNullOrEmpty(textBox_HD_TongTien.Text)) {
                try {
                    filteredData = filteredData.Where(FilterSoLuong(textBox_HD_TongTien.Text, "TongTien"));
                } catch {
                    // Ignore invalid expressions
                }
            }
            if (!string.IsNullOrEmpty(textBox_HD_ConLai.Text)) {
                try {
                    filteredData = filteredData.Where(FilterSoLuong(textBox_HD_ConLai.Text, "ConLai"));
                } catch {
                    // Ignore invalid expressions
                }
            }

            DateTime from = DateTime.Parse(date_HD_NgayBan.Text);
            DateTime to = DateTime.Parse(date_HD_Filter.Text);
            filteredData = filteredData.Where(s => s.NgayHD >= from && s.NgayHD <= to);

            return filteredData;
        }
        private void ApplyFilter_HoaDonBanSach() {
            if (isLoc_HD && dataGridView_HoaDonBanSach != null) {
                dataGridView_HoaDonBanSach.DataSource = new BindingSource { DataSource = GetFilteredData_HD().ToList() };
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
        private void TextBox_HD_SoTienTra_TextChanged(object sender, EventArgs e) {
            ApplyFilter_HoaDonBanSach();
        }
        private void TextBox_HD_TongTien_TextChanged(object sender, EventArgs e) {
            ApplyFilter_HoaDonBanSach();
        }
        private void TextBox_HD_ConLai_TextChanged(object sender, EventArgs e) {
            ApplyFilter_HoaDonBanSach();
        }
        private void Date_HD_Filter_ValueChanged(object sender, EventArgs e) {
            ApplyFilter_HoaDonBanSach();
        }
        #endregion
        private void Icon_HD_Tim_Click(object sender, EventArgs e) {
            var filteredList = GetFilteredData_HD().ToList();
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
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView_PhieuNhapSach.Rows.Count) {
                return; // Exit if RowIndex is invalid
            }

            if (db != null && dataGridView_HoaDonBanSach.Rows[e.RowIndex].DataBoundItem is HoaDonBanSach hoadon) {
                if (e.ColumnIndex == 1 && !db.KhachHangs.Any(s => s.MaKH == hoadon.MaKH)) {
                    MessageBox.Show($"Không tìm thấy khách hàng với mã số {hoadon.MaKH}.", "Lỗi mã khách hàng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    var old = db.HoaDonBanSachs.AsNoTracking().FirstOrDefault(p => p.MaHD == hoadon.MaHD);
                    if (old != null) {
                        hoadon.MaKH = old.MaKH;
                        dataGridView_PhieuNhapSach.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old.MaKH;
                    }
                }

                if (e.ColumnIndex == 2 && !db.Sachs.Any(s => s.MaSach == hoadon.MaSach)) {
                    MessageBox.Show($"Không tìm thấy sách với mã số {hoadon.MaSach}.", "Lỗi mã sách",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    var old = db.HoaDonBanSachs.AsNoTracking().FirstOrDefault(p => p.MaHD == hoadon.MaHD);
                    if (old != null) {
                        hoadon.MaSach = old.MaSach;
                        dataGridView_PhieuNhapSach.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = old.MaSach;
                    }
                }
            }

            db?.SaveChanges();
        }
        private void DataGridView_HoaDonBanSach_SelectionChanged(object sender, EventArgs e) {
            if (db == null || db is IDisposable { } && (this.IsDisposed || this.Disposing))
                return;

            if (!isLoc_HD && dataGridView_HoaDonBanSach.CurrentRow != null) {
                var maHD = dataGridView_HoaDonBanSach.CurrentRow.Cells[0].Value?.ToString() ?? "";
                var maKH = dataGridView_HoaDonBanSach.CurrentRow.Cells[1].Value?.ToString() ?? "";
                var maSach = dataGridView_HoaDonBanSach.CurrentRow.Cells[2].Value?.ToString() ?? "";
                var soLuong = dataGridView_HoaDonBanSach.CurrentRow.Cells[3].Value?.ToString() ?? "";
                var giaBan = dataGridView_HoaDonBanSach.CurrentRow.Cells[4].Value?.ToString() ?? "";
                var tongTien = dataGridView_HoaDonBanSach.CurrentRow.Cells[5].Value?.ToString() ?? "";
                var soTienTra = dataGridView_HoaDonBanSach.CurrentRow.Cells[6].Value?.ToString() ?? "";
                var conLai = dataGridView_HoaDonBanSach.CurrentRow.Cells[7].Value?.ToString() ?? "";
                var ngayHD = dataGridView_HoaDonBanSach.CurrentRow.Cells[8].Value?.ToString() ?? "";

                SetHoaDonBanSach(new HoaDonBanSach {
                    MaHD = int.TryParse(maHD, out var _maHD) ? _maHD : 0,
                    MaKH = int.TryParse(maKH, out var _maKH) ? _maKH : 0,
                    MaSach = int.TryParse(maSach, out var _maSach) ? _maSach : 0,
                    SoLuong = int.TryParse(soLuong, out var _soLuong) ? _soLuong : 0,
                    GiaBan = double.TryParse(giaBan, out var _giaBan) ? _giaBan : 0,
                    TongTien = double.TryParse(tongTien, out var _tongTien) ? _tongTien : 0,
                    SoTienTra = double.TryParse(soTienTra, out var _soTienTra) ? _soTienTra : 0,
                    ConLai = double.TryParse(conLai, out var _conLai) ? _conLai : 0,
                    NgayHD = DateTime.TryParse(ngayHD, out var _ngayHD) ? _ngayHD : DateTime.Now
                });
            }
        }
        private void Icon_HD_Tinh_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBox_HD_MaSach.Text)) {
                MessageBox.Show(
                    "Nhập mã sách trước khi tính các số liệu.",
                    "Chưa điền đầy đủ các thông tin cần thiết",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            int maSach = int.Parse(textBox_HD_MaSach.Text);

            if (db!.Sachs.First(s => s.MaSach == maSach).SoLuong == 0) {
                MessageBox.Show(
                    "Sách này chưa được nhập vào kho nên hiện tại chưa thể bán.\n" +
                    "Vui lòng nhập sách trước khi tiến hành bán sách.",
                    "Chưa có sách trong kho",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_HD_SoLuong.Text) ||
                string.IsNullOrWhiteSpace(textBox_HD_MaSach.Text)) {
                MessageBox.Show(
                    "Nhập đủ mã sách và số lượng trước khi tính các số liệu.",
                    "Chưa điền đầy đủ các thông tin cần thiết",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            int soLuong = int.Parse(textBox_HD_SoLuong.Text);
            double giaBan = GetGiaBan(int.Parse(textBox_HD_MaSach.Text));
            double soTienTra = double.TryParse(textBox_HD_SoTienTra.Text, out var parsed) ? parsed : 0;
            double conLai = double.Parse(textBox_HD_TongTien.Text) - soTienTra;

            if (conLai < 0) {
                textBox_HD_SoTienTra.Text = textBox_HD_TongTien.Text;
                MessageBox.Show($"Số tiền trả lại cho khách hàng: {-conLai} đồng.", "Trả tiền thừa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                conLai = 0;
            }

            textBox_HD_GiaBan.Text = giaBan.ToString();
            textBox_HD_TongTien.Text = (soLuong * giaBan).ToString();
            textBox_HD_ConLai.Text = conLai.ToString();
        }
        private void Icon_DemLenTren_Click(object sender, EventArgs e) {
            textBox_HD_SoTienTra.Text = textBox_HD_ConLai.Text;
        }
        #endregion

    }
}
