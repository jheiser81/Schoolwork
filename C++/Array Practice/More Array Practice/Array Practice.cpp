// Array Practice.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <algorithm>
//Replace all odd numbers in an array of size 5 with - 1.
//
//Input: array = { 1, 2, 3, 4, 5 }
//Output: array = { -1, 2, -1, 4, -1 }
//
//Input: array = { 2, 4, 6, 8, 10 }
//Output: array = { 2, 4, 6, 8, 10 }
//
//Input: array = { 1, 3, 5, 7, 9 }
//Output: array = { -1, -1, -1, -1, -1 }

int main()
{
	int numArray[] = { 1, 3, 5, 7, 9 };
	for (int i = 0; i < 5; i++)
	{
		if (numArray[i] % 2 != 0)
		{
			numArray[i] = -1; //this was simply redelaring each odd number in the array as -1, I don't know why this was so hard for me to figure out
		}
		std::cout << numArray[i] << "\n";
	}

	std::string strArray[] = { "Hello", "World", "How", "Are", "You" };
	std::cout << "\nPrint in normal order\n";
	for (int i = 0; i < 5; i++)
	{
		std::cout << strArray[i] << "\n";
	}
	std::cout << "\nNon-cheat reverse array\n";
	for (int i = 4; i >= 0; i--)
	{
		std::cout << strArray[i] << "\n";
	}
	std::cout << "\nReverse array using reverse function and #include <algorithm>\n";
	reverse(strArray, strArray + 5); //this is kind of a cheat, but it works
	for (int i = 0; i < 5; i++)
	{
		std::cout << strArray[i] << "\n";
	}

	//make an array of 10 numbers, print it, then set every even number to 100
	int newArray[10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	std::cout << "\nPrint original numbers\n";
	for (int i = 0; i < 10; i++)
	{
		std::cout << newArray[i] << "\n";
	}
	std::cout << "\nUpdating even nums to 100\n";
	for (int i = 0; i < 10; i++)
	{
		if (newArray[i] % 2 == 0)
		{
			newArray[i] = 100;
		}
		std::cout << newArray[i] << "\n";
	}
}