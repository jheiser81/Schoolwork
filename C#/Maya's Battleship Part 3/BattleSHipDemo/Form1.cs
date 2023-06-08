using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace BattleSHipDemo
{
    public partial class Form1 : Form
    {
        PictureBox[,] playerBoard = new PictureBox[10, 10];
        PictureBox[,] computerBoard = new PictureBox[10, 10];
        int HumanShots = 0;
        int CompShots = 0;
        int PlayerHitCount = 0;
        int ComputerHitCount = 0;
        HashSet<int> PlayerLocations = new HashSet<int>();
        HashSet<int> ComputerLocations = new HashSet<int>();
        List<int> ComputerListLocation = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PrintBoard();
            RandomAssignment();
            DisplayShips();
            TurnAssignemnt();
        }
        void RandomAssignment()
        {
            Random rnd = new Random();//this is an object that allows us to generate random numbers
            while (PlayerLocations.Count < 8)//if player locations is less than 8 then we ca
            {
                int xLocation = rnd.Next(8);
                PlayerLocations.Add(xLocation);//this allows us to define our player location
                int yLocation = rnd.Next(8);
                PlayerLocations.Add(yLocation);//this allows us to define our player location
            }
            while (ComputerLocations.Count < 8)
            {
                int xLocation = rnd.Next(8);
                ComputerLocations.Add(xLocation);
                int yLocation = rnd.Next(8);
                ComputerLocations.Add(yLocation);
            }
            //Use a random number genorator
            //Use a data structure called "HashSet" line 16 and 17 (do research)
            //while the hashset has less then 8 numbers genorate random numbers for playerLocation
            //add a location x and y           
            //while the hashset.Count has less then 8 numbers genorate random numbers for ComputerLocation
            //add a location x and y           
        }
        private void PrintBoard()
        {
            //Use the code you have already written to print the game board           
            int xpos = 100, ypos = 20;
            int xposComp = 850, yposComp = 20;
            for (int i = 0; i <= playerBoard.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= playerBoard.GetUpperBound(1); j++)
                {
                    playerBoard[i, j] = new PictureBox
                    {
                        Name = "picturebox" + i.ToString() + ", " + j.ToString(),
                        Location = new Point(xpos, ypos),
                        Size = new Size(60, 60),
                        Visible = true,
                        ImageLocation = "./waves.png"
                    };
                    this.Controls.Add(playerBoard[i, j]);
                    computerBoard[i, j] = new PictureBox();
                    computerBoard[i, j].Name = "picturebox" + i.ToString() + ", " + j.ToString(); ;
                    computerBoard[i, j].Location = new Point(xposComp, yposComp);
                    computerBoard[i, j].Size = new Size(60, 60);
                    computerBoard[i, j].Visible = true;
                    computerBoard[i, j].ImageLocation = "./waves.png";
                    this.Controls.Add(computerBoard[i, j]);
                    xpos = xpos + 60;
                    xposComp = xposComp + 60;
                }
                ypos += 60;
                xpos = 100;
                yposComp += 60;
                xposComp = 850;
            }
        }

        void TurnAssignemnt()
        {
            //use a random number to make a turn for computer or for the player
            //if player goes they get to click
            //if computer goes then call computerTurn()
            Random random = new Random();
            int TurnAss = random.Next();
            if (TurnAss % 2 == 0)
            {
                MessageBox.Show("Players Turn");
            }
            else
            {
                MessageBox.Show("Computers Turn");
                //computersTurn()
            }
        }
        void DisplayShips()
        {
            //Convert your HashSet.ToList() for the playerLocation, List is another data structure that acts like an array
            //Change the image location from water to ships  
            List<int> MyPlace = PlayerLocations.ToList();
            playerBoard[MyPlace[0], MyPlace[1]].ImageLocation = "./Ship.png";
            playerBoard[MyPlace[2], MyPlace[3]].ImageLocation = "./Ship.png";
            playerBoard[MyPlace[4], MyPlace[5]].ImageLocation = "./Ship.png";
            playerBoard[MyPlace[6], MyPlace[7]].ImageLocation = "./Ship.png";
            //Convert your HashSet.ToList() for the computerLocation, List is another data structure that acts like an array
            //Change the image location from water to ships
            ComputerListLocation = ComputerLocations.ToList();
            computerBoard[ComputerListLocation[0], ComputerListLocation[1]].ImageLocation = "./Ship.png";
            computerBoard[ComputerListLocation[2], ComputerListLocation[3]].ImageLocation = "./Ship.png";
            computerBoard[ComputerListLocation[4], ComputerListLocation[5]].ImageLocation = "./Ship.png";
            computerBoard[ComputerListLocation[6], ComputerListLocation[7]].ImageLocation = "./Ship.png";
        }
        void Player_Click(object sender, EventArgs e)
        {
            //turn sender into a Picturebox
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
        }
        void ComputerTurn()
        {
            //make a radom number for x and y
            //check if Computer list locations match the x and y locations
                   //change to HIT
                   //add to the computer hit counter
            //otherwise check if the image is waves
                    //change to missed
            //other wise
                    //computer turn ()
                    //you can do this recursivly so you dont have to use a loop, but you can use a loop like we did before with the hash sets


        }
        void WinCheck()
        {           
            //check if there were four hits for player
                //reset board
            //chech if there were four hits for computer
                //reset board
        }

        void Reset()
        {
            //Call Random Assignment      
            //run loops that resets all the images to waves
            //set player count to 0
            //set computer hit count to 0
            //display ships
        }
    }
}