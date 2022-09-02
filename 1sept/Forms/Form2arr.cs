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
    public partial class Form2arr : Form
    {
        public Form2arr()
        {
            InitializeComponent();
        }

        private void Form2arr_Load(object sender, EventArgs e)
        {
            CreateButtons();
        }

        Button CurrentButton;
        Random random = new Random();
        bool buttonReleased = true;

        int M = 5;
        int N = 5;
        int x = 50;
        int y = 10;

        private void CreateButtons()
        {

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    var button = new Button();
                    button.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    button.Location = new Point(i * x + i * y, j * x + j * y);
                    button.Size = new Size(x, x);
                    button.Text = ((i + 1) * (j + 1)).ToString();
                    button.Click += new EventHandler(ButtonRemove);
                    this.Controls.Add(button);
                }
            }
        }

        private void ButtonRemove(object sender, EventArgs e)
        {
            Controls.Remove((Button)sender);
        }
    }
}
