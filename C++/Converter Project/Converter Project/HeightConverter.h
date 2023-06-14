#pragma once
#include <string>
#include "Converter.h"

class HeightConverter : public Converter {
public:
	HeightConverter();
	~HeightConverter();

	double toMetric(double valueToConvert) override;
	double toImperial(double valueToConvert) override;
	void description() const override;
};
