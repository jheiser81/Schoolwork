#pragma once
#include <string>

//Instructions:
/*Objective* : This assignment is designed to give you practical experience with two key concepts in Object - Oriented Programming(OOP) : inheritance and composition.You will build classes that model real - world entities and understand how these two techniques allow for flexible, modular, and reusable code.

** Part 1 : Inheritance(50 points) * *

1. Implement an `Animal` base class with the following attributes and behaviors(10 points) :
	-Protected member variables `sound` and `name`, both of type string(5 points).
	- A pure virtual function `makeSound()` that prints the sound the animal makes(5 points).

2. Develop a `Dog` class and a `Cat` class that inherit from the `Animal` base class (40 points) :
	-Override the `makeSound()` function in both classes.The `Dog` class should print "Woof!" and the `Cat` class should print "Meow!" (10 points).
	- The `Dog` class should include an additional integer member variable `fetchCount`, which is initially set to 0, and a function `fetchItem()` that takes a string argument representing an item.Each time `fetchItem()` is called, increment `fetchCount` by 1. Once `fetchCount` is equal to or exceeds 10, print a message that the dog is tired, reset `fetchCount` to 0, and append the fetched item to the dog's original name (30 points).*/

class Animal {
protected:
	std::string name, species, sound;
public:
	Animal(const std::string& name, const std::string& species, const std::string& sound);
	virtual void makeSound();
	virtual std::string showInfo();
};
