namespace _2_Input_and_Output
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Concat_btn_1_Click(object sender, EventArgs e)
        {
            string hello = textBox1.Text;
            string world= textBox2.Text;

            textBox3.Text = hello + world;
            textBox5.Text = $"{hello}{world}";
        }

        private void concat_btn_2_Click(object sender, EventArgs e)
        {
            string author = textBox4.Text;
            string quote = richTextBox1.Text;
            richTextBox2.Text = $"{author + " said: " + quote}";
        }
    }
}