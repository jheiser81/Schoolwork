namespace First_C_sharp_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != "" && textBox2.Text != "")
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            textBox3.Text = $" The sum of {num1} + {num2} = {num1 + num2}";

            add_btn.Text = "Wow";

            add_btn.BackColor = Color.LightBlue;
            diff_btn.BackColor = Color.FromArgb(224, 224, 224);
            prod_btn.BackColor = Color.FromArgb(224, 224, 224);
            quot_btn.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
       
            textBox3.Text = $" The difference of {num1} - {num2} = {num1 - num2}";

            add_btn.BackColor = Color.FromArgb(224, 224, 224);
            diff_btn.BackColor = Color.LightBlue;
            prod_btn.BackColor = Color.FromArgb(224, 224, 224);
            quot_btn.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
           
            textBox3.Text = $" The product of {num1} * {num2} = {num1 * num2}";

            add_btn.BackColor = Color.FromArgb(224, 224, 224);
            diff_btn.BackColor = Color.FromArgb(224, 224, 224);
            prod_btn.BackColor = Color.LightBlue;
            quot_btn.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
          
            textBox3.Text = $" The quotient of {num1} / {num2} = {num1 / num2}";

            add_btn.BackColor = Color.FromArgb(224, 224, 224);
            diff_btn.BackColor = Color.FromArgb(224, 224, 224);
            prod_btn.BackColor = Color.FromArgb(224, 224, 224);
            quot_btn.BackColor = Color.LightBlue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void swap_btn_Click(object sender, EventArgs e)
        {
            int num1 = 55;
            int num2 = 60;

            int temp = num1; //new variable to hold the value of num1 temporarily
            num1 = num2;    //value of num1 is now the value of num2
            num2 = temp;   //value of num2 is now the value of temp

            textBox4.Text = $"Swapped values: num1 = {num1}, num2 = {num2}";
        }
    }
}