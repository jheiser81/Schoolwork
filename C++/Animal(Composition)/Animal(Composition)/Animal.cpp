#include <iostream>
#include "Animal.h"

Animal::Animal(const std::string& name, const std::string& sound) : name(name), sound(sound) {}

std::string Animal::getName() const {
	return name;
}

std::string Animal::getSound() const {
	return sound;
}

void Animal::setName(const std::string& name) {
	this->name = name;
}

void Animal::setSound(const std::string& sound) {
	this->sound = sound;
}

void Animal::makeSound() const {
	std::cout << name << " says " << sound << "\n";
}