namespace Functions_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Exercise 1:
        //• Make a subroutine called sum that has two integer parameters,
        //add the two integers together and print to a RichTextBox
        //• Call the subroutine on the form load and a button click and fill
        //in the arguments
        //• Input form load= 10, 5
        //• Output = “Form load sum arguments 10 + 5 = 15”
        //• Input button click = 55, 20
        //• Output = “Button click arguments 55 + 20 = 75”

        //---------------------------------------------------

        private void sum(string place, int a, int b) //these are the parameters I am sending through the method
        {
            richTextBox1.Text = $"{place} sum arguments: {a} + {b} = {a + b}\n";
        }

        private void diff(string place, int a, int b)
        {
            richTextBox1.Text += $"{place} diff arguments: {a} - {b} = {a - b}\n";
        }

        private void prod(string place, int a, int b)
        {
            richTextBox1.Text += $"{place} product arguments: {a} * {b} = {a * b}\n";
        }

        private void quo(string place, double a, double b)
        {
            richTextBox1.Text += $"{place} quotient arguments: {a} / {b} = {a / b}\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sum("Form load", 10, 5);//these are the arguments I am passing through
            diff("Form Load", 10, 5);
            prod("Form Load", 10, 5);
            quo("Form Load", 10, 5);
            square("Form Load", 6);
            modulo("Form Load", 15, 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum("Button click", 55, 20);
            diff("Button click", 55, 20);
            prod("Button click", 55, 20);
            quo("Button click", 55, 20);
            AddNumbers(3, 39);
        }

        // Exercise 2:
        // • Make a subroutine called square that has one integer parameter,
        // square the integer and print to a RichTextBox
        // • Call the subroutine on the form load and a button click and fill
        // in the arguments
        // • Input form load= 6
        // • Output = “Form load square argument: 6² = 36”
        // • Input button click = 9
        // • Output = “Button click square argument: 9² = 81”

        //----------------------------------------------------------------------

        private void square(string place, int a)
        {
            richTextBox2.Text = $"{place} square argument: {a} ^ 2 = {a * a}\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            square("Button click", 9);
            modulo("Button click", 42, 7);
        }

        // Exercise 3:
        // • Make a subroutine called modulo that has two integer parameters,
        // find the modulo of the two integers and print to a RichTextBox
        // • Call the subroutine on the form load and a button click and fill
        // in the arguments
        // • Input form load= 15, 4
        // • Output = “Form load modulo arguments: 15 % 4 = 3”
        // • Input button click = 42, 7
        // • Output = “Button click modulo arguments: 42 % 7 = 0”

        //-------------------------------------------------------------------------

        private void modulo(string place, int a, int b)
        {
            richTextBox2.Text += $"{place} modulo arguments: {a} % {b} = {a % b}\n";
        }

        public int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}