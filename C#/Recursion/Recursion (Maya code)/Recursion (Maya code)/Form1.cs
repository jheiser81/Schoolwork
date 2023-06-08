namespace Recursion__Maya_code_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int SumNum1To100(int x)
        {
            //sum numbers 1-100
            //1+2+3+4+5+6
            int sum = 0;
            for (int i = 0; i <= x; i++)
            {
                sum += i;
            }
            return sum;
        }

        private ulong Factorials(ulong factorial)
        {
            //1*2*3*4*5*6
            ulong product = 1;
            for (ulong i = 1; i <= factorial; i++)
            {
                product *= i;
            }
            return product;
        }

        private double FactorialsRecursion(double fact)
        {
            if (fact == 1)//in recursion you always have to have an if statment that stops the recusion
            {
                return fact;//generally it will return the last value
            }
            return fact * FactorialsRecursion(--fact);//recusive return
            //recustive return that multiplies the function
        }

        private int PowerOf(int pBase, int power)
        {
            //using the same concept as the factorial, multiply the base by itself for the amount of power you have
            //7, 3 =  7 * 7 * 7 = 343
            if (power == 0)//end the recursion
            {
                return 1;
            }
            return pBase * PowerOf(pBase, power - 1);//recursive call with a power-- * base
        }

        private int PowerIterative(int pBase, int power)
        {
            int myPowerAnswer = 1;
            for (int i = 0; i < power; i++)
            {
                myPowerAnswer *= pBase;
            }
            return myPowerAnswer;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int myPowInterative = PowerIterative(2, 5);

            int myPower = PowerOf(2, 5);
            richTextBox1.Text = $"recursive: {myPower}\nIterative: {myPowInterative}";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double myFactToFind = 935;
            //double factIter = Factorials(myFactToFind);
            //richTextBox1.Text += $"\n{myFactToFind}! = {factIter}";
            double fact = FactorialsRecursion(myFactToFind);
            richTextBox1.Text += $"{myFactToFind}! = {fact}";
            //int sumed100Numbers = SumNum1To100(100);
            //richTextBox1.Text += "sumed numbers are: " + sumed100Numbers.ToString();
        }
    }
}