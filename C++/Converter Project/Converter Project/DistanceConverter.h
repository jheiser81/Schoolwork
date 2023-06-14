#pragma once
#include <string>
#include "Converter.h"

class DistanceConverter : public Converter {
public:
	DistanceConverter();
	~DistanceConverter();

	double toMetric(double valueToConvert) override;
	double toImperial(double valueToConvert) override;
	void description() const override;
};
