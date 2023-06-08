namespace Functions_Exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int MyIntMethod(int x)
        {
            return x * x;  //Defines MyIntMethod as a function that takes an integer parameter x and returns the result of multiplying x by itself."
        }

        private string MyStringMethod(string x)
        {
            return $"Hello, {x}";
        }

        private double MyDoubleMethod(double x)
        {
            return x * 5.99;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int myReturnIntValue = MyIntMethod(55);               //Calls MyIntMethod with an argument of 55, and stores the returned value in myReturnIntValue
            string myReturnStringValue = MyStringMethod("World"); //Calls MyStringMethod with an argument of "World", and stores the returned value in myReturnStringValue
            double myReturnDoubleValue = MyDoubleMethod(8.5);     //Calls MyDoubleMethod with an argument of 8.5, and stores the returned value in myReturnDoubleValue

            richTextBox1.Text = $"MyIntMethod returned {myReturnIntValue}.\nMyStringMethod returned {myReturnStringValue}.\nMyDoubleMethod returned {myReturnDoubleValue}.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = addTwoNumbers(5, 10);  //Calls the AddTwoNumbers method with the arguments 5 and 10, and stores the returned value in the 'result' variable.
            richTextBox2.Text = $"The sum of 5 and 10 is {result}";
        }

        public int addTwoNumbers(int x, int y) // This method takes two integer parameters x and y, adds them together and returns the result

        {
            int sum = x + y;
            return sum; // Returns the value stored in sum
        }
    }
}