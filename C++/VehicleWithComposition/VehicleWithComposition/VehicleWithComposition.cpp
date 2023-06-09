#include <iostream>
#include "Car.h"
#include "Truck.h"

int main()
{
	Car myCar("Red", 2020, "Toyota", "Camry");
	Truck myTruck("Blue", 2022, "Ford", "F-150");

	std::cout << "--------Car:--------\n" << myCar.getInfo() << "\n";
	myCar.soundHorn();
	myCar.start();
	myCar.accelerate();
	myCar.decelerate();
	myCar.stop();
	std::cout << "\n\n" << "--------Truck:--------\n" << myTruck.getInfo() << "\n";
	myTruck.soundHorn();
	myTruck.start();
	myTruck.accelerate();
	myTruck.decelerate();
	myTruck.stop();

	return 0;
}