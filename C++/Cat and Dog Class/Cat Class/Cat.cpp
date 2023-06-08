#include "Cat.h"
#include <iostream>

//--Making a class (.cpp file)--
/*
1) Make sure to add a reference to the header file at the top of the file (#include "object.h") and also #include <iostream>

2)Create the constructor and destuctor (if using) for the class.
	-//Syntax: ClassName::ClassName(parameter& member) : member1(value), member2(value), member3(value) {}

3)Create the getters and setters for the class.
	-Syntax for the getters : return_type ClassName::getFunctionName() const { return member; }
	-Syntax for the setters : void ClassName::setFunctionName(const data_type& member) { this->member = member; }
	-The const keyword means that the function will not change the object's data members.
	-The & symbol means that the function will use the address of the parameter, not the value.
	-The 'this' keyword and arrow operator (->) are used to access the object's data members

4)Create any other functions that you want to use with the class. These should be already declared in the header file and defined in the .cpp file.
-Syntax: returnType ClassName::functionName() const { function body and output; }
 */

 //Constructor and Destructor

Cat::Cat(const std::string& name, const std::string& breed, const std::string& color, int age) : name(name), breed(breed), color(color), age(age) {}

//Cat::~Cat() {}

//Getters and Setters

std::string Cat::getName() const { return name; }
void Cat::setName(const std::string& name) { this->name; }

std::string Cat::getBreed() const { return breed; }
void Cat::setBreed(const std::string& breed) { this->breed; }

std::string Cat::getColor() const { return color; }
void Cat::setColor(const std::string& color) { this->color; }

int Cat::getAge() const { return age; }
void Cat::setAge(int age) { this->age = age; }

//Other functions

void Cat::meow() const { std::cout << "The cat meows plaintively. \n"; }
void Cat::purr() const { std::cout << "The cat purrs contentedly. \n"; }
void Cat::hiss() const { std::cout << "The cat hisses angrily. \n"; }