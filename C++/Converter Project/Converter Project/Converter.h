#pragma once
#include <string>

//Objective:
/*The goal of this assignment is to create a C++ program that applies the principles of object - oriented
programming such as inheritance, polymorphism, and dynamic binding.This program will be used for
unit conversions and precise calculations involving body metrics and speed.*/

//Part 1 : Base Class Converter
/*Your first task is to build a base class named Converter.This class will include the following virtual
member functions:

1. virtual double toMetric(double value) : This function takes a value in the imperial unit and
converts it into its metric counterpart.

2. virtual double toImperial(double value) : This function does the opposite.It takes a value in the
metric system and converts it to its imperial equivalent.

3. virtual void description() const : This function prints a concise description of the converter class,
which will specify the kind of conversions it performs.
*/

class Converter
{
public:
	//default constructor, doesn't have any parameters because we don't need to initialize anything
	Converter();
	virtual ~Converter();

	//virtual functions, will be overridden by derived classes
	virtual double toMetric(double valueToConvert);
	virtual double toImperial(double valueToConvert);
	virtual void description() const;
};