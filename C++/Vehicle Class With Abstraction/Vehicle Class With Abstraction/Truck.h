#pragma once
#include <string>
#include "Vehicle.h"

class Truck : public Vehicle {

public:
	Truck(const std::string& make, const std::string& model, int year, int numDoors, bool has4WD);

	void drive() override;
	void honk() override;

	int getNumDoors() const;
	void setNumDoors(int numDoors);

	bool getHas4WD() const;
	void setHas4WD(bool has4WD);

private:
int numDoors;
bool has4WD = false;
};