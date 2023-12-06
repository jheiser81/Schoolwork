namespace Arrays
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }
        string[,] multiArrayStaticInitalization = new string[,] { { " * ", " * ", " * " }, { " * ", " * ", " * " }, { " * ", " * ", " * " } };
        string[,] multiArrayDynamic = new string[10, 10];
        void PrintArray(string toFill = "")
        {
            richTextBox1.Text = "This is my array I have to type\n";
            for (int i = 0; i <= multiArrayStaticInitalization.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= multiArrayStaticInitalization.GetUpperBound(1); j++)
                {

                    richTextBox1.Text += multiArrayStaticInitalization[i, j];
                }
                richTextBox1.Text += "\n";
            }

            richTextBox1.Text += "This is my Awesome Lazy array\n";
            for (int i = 0; i <= multiArrayDynamic.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= multiArrayDynamic.GetUpperBound(1); j++)
                {
                    if (toFill == " E ")
                    {
                        multiArrayDynamic[i, j] = toFill;
                    }
                    richTextBox1.Text += multiArrayDynamic[i, j];
                }
                richTextBox1.Text += "\n";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PrintArray(" E ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please input some data ");
                return;
            }
            int x = Convert.ToInt32(textBox1.Text) - 1;
            int y = Convert.ToInt32(textBox2.Text) - 1;
            multiArrayDynamic[y, x] = " F ";
            if (y <= 3 && x <= 3)
            {
                multiArrayStaticInitalization[y, x] = " F ";
            }
            PrintArray();
        }
    }
}