#include "Car.h"
#include <iostream>

Car::Car(const std::string& make, const std::string& model, int year) : Vehicle(make, model, year) {}

void Car::drive() {
	std::cout << "Driving a car\n";
}

void Car::honk() {
	std::cout << "Honk! Honk!\n";
}