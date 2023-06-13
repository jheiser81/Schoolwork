#pragma once
#include <string>

class Boat {
public:
	Boat(const std::string& name, float length, int maxPassengers);

	virtual void sail() = 0;
	virtual void dock() = 0;

	std::string getName() const;
	float getLength() const;
	int getMaxPassengers() const;

protected:
	std::string name;
	float length;
	int maxPassengers;
};