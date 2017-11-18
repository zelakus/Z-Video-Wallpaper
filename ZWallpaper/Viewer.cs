using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZWallpaper
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        public void SetUrl(string url)
        {
            axWindowsMediaPlayer1.URL = url;
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Top = 0;
            this.Left = 0;

            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.mute = true;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
    }
}
