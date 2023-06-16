#include "HeightConverter.h"
#include <iostream>

HeightConverter::HeightConverter() {}
HeightConverter::~HeightConverter() {}

// 1 foot = 0.3048 meters, multiply the value ToConvert by this to convert feet to meters
double HeightConverter::toMetric(double valueToConvert) {
	return valueToConvert * 0.3048;
}

// 1 meter = 3.28084 feet, multiply the valueToConvert by this to convert meters to feet
double HeightConverter::toImperial(double valueToConvert) {
	return valueToConvert * 3.28084;
}

void HeightConverter::description() const {
	std::cout << "The program converts between imperial and metric units of height.\n";
}