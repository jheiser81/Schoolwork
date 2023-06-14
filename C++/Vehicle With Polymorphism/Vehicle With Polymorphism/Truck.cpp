#include "Truck.h"
#include <iostream>

Truck::Truck(const std::string& make, const std::string& model, int year) : Vehicle(make, model, year) {}

void Truck::drive() {
	std::cout << "Driving a truck...\n";
}

void Truck::pullTrailer() {
	std::cout << "Pulling a trailer...\n";
}

void Truck::honk() {
	std::cout << "AHHHHHH honk!\n";
}