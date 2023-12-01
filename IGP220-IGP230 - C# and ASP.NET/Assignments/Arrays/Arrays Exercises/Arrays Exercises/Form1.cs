namespace Arrays_Exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //C# array format:
        //data_type[] array_name = new data_type[array_size];

        //Exercise 1: Make an array of five numbers, add all the numbers together. (no loops just use the indexes of array)
        //input: 5, 1, 22, 4, 3
        //output: 35

        private void button3_Click(object sender, EventArgs e)
        {
            int[] newArray = { 5, 1, 22, 4, 3 };      //declares the numbers in the array and the size of the array
            int sum = 0;

            for (int i = 0; i < newArray.Length; i++) //for loop to add the numbers in the array. Array.Length is the size of the array.
                                                      //Asks if i is less than the length of the array, if so, add 1 to i.
            {
                sum += newArray[i];                   //goes through once, then iterates the index to get the next number, adds to the sum. Continues until it reaches the last position in the array
            }
            textBox1.Text = sum.ToString();           //after going through each index location in the array, prints the total in the sum variable
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exercise 2:
            //Create an array of 100 random numbers, then calculate how many odd numbers, even numbers
            //(even excluding 0) and zeros there are in the array

            int[] myArray = { 1, 5, 8, 0, 19, 4, 6, 15, 10, 13 };  //array.length is 10
            int evenCount = 0;
            int oddCount = 0;
            int zeroCount = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == 0)
                {
                    zeroCount++;
                }
                else if (myArray[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
                richTextBox1.Text = "Even numbers: " + evenCount + "\n" + "Odd numbers: " + oddCount + "\n" + "Zeroes: " + zeroCount;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random(); //makes new random object
            int[] randArray = new int[100]; //makes new array of 100
            int evenCount = 0;
            int oddCount = 0;
            int zeroCount = 0;
            double arrSum = 0;
            int largestNum = 0;
            int smallestNum = 0;
            double arrAvg = 0;

            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = random.Next(100);

                if (randArray[i] == 0)
                {
                    zeroCount++;
                }
                else if (randArray[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
                arrSum += randArray[i];
                richTextBox2.Text = $"There are {evenCount} even numbers, {oddCount} odd numbers and {zeroCount} zeroes in the array. \n\nThe sum of the numbers in the arary is {arrSum}";
            }
            {
                largestNum = randArray[0];
                for (int i = 1; i < randArray.Length; i++)
                {
                    if (randArray[i] > largestNum)
                    {
                        largestNum = randArray[i];
                    }
                }
                richTextBox2.Text += $"\n\nThe largest number in the array is {largestNum}.";
            }
            if (randArray.Length > 0)
            {
                smallestNum = randArray[0];
                for (int i = 0; i < randArray.Length; i++)
                {
                    if (randArray[i] < smallestNum)
                    {
                        smallestNum = randArray[i];
                    }
                }
                richTextBox2.Text += $"\n\nThe smallest number in the array is {smallestNum}.";
            }
            arrAvg = arrSum / randArray.Length; //why is this not printing as a double?
            richTextBox2.Text += $"\n\nThe average of the numbers in the array is {arrAvg}.";
        }

        //if (randArray.Length > 0)
        //{
        //    arrSum = randArray[0];
        //    for (int i = 1; i < randArray.Length; i++)
        //    {
        //        arrSum += randArray[i];
        //    }
        //    richTextBox2.Text += $"\n\nThe sum of the array is {arrSum}.";
        //}
        //if (randArray.Length > 0)

        private void button4_Click(object sender, EventArgs e)
        {
            //1. Declared array of 4 numbers
            //2. Declared a variable to hold the numbers
            //3. Need to check if each number is greater than or equal to previous number
            //4. Go through each number and check it against the previous number
            //check if the number is the first number in the array
            //if it is, skip it
            //if it's not the first number, we check if it's greater than or equal to the previous number.
            //if true, we move on to the next number.
            //if false, break loop and print NO
            //5. If we get to the end of the array, it means every condition was true, so then print YES at the end

            int[] N = { -10, 10 };

            for (int i = 0; i < N.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    if (N[i] >= N[i - 1])
                    {
                        continue;
                    }
                    else
                    {
                        richTextBox3.Text = "No";
                        return;
                    }
                }
            }
            richTextBox3.Text = "Yes";
        }
        
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        private void button5_Click(object sender, EventArgs e)
        {
            ////1. Declare an array of 12 months
            ////2. Declare a variable to hold the month
            ////3. Check if the month is in the array
            ////4. If it is, print YES
            ////5. If it's not, print NO
            //string month = textBox2.Text;
            //for (int i = 0; i < months.Length; i++)
            //{
            //    if (month == months[i])
            //    {
            //        richTextBox4.Text = "Yes";
            //        return;
            //    }
            //}
            //richTextBox4.Text = "No";
        }
    }
}