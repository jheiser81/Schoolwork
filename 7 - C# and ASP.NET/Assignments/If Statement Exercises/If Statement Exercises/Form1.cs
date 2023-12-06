namespace If_Statement_Exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text); //int.Parse() method is used to convert a string representation of a number into an integer value.
            int num2 = int.Parse(textBox2.Text); //used this method so that the program could be dynamic, instead of hardcoding the numbers

            string output1;
            if (num1 % 2 == 0)
            {
                output1 = "even";
            }
            else
            {
                output1 = "odd";
            }
            string output2;
            if (num2 % 2 == 0)
            {
                output2 = "even";
            }
            else
            {
                output2 = "odd";
            }
            richTextBox1.Text = $"Num1 is {output1}, Num2 is {output2}";
            }
        
        //used additional variables here so that both numbers could be checked at the same time

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int myNumber = int.Parse(textBox3.Text);
            if (myNumber % 2 == 0)
            {
                MessageBox.Show("The number is even");
            }
            else
            {
                MessageBox.Show("The number is odd");
            }
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numInput = int.Parse(textBox4.Text);
            if (numInput % 3 == 0 && numInput % 5 == 0)
            {
                textBox4.Text = "FizzBuzz";
            }
            else if (numInput % 3 == 0)
            {
                textBox4.Text = "Fizz";
            }
            else if (numInput % 5 == 0)
            {
                textBox4.Text = "Buzz";
            }
            else
            {
                textBox4.Text = "No Fizz or Buzz";
            }
                
        }
    }
    }
