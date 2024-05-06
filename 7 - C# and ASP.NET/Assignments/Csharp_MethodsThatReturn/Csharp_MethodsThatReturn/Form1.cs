using System.Security.Policy;

namespace Csharp_MethodsThatReturn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double arithmetic(string oper, double num1, double num2)
        {
            if (oper == "+")
            {
                return num1 + num2;
            }
            else if (oper == "-")
            {
                return num1 - num2;
            }
            else if (oper == "*")
            {
                return num1 * num2;
            }
            else if (oper == "/")
            {
                return num1 / num2;
            }
            return 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //• Make a one function called arithmetic.
            //• Create three parameters
            //1.Operator(string)
            //2.Number1(Integer)
            //3.Number2(Integer)
            //• Pass in (+or - or * or /) as your string arguments and 2 numbers for integers,
            //do the relevant arithmetic based on the operator input and return the value.
            //• Input = *, 5 , 10-- > Output = 50
            //• Input = +, 10, 55-- > Output = 65
            //• Input = -, 42, 2-- > Output = 40
            //• Input = /, 100, 20-- > Output = 5
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            double result = arithmetic("*", num1, num2);
            richTextBox1.Text = Convert.ToString(result);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            double result = arithmetic("/", num1, num2);
            richTextBox1.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            double result = arithmetic("+", num1, num2);
            richTextBox1.Text = Convert.ToString(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            double result = arithmetic("-", num1, num2);
            richTextBox1.Text = Convert.ToString(result);
        }
    }
}