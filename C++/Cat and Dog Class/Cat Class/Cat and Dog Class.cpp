// Cat Class.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include "Cat.h"
#include "Dog.h"
#include <iostream>

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