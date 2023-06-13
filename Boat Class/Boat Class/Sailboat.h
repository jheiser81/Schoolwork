#pragma once
#include <string>
#include "Boat.h"

class Sailboat : public Boat {
public:
	Sailboat(const std::string& name, float length, int maxPassengers, int numSails);

	void sail() override;
	void dock() override;

	int getNumSails() const;

private:
	int numSails;
};
