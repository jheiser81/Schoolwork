#include "Snake.h"
#include <iostream>

//--Making a class (.cpp file)--
/*
1) Make sure to add a reference to the header file at the top of the file (#include "object.h") and also #include <iostream>

2)Create the constructor and destuctor (if using) for the class.
	-//Syntax: ClassName::ClassName(parameter& member) : member1(value), member2(value), member3(value) {}

3)Create the getters and setters for the class.
	-Syntax for the getters : return_type Class::getFunctionName() const { return member; }
	-Syntax for the setters : void Class::setFunctionName(const return_type& member) { this->member = member; }
	-The const keyword means that the function will not change the object's data members.
	-The & symbol means that the function will use the address of the parameter, not the value.
	-The 'this' keyword and arrow operator (->) are used to access the object's data members

4)Create any other functions that you want to use with the class. These should be already declared in the header file and defined in the .cpp file.
-Syntax: returnType ClassName::functionName() const { function body and output; }
 */

 //Constructor
Snake::Snake(const std::string& name, const std::string& breed, const std::string& color, int age) : name(name), breed(breed), color(color), age(age) {}

//Getters & Setters
std::string Snake::getName() const { return name; }
void Snake::setName(const std::string& name) { this->name = name; }

std::string Snake::getBreed() const { return breed; }
void Snake::setBreed(const std::string& breed) { this->breed = breed; }

std::string Snake::getColor() const { return color; }
void Snake::setColor(const std::string& color) { this->color = color; }

int Snake::getAge() const { return age; }
void Snake::setAge(int age) { this->age = age; }

//Other functions
void Snake::slither() const { std::cout << "The snake slithers silently. \n"; }
void Snake::hide() const { std::cout << "The snake is feeling shy and hides from you. \n"; }
void Snake::swallowPrey() const { std::cout << "The snake is hungry and swallows it's prey whole. Gulp! \n"; }