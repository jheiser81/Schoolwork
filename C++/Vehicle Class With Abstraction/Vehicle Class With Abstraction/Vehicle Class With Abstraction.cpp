#include <iostream>
#include "Car.h"
#include "Vehicle.h"

int main()
{
	Car car("Ford", "Mustang", 1969);
	car.drive();
	car.honk();

	std::cout << car.getMake() << " " << car.getModel() << " " << car.getYear() << "\n";

	return 0;
}