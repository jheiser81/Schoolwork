#include "Car.h"
#include <iostream>

//--Making a class (main .cpp file)--
/*
1) Make sure to add a reference to the header file at the top of the file (#include "object.h") and also #include <iostream>

2) Create the constructor and destuctor (if using) for the class.
	-Syntax: Class::Class(parameters) : member1(value), member2(value) {}
	-You must use the exact same parameters as specified in the other constructors in the header and .cpp files, and in the same order.

3) Call the get functions to output the object's data members.
	-Syntax: output type << object.function() << "\n";

4) Call the object's member functions (object.function();)

*/

int main()
{
	//Create a Car object
	Car car("Honda", "Civic", 2024); //This must follow the exact same paramaters as the constructors, and in the same order (string, string, int)

	//Output the car's details by calling the get functions.
	//Syntax: output type << object.function() << "\n";

	std::cout << "Make: " << car.getMake() << "\n";
	std::cout << "Model: " << car.getModel() << "\n";
	std::cout << "Year: " << car.getYear() << "\n";

	//Call the car's member functions (what it does)
	//object.function();
	car.start();
	car.stop();
	car.accelerate();

	return 0;
}