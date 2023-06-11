#include <iostream>
#include "Cat.h"

Cat::Cat(const std::string& name, const std::string& species, const std::string& sound) : Animal(name, species, sound) {}

void Cat::makeSound() {
	std::cout << "Meow!" << std::endl;
}