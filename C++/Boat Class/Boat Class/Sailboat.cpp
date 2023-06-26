#include "Sailboat.h"
#include <iostream>

Sailboat::Sailboat(const std::string& name, float length, int maxPassengers, int numSails) : Boat(name, length, maxPassengers), numSails(numSails) {}

void Sailboat::sail() {
	std::cout << "Sail away, sail away, sail away.\n";
}

void Sailboat::dock() {
	std::cout << "Docking at the marina.\n";
}

int Sailboat::getNumSails() const {
	return numSails;
}