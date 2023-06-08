namespace Methods_Classwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void greeting(string place) //this is the parameter
        {
            richTextBox1.Text += $"Hello, {place}\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            greeting("Button"); //this is an argument
        }

        //Exercise 1:
        //Make a subroutine called sum that has two integer parameters, add the two integers together and print to a RichTextBox
        //Call the subroutine on the form load and a button click and fill in the arguments
        //Input form load= 10, 5
        //Output = “Form load sum arguments 10 + 5 = 15”
        //Input button click = 55, 20
        //Output = “Button click arguments 55 + 20 = 75

        //Exercise 2:
        //• Make the product(multiplication), quotient(division) and difference(Subtraction) Subroutines just like sum and add them
        //to the form load and button click
        //• Input form load= 10, 5
        //• Output = “Form load product arguments 10 * 5 = 50”
        //• Input button click = 55, 20
        //• Output = “Button click product arguments 55 * 20 = 1100”
        //• Input form load= 10, 5
        //• Output = “Form load quotient arguments 10 / 5 = 2”
        //• Input button click = 20, 55
        //• Output = “Button click quotient arguments 55 / 20 = 2.75”
        //• Input form load= 10, 5
        //• Output = “Form load difference arguments 10 - 5 = 5”
        //• Input button click = 20, 55
        //• Output = “Button click difference arguments 55 - 20 = 35

        private void Form1_Load(object sender, EventArgs e)
        {
            greeting("Form Load"); //this is an argument
            sum("Form Load", 10, 5); //calls sum function
            diff("Form Load", 10, 5); //calls diff function
            product("Form Load", 10, 5); //calls product function
            quotient("Form Load", 10, 5); //calls quotient function
        }

        private void sum(string place, int a, int b)//sets up the parameters for the function, one string and two integers
        {
            richTextBox2.Text += $"{place} sum arguments: {a} + {b} = {a + b}\n";//operation to be performed
        }

        private void diff(string place, int a, int b)//sets up the parameters for the function, one string and two integers
        {
            richTextBox2.Text += $"{place} difference arguments: {a} - {b} = {a - b}\n"; //operation to be performed
        }

        private void product(string place, int a, int b)//sets up the parameters for the function, one string and two integers
        {
            richTextBox2.Text += $"{place} product arguments: {a} * {b} = {a * b}\n"; //operation to be performed
        }

        private void quotient(string place, double a, double b) //sets this as double so that the operation can be decimal number
        {
            richTextBox2.Text += $"{place} quotient arguements: {a} / {b} = {a / b}\n"; //operation to be performed
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear(); //clears the richtextbox to display button input
            sum("Button", 55, 20);//string, int, int
            diff("Button", 55, 20);//string, int , int
            product("Button", 55, 20);//string, int, int
            quotient("Button", 55, 20); //string, double, double
        }
    }
}