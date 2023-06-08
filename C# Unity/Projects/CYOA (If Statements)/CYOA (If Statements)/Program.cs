
Console.WriteLine("You are in a creepy house! With a creepy staircase! Do you want to go \nA: upstairs \nor \nB: into the kitchen?\n");
string input = Console.ReadLine();

if (input == "a")
{
    Console.WriteLine();
    Console.WriteLine("You went up the creepy staircase!\n");
}
else if (input == "b")
{
    Console.WriteLine();
    Console.Write("You skipped the creepy staircase and went into the kitchen...which was even creepier!!!\n");
}

//Club Entry
int age = 18;
bool isFemale = false;
int ClubPopulation = 30;

if (age >= 18 && (ClubPopulation < 100 || isFemale == true)) //code in inner brackets is evaluated first
{
    Console.WriteLine("You are allowed in");
}