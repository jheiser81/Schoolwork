namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = 3; b = 4;
            textBox1.Text = a.ToString() + b.ToString();
        }
    }
}