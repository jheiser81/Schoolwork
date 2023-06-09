#include <iostream>
#include "Car.h"

Car::Car(const std::string& color, int year, const std::string& make, const std::string& model) : Vehicle(color, year, make, model) {}

void Car::soundHorn() {
	std::cout << "Car horn blares. Beep beep!" << "\n";
}

void Car::start() {
	std::cout << "Car started" << "\n";
}

void Car::stop() {
	std::cout << "Car stopped" << "\n";
}

void Car::accelerate() {
	std::cout << "Car is accelerating: ";
	for (size_t i = 0; i < 10; i++)
	{
		std::cout << (speed += 10) << " k/h, ";
	}
	std::cout << "Acceleration complete." << "\n";
}

void Car::decelerate() {
	std::cout << "Car is decelerating: ";
	for (size_t i = 0; i < 10; i++)
	{
		std::cout << (speed -= 10) << " k/h, ";
	}
	std::cout << "Deceleration complete." << "\n";
}