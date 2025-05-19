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

            comboBox_KH_GioiTinh.SelectedIndex = 0;
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
                string.IsNullOrWhiteSpace(textBox_KH_TienNo.Text) ||
                string.IsNullOrWhiteSpace(textBox_KH_SDT.Text)
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
    }
}
