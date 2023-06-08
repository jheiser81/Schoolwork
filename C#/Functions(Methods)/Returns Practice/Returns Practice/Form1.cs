namespace Returns_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MyMethod()//creating a method
        {
            richTextBox1.Text += "I just go executed!\n\n";//put output message here
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyMethod();//call the method here
            FName("Liam", "Witherspoon", 5);//argument
            FName("Jenny", "Garland", 8);//argument
            FName("Andrew", "Tate", 31);//argument
            Country("Sweden");
            Country("USA");
            Country();
        }

        private void Country(string countryName = "Norway")//set a default parameter value with =
        {
            richTextBox1.Text += $"{countryName}\n";
        }

        private void FName(string firstName, string lastName, int age)//parameters will be passed to method
        {
            //richTextBox1.Text += firstName + " " + "Heiser\n";
            richTextBox1.Text += $"{firstName} {lastName} is {age} years old.\n\n";
        }

        //PARAMETERS AND ARGUMENTS

        //Information can be passed to methods as parameter.Parameters act as variables inside the method.

        //They are specified after the method name, inside the parentheses.You can add as many parameters as you want, just separate them with a comma.

        //The following example has a method that takes a string called fname as parameter.When the method is called, we pass along a first name, which is used inside the method to print the full name.
        //------------------------------------------------------------------------------------------

        //RETURN VALUES

        //Previously we used the void keyword in all examples, which indicates that the method should not return a value.

        //If you want the method to return a value, you can use a primitive data type (such as int or double) instead of void, and use the return keyword inside the method:

        private int ReturnMethods(int x, int y)//didn't use void
        {
            return x + y;//returns the value
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z = ReturnMethods(5, 3);//made variable to store result of x + y
            richTextBox2.Text = z.ToString() + "\n";
        }
    }
}