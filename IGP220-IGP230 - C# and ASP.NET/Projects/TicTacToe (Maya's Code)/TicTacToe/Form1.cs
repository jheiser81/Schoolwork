namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[,] gameBoard = new string[3, 3];//this is the 3x3 game board
        private bool player1 = false; //this checks if it is player 1's turn

        private void PrintBoard()
        {
            richTextBox1.Clear(); //is this doing anything?
            for (int row = 0; row <= gameBoard.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= gameBoard.GetUpperBound(0); col++)
                {
                    if (gameBoard[row, col] == "  ") //this checks if the slot in the array is an empty space
                    {
                        richTextBox1.Text += " "; //displays the empty space
                    }
                    else
                    {
                        richTextBox1.Text += gameBoard[row, col]; //displays either an X or an O or -
                    }
                }
                richTextBox1.Text += "\n"; //this is the new line
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for (int row = 0; row < 3; row++) //this is the rows
            //{
            //    for (int col = 0; col < 3; col++) //this is the columns
            //    {
            //        gameBoard[row, col] = " - "; //fills in the array with -'s
            //    }
            //}
            //PrintBoard(); //after the array is filled, print the board
            //didn't need this since the printBoard function is called in the reset function
            reset();
        }

        private void winCheck()
        {
            if (//horizontal rows, if any of these are true, then X wins
                (gameBoard[0, 0] == " X " && gameBoard[0, 1] == " X " && gameBoard[0, 2] == " X ") ||
                (gameBoard[1, 0] == " X " && gameBoard[1, 1] == " X " && gameBoard[1, 2] == " X ") ||
                (gameBoard[2, 0] == " X " && gameBoard[2, 1] == " X " && gameBoard[2, 2] == " X ") ||
                //vertical rows if any of these are true, then X wins
                (gameBoard[0, 0] == " X " && gameBoard[1, 0] == " X " && gameBoard[2, 0] == " X ") ||
                (gameBoard[0, 1] == " X " && gameBoard[1, 1] == " X " && gameBoard[2, 1] == " X ") ||
                (gameBoard[0, 2] == " X " && gameBoard[1, 2] == " X " && gameBoard[2, 2] == " X ") ||

                (gameBoard[0, 0] == " X " && gameBoard[1, 1] == " X " && gameBoard[2, 2] == " X ") ||//diagonal top left to bottom right
                (gameBoard[0, 2] == " X " && gameBoard[1, 1] == " X " && gameBoard[2, 0] == " X ")) //diagonal top right to bottom left
            {
                reset();
                MessageBox.Show("X wins!");
                return;
            }
            else if (//vertical rows, if any of these are true, then O wins
                    (gameBoard[0, 0] == " O " && gameBoard[1, 0] == " O " && gameBoard[2, 0] == " O ") ||
                    (gameBoard[0, 1] == " O " && gameBoard[1, 1] == " O " && gameBoard[2, 1] == " O ") ||
                    (gameBoard[0, 2] == " O " && gameBoard[1, 2] == " O " && gameBoard[2, 2] == " O ") ||
                    //horizontal rows if any of these are true, then O wins
                    (gameBoard[0, 0] == " O " && gameBoard[0, 1] == " O " && gameBoard[0, 2] == " O ") ||
                    (gameBoard[1, 0] == " O " && gameBoard[1, 1] == " O " && gameBoard[1, 2] == " O ") ||
                    (gameBoard[2, 0] == " O " && gameBoard[2, 1] == " O " && gameBoard[2, 2] == " O ") ||
                    (gameBoard[0, 0] == " O " && gameBoard[1, 1] == " O " && gameBoard[2, 2] == " O ") ||//diagonal top left to bottom right
                    (gameBoard[0, 2] == " O " && gameBoard[1, 1] == " O " && gameBoard[2, 0] == " O ")) //diagonal top right to bottom left
            {
                reset();
                MessageBox.Show("O wins!");
            }
            else
            {
                //need to make a draw condition, if all tiles are filled but no winning line then game ends
                //display message saying "Draw, no one wins"
                //Extra: Reset game board, ask if you want to play again

                int boardFilledCount = 0;
                for (int row = 0; row <= gameBoard.GetUpperBound(0); row++) //counts how many non-empty slots there are
                {
                    for (int col = 0; col <= gameBoard.GetUpperBound(1); col++)
                    {
                        if (gameBoard[row, col] != " - ")
                        {
                            boardFilledCount++;//counts slots that are filled (not empty), so either an X or an O
                        }
                    }
                }
                if (boardFilledCount == 9) //if boardFilledCount is 9, then all slots are filled
                {
                    reset();
                    MessageBox.Show("Draw, no one wins.");
                    return;
                }
            }
        }

        private void reset()
        {
            for (int row = 0; row < 3; row++) //this is the rows
            {
                for (int col = 0; col < 3; col++) //this is the columns
                {
                    gameBoard[row, col] = " - "; //fills in the array with -'s
                }
            }
            PrintBoard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")//both textboxes must have data
            {
                MessageBox.Show("Enter row and col number between 1-3");
                return;
            }

            int x = int.Parse(textBox1.Text) - 1;
            int y = int.Parse(textBox2.Text) - 1;

            if (gameBoard[y, x] != " - ") //this had to be before the player1 check
            {
                MessageBox.Show("This spot is already taken");
                return;
            }
            if (player1 == true) //if player1 is true, then it is player 1's turn
            {
                gameBoard[y, x] = " O ";
                player1 = false;
            }
            else
            {
                gameBoard[y, x] = " X "; //if player1 is false, then it is player 2's turn
                player1 = true;
            }
            PrintBoard();
            winCheck();
            {
            }
        }
    }
}