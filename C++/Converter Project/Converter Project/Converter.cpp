#include "Converter.h"
#include <iostream>

Converter::Converter() {}
Converter::~Converter() {} //default constructor and destructor

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
	std::cout << "This is a converter for measurements. It converts between imperial and metric units.\n";
}