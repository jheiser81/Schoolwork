
#region Exercise 1
//Exercise 1
//Print the numbers from 1 to 15 once with a while loop and then again with a for-loop.
//Change the code, so that the loops instead of counting up from 1 to 15 they count down from 15 to 1.

int i = 1;

while (i < 15)
{
    i++;
    Console.WriteLine(i);
}

Console.WriteLine();

for (int j = 1; j <= 15; j++)
{
    Console.WriteLine(j);
}

Console.WriteLine();

int x = 15;

while (x > 0)
{
    Console.WriteLine(x);
    x--;
}

Console.WriteLine();

for (int j = 15; j > 0; j--)
{
    Console.WriteLine(j);
}

Console.WriteLine();
#endregion

#region Exercise 2
//Exercise 2
//Create an endless-loop, in which the user is prompted to enter a Command. When the user enters “quit” the program should break out of the loop.
//If the user enters anything else it should print “Unknown Command”.

while (true) //initialize the loop
{
    Console.WriteLine("Enter a command");
    string input = Console.ReadLine();

    if (input == "quit")
    {
        break;
    }
    else if (input == "go")
    {
        Console.WriteLine("Going, going, gone");
    }
    else
    {
        Console.WriteLine("Unknown Command");
    }
}
#endregion


//Exercise 3
//Create a hitpoint-Variable and set it to 100. Now create an endless-loop. 
//Within this loop the user should be able to enter numbers. The hitpoint-Variable should be reduced by this number.
//When the hitpoints reach 0 print the message “Player died” and exit the loop.

int hitpoints = 100;

 while (true) 
{
    Console.WriteLine("Enter a number for damage"); 
    string input = Console.ReadLine(); 
    int dmg = Convert.ToInt32(input); 
    hitpoints -= dmg; 
    Console.WriteLine($"Remaining hitpoints: {hitpoints}");

    if (hitpoints <= 0) 
    {
        Console.WriteLine("You die"); 
        break; 
    }
}

//1)set hitpoints to 100
//2)create while loop
//3)prompt user to enter number for damage
//4)converts the number stored in string 'input' to an integer
//5)subtract the damage from the hitpoints
//6)print the remaining hitpoints
//7)if the hitpoints are less than or equal to 0, print "You die" and break the loop



