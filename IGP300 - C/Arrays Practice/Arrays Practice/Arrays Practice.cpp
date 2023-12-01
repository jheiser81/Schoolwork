// Arrays Practice.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <stdio.h>

int main()
{
	///ARRAYS PRACTICE:

	///Exercise #1: Sum of Array Elements
	////Description: Write a program that calculates the sum of all elements in an array of integers.
	////
	////Pseudocode:
	////
	////Declare an array of integers.
	////Initialize variable sum to 0.
	////Determine the length of the array and store it in the variable length.
	////Iterate over each element in the array :
	////Add the current element to sum.
	////Print the value of sum.

	int myArray[5]{ 100, 55, 36, 72, 91 };
	int sum = 0;
	int length = 5;
	//can also use sizeof(myArray) / sizeof(myArray[0]) to get the length of the array.
	//sizeof is useful when the size of the array is not known, or when you want flexibility if the size of the array changes.

	for (int i = 0; i < length; i++)
	{
		sum += myArray[i];
	}
	printf("%d\n\n", sum);

	///Exercise 2: Finding Maximum Element
	//Description: Write a program that finds the maximum element in an array of integers.
	//
	//Pseudocode:
	//
	//Declare an array of integers.
	//Initialize a variable max to the first element of the array.
	//Iterate over each element in the array starting from the second element :
	//If the current element is greater than max, update the value of max to the current element.
	//Print the value of max.
	//Follow the same procedure to find and print the min number

	int maxArray[10]{ 1, 5, 8, 32, 86, 900, 754, 500, 88, 100 };
	int max = maxArray[0];
	int min = maxArray[0];

	for (int i = 1; i < 10; i++) //starts at 1 in order to compare the second element to the first element.
	{
		if (maxArray[i] > max)
		{
			max = maxArray[i];
		}
	}

	for (int i = 1; i < 10; i++)
	{
		if (maxArray[i] < min)
		{
			min = maxArray[i];
		}
	}

	printf("Max: %d\n", max);
	printf("Min: %d\n\n", min);

	///Exercise 3: Printing Array Elements
	//Description: Write a program that prints all elements in an array of integers.
	//
	//Pseudocode:
	//
	//Declare an array of integers.
	//Determine the length of the array and store it in the variable length.
	//Iterate over each element in the array
	//Print the current element.
	//Follow the same procedure to print the array in reverse order.

	int printArray[5]{ 1, 2, 3, 4, 5 };
	int arrayLength = 5;

	for (int i = 0; i < arrayLength; i++)
	{
		printf("%d \n", printArray[i]);
	}

	printf("\n");

	for (int i = arrayLength - 1; i >= 0; i--)
		//Instead of starting at 0, we start at the last element of the array, and decrement the index by 1 each time.
		// We also change the condition to i >= 0, so that the loop will continue until the index reaches 0.
		//This will print the array in reverse order.
	{
		printf("%d \n", printArray[i]);
	}

	printf("\n");

	///Exercise 4: Counting Even Numbers
	//Description: Write a program that counts the number of even numbers in an array of integers.
	//
	//Pseudocode:
	//
	//Declare an array of integers.
	//Initialize a variable counter to 0.
	//Iterate over each element in the array
	//If the current element is even(i.e., divisible by 2), increment counter by 1.
	//Print the value of counter.
	//Do the same procedure for odd numbers

	int evenNums[10]{ 76, 42, 88, 17, 61, 93, 29, 55, 83, 12 };
	int evenCount = 0;
	int oddCount = 0;

	for (int i = 0; i < 10; i++)
	{
		if (evenNums[i] % 2 == 0)
		{
			evenCount++;
		}
		else
		{
			oddCount++;
		}
	}
	printf("There are %d even numbers and %d odd numbers in the array \n\n", evenCount, oddCount);

	///Exercise 5: Reversing Array Elements
	//Description: Write a program that reverses the elements in an array of integers.
	//
	//Pseudocode:
	//
	//Declare an array of integers.
	//Initialize variables start and end to the first and last indices of the array, respectively.
	//While start is less than end :
	//Swap the elements at indices start and end.
	//Increment start and decrement end.
	//Print the reversed array.

	int anotherArray[5]{ 5, 88, 42, 67, 103 };
	int start = 0;
	int end = 4;
	int temp = 0;

	while (start < end)
	{
		temp = anotherArray[start];
		anotherArray[start] = anotherArray[end];
		anotherArray[end] = temp;
		start++;
		end--;
	}

	for (int i = 0; i < 5; i++) //need to iterate through the loop to print each element in the array.
	{
		printf("%d \n", anotherArray[i]);
	}

	printf("\n");

	///Exercise 6: Finding Average Value
	//Description: Write a program that calculates the average value of elements in an array of floating - point numbers.
	//
	//Pseudocode:
	//
	//	Declare an array of floating - point numbers.
	//	Initialize variables sum and length to 0.
	//	Iterate over each element in the array :
	//	Add the current element to sum.
	//	Increment length by 1.
	//	Calculate the average value by dividing sum by length.
	//	Print the average value.

	float avgArray[5]{ 2, 666, 207, 55, 325 };
	float newSum = 0;
	int newLength = 0; //use int instead of float because we are dividing by an int.

	for (int i = 0; i < 5; i++) //use int here as well
	{
		newSum += avgArray[i];
		newLength++;
	}

	float average = newSum / newLength;
	printf("The average of the array is: %f \n\n", average);
}