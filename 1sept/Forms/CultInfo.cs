using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1sept.Forms
{
    public partial class CultInfo : Form
    {
        DateTime dt;
        public CultInfo()
        {
            InitializeComponent();
            dt = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           
            CultureInfo tokyoCulture = new CultureInfo("ja-JP");
            DateTimeFormatInfo dtfi = tokyoCulture.DateTimeFormat;
            dtfi.TimeSeparator = ":";
            listBox1.Items.Add($"Tokyo: {dt.ToString("t", dtfi)}");
            
            listBox1.Items.Add($"New York: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "Eastern Standard Time")}");
            
            listBox1.Items.Add($"California: {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Local.Id, "Pacific Standard Time")}");
           
            CultureInfo londonCulture = new CultureInfo("en-GB");
            dtfi = londonCulture.DateTimeFormat;
            dtfi.TimeSeparator = ":";
            listBox1.Items.Add($"London: {dt.ToString("t", dtfi)}");
            
            CultureInfo ukraineCulture = new CultureInfo("uk-UA");
            dtfi = ukraineCulture.DateTimeFormat;
            dtfi.TimeSeparator = ":";
            listBox1.Items.Add($"Kyiv: {dt.ToString("t", dtfi)}");
        }

    }
}
