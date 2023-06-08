using System.Threading.Channels;

Console.WriteLine("Enter the name of the first Pokemon");
string pok1Name = Console.ReadLine();
Console.WriteLine("Enter the name of the second Pokemon");
string pok2Name = Console.ReadLine();

int pok1Hp = 100;
int pok2Hp = 100;

Random rng = new Random();
int pok1Dmg;
int pok2Dmg;

Random randAttack = new Random();
string pok1Attack;
string pok2Attack;

int turncount = 1;

Console.WriteLine($"------------Turn {turncount} ------------");
while (pok1Hp > 0 && pok2Hp > 0) //while loop to check if either of the pokemon is dead (hp is 0 or less)
{
    //randomized attack for pok1
    if (randAttack.Next(0, 2) == 0)
    {
        pok1Attack = "tackle";
    }
    else
    {
        pok1Attack = "multistrike";
    }

    //randomized attack for pok2
    if (randAttack.Next(0, 2) == 0)
    {
        pok2Attack = "tackle";
    }
    else
    {
        pok2Attack = "multistrike";
    }

    //pok1 attack
    if (pok1Attack == "tackle")
    {
        pok1Dmg = rng.Next(10, 16); // 10 to 15 damage
        Console.WriteLine($"{pok1Name} attacks {pok2Name} with {pok1Attack} and deals {pok1Dmg} damage");
        pok2Hp -= pok1Dmg;
    }
    else if (pok1Attack == "multistrike")
    {
        for (int i = 0; i < 5; i++)
        {
            pok1Dmg = rng.Next(5, 11); // 5 to 10 damage
            Console.WriteLine($"{pok1Name} attacks {pok2Name} with {pok1Attack} and deals {pok1Dmg} damage");
            pok2Hp -= pok1Dmg;
        }
    }
    turncount++;

    if (pok2Hp < 0) pok2Hp = 0;
    WinCheck();

    Console.WriteLine();

    // pok2 attack
    if (pok2Attack == "tackle")
    {
        pok2Dmg = rng.Next(10, 16); // 10 to 15 damage
        Console.WriteLine($"{pok2Name} attacks {pok1Name} with {pok2Attack} and deals {pok2Dmg} damage");
        pok1Hp -= pok2Dmg;
    }
    else if (pok2Attack == "multistrike")
    {
        for (int i = 0; i < 5; i++)
        {
            pok2Dmg = rng.Next(5, 11); // 5 to 10 damage
            Console.WriteLine($"{pok2Name} attacks {pok1Name} with {pok2Attack} and deals {pok2Dmg} damage");
            pok1Hp -= pok2Dmg;
        }
    }

    if (pok1Hp < 0) pok1Hp = 0;
    WinCheck();

    Console.WriteLine();
    Console.WriteLine($"{pok1Name}: {pok1Hp}");
    Console.WriteLine($"{pok2Name}: {pok2Hp}");
    Console.WriteLine();

    
}

void WinCheck() //create winner checking method
{
    if (pok1Hp <= 0 && pok2Hp <= 0)
    {
        Console.WriteLine("Draw!"); //print battle is a tie
    }
    else if (pok1Hp <= 0)
    {
        Console.WriteLine($"{pok2Name} wins!"); //print pokemon2 wins
    }
    else if (pok2Hp <= 0)
    {
        Console.WriteLine($"{pok1Name} wins!"); //print pokemon1 wins
    }
}

//#region Turn2
//Console.WriteLine("------------Turn 2------------");
//pok1Dmg = rng.Next(10, 21);
//pok2Dmg = rng.Next(10, 21);

//Console.WriteLine($"{pok1Name} attacks {pok2Name} and deals {pok1Dmg} damage");
//Console.WriteLine($"{pok2Name} attacks {pok1Name} and deals {pok2Dmg} damage");

//pok1Hp -= pok2Dmg;
//pok2Hp -= pok1Dmg;

//Console.WriteLine($"{pok1Name}: {pok1Hp}");
//Console.WriteLine($"{pok2Name}: {pok2Hp}");
//#endregion

//#region Turn3
//Console.WriteLine("------------Turn 3------------");
//pok1Dmg = rng.Next(10, 21);
//pok2Dmg = rng.Next(10, 21);

//Console.WriteLine($"{pok1Name} attacks {pok2Name} and deals {pok1Dmg} damage");
//Console.WriteLine($"{pok2Name} attacks {pok1Name} and deals {pok2Dmg} damage");

//pok1Hp -= pok2Dmg;
//pok2Hp -= pok1Dmg;

//Console.WriteLine($"{pok1Name}: {pok1Hp}");
//Console.WriteLine($"{pok2Name}: {pok2Hp}");
//#endregion

//1.Fight to the death
//Currently we only implemented 3 turns of combat.
//Change the Code, so that the two pokemon fight until one of them is dead.
//2. Pick attack
//Next the Player should be able to choose between different attacks that the pokemon can perform.
//Hint: It is up to you if only Pokemon1 can pick its attack or if both Pokemon can pick their attacks.
//3. Multistrike
//One of the attacks should be a multistrike that hits the enemy 5 times. Use a for-loop to implement this mechanic.