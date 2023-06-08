// More more arrays.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
 ///Exercise 1
//Create a new array that is the sum of two arrays of size 5.
//
//Input: array1 = { 1, 2, 3, 4, 5 }, array2 = { 5, 4, 3, 2, 1 }
//Output: newArray = { 6, 6, 6, 6, 6 }
//
//Input: array1 = { 0, 0, 0, 0, 0 }, array2 = { 5, 4, 3, 2, 1 }
//Output: newArray = { 5, 4, 3, 2, 1 }
//
//Input: array1 = { 1, 1, 1, 1, 1 }, array2 = { 5, 5, 5, 5, 5 }
//Output: newArray = { 6, 6, 6, 6, 6 }

///Exercise 2
//Find the maximum product of two integers in an array of positive numbers.
//
//Input: array = { 1, 20, 30, 44, 5, 56, 57, 23, 45, 12 }
//Output: 3248 (57 * 56)
//
//Input : array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
//Output: 90 (10 * 9)
//
//Input : array = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }
//Output: 100 (10 * 10)

///Exercise 3
//Replace MinMax
//
//
//Read Make an array size of N, then read N integers
//Assume all values are between[0, 200]
//Print the array after doing the following operations :
//Find the minimum number in the array
//Find the maximum number in the array
//Replace each minimum number with maximum number and vise versa
//Input = > Output
//Input = 4, 1, 3, 10, 8, 10, 10
//Output = 4, 10, 3, 10, 8, 1, 1

///Exercise 4
//Is it a Palindrome ?
//Read integer N(< 1000), then read the n amount of elements in array
//	Determine if the array is a palindrome or not
//	An array is called a palindrome if it reads the same backwards and forwards
//	for example, arrays{ 1 } and {1, 2, 3, 2, 1} are palindromes
//		While arrays{ 1,12 } and {4, 7, 5, 4} are not
//		Input = > Output
//		5:  13231 = > Yes
//		4:  1234 = > No

///Exercise 5
//Check if an array of size 5 is sorted in descending order.
//
//Input: array = { 5, 4, 3, 2, 1 }
//Output: true
//
//Input : array = { 1, 2, 3, 4, 5 }
//Output: false
//
//Input : array = { 5, 5, 5, 5, 5 }
//Output: false

///Exercise 6
//Find the product of all elements of an array of size 5.
//
//Test case 1:
//
//Input: array = { 1, 2, 3, 4, 5 }
//Output: 120
//
//Test case 2:
//
//Input: array = { 0, 1, 2, 3, 4 }
//Output: 0
//
//Test case 3:
//
//Input: array = { -1, -2, -3, -4, -5 }
//Output: -120

///Exercise 7
//Count how many even numbers are in an array of size 5.
//
//Input: array = { 1, 2, 3, 4, 5 }
//Output: 2
//
//Input : array = { 2, 4, 6, 8, 10 }
//Output: 5
//
//Input : array = { 1, 3, 5, 7, 9 }
//Output: 0

///Exercise 8
//Search and Add the Index of an Element in an Array
//Input : Array: {1, 2, 3, 4, 5}, Value : 3, Index : 2
//Output : Value found at index 2 (2 + 3 = 5)
//
//Test Cases :
//
//Input: {1, 2, 3, 4, 5}, Value : 3, Index : 2
//Output : Value 3 found at index 2 (2 + 3 = 5)
//
//Input : {5, 10, 15, 20}, Value : 10, Index : 1
//Output : Value 10 found at index 1 (1 + 10 = 11)
//
//Input : {4, 8, 12, 16, 20}, Value : 7, Index : null
//Output : Element not found in the array
//
//Input : {3, 6, 9, 12, 15}, Value : 15, Index : 4
//Output : Element found at index 4 (4 + 15 = 19)

///Exercise 9

///Exercise 10

int main()
{
	//int array1[5] = { 1, 2, 3, 4, 5 };
	//int array2[5] = { 5, 4, 3, 2, 1 };
	//int array3[5];
	//for (int i = 0; i < 5; i++)
	//{
	//	array3[i] = array1[i] + array2[i]; //just adding the two arrays together
	//	std::cout << array3[i] << ", ";
	//}

	/*int newArray[10] = {10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
	int max = newArray[0];
	int secondToMax = newArray[0];
	int product = 0;
	for (int i = 0; i < 10; i++)
	{
		if (newArray[i] > max)
		{
			secondToMax = max;
			max = newArray[i];
		}
		else if (newArray[i] > secondToMax)
		{
			secondToMax = newArray[i];
		}
	}

	product = max * secondToMax;
	std::cout << "The max number is: " << max << "\n";
	std::cout << "The second largest number is " << secondToMax << "\n";
	std::cout << "The maximum product of two integers in the array is: " << product << "\n";*/

	/*int array[7] = {4, 1, 3, 10, 8, 10, 10};
	int min = array[0];
	int max = array[0];
	int temp = 0;

	for (int i = 0; i < 7; i++)
	{
		if (array[i] < min)
		{
			min = array[i];
		}
		else if (array[i] > max)
		{
			max = array[i];
		}
	}

	for (int i = 0; i < 7; i++)
	{
		if (array[i] == min)
		{
			array[i] = max;
		}
		else if (array[i] == max)
		{
			array[i] = min;
		}
	}

	for (int i = 0; i < 7; i++)
	{
		std::cout << array[i] << ", ";
	}*/

	/*int array[5] = {1, 3, 2, 3, 1};
	int size = 5;
	bool isPalindrome = false;

	for (int i = 0; i < size; i++)
	{
		if (array[i] == array[size - 1 - i])
		{
			isPalindrome = true;
		}
		else
		{
			isPalindrome = false;
		}
	}

	if (isPalindrome == true)
	{
		std::cout << "Yes";
	}
	else
	{
		std::cout << "No";
	}*/

	/*int array[5] = {5, 4, 3, 2, 1};
	bool isDesc = false;

	for (int i = 0; i < 5; i++)
	{
		if (array[i] > array[i + 1])
		{
			isDesc = true;
		}
		else
		{
			isDesc = false;
		}
	}
	isDesc = false;
	std::cout << isDesc << "\n";
	return 0;*/

	/*int array[5] = {1, 2, 3, 4, 5};
	int product = 1;

	for (int i = 0; i < 5; i++)
	{
		product = product * array[i];
	}

	std::cout << product << "\n";*/

	/*int array[5] = {1, 2, 3, 4, 5};
	int evenCount = 0;

	for (int i = 0; i < 5; i++)
	{
		if (array[i] % 2 == 0)
		{
			evenCount++;
		}
	}
	std::cout << "There are " << evenCount << " even numbers in the array. \n";
*/

/*int newArray[5] = {3, 6, 9, 12, 15};
int value = 15;
int index = 4;
int sum = 0;

for (int i = 0; i < 5; i++)
{
	if (newArray[i] == value)
	{
		newArray[i] = index;
		sum = newArray[i] + value;
		std::cout << "Value found at index " << newArray[i] << " (" << newArray[i] << " + " << value << " = " << sum << ")\n";
	}
}*/

/*
//Count the Number of Elements That Are Greater Than a Given Value in an Array and Sum Them
//
//Test Case 1:
//
//Input: array = { 1, 2, 3, 4, 5 }, value = 3
//Output : count = 2, sum = 9
//
//Test Case 2 :
//
//	Input : array = { 0 }, value = 0
//	Output : count = 0, sum = 0
//
//	Test Case 3 :
//
//	Input : array = { 5, 4, 3, 2, 1 }, value = 4
//	Output : count = 1, sum = 5
//
//	Test Case 4 :
//
//	Input : array = { 10, 20, 30, 40, 50 }, value = 25
//	Output : count = 3, sum = 120
//
//	Test Case 5 :
//
//	Input : array = { -5, -4, -3, -2, -1 }, value = -4
//	Output : count = 3, sum = -6

//  Pseudocode:
//  1. Create an array of 5 integers
//  2. Create a variable to hold the value to check
//  3. Create a variable to hold the count of numbers greater than the value
//  4. Create a variable to hold the sum of the numbers greater than the value
//  5. Loop through the array
//  6. Check if the current element is greater than the value
//  7. If it is, increment the count and add the current element to the sum
//  8. Print the count and the sum

	int array[5] = { 1, 2, 3, 4, 5 };
	int numToCheck = 3;
	int count = 0;
	int sum = 0;
	for (int i = 0; i < 5; i++)
	{
		if (array[i] > numToCheck)
		{
			count++;
			sum += array[i];
		}
	}
	std::cout << "There are " << count << " numbers greater than " << numToCheck << ". The sum of those elements is " << sum << ".\n";
	*/

	/*Find the Sum of Every Second Element of an Array of Size 5

	Test Case 1:

	Input: array = { 1, 2, 3, 4, 5 }
	Output: 6

	Test Case 2 :

		Input : array = { 0, 1, 0, 1, 0 }
	Output: 2

	Test Case 3 :

		Input : array = { 5, 4, 3, 2, 1 }
	Output: 4

	Test Case 4 :

		Input : array = { 10, 20, 30, 40, 50 }
	Output: 60

	Test Case 5 :

		Input : array = { -5, -4, -3, -2, -1 }
	Output: -6*/

	//  Pseudocode:
	//  1. Create an array of 5 integers
	//  2. Create a variable to hold the sum of every second element
	//  3. Loop through the array
	//  4. Check if the current index is even
	//  5. If it is, add the current element to the sum

	int array[5] = { 1, 2, 3, 4, 5 };
	int secondNumSum = 0;

	for (int i = 0; i < 5; i++)
	{
		if (array[i] % 2 == 0)
		{
			secondNumSum += array[i];
		}
	}
	std::cout << "The sum of every second element is " << secondNumSum << "\n";
}