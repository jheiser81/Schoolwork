// Functions Practice.cpp : This file contains the 'main' function. Program execution begins and ends there.

#include <stdio.h>

///Notes on functions:
//In C, functions are made using the following syntax:
//return_type function_name( parameter list ) {
//   body of the function
//}
//
//The return_type is the data type of the value the function returns. Some functions perform the desired operations without returning a value.
//In this case, the return_type is the keyword void.
//
//The function_name is the actual name of the function. The function name and the parameter list together constitute the function signature.
//
//The parameter list refers to the type, order, and number of the parameters of a function. Parameters are optional; that is, a function may contain no parameters.
//
//The function body contains a collection of statements that define what the function does.
//
//Functions can be broken up into 3 parts:
//1. Function declaration
//2. Function definition
//3. Function call
//
//Function declaration:
//A function declaration tells the compiler about a function's name, return type, and parameters. This is placed at the top of the C file, outside of the main function.
//
//Function definition:
//The function definition provides the actual body of the function. This is placed after the main function.
//
//Function call:
//A function call is the actual code that is used to pass control to a function. This is placed inside the main function.

///Exercises:

//Exercise 1: Maximum Number
//Write a function named maxNumber that takes two integer parameters and returns the maximum of the two numbers.

//Function declaration for maxNumber
int maxNumber(int num1, int num2);

//Exercise 2: Factorial
//Write a function named factorial that takes an integer parameter and returns its factorial.The factorial of a number n is the product of all positive integers from 1 to n.

//Function declaration for factorial
int factorial(int n);

//Exercise 3: Sum of Array
//Write a function named sumOfArray that takes an array of integers and its size as parameters and returns the sum of the elements in the array.

//Psuedocode:
//function sumOfArray(array, length) :
//	sum = 0
//	for i from 0 to length - 1 :
//		sum = sum + array[i]
//		return sum

//Function declaration for sumOfArray
int sumOfArray(int sumArray[], int length);
//the function declaration contains the actual array and its size

int main()
{
	int num1, num2; //these are the two numbers that will be compared
	printf("Enter first number: ");
	scanf_s("%d", &num1);
	printf("Enter second number: ");
	scanf_s("%d", &num2);
	int result = maxNumber(num1, num2); //this is the call for the maxNumber function
	printf("The maximum nubmer is %d\n", result);

	printf("\n");

	int n; //this is the number that will be used to find the factorial
	printf("Enter a number: ");
	scanf_s("%d", &n);
	int factorialResult = factorial(n); //this is the call for the factorial function
	printf("The factorial of %d is %d\n", n, factorialResult);

	printf("\n");

	int sumArray[5] = { 1, 2, 3, 4, 5 }; //this is the array that will be used to find the sum
	int length = sizeof(sumArray) / sizeof(sumArray[0]); //this is the size of the array
	int resultSum = sumOfArray(sumArray, length); //this is the call for the sumOfArray function
	printf("The sum of the array is %d\n", resultSum);

	return 0;
}

//function definition for maxNumber
int maxNumber(int num1, int num2) {
	if (num1 > num2) {
		return num1;
	}
	else {
		return num2;
	}
}

//function definition for factorial
int factorial(int n) {
	if (n == 0) {
		return 1;
	}
	else {
		return n * factorial(n - 1);
	}
}

//function definition for sumOfArray
//
// this didn't work
//int sumOfArray(int sumArray[], int length)
//{
//	for (int i = 0; i < length; i++)
//	{
//		int sum = 0;
//		sum = sum + sumArray[i];
//		return sum;
//	}
//}

//this worked
int sumOfArray(int sumArray[], int length)
{
	int sum = 0;

	for (int i = 0; i < length; i++)
	{
		sum = sum + sumArray[i];
	}
	return sum;
}