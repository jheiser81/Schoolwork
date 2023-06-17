#include "WeightConverter.h"
#include <iostream>

WeightConverter::WeightConverter() {}
WeightConverter::~WeightConverter() {}

//1 pound = 0.45359237 kilograms, multiply the valueToConvert by this to convert to metric
double WeightConverter::toMetric(double valueToConvert) {
	return valueToConvert * 0.45359237;
}

//1 kilogram = 2.20462262185 pounds, multiply the valueToConvert by this to convert to imperial
double WeightConverter::toImperial(double valueToConvert) {
	return valueToConvert * 2.20462262185;
}

void WeightConverter::description() const {
	std::cout << "The program converts between imperial and metric units of weight.\n";
}