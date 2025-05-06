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
    public partial class Form_Account : Form
    {
        private AccountContext? db;

        public Form_Account()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db = new AccountContext();

            // Uncomment the line below to start fresh with a new database.
            this.db.Database.EnsureDeleted();
            this.db.Database.EnsureCreated();

            this.db.Accounts.Load();

            this.accountBindingSource.DataSource = db.Accounts.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }
    }
}
