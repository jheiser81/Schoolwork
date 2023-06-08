namespace If_Statement_Exercises__C_Sharp_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EvenOddCheck_Click(object sender, EventArgs e)
        {
            //Exercise 1: Write a program that checks if a given number is even or odd.

            int number = int.Parse(num_box.Text);

            if (number % 2 == 0)
            {
                num_result_box.Text = $"The number {number} is even";
            }
            else
            //else if (number % 2 != 0)
            {
                num_result_box.Text = $"The number {number} is odd";
            }
        }

        private void year_check_Click(object sender, EventArgs e)

        //Exercise 2: Write a program that checks if a given year is a leap year or not.

        //Years that are divisible by 4 are leap years.
        //Years that are divisible by 100 are not leap years, except for years that are also divisible by 400, which are leap years.

        {
            bool IsLeapYear = false;               // set to false by default
            int year = int.Parse(year_box1.Text);   // gets the year entered into the text box, and converts it to an integer
            {
                if (year % 4 == 0)                 // checks if year is evenly divisible by 4. If it is, move to the next step. If not, skip to final step.

                {
                    if (year % 100 == 0)           // If year is divisible by 4, check if it is also divisible by 100. It it is, move to the next step.
                                                   // If not, isLeapYear = true and skip to final step
                    {
                        if (year % 400 == 0)       // If year is divisible by both 4 and 100, check if it is also divisible by 400. If it is, isLeapYear = true
                                                   // If not, isLeapYear = false and skip to final step
                        {
                            IsLeapYear = true;    //  Check the value of isLeapYear. If it is true, the year is a leap year. If it is false, the year is not a leap year.
                        }
                    }
                    else
                    {
                        IsLeapYear = true;
                    }
                }

                if (IsLeapYear)
                {
                    year_result_box.Text = $"The year {year} is a leap year.";
                }
                else
                {
                    year_result_box.Text = $"The year {year} is not a leap year.";
                }
            }
        }

        //This can be written out in a more concise way using the &&  and || operators

        //    int year = int.Parse(year_box.Text);
        //    bool IsLeapYear = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        //       if (IsLeapYear)
        //{
        //    year_result_box.Text = $"The year {year} is a leap year.";
        //}
        //       else
        //{
        //    year_result_box.Text = $"The year {year} is not a leap year.";
        //}
        private void numCheck_btn_Click(object sender, EventArgs e)
        {
            //Exercise 3: Write a program that compares two numbers and displays the larger number.

            int num1 = int.Parse(num_box1.Text);
            int num2 = int.Parse(num_box2.Text);

            if (num1 > num2)
            {
                num_result_box2.Text = $"The larger number is {num1}"; //checks if num1 is > num2. If it is, print message. If not, next step.
            }
            else if (num2 > num1)
            {
                num_result_box2.Text = $"The larger number is {num2}"; //checks if num2 is > num1. If it is, print message. If not, final step.
            }
            else
            {
                num_result_box2.Text = $"The numbers are equal"; //if both previous conditions are false, numbers are equal
            }
        }

        //Exercise 4: Write a program that checks if a given character is a vowel or not.

        private void vowel_check_Click(object sender, EventArgs e)
        {
            string input = char_box1.Text.ToUpper();                            //converts input to uppercase, so that A and a can both be checked. Could also set toLower.
            char ch = input[0];                                                 //retrieves data from the 0 index position in the string.

            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U') //characters use single '' instead of double "", because we are making a character literal,
                                                                               //not a string literal
            {
                char_result_box.Text = $"{ch} is a vowel";
            }
            else
            {
                char_result_box.Text = $"{ch} is not a vowel";
            }
        }

        private void age_check_Click(object sender, EventArgs e)
        {
            //Exercise 5: Write a program that takes in a person's age and determines if they are old enough to vote (age 18 or older).

            int age = int.Parse(AgeBox1.Text);

            if (age >= 18)
            {
                age_result_box.Text = "You are old enough to vote.";
            }
            else if (age <= 18)
            {
                age_result_box.Text = "You are not old enough to vote.";
            }
        }

        private void grade_btn_Click(object sender, EventArgs e)
        {
            //Exercise 6: Write a program that takes in a person's grade and returns their letter grade based on the following scale:
            //A for grades 90-100, B for grades 80-89, C for grades 70-79, D for grades 60-69, and F for grades below 60.

            string firstName = name_box1.Text;
            string lastName = name_box2.Text;
            int score = int.Parse(grade_box.Text);
            char grade;

            if (score >= 90 && score <= 100)
            {
                grade = 'A';
            }
            else if (score >= 80 && score <= 89)
            {
                grade = 'B';
            }
            else if (score >= 70 && score <= 79)
            {
                grade = 'C';
            }
            else
            {
                grade = 'F';
            }
            grade_result.Text = $"{firstName} {lastName}, you received a grade of {grade} with a score of {score}.";
        }

        private void Generation_btn_Click(object sender, EventArgs e)
        {
            //Exercise 7: Write a program that takes in a person's birth year and determines if they are in the Millennial generation (born between 1981 and 1996) or not.

            string firstName = name_box3.Text;
            string lastName = name_box4.Text;
            int birthYear = int.Parse(year_box2.Text);

            if (birthYear >= 1981 && birthYear <= 1996)
            {
                generation_box.Text = $"{firstName} {lastName}, you were born in the year {birthYear}, so you are a millenial.";
            }
            else if (birthYear >= 1997 && birthYear <= 2012)
            {
                generation_box.Text = $"{firstName} {lastName}, you were born in the year {birthYear}, so you are Gen Z";
            }
            else
            {
                generation_box.Text = $"{firstName} {lastName}, you were born in the year {birthYear}, so you are Gen Alpha, and are a child.";
            }
        }

        private void check_btn(object sender, EventArgs e)

        //Exercise 8: Write a program that takes in three numbers and returns the largest of the three.

        {
            int num1 = int.Parse(num_box3.Text);
            int num2 = int.Parse(num_box4.Text);
            int num3 = int.Parse(num_box5.Text);

            if (num1 > num2 && num1 > num3)
            {
                num_results.Text = $"{num1} is the largest number.";
            }
            else if (num2 > num1 && num2 > num3)
            {
                num_results.Text = $"{num2} is the largest number.";
            }
            else if (num3 > num1 && num3 > num2)
            {
                num_results.Text = $"{num3} is the largest number.";
            }
            else if (num1 == num2 && num2 == num3)
            {
                num_results.Text = "All the numbers are equal.";
            }
            else if (num1 == num2 || num1 == num3 || num2 == num3)
            {
                num_results.Text = "Two of the numbers are equal.";
            }
        }
    }
}