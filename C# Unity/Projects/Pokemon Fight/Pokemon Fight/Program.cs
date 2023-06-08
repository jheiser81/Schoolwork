
Console.WriteLine(@"
                                  ,'\
    _.----.        ____         ,'  _\   ___    ___     ____
_,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |`.
\      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ |  |
 \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \|  |
   \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |
    \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |
     \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |
      \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |
       \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |
        \_.-'       |__|    `-._ |              '-.|     '-.| |   |
                                `'                            '-._|\");

#region Global Variables
int pokemon1HP = 100; //set pokemon1HP to 100
int pokemon2HP = 100; //set pokemon2HP to 100
Random rndDmg = new Random(); //create random number generator for pokemon1 and pokemon2
#endregion

#region Battle Contestants
Console.WriteLine("Enter the name of your first pokemon: \n"); //ask for name of pokemon1
string pokemon1 = Console.ReadLine();//user inputs name of pokemon1
Console.WriteLine(); //create linebreak

Console.WriteLine("Enter the name of your second pokemon: \n"); //ask for name of pokemon2
string pokemon2 = Console.ReadLine(); //user inputs name of pokemon2
Console.WriteLine(); //create linebreak
#endregion  

#region Battle Message
Console.WriteLine($"{pokemon1} vs {pokemon2}\n"); //print battle message, new line
Console.WriteLine($"Commence battle? (YES/NO)\n"); //ask if user wants to start battle

string battle = Console.ReadLine(); //user inputs yes or no
Console.WriteLine(); //create linebreak

if (battle.ToUpper() == "YES") //if user inputs yes, made uppercase to avoid errors
{
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("Battle starting!\n"); //print battle commencing, new line
}
else //if user inputs no
{
    Console.WriteLine("Battle cancelled!"); //print battle cancelled
    return; //exit program
}
#endregion

#region Battle
void Attack(int numberOfAttacks) //create attack method, with number of attacks as parameter
{
    for (int attackCounter = 0; attackCounter < numberOfAttacks; attackCounter++) //for loop to repeat attack method 3 times
    {
        if (pokemon1HP <= 0 || pokemon2HP <= 0) //if pokemon1HP or pokemon2HP is less than or equal to 0
        {
            break; //break out of loop
        }

        int P1dmg = rndDmg.Next(5, 16); //random number between 5 and 15 for pokemon1 attack
        int P2dmg = rndDmg.Next(5, 16); //random number between 5 and 15 for pokemon2 attack

        int firstAttacker = rndDmg.Next(1, 3); //randomly select which Pokemon attacks first 

        if (firstAttacker == 1) //if firstAttacker is equal to 1
        {
            Console.WriteLine($"{pokemon1} attacks first!\n"); 
            
            // Pokemon 1 attacks first
         
            pokemon2HP -= P1dmg; //subtract pokemon1 attack from pokemon2HP
            if (pokemon2HP < 0) //if pokemon2HP is less than 0
            {
                pokemon2HP = 0; //set pokemon2HP to 0
            }

            // Pokemon 2 attacks second

            pokemon1HP -= P2dmg; //subtract pokemon2 attack from pokemon1HP
            if (pokemon1HP < 0) //if pokemon1HP is less than 0
            {
                pokemon1HP = 0; //set pokemon1HP to 0
            }

            Console.WriteLine($"{pokemon1} attacks {pokemon2} and deals {P1dmg} damage!");
            Console.WriteLine($"{pokemon2} attacks {pokemon1} and deals {P2dmg} damage!\n");
        }
        else
        {
            Console.WriteLine($"{pokemon2} attacks first!\n");

            // Pokemon 2 attacks first
            pokemon1HP -= P2dmg;
            if (pokemon1HP < 0)
            {
                pokemon1HP = 0;
            }

            // Pokemon 1 attacks second
            pokemon2HP -= P1dmg;
            if (pokemon2HP < 0)
            {
                pokemon2HP = 0;
            }

            Console.WriteLine($"{pokemon2} attacks {pokemon1} and deals {P2dmg} damage!");
            Console.WriteLine($"{pokemon1} attacks {pokemon2} and deals {P1dmg} damage!\n");
        }

        Console.WriteLine($"{pokemon1} has {pokemon1HP} HP remaining \n{pokemon2} has {pokemon2HP} HP remaining\n"); //print remaining pokemon1HP and pokemon2HP, new line
    }

    RoundResult(); //call battle result method
}


#endregion

#region Round End
void RoundResult() //create battle result method
{
    if (pokemon1HP > pokemon2HP) //if pokemon1HP is greater than pokemon2HP
    {
        Console.WriteLine($"{pokemon1} wins!"); //print pokemon1 wins
    }
    else if (pokemon2HP > pokemon1HP) //if pokemon2HP is greater than pokemon1HP
    {
        Console.WriteLine($"{pokemon2} wins!"); //print pokemon2 wins
    }
    else //if pokemon1HP is equal to pokemon2HP
    {
        Console.WriteLine("Draw!"); //print battle is a tie
    }
}
#endregion

#region Next Round
string continueBattle = "YES";
while (continueBattle.ToUpper() == "YES" && pokemon1HP > 0 && pokemon2HP > 0)
{
    Attack(3); //call attack method 3 times

    if (pokemon1HP > 0 && pokemon2HP > 0) //if pokemon1HP and pokemon2HP is greater than 0
    {
        Console.WriteLine("Do you want to continue to the next round? YES/NO\n"); 
        continueBattle = Console.ReadLine().ToUpper(); //turns input into uppercase to avoid errors
        Console.WriteLine();

        if (continueBattle.ToUpper() == "YES")  
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Next round starting!\n");
        }
    }
}

if (pokemon1HP == 0 || pokemon2HP == 0 || continueBattle.ToUpper() == "NO") //if pokemon1HP or pokemon2HP is equal to 0 or user inputs no
{
    Console.WriteLine("Battle ended.");
}
#endregion




