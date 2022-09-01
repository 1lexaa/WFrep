using System.Diagnostics.Metrics;

namespace _1sept
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //private int counter = 0;
        //private int k = 0;


        private int counter = 0;
        Random random = new Random();


        private void button1_Click_1(object sender, EventArgs e)
        {
            // counter++;
            // Button b = sender as Button;

            // button1.Text = $"{k++}";
            // buttonCounter.Text = counter.ToString();


            

            counter++;

            buttonCounter.Text = counter.ToString();

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(random.Next(0, this.Width - button1.Width), random.Next(0, this.Height - button1.Height));
        }

        //
        //
        
    }
}
