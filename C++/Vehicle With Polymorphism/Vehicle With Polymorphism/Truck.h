#pragma once
#include <string>
#include "Vehicle.h"

class Truck : public Vehicle {
public:
	Truck(const std::string& make, const std::string& model, int year);

	void drive() override;
	void honk() override;
	void pullTrailer();
};
