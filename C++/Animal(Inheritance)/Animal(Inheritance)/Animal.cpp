#include <iostream>
#include "Animal.h"

Animal::Animal(const std::string& name, const std::string& species, const std::string& sound) : name(name), species(species), sound(sound) {}

void Animal::makeSound() {
	std::cout << sound << std::endl;
}

std::string Animal::showInfo() {
	return "Name: " + name + ", Species: " + species + ", Sound: " + sound + "\n";
}