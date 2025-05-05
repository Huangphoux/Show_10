using FontAwesome.Sharp;
using Show10;
using Show10.Child_Forms;
using System.Drawing.Text;

namespace show10
{
    public partial class MainWindow : Form
    {
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;

        public MainWindow()
        {
            InitializeComponent();
            DoubleBuffered = true;

            elapsedTime = TimeSpan.Zero;
            timer_Clock.Start();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 80);
            panel_Menu.Controls.Add(leftBorderBtn);
        }

        private TimeSpan elapsedTime;
        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
            label_Clock.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }


        private bool isFullScreen = false;

        private void Icon_Fullscreen_Click(object sender, EventArgs e)
        {

            FullScreen fullScreen = new FullScreen();

            if (!isFullScreen)
            {
                fullScreen.EnterFullScreenMode(this);
                isFullScreen = true;
            }
            else
            {
                fullScreen.LeaveFullScreenMode(this);
                isFullScreen = false;
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                //Button
                currentBtn = (IconButton)senderBtn;

                currentBtn.ForeColor = color;
                //currentBtn.BackColor = Color.Red;
                currentBtn.IconColor = color;

                //Left border button
                leftBorderBtn.BackColor = color;

                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Control.DefaultForeColor;
                currentBtn.BackColor = Control.DefaultBackColor;
                currentBtn.IconColor = Control.DefaultForeColor;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;

            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_ChildForm.Controls.Add(childForm);
            panel_ChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void Icon_User_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Form_User());
        }

        private void Icon_Book_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

        }
    }
}
