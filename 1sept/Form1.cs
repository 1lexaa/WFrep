namespace _1sept
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //private int counter = 0;
        private int k = 0;



       

        private void button1_Click_1(object sender, EventArgs e)
        {
            // counter++;
            Button b = sender as Button;
          
            button1.Text = $"{k++}";
            // buttonCounter.Text = counter.ToString();
        }
    }
}
