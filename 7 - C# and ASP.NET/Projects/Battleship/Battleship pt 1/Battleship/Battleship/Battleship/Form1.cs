namespace Battleship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PictureBox[,] playerboard = new PictureBox[10, 10];
        private PictureBox[,] computerboard = new PictureBox[10, 10];

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintBoard();
        }

        private void PrintBoard()
        {
            //Playerboard

            int xpos = 45;
            int ypos = 45;
            for (int i = 0; i < playerboard.GetLength(0); i++)
            {
                for (int j = 0; j < playerboard.GetLength(1); j++)
                {
                    playerboard[i, j] = new PictureBox
                    {
                        Name = "picturebox" + i.ToString(),
                        Location = new Point(xpos, ypos),
                        Size = new Size(45, 45),
                        Visible = true,
                        BackColor = Color.LightBlue,
                        ImageLocation = "./Wave background.png"
                    };
                    this.Controls.Add(playerboard[i, j]);
                    xpos += 45;
                }
                xpos = 45;
                ypos += 45;
            }

            //Computerboard

            int computerXpos = xpos + 500;
            int computerYpos = 45;
            for (int i = 0; i < computerboard.GetLength(0); i++)
            {
                for (int j = 0; j < computerboard.GetLength(1); j++)
                {
                    computerboard[i, j] = new PictureBox
                    {
                        Name = "Computerboard" + i.ToString(),
                        Location = new Point(computerXpos, computerYpos),
                        Size = new Size(45, 45),
                        Visible = true,
                        BackColor = Color.LightBlue,
                        ImageLocation = "./Wave background.png"
                    };
                    this.Controls.Add(computerboard[i, j]);
                    computerXpos += 45;
                }
                computerXpos = xpos + 500;
                computerYpos += 45;
            }
        }

        private void RandomAssignment()
        {
        }
    }
}