// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include <stdio.h>

int main() {
	/*int age;
	printf("Enter your age: ");
	scanf_s("%d", &age);

	printf("\n");

	if (age < 0) {
		printf("Invalid age\n");
	}
	else if (age < 13) {
		printf("You are a child\n");
	}
	else if (age < 18) {
		printf("You are a minor\n");
	}
	else if (age < 60) {
		printf("You are an adult\n");
	}
	else {
		printf("You are a senior citizen\n");
	}

	printf("\n");

	int x = 5;
	if (x > 0)
	{
		printf("x is positive\n");
	}

	printf("\n");

	int day = 5;
	switch (day)
	{
	case 1:
		printf("Monday\n");
		break;
	case 2:
		printf("Tuesday\n");
		break;
	case 3:
		printf("Wednesday\n");
		break;
	case 4:
		printf("Thursday\n");
		break;
	case 5:
		printf("Friday\n");
		break;
	default:
		printf("Day is a weekend\n");
		break;
	}

	printf("\n");

	int num = 2;
	switch (num)
	{
	case 1:
		printf("One\n");
	case 2:
		printf("Two\n");
	case 3:
		printf("Three\n");
		break;
	default:
		printf("Invalid number");
		break;
	}*/

	//	int i = 1;
	//
	//loop:
	//	printf("%d ", i);
	//	i++;
	//
	//	if (i <= 5) {
	//		goto loop;  // jump back to the 'loop' label
	//	}
	//end:
	//	printf("End of program\n");
	//	// Output: 1 2 3 4 5
	//
	//	int num;
	//	do {
	//		printf("Enter a number between 1-10: ");
	//		scanf_s("%d", &num);
	//	} while (num < 1 || num > 10);

		//int num1 = 0;
		//while (num1 < 1 || num1 > 10) {
		//	printf("Enter a number between 1-10: ");
		//	scanf_s("%d", &num1);
		//}

		// Declare and initialize an array of integers with hardcoded values:

	//int numbers[] = { 2, 4, 6, 8, 10 };

	//// Access and print the elements of the array
	//for (int i = 0; i < 5; i++) {
	//	printf("Element %d: %d\n", i, numbers[i]);
	//}

	//printf("\n");

	//int numbers2[] = { 2, 4, 6, 8, 10 };

	//// Access and print the value at index 2
	//printf("Original value at index 2: %d\n", numbers2[2]);

	//// Assign a new value to the third element (index 2)
	//numbers2[2] = 12;

	//// Access and print the updated value at index 2
	//printf("Updated value at index 2: %d\n", numbers2[2]);

	//int numArray[10];
	//for (int i = 0; i < 10; i++) {
	//	numArray[i] = i + 1;
	//	printf("Element %d: %d\n", i, numArray[i]);
	//}

	//int n[10]; /* n is an array of 10 integers */
	//int i, j;

	/* initialize elements of array n to 0 */
	//for (i = 0; i < 10; i++) {
	//	n[i] = i + 100; /* set element at location i to i + 100 */
	//}

	/* output each array element's value */
	/*for (j = 0; j < 10; j++) {
		printf("Element[%d] = %d\n", j, n[j]);
	}*/

	//int matrix[3][4] = { //creating a 2D array with 3 rows and 4 columns
	//	{1, 2, 3, 4},
	//	{5, 6, 7, 8},
	//	{9, 10, 11, 12}
	//};

	//printf("Matrix elements:\n");

	//for (int i = 0; i < 3; i++) {
	//	for (int j = 0; j < 4; j++) {
	//		printf("%d", matrix[i][j]);
	//	}
	//	printf("\n");
	//}

	//Function declaration
	int add(int a, int b);

	int num1 = 5;
	int num2 = 10;

	//Function call
	int sum = add(num1, num2);

	printf("Sum: %d\n", sum);

	return 0;
}

//Function definition
int add(int a, int b) {
	return a + b;
}