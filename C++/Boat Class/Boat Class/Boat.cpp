#include "Boat.h"
#include <iostream>

Boat::Boat(const std::string& name, float length, int maxPassengers) : name(name), length(length), maxPassengers(maxPassengers) {}

std::string Boat::getName() const {
	return name;
}

float Boat::getLength() const {
	return length;
}

int Boat::getMaxPassengers() const {
	return maxPassengers;
}