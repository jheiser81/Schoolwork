namespace Arrays
{
    public partial class Form1 : Form
    {
        private string[,] gameBoard = new string[3, 3];
        private bool player1 = true;

        public Form1()
        {
            InitializeComponent();
        }

        //private string[,] multiArrayStaticInitalization = new string[,] { { " * ", " * ", " * " }, { " * ", " * ", " * " }, { " * ", " * ", " * " } };

        private void PrintBoard()
        {
            richTextBox1.Clear();
            for (int row = 0; row <= gameBoard.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= gameBoard.GetUpperBound(0); col++)
                {
                    if (gameBoard[row, col] == "")
                    {
                        richTextBox1.Text += " ";
                    }
                    richTextBox1.Text += gameBoard[row, col];
                }
                richTextBox1.Text += "\n";
            }
            //richTextBox1.Text = "This is my array I have to type\n";
            //for (int i = 0; i <= multiArrayStaticInitalization.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= multiArrayStaticInitalization.GetUpperBound(1); j++)
            //    {
            //        richTextBox1.Text += multiArrayStaticInitalization[i, j];
            //    }
            //    richTextBox1.Text += "\n";
            //}

            //richTextBox1.Text += "This is my Awesome Lazy array\n";
            //for (int i = 0; i <= multiArrayDynamic.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= multiArrayDynamic.GetUpperBound(1); j++)
            //    {
            //        if (toFill == " * ")
            //        {
            //            multiArrayDynamic[i, j] = toFill;
            //        }
            //        richTextBox1.Text += multiArrayDynamic[i, j];
            //    }
            //    richTextBox1.Text += "\n";
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int row = 0; row <= gameBoard.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= gameBoard.GetUpperBound(0); col++)
                {
                    gameBoard[row, col] = " * ";
                }
            }
            PrintBoard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter row and col numbers between 1-3 ");
                return;
            }
            int x = Convert.ToInt32(textBox1.Text) - 1;
            int y = Convert.ToInt32(textBox2.Text) - 1;

            if (gameBoard[y, x] != " * ") //this had to be before the player1 check
            {
                MessageBox.Show("This spot is already taken");
                return;
            }

            if (player1 == true)
            {
                gameBoard[y, x] = " X ";
                player1 = false;
            }
            else
            {
                gameBoard[y, x] = " O ";
                player1 = true;
            }
            PrintBoard();
            //if (y != 3 && x <= 3)
            //{
            //    MessageBox.Show("X wins the game!");
            //}
            //else if (y <= 3 && x != 3)
            //{
            //    MessageBox.Show("O wins the game!");
            //}
            //else
            //{
            //    MessageBox.Show("Game is a draw, no one wins.");
            //}

            //if (gameBoard[y, x] != " * ")
            //{
            //    MessageBox.Show("This spot is already taken");
            //    return;
            //}

            {
            }
        }
    }
}