#pragma once
#include <string>
#include "Calculator.h"

//Part 4: Derived Class BMICalculator
/*Now, develop a derived class BMICalculator that inherits from the Calculator base class.This class should
contain the following functions :

1. double calculate(double weight, double height) override : This function should calculate the
Body Mass Index(BMI) based on the provided weight and height.

2. protected std::string interpretResult(double result) override : This function should provide a
health - related interpretation of the BMI result.It could be categorizing the result into
underweight, normal weight, overweight, and obese based on standard BMI categories.

3. void description() const override : This function should print a description of the BMICalculator
class's specific functionality.*/

class BMI_Calculator : public Calculator {
public:
	BMI_Calculator();
	~BMI_Calculator();

	double calculate(double weight, double height) override;
	void description() const override;

	std::string getBMI_Interpretation(double result); //this is a helper function to be used in interpretResult

protected:
	std::string interpretResult(double result) override;
};
