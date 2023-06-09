#pragma once
#include "Vehicle.h"

class Car : public Vehicle
{
public:
	Car(const std::string& color, int year, const std::string& make, const std::string& model);
	void soundHorn() override;
	void start() override;
	void stop() override;
	void accelerate() override;
	void decelerate() override;
};
