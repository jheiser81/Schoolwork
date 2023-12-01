using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dog_OOP
{
    //Create a class called "Dog" with the following private fields:
    //•string name
    //•int age
    //•string breed

    //Create a constructor that takes in three parameters: "name", "age", and "breed". Inside the constructor, set the corresponding fields using the parameters.

    //Add public getters and setters for each field.The getter for "name" should return the name as a string, the getter for "age" should return the age as an int, and the getter for "breed" should return the breed as a string. The setters for all three fields should take in a value and set the corresponding field to that value.

    //Add the following public methods to the class:
    //•    string Bark(): returns "Woof!" .
    //•    string WagTail(): returns "Tail wagging...".

    //In the "Form1" class Form1_Load, create an instance of the Dog class using the constructor and pass in "Jeff" as the name, 5 as the age, and "Labrador Retriever" as the breed.Use the getters to output the values of the name, age, and breed fields to the console.

    //Finally, call the Bark and WagTail methods on the dog instance and observe their output into a richTextbox.

    //    Try making the getters and setters in the three different ways I demonstrated in class:
    //name in the traditional way GetName() SetName().
    //age in the more protected way using if statements Age { get { return_age; } set { if.....} }
    //    breed as the shorthand.Breed { get; set; }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dog myDog = new Dog("Jeff", 5, "Labrador Retriever");// create an instance of the Dog class using the constructor and pass in "Jeff" as the name, 5 as the age, and "Labrador Retriever" as the breed.

            //interpolated way
            richTextBox1.Text = $"{myDog.GetName()} is {myDog.Age} years old, and is a {myDog.Breed}.\n{myDog.Bark()}\n{myDog.WagTail()}";

            //richTextBox1.Text = "Name: " + myDog.GetName() + "\n" +
            //    "Age: " + myDog.Age.ToString() + "\n" +
            //    "Breed: " + myDog.Breed + "\n" +
            //    myDog.Bark() + "\n" +
            //    myDog.WagTail();

            Cat myCat = new Cat("Tiamat", 5, "Bombay", "to rule the world!");

            richTextBox1.Text += $"\n\n{myCat.Name} is {myCat.Age} years old, and is a {myCat.Breed}. Her mission is to {myCat.Mission}.\n{myCat.Meow()}\n{myCat.Purr()}\n{myCat.Hiss()}";

            Bank Bank = new Bank(123456789, "Checking", 5050.50);

            richTextBox1.Text += $"\n\nYou withdraw {Bank.Withdraw(1000.25)} from your {Bank.AccountType} account. Your new balance is {Bank.Balance}.";
        }
    }
}