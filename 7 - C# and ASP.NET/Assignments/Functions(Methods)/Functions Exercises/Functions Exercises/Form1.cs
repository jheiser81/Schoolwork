namespace Functions_Exercises
{
    public partial class Form1 : Form
    {
        private double currentBalance = 1000.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Exercise 1:

        //•Look back at the 100 random number array we made.
        //•Move the find largest, find smallest, sum, average, and the(even, odd, zero counter) into separate subprograms.
        private int countZeroes(int[] randarray) //function to count zeros in array
        {
            int zerocount = 0; //counter variable
            for (int i = 0; i < randarray.Length; i++) //for loop to count zeros
            {
                if (randarray[i] == 0)
                {
                    zerocount++;
                }
            }
            return zerocount; //returns count
        }

        private int countEvenNums(int[] randarray)
        {
            int evencount = 0;
            for (int i = 0; i < randarray.Length; i++)
            {
                if (randarray[i] % 2 == 0)
                {
                    evencount++;
                }
            }
            return evencount;
        }

        private int countOddNums(int[] randarray)
        {
            int oddcount = 0;
            for (int i = 0; i < randarray.Length; i++)
            {
                if (randarray[i] % 2 != 0)
                {
                    oddcount++;
                }
            }
            return oddcount;
        }

        private int getSmallestNum(int[] randarray)
        {
            int smallestNum = 0;
            for (int i = 0; i < randarray.Length; i++)
            {
                if (randarray[i] < smallestNum)
                {
                    smallestNum = randarray[i];
                }
            }
            return smallestNum;
        }

        private int getLargestNum(int[] randarray)
        {
            int largestNum = 0;
            for (int i = 0; i < randarray.Length; i++)
            {
                if (randarray[i] > largestNum)
                {
                    largestNum = randarray[i];
                }
            }
            return largestNum;
        }

        private int getSum(int[] randarray)
        {
            int sum = 0;
            for (int i = 0; i < randarray.Length; i++)
            {
                sum += randarray[i];
            }
            return sum;
        }

        private double getAvg(int[] randarray)
        {
            double sum = 0;//used sum again but set as double
            for (int i = 0; i < randarray.Length; i++)
            {
                sum += randarray[i];
            }
            return sum / randarray.Length;//sum divided by length of array
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random(); //makes new random object
            int[] randArray = new int[100]; //makes new array of 100

            for (int i = 0; i < randArray.Length; i++) //for loop to fill array with random numbers
            {
                randArray[i] = random.Next(101);//includes 0, otherwise use 100 + 1
            }

            richTextBox1.Text = $"There are {countZeroes(randArray)} zeros in the array.\nThere are {countEvenNums(randArray)} even numbers in the array.\nThere are {countOddNums(randArray)} odd numbers in the array.\n\nThe smallest number in the array is {getSmallestNum(randArray)}.\nThe largest number in the array is {getLargestNum(randArray)}.\nThe sum of the numbers in the array is {getSum(randArray)}.\nThe average of the numbers in the array is {getAvg(randArray)}."; //prints out the number of zeros in the array
        }

        // Exercise 2:
        //•Make a Mini-ATM.
        //•Using a function and subroutine, use the function to return the amount withdrawn as a messagebox.Use the subroutine to print the balance in a message box. Print the balance when after you withdraw
        private void Withdraw_btn_Click(object sender, EventArgs e)
        {
            double amount_to_withdraw = double.Parse(textBox1.Text);//withdrawal amount from textbox
            double withdrawnAmount = Withdraw(amount_to_withdraw);//calling withdraw function with withdrawal amount
            if (withdrawnAmount > 0)
            {
                displayBalance();//display balance if withdrawal successful
            }
        }

        private void Chk_Bal_btn_Click(object sender, EventArgs e)
        {
            displayBalance();//display the balance
        }

        private double Withdraw(double amount_to_withdraw)
        {
            if (amount_to_withdraw > currentBalance)//check if amount withdrawn is more than balance
            {
                MessageBox.Show("Insufficient funds.");
                return 0;
            }
            else
            {
                currentBalance -= amount_to_withdraw;//deduct amount from balance
                MessageBox.Show($"Amount withdrawn: ${amount_to_withdraw}.");
                return amount_to_withdraw;
            }
        }

        private void displayBalance()
        {
            MessageBox.Show($"Current balance is: ${currentBalance}.");
        }
    }
}