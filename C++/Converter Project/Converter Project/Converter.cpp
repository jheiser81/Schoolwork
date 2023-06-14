#include "Converter.h"
#include <iostream>

Converter::Converter(){}
Converter::~Converter(){}

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
	std::cout << "This is the base class Converter.\n";
}



