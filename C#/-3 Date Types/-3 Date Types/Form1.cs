namespace _3_Date_Types
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Add_btn_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(num1_box.Text);
            int num2 = Convert.ToInt32(num2_box.Text);
            sum_box_1.Text = Convert.ToString(num1 + num2);

            //this method declares num1 and num2 as integers, and converts the text in the textboxes to integers.
            //We then need to convert the result of the addition to a string so that it can be displayed in the textbox.

            int num_1 = 5;
            int num_2 = 5;
            sum_box_2.Text = Convert.ToString(num_1 + num_2);

            //this method declares num1 and num2 as integers , and assigns the value of 5 to both textboxes.
            //We then need to convert the result of the addition to a string so that it can be displayed in the textbox.
        }

        private void concat_btn_click(object sender, EventArgs e)
        { 
            String_box_3.Text = string_box_1.Text + String_box_2.Text;
        }

        private void concat_btn_2_Click(object sender, EventArgs e)
        {
           string firstName = NameBox1.Text;
           string lastName = NameBox2.Text;
           int age = Convert.ToInt32(AgeBox.Text);
            FullNameBox.Text = $"Hello {firstName} {lastName}, you are {age} years old";

        }

        private void concat_btn_3_Click(object sender, EventArgs e)
        {
            string place = "zoo";
            string friend = "Nick";
            string activity = "fun";
            string thing_1 = "lions";
            string thing_2 = "zebras";
            string thing_3 = "a really fat cabybara";
            string result = result_box.Text;
            richTextBox1.Text = $"Hi! Last week I went to the {place}. My friend {friend} and I had so much {activity}. There were {thing_1}, {thing_2}, and {thing_3}. When we saw it we felt really {result}. You should come next time!";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string bday = "Happy Birthday";
            string_box_4.Text = (bday[7].ToString());
        }
    }
}