/* //this starts a block to be commented out, until it reaches the specified end point 
 
Random rng = new Random();//declare a new random number generator
int num1 = rng.Next(11); //declare and initialize a variable to hold a random number, define the range of the random numbers generated. In this case, the range is 0-2, because 0 is set as the starting point.
Console.WriteLine(num1);

int num2 = rng.Next(10, 16); //this time, the range is 10-15, because 10 is set as the starting point.
Console.WriteLine(num2);

int x = 5;
int y = 10;
int temp = x; //temp is now holding the value of x, which is 5
x = y; //x is now holding the value of y, which is 10
y = temp; //y is now holding the value of temp, which is 5
temp = x;

Console.WriteLine("X:" + x);
Console.WriteLine("Y: " + y);

Console.WriteLine("Enter the name of your favourite food");
string bestFood = Console.ReadLine();
Console.WriteLine("Enter the name of your least favourite food");
string worstFood = Console.ReadLine();

Console.WriteLine("Whooosh! A magician suddenly inverts your tastes!");
Console.WriteLine("Your favourite food is now " + worstFood);
Console.WriteLine("Your least favourite food is now " + bestFood);

i neeed to now invert the values of bestFood and worstFood
how can i do this?

string foodTemp = bestFood;//foodtemp is now holding the value of bestFood
bestFood = worstFood;//bestfood is now holding the value of worstFood
worstFood = foodTemp;//worstfood is now holding the value of foodTemp

#region Exercise A

//A) Bugfixing
//Look at the following code and check its output. 2 + 3 is normally not 23
//Try to fix the code so that it works as intended.

int num1 = int.Parse("2");
int num2 = int.Parse("3");
string sum = (num1 + num2).ToString();
Console.WriteLine("A) " + sum);
#endregion

#region Exercise B

//B) Simple Calculator
//The player should be able to input 2 numbers that are multiplied and the result is printed to the console.

Console.WriteLine("Enter first number");
int input1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int input2 = Convert.ToInt32(Console.ReadLine());
int result = input1 * input2;
Console.WriteLine($" The result of {input1} * {input2} is {result}");
#endregion

*/ //this ends the block of commented out code

#region Exercise C

//C) Random Damage
//Change the code, so that the player deals between 10 and 15 damage to the enemy.
using System.Runtime.CompilerServices;

Random randDmg = new Random();//create random number generator
int enemyHealth = 100;//set enemy health to 100
int damage = randDmg.Next(10, 16);//set range of damage between 10-15
    enemyHealth -= damage;//subtract damage from enemy health
Console.WriteLine($"The enemy took {damage} damage! It now has {enemyHealth} health remaining.");
#endregion

