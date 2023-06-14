#pragma once
#include <string>

//Objective:
/*The goal of this assignment is to create a C++ program that applies the principles of object - oriented
programming such as inheritance, polymorphism, and dynamic binding.This program will be used for
unit conversions and precise calculations involving body metrics and speed.

Part 1 : Base Class Converter
Your first task is to build a base class named Converter.This class will include the following virtual
member functions:

1. virtual double toMetric(double value) : This function takes a value in the imperial unit and
converts it into its metric counterpart.

2. virtual double toImperial(double value) : This function does the opposite.It takes a value in the
metric system and converts it to its imperial equivalent.

3. virtual void description() const : This function prints a concise description of the converter class,
which will specify the kind of conversions it performs.

Part 2: Derived Classes WeightConverter, DistanceConverter, and HeightConverter
Next, create three classes, WeightConverter, DistanceConverter, and HeightConverter, that inherit from
the Converter base class. These classes will be responsible for weight, distance, and height conversions
respectively:

1. double toMetric(double value) override: This function should take the provided value in imperial
units and convert it to its metric equivalent.

2. double toImperial(double value) override: Similarly, this function should take the provided value
in metric units and convert it to its imperial equivalent.

3. void description() const override: This function should print a description detailing the specific
functionality of each converter class.
*/

class Converter
{
public:
	Converter(); //default constructor, doesn't have any parameters
	virtual ~Converter();

	//virtual functions, to be overridden by derived classes
	virtual double toMetric(double valueToConvert) = 0;
	virtual double toImperial(double valueToConvert) = 0;
	virtual void description() const = 0;
};