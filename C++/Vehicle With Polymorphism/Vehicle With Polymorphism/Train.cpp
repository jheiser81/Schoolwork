#include "Train.h"
#include <iostream>

Train::Train(const std:: string& make, const std::string& model, int year, int numberOfCars) : Vehicle(make, model, year), numberOfCars(numberOfCars)
{}

void Train::drive() {
	std::cout << "Driving down the railroad tracks.\n";
}

void Train::honk() {
	std::cout << "Choo Choo!\n";
}

int Train::getNumberOfCars() const {
	return numberOfCars;
}

void Train::setNumberOfCars(int numberOfCars) {
	this->numberOfCars = numberOfCars;
}



