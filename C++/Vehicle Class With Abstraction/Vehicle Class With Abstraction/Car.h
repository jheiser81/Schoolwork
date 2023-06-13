#pragma once
#include <string>
#include "Vehicle.h"

class Car : public Vehicle {
public:
	Car(const std::string& make, const std::string& model, int year);

	void drive() override; //overriding pure virtual function from Vehicle
	void honk() override;
};
