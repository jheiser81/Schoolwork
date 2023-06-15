#include "Speed_Calculator.h"
#include <iostream>

Speed_Calculator::Speed_Calculator() {}
Speed_Calculator::~Speed_Calculator() {}

double Speed_Calculator::calculate(double distance, double time) {
	return distance / time;
}

// helpter function to be able to access interpretResult, since it's protected in the base class
std::string Speed_Calculator::getSpeedInterpretation(double result) {
	return interpretResult(result);
}

std::string Speed_Calculator::interpretResult(double result) {
	if (result < 1) {
		return "You are walking.";
	}
	else if (result >= 1 && result < 10) {
		return "You are running.";
	}
	else if (result >= 10 && result < 50) {
		return "You are biking.";
	}
	else {
		return "You are driving.";
	}
}

void Speed_Calculator::description() const {
	std::cout << "This is a Speed Calculator. It calculates your speed based on distance traveled / time.\n";
}