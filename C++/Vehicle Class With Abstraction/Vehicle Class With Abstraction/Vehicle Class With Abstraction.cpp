#include <iostream>
#include "Car.h"
#include "Truck.h"
#include "Vehicle.h"

int main()
{
	Car car("Mazda", "Miata", 1990);
	
	car.drive();
	car.honk();

	//std::cout << car.getMake() << " " << car.getModel() << " " << car.getYear() << "\n\n";
	std::cout << "Make: " << car.getMake() << "\n" << "Model: " << car.getModel() << "\n" << "Year: " << car.getYear() << "\n\n";

	Truck truck("Chevy", "Silverago", 2023, 4, true);
	truck.drive();
	truck.honk();

	//std::cout << truck.getMake() << " " << truck.getModel() << " " << truck.getYear() << " " << truck.getNumDoors() << "\n";

	std::cout << std::boolalpha << "Make: " << truck.getMake() << "\n" << "Model: " << truck.getModel() << "\n" << "Year: " << truck.getYear() << "\n" << "Doors: " << truck.getNumDoors() << "\n" << "Has 4WD: " << truck.getHas4WD() << "\n\n";

	return 0;
}