#include <stdio.h>
#include <math.h> // for sqrt() function

/// Assignment 1: Bubble Sort Function - Pass by Value
//In this assignment, you will implement the bubble sort algorithm for sorting an array of integers. However, you should create a function that takes the array as input and returns a new sorted array, leaving the original array unchanged.This will require you to pass the array by value.
//
//** Deliverables : **
//
//1. A function called `bubble_sort_by_value` that sorts the input array and returns a new sorted array.
//2. Test your function with at least three different test cases.
//
//* *Guidelines:**
//
//1. Define a function with the following signature :
//
//int* bubble_sort_by_value(const int* arr, int size);
//```
//2. Implement the bubble sort algorithm within the function, making sure not to modify the original array.
//3. Allocate a new array of the same size, copy the original array's elements, and perform the sorting on the new array.
//4. Return the new sorted array.
//
//Remember to test your function with various test cases to ensure its correctness.
//
//* *Test Cases for Assignment 1 (Bubble Sort - Pass by Value) * *
//
//1. Input Array : {5, 3, 2, 4, 1}
//Expected Output Array : {1, 2, 3, 4, 5}
//Note: The original array should remain unchanged.
//
//2. Input Array : {10, -5, 3, -1, 0, 100}
//Expected Output Array : {-5, -1, 0, 3, 10, 100}
//Note: The original array should remain unchanged.
//
//3. Input Array : {1, 1, 1, 1, 1}
//Expected Output Array : {1, 1, 1, 1, 1}
//Note: The original array should remain unchanged.

/// Assignment 2: Bubble Sort Function - Pass by Reference
//In this assignment, you will again implement the bubble sort algorithm for sorting an array of integers.However, this time you should create a function that directly modifies the input array.This will require you to pass the array by reference.
//
//** Deliverables:**
//
//1. A function called `bubble_sort_by_reference` that sorts the input array in - place.
//2. Test your function with at least three different test cases.
//
//* *Guidelines:**
//
//1. Define a function with the following signature :
//
//void bubble_sort_by_reference(int* arr, int size);
//
//2. Implement the bubble sort algorithm within the function, making sure to modify the original array.
//3. Since the array is passed by reference, there is no need to return anything from the function.
//
//Remember to test your function with various test cases to ensure its correctness.
//
//* *Test Cases for Assignment 2 (Bubble Sort - Pass by Reference) * *
//
//1. Input Array : {5, 3, 2, 4, 1}
//Expected Output Array : {1, 2, 3, 4, 5}
//Note: The original array should be sorted in - place.
//
//2. Input Array : {10, -5, 3, -1, 0, 100}
//Expected Output Array : {-5, -1, 0, 3, 10, 100}
//Note: The original array should be sorted in - place.
//
//3. Input Array : {1, 1, 1, 1, 1}
//Expected Output Array : {1, 1, 1, 1, 1}
//Note: The original array should remain the same as all elements are equal.
//
//For each test case, compare the output of your function with the expected output array.If they match for all test cases, your implementation is likely correct.

/// Assignment 3: Array Manipulation and Indexing
//
//In this assignment, you will practice working with arrays in C.Your task is to create an array and simultaneously print two different indexes in a single loop.
//
//** Objective : **
//
//Create an array of integers with at least 10 elements.Write a program that prints the elements at two different indexes, `i` and `i+1`, in a single loop.The loop should run such that it doesn't cause an out-of-bound error.
//
//* *Deliverables:**
//
//1. A C program with an array of at least 10 integers.
//2. The program should contain a loop that prints the elements at two different indexes(`i` and `i+1`) simultaneously.
//	3. Ensure your program doesn't cause an array out-of-bound error.
//	4. A brief report outlining the results of your test cases and any modifications you made to your program, and why.
//
//	* *Guidelines:**
//
//	1. Initialize an array with at least 10 integers.You can choose the values yourself.
//	2. Write a loop that iterates through the array.The loop should run until `size - 1`, where `size` is the size of the array.
//	3. Inside the loop, print the elements at indexes `i` and `i+1` in each iteration.Ensure the index `i+1` doesn't go out-of-bounds.
//	4. Compile and run your program to ensure it works as expected.
//
//	* *Test Your Program : **
//
//	To make sure your program works as expected, test it with the following scenarios :
//
//1. Array : {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
//Expected output : Pairs of elements(1, 2), (2, 3), (3, 4), ..., (9, 10).
//
//2. Array : {10, 20, 30, 40, 50, 60, 70, 80, 90, 100}
//Expected output : Pairs of elements(10, 20), (20, 30), (30, 40), ..., (90, 100).
//
//3. Array : {-1, -2, -3, -4, -5, -6, -7, -8, -9, -10}
//Expected output : Pairs of elements(-1, -2), (-2, -3), (-3, -4), ..., (-9, -10).
//
//If your program produces the correct output for these test cases, it is likely correct.However, consider creating additional test cases to further validate your solution.

/// Assignment 4: Array Manipulation and Indexing 2
//
//In this assignment, you will practice working with arrays in C.Your task is to create an array and simultaneously print two different indices in a single loop, but with a twist : you will print the first and last elements, then the second and second last elements, and so forth.
//
//** Objective : **
//
//Create an array of integers with at least 4 elements.Write a program that prints the elements at two different indices, `i` and `size-i - 1`, in a single loop.The loop should run such that it doesn't cause an out-of-bound error.
//
//* *Deliverables:**
//
//1. A C program with an array of at least 4 integers.
//2. The program should contain a loop that prints the elements at two different indices(`i` and `size-i - 1`) simultaneously.
//	3. Ensure your program doesn't cause an array out-of-bound error.
//
//	* *Guidelines:**
//
//	1. Initialize an array with at least 4 integers.You can choose the values yourself.
//	2. Write a loop that iterates through half of the array.The loop should run until `size/2`, where `size` is the size of the array.
//	3. Inside the loop, print the elements at indices `i` and `size-i - 1` in each iteration.Ensure the indices do not go out - of - bounds.
//	4. Compile and run your program to ensure it works as expected.
//
//	* *Test Your Program : **
//
//	To make sure your program works as expected, test it with the following scenarios :
//
//1. Array : {1, 2, 3, 4}
//Expected output : Pairs of elements(1, 4), (2, 3).
//
//2. Array : {10, 20, 30, 40, 50, 60}
//Expected output : Pairs of elements(10, 60), (20, 50), (30, 40).
//
//3. Array : {-1, -2, -3, -4, -5, -6, -7, -8}
//Expected output : Pairs of elements(-1, -8), (-2, -7), (-3, -6), (-4, -5).
//
//If your program produces the correct output for these test cases, it is likely correct.However, consider creating additional test cases to further validate your solution.

/// Assignment 5: Calculating the Hypotenuse of a Right Triangle in C
//**Objective : **
//In this assignment, you will write a C program that takes two positive numbers as input representing the lengths of the two legs of a right triangle and calculates the length of the hypotenuse using the Pythagorean theorem.
//
//** Tasks : **
//
//1. Write a C program that prompts the user for two positive numbers(the lengths of the legs of a right triangle).
//2. The program should calculate and print out the length of the hypotenuse of the right triangle.
//3. Compile and run your program, making sure it executes successfully.
//4. Test your program using various test cases(including the ones provided below).
//5. If you encounter any issues, debug your program accordingly and retest it.
//6. Reflect on the results and write a brief report on your findings.
//
//* *Test Cases : **
//
//1. Input : 3 4
//Expected Output : The hypotenuse is 5.000000
//
//2. Input : 5 12
//Expected Output : The hypotenuse is 13.000000
//
//3. Input : 8 15
//Expected Output : The hypotenuse is 17.000000
//
//* *Additional Considerations : **
//
//1. Test edge cases, such as when one or both of the input numbers are zero.
//2. Verify if your program handles negative numbers correctly.If not, modify your code to handle such cases.The lengths of the sides of a triangle should be non - negative.
//3. Test your program with non - integer numbers, as the lengths of the sides of a triangle can be non - integer.
//4. Test your program with very large numbers and observe what happens.Can you explain why ? (Hint : Consider the precision of double in C)
//
//* *Deliverables : **
//
//1. Your C program source code.
//2. A brief report outlining the results of your test cases and any modifications you made to your program, and why.

/// **Function Declarations**:

int* bubble_sort_by_value(const int* arr, int size);

void bubble_sort_by_reference(int* arr, int size); //using void here because we are not returning anything

double pythagorean(double a, double b); //declaration for square root function

int main()
{
	///Sorting by value, uncomment to run
	//	//Output 1
	//	int arr[5] = { 5, 3, 2, 4, 1 };
	//	int size = 5;
	//	int* sortedArray = bubble_sort_by_value(arr, size); //call the function and store the returned array in a pointer
	//
	//	printf("Sort by value: ");
	//	for (int i = 0; i < size; i++)
	//	{
	//		printf("%d ", sortedArray[i]);
	//	}
	//	//------------------------------------------
	//	//Output 2
	//	int arr[6] = { 10, -5, 3, -1, 0, 100 };
	//	int size = 6;
	//	int* sortedArray = bubble_sort_by_value(arr, size);
	//
	//	printf("Sort by value: ");
	//	for (int i = 0; i < size; i++)
	//	{
	//		printf("%d ", sortedArray[i]);
	//	}
	////------------------------------------------
	//	//Output 3
	//	int arr[5] = { 1, 1, 1, 1, 1, };
	//	int size = 5;
	//	int* sortedArray = bubble_sort_by_value(arr, size);
	//
	//	printf("Sort by value: ");
	//	for (int i = 0; i < size; i++)
	//	{
	//		printf("%d ", sortedArray[i]);
	//	}

	///Sorting by reference, uncomment to run
	////Output 1
		//int arr[5] = { 5, 3, 2, 4, 1 };
		//int size = 5;
		//bubble_sort_by_reference(arr, size); //call the function and store the returned array in a pointer
		//printf("Sort by reference:");
		//
		//for (int i = 0; i < size; i++)
		//{
		//	printf("%d ", arr[i]);
		//}
		////------------------------------------------
		////Output 2
		//int arr[6] = { 10, -5, 3, -1, 0, 100 };
		//int size = 6;
		//bubble_sort_by_reference(arr, size);
		//printf("Sort by reference: ");
		//
		//for (int i = 0; i < size; i++)
		//{
		//	printf("%d ", arr[i]);
		//}
		////------------------------------------------
		////Output 3
		//int arr[5] = { 1, 1, 1, 1, 1, };
		//int size = 5;
		//bubble_sort_by_reference(arr, size);
		//printf("Sort by reference: ");
		//
		//for (int i = 0; i < size; i++)
		//{
		//	printf("%d ", arr[i]);
		//}

	//int newArray[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //test case working
	//int newArray[10] = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }; //test case working
	//int newArray[10] = { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 }; //test case working

	int newArray[10] = { 45, 12, 78, 23, 56, 89, 34, 67, 91, 18 };
	int size = 10;

	for (int i = 0; i < size - 1; i++)
	{
		//printf("Element pair: %d, %d\n", i + 1, newArray[i + 1]); //not working
		printf("Element pair: %d, %d\n", newArray[i], newArray[i + 1]); //this worked, because we are printing the element at index i and the element at index i + 1
		printf("----------------------\n");
	}

	printf("--------------------------------------\n");

	//int weirdArray[4] = { 1, 2, 3, 4 }; //test case working
	//int weirdArray[6] = { 10, 20, 30, 40, 50, 60 }; //test case working
	//int weirdArray[8] = { -1, -2, -3, -4, -5, -6, -7, -8 }; //test case working

	int weirdArray[6] = { 2, 4, 6, 8, 10, 12 };
	int length = sizeof(weirdArray) / sizeof(weirdArray[0]);

	/*for (int i = 0; i < size; i += 2)*/
		//increment by 2 because we are comparing two elements at a time.
		//ok this is working but i'm getting 1,4 and 3, 2 instead of 1,4 and 2,3

	for (int i = 0; i < length / 2; i++) //ok this worked, I had to divide the size by 2

	{
		printf("Element pair: (%d, %d)\n", weirdArray[i], weirdArray[length - i - 1]); //size - i - 1 because we are starting from the end of the array
		printf("----------------------\n");
	}

	printf("--------------------------------------\n");

	///Test cases for Pythagorean, uncomment to run:
	//
	////Test case 1:
	//double a = 3;
	//double b = 4;
	//double c = pythagorean(a, b);
	//printf("The length of the hypotenuse is: %lf\n", c);
	//
	////Test case 2:
	//double a = 5;
	//double b = 12;
	//double c = pythagorean(a, b);
	//printf("The length of the hypotenuse is: %lf\n", c);
	//
	////Test case 3:
	//double a = 8;
	//double b = 15;
	//double c = pythagorean(a, b);
	//printf("The length of the hypotenuse is: %lf\n", c);

	return 0;
}

/// **Function Definitions**:

//Sort by value

int* bubble_sort_by_value(const int* arr, int size)
{
	//how to make a new array and copy the elements of the original array into it?
	int* sortedArray = new int[size]; //create a new array of the same size as the original array. Takes in the size of the array as a parameter
	for (int i = 0; i < size; i++)
	{
		sortedArray[i] = arr[i]; //copy the elements of the original array into the new array
	}

	//implement bubble sort alg (by value)
	for (int i = 0; i < size - 1; i++) //outer loop iterates through the array size - 1 times
	{
		for (int j = 0; j < size - i - 1; j++) //inner loop iterates through the array size - i - 1 times
		{
			if (sortedArray[j] > sortedArray[j + 1]) //checks if the current element is greater than the next element.
				//If it is, swap the values
			{
				int temp = sortedArray[j]; //use a temp variable to store the value of the current element
				sortedArray[j] = sortedArray[j + 1];
				sortedArray[j + 1] = temp;
			}
		}
	}
	return sortedArray;
}

//sort by reference:

void bubble_sort_by_reference(int* arr, int size) //using void here because we are not returning anything
{
	//implement bubble sort alg (by reference)
	for (int i = 0; i < size - 1; i++)
	{
		for (int j = 0; j < size - i - 1; j++)
		{
			if (arr[j] > arr[j + 1]) //using the original array here, since we are not copying to a new array
			{
				int temp = arr[j];
				arr[j] = arr[j + 1];
				arr[j + 1] = temp;
			}
		}
	}
}

//Calculate hypotenuse:

double pythagorean(double a, double b)
{
	return sqrt(pow(a, 2) + pow(b, 2));
	//could have also used sqrt(a * a + b * b), they seem to be equivalent
	//sqrt is a function from the math library that calculates the square root of a number
	//a * a + b * b is the same as a^2 + b^2 = c^2, which is the pythagorean theorem
}

///Report for Assignment 5:
/*
 -After looking up how to calculate square roots in C, I found that there is a function in the math.h library called sqrt that	calculates the square root of a number. So, I needed #include <math.h> at the top of my program.
 -I also found that there is a function called pow that calculates the power of a number, also in the math.h libary.
 -Apparently there is also a hypot() function that calculates the hypotenuse of a right triangle. So I guess I could have just used that, instead of making my own pythagorean() function. Oh, well.
 -I used the pow function to calculate the square of a and b, and then added them together. Then, I used the sqrt function to calculate the square root of the sum of a^2 and b^2.
pythagorean set as a double because the sqrt function returns a double.

For printing, I used %lf instead of %f. It didn't seem to make any difference for the test cases, but I guess %lf instead of %f would allow for larger numbers to be printed.*/

//definition for print_board function:
void printBoard(char board[3][3])
{
	printf("Current board:\n");
	printf("-------------\n");

	for (int i = 0; i < 3; i++) //outer loop iterates through the rows
	{
		for (int j = 0; j < 3; j++) //inner loop iterates through the columns
		{
			printf("%c ", board[i][j]); //prints the current element
		}
		printf("\n"); //prints a new line after each row
	}
	printf("-------------\n");
}