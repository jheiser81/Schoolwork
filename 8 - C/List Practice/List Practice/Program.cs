List<int> intList = new List<int>();
intList.Add(0);
intList.Add(1);
intList.Add(2);
intList.Add(3);
intList.Add(4);

//printing using a for loop
//for (int i = 0; i < intList.Count; i++) //.Count is a built in function for lists that returns the number of elements in the list. It is similar to .Length for arrays.
//{
//    Console.WriteLine(intList[i]);
//}

//Console.WriteLine();

////printing using a foreach loop
////this is the preferred way to print lists
////How this works is that the foreach loop will go through each element in the list and assign it to the variable i.
////Then it will execute the code in the loop, which in this case is just printing the value of i.

foreach (int i in intList)
{
    Console.WriteLine(i);
}

Console.WriteLine();

//now lets remove the 2nd element in the list

intList.RemoveAt(1); //this will remove the element at index 1, which is the 2nd element in the list

//now lets print the list again to see if the 2nd element was removed

for (int i = 0; i < intList.Count; i++)
{
    Console.WriteLine(intList[i]);
}