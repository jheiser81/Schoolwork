#include "Dog.h"
#include <iostream>

//Constructor
Dog::Dog(const std::string& name, const std::string& breed, const std::string& color, int age) : name(name), breed(breed), color(color), age(age) {}

//Getters and setters
std::string Dog::getName() const { return name; }
void Dog::setName(const std::string& name) { this->name = name; }

std::string Dog::getBreed() const { return breed; }
void Dog::setBreed(const std::string& breed) { this->breed; }

std::string Dog::getColor() const { return color; }
void Dog::setColor(const std::string& color) { this->color = color; }

int Dog::getAge() const { return age; }
void Dog::setAge(int age) { this->age; }

//Other functions
void Dog::bark() const { std::cout << "The dog barks excitedly \n"; }
void Dog::tailWag() const { std::cout << "The dog wags its tail happily \n"; }
void Dog::drool() const { std::cout << "The dog drools \n"; }