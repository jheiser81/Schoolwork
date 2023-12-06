namespace Recursion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int x = 5;
            //int factResult = 1;//set to 1 not 0, since anything * 0 = 0

            //for (int i = 1; i <= x; i++)
            //{
            //    factResult *= i; //fact = fact * i
            //}
            //richTextBox1.Text = $"Factorial of {x} is {factResult}";
        }

        //private int Recursion(int factorial)
        //{
        //    int products = 1;
        //    for (int i = 1; i <= factorial; i++)
        //    {
        //        products *= i;
        //    }
        //    return products;
        //}

        //private int Factorials(int factorial)
        //{
        //    int product = 1;
        //    for (int i = 1; i <= factorial; i++)
        //    {
        //        product *= i;
        //    }
        //    return product;
        //}

        private double FactorialRecursion(double fact)
        {
            if (fact == 1)
            {
                return fact;
            }
            return fact * FactorialRecursion(--fact);
        }

        private int PowerOf(int pBase, int power) //takes two parameters
        { //using the same concept as the factorial, multiply the base by itself for the amount of power you have
          //7, 3 = 7 * 7 * 7 = 343

            if (power == 0)
            {
                return 1;
            }
            return pBase * PowerOf(pBase, power - 1);

            int PowerIterative(int pBase, int power)
            {
                int myPowerAnswer = 1;
                for (int i = 0; i < power; i++)
                {
                    myPowerAnswer *= pBase;
                }
                return myPowerAnswer;
            }
            //    if (power == 0)//end the recursion
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //        return pBase * PowerOf(pBase, power - 1);
            //    }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myPowInterative = PowerIterative(2, 5);

            int myPower = PowerOf(2, 5);
            richTextBox1.Text = $"recursive: {myPower}\nIterative: {myPowInterative}";
            //int pBase = 7;
            //int power = 3;
            //int result = PowerOf(pBase, power);
            //richTextBox1.Text = $"{pBase} to the power of {power} is {result}";

            //int myFactToFind = 5;
            //int fact = Factorials(myFactToFind);
            //richTextBox1.Text = $"Factorial of {myFactToFind} is {fact}";
            //richTextBox1.Text = Recursion(5).ToString();
        }
    }

    //The function PowerOf takes two parameters, pBase and power.It is used to calculate the power of pBase raised to power. The function is implemented using recursion, which means that it calls itself with a smaller value of power until it reaches the base case, which is when power is equal to 0.

    //Here's how the function works:

    //The function first checks if power is equal to 0. If it is, it returns 1, since any number raised to the power of 0 is 1.
    //If power is not equal to 0, the function recursively calls itself with the parameters pBase and power - 1.
    //This continues until the base case is reached, at which point the function returns 1.
    //Once the base case is reached, the function starts returning values up the call stack.The value of pBase is multiplied by the result of the recursive call, which computes the power of pBase raised to power-1.
    //The final result is returned to the caller.
    //Here's an example of how the function works for pBase = 7 and power = 3:

    //PowerOf(7, 3) is called.
    //Since power is not equal to 0, the function calls itself with the parameters 7 and 2: 7 * PowerOf(7, 2).
    //Since power is not equal to 0, the function calls itself again with the parameters 7 and 1: 7 * 7 * PowerOf(7, 1).
    //Since power is not equal to 0, the function calls itself one more time with the parameters 7 and 0: 7 * 7 * 7 * PowerOf(7, 0).
    //Since power is equal to 0, the function returns 1.
    //The previous call to PowerOf(7, 0) returns 1 * 7 * 7 * 7, which is 343.
    //The final result is 343.
}