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
    public partial class Form2sept : Form
    {
        public Form2sept()
        {
            InitializeComponent();
        }

        int X = 0;
        int Y = 0;

        int XClick = 0;
        int YClick = 0;

        private void Form2sept_KeyDown(object sender, KeyEventArgs e)
        {
            this.Text += (char)e.KeyValue;

            Point? newLocation = null;

            if (e.KeyCode == Keys.Up)
            {
                newLocation = new Point(this.Location.X, this.Location.Y - 50);
            }
            else if (e.KeyCode == Keys.Down)
            {
                newLocation = new Point(this.Location.X, this.Location.Y + 50);
            }
            else if (e.KeyCode == Keys.Left)
            {
                newLocation = new Point(this.Location.X - 50, this.Location.Y);
            }
            else if (e.KeyCode == Keys.Right)
            {
                newLocation = new Point(this.Location.X + 50, this.Location.Y);
            }
            if (newLocation != null)
            {
                if (Screen.PrimaryScreen.Bounds.Contains(new Rectangle(newLocation.Value, this.Size)))
                {
                    this.Location = newLocation.Value;
                }
            }
        }
    }
}
