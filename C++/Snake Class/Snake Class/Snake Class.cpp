#include "Snake.h"
#include <iostream>

//--Making a class (main .cpp file)--
/*
1) Make sure to add a reference to the header file at the top of the file (#include "object.h") and also #include <iostream>

2) Create the constructor and destuctor (if using) for the class.
	-Syntax: Class::Class(parameters) : member1(value), member2(value) {}
	-You must use the exact same parameters as specified in the other constructors in the header and .cpp files, and in the same order.

3) Call the get functions to output the object's data members.
	-Syntax: output type << object.function() << "\n";

4) Call the object's member functions object.function();

*/

int main()
{
	Snake mySnake("Apollo", "Corn Snake", "orange with red spots", 10);

	std::cout << "Name: " << mySnake.getName() << "\n";
	std::cout << "Breed: " << mySnake.getBreed() << "\n";
	std::cout << "Color: " << mySnake.getColor() << "\n";
	std::cout << "Age: " << mySnake.getAge() << "\n";

	mySnake.slither();
	mySnake.hide();
	mySnake.swallowPrey();

	return 0;
}