#include <iostream>
#include "Animal.h"

Animal::Animal(const std::string& name, const std::string& sound) : name(name), sound(sound) {}

std::string Animal::getName() const {
	return name;
}

void Animal::setName(const std::string& name) {
	this->name = name;
}

void Animal::makeSound() {
	std::cout << sound << std::endl;
}

//std::string Animal::printInfo() {
//	return "Name: " + name + ", Sound: " + sound + "\n";
//}