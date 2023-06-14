#pragma once
#include <string>
#include "Calculator.h"

//Part 5: Derived Class SpeedCalculator
/*Next, design a derived class named SpeedCalculator that inherits from the Calculator base class.
Implement the following functions :
1. double calculate(double distance, double time) override : This function should calculate speed by
dividing the given distance by time.
2. protected std::string interpretResult(double result) override : This function should provide an interpretation of the speed result. It could contextualize the result with typical speeds for walking, running, biking, or driving, for example.
3. void description() const override : This function should print a description of the SpeedCalculator
class's specific functionality.*/

class Speed_Calculator : public Calculator {
public:
	Speed_Calculator();
	~Speed_Calculator();

	double calculate(double distance, double time) override;
	void description() const override;

protected:
	std::string interpretResult(double result) override;
};
