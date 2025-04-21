using Show10.Windows;

namespace show10
{
    public partial class MainWindow : Form
    {
        Form formDashboard;
        Form formAbout;
        Form formSetting;
        Form formLogout;
        Form formSubMenu1;
        Form formSubMenu2;

        public MainWindow()
        {
            InitializeComponent();
            mdiProp();
            //Hello WOrld
        }
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        bool menuExpanded = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpanded)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 168)
                {
                    menuTransition.Stop();
                    menuExpanded = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 56)
                {
                    menuTransition.Stop();
                    menuExpanded = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpanded = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 44)
                {
                    sidebarTransition.Stop();
                    sidebarExpanded = false;


                    pnDashboard.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnSetting.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 225)
                {
                    sidebarTransition.Stop();
                    sidebarExpanded = true;

                    pnDashboard.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnSetting.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            if (formDashboard == null)
            {
                formDashboard = new formDashboard();
                formDashboard.FormClosed += Dashboard_FormClosed;
                formDashboard.MdiParent = this;
                formDashboard.Dock = DockStyle.Fill;
                formDashboard.Show();
            }
            else
            {
                formDashboard.Activate();
            }
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formDashboard = null;
        }

        private void submenu1_Click(object sender, EventArgs e)
        {
            if (formSubMenu1 == null)
            {
                formSubMenu1 = new formSubMenu1();
                formSubMenu1.FormClosed += formSubMenu1_FormClosed;
                formSubMenu1.MdiParent = this;
                formSubMenu1.Dock = DockStyle.Fill;
                formSubMenu1.Show();
            }
            else
            {
                formSubMenu1.Activate();
            }
        }

        private void formSubMenu1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSubMenu1 = null;
        }

        private void submenu2_Click(object sender, EventArgs e)
        {
            if (formSubMenu2 == null)
            {
                formSubMenu2 = new formSubMenu2();
                formSubMenu2.FormClosed += formSubMenu2_FormClosed;
                formSubMenu2.MdiParent = this;
                formSubMenu2.Show();
            }
            else
            {
                formSubMenu2.Activate();
            }
        }

        private void formSubMenu2_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSubMenu2 = null;
        }

        private void about_Click(object sender, EventArgs e)
        {
            if (formAbout == null)
            {
                formAbout = new formAbout();
                formAbout.FormClosed += About_FormClosed;
                formAbout.MdiParent = this;
                formAbout.Dock = DockStyle.Fill;
                formAbout.Show();
            }
            else
            {
                formAbout.Activate();
            }
        }

        private void About_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formAbout = null;
        }

        private void submenu2_Click_1(object sender, EventArgs e)
        {
            if (formSubMenu2 == null)
            {
                formSubMenu2 = new formSubMenu2();
                formSubMenu2.FormClosed += formSubMenu2_FormClosed;
                formSubMenu2.MdiParent = this;
                formSubMenu2.Dock = DockStyle.Fill;
                formSubMenu2.Show();
            }
            else
            {
                formSubMenu2.Activate();
            }
        }

        private void setting_Click(object sender, EventArgs e)
        {
            if (formSetting == null)
            {
                formSetting = new formSetting();
                formSetting.FormClosed += Setting_FormClosed;
                formSetting.MdiParent = this;
                formSetting.Dock = DockStyle.Fill;
                formSetting.Show();
            }
            else
            {
                formSetting.Activate();
            }
        }

        private void Setting_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSetting = null;
        }


    }
}
