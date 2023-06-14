#pragma once
#include <string>
#include "Converter.h"

class WeightConverter : public Converter {
public:
	WeightConverter();
	~WeightConverter();

	double toMetric(double valueToConvert) override;
	double toImperial(double valueToConvert) override;
	void description() const override;
};
