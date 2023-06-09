#pragma once
#include "Vehicle.h"

class Truck {
private:
	Vehicle vehicle;
public:
	Truck(const std::string& color, int year, const std::string& make, const std::string& model);
	void soundHorn();
	void start();
	void stop();
	void accelerate();
	void decelerate();
	std::string getInfo();
};