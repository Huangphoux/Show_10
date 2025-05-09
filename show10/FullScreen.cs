using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Show10
{
    internal class FullScreen
    {
        public void EnterFullScreenMode(Form targetForm)
        {
            targetForm.WindowState = FormWindowState.Normal;
            targetForm.FormBorderStyle = FormBorderStyle.None;
            targetForm.WindowState = FormWindowState.Maximized;
        }

        public void LeaveFullScreenMode(Form targetForm)
        {
            targetForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            targetForm.WindowState = FormWindowState.Normal;


            targetForm.Width = 1280;
            targetForm.Height = 720;
            targetForm.StartPosition = FormStartPosition.Manual;
            targetForm.Left = (Screen.PrimaryScreen.WorkingArea.Width - 1280) / 2;
            targetForm.Top = (Screen.PrimaryScreen.WorkingArea.Height - 720) / 2;

    }


    }
}
