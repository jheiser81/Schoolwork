#pragma once
#include <string>

class Vehicle {
public:
	Vehicle(const std::string& make, const std::string& model, int year);

	virtual void drive() = 0;
	virtual void honk() = 0;

	std::string getMake() const;
	std::string getModel() const;
	int getYear() const;

protected:
	std::string make;
	std::string model;
	int year;
};