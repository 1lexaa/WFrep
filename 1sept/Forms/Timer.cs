using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
using System.Linq;

namespace _1sept.Forms
{
    public partial class Timer : Form
    {

        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;
        public Timer()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToString());
            sb.Replace(":", "");
            bmpScreenshot.Save(@"C:\Users\1lexaa\Desktop\1\" + sb.ToString() + ".png", ImageFormat.Png);
        }
    }
}
