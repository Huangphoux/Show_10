using Show10.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Show10.Child_Forms
{
    public partial class Form_TaiKhoan : Form
    {
        private TaiKhoanContext? db;

        public Form_TaiKhoan()
        {
            InitializeComponent();
        }

        private void Form_Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            db?.Dispose();
            db = null;
        }

        private void Form_Account_Load(object sender, EventArgs e)
        {
            db = new TaiKhoanContext();

            // Uncomment the line below to start fresh with a new database.
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.TaiKhoans.Load();

            taiKhoanBindingSource.DataSource = db.TaiKhoans.Local.ToBindingList();
        }

        private void CheckBox_TK_TimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_TK_TimKiem.Checked)
            {
                icon_TK_Them.Enabled = false;
                icon_TK_Xoa.Enabled = false;
            }
            else
            {
                icon_TK_Them.Enabled = true;
                icon_TK_Xoa.Enabled = true;
            }

        }
    }
}
