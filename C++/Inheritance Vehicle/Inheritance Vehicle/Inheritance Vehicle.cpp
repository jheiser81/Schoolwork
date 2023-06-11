#include <iostream>
#include "Car.h"
#include "Truck.h"

int main() {
	Car myCar("Red", 2020, "Toyota", "Camry");
	Truck myTruck("Blue", 2022, "Ford", "F-150");

	std::cout << "--------Car:--------\n" << myCar.getInfo() << "\n"; //Outputs: Make: Toyota, Model: Camry, Color: Red, Year: 2020
	myCar.soundHorn();		//Outputs: Car horn
	myCar.start();		    //Outputs: Car started
	myCar.accelerate();		//Outputs: Car is accelerating
	myCar.decelerate();		//Outputs: Car is decelerating
	myCar.stop();			//Outputs: Car stopped

	std::cout << "\n\n" << "--------Truck--------\n" << myTruck.getInfo() << "\n"; //Outputs Make: Ford, Model: F-150, Color: Blue, Year: 2022

	myTruck.soundHorn();	//Outputs: Car horn
	myTruck.start();		//Outputs: Car started
	myTruck.accelerate();	//Outputs: Car is accelerating
	myTruck.decelerate();	//Outputs: Car is decelerating
	myTruck.stop();			//Outputs: Car stopped
}