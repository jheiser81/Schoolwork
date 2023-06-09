#include <iostream>
#include "Vehicle.h"

Vehicle::Vehicle(const std::string& color, int year, const std::string& make, const std::string& model) : color(color), year(year), make(make), model(model) {
	speed = 0;
}

void Vehicle::soundHorn() {
	std::cout << "Vehicle horn" << "\n";
}

void Vehicle::start() {
	std::cout << "Vehicle started" << "\n";
}

void Vehicle::stop() {
	std::cout << "Vehicle stopped" << "\n";
}

void Vehicle::accelerate() {
	std::cout << "Vehicle is accelerating" << "\n";
}

void Vehicle::decelerate() {
	std::cout << "Vehicle is decelerating" << "\n";
}

std::string Vehicle::getInfo() {
	return "Make: " + make + ", Model: " + model + ", Color: " + color + ", Year: " + std::to_string(year);
}