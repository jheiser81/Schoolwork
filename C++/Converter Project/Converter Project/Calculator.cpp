#include "Calculator.h"
#include <iostream>

Calculator::Calculator() {}
Calculator::~Calculator() {}

void Calculator::printResult(double result) {
	std::cout << "The result is: " << result << "\n";
}