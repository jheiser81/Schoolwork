#pragma once
#include "Vehicle.h"

class Car {
private:
	Vehicle vehicle;
public:
	Car(const std::string& color, int year, const std::string& make, const std::string& model);
	void soundHorn();
	void start();
	void stop();
	void accelerate();
	void decelerate();
	std::string getInfo();
};
