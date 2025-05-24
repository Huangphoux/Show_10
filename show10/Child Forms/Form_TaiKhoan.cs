using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Show10.Models;

namespace Show10.Child_Forms {
    public partial class Form_TaiKhoan : Form {
        private NhaSachContext? db;
        bool isLoc = false;
        public Form_TaiKhoan() {
            InitializeComponent();
            DoubleBuffered = true;

            dataGridView_TaiKhoan.RowTemplate.Height = 50;
        }
        private void Form_Account_Load(object sender, EventArgs e) {
            db = new NhaSachContext();

            // Dòng dưới sẽ luôn xoá DB mỗi khi load form
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.TaiKhoans.Load();

            taiKhoanBindingSource.DataSource = db.TaiKhoans.Local.ToBindingList();

            dataGridView_TaiKhoan.Refresh();
        }
        private void Form_Account_FormClosing(object sender, FormClosingEventArgs e) {
            db?.Dispose();
            db = null;
        }
        private TaiKhoan GetTaiKhoan() {
            string tenTK = textBox_TK_TenTK.Text;
            string matKhau = textBox_TK_MatKhau.Text;
            string hoTen = textBox_TK_HoTen.Text;
            string vaiTro = checkBox_TK_QTV.Checked ? "admin" : "user";

            return new TaiKhoan { TenTK = tenTK, HoTen = hoTen, MatKhau = matKhau, VaiTro = vaiTro };
        }
        private void SetTaiKhoan(TaiKhoan taiKhoan) {
            textBox_TK_TenTK.Text = taiKhoan.TenTK;
            textBox_TK_MatKhau.Text = taiKhoan.MatKhau;
            textBox_TK_HoTen.Text = taiKhoan.HoTen;
            checkBox_TK_QTV.Checked = taiKhoan.VaiTro == "admin";
        }

        #region Detect changes
        private void TextBox_TK_TenTK_TextChanged(object sender, EventArgs e) {
            ApplyFilters();
        }

        private void TextBox_TK_MatKhau_TextChanged(object sender, EventArgs e) {
            ApplyFilters();
        }

        private void TextBox_TK_HoTen_TextChanged(object sender, EventArgs e) {
            ApplyFilters();
        }

        private void CheckBox_TK_QTV_CheckStateChanged(object sender, EventArgs e) {
            ApplyFilters();
        }
        #endregion
        private void ApplyFilters() {
            if (isLoc && dataGridView_TaiKhoan != null) {
                var filteredData = db.TaiKhoans.Local.AsQueryable();

                if (!string.IsNullOrEmpty(textBox_TK_TenTK.Text)) {
                    filteredData = filteredData.Where(tk => tk.TenTK.Contains(textBox_TK_TenTK.Text));
                }

                if (!string.IsNullOrEmpty(textBox_TK_MatKhau.Text)) {
                    filteredData = filteredData.Where(tk => tk.MatKhau.Contains(textBox_TK_MatKhau.Text));
                }

                if (!string.IsNullOrEmpty(textBox_TK_HoTen.Text)) {
                    filteredData = filteredData.Where(tk => tk.HoTen.Contains(textBox_TK_HoTen.Text));
                }

                if (checkBox_TK_QTV.CheckState != CheckState.Indeterminate) {
                    string checkState = checkBox_TK_QTV.CheckState == CheckState.Checked ? "admin" : "user";
                    filteredData = filteredData.Where(tk => tk.VaiTro.Equals(checkState));
                }

                // Update DataGridView
                dataGridView_TaiKhoan.DataSource = new BindingSource { DataSource = filteredData.ToList() };
            }
        }
        private void Icon_TK_Them_Click(object sender, EventArgs e) {
            TaiKhoan taiKhoan = GetTaiKhoan();

            if (string.IsNullOrEmpty(taiKhoan.TenTK) || string.IsNullOrEmpty(taiKhoan.MatKhau) || string.IsNullOrEmpty(taiKhoan.HoTen)) {
                MessageBox.Show(
                    "Nhập đủ tên tài khoản, mật khẩu và họ tên\ntrước khi thêm vào cơ sở dữ liệu.",
                    "Chưa điền đầy đủ các thông tin cần thiết",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (db!.TaiKhoans.Any(tk => tk.TenTK == taiKhoan.TenTK)) {
                var result = MessageBox.Show(
                    "Tồn tại tài khoản với tên tài khoản này.\n" +
                    "Ghi đè thông tin của tài khoản?",
                    "Ghi đè thông tin của tài khoản",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {
                    var existingAccount = db.TaiKhoans.First(tk => tk.TenTK == taiKhoan.TenTK);

                    existingAccount.MatKhau = taiKhoan.MatKhau;
                    existingAccount.HoTen = taiKhoan.HoTen;
                    existingAccount.VaiTro = taiKhoan.VaiTro;

                }
            } else {
                db.Add(taiKhoan);
            }

            db.SaveChanges();
            dataGridView_TaiKhoan.Refresh();

            foreach (DataGridViewRow row in dataGridView_TaiKhoan.Rows) {
                if (row.DataBoundItem is TaiKhoan rowAccount &&
                    rowAccount.TenTK == taiKhoan.TenTK) // Compare by unique key
                {
                    row.Selected = true;
                    dataGridView_TaiKhoan.CurrentCell = row.Cells[0];
                    break;
                }
            }

            Icon_TK_Clear_Click(sender, e);
        }
        private void Icon_TK_Xoa_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "Xoá tài khoản?",
                "Trước khi xoá tài khoản",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                // Use a HashSet to avoid duplicate row indices
                var rowsToDelete = new HashSet<int>();

                foreach (DataGridViewCell cell in dataGridView_TaiKhoan.SelectedCells) {
                    rowsToDelete.Add(cell.RowIndex);
                }

                foreach (int rowIndex in rowsToDelete) {
                    if (dataGridView_TaiKhoan.Rows[rowIndex].DataBoundItem is TaiKhoan taiKhoan) {
                        db.TaiKhoans.Remove(taiKhoan);
                    }
                }

                db.SaveChanges();
                dataGridView_TaiKhoan.Refresh();
            }
        }
        private void Icon_TK_Loc_Click(object sender, EventArgs e) {
            icon_TK_Loc.IconChar = (icon_TK_Loc.IconChar == IconChar.Filter) ? IconChar.FilterCircleXmark : IconChar.Filter;
            isLoc = !isLoc;

            List<Button> icon_TK = [icon_TK_Them, icon_TK_Tim, icon_TK_Xoa];

            icon_TK.ForEach(icon => icon.Enabled = !isLoc);

            checkBox_TK_QTV.ThreeState = isLoc;

            if (!isLoc) {
                checkBox_TK_QTV.Checked = false;
                dataGridView_TaiKhoan.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dataGridView_TaiKhoan.DataSource = taiKhoanBindingSource;
            } else {
                ApplyFilters();
                Icon_TK_Clear_Click(sender, e);
                checkBox_TK_QTV.CheckState = CheckState.Indeterminate;
            }
        }
        private void Icon_TK_Tim_Click(object sender, EventArgs e) {
            var filteredData = db!.TaiKhoans.Local.AsQueryable();

            if (!string.IsNullOrEmpty(textBox_TK_TenTK.Text)) {
                filteredData = filteredData.Where(tk => tk.TenTK.Contains(textBox_TK_TenTK.Text));
            }

            if (!string.IsNullOrEmpty(textBox_TK_MatKhau.Text)) {
                filteredData = filteredData.Where(tk => tk.MatKhau.Contains(textBox_TK_MatKhau.Text));
            }

            if (!string.IsNullOrEmpty(textBox_TK_HoTen.Text)) {
                filteredData = filteredData.Where(tk => tk.HoTen.Contains(textBox_TK_HoTen.Text));
            }

            if (checkBox_TK_QTV.CheckState != CheckState.Indeterminate) {
                string checkState = checkBox_TK_QTV.CheckState == CheckState.Checked ? "admin" : "user";
                filteredData = filteredData.Where(tk => tk.VaiTro.Equals(checkState));
            }

            var filteredList = filteredData.ToList();
            if (filteredList.Count == 0)
                return;

            var firstAccount = filteredList[0];

            foreach (DataGridViewRow row in dataGridView_TaiKhoan.Rows) {
                if (row.DataBoundItem is TaiKhoan rowAccount &&
                    rowAccount.TenTK == firstAccount.TenTK) // Compare by unique key
                {
                    row.Selected = true;
                    dataGridView_TaiKhoan.CurrentCell = row.Cells[0];
                    SetTaiKhoan(rowAccount);
                    break;
                }
            }
        }
        private void Icon_TK_Clear_Click(object sender, EventArgs e) {
            SetTaiKhoan(new TaiKhoan { TenTK = "", MatKhau = "", HoTen = "", VaiTro = "user" });
        }
        private void DataGridView_TaiKhoan_SelectionChanged(object sender, EventArgs e) {
            if (db == null || this.IsDisposed || this.Disposing || dataGridView_TaiKhoan.IsDisposed) {
                return;
            }

            if (!isLoc && dataGridView_TaiKhoan.CurrentRow != null) {
                var tenTK = dataGridView_TaiKhoan.CurrentRow.Cells[0].Value?.ToString() ?? "";
                var matKhau = dataGridView_TaiKhoan.CurrentRow.Cells[1].Value?.ToString() ?? "";
                var hoTen = dataGridView_TaiKhoan.CurrentRow.Cells[2].Value?.ToString() ?? "";
                var vaiTro = dataGridView_TaiKhoan.CurrentRow.Cells[3].Value?.ToString() ?? "user";

                SetTaiKhoan(new TaiKhoan {
                    TenTK = tenTK,
                    MatKhau = matKhau,
                    HoTen = hoTen,
                    VaiTro = vaiTro
                });
            }
        }
        private void DataGridView_TaiKhoan_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            db?.SaveChanges();
        }
    }
}
