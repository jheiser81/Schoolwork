namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //bubble sort

            int[] myArray = { 33, 55, 4, 32, 1, 2, 3 };
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        int temp = myArray[j];
                        myArray[j] = myArray[i];
                        myArray[j] = temp;
                    }
                }
            }
            {
            }
        }
    }
}