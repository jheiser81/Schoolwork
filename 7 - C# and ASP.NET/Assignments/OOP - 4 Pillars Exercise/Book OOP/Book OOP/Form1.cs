namespace Book_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Book myBook = new Book("The Hobbit", "J.R.R. Tolkien", 1937, 310);

            richTextBox1.Text = ($"{myBook.BookName} was written by {myBook.Author} in {myBook.PubYear} and has {myBook.Pages} pages.");
        }
    }
}