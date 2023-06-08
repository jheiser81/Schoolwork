using System.Windows.Forms.VisualStyles;

namespace Strings_Exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            int age = Convert.ToInt32(textBox3.Text);
            richTextBox1.Text = $"Hello {firstName} {lastName}, you are {age} years old.";

            button1.BackColor = Color.LightBlue; 

        }
    }
}