#include "Calculator.h"
#include <iostream>

Calculator::Calculator() {}
Calculator::~Calculator() {}

void Calculator::printResult(double result) {
	std::cout << "The result is: " << result << "\n";
}

void Calculator::description() const {}

//Don't need to implement the other functions from Calculator.h because they are virtual or pure virtual, and are implemented in the child classes.