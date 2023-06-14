#pragma once
#include <string>
#include "Converter.h"

//Part 2: Derived Classes WeightConverter, DistanceConverter, and HeightConverter
/*Next, create three classes, WeightConverter, DistanceConverter, and HeightConverter, that inherit from
the Converter base class.These classes will be responsible for weight, distance, and height conversions
respectively :

1. double toMetric(double value) override : This function should take the provided value in imperial
units and convert it to its metric equivalent.

2. double toImperial(double value) override : Similarly, this function should take the provided value
in metric units and convert it to its imperial equivalent.

3. void description() const override : This function should print a description detailing the specific
functionality of each converter class.*/

class WeightConverter : public Converter {
public:
	WeightConverter();
	~WeightConverter();

	double toMetric(double valueToConvert) override;
	double toImperial(double valueToConvert) override;
	void description() const override;
};
