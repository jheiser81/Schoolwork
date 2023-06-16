#include "DistanceConverter.h"
#include <iostream>

DistanceConverter::DistanceConverter() {}
DistanceConverter::~DistanceConverter() {}

//1 mile = 1.60934 km, multiply by this to convert to km
double DistanceConverter::toMetric(double valueToConvert) {
	return valueToConvert * 1.60934;
}

//1 km = 0.621371 miles, multiply by this to convert to miles
double DistanceConverter::toImperial(double valueToConvert) {
	return valueToConvert * 0.621371;
}

void DistanceConverter::description() const {
	std::cout << "The program will also provide an interpretation of your speed based on typical speeds for walking, running, biking, or driving.\n";
}