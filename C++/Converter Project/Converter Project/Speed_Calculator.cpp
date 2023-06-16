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
	if (result == 0) {
		return "You are not moving.";
	}
	else if (result >= 0 && result < 5)
	{
		return "You are walking.";
	}
	else if (result >= 1 && result < 16) {
		return "You are running.";
	}
	else if (result >= 10 && result < 48) {
		return "You are biking.";
	}
	else if (result > 48 && result < 100) {
		return "You are driving.";
	}
	else
	{
		return "You are going really fast! Either you're on a train, a plane, a rocket, or you're traveling through space and time.";
	}
}

void Speed_Calculator::description() const {
	std::cout << "\nThis is a Speed Calculator. It calculates your speed based on distance traveled and time taken.\n";
}