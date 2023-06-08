namespace Methods_Exercises
{
    //////////METHODS AND FUNCTIONS//////////

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void MyMethod() //user-defined method, can be named anything and called from anywhere in the class
        //{
        //    richTextBox1.Text += ("Hello, Method!");
        //}

        //private void Form1_Load(object sender, EventArgs e) //calls the function on form load
        //{
        //    MyMethod();
        //}

        //private void button1_Click(object sender, EventArgs e) //calls the function again when button is clicked
        //{
        //    MyMethod();
        //}

        //////////PARAMETERS AND ARGUMENTS//////////

        //-We can input different data into our subroutines by defining parameters and inputting arguments.
        //-Parameters are variables we define so we can pass data into the function
        //-Arguments are what we define when we call the subroutine.

        private void MyMethod(string place)                 //added a parameter to the method called 'place'
        {
            richTextBox1.Text += $"Hello, {place}!";        //used the parameter in the method using template literal
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyMethod("Form Load");                          //added an argument to the method called "Form Load"
            Sum(10, 5);                                     //added the sum function to the form load, with arguments 10 and 5
            Difference(10, 5);
            Product(10, 5);
            Quotient(10, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyMethod("Button");                            //added an argument to the method called "Button"
            button1.BackColor = Color.LightBlue;
        }

        //---------------------------------------------------------------------------------------------------------------
        private void Sum(int num1, int num2)               //added two parameters to the method called 'num1' and 'num2'
        {
            richTextBox2.Text += $"The sum of {num1} and {num2} is {num1 + num2}\n";
        }                                                //\n creates a line break, C# equivalent of vbCrlf in Visual Basic

        private void button2_Click(object sender, EventArgs e)
        {
            Sum(55, 20);                                  //added arguments to the method 55 and 20
            button2.BackColor = Color.LightBlue;
        }

        //-----------------------------------------------------------------------------------------------------------------
        private void Difference(int num1, int num2)
        {
            richTextBox3.Text += $"The difference of {num1} and {num2} is {num1 - num2}\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            Difference(55, 20);
            button3.BackColor = Color.LightBlue;
        }

        //-------------------------------------------------------------------------------------------------------------------
        private void Product(int num1, int num2)
        {
            richTextBox3.Text += $"The product of {num1} and {num2} is {num1 * num2}\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            Product(55, 20);
            button4.BackColor = Color.LightBlue;
        }

        //---------------------------------------------------------------------------------------------------------------------

        private void Quotient(int num1, int num2)
        {
            richTextBox3.Text += $"The quotient of {num1} and {num2} is {num1 / num2}\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            Quotient(55, 20);
            button5.BackColor = Color.LightBlue;
        }
    }
}