#pragma once
#include <string>

//MAKING A CLASS (header file)
/*
* 1) Create a header file for the class (this file). In the header file, declare the class and its private and public members.
class Class {
private:
	//private members
	public:
	//public members
	};

2) Create the constructor and destructor (if using). The constructor is used to initialize the class members, the destructor is used to free up memory.
   -Syntax: Class(parameter& member, parameter& member);

3) Specify the accessors and mutators (getters and setters) for the class members. Each data member needs a getter followed by a setter.

	The way to do this is as follows:
	- Create a getter function that returns the data member. This function should be const, so that it can't be modified outside the class
	- Create a setter function that takes a const reference to the data member as a parameter using the & operator. This function should be void, as it doesn't return anything
	*Note: The getter and setter functions should be declared in the header file, but defined in the .cpp file. It is useful to think of the header file as the function prototype, and the .cpp file as the function definition.

4) Create any other functions that you want to use with the class. These should be declared in the header file and defined in the .cpp file as well. Set these as const.
 */

class Snake
{
private:
	std::string name;
	std::string breed;
	std::string color;
	int age;

public:
	//Constructor
	Snake(const std::string& name, const std::string& breed, const std::string& color, int age);

	//Getters & Setters
	std::string getName() const;
	void setName(const std::string& name);

	std::string getBreed() const;
	void setBreed(const std::string& breed);

	std::string getColor() const;
	void setColor(const std::string& color);

	int getAge() const;
	void setAge(int age);

	//Other functions
	void slither() const;
	void hide() const;
	void swallowPrey() const;
};