#include <iostream>
#include <algorithm>
//using namespace std; //include this to avoid having to type std::cout every time you want to use it

//	C++ Syntax:
/*
	-#include <iostream> is a header file library that lets us work with input and output objects. Include this at the top of the file.

	-int main() is a function that is required in every C++ program. Code is executed from top to bottom, so the main() function is executed first.

	-std::cout is an object used together with the insertion operator (<<) to output/print text to the console.

	-It is considered good practice to use std::cout, instead of simply cout, but for this to function you must include the line using namespace std;** at the top of the file.

	-to insert a new line, you can use \n, same as in C

	-comments are the same as in C
*/

//	C++ Variables:
/*
	-C++ has the same basic data types as C, such as: int, double, float, char, bool, etc. Unlike in C, C++ includes the string data type.

	-variables are declared with the syntax: type variableName = value;

	-variables can be declared without a value, and assigned a value later

	-the const keyword is used to make variables unchangeable, or constant. This is similar to the const keyword in C.
*/

//	C++ Input/Output:
/*
	-In C++, you can use the std::cin object together with the extraction operator ( >> ) to get user input.
		For example: int x; cin >> x; will get the user input and store it in the variable x.

	-When printing variables in C++, it is not necessary to use C - style format specifiers, such as% d, % f, % c, etc.

	- You can simply use the insertion operator ( << ) to insert the variable into the output stream.However, printf() and format specifiers can still be used.

	- To combine text and a variable, you can use the + operator, or the insertion operator ( << ).
		For example : cout << "My favorite number is: " << myNum; or cout << "My favorite number is: " + myNum;

	-You can also use the cin object to get user input.This is similar to scanf() in C.
*/

// C++ Strings:
/*
	- C++ has a string class, which has many useful methods.

	- To declare a string in C++, you use the following syntax: string myString = "Some text";.

	- In C++, strings are objects, which allows for certain operations to be performed on them, such as concatenation and appending.

	-To concatenate two strings, you can use the + operator or the append() method.

	- In C++, you can use both single quote('') and double quote("") to declare string literals.

	- In C++, you can use the + operator to concatenate (combine) strings.

	- In C++, you can use the getline() function to read a line of text from a user. It takes cin as the first parameter, and the string variable as second.

	-To get the length of a string, you can use the length() or size() functions. They both do the same thing.

	-To access a single character from a string, you can use the [] operator. The index starts from 0. For instance, myString[2] will return the third character in the string.

	-To change the value of a single character in a string, refer to the index number, and use single quotes('') around the new character. For instance, string myString = "Hello"; myString[0] = 'J'; will change the value of the first character in the string to J, and outout Jello instead of Hello.

	-To use quotes inside a string, you can use the escape character (\) to escape the quotes. For instance, string txt = "We are the so-called \"Vikings\" from the north."; will output: We are the so-called "Vikings" from the north.
*/

//	C++ Operators:
/*
	- C++ has the same basic operators as C, such as: +, -, *, /, %, ++, --, etc.

	- C++ has the same logical operators as C, such as: ==, !=, >, <, >=, <=, &&, ||, !, etc.

	- C++ has the same assignment operators as C, such as: =, +=, -=, *=, /=, %=, &=, |=, ^=, >>=, <<=, etc.

	- C++ has the same misc operators as C, such as: &, *, ?, sizeof, etc.
*/

// C++ Math Functions:
/*
	-C++ has many built-in functions that can be used to perform mathematical tasks.

	-As there are many of these built-in functions, it is best to look these up as needed rather than trying to memorize them all.

	-To use these functions, you must include the cmath library at the top of the file: #include <cmath>
*/

// Arrays in C++:
/*
	-Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.

	-To declare an array in C++, you can use the same syntax as in C: type arrayName[arraySize];

	-You can also initialize an array when you declare it, by using the same syntax as in C: type arrayName[arraySize] = {value0, value1, value2, ...};

	-You can access elements of an array by referring to the index number, just like in C: arrayName[indexNumber];

	-You can change the value of an element in an array by referring to the index number, and using the assignment operator (=): arrayName[indexNumber] = newValue;

	-You can loop through an array using a for loop, just like in C.

	-There are other ways that arrays can be manipulated such as sorting, reversing, etc. These are similar to C, but there are also built-in functions that can be used.
		-To sort an array, you can use the sort() function, which is included in the algorithm library: #include <algorithm>
		-To reverse an array, you can use the reverse() function, which is also included in the algorithm library: #include <algorithm>.
		For example: sort(arrayName, arrayName + arraySize); or reverse(arrayName, arrayName + arraySize);
*/

// C++ Loops:
/*
	-C++ has the same basic loops as C, such as: for, while, do...while, etc.

	- C++ has the same break and continue statements as C.

	- C++ has the same goto statement as C.

	- C++ has the same switch statement as C.

	- To declare a for loop in C++, you use the following syntax:
		for (statement 1; statement 2; statement 3) { // code block to be executed }.
		For example:
		for (int i = 0; i < 5; i++)
		{ std:: cout << i << "\n"; }.

	- To declare a while loop in C++, you use the following syntax:
		while (condition)
		{ // code block to be executed }.
		For example:
		int i = 0;
		while (i < 5)
		{ std::cout << i << "\n"; i++; }.
*/

// C++ Functions:
/*	-functions in c++ are blocks of code that perform specific tasks.they are defined   with a name, a return type, and a set of parameters.

	-functions in c++ are similar to c, but there are some differences.

	- to declare a function in c++, you use the following syntax:

	- returntype functionname(parameter1, parameter2, parameter3, ...) { // code block	to be executed }.
		for example:
		int myfunction(int x, int y) { return x + y; }.
*/

int square(int a); //function prototype for square

int main()
{
	//std::cout << "Hello World!\nIt's a beautiful day!\n";
	//std::cout << "I am learning C++\n";
	//std::string color = "green";
	//std::cout << "My favourite color is: " << color << "\n"; //using the insertion operator (<<)
	//std::cout << "My favourite color is: " + color + "\n"; //using the + operator
	//std::string str = "Good-bye, Antimatter! \n";
	//for (int i = 0; i < str.length(); i++)
	//{
	//	std::cout << str[i] << "\n";
	//}

	/*std::string password = "1234";
	std::string input;
	while (input != password)
	{
		std::cout << "Enter your password: ";
		std::cin >> input;
	}
	std::cout << "Access granted. \n";*/

	//std::cout << "Input a number: ";
	//int x;
	//cin >> x; //cin gets user input and stores it in the variable x, and the >> is the extraction operator
	//std::cout << "The value of x is: " << x << "\n";

	/*std::string cars[5] = { "Volvo", "BMW", "Ford", "Mazda", "Tesla" };*/

	//print in normal order

	//for (int i = 0; i < 5; i++)
	//{
	//	std::cout << i << " = " << cars[i] << "\n";
	//}

	//std::cout << "\n";

	////print in reverse order
	//for (int i = 4; i >= 0; i--)
	//{
	//	std::cout << i << " = " << cars[i] << "\n";
	//}

	//sort(cars, cars + 5); //sort the array in alphabetical order
	//for (int i = 0; i < 5; i++)
	//{
	//	std::cout << i << " = " << cars[i] << "\n";
	//}

	//std::cout << "\n";

	//reverse(cars, cars + 5); //reverse the array

	//for (int i = 0; i < 5; i++)
	//{
	//	std::cout << i << " = " << cars[i] << "\n";
	//}

	////call the square function
	//std::cout << "\nThe square of 5 is: ";
	//std::cout << square(5) << "\n";

	int myArray[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	for (int i = 0; i < 10; i++)
		if (i == 5)
		{
			std::cout << "\n" << myArray[i] << " is at index " << i << "\n";
			std::cout << myArray[i] << ", ";
		}

	return 0;
}

int square(int a)
{
	return a * a;
}