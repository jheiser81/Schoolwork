#pragma once // this is a header guard, it prevents the header from being included more than once
#include <string> // include the string library

//Making a class (header file)
/*
1) Create a header file for the class (this file). In the header file, declare the class and its private and public members.
class Class {
private:
	//private members
	public:
	//public members
	};

2) Create the constructor and destructor (if using). The constructor is used to initialize the class members, the destructor is used to free up memory. Const is used to make sure that the function doesn't modify the object's data members. The & symbol is used to make sure that the function uses the address of the parameter, not the value.
   -Syntax: Class(parameter& member, parameter& member);

3) Specify the accessors and mutators (getters and setters) for the class members. Each data member needs a getter followed by a setter.

	The way to do this is as follows:
	- Create a getter function that returns the data member. This function should be const, so that it can't be modified outside the class
	- Create a setter function that takes a const reference to the data member as a parameter using the & operator. This function should be void, as it doesn't return anything
	*Note: The getter and setter functions should be declared in the header file, but defined in the .cpp file. It is useful to think of the header file as the function prototype, and the .cpp file as the function definition.

4) Create any other functions that you want to use with the class. These should be declared in the header file and defined in the .cpp file as well.
 */

class Car {
private: //these are the data members for the class, basically the attributes the object has
	std::string make;
	std::string model;
	int year;

public: //this is the public section of the class, where the functions are declared
	Car(const std::string& make, const std::string& model, int year);
	//Constructor. This will use the same parameters specified as private data members. The const keyword means that the function will not change the object's data members. The & symbol means that the function will use the address of the parameter, not the value.

	~Car(); //destructor. This is optional

	//Accessors and mutators (getters and setters)
	/*-Syntax for getters: return_type getFunctionName() const;

	  -Syntax for setters: void setFunctionName(const return_type& member);
	  const is used so that the function will not modify the object's data members
	  & is used so that the function will use the address of the parameter, not the value*/

	std::string getMake() const;
	void setMake(const std::string& make);

	std::string getModel() const;
	void setModel(const std::string& model);

	int getYear() const;
	void setYear(int year);

	//Other functions (what the object can do)

	void start() const;
	void stop() const;
	void accelerate() const;
};
