#include "Boat.h"
#include "Sailboat.h"
#include <iostream>

int main()
{
	Sailboat sailboat("S. S. Minnow", 30.0f, 6, 3);

	std::cout << "Name: " << sailboat.getName() << "\n";
	std::cout << "Length: " << sailboat.getLength() << "\n";
	std::cout << "Max Passengers: " << sailboat.getMaxPassengers() << "\n";
	std::cout << "Number of Sails: " << sailboat.getNumSails() << "\n\n";

	sailboat.sail();
	sailboat.dock();

	return 0;
}