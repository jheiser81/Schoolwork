#pragma once
#include "Animal.h"

//Instructions:
/*
1. Implement an `Animal` class with the following attributes and behaviors(10 points) :
	-Member variables `sound` and `name`, both of type string.These attributes will define the specific sound and name for each `Animal` instance(5 points).
	- A function `makeSound()` that, when called, prints the sound of the `Animal` instance to the console.This behavior is common to all `Animal` instances(5 points).

	2. Construct a `PetOwner` class (40 points) :
	-This class should represent an owner of pets.It should contain private member variables that are `Animal` objects, symbolizing the pets owned by the PetOwner instance(10 points).
	- For the scope of this assignment, assume that each `PetOwner` owns a dog and a cat.Hence, the `PetOwner` class should have exactly two `Animal` objects as member variables.
	- It should also incorporate an additional integer member variable `totalFetches`, initially set to 0. This variable will keep track of the number of times the pet owner has played "fetch" with their dog(5 points).
	- Implement a function `playFetchWithDog()` that takes a string argument representing an item.Each time the `playFetchWithDog()` function is called, increment `totalFetches` by 1. If `totalFetches` reaches or surpasses 20, print a message indicating that the owner needs a break from playing, reset `totalFetches` to 0, and modify the dog's name by appending the string representation of `totalFetches` to its original name (15 points).
	- Implement a function `hearAnimalSound()` that takes as argument an `Animal` object owned by the `PetOwner`. The function should call the `makeSound()` function of the given `Animal` object, thereby printing the sound made by the `Animal` (10 points).*/
