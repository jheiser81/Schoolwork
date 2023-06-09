#pragma once
#include <string>

class Vehicle
{
protected:
	std::string color, make, model;
	int year;
	int speed;
public:
	Vehicle(const std::string& color, int year, const std::string& make, const std::string& model);
	virtual void soundHorn();
	virtual void start();
	virtual void stop();
	virtual void accelerate();
	virtual void decelerate();
	virtual std::string getInfo();
};
