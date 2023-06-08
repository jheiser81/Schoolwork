#region About Lists

//In C#, lists are another type of collection. They differ from arrays in a few key ways.

//Lists are dynamic, meaning they can grow and shrink in size as needed.
//With lists, you can insert a new item into a specific index, and the items after it will be moved down to make room.
//Lists also have a built-in sorting ability. The sorting is done alphabetically by default, but you can also specify a custom sorting method
//Lists are technically slower than arrays, but unless you're working with a very large amount of data, you won't notice the difference.
//Lists can hold any type of data, including other lists. They can also hold different types of data in the same list.

#endregion

#region Creating Lists

//Creating lists is similar to how we make arrays, but there are a few differences.
//Instead of using square brackets, we use angle brackets to specify the type of data the list will hold.
//This is also followed by parentheses at the end.

//For example, if we wanted to create a list of strings, we would do it like this:

List<string> stringList = new List<string>();

//Note that we did not specify a size for the list. This is because lists grow and shrink as needed.

#endregion

#region Adding Items to Lists

//To add items to a list, we use the .Add() method.

//For example, if we wanted to add some strings to our list, called "first entry", "third entry" and "fourth entry,  we would do it like this:

stringList.Add("first entry");
stringList.Add("third entry");
stringList.Add("fourth entry\n");

//Note that we did not add a second entry. This is because lists do not need to be filled in order, and we will add a second entry later.

#endregion

#region Accessing Items in Lists

//To access items in a list, we use the same syntax as we do with arrays.
//We use square brackets and the index of the item we want to access.

//For example, if we wanted to access the first item our list, we would do this:

Console.WriteLine(stringList[0]);

//Note that we used 0 as the index. This is because lists, like arrays, are zero-indexed.

#endregion

#region Inserting Items into Lists

//Lists have a built-in method for inserting items into a specific index.
//This method is called .Insert(), and it takes two parameters: the index to insert the item at, and the item to insert.

//For example, if we wanted to insert the missing second entry into our list, we would do it like this:

stringList.Insert(1, "second entry");

//Here, we specified 1 as the index, and "second entry" as the item to insert.
//This will insert the new item at index 1, and move the third and fourth items down to indices 2 and 3, respectively.

Console.WriteLine(stringList[1]);
Console.WriteLine(stringList[2]);
Console.WriteLine(stringList[3]);

//Now that we've inserted the missing second entry, we can access it like any other item in the list, and it will print out "second entry".

#endregion

#region Removing Items from Lists

//Lists have a built-in method for removing items from a list as well.
//This method is called .Remove(), and it takes only one parameter: the item to remove.

//For example, if we wanted to remove the third entry from our list, we would do it like this:

stringList.Remove("third entry");

//This will remove the third entry from the list, and move the fourth entry up to index 2.
//You don't need to specify the index of the item to remove here, only the item itself.
//Note that you must print out the list again to see the changes, because the list is not automatically updated when you remove an item.

//Console.WriteLine(stringList[0]);
//Console.WriteLine(stringList[1]);
//Console.WriteLine(stringList[2]);
//Console.WriteLine(stringList[3]); //This will give an error, because there is no item at index 3 anymore since we removed it.

//This is a bit ineffecient printing out the entire list, so it's easier to use a loop to print out the list, like so:
Console.WriteLine("For loop:");
Console.WriteLine("------------");
for (int i = 0; i < stringList.Count; i++)
{
    Console.WriteLine(stringList[i]);
}

//or you can use a foreach loop, like so:
Console.WriteLine("Foreach loop:");
Console.WriteLine("------------");
foreach (string item in stringList) //This places each item in the list into the variable "item", and then uses the loop to print out each item.
{
    Console.WriteLine(item);
}

//Alternatively you could create a method to print out the list, and call it whenever you need to print out the list.
//This is a bit more complicated, but it's more efficient than using a loop every time you need to print out the list.

//You can also remove items by index, using the .RemoveAt() method.
//This method takes only one parameter: the index of the item to remove.

#endregion

#region Sorting Lists

//Lists have a built-in method for sorting items in a list.
//This method is called .Sort(), and it takes no parameters.

//For example, if we wanted to sort our list alphabetically, we would do it like this:

stringList.Sort();

//This will sort the items in the list alphabetically, and print them out in order.
//There are also other ways to sort lists, such as by length, reverse alphabetical order, or a custom sorting method.
//These can be complicated and hard to remember, so it's best to look them up when you need them, rather than trying to memorize them.

#endregion

#region Lists of Lists

//Lists can hold any type of data, including other lists.
//This means that we can create a list of lists, and use it to store data in a grid-like format.
//This is useful for storing data that has multiple values, such as a grid of numbers or a grid of strings.
//This is somewhat similar to a 2D array, but lists are more flexible and easier to work with.

//For example, in the code below, we create a list of lists, and use it to store a grid of numbers.
//We then print out the grid to the console.

List<List<int>> gridList = new List<List<int>>();
gridList.Add(new List<int>() { 1, 2, 3 });
gridList.Add(new List<int>() { 4, 5, 6 });
gridList.Add(new List<int>() { 7, 8, 9 });

for (int i = 0; i < gridList.Count; i++)
{
    for (int j = 0; j < gridList[i].Count; j++)
    {
        Console.Write(gridList[i][j] + " ");
    }
    Console.WriteLine();
}

//This syntax looks a bit complicated, but it's just the angle brackets nested inside each other.
//Note that we used a nested for loop to print out the grid.
//This is because we need to loop through each list in the list of lists, and then loop through each item in that list.
//A list of lists is usually called a "jagged array", because each list can be a different size, even though it's technically not an array.

#endregion