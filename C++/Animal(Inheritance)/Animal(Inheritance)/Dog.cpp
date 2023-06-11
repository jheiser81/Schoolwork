#include <iostream>
#include "Dog.h"

Dog::Dog(const std::string& name, const std::string& species, const std::string& sound) : Animal(name, species, sound) {}

void Dog::makeSound() {
	std::cout << "Woof!" << std::endl;
}

void Dog::fetchItem(const std::string& item) {
	fetchCount++;
	if (fetchCount >= 10) {
		std::cout << "The dog is tired." << std::endl;
		Animal::name += item;
		fetchCount = 0;
	}
	else {
		std::cout << "The dog fetched the " << item << "." << std::endl;
	}
}