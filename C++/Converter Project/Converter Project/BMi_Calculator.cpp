#include "BMI_Calculator.h"
#include <iostream>
#include <cmath> //need this for pow function

BMI_Calculator::BMI_Calculator() {}
BMI_Calculator::~BMI_Calculator() {}

double BMI_Calculator::calculate(double weight, double height) {
	return weight / pow(height, 2); //formula for calculating BMI: weight / height^2. Used pow function from cmath library
}

//BMI Categories: Underweight = <18.5, Normal weight = 18.5–24.9, Overweight = 25–29.9, Obesity = BMI of 30 or greater, according to the WHO.
std::string BMI_Calculator::interpretResult(double result) {
	if (result < 18.5) {
		return "Underweight";
	}
	else if (result >= 18.5 && result <= 24.9) {
		return "Normal";
	}
	else if (result >= 25 && result <= 29.9) {
		return "Overweight";
	}
	else {
		return "Obese";
	}
}

void BMI_Calculator::description() const {
	std::cout << "This is a BMI Calculator. It calculates your BMI based on your weight and height according to medical health guidelines.\n";
}