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
        private int playerHits = 0; //do i need this?
        private int computerHits = 0; //do i need this?
        private int PlayerHitCount = 0;
        private int ComputerHitCount = 0;
        private HashSet<int> playerLocations = new HashSet<int>();
        private HashSet<int> computerLocations = new HashSet<int>();
        private List<int> compPlace;

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintBoard(); //calling the following functions on form load
            RandomAssignment();
            DisplayShips();
            TurnDecision();
        }

        private void PrintBoard()
        {
            //playerBoard

            int xpos = 45;//x position of the first picturebox
            int ypos = 45; //y position of the first picturebox
            for (int i = 0; i < playerBoard.GetLength(0); i++)//outer loop for 10 rows
            {
                for (int j = 0; j < playerBoard.GetLength(1); j++)//inner loop for 10 columns
                {
                    playerBoard[i, j] = new PictureBox //creates new picturebox with following properties:
                    {
                        Name = "picturebox" + i.ToString() + j.ToString(),
                        Location = new Point(xpos, ypos),
                        Size = new Size(45, 45),
                        Visible = true,
                        BackColor = Color.LightBlue,
                        ImageLocation = "./Waves.png"
                    };
                    this.Controls.Add(playerBoard[i, j]);//controls for the form
                    xpos += 45;//this is the x position of the next picturebox
                }
                xpos = 45;//this is the x position of the first picturebox in the next row
                ypos += 45;//y position of the next row
            }

            //computerBoard

            int computerXpos = xpos + 500;//sets the x position of the first picturebox in the computer board 500 pixels to the right of the player board
            int computerYpos = 45; //set starting y position
            for (int i = 0; i < computerBoard.GetLength(0); i++)//outer loop for 10 rows
            {
                for (int j = 0; j < computerBoard.GetLength(1); j++)//inner loop for 10 columns
                {
                    computerBoard[i, j] = new PictureBox//makes new picturebox with following properties
                    {
                        Name = "picturebox" + i.ToString() + j.ToString(),
                        Location = new Point(computerXpos, computerYpos),
                        Size = new Size(45, 45),
                        Visible = true,
                        BackColor = Color.LightBlue,
                        ImageLocation = "./Waves.png"
                    };
                    computerBoard[i, j].Click += PlayerClick;
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
            bool isPlayerTurn = random.Next() % 2 == 0;
            if (isPlayerTurn)
            {
                MessageBox.Show("Player goes first");
            }
            else if (!isPlayerTurn)
            {
                MessageBox.Show("Computers goes first");
                ComputerTurn();
            }
        }

        private void DisplayShips()
        {//Display Ships Function:
         //Convert your HashSet.ToList() for the playerLocation, List is another data structure that acts like an array
         //Change the image location from water to ships
         //Convert your HashSet.ToList() for the computerLocation, List is another data structure that acts like an array
         //Change the image location from water to ships

            //End result:
            //You should have random ships on your gameboard every time you start the for loop

            //Steps:
            //1)take playerLocations hashset and convert to a list
            //2)change image location from water to ships
            //3)Convert computerLocation hashset to list
            //4)Change image location from water to ships for computer

            List<int> playerPlace = playerLocations.ToList();//convert hashset to list, create new variable that holds the data from the hashset

            playerBoard[playerPlace[0], playerPlace[1]].ImageLocation = "./Battleship_img.png";//randomly changes the image location of the picturebox from waves to battleship on playerBoard
            playerBoard[playerPlace[2], playerPlace[3]].ImageLocation = "./Battleship_img.png";//playerLocations was first declared as a hashset, had random numbers added to it, then converted to a list
            playerBoard[playerPlace[4], playerPlace[5]].ImageLocation = "./Battleship_img.png";
            playerBoard[playerPlace[6], playerPlace[7]].ImageLocation = "./Battleship_img.png";

            compPlace = computerLocations.ToList();
            //compPlace[0] = 0;
            //compPlace[1] = 0;

            //compPlace[2] = 0;
            //compPlace[3] = 9;

            //compPlace[4] = 9;
            //compPlace[5] = 9;

            //compPlace[6] = 9;
            //compPlace[7] = 0; //this was just for testing

            //computerBoard[compPlace[0], compPlace[1]].ImageLocation = "./Battleship_img.png";//randomly changes the image location of the picturebox from waves to battleship on computerBoard
            //computerBoard[compPlace[2], compPlace[3]].ImageLocation = "./Battleship_img.png";//computerLocations was first declared as a hashset, had random numbers added to it, then converted to a list
            //computerBoard[compPlace[4], compPlace[5]].ImageLocation = "./Battleship_img.png";
            //computerBoard[compPlace[6], compPlace[7]].ImageLocation = "./Battleship_img.png";
        }

        private void PlayerClick(object sender, EventArgs e)
        {    //turn sender into a Picturebox
             //extract the number from the picturebox name
             //exract the number from the picturebox name
             //check if that space has a ship in it
             //Change ship to HIT
             //Add 1 to the player counter (so you can later check if your player won)
             //otherwise check if the image is water
             //change to missed
             //otherwise the place has already been taken
             //let them know it has been taken
             //leave the function

            //call win check
            //call computer turn

            PictureBox clickedBox = (PictureBox)sender;//turn sender into a Picturebox
            int y = int.Parse(clickedBox.Name.Substring(10, 1));//x coordinate of the clicked PictureBox
            int x = int.Parse(clickedBox.Name.Substring(11));//y coordinate of the clicked PictureBox
            string imageLocation = computerBoard[y, x].ImageLocation; //image location of clicked tile on compboard
            bool gameover = false;
            if ((compPlace[0] == y && compPlace[1] == x) ||
                (compPlace[2] == y && compPlace[3] == x) ||
                (compPlace[4] == y && compPlace[5] == x) ||
                (compPlace[6] == y && compPlace[7] == x)) //Not checking the image, checking the placement
            {
                computerBoard[y, x].ImageLocation = "./explosion-417894_640.png";//change to explosion
                MessageBox.Show("You hit an enemy ship!");
                PlayerHitCount++;//increment player hit counter
                gameover = CheckWin(); //check if game is won
            }
            else if (imageLocation == "./Waves.png") //If it's a water tile...
            {
                computerBoard[y, x].ImageLocation = "./Smoke.png";//set to smoke (miss)
            }
            else
            {
                MessageBox.Show("You have already attacked this location");//check if tile already attacked
            }
            if (gameover == false)
            {
                ComputerTurn();
            }
        }

        private void ComputerTurn()
        {//make a radom number for x and y
            //check if Computer list locations match the x and y locations
            //change to HIT
            //add to the computer hit counter
            //otherwise check if the image is waves
            //change to missed
            //other wise
            //computer turn ()
            //you can do this recursivly so you dont have to use a loop, but you can use a loop like we did before with the hash sets

            Random rand = new Random();
            int x = rand.Next(10);//generate random number 0-9 for attack
            int y = rand.Next(10);
            string imageLocation = playerBoard[x, y].ImageLocation;//gets the image loc of targeted tile
            MessageBox.Show("Computer shoots at " + x + ", " + y + ".");

            if (imageLocation == "./Battleship_img.png")//check if there's a player ship on tile
            {
                playerBoard[x, y].ImageLocation = "./explosion-417894_640.png";//change to explosion
                MessageBox.Show("Your ship has been hit!");
                ComputerHitCount++;//increment computer's hit counter
                CheckWin();
            }
            else if (imageLocation == "./Waves.png")//if it's a water tile...
            {
                playerBoard[x, y].ImageLocation = "./Smoke.png";//set image to smoke(missed shot)
            }
            else
            {
                ComputerTurn();//call the computer's turn for new x and y, attack new tile
            }
        }

        private bool CheckWin()
        {//check if there were four hits for player
            //reset board
            //chech if there were four hits for computer
            //reset board

            if (PlayerHitCount == 4)
            {
                MessageBox.Show("Player wins!");
                ResetBoard();
                return true;
            }
            else if (ComputerHitCount == 4)
            {
                MessageBox.Show("Computer wins :(");
                ResetBoard();
                return true;
            }
            return false;
        }

        private void ResetBoard()
        {   //Call Random Assignment
            //run loops that resets all the images to waves
            //set player count to 0
            //set computer hit count to 0
            //display ships

            //basically just set board back to the way it was at the start of the game

            for (int i = 0; i < playerBoard.GetLength(0); i++)//loops through playerboard tiles and resets to wave image
            {
                for (int j = 0; j < playerBoard.GetLength(1); j++)
                {
                    playerBoard[i, j].ImageLocation = "./Waves.png";
                }
            }

            for (int i = 0; i < computerBoard.GetLength(0); i++)//do the same for computerboard tiles
            {
                for (int j = 0; j < computerBoard.GetLength(1); j++)
                {
                    computerBoard[i, j].ImageLocation = "./Waves.png";
                }
            }

            PlayerHitCount = 0;// Set player hit count to 0
            ComputerHitCount = 0;// Set computer hit count to 0

            DisplayShips();//call DisplayShips function for reset board

            TurnDecision();//randomize turn for new game
            RandomAssignment();//Call Random Assignment function
        }
    }
}