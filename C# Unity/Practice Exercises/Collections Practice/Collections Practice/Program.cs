//Exercise #1:
//A) Declare an Integer-Array which can contain 20 values. Then use a For-Loop to set all those values to random numbers between 1 and 100.
//Print out all the values to the console.
//B) Do the same with an integer list

//int[] myArray = new int[20]; //[] denotes an array of the type indicated, in this case an array of integers. The size of the array is set to 20, meaning it has space to hold 20 integers (0-19)
//Console.WriteLine("1A) This is the array\n");

//for (int i = 0; i < myArray.Length; i++) //.Length will return the size of the array
//{
//    Random random = new Random();
//    myArray[i] = random.Next(1, 101); //1 is the lower bound and 101 is the upper bound of the array. random.Next will return a random number between those two values

//    Console.WriteLine(myArray[i]);
//    Console.WriteLine("--");
//}

//Console.WriteLine("----------------------------------------------");

//List<int> MyList = new List<int>(); //This creates a list of integers. With a List, the type is declared between the <>. Unlike an array the size of the list is not set, it will grow as needed.
//Console.WriteLine("1B) This is the list\n");

//for (int i = 0; i < 20; i++)
//{
//    Random random = new Random();
//    MyList.Add(random.Next(1, 101)); //with a List you can just use .Add to add a value to the list

//    Console.WriteLine(MyList[i]);
//    Console.WriteLine("--");
//}

//Exercise #2:
//A)Declare a String-List and read Text from the console in an Endless-Loop.
//Whenever the player enters something add it to the List.

//B) When the player enters the string “stop” print every item in the list in the reversed order.
//i.e.the player enters:
//Bob
//Cat
//Monkey
//Stop

//You program should output:
//Monkey
//Cat
//Bob

List<string> MyList2 = new List<string>();

while (true)
{
    string input = Console.ReadLine();

    if (input == "stop")
        break;
    else
        MyList2.Add(input);
}
for (int i = 0; i < MyList2.Count; i++)
{
    Console.WriteLine(MyList2[i]);
}

//reverse order

//List<string> MyList2 = new List<string>();

//while (true)
//{
//    string input = Console.ReadLine();

//    if (input == "stop")
//        break;
//    else
//        MyList2.Add(input);
//}
//Console.WriteLine("Printing in reversed order");
//for (int i = MyList2.Count - 1; i >= 0; i--)
//{
//    Console.WriteLine(MyList2[i]);
//}

Console.WriteLine("Printing in sorted order");
for (int i = 0; i < MyList2.Count; i++)
{
    Console.WriteLine(MyList2[i]);
}