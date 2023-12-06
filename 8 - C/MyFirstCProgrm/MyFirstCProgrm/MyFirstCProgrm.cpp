// MyFirstCProgrm.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <stdio.h>

void printHelloWorld() {
	char str[] = "Hello World!\n"; // Note the size of the array is not specified explicitly
	printf("%s", str);
}

int main()
{
	//printf("Hello World!\n"); //printf() is how you print to the console in C

	//printHelloWorld();
	//return 0; //return 0 means the program ran successfully

	char str[6] = { 'H', 'e', 'l', 'l', 'o','\0' };
	printf("%s\n", str);
	/*return 0;*/

	int x = 10;
	if (x > 0) {
		printf("x is positive\n");
	}
	return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started:
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file