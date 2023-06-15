#include <iostream>
#include <string>
#include "Converter.h"
#include "WeightConverter.h"
#include "HeightConverter.h"
#include "DistanceConverter.h"
#include "Calculator.h"
#include "BMI_Calculator.h"
#include "Speed_Calculator.h"

#pragma region anotherCalculation function
bool anotherCalculation()
{
	while (true)
	{
		std::string response;
		std::cout << "Would you like to perform another calculation? (yes or no): ";
		std::cin >> response;

		if (response == "yes")
		{
			return true;
		}
		else if (response == "no")
		{
			return false;
		}
		else
		{
			std::cout << "Invalid input. Please enter yes or no: ";
		}
	}
}
#pragma endregion

#pragma region bmiCalculation function
void bmiCalculation(std::string unitSystem) {
	double weight, height;

	// Ask for user's weight
	std::cout << "Please enter your weight: ";
	std::cin >> weight;

	// Error handling for negative weight or invalid input (not a number)
	while (weight <= 0 || std::cin.fail()) //cin.fail() checks if operation failed or not
	{
		std::cout << "Invalid input. Please enter a positive number for weight: ";
		std::cin.clear(); //resets error flag, otherwise program will get stuck in an infinite loop
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n'); //had to look this up, it clears the newline character from the input buffer
		std::cin >> weight;
	}

	// Ask for user's height
	std::cout << "Please enter your height: ";
	std::cin >> height;

	// Error handling for negative height or invalid input (not a number)
	while (height <= 0 || std::cin.fail())
	{
		std::cout << "Invalid input. Please enter a positive number for height: ";
		std::cin.clear();
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		std::cin >> height;
	}

	// Convert user's weight and height to metric if needed.
	// This is because the BMI formula requires metric units.
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
	std::string interpretation = bmiCalculator.getBMI_Interpretation(bmi); //calling the helper function to access interpretResult
	std::cout << "Your BMI is: " << bmi << ", which is considered " << interpretation << ".\n";
}
#pragma endregion

#pragma region speedCalculation function
void speedCalculation(std::string unitSystem) {
	double distance, time;

	// Ask user for distance and speed
	std::cout << "Please enter the distance traveled: ";
	std::cin >> distance;

	// Error handling for negative distance or invalid input (not a number)
	while (distance <= 0 || std::cin.fail())
	{
		std::cout << "Invalid input. Please enter a positive number for distance: ";
		std::cin.clear();
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		std::cin >> distance;
	}

	// Ask user for time
	std::cout << "Please enter the time it took to travel that distance: ";
	std::cin >> time;

	// Error handling for negative time or invalid input (not a number)
	while (time <= 0 || std::cin.fail())
	{
		std::cout << "Invalid input. Please enter a positive number for time: ";
		std::cin.clear();
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		std::cin >> time;
	}

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
	std::string speedInterpretation = speedCalculator.getSpeedInterpretation(speed); //calling the helper function to access interpretResult

	if (unitSystem == "imperial")
	{
		DistanceConverter distanceToConvert;
		speed = distanceToConvert.toImperial(speed); // convert speed back to imperial if user chose imperial
	}

	// Print speed result and interpretation
	if (unitSystem == "imperial")
	{
		std::cout << "Your speed is: " << speed << " miles per hour. " << speedInterpretation << "\n";
	}
	else
	{
		std::cout << "Your speed is: " << speed << " kilometers per hour. " << speedInterpretation << "\n";
	}
}
#pragma endregion

int main()

{
	std::string unitSystem;
	std::string calculationType;

	do
	{
		// Ask user for preferred unit system
		std::cout << "Please choose preferred unit system: metric(kilograms and meters) or imperial(pounds and feet): ";
		std::cin >> unitSystem;

		//error handling if user input doesn't match metric or imperial
		if (unitSystem != "metric" && unitSystem != "imperial")
		{
			std::cout << "Invalid input.\n";
			std::cout << "Please enter metric or imperial: ";
			std::cin >> unitSystem;
		}

		// Ask user what type of calculation they want to perform
		std::cout << "Please choose a calculation to perform (BMI or speed): ";
		std::cin >> calculationType;

		while (calculationType != "BMI" && calculationType != "speed")
		{
			std::cout << "Invalid input.\n";
			std::cout << "Please enter BMI or speed: ";
			std::cin >> calculationType;
		}

		if (calculationType == "BMI")
		{
			// Perform BMI calculation
			BMI_Calculator bmiCalculator;
			bmiCalculator.description(); //calling the description function
			bmiCalculation(unitSystem);
		}
		else if (calculationType == "speed")
		{
			// Perform speed calculation
			Speed_Calculator speedCalculator;
			speedCalculator.description(); //calling the description function
			speedCalculation(unitSystem);
		}

		// Ask user if they want to perform another calculation
		if (!anotherCalculation())
		{
			break;
		}
	} while (true);

	return 0;
}

//old code
/*
		// Ask for user's weight
		std::cout << "Please enter your weight: ";
		std::cin >> weight;

		// Error handling for negative weight or invalid input (not a number)
		while (weight <= 0 || std::cin.fail()) //cin.fail() checks if operation failed or not
		{
			std::cout << "Invalid input. Please enter a positive number for weight: ";
			std::cin.clear(); //resets error flag, otherwise program will get stuck in an infinite loop
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n'); //had to look this up, it clears the newline character from the input buffer
			std::cin >> weight;
		}

		// Ask for user's height
		std::cout << "Please enter your height: ";
		std::cin >> height;

		// Error handling for negative height or invalid input (not a number)
		while (height <= 0 || std::cin.fail())
		{
			std::cout << "Invalid input. Please enter a positive number for height: ";
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			std::cin >> height;
		}

		// Convert user's weight and height to metric if needed.
		// This is because the BMI formula requires metric units.
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
		std::string interpretation = bmiCalculator.getBMI_Interpretation(bmi); //calling the helper function to access interpretResult
		std::cout << "Your BMI is: " << bmi << ", which is considered " << interpretation << ".\n";

		// Ask user if they want to perform another calculation
		if (!anotherCalculation())
		{
			return 0;
		}
		else
		{
			std::cout << "Please choose measurement system (metric or imperial): ";
			std::cin >> unitSystem;
		}*/

		/*
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
		std::string speedInterpretation = speedCalculator.getSpeedInterpretation(speed); //calling the helper function to access interpretResult

		if (unitSystem == "imperial")
		{
			DistanceConverter distanceToConvert;
			speed = distanceToConvert.toImperial(speed); // convert speed back to imperial if user chose imperial
		}

		// Print speed result and interpretation
		std::cout << "Your speed is: " << speed << " units per hour. " << speedInterpretation << "\n";*/