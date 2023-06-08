// More Arrays Practice.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
/*
1) Find the sum of all the elements in an array.Initialize an integer array of size 5 with some values and calculate the sum of all the values.

2) Find the maximum and minimum element in an array.Initialize an integer array of size 10 with some values and then find the maximum and minimum elements.

3) Find the second largest element in an array.Initialize an integer array of size 10 with some values and then find the second largest element.

4)Remove duplicates from an array.Initialize an integer array with some duplicate values.Write a code to remove duplicates from the array. (Hint: You can create another array to hold the unique elements).

5) Reverse an array.Initialize an array of integers and write a function to reverse the array.

6) Count the frequency of each element in an array.Initialize an array with some duplicate elements and count the frequency of each element.

7) Rotate an array by 'k' positions.Initialize an integer array and write a function to rotate the array by 'k' positions. 'k' should be a user input.

8) Find a pair of elements in an array whose sum equals a specific target.Initialize an integer array and write a function to find a pair of elements that add up to a specific target.

9) Write a function to sort an array in ascending order.Use any sorting algorithm you are comfortable with(like bubble sort, selection sort, etc.).

10) Check if an array is a palindrome.Initialize an array such that it reads the same forward as backward and write a function to check if it's a palindrome.
*/

int main()
{
#pragma region Exercise 1: Find the sum of all the elements in an array.Initialize an integer array of size 5 with some values and calculate the sum of all the values.

	//**Pseudocode**
	//Declare an array of integers.
	//Initialize a variable sum to 0.
	//Initialize a variable size to the size of the array. Alternatively, you can use sizeof (numArray) / sizeof(numArray[0]) to get the size of the array.
	//Iterate over each element in the array using a for loop.
	//Inside the loop, set sum to sum + the current element of the array
	//Print the value of sum.

	std::cout << "Defining the size of the array: " << "\n";
	int numArray[5] = { 55, 22, 4, 36, 80 };
	int sum = 0;
	int size = 5;
	for (int i = 0; i < size; i++)
	{
		sum += numArray[i];
		//sum = sum + numArray[i];
	}
	std::cout << "The sum of the numbers in the array is: ";
	std::cout << sum << "\n\n";

	//sizeof (numArray) / sizeof(numArray[0]) can also be used to get the size of the array. This is useful if the size of the array is not known.
	std::cout << "Using sizeof to get the size of the array: " << "\n";
	int numArray2[] = { 55, 22, 4, 36, 80, 1, 99, 100, 2, 0 };
	int sum2 = 0;
	int size2 = sizeof(numArray2) / sizeof(numArray2[0]);
	for (int i = 0; i < size2; i++)
	{
		sum2 += numArray2[i];
	}
	std::cout << "The sum of the numbers in the array is: ";
	std::cout << sum2 << "\n\n";

	//Explanation:
	//In the above code examples, we have created an integer array and initialized it with some values.
	//We have initialized two variables, one for sum and one for size.
	//We then use a for loop to iterate over each element in the array and add it to the sum variable.
	//Finally, we print the value of sum.
	//The two code examples show two different ways to get the size of the array, one by defining the size of the array and the other by using sizeof.
	//Both methods are acceptable and produce the same result.
	//This method is how you can find the sum of all the elements in any integer array.

#pragma endregion

#pragma region Exercise 2: Find the maximum and minimum element in an array.Initialize an integer array of size 10 with some values and then find the maximum and minimum elements.

	//**Pseudocode**
	//Declare an array of integers.
	//Initialize a variable max to the first element of the array.
	//Iterate over each element in the array starting from the second element
	//If the current element is greater than max, update the value of max to the current element.
	//Print the value of max.
	//Follow the same procedure to find and print the min number

	int minMax[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	int min = minMax[0];
	int max = minMax[0];
	for (int i = 1; i < 10; i++)
	{
		if (minMax[i] > max)
		{
			max = minMax[i];
		}
		else if (minMax[i] < min)
		{
			min = minMax[i];
		}
	}
	std::cout << "The max number is: " << max << "\n";
	std::cout << "The min number is: " << min << "\n\n";

	//Explanation:
	//In the above code, we have initialized the max and min variables to the first element of the array, i.e., minMax[0].
	//Then we have iterated over each element in the array starting from the second element. The reason for this is to avoid comparing the first element with itself.
	//If the value of the current array element [i] is greater than the value of max, we update the value of max to the current element.
	//Similarly, if the value of the current array element [i] is less than the value of min, we update the value of min to the current element.
	//Finally, we print the values of max and min.
	//This procedure is how you can determine the maximum and minimum elements in any integer array.

#pragma endregion

#pragma region Exercise 3: Find the second largest element in an array.Initialize an integer array of size 10 with some values and then find the second largest element.

	//**Pseudocode**
	//Declare an array of integers.
	//Initialize a variable to hold the largest element in the array and set it to the first element of the array [0].
	//Initialize a variable to hold the second largest element in the array and also set it to the first element of the array [0].
	//Use a for loop to iterate ove each element in the array starting from the second element.
	//Compare the current array element with the value of the largest element variable and if it is greater, update the value of the largest element variable to the current element.
	//If the current array element is less than the largest element variable and greater than the second largest element variable, update the value of the second largest element variable to the current element.

	int newArray[] = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
	int largest = newArray[0];
	int secondLargest = newArray[0];
	for (int i = 1; i < 10; i++)
	{
		if (newArray[i] > largest)
		{
			secondLargest = largest;
			largest = newArray[i];
		}
		else if (newArray[i] < largest && newArray[i] > secondLargest)
		{
			secondLargest = newArray[i];
			largest = secondLargest;
		}
	}
	std::cout << "The largest number in the array is: " << largest << "\n";
	std::cout << "The second largest number in the array is: " << secondLargest << "\n";

	//Explanation:
	//In the above code, we have created an integer array and initialized it with some values.
	//We have initialized two variables, one for the largest element and one for the second largest element of the array.
	//We then use a for loop to iterate over each element in the array starting from the SECOND element. The reason for this is to avoid comparing the first element with itself.
	//If the value of the current array element [i] is greater than the value of the largest variable, we set the value of the secondLargest variable to the value of the largest variable and set the value of the largest variable to the value of the current array element [i].
	//If the value of the current array element [i] is less than the value of the largest variable AND greater than the value of the secondLargest variable, we set the value of the secondLargest variable to the value of the current array element [i]. We also set the value of the largest variable to the value of the secondLargest variable so that the largest variable always holds the largest value.
	//Finally, we print the values of the largest and secondLargest variables.
	//This can also be done by using a temporary variable to hold the value of the largest variable, then updating the value of the largest variable to the current array element [i] and updating the value of the secondLargest variable to the value of the temporary variable.

#pragma endregion

#pragma region Exercise 4: Remove duplicates from an array.Initialize an integer array with some duplicate values. Write a code to remove duplicates from the array. (Hint: You can create another array to hold the unique elements).

	//**Pseudocode**
	//Declare an array of integers.
	//Initialize a variable to specify the size of the array.
	//Declare another array of integers of the same size as the first array.
	//Initialize a variable to hold the count of unique elements in the array and set it to 0.
	//Use a for loop to iterate over each element in the array.
	//initialize a boolean variable to check if the current element is a duplicate and set it to false.
	//Use a nested for loop to iterate over each element in the second array.
	//If the current element in the first array is equal to the current element in the second array, set the boolean variable to true and break out of the loop.
	//If the boolean variable is false, set the current element in the second array to the current element in the first array and increment the count of unique elements.

	int arr1[5] = { 4, 8, 12, 16, 4 };
	int arr1Size = 5;
	int arr2[5];
	int arr2Count = 0;

	for (int i = 0; i < arr1Size; i++)
	{
		bool isDuplicate = false;
		for (int j = 0; j < arr2Count; j++)
		{
			if (arr1[i] == arr2[j])
			{
				isDuplicate = true;
				break;
			}
		}
		if (!isDuplicate)
		{
			arr2[arr2Count] = arr1[i];
			arr2Count++;
		}
	}
	for (int i = 0; i < arr2Count; i++)
	{
		std::cout << arr2[i] << "\n";
	}

#pragma endregion
}