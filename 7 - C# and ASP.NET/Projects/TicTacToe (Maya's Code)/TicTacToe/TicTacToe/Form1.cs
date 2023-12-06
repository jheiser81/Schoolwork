using System.CodeDom;
using System.Data.Common;
using System.Text;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1. print 3 x 3
        //2. intiail turn / turn swap
        //3. wincheck
        //4. tie check
        //5. if already selected
        string[,] GameBoard;
        bool turnx = true;
        int turnCount = 0;
        private void WinCheck(string valueToCheck) {
            if (GameBoard[0, 0] == valueToCheck && GameBoard[0, 1] == valueToCheck && GameBoard[0, 2] == valueToCheck ||
                GameBoard[1, 0] == valueToCheck && GameBoard[1, 1] == valueToCheck && GameBoard[1, 2] == valueToCheck||
                GameBoard[2, 0] == valueToCheck && GameBoard[2, 1] == valueToCheck && GameBoard[2, 2] == valueToCheck||
                GameBoard[0, 0] == valueToCheck && GameBoard[1, 0] == valueToCheck && GameBoard[2, 0] == valueToCheck ||
                 GameBoard[0, 1] == valueToCheck && GameBoard[1, 1] == valueToCheck && GameBoard[2, 1] == valueToCheck ||
                 GameBoard[0, 2] == valueToCheck && GameBoard[1, 2] == valueToCheck && GameBoard[2,2] == valueToCheck ||
                 GameBoard[0, 0] == valueToCheck && GameBoard[1, 1] == valueToCheck && GameBoard[2, 2] == valueToCheck ||
                 GameBoard[0, 2] == valueToCheck && GameBoard[1, 1] == valueToCheck && GameBoard[2, 0] == valueToCheck )
            {
                MessageBox.Show($"{valueToCheck} Wins!!");
                PrintGame(formLoad: true);
            }
            if (turnCount == 9)
            {
                MessageBox.Show($"No one wins You are both losers!!");
                PrintGame(formLoad: true);
                turnCount = 0;
            }
        }
        private void PrintGame(bool formLoad = false) {
            richTextBox1.Clear();          
            for (int row = 0; row <= GameBoard.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= GameBoard.GetUpperBound(1); column++)
                {
                    if (formLoad)
                    {
                        GameBoard[row, column] = " * ";

                    }
                    richTextBox1.Text += GameBoard[row, column];
                }
                richTextBox1.Text += "\n";
            }

        }
        private void TurnSelect(int x = 0, int y = 0, bool formLoad = false) {
            Random rand = new Random();
            int randomTurn = rand.Next(2);
            if (randomTurn == 0 && formLoad)
            {
                turnx = true;
                button1.Text = "X Turn";
                return;
            }
            else if (formLoad) {
                turnx = false;
                button1.Text = "O Turn";
                return;
            }
            if (GameBoard[y, x] != " * ")
            {
                MessageBox.Show("This has already been taken, please select another spot");
                return;
            }
            if (turnx)
            {
                GameBoard[y, x] = " X ";
                button1.Text = "O Turn";
            }
            else
            {
                button1.Text = "X Turn";
                GameBoard[y, x] = " O ";
            }
            turnCount++;
            turnx = !turnx;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GameBoard = new string[3, 3];
            TurnSelect(formLoad: true);
            PrintGame(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" )
            {
                MessageBox.Show("Please fill in the textboxes");
                return;
            }
            int x = Convert.ToInt32(textBox1.Text) - 1;
            int y = Convert.ToInt32(textBox2.Text) - 1;
            if (x < 0 || y < 0 || x > 2 || y > 2)
            {
                MessageBox.Show("Please Enter a number between 1 and 3");
                return;
            }
            TurnSelect(x, y);
            PrintGame();
            WinCheck(" X ");
            WinCheck(" O ");
        }
    }
}