// Cat Class.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include "Cat.h"
#include "Dog.h"
#include <iostream>

//--Making a class (main .cpp file)--
/*
1) Make sure to add a reference to the header file(s) at the top of the file (#include "object.h") and also #include <iostream>

2) Create the constructor and destuctor (if using) for the class.
	-Syntax: ClassName object(parameter1, parameter2, etc);
	-You must use the exact same parameters as specified in the other constructors in the header and .cpp files, and in the same order.

3) Call the get functions to output the object's data members.
	-Syntax: output type << "output message" << object.function() << "\n";

4) Call the object's member functions object.function();

*/

int main()
{
	//Create a Cat object
	//Must use the exact same parameters from the constructors, and in the same order

	std::cout << "--Cat--\n";
	Cat myCat("Boots", "Tabby", "Orange", 5);

	//Calling the getter functions
	std::cout << "Name: " << myCat.getName() << "\n";
	std::cout << "Breed: " << myCat.getBreed() << "\n";
	std::cout << "Color: " << myCat.getColor() << "\n";
	std::cout << "Age: " << myCat.getAge() << "\n";

	//calling the other member functions
	myCat.meow();
	myCat.purr();
	myCat.hiss();

	std::cout << "\n--Dog--\n";
	Dog myDog("Rover", "Golden Retriever", "Golden", 3);

	std::cout << "Name: " << myDog.getName() << "\n";
	std::cout << "Breed: " << myDog.getBreed() << "\n";
	std::cout << "Color: " << myDog.getColor() << "\n";
	std::cout << "Age: " << myDog.getAge() << "\n";

	myDog.bark();
	myDog.tailWag();
	myDog.drool();

	return 0;
}