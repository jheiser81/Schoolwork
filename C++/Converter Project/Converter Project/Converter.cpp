#include "Converter.h"
#include <iostream>

//default constructor and destructor.
Converter::Converter() {}
Converter::~Converter() {}

// member functions from Converter.h, will be overridden by derived classes
double Converter::toMetric(double valueToConvert)
{
	return valueToConvert;
}

double Converter::toImperial(double valueToConvert)
{
	return valueToConvert;
}

void Converter::description() const
{
	std::cout << "------------------------------------------------------------------------------------\n";
	std::cout << "This is a converter for measurements. It converts between imperial and metric units.\n";
}