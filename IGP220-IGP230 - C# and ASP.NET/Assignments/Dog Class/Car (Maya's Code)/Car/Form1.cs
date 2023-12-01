namespace Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vehicle[] vehicle = new Vehicle[3];
            Car mazdaCX5 = new Car("Mazda", "CX5", 2022, 2, 5);
            Car FordTaurus = new Car("Ford", "Taurus", 2024, 4, 13);
            Truck DodgeRAM = new Truck("Dodge", "RAM", 2004, 2);
            mazdaCX5.SetVIN(45678);
            MessageBox.Show("the mazda VIN is: " + mazdaCX5.GetVIN().ToString());
            mazdaCX5.Age = 6;
            MessageBox.Show("the mazda age is: " + mazdaCX5.Age.ToString());
            MessageBox.Show("the mazda door count is: "+ mazdaCX5.NumDoors.ToString());
            vehicle[0] = mazdaCX5;
            vehicle[1] = FordTaurus;
            vehicle[2] = DodgeRAM;
            for (int i = 0; i < vehicle.Length; i++)
            {
                richTextBox1.Text += vehicle[i].Drive() + "\n";
            }
        }
    }
}