//while loops
Random rng = new Random();
int score = 0;
int dice1 = 0; rng.Next(1, 7);

while (dice1 != 1)
{
    dice1 = rng.Next(1, 7);
    if (dice1 != 1)
    {
        score += dice1;
        Console.WriteLine($"You rolled a {dice1}. Current score: {score}");
    }
}
Console.WriteLine($"You rolled a 1. Final score: {score}");

int i = 0;
while (i < 10) //while i is less than 10, keeps counting (iterating)
{
    i++;
    if (i == 5) //creates an if condition inside the while loop
    {
        break; //break immediately ends the loop, and moves to the code outside the loop
        //if you use continue instead, 5 will be skipped in the counting
    }
    Console.WriteLine(i);
}
Console.WriteLine("Finished counting");

//endless loops

int j = 0;
while (true)
{
    j++;
    Console.WriteLine(j); //this statement would make the while loop endless

    if (j == 500) //condition
    {
        break; //break will end the loop once it reaches 500
    }
}
Console.WriteLine("Finished counting");

Console.WriteLine("Where do you want to go?");
Console.WriteLine("a) left");
Console.WriteLine("b) right");

while (true)
{
    string input = Console.ReadLine();

    if (input == "a")
    {
        Console.WriteLine("You went left into the woods");
        break; //breaks out of the loop
    }
    else if (input == "b")
    {
        Console.WriteLine("You went right into the ruins");
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. \nEnter your decision again");

        //this will prompt the player to choose between a or b again, since anything else is invalid
        //this will continue as long as the input is invalid
        //once a valid decision is input, the program will continue
        //if this isn't implemented, choosing an invalid input would print the message, but would also end the program
    }
}