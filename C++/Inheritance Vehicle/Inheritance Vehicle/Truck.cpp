#include <iostream>
#include "Truck.h"

Truck::Truck(const std::string& color, int year, const std::string& make, const std::string& model) : Vehicle(color, year, make, model) {}

void Truck::soundHorn() {
	std::cout << "Truck horn blares. Honk honk!" << "\n";
}

void Truck::start() {
	std::cout << "Truck started" << "\n";
}

void Truck::stop() {
	std::cout << "Truck stopped" << "\n";
}

void Truck::accelerate() {
	std::cout << "Truck is accelerating: ";
	for (size_t i = 0; i < 10; i++)
	{
		std::cout << (speed += 10) << " k/h, ";
	}
	std::cout << "Acceleration complete." << "\n";
}

void Truck::decelerate() {
	std::cout << "Truck is decelerating: ";
	for (size_t i = 0; i < 10; i++)
	{
		std::cout << (speed -= 10) << " k/h, ";
	}
	std::cout << "Deceleration complete." << "\n";
}