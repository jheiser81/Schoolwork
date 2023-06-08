#include <iostream>

//Gain Familiarity :

//Input Output
//Only use cin and cout, no if's, loops etc
//
//1. Ask for name and age then print a greeting :
//-Input : "John", 36
//- Output : "Hello, John! You are 36 years old"
//
//2. Ask for two numbers and print the product :
//-Input : 3, 4
//- Output : "The product is 12."
//
//3. Write A program that takes in 2 numbers as the input and prints their + -*/ as follows :
//input: 12 and 3
//output :
//    12 + 3 = 15
//    12 - 3 = 9
//    13 / 3 = 4
//    12 * 3 = 36
//---------------------------------------------
//Using only if's. No loops, arrays etc
//4. Ask for a number and print even or odd:
//-Input : 4
//- Output : "The number is even."
//- Input : 7
//- Output : "The number is odd."
//
//5. 'Divisible by 2 or 3'
//* Additional Inputs & Outputs :
//	-Input : `int num = 4; `, Output: `The number is divisible by 2.`
//	- Input: `int num = 9; `, Output: `The number is divisible by 3.`
//	- Input: `int num = 7; `, Output: `The number is not divisible by 2 or 3.`
//
//	6. 'Past, Present, or Future'
//	* Additional Inputs & Outputs:
//-Input : `int year = 2022; `, Output: `The year is in the past.`
//- Input: `int year = 2023; `, Output: `The year is the present year.`
//- Input: `int year = 2024; `, Output: `The year is in the future.`

int main()
{
	//Exercise 1:
	std::string name;
	int age;
	std::cout << "Enter your name and age: ";
	std::cin >> name >> age;
	std::cout << "Hello, " << name << "! You are " << age << " years old. \n\n";

	//Exercise 2:
	int num1, num2;
	std::cout << "Enter two numbers: \n";
	std::cin >> num1 >> num2;
	std::cout << "The product of the two numbers is " << num1 * num2 << ". \n"; */
		std::cout << "The product of " << num1 << " and " << num2 << " is " << num1 * num2 << "\n\n"; //why is this so cumbersome in C++ ???!!!

	//Exercise 3:
	int newNum1, newNum2;
	std::cout << "Enter two new numbers\n";
	std::cin >> newNum1 >> newNum2;
	std::cout << "The sum of " << newNum1 << " and " << newNum2 << " is " << newNum1 + newNum2 << "\n";
	std::cout << "The difference of " << newNum1 << " and " << newNum2 << " is " << newNum1 - newNum2 << "\n";
	std::cout << "The quotient of " << newNum1 << " and " << newNum2 << " is " << newNum1 / newNum2 << "\n";
	std::cout << "The product of " << newNum1 << " and " << newNum2 << " is " << newNum1 * newNum2 << "\n";

	//Exercise 4:
	int ifNum;
	std::cout << "Enter a number: \n";
	std::cin >> ifNum;
	if (ifNum % 2 == 0)
	{
		std::cout << "The number is even\n";
	}
	else
	{
		std::cout << "The number is odd\n";
	}

	//Exercise 5:
	int ifNum2;
	std::cout << "Enter a number: \n";
	std::cin >> ifNum2;
	if (ifNum2 % 2 == 0)
	{
		std::cout << "The number is divisible by 2\n";
	}
	else if (ifNum2 % 3 == 0)
	{
		std::cout << "The number is divisible by 3\n";
	}
	else
	{
		std::cout << "The number is not divisible by 2 or 3\n";
	}

	//Exercise 6:
	int year;
	std::cout << "Enter a year: \n";
	std::cin >> year;

	if (year < 2023)
	{
		std::cout << "The year is in the past\n";
	}
	else if (year == 2023)
	{
		std::cout << "The year is the present year\n";
	}
	else
	{
		std::cout << "The year is in the future\n";
	}
}