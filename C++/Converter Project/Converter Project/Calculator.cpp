#include "Calculator.h"
#include <iostream>

Calculator::Calculator() {}
Calculator::~Calculator() {}

void Calculator::printResult(double result) {
	std::cout << "The result is: " << result << "\n";
}

//Don't need to implement the other functions from Calculator.h because they are pure virtual, so will be implemented in the derived classes