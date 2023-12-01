#include <stdio.h>

//1)
//Exercise: Finding the Largest and Second Largest Number(Non - Duplicates)
//
//Description :
//
//In this exercise, you will write a C program that reads a series of positive integers and determines
// the largest and second largest numbers among them.You will be given a base code, and your task is to complete the missing parts and test the code with various test cases.
//
//    Tasks :
//
//    Make sure you compile and run it successfully.
//    Test the base code with the provided test cases below.
//    If you find any issues, modify it accordingly and test it again.
//    Test Cases :
//
//Input: 5, 1, 2, 3, 4, 5
//Output : 5 is the largest number and 4 is the second largest
//Input : 4, 11, 9, 2, 7
//Output : 11 is the largest number and 9 is the second largest
//Input : 6, 8, 5, 8, 12, 3, 5
//Output : 12 is the largest number and 8 is the second largest
//Input : 3, 100, 100, 100
//Output : 100 is the largest number and 3 is the second largest
//Input : 1, 42
//Output : 42 is the largest number and 1 is the second largest
//
//Tips :
//Make sure to test edge cases, such as when all numbers are the same or when only one number is provided.
//Verify if the program handles negative numbers correctly.If not, modify the code to handle such cases.

int main()
{
	int num = 0; //num is the number that the user enters
	int largest = 0;
	int secondLargest = 0;
	int count = 0;

	printf("Enter the number of integers: ");
	scanf_s("%d", &count);
	printf("Enter %d integers: ", count);

	//the %d is a placeholder for the value that will be entered by the user(integer or double), the & is the address of the variable

	for (int i = 0; i < count; i++)
	{
		scanf_s("%d", &num); //this gets the current value of num

		if (num > largest)
		{
			secondLargest = largest; //this updates the second largest value to the previous largest value
			largest = num; //this updates the largest value to the current num value
		}
		else if (num > secondLargest && num != largest) //had to use 'num != largest' instead of <= because if the user entered the same number twice, it would be the largest and second largest
		{
			secondLargest = num; //this updates the second largest value to the current num value
		}
	}
	printf("%d is the largest number and %d is the second largest number\n", largest, secondLargest);
	return 0;
}