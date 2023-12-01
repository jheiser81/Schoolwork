namespace Battleship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PictureBox[,] playerBoard = new PictureBox[10, 10];
        private PictureBox[,] computerBoard = new PictureBox[10, 10];
        //private int playerShots = 0;
        //private int computerShots = 0;
        //private int playerHits = 0;
        //private int computerHits = 0;

        private HashSet<int> playerLocations = new HashSet<int>();
        private HashSet<int> computerLocations = new HashSet<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintBoard();
            RandomAssignment();
            DisplayShips();
            TurnDecision();
        }

        private void PrintBoard()
        {
            //playerBoard

            int xpos = 45;
            int ypos = 45;
            for (int i = 0; i < playerBoard.GetLength(0); i++)
            {
                for (int j = 0; j < playerBoard.GetLength(1); j++)
                {
                    playerBoard[i, j] = new PictureBox
                    {
                        Name = "picturebox" + i.ToString(),
                        Location = new Point(xpos, ypos),
                        Size = new Size(45, 45),
                        Visible = true,
                        BackColor = Color.LightBlue,
                        ImageLocation = "./Wave background.png"
                    };
                    this.Controls.Add(playerBoard[i, j]);
                    xpos += 45;
                }
                xpos = 45;
                ypos += 45;
            }

            //computerBoard

            int computerXpos = xpos + 500;
            int computerYpos = 45;
            for (int i = 0; i < computerBoard.GetLength(0); i++)
            {
                for (int j = 0; j < computerBoard.GetLength(1); j++)
                {
                    computerBoard[i, j] = new PictureBox
                    {
                        Name = "computerBoard" + i.ToString(),
                        Location = new Point(computerXpos, computerYpos),
                        Size = new Size(45, 45),
                        Visible = true,
                        BackColor = Color.LightBlue,
                        ImageLocation = "./Wave background.png"
                    };
                    this.Controls.Add(computerBoard[i, j]);
                    computerXpos += 45;
                }
                computerXpos = xpos + 500;
                computerYpos += 45;
            }
        }

        private void RandomAssignment()
        {//Random Assignment Function: Use a random number generator to make random numbers.
         //Use a data structure called "HashSet" lines 16 and 17 in my code(do research)
         //loop while the HashSet.Count has less than 8 numbers generate random numbers for playerLocation
         //add a location x and y
         //while the HashSet.Count has less than 8 numbers generate random numbers for ComputerLocation
         //add a location x and y

            //Steps:
            //1)declare a new hashset
            //2)make a while loop, numbers < 8
            //3)generate random numbers between 0 and 9
            //4)x and y coordinates determined by random numbers

            Random rand = new Random(); //create new random object, the random numbers determine starting position of the ships on the gameboard
            while (playerLocations.Count < 8) //while the set has less than 8 elements...
            {
                int xPosition = rand.Next(10);//declare new variable and assign it a random number between 0 and 9
                playerLocations.Add(xPosition);//take the value of xPosition and add it to the set
                int yPosition = rand.Next(10);
                playerLocations.Add(yPosition);
            }
            while (computerLocations.Count < 8) //do the exact same for the computer
            {
                int xPosition = rand.Next(10);
                computerLocations.Add(xPosition);
                int yPosition = rand.Next(10);
                computerLocations.Add(yPosition);

                //with sets you don't index like with arrays, you just add elements to the set
            }
        }

        private void TurnDecision()
        { //use a random number generator to make a turn for computer or for the player
          //if player goes they get to click
          //if computer goes then call computerTurn()

            Random random = new Random();
            bool isPlayerTurn = (random.Next() % 2 == 0);
            if (isPlayerTurn)
            {
                MessageBox.Show("Players Turn");
            }
            else
            {
                MessageBox.Show("Computers Turn");
            }
        }

        private void DisplayShips()
        {//Display Ships Function:
         //Convert your HashSet.ToList() for the playerLocation, List is another data structure that acts like an array
         //Change the image location from water to ships
         //Convert your HashSet.ToList() for the computerLocation, List is another data structure that acts like an array
         //Change the image location from water to ships

            //End result:
            //You should have random ships on your gameboard every time you start the for

            //Steps:
            //1)take playerLocations hashset and convert to a list
            //2)change image location from water to ships
            //3)Convert computerLocation hashset to list
            //4)Change image location from water to ships for computer

            List<int> playerPlace = playerLocations.ToList();//convert hashset to list, create new variable that holds the data from the hashset
            List<int> compPlace = computerLocations.ToList();
            playerBoard[playerPlace[0], playerPlace[1]].ImageLocation = "./Battleship_img.png";
            playerBoard[playerPlace[2], playerPlace[3]].ImageLocation = "./Battleship_img.png";
            playerBoard[playerPlace[4], playerPlace[5]].ImageLocation = "./Battleship_img.png";
            playerBoard[playerPlace[6], playerPlace[7]].ImageLocation = "./Battleship_img.png";

            computerBoard[compPlace[0], compPlace[1]].ImageLocation = "./Battleship_img.png";
            computerBoard[compPlace[2], compPlace[3]].ImageLocation = "./Battleship_img.png";
            computerBoard[compPlace[4], compPlace[5]].ImageLocation = "./Battleship_img.png";
            computerBoard[compPlace[6], compPlace[7]].ImageLocation = "./Battleship_img.png";
        }
    }
}