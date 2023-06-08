Console.WriteLine("Welcome to the Cat Dungeon!");

Console.WriteLine(@"

_._     _,-'""""`-._
(,-.`._,'(       |\`-/|
    `-.-' \ )-`( , o o)
          `-    \`_`""'-
                   .-.
                  / /
                 / |
   |\     ._ ,-""  `.
   | |,,_/  7        ;
 `;=     ,=(     ,  /
  |`@  @  ` |    \_,|
 .=; <> _ ; /  ,/'/ |
';|\,j_ \;=\ ,/   `-'
    `--'_|\  )
   ,' | /  ;'
  (,,/ (,,/      ");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(@"You find yourself in a damp cellar, the ground beneath you is cold and hard.
You can hear the sound of dripping water and the occasional scurrying of rats.
Beneath the light of flickering, greasy torch, you can see a wooden chest and a wooden door.

Do you:
A) Try to open the door
B) Try to open the chest");
Console.WriteLine();
string choice1 = Console.ReadLine();
Console.WriteLine();
Console.Clear();
if (choice1 == "A" || choice1 == "a")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@"As you try to open the door, you break your wrist and die.
THE END");
    Console.ResetColor();
}
else if (choice1 == "B" || choice1 == "b")
{
    Console.WriteLine("You open the chest, and a cute kitten hops out onto the floor.");
    Console.WriteLine(@" 
   |\---/|
   | ,_, |
    \_`_/-..----.
 ___/ `   ' ,""+ \  
(__...'   __\    |`.___.';
  (_,...'(_,.`__)/'.....+");
}
else
{
    Console.WriteLine("Invalid input");
}


Console.WriteLine("You approach the kitten, kneeling down to greet it. It hops up into your lap");
Console.WriteLine("Do you:\nA) Pet the cute little kitty\nB) Try to take the key from around it's neck\n");
string choice2 = Console.ReadLine();
Console.Clear();
if (choice2 == "A" || choice2 == "a")
{
    Console.WriteLine("\nYou pet the sweet kitty and it starts to purr. You feel happy inside. Everything is fine");
}
else if (choice2 == "B" || choice2 == "b")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nYou try to take the necklace from the kitten. It scratches you and you die");
    Console.ResetColor();
}
else
{
    Console.WriteLine("Invalid input");
}