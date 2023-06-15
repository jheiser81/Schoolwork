#include <iostream>
#include <string>
#include "Converter.h"
#include "WeightConverter.h"
#include "HeightConverter.h"
#include "DistanceConverter.h"
#include "Calculator.h"
#include "BMI_Calculator.h"
#include "Speed_Calculator.h"

int main()
{
	std::string unitSystem;
	double weight, height, distance, time;

	// Ask user for preferred unit system
	std::cout << "Please choose measurement system (metric or imperial): ";
	std::cin >> unitSystem;

	// Ask for user's weight and height
	
	std::cout << "Please enter your weight: ";
	std::cin >> weight;
	/*std::cin.ignore();*/ //looked this up, but it's not working.
	std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n'); //had to look this up, it's working

	std::cout << "Please enter your height: ";
	std::cin >> height;
	std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

	// Convert user's weight and height to metric if needed
	if (unitSystem == "imperial") 
	{
		WeightConverter weightToConvert;
		weight = weightToConvert.toMetric(weight);

		HeightConverter heightToConvert;
		height = heightToConvert.toMetric(height);
	}

	// Calculate user's BMI and print result
	BMI_Calculator bmiCalculator;
	double bmi = bmiCalculator.calculate(weight, height); 
	std::string interpretation = bmiCalculator.getBMI_Interpretation(bmi);
	std::cout << "Your BMI is: " << bmi << ", which is considered " << interpretation << ".\n";

	// Ask user for distance and speed
	std::cout << "Please enter the distance traveled: ";
	std::cin >> distance;

	std::cout << "Please enter the time it took to travel that distance: ";
	std::cin >> time;
	std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

	// Convert distance to metric, if needed
	if (unitSystem == "imperial")
	{
		DistanceConverter distanceToConvert;
		distance = distanceToConvert.toMetric(distance); 
	}

	// Calculate user's speed and print result
	Speed_Calculator speedCalculator;
	double speed = speedCalculator.calculate(distance, time);

	// Interpret speed result
	std::string speedInterpretation = speedCalculator.getSpeedInterpretation(speed);

	if (unitSystem == "imperial")
	{
		DistanceConverter distanceToConvert;
		speed = distanceToConvert.toImperial(speed); // convert speed back to imperial if user chose imperial
	}

	// Print speed result and interpretation
	std::cout << "Your speed is: " << speed << " units per hour. " << speedInterpretation << "\n";

	//After each calculation, ask the user if they would like to perform another calculation.
	std::string anotherCalculation;
	std::cout << "Would you like to perform another calculation? (yes or no): ";
	std::cin >> anotherCalculation;

	if (anotherCalculation == "yes")
	{
		main();
	}
	else
	{
		std::cout << "Goodbye!\n";
	}

	//TO DO:
	// Add some error handling for user input, such as if user enters something other than metric or imperial, or if user enters a negative number for weight, height, distance, or time, or doesn't ente a number at all
}
