using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1sept.Forms
{
    public partial class Timer2sept : Form
    {
        public Timer2sept()
        {
            InitializeComponent();
        }

        DateTime timeStarted;

        private void Timer2sept_Load(object sender, EventArgs e)
        {
            timeStarted = DateTime.Now;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = (DateTime.Now - timeStarted).ToString();
        }
    }

    }
