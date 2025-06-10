namespace Show10 {
    internal class FullScreen {
        public static void EnterFullScreenMode(Form targetForm) {
            targetForm.WindowState = FormWindowState.Normal;
            targetForm.FormBorderStyle = FormBorderStyle.None;
            targetForm.WindowState = FormWindowState.Maximized;
        }

        public static void LeaveFullScreenMode(Form targetForm) {
            targetForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            targetForm.WindowState = FormWindowState.Normal;

            targetForm.Width = 1600;
            targetForm.Height = 900;
            targetForm.StartPosition = FormStartPosition.CenterScreen;
        }


    }
}
