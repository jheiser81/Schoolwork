#include <iostream>
#include "Vehicle.h"

Vehicle::Vehicle(const std::string& color, int year, const std::string& make, const std::string& model)
	: color(color), year(year), make(make), model(model) {
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
	std::cout << "Vehicle is accelerating: ";
	for (size_t i = 0; i < 10; i++)
	{
		std::cout << (speed += 10) << " k/h, ";
	}
	std::cout << "Acceleration complete" << "\n";
}

void Vehicle::decelerate() {
	std::cout << "Vehicle is decelerating: ";
	for (size_t i = 0; i < 10; i++)
	{
		std::cout << (speed -= 10) << " k/h, ";
	}
	std::cout << "Deceleration complete" << "\n";
}

std::string Vehicle::getInfo() {
	return "Color: " + color + "\n" + "Year: " + std::to_string(year) + "\n" + "Make: " + make + "\n" + "Model: " + model + "\n" + "Speed: " + std::to_string(speed) + "\n";
}