// C Exercises - To Submit.cpp : This file contains the 'main' function. Program execution begins and ends there.

//Exercise 1: Refactor the code
/*
In this exercise, you will refactor a C program that reads an integer of up to 6 digits and counts the number of 7s in it.You are given the base code, and your task is to modify it to make it more efficient, readable, and maintainable.

Tasks:

-Analyze the given code and identify areas that could be improved.
- Refactor the code accordingly.Possible improvements might include removing redundant code, using loops instead of repetitive if statements, and improving variable names to make their purpose clearer.
- Expand the max amount of digits from 6 to 18.
- Make sure you compile and run it successfully.
- Test the refactored code with the provided test cases below.
- If you find any issues, modify it accordingly and test it again.

Test Cases:

-Input: `777777`
Output : `6 seven(s) in: 777777`
- Input: `123456`
Output : `1 seven(s) in: 123456`
- Input: `0`
Output : `0 seven(s) in: 0`
- Input: `7`
Output : `1 seven(s) in: 7`
- Input: `17`
Output : `1 seven(s) in: 17`
- Input: `71`
Output : `1 seven(s) in: 71`
- Input: `77`
Output : `2 seven(s) in: 77`
- Input: `700000`
Output : `1 seven(s) in: 700000`
- Input: `70007`
Output : `2 seven(s) in: 70007`
- Input: `777777777777777777`
Output : `18 seven(s) in: 777777777777777777`

Tips :

	-Consider how you can use a loop to check each digit of the number instead of having separate code for each possible number of digits.
	- Think about how you can improve the variable names to better reflect their purpose.This can make the code easier to understand and maintain.
	- Consider the edge case where the input number is zero.
	- Verify if the program handles negative numbers correctly.If not, modify the code to handle such cases.

//Pseudocode:
	/*  1. Prompt the user to enter a positive integer.
		2. Read and store the entered number.
		3. Initialize a counter variable to 0.
		4. Initialize a variable to store the current digit being checked.
		5. Use a loop to iterate through each digit of the entered number :
	-While the entered number is not equal to 0 :
		-Set the current digit to the remainder of the entered number divided by 10.
		- If the current digit is equal to 7, increment the counter.
		- Divide the entered number by 10 to remove the rightmost digit.
		6. Print the number of occurrences of the digit 7.*/

#include <stdio.h>

int main()
{
	//long long int value, savedresult, currentdigit;
	//int counter = 0;
	//int digitcount = 0;

	////Lines 62-64:
	//	/*declared variables value, savedresult, and currentdigit on one line, since they don't have declared values yet.
	//	Also had to change the data type to 'unsigned long long int' in order to accomodate the last test case of 18x 7's. Tested and working.
	//	removed the newvalue variable since it was never used, and replaced all instances of newvalue with savedresult. Tested and working.
	//	renamed result to digitcount, since it is counting the number of digits in the input. Tested and working.
	//	replaced the a-f variables with just one variable called currentdigit, since it's only checking one digit at a time. Tested and working.*/

	//printf("Input up to 18 integers:\n");
	//scanf_s("%llu", &value);

	////Lines 73-74:
	///*changed the prompt text to say up to 18 integers to reflect the expanded max amount of digits.
	//used %llu instead of %d for an 'unsigned long long int'. This expands the max amount of digits from 6 to 18, and since it's unsigned it prevents negative numbers from being entered.
	//A normal long long int would have worked for the number output, but would have allowed negative integers. Tested and working.*/

	//savedresult = value;

	//while (value != 0)
	//{
	//	currentdigit = value % 10;

	//	if (currentdigit == 7)
	//	{
	//		counter++;
	//	}
	//	value /= 10;
	//	digitcount++;
	//}
	//printf("%d seven(s) in: %llu\n", counter, savedresult);

	////Lines 82-91:
	///*loop will continue to execute as long as the value is not equal to 0.
	//removed the old if statements and replaced them with a single while loop, since it's more efficient and easier to read.
	//the new if statement checks if currentdigit is equal to 7, and increments the counter if it is.
	//the value is then divided by 10 to remove the rightmost digit.
	//digitcount is incremented by 1 each pass through the loop, since it's keeping track of the number of digits in the input.
	//replaced the multiple output messages with just one. Had to use %llu again to print the unsigned long long int.*/

	////Exercise #2: Hot key menu system
	///*Objective:
	//In this exercise, students will modify a given hot key menu system to implement the following improvements :

	//	1. Replace 'if' statements with 'switch' statements to make the code more efficient.
	//	2. Add an "Exit" option to the menu.
	//	3. Have the program run continuously till "Exit" is chosen
	//	4. Implement error handling for invalid inputs.

	//	Instructions:
	//		1. Analyze the provided code snippet, which implements a basic hot key menu system:

	//	int Choice;

	//	printf("Hot Key Menu System \n");
	//	printf("1. Option1\n");
	//	printf("2. Option2\n");
	//	printf("3. Option3\n");
	//	printf("4. Option4\n");
	//	printf("Please Select an option ");
	//	scanf_s("%d", &Choice);

	//	if (Choice == 1) {
	//		printf("Red pill 1");
	//	}
	//	if (Choice == 2) {
	//		printf("Blue pill 2");
	//	}
	//	if (Choice == 3) {
	//		printf("Rabbit hole 3");
	//	}
	//	if (Choice == 4) {
	//		printf("Out of the matrix of the matrix 4");
	//	}

	//		2. Modify the code by replacing the 'if' statements with a 'switch' statement for a more efficient control structure.

	//		3. Add a new option(5) to the menu that allows the user to exit the program.

	//		4. Implement error handling to catch invalid inputs.If the user enters an invalid option, print an error message and prompt the user to try again.

	//		5. Test the modified menu system to ensure it works correctly and handles errors as expected.

	//		Bonus: Add additional features to the menu system, such as custom messages for each option, or nested menus for more complex navigation.*/

	//printf("-------------------------------------------------------\n"); //line break for readability

	//int choice;

	//printf("Hot Key Menu System: \n");
	//printf("1. Option1\n");
	//printf("2. Option2\n");
	//printf("3. Option3\n");
	//printf("4. Option4\n");
	//printf("5. Exit\n"); //added exit option dialogue to the menu
	//printf("-------------------------------------------------------\n");
	//printf("Please Select an option: ");
	//scanf_s("%d", &choice);

	//printf("\n"); //line break for readability

	//switch (choice)
	//{
	//case 1:
	//	printf("You decide to face reality and truth, no matter how hard they are. You take the red pill.\n");
	//	break;
	//case 2:
	//	printf("Reality is hard, and the truth is full of razor-sharp edges. You would rather be swaddled by the soft blanket of ignornance. You take the Blue pill.\n");
	//	break;
	//case 3:
	//	printf("Down the rabbit hole. Wooooooooooo! Alice would be proud.\n");
	//	break;
	//case 4:
	//	printf("Out of the matrix of the matrix\n");
	//	break;
	//case 5: //added case 5 (exit option) to the switch statement
	//	printf("Exiting program\n"); //
	//	break;
	//default: //added default case for invalid inputs
	//	printf("Invalid input. Please try again.\n");
	//	break;
	//}

	//Exercise #3: Calculating the Factorial of a Number
	/*Description:
		In this exercise, you will write a C program that reads a positive integer and calculates its factorial.You will be given a base code, and your task is to complete the missing parts and test the code with various test cases.

		Tasks :

		-Make sure you compile and run it successfully.
		- Test the base code with the provided test cases below.
		- If you find any issues, modify it accordingly and test it again.

		Test Cases :

	-Input : 5
		Output : `The factorial of 5 is 120`
		- Input: 0
		Output : The factorial of 0 is 1
		- Input : 1
		Output : `The factorial of 1 is 1`
		- Input: 10
		Output : `The factorial of 10 is 3628800`
		- Input: 13
		Output : `The factorial of 13 is 6227020800`

		Tips:

	-Make sure to test edge cases, such as when the input is zero or one.
		- Verify if the program handles negative numbers correctly.If not, modify the code to handle such cases.
		- As a bonus, try implementing the factorial function recursively and compare it with your iterative solution.

		//Pseudocode:
		//1. Read a positive integer from the user and store it in a variable called 'number'.
		//2. Initialize a variable called 'factorial' to 1.
		//3. Check if 'number' is equal to 0 or 1.
		//a.If true, then the factorial is 1. Print "The factorial of [number] is 1" and exit.
		//4. Otherwise, proceed with the following steps :
		//a.Use a loop to iterate from 'number' down to 2 (inclusive).
		//b.Multiply 'factorial' by the current number in each iteration.
		//5. After the loop, print "The factorial of [number] is [factorial]".

		// Optional Recursive Solution:
		//1. Create a recursive function called 'factorial' that takes an integer argument 'n'.
		//2. Inside the function, check if 'n' is equal to 0 or 1.
		//a.If true, return 1.
		//3. Otherwise, return 'n' multiplied by the factorial of 'n-1'.
		//4. In the main program, call the 'factorial' function passing the 'number' as an argument.
		//5. Print "The factorial of [number] is [result of factorial function]".*/

	printf("-------------------------------------------------------\n"); //line break for readability

	int number;
	double factorial = 1;

	printf("Enter a positive integer: ");
	scanf_s("%d", &number);

	if (number == 0 || number == 1) //if number is 0 or 1, factorial is 1
	{
		printf("The factorial of %d is 1\n", number);
	}

	else if (number < 0) //if number is negative, print error message
	{
		printf("Number is negative. Please enter a positive number.\n");
	}

	else //if number is greater than 1, calculate factorial
	{
		for (int i = number; i >= 2; i--)
		{
			factorial *= i;
		}

		printf("The factorial of %d is %f\n", number, factorial);
	}

	return 0;
}