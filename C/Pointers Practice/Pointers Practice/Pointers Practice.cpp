// Pointers Practice.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <stdio.h>

struct Person {
	char name[50];
	int age;
};

int main()
{
	struct Person* personPtr;
	personPtr = (struct Person*)malloc(sizeof(struct Person));
	if (personPtr != NULL)
	{
		strcpy_s(personPtr->name, "John");
		personPtr->age = 25;
	}
	else
	{
		printf("Memory allocation failed\n");
	}

	struct Person person;
	strcpy_s(person.name, "John");
	person.age = 25;

	printf("Name: %s\n", person.name);

	//int num = 10;
	//int* ptr;
	//*int num = 10;*/
	//ptr = &num;
	//printf("The value of num is %p\n", num);

	//printf("Pointers with primitive data type Integer\n");
	//int myInt = 10;
	//int* myIntPointer = &myInt; //this is how you declare a pointer. The * is used to declare a pointer. The & is used to get the address of the variable.
	//printf("Pointer data (address of myInt): %p\n", myIntPointer); //this is how you print the address of a pointer. The %p is used to print the address of a pointer.
	//printf("Pionter address: (address of myIntPointer): %p\n", &myIntPointer);
	//printf("myInt Pointer: %p\n", myIntPointer);
	//printf("Data in myInt %d\n", myInt);
	//printf("Data in myIntPointer %d\n\n\n", *myIntPointer); //this is called dereferencing, which means to get the value of the pointer. Confusing term but essentially it just gets the value, not the address.

	return 0;
}