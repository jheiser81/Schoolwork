#include "Vehicle.h"
#include <iostream>

Vehicle::Vehicle(const std::string& make, const std::string& model, int year) : make(make), model(model), year(year) {}

std::string Vehicle::getMake() const {
	return make;
}

std::string Vehicle::getModel() const {
	return model;
}

int Vehicle::getYear() const {
	return year;
}