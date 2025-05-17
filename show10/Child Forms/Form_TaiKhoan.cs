using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Show10.Models;


namespace Show10.Child_Forms {
    public partial class Form_TaiKhoan : Form {
        private NhaSachContext? db;
        bool isLoc = false;

        public Form_TaiKhoan() {
            InitializeComponent();
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


        // không select khi bấm vào checkbox
        private void DataGridView_TaiKhoan_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView_TaiKhoan.CurrentCell != null &&
                dataGridView_TaiKhoan.Columns[dataGridView_TaiKhoan.CurrentCell.ColumnIndex].Index == 3) {
                dataGridView_TaiKhoan.CurrentCell.Selected = false;
            }

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

        private void DataGridView_TaiKhoan_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            // Commit the edit when the checkbox cell value changes
            if (dataGridView_TaiKhoan.IsCurrentCellDirty &&
                dataGridView_TaiKhoan.CurrentCell is DataGridViewCheckBoxCell) {
                dataGridView_TaiKhoan.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridView_TaiKhoan_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            // Ensure the event is triggered for the checkbox column
            if (e.RowIndex >= 0 && e.ColumnIndex == 3) { // Assuming column index 3 is the checkbox column
                var row = dataGridView_TaiKhoan.Rows[e.RowIndex];

                if (row.DataBoundItem is TaiKhoan taiKhoan) {
                    // Update the VaiTro property based on the checkbox value
                    taiKhoan.VaiTro = (string)row.Cells[e.ColumnIndex].Value;

                    db.SaveChanges();
                    dataGridView_TaiKhoan.Refresh();
                }
            }
        }

        private void Icon_TK_Loc_Click(object sender, EventArgs e) {
            icon_TK_Loc.IconChar = (icon_TK_Loc.IconChar == IconChar.Filter) ? IconChar.FilterCircleXmark : IconChar.Filter;
            isLoc = !isLoc;

            List<Button> icon_TK = [icon_TK_Them, icon_TK_Tim, icon_TK_Xoa];

            icon_TK.ForEach(icon => icon.Enabled = !isLoc);

            if (!isLoc) {
                checkBox_TK_QTV.Checked = false;
                checkBox_TK_QTV.ThreeState = false;
                dataGridView_TaiKhoan.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dataGridView_TaiKhoan.DataSource = taiKhoanBindingSource;
            } else {
                checkBox_TK_QTV.ThreeState = true;
                checkBox_TK_QTV.CheckState = CheckState.Indeterminate;
                ApplyFilters();
            }
        }

        private TaiKhoan GetTaiKhoan() {
            string tenTK = textBox_TK_TenTK.Text;
            string matKhau = textBox_TK_MatKhau.Text;
            string hoTen = textBox_TK_HoTen.Text;
            string vaiTro = checkBox_TK_QTV.Checked ? "admin" : "user";

            return new TaiKhoan { HoTen = tenTK, MatKhau = matKhau, TenTK = hoTen, VaiTro = vaiTro };
        }

        private void Icon_TK_Them_Click(object sender, EventArgs e) {
            TaiKhoan taiKhoan = GetTaiKhoan();

            if (string.IsNullOrEmpty(taiKhoan.TenTK) || string.IsNullOrEmpty(taiKhoan.MatKhau) || string.IsNullOrEmpty(taiKhoan.HoTen)) {
                MessageBox.Show(
                    "Nhập đủ tên tài khoản, mật khẩu và họ tên\ntrước khi thêm vào cơ sở dữ liệu.",
                    "Chưa điền đầy đủ các thông tin cần thiết",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (db.TaiKhoans.Any(tk => tk.TenTK == taiKhoan.TenTK)) {
                var result = MessageBox.Show(
                    "Đã có tài khoản sử dụng tên tài khoản này!\n" +
                    "Bạn muốn ghi đè thông tin của tài khoản này?",
                    "Ghi đè thông tin của tài khoản",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {
                    var existingAccount = db.TaiKhoans.First(tk => tk.TenTK == taiKhoan.TenTK);

                    existingAccount.MatKhau = taiKhoan.MatKhau;
                    existingAccount.HoTen = taiKhoan.HoTen;
                    existingAccount.VaiTro = taiKhoan.VaiTro;

                    db.SaveChanges();
                    dataGridView_TaiKhoan.Refresh();
                }

            } else {
                _ = db.Add(taiKhoan);
                _ = db.SaveChanges();
                dataGridView_TaiKhoan.Refresh();
            }
        }
    }
}
