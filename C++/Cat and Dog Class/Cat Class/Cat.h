#pragma once
#include <string> //this is the string library

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
	-Syntax for getters: data_type getFunctionName() const;

	- Create a setter function that takes a const reference to the data member as a parameter using the & operator. This function should be void, as it doesn't return anything
	-Syntax for setters: void setFunctionName(const return_type& member);

	-const is used so that the function will not modify the object's data members
	-& is used so that the function will use the address of the parameter, not the value

	*Note: The getter and setter functions should be declared in the header file, but defined in the .cpp file. It is useful to think of the header file as the function prototype, and the .cpp file as the function definition.

4) Create any other functions that you want to use with the class. These should be declared in the header file and defined in the .cpp file as well.
 */

class Cat
{
private: //We use private members to protect the data from being modified outside the class
	std::string name;
	std::string breed;
	std::string color;
	int age;

public: //public members are accessible outside the class

	Cat(const std::string& name, const std::string& breed, const std::string& color, int age);
	//this is the constructor, which has all the parameters for the class.
	//These should be specified as **const references**, so that they can't be modified outside the class. The & operator will be used to pass the parameters by reference instead of by value.

	/*~Cat();*/ //this is the destructor. It is not generally necessary, unless you are doing specific memory management tasks, such as deleting pointers

	//Accessors and Mutators (Getters and Setters)

	std::string getName() const; //getter
	void setName(const std::string& name); //setter

	std::string getBreed() const;
	void setBreed(const std::string& breed);

	std::string getColor() const;
	void setColor(const std::string& color);

	int getAge() const;
	void setAge(int age); //this takes an int as a parameter not a const reference, which is why you don't need to use the & operator

	//Other functions
	void meow() const;
	void purr() const;
	void hiss() const;
};