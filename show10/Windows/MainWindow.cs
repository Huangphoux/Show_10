using Show10;

namespace show10
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleBuffered = true;
            elapsedTime = TimeSpan.Zero;
            timer_Clock.Start();
        }

        private TimeSpan elapsedTime;
        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
            label_Clock.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {

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
    }
}
