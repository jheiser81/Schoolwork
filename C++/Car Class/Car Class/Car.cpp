#include "Car.h" // include the header file for the Car class
#include <iostream>

//--Making a class (object.cpp file)--
/*
1) Make sure to add a reference to the header file at the top of the file (#include "object.h") and also #include <iostream>

2)Create the constructor and destuctor (if using) for the class.
	-//Syntax: Class::Class(parameters) : member1(value), member2(value) {}

3)Create the getters and setters for the class.
	-Syntax for the getters : return_type Class::getFunctionName() const { return member; }
	-Syntax for the setters : void Class::setFunctionName(const return_type& member) { this->member = member; }
	-The const keyword means that the function will not change the object's data members.
	-The & symbol means that the function will use the address of the parameter, not the value.
	-The 'this' keyword and arrow operator (->) are used to access the object's data members

4)Create any other functions that you want to use with the class. These should be already declared in the header file and defined in the .cpp file.
 */

 //--Make the constructor--

Car::Car(const std::string& make, const std::string& model, int year) : make(make), model(model), year(year) {}
Car::~Car() {}

//--Getters and setters--

std::string Car::getMake() const { return make; }
void Car::setMake(const std::string& make) { this->make = make; }

std::string Car::getModel() const { return model; }
void Car::setModel(const std::string& model) { this->model = model; }

int Car::getYear() const { return year; }
void Car::setYear(int year) { this->year = year; }

//--Other functions (this defines the functions)--

void Car::start() const { std::cout << "The car has started. \n"; }
void Car::stop() const { std::cout << "The car has stopped. \n"; }
void Car::accelerate() const { std::cout << "The car is accelerating. \n"; }