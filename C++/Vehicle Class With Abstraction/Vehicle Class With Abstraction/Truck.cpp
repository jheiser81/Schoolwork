#include "Truck.h"
#include <iostream>

Truck::Truck(const std::string& make, const std::string& model, int year, int numDoors, bool has4WD) : Vehicle(make, model, year), numDoors(numDoors), has4WD(has4WD) {}

void Truck::drive() {
	std::cout << "Driving truck...\n";
}

void Truck::honk() {
	std::cout << "HONK! HONK!\n";
}

int Truck::getNumDoors() const {
	return numDoors;
}

void Truck::setNumDoors(int numDoors) {
	this->numDoors = numDoors;
}
bool Truck::getHas4WD() const {
	return has4WD;
}

void Truck::setHas4WD(bool has4WD) {
	this->has4WD = has4WD;
}





