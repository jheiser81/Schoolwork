#include <iostream>
#include "Truck.h"

Truck::Truck(const std::string& color, int year, const std::string& make, const std::string& model)
	: vehicle(color, year, make, model) {}

void Truck::soundHorn() {
	std::cout << "Truck horn" << "\n";
}

void Truck::start() {
	vehicle.start();
}

void Truck::stop() {
	vehicle.stop();
}

void Truck::accelerate() {
	vehicle.accelerate();
}

void Truck::decelerate() {
	vehicle.decelerate();
}

std::string Truck::getInfo() {
	return "Truck: " + vehicle.getInfo();
}