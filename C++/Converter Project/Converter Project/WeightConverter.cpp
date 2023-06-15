#include "WeightConverter.h"
#include <iostream>

WeightConverter::WeightConverter() {}
WeightConverter::~WeightConverter() {}

//1 pound = 0.45359237 kilograms, multiply by this to convert to metric
double WeightConverter::toMetric(double valueToConvert) {
	return valueToConvert * 0.45359237;
}

//1 kilogram = 2.20462262185 pounds, multiply by this to convert to imperial
double WeightConverter::toImperial(double valueToConvert) {
	return valueToConvert * 2.20462262185;
}

void WeightConverter::description() const {
	std::cout << "This is a converter for weight measurements from imperial to metric and vice versa.\n";
}