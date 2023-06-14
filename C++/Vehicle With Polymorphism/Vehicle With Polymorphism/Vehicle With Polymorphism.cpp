#include "Car.h"
#include "Truck.h"
#include "Train.h"
#include <iostream>
#include <string>

int main()
{
	Vehicle* vehicles[3];
	vehicles[0] = new Car("Ford", "Mustang", 1969);
	vehicles[1] = new Truck("Ford", "F-150", 2020);
	vehicles[2] = new Train("Thomas", "The Tank Engine", 1984, 60);
	int size = sizeof(vehicles) / sizeof(vehicles[0]);
	for (size_t i = 0; i < size; i++)
	{
		std::cout << vehicles[i]->getMake() << " " << vehicles[i]->getModel() << " " << vehicles[i]->getYear() << "\n";

		vehicles[i]->drive();
		vehicles[i]->honk();

		std::cout << "\n";
	}

	for (size_t i = 0; i < size; i++)
	{
		delete vehicles[i];
	}

	std::cout << "-------------------------\n";

	Train train("Thomas", "The Tank Engine", 1984, 60);
	train.drive();
	train.honk();
	std::cout << train.getMake() << " " << train.getModel() << " " << train.getYear() << " " << train.getNumberOfCars() << "\n";

	return 0;
}