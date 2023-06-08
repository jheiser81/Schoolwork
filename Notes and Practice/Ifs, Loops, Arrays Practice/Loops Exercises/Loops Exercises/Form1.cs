namespace Loops_Exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exercise 1: Print numbers 1-10

            for (int i = 0; i <= 10; i++)
            {
                richTextBox1.Text += $"{i}, ";
                //or can be typed: += i.ToString() + ",
            }
        }

        //--------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
            //Exercise 2: Sum of numbers 1-100

            int sum = 0; //declare variable
            for (int i = 1; i <= 100; i++) //
            {
                sum += i;
                richTextBox2.Text += $"{sum}, ";
            }
        }

        //--------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            //Exercise 3: Sum of numbers in an array

            int[] array = { 5, 1, 22, 4, 3 };
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                richTextBox3.Text = $"The sum of the numbers in the array is {sum}";
            }
        }

        //--------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)

        //Exercise 4: Sum of all the even numbers between two numbers
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int sum = 0;
            string evenNumbers = "";

            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    evenNumbers += i + ", ";
                }
            }
            richTextBox4.Text = evenNumbers + "\n" + $"The sum of all the even numbers is {sum}";
        }

        //---------------------------------------------------------
        private void button5_Click(object sender, EventArgs e)
        {
            //Exercise 5: Print numbers 1-10 using while loop (this is just a demo)
            int i = 1;
            while (i <= 10)
            {
                richTextBox5.Text += i.ToString() + ", ";
                i++;
            }
        }

        //---------------------------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            //Exercise 6: Generate random numbers until you get 42

            Random rand = new Random();
            int randnum;
            while (true)
            {
                randnum = rand.Next(100) + 1;
                richTextBox6.Text += randnum.ToString() + ", ";

                if (randnum == 42)
                {
                    break;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Exercise 7: Determine if a number is prime number or not

            //Determine if a number is prime number
            //Input = 1399
            //Output = It is True Your number is prime

            //Input = 22
            //Output = It is False Your number is prime

            //Input = 2
            //Output = It is True Your number is prime

            //Input = 1
            //Output = It is False Your number is prime

            int j = int.Parse(prime_input.Text);
            bool isPrime = true;

            //if (j == 1)
            //{
            //    isPrime = false;
            //}
            for (int i = 2; i < j; i++)
            {
                if (j % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime == true && j != 1)
            {
                primeBox.Text = "Your number is prime.";
            }
            else
            {
                primeBox.Text = "Your number is not prime.";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int N = int.Parse(board_input.Text);
            board_box1.Clear();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    board_box1.Text += " * ";
                }
                board_box1.Text += "\n";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int N = int.Parse(board_input2.Text);
            board_box2.Clear();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    board_box2.Text += " * ";
                }
                board_box2.Text += "\n";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int N = int.Parse(board_input3.Text);
            board_box3.Clear();
            for (int i = 0; i < N; i++)
            {
                for (int j = N - 1; j >= i; j--)
                {
                    board_box3.Text += " * ";
                }
                board_box3.Text += "\n";
            }
        }
    }
}