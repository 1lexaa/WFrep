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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void linkLabel1sept_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
            this.Show();
        }

        private void linkLabel2sept_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Form2sept().ShowDialog();
            this.Show();
        }

        private void prac2sept_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Timer2sept().ShowDialog();
            this.Show();
        }

        private void linkarr2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Form2arr().ShowDialog();
            this.Show();
        }

        

        private void linktimer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Timer().ShowDialog();
            this.Show();
        }

        private void linkCH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new WallpaperChanger().ShowDialog();
            this.Show();
        }

        private void linkLabel_IM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new InfMenu().ShowDialog();
            this.Show();
        }
    }
}
