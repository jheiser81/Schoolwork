#pragma once
#include <string>
#include "Vehicle.h"

class Train : public Vehicle {
public:
	Train(const std::string& make, const std::string& model, int year, int numberOfCars);

	void drive() override;
	void honk() override;

	int getNumberOfCars() const;
	void setNumberOfCars(int numberOfCars);

private:
int numberOfCars;
};
