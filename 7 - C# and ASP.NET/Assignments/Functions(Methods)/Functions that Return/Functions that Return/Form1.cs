using System.Drawing.Text;

namespace Functions_that_Return
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int myIntMethod(int x)
        {
            return x * x;
        }

        private string myStringMethod(string x)
        {
            return $"Hello, {x}";
        }

        private double myDoubleMethod(double x)
        {
            return x * 5.99;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int myReturnIntValue = myIntMethod(55);
            string myReturnStringValue = myStringMethod("World");
            double myReturnDoubleValue = myDoubleMethod(8.5);
            richTextBox1.Text = myReturnDoubleValue.ToString();
        }

        //Make a function called arithmetic.
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
        private int arithmetic(string op, int num1, int num2)
        {
            //int result = 0;
            if (op == "+") //checks if op is equal to "+"
            {
                return num1 + num2;//if it is, it adds the two numbers together
            }
            else if (op == "-")
            {
                return num1 - num2;
            }
            else if (op == "*")
            {
                return num1 * num2;
            }
            else if (op == "/")
            {
                return num1 / num2;
            }
            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = 10;
            int num2 = 55;
            string op = "+";
            int result = arithmetic(op, num1, num2);
            richTextBox2.Text += $"The sum of {num1} and {num2} is {num1 + num2}.\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = 42;
            int num2 = 2;
            string op = "-";
            int result = arithmetic(op, num1, num2);
            richTextBox2.Text += $"The difference of {num1} and {num2} is {num1 - num2}.\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = 5;
            int num2 = 10;
            string op = "*";
            int result = arithmetic(op, num1, num2);
            richTextBox2.Text += $"The product of {num1} and {num2} is {num1 * num2}.\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = 100;
            int num2 = 20;
            string op = "/";
            int result = arithmetic(op, num1, num2);
            richTextBox2.Text += $"The quotient of {num1} and {num2} is {num1 / num2}.\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Exercise 1:
            //•Look back at the 100 random number array we made.
            //•Move the find largest, find smallest, sum, average, and the(even, odd, zero counter) into separate subprograms.
            //•Call the subprograms from the main program and display the results in the rich text box.
            //•Make sure to pass the array into the subprograms as a parameter.

            Random random = new Random(); //makes new random object
            int[] randArray = new int[100]; //makes new array of 100
            //int evenCount = 0;
            //int oddCount = 0;
            //int zeroCount = 0;
            //double arrSum = 0;
            //int largestNum = 0;
            //int smallestNum = 0;
            //double arrAvg = 0;

            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = random.Next(100);

                //    if (randArray[i] == 0)
                //    {
                //        zeroCount++;
                //    }
                //    else if (randArray[i] % 2 == 0)
                //    {
                //        evenCount++;
                //    }
                //    else
                //    {
                //        oddCount++;
                //    }
                //    arrSum += randArray[i];
                //    richTextBox2.Text = $"There are {evenCount} even numbers, {oddCount} odd numbers and {zeroCount} zeroes in the array. \n\nThe sum of the numbers in the arary is {arrSum}";
                //}
                //{
                //    largestNum = randArray[0];
                //    for (int i = 1; i < randArray.Length; i++)
                //    {
                //        if (randArray[i] > largestNum)
                //        {
                //            largestNum = randArray[i];
                //        }
                //    }
                //    richTextBox2.Text += $"\n\nThe largest number in the array is {largestNum}.";
                //}
                //if (randArray.Length > 0)
                //{
                //    smallestNum = randArray[0];
                //    for (int i = 0; i < randArray.Length; i++)
                //    {
                //        if (randArray[i] < smallestNum)
                //        {
                //            smallestNum = randArray[i];
                //        }
                //    }
                //    richTextBox2.Text += $"\n\nThe smallest number in the array is {smallestNum}.";
                //}
                //arrAvg = arrSum / randArray.Length; //why is this not printing as a double?
                //richTextBox2.Text += $"\n\nThe average of the numbers in the array is {arrAvg}.";
            }
        }
    }
}