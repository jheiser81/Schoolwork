using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Dog_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Instructions

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

        #endregion Instructions

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Dog

            Dog myDog = new Dog("Jeff", 3, "Labrador Retriever", "the dog", "Yoda chew toy", "3 out of 5");
            // create an instance of the Dog class using the constructor and pass in "Jeff" as the name, 5 as the age, and "Labrador Retriever" as the breed.
            richTextBox1.Text = $"{myDog.Name} {myDog.Species} is {myDog.Age} years old, and is a {myDog.Breed}. {myDog.Name}'s current drool level is {myDog.droolLevel}. His favourite toy is a {myDog.favToy}.\n{myDog.Bark()}\n{myDog.WagTail()}.";

            #endregion Dog

            #region Cat

            Cat myCat = new Cat("Tiamat", 5, "Bombay", "the cat", "to rule the world!", "supreme indifference");
            richTextBox1.Text += $"\n\n{myCat.Name} {myCat.Species} is {myCat.Age} years old, and is a {myCat.Breed}. She gazes at you with {myCat._indifference}. Her mission is to {myCat._mission}\n{myCat.Meow()}\n{myCat.Purr()}\n{myCat.Hiss()}\n{myCat.Name}{myCat.SitsOnKeyboard()}";

            #endregion Cat

            #region Snake

            Snake mySnake = new Snake("Slithers", 15, "Ball Python", 5, "the snake", venomous: false);
            richTextBox1.Text += $"\n\n{mySnake.Name} {mySnake.Species} is {mySnake.Age} years old, and is a {mySnake.Breed}. He is {mySnake._length} feet in length.";
            richTextBox1.Text += $" It is {mySnake._venomous} that he is venomous, since pythons are constrictors.\n";

            #endregion Snake

            #region Eating

            richTextBox1.Text += $"\n{myDog.Name} {myDog.Species}{myDog.Eating()}";
            richTextBox1.Text += $"\n{myCat.Name} {myCat.Species}{myCat.Eating()}";
            richTextBox1.Text += $"\n{mySnake.Name} {mySnake.Species}{mySnake.Eating()}\n";

            #endregion Eating

            #region Sleeping

            richTextBox1.Text += $"\n{myDog.Name} {myDog.Species}{myDog.Sleeping()}. {myDog.Name}{myDog.Aging()}";
            richTextBox1.Text += $"\n{myCat.Name} {myCat.Species}{myCat.Sleeping()}. {myCat.Name}{myCat.Aging()}";
            richTextBox1.Text += $"\n{mySnake.Name} {mySnake.Species}{mySnake.Sleeping()}. {mySnake.Name}{mySnake.Aging()}\n\n";

            #endregion Sleeping

            #region Polymorphism

            Animal[] kingdom = new Animal[3]; //creating an object array with the Animal class and kingdom as the name, with 3 elements
            kingdom[0] = new Dog("Enzo", 5, "dachshund", "the dog", "frisbee", "2/5"); //creates new instance of the animal class, number in the brackets is the element number
            kingdom[1] = new Cat("Miss Cleo", 7, "Eqyptian Longhair", "the cat", "to receive bellyrubs all day", "indifference level 1/5");
            kingdom[2] = new Snake("Apollo", 10, "Corn Snake", 12, "the snake", venomous: false);
            for (int i = 0; i < kingdom.Length; i++) //for loop to go through the array
            {
                richTextBox1.Text += $"{kingdom[i].Name} {kingdom[i].Species}{kingdom[i].Eating()}\n";
                richTextBox1.Text += $"{kingdom[i].Name} {kingdom[i].Species}{kingdom[i].Sleeping()}\n";
            }

            Cat newCat = new Cat("Fluffy", 3, "Siamese", "the cat", "to catch ALL OF THE BIRDS", "indifference level 3/5");// creating new instances of the animal class
            Dog newDog = new Dog("Buddy", 5, "Golden Retriever", "the dog", "a gross old bone", "5/5");
            Snake newSnake = new Snake("Sneaky", 2, "Garter Snake", 3, "the snake", venomous: false);

            FeedAnimal(newDog); //calling the method FeedAnimal and passing in the new instances of the animal class
            FeedAnimal(newCat);
            FeedAnimal(newSnake);

            #endregion Polymorphism
        }

        public void FeedAnimal(Animal animal) //method with the parameter animal, which is an instance of the animal class
        {
            richTextBox1.Text += $"\n{animal.Name} {animal.Species}{animal.Eating()}\n";
        }
    }
}