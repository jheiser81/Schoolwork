#include "Car.h"
#include "Truck.h"
#include <iostream>
#include <string>

int main()
{
	Vehicle* vehicles[2];
	vehicles[0] = new Car("Ford", "Mustang", 1969);
	vehicles[1] = new Truck("Ford", "F-150", 2020);
	int size = sizeof(vehicles) / sizeof(vehicles[0]);
	for (size_t i = 0; i < size; i++)
	{
		std::cout << vehicles[i]->getMake() << " " << vehicles[i]->getModel() << " " << vehicles[i]->getYear() << "\n";

		vehicles[i]->drive();
		vehicles[i]->honk();

		std::cout << "\n";
	}
}