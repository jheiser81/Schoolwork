//Exercise If-Statements

#region Exercise 1) Choose your Path
//Create if-Statements that react to the users input.
//It could i.e. respond to decision a:
//"You went into the castle and got spooked by ghosts"

//a) React to Player-Input
//b) Handle invalid input

Console.WriteLine("-----------------1) Choose your Path -----------------\n");
Console.WriteLine("Where do you want to go?");
Console.WriteLine("a: Left into the spooky castle");
Console.WriteLine("b: Straight ahead into the spooky wood");
Console.WriteLine("c: Right into the Rainbow Wonderland");
string input1 = Console.ReadLine();
if (input1 == "a")
{
    Console.WriteLine("You turned left into the castle and got spooked by ghosts.");
}
else if (input1 == "b")
{
    Console.WriteLine("You went straight ahead into the spooky wood.");
}
else if (input1 == "c")
{
    Console.WriteLine("You turned right, into the Rainbow Wonderland. ");
}
else
{
    Console.WriteLine("Invalid input");
}
Console.WriteLine();
#endregion

#region Exercise 2) Find the Bug
//Console.WriteLine("-----------------2) Find the Bug-----------------");

////When the player enters anything different than a||b or c
////he should get the message: "Invalid input!"

////Here we have a Damage-Calculation, where the player can be invulnerable
////If the player is invulnerable he should not receive any damage.
////Currently the player receives damage even if he is invulnerable. Find and fix the bug!

int playerHp = 100;
int damage = 10;

bool isPlayerInvulnerable = true;
bool playerHasArmor = false;

Console.WriteLine("Player HP before attack: " + playerHp);
if (isPlayerInvulnerable == true)
{
    Console.WriteLine("No damage received!");
}
else if (playerHasArmor == true)
{
    playerHp -= damage / 2;
}
else if (playerHasArmor == false)
{
    playerHp -= damage;
}
Console.WriteLine("Player HP after attack: " + playerHp);
#endregion

#region Exercise 3) Puzzle Game
//a) There is only one correct solution to the puzzle:
//Left Lever: up
//Center Lever: down
//Right Lever: up

//If the player sets the levers this way he should get the message:
//"The door that blocked your way opens. You are free to continue your adventure."

//b) Dangerous Situations
//Left Lever: up
//Center Lever: down
//Right Lever: down

//Left Lever: down
//Center Lever: down
//Right Lever: up

//If the player sets the levers in one of these ways he should get the message:
//"Oh no! A trapdoor beneath you opens and you fall to your death :("

//c) Handle remaining Situations
//If the player sets the levers in any other way, he should get the message:
//"Nothing happens"

Console.WriteLine("-----------------3) Puzzle Game-----------------");

Console.WriteLine("Which position would you like to put the left lever into [up|down]");
string leftLeverState = Console.ReadLine();
Console.WriteLine("Which position would you like to put the center lever into [up|down]");
string centerLeverState = Console.ReadLine();
Console.WriteLine("Which position would you like to put the right lever into [up|down]");
string rightLeverState = Console.ReadLine();

if (leftLeverState == "up" && centerLeverState == "down" && rightLeverState == "up")
{
    Console.WriteLine("The door the blocked your way opens. You are free to continue your adventure.");
}
else if ((leftLeverState == "up" && centerLeverState == "down" && rightLeverState == "down") ||
        (leftLeverState == "down" && centerLeverState == "down" && rightLeverState == "up"))
{
    Console.WriteLine("Oh no! A trapdoor beneath you opens and you fall to your death :(");
}
else
{
    Console.WriteLine("Nothing happens");
}
#endregion

#region Exercise 4) The Switch Statement (Optional)

//a) Rewrite the if-Statements from Exercise 1) using a switch statement instead.

string userInput = Console.ReadLine();

switch (userInput) //doesn't seem to really do anything different than the if statements, it's the same outcome, just a different way of writing it.
{
    case "a":
        Console.WriteLine("You turned left into the castle and got spooked by ghosts.");
        break;
    case "b":
        Console.WriteLine("You went straight ahead into the spooky wood.");
        break;
    case "c":
        Console.WriteLine("You turned right, into the Rainbow Wonderland. ");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}
#endregion


