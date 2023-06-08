#region Array Declaration

//In C#, we declare an array by specifying the data type of the array followed by square brackets and the name of the array variable.
//This is followed by the equal sign and the keyword 'new', then the data type of the array element, followed by square brackets with the number of elements in the array inside them.

//datatype[] arrayName = new datatype[number of array elements];

//Arrays can also be declared without specifying the number of elements in the array.
//In this case, the array is declared with no elements, but the number of elements can be specified later.

//Arrays can hold values of any data type, but the elements in a single array must all be of the same data type.

int[] intArray = new int[5]; // Declares an array of integers with 5 elements
string[] stringArrray = new string[10]; // Declares an array of strings with 10 elements
char[] charArray = new char[100]; // Declares an array of characters with 100 elements
object[] objectArray = new object[4]; // Declares an array of objects with 4 elements

#endregion

#region Accessing Array Elements

//Array elements are accessed by specifying the index of the element in square brackets.
//The index of the first element in an array is 0, the second element is 1, and so on.

//int[] myArrary = new int[5];
//myArrary[0] = 10;
//myArrary[1] = 200;
//myArrary[2] = 40;
//myArrary[3] = 400;
//myArrary[4] = 55;

//Console.WriteLine(myArrary[2]);

//This will print 40 to the console, because it is the third element in the array.

#endregion

#region Changing Array Elements

//Array elements can be changed by specifying the index of the element in square brackets and assigning a new value to it.
//It is useful to think of arrays as a list of variables or as a box with compartments, where each element in the array is a variable of a certain data type.
//So, to change the value of an element in an array, you just assign a new value to it by specifying the index of the element you want to change.
//This is often done in a for loop, where the index of the array is used to iterate through the elements in the array.
//For example: We will declare a new array of 5 intgers, and then use a for loop to iterate through the array and set each element to 100.
//
//int[] myArray = new int[5];
//for (int i = 0; i < 5; i++)
//{
//    myArray[i] = 100;
//    Console.WriteLine(myArray[i]);
//}
//This will now reassign each element in the array to have a value of 100.

#endregion

#region Hard Coding Array Elements

//Array elements can also be hard coded when the array is declared. This is done by enclosing the elements in curly braces and separating them with commas.
//This is more efficient and takes less lines of code, however you cannot change the values of the elements later in the program, so it limits the flexibility of the array.
//This is useful when you know the values of the elements in the array when you declare it, but this is not always possible.

//int[] myArray = new int[] { 10, 200, 40, 400, 55 };

//Console.WriteLine(myArray[4]);

//This will print 55 to the console, because it is the fifth element in the array.

#endregion

#region For Loops and Arrays

//For loops are often used to iterate through the elements in an array.
//The for loop is set up to run for the number of elements in the array, and the index of the array is used to access each element in the array.

//int[] enemyHP = new int[8];

//for (int i = 0; i < enemyHP.Length; i++)
//{
//    enemyHP[i] = 100;
//}

//for (int i = 0; i < enemyHP.Length; i++)
//{
//    Console.WriteLine($"Enemy has {enemyHP[i]} HP");
//}

//This for loop will iterate through the array and set each element to 100.
//Instead of setting the index to a specific value, we use the .Length property, which is the total number of elements in the array.
//print enemyHP

#endregion

#region Multidimensional Arrays

//Multidimensional arrays are arrays that contain other arrays.

#endregion

#region Limitations of Arrays

//Arrays have a fixed size, which means that once they are declared, the number of elements in the array cannot be changed.
//When an array is declared, the number of elements in the array is specified and the computer allocates memory in RAM.

//Arrays can only hold elements of the same data type.

//Arrays have no built-in methods to add or remove elements

//Arrays are not dynamic, which means that they cannot grow or shrink in size.

//Arrays don't have any built-in methods to sort the elements in the array. In order to sort an array, you must write your own sorting algorithm.
//This is quite common, but it is a limitation of arrays.

#endregion

int[] array = new int[5] { 1, 2, 3, 4, 5 };
int size = 5;
int sum = 0;

for (int i = 0; i < 5; i++)
{
    sum += array[i];
}
Console.WriteLine($"{sum}");