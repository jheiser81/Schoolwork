#include <iostream>
#include "Car.h"

Car::Car(const std::string& color, int year, const std::string& make, const std::string& model)
	: vehicle(color, year, make, model) {}

void Car::soundHorn() {
	std::cout << "Car horn" << "\n";
}

void Car::start() {
	vehicle.start();
}

void Car::stop() {
	vehicle.stop();
}

void Car::accelerate() {
	vehicle.accelerate();
}

void Car::decelerate() {
	vehicle.decelerate();
}

std::string Car::getInfo() {
	return "Car: " + vehicle.getInfo();
}