#include <stdio.h>
#include <string.h>

///C Syntax General Rules:
//1. C is a case sensitive language. All commands in C must be in lowercase.
//2. C does not allow white space in variable names.
//3. C does not allow special characters in variable names except underscore (_).
//4. C does not allow keywords to be used as variable names.
//5. C does not allow variable names to start with a number.

///Input/Output in C:
//1. printf() is used to print output to the screen.
//2. scanf() is used to read input from the user.
//3. When printing to the console using printf(), you must use format specifiers to indicate the data type of the value you are printing.
//4. You must also use format specifiers when reading input from the user using scanf().
	//Common format specifiers:
	//%i: used to read or print integers.
	//%d: used to read or print integers or doubles. It is common to just use %d, since it can be used for both.
	//%f: used to read or print floating point values.
	//%c: used to read or print single characters.
	//%s: used to read or print strings.
	//there are other format specifiers, but these are the most common ones. Other ones can be looked up online.

///Data Types in C:
//1. int: used to store integer values (4 bytes).
//2. float: used to store floating point values (decimal values, 4 bytes).
//3. short: used to store small integers (2 bytes).
//4. long: used to store large integers (8 bytes).
//5. double: used to store double precision floating point values (8 bytes).
//6. char: used to store single characters (1 byte).
//7. void: used to indicate that a function does not return any value.
//8. long long: used to store very large integers (8 bytes).
//9. long double: used to store very large floating point values (10 bytes).
//* In C, string is not a data type. Instead you must use an array of characters to store a string.

///Operators in C:
//1. Arithmetic Operators:
	//'+': addition
	//'-': subtraction
	//'*': multiplication
	//'/': division
	//'%': modulus (remainder)
//2. Relational Operators:
	//'==': equal to
	//'!=': not equal to
	//'>': greater than
	//'<': less than
	//'>=': greater than or equal to
	//'<=': less than or equal to

///Conditional Statements in C:
//There are two main types of conditional statements in C: if statements and switch statements.
//
// If statements are used to execute a block of code if a condition is true. They control the flow of a program.
//
// Switch statements are used to execute a block of code depending on the value of an expression. They do not perform any kind of arithmetic or logical operations, they simply check a value   against a list of possible values and execute a block of code if the value matches one of the possible values.
//
// 1. IF STATEMENT:
//
//	if (condition)
//	{
//		code to execute if condition is true
//	}
// ---------------------------------------------
//2. IF-ELSE STATEMENT:
//
//if (condition)
//	{
//		code to execute if condition is true
//	}
//	else
//	{
//		code to execute if condition is false
//	}
// ---------------------------------------------
//3. ELSE-IF STATEMENT:
//
//if (condition)
//	{
//		code to execute if condition is true
//	}
//	else if (condition)
//	{
//		code to execute if condition is true
//	}
//	else
//	{
//		code to execute if all conditions are false
//	}
//----------------------------------------------------
//4. SWITCH STATEMENT:
//
//switch (expression)
//	{
//		case value1:
//			code to execute if expression is equal to value1
//			break;
//		case value2:
//			code to execute if expression is equal to value2
//			default: code to execute if expression is not equal to any of the values
//	}
//
//5. NESTED IF STATEMENTS:
//
//	Nested if statements are if statements that are inside of other if statements. They are used to check multiple conditions.
//
//	if (condition)
//	{
//		if (condition)
//		{
//			code to execute if both conditions are true
//		}
//		else
//		{
//			code to execute if the first condition is true and the second condition is false
//		}
//	}
//	else
//	{
//		code to execute if the first condition is false
//	}

///Loops in C:
//There are three main types of loops in C: for loops, while loops, and do-while loops.
//
//FOR LOOPS are used to execute a block of code a certain number of times. They are used when you know how many times you want to execute a block of code.
//
//WHILE LOOPS are used to execute a block of code while a condition is true. They are used when you do not know how many times you want to execute a block of code, or when you want to execute a block of code until a certain condition is met.
//
//DO-WHILE LOOPS are used to execute a block of code while a condition is true. They are used when you do not know how many times you want to execute a block of code, or when you want to execute a block of code until a certain condition is met. The difference between a while loop and a do-while loop is that a do-while loop will always execute the block of code at least once, even if the condition is false.
//
//1. FOR LOOP:
//
//for (initialization; condition; increment)
//	{
//		code to execute
//	}
//
// Example:
//
// for (int i = 0; i < 10; i++)
//
// here, i stands for index, which is initialized to 0.
// The loop will execute as long as i is less than 10. After each iteration, i will be incremented by 1.
// ---------------------------------------------
//2. WHILE LOOP:
//
//while (condition)
//	{
//		code to execute
//	}
//
// Example:
//
// while (i < 10)
//
// This is the exact same loop as the for loop above, but written as a while loop.
// Note that it is preferable to use a for loop in this case, since it is more concise, and is what a for loop is designed for.
// ---------------------------------------------
//3. DO-WHILE LOOP:
//
//do
//	{
//		code to execute
//	} while (condition);
//
// Example:
//
// do
// {
//		printf("Hello World!\n");
// } while (i < 10);
//
// This loop will execute the code at least once, even if the condition is false.
// ---------------------------------------------
//4. BREAK STATEMENT:
//
// The break statement is used to exit a loop. It is used when you want to exit a loop early (like when a condition has been met, and you don't want to continue), or for exiting a case in a switch statement.
//
// Example:
//
// for (int i = 0; i < 10; i++)
// {
//		if (i == 5)
//		{
//			break;
//		}
//		printf("%d\n", i);
// }
//
// This loop will print the numbers 0-4, and then exit the loop when i is equal to 5.
// ---------------------------------------------
//5. CONTINUE STATEMENT:
//
// The continue statement is used to skip the rest of the code in a loop, and continue with the next iteration of the loop.
// It is used when you want to skip a certain iteration of a loop.
//
// Example:
//
// for (int i = 0; i < 10; i++)
// {
//		if (i == 5)
//		{
//			continue;
//		}
//		printf("%d\n", i);
// }
//
// This loop will print the numbers 0-9, except for 5.
// ---------------------------------------------
//6. GOTO STATEMENT:
//
// The goto statement is used to jump to a label. It is used when you want to jump to a certain part of your code, and then continue executing from there.
//
// Example:
//
// for (int i = 0; i < 10; i++)
// {
//		if (i == 5)
//		{
//			goto label;
//		}
//		printf("%d\n", i);
// }
// label:
// printf("Hello World!\n");
//
// This loop will print the numbers 0-4, and then jump to the label, and print "Hello World!".
// Note that goto statements are generally considered bad practice, and should be avoided if possible as they can make code difficult to read and debug.
// ---------------------------------------------
//7. NESTED LOOPS:
//
// Loops can be nested inside other loops. This is useful when you want to perform a certain action for each iteration of an outer loop.
//
// Example:
//
// for (int i = 0; i < 10; i++)
// {
//		for (int j = 0; j < 10; j++)
//		{
//			printf("%d\n", j);
//		}
// }
//
// This loop will print the numbers 0-9, 10 times. The outer loop will first execute once, and then the inner loop will execute 10 times.
// Then the outer loop will execute again, and the inner loop will execute 10 times again.
// This will continue until the outer loop has executed 10 times.
// ---------------------------------------------

///Arrays in C:
//An array is a collection of elements of the same type placed in contiguous memory locations that can be individually referenced by using an index to a unique identifier.
//Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.
//Arrays utilize indexes to access array elements. The first element in an array is at index 0, the second element is at index 1, and so on.
//In C, an array can be made of any of the following types: int, char, float, and double.
//
//To create an array in C, there are two key steps:
//
//1. ARRAY DECLARATION: First, you must declare a variable of the desired array type, followed by square brackets, followed by the identifier name.
//2. ARRAY INITIALIZATION: Next, you must initialize the array by assigning values to each element of the array.
//
//Example:
//
//int main()
//{
//	int arr[5]; // array declaration
//	arr[0] = 5; // array initialization
//	arr[1] = 10;
//	arr[2] = 15;
//	arr[3] = 20;
//	arr[4] = 25;
//
//	printf("%d\n", arr[0]); // prints 5
//	printf("%d\n", arr[1]); // prints 10
//	printf("%d\n", arr[2]); // prints 15
//	printf("%d\n", arr[3]); // prints 20
//	printf("%d\n", arr[4]); // prints 25
//}
//
//This program declares an array of 5 integers, and then initializes each element of the array with a value.
//The values of the array are then printed to the screen.
//Note that the array indexes start at 0, and end at 4. This is because the array has 5 elements, and the indexes start at 0.
//If you try to access an element outside of the array, you will get an error.
//
//Note that you can also initialize an array at the time of declaration, like this:
//
//int arr[5] = {5, 10, 15, 20, 25};
//
//This will initialize each element of the array with the specified value.
//
//It is also possible to declare an array without specifying the size, like this:
//
//int arr[] = {5, 10, 15, 20, 25};
//
//This will automatically set the size of the array to the number of elements in the array initializer.
//In this case, the size of the array will be 5.
//For the most part, you will want to declare the size of the array, but this is useful if you don't know the size of the array ahead of time.

///Sorting Arrays in C:
//There are many different sorting algorithms that can be used to sort arrays in C. A common sorting algorithm is the bubble sort algorithm.
//The bubble sort algorithm works by repeatedly swapping adjacent elements that are out of order.
//The algorithm will continue until the array is sorted.
//
//Example:
//
//int main()
//{
//	int arr[5] = { 25, 20, 15, 10, 5 };
//
//	/*bubble sort algorithm*/
//	for (int i = 0; i < 5; i++)
//	{
//		for (int j = 0; j < 5 - i - 1; j++)
//		{
//			if (arr[j] > arr[j + 1])
//			{
//				int temp = arr[j];
//				arr[j] = arr[j + 1];
//				arr[j + 1] = temp;
//			}
//		}
//	}
//
//	//print sorted array
//	for (int i = 0; i < 5; i++)
//	{
//		printf("%d\n", arr[i]);
//	}
//	return 0;
//}
//
//
//This algorithm uses nested loops, and a temp variable to swap the elements.
//The way this works is that the outer loop will execute 5 times, and the inner loop will execute 4 times.
//The inner loop will compare each element of the array with the element next to it, and swap them if they are out of order.
//After the first iteration of the outer loop, the largest element will be at the end of the array.
//After the second iteration of the outer loop, the second largest element will be at the end of the array.
//This will continue until the array is sorted.

///Pointers in C:
//A pointer is a variable that stores the address of another variable.
//An easy way to think of pointers is they are signs that point to a location in memory.
//Pointers are used to store the addresses of other variables, and they are used to pass variables by reference.
//Pointers are declared by using the * operator.
//After declaring a pointer, you can assign the address of a variable to the pointer by using the & operator.
//Once a pointer has been directed to a variable, you can access the value of the variable by using the * operator again.
//This is called dereferencing the pointer.
//
//Example:
//
//int main()
//{
//	int x = 5;
//	int* ptr = &x;
//
//	printf("%d\n", x); //This will print the value of x, which is 5.
//	printf("%d\n", *ptr); //This will print the value of ptr, which is the address of x.
//	//This uses a pointer to pass x by reference.
//	//This means that any changes made to x inside the function will also be made to x outside the function.
//	//In order to pass by value instead, you would need to pass a copy of x to the function.
//  //The & operator is used to get the address of a variable, so &x will return the address of x.
//}

///Functions in C:
//Functions are used to perform certain actions, and they are important for code reusability. In C, functions are used to break up large programs into smaller, more manageable pieces.
//In C, functions are broken up into three parts: the function declaration, the function definition, and the function call.
//
//1.FUNCTION DECLARATION:The function declaration tells the compiler about a function's name, return type, and parameters. The function declaration is also called the function prototype.
//
//2g.FUNCTION DEFINITION:The function definition provides the actual body of the function. The function definition is also called the function implementation.
//
//3.FUNCTION CALL:The function call is the place where the function is invoked, or called. The function call tells the compiler to execute the function. This is done from inside the default main() function.
//
//Example:
//
//int add(int x, int y); // function declaration
//
//int main()
//{
//	int sum = add(5, 10); // function call
//	printf("%d\n", sum);
//}
//
//int add(int x, int y) // function definition
//{
//	return x + y;
//}
//
//This program will print the number 15. The function add() is declared at the top of the program, and defined at the bottom of the program.
//The function add() takes two parameters, x and y, and returns the sum of the two parameters.
//The function add() is called from inside the main() function, and the result is stored in the variable sum.

///Exercise 1: Number Arithmetic
//Write a function named add, subtract, multiply, and divide that take two double parameters and return the result
//of the arithmetic operation on those two numbers.

///Exercise 2: Count Even Numbers
//Write a function named countEvenNumbers that takes an integer array and its length as parameters and returns the count of even numbers in the array.
//
//Pseudocode:
//function countEvenNumbers(array, length) :
//	count = 0
//	for i from 0 to length - 1 :
//		if array[i] is even :
//count = count + 1
//return count
//
//int add(int x, int y); // function declaration for add
//int subtract(int x, int y); // function declaration for subtract
//int multiply(int x, int y); // function declaration for multiply
//double divide(double x, double y); // function declaration for divide
////
//int countEvenNums(int numArray[10], int length); // function declaration for countEvenNums
//
//int main()
//{
//	int addResult = 0;
//	int subtractResult = 0;
//	int multiplyResult = 0;
//	double divideResult = 0;
//
//	addResult = add(5, 10); // function call for add
//	subtractResult = subtract(5, 10); // function call for subtract
//	multiplyResult = multiply(5, 10); // function call for multiply
//	divideResult = divide(5, 10); // function call for divide
//
//	printf("The result of add is %d\n", addResult);
//	printf("The result of subtract is %d\n", subtractResult);
//	printf("The result of multiply is %d\n", multiplyResult);
//	printf("The result of divide is %f\n\n", divideResult);
//
//	// function call for countEvenNums
//	int numArray[10]{ 2, 4, 6, 8, 10, 1, 3, 5, 7, 9 };
//	int evenCount = countEvenNums(numArray, 10); //this calls the countEvenNums function and passes the array and the length of the array as parameters
//	printf("There are %d even numbers in the array\n", evenCount);
//}
//
//int add(int x, int y)
//{
//	return x + y;
//}
//
//int subtract(int x, int y)
//{
//	return x - y;
//}
//
//int multiply(int x, int y)
//{
//	return x * y;
//}
//
//double divide(double x, double y)
//{
//	return x / y;
//}
//
//// function definition for countEvenNums
//int evenCount = 0;
//int countEvenNums(int numArray[10], int length)
//{
//	for (int i = 0; i < length; i++)
//	{
//		if (numArray[i] % 2 == 0)
//		{
//			evenCount++;
//		}
//	}
//	return evenCount;
//}

///Structs in C:
//A struct is a user-defined data type that groups related variables of different data types into a single unit.
//Structs are basically the way that C handles object-oriented programming, but it is not quite the same.
//A struct can be declared outside of a function, in which case it is called a global struct.
//A struct can also be declared inside of a function, in which case it is called a local struct.
//A struct is declared using the struct keyword, as follows:
//
//struct Person
//{
//	char name[50];
//	int age;
//	double weight;
//};
//
//This declares a struct named Person that contains three members: name, age, and weight.
//The members of a struct can be accessed using the dot operator .
//The members of a struct can also be accessed using a pointer to the struct.
//The arrow operator (->) is used to access the members of a struct using a pointer to the struct.
//
//Example:
//
//Here we are declaring a struct named Person that contains three members: name, age, and weight.
//
//struct Person
//{
//	char name[50];
//	int age;
//	double weight;
//};
//
//int main()
//{
//	struct Person person1; //using the Person struct with a variable named person1
//
//	strcpy_s(person1.name, "John");			//using strcpy_s to copy the string "John" into the name member of the person1 struct
//	person1.age = 27;						//assigning the value 27 to the age member of the person1 struct
//	person1.weight = 180.5;					//assigning the value 180.5 to the weight member of the person1 struct
//
//	printf("Name: %s\n", person1.name);
//	printf("Age: %d\n", person1.age);
//	printf("Weight: %f\n", person1.weight); //then we print the values of the members of the person1 struct
//
//	struct Person person2;			 		//repeat the process for person2
//	strcpy_s(person2.name, "Phoebe");
//	person2.age = 22;
//	person2.weight = 120.5;
//
//	printf("\nName: %s\n", person2.name);
//	printf("Age: %d\n", person2.age);
//	printf("Weight: %f\n", person2.weight);
//
//	//This method is passing by value, which means that the function is making a copy of the struct and then using that copy.
//	//This is slower and uses more memory, but is safer as it doesn't change the original struct or the values of the members of the struct.
//
//	struct Person* ptrPerson;				 //here we are declaring a pointer to the Person struct named ptrPerson
//	ptrPerson = &person1;					 //here we are assigning the address of the person1 struct to the ptrPerson pointer
//
//	printf("\nName: %s\n", ptrPerson->name); //here we are using the arrow operator to access the members of the person1 struct using the ptrPerson pointer
//	printf("Age: %d\n", ptrPerson->age);	 //using the arrow operator is the same as using the dot operator with pointers, and is faster/easier to read
//	printf("Weight: %f\n", ptrPerson->weight);
//	ptrPerson = &person2;					 //here we are assigning the address of the person2 struct to the ptrPerson pointer so that we can print the values of the person2 struct
//
//	printf("\nName: %s\n", ptrPerson->name);
//	printf("Age: %d\n", ptrPerson->age);
//	printf("Weight: %f\n", ptrPerson->weight);
//
//	//This method is passing by reference, which means that the function is using the actual struct and not a copy of it.
//	//This is more memory-efficient than passing by value, but it changes the values of the struct so should be used with caution.
//
//	return 0;
//}

///Linked Lists in C:
//A linked list is a data structure that consists of a sequence of 'nodes'. Each node contains data and a pointer to the next node in the list. The last node in the list points to NULL.
//The first node in the list is typically called the 'head' of the list, or the start.
//The last node in the list is typically called the 'tail' of the list, or the end.
//A linked list can be declared outside of a function, in which case it is called a global linked list.
//A linked list can also be declared inside of a function, in which case it is called a local linked list.
//A linked list is declared using the struct keyword
//
//The members of a linked list can be accessed using the dot operator .
// he members of a linked list can also be accessed using a pointer to the linked list.
//The arrow operator (->) is used to access the members of a linked list using a pointer to the linked list. The difference between  the dot operator and the arrow operator is that the dot operator is used with the name of the linked list, while the arrow operator is used with a pointer to the linked list.
//It is necessary to use the malloc() function to allocate memory for the linked list. Malloc stands for memory allocation.
//The malloc() function takes the size of the linked list as an argument and returns a pointer to the linked list.
//
//Example:
//
//Here we are declaring a linked list named Node that contains two members: data and next.
//
//struct Node
//{
//	int data;
//	struct Node* next;
//};
//
//int main()
//{
//	struct Node* head = NULL; //declaring a pointer to the Node struct named head and assigning it to NULL
//	struct Node* second = NULL; //declaring a pointer to the Node struct named second and assigning it to NULL
//	struct Node* third = NULL; //declaring a pointer to the Node struct named third and assigning it to NULL
//
//	head = (struct Node*)malloc(sizeof(struct Node)); //allocating memory for the head pointer
//	second = (struct Node*)malloc(sizeof(struct Node)); //allocating memory for the second pointer
//	third = (struct Node*)malloc(sizeof(struct Node)); //allocating memory for the third pointer
//
//	head->data = 1; //assigning the value 1 to the data member of the head struct
//	head->next = second; //assigning the address of the second struct to the next member of the head struct
//
//	second->data = 2; //assigning the value 2 to the data member of the second struct
//	second->next = third; //assigning the address of the third struct to the next member of the second struct
//
//	third->data = 3; //assigning the value 3 to the data member of the third struct
//	third->next = NULL; //assigning NULL to the next member of the third struct
//
//	printf("The first node contains the value %d\n", head->data); //printing the value of the data member of the head struct
//	printf("The second node contains the value %d\n", second->data); //printing the value of the data member of the second struct
//	printf("The third node contains the value %d\n", third->data); //printing the value of the data member of the third struct
//
//	return 0;
//}