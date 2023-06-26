#include "Converter.h"
#include "WeightConverter.h"
#include "HeightConverter.h"
#include "DistanceConverter.h"
#include "Calculator.h"
#include "BMI_Calculator.h"
#include "Speed_Calculator.h"
#include <iostream>
#include <string>

// This function asks the user if they want to perform another calculation, taking a yes or no input from the user. If yes, the program will loop back to the beginning. If no, the program will end. If the user enters an invalid input, the program will ask the user to enter yes or no again.
#pragma region anotherCalculation function

bool anotherCalculation()
{
	while (true)
	{
		std::string response;
		std::cout << "\nWould you like to perform another calculation? (yes or no): ";
		std::cin >> response;

		if (response == "yes")
		{
			return true;
		}
		else if (response == "no")
		{
			std::cout << "\nThank you for using the converter program. Goodbye!\n";
			return false;
		}
		else
		{
			std::cout << "\nInvalid input. Please enter yes or no: ";
		}
	}
}
#pragma endregion

// Contains all of the calculation/conversion code for weight, height, and BMI. Called in main() if user chooses BMI calculation.
#pragma region bmiCalculation function

void bmiCalculation(std::string unitSystem) {
	double weight, height;

	// Ask for user's weight
	std::cout << "\nPlease enter your weight: ";
	std::cin >> weight;

	// Error handling for negative weight or invalid input (not a number)
	while (weight <= 0 || std::cin.fail())									//cin.fail() checks if operation failed or not, the way it's used here checks if the input is a number or not
	{
		std::cout << "\nInvalid input. Please enter a positive number for weight: ";
		std::cin.clear();													//resets error flag, otherwise program will get stuck in an infinite loop
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n'); //had to look this up, it clears the newline character from the input buffer. Otherwise, it will skip the next input
		std::cin >> weight;
	}

	// Ask for user's height
	std::cout << "\nPlease enter your height: ";
	std::cin >> height;

	// Error handling for negative height or invalid input (not a number)
	while (height <= 0 || std::cin.fail())
	{
		std::cout << "\nInvalid input. Please enter a positive number for height: ";
		std::cin.clear();
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		std::cin >> height;
	}

	// Convert user's weight and height to metric if needed. This is because the standard BMI formula requires metric units.
	if (unitSystem == "imperial")
	{
		WeightConverter weightToConvert;
		weight = weightToConvert.toMetric(weight); // uses a pointer to the WeightConverter class to call the toMetric function

		HeightConverter heightToConvert;
		height = heightToConvert.toMetric(height); // uses a pointer to the HeightConverter class to call the toMetric function
	}

	// Calculate user's BMI and print result
	BMI_Calculator bmiCalculator; //creating an object of BMI_Calculator class
	double bmi = bmiCalculator.calculate(weight, height); //calling the calculate function from BMI_Calculator class
	std::string interpretation = bmiCalculator.getBMI_Interpretation(bmi); //calling the helper function to access interpretResult
	std::cout << "\nYour BMI is: " << bmi << ", which is considered " << interpretation << ".\n";
}
#pragma endregion

// Contains all of the calculation/conversion code for distance, time, and speed, in metric or imperial units. Called in main() if user chooses speed calculation.
#pragma region speedCalculation function

void speedCalculation(std::string unitSystem) {
	double distance, time;

	// Ask user for distance and speed
	std::cout << "\nPlease enter the distance traveled: ";
	std::cin >> distance;

	// Error handling for negative distance or invalid input (not a number)
	while (distance <= 0 || std::cin.fail())
	{
		std::cout << "\nInvalid input. Please enter a positive number for distance: ";
		std::cin.clear();
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		std::cin >> distance;
	}

	// Ask user for time
	std::cout << "\nPlease enter the time it took to travel that distance: ";
	std::cin >> time;

	// Error handling for negative time or invalid input (not a number)
	while (time <= 0 || std::cin.fail())
	{
		std::cout << "\nInvalid input. Please enter a positive number for time: ";
		std::cin.clear();
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		std::cin >> time;
	}

	// Convert distance to metric, if needed
	if (unitSystem == "imperial")
	{
		DistanceConverter distanceToConvert; //creating an object of DistanceConverter class
		distance = distanceToConvert.toMetric(distance); // uses a pointer to access the toMetric function in DistanceConverter if user chose imperial
	}

	// Calculate user's speed and print result
	Speed_Calculator speedCalculator; //creating an object of Speed_Calculator class
	double speed = speedCalculator.calculate(distance, time); //calling the calculate function from Speed_Calculator class

	// Interpret speed result
	std::string speedInterpretation = speedCalculator.getSpeedInterpretation(speed); //calling the helper function to access interpretResult

	if (unitSystem == "imperial")
	{
		DistanceConverter distanceToConvert;
		speed = distanceToConvert.toImperial(speed); // uses a pointer to access the toImperial function in DistanceConverter to convert speed back to imperial
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

	do //do while loop to keep the program running until user chooses to exit. It will run at least once
	{
		// Ask user for preferred unit system
		Converter converter;
		converter.description(); //calling the description function from Converter class
		std::cout << "\nPlease choose preferred unit system: metric (kilograms and meters) or imperial (pounds and feet): ";
		std::cin >> unitSystem;

		//error handling if user input doesn't match metric or imperial
		if (unitSystem != "metric" && unitSystem != "imperial")
		{
			std::cout << "\nInvalid input.\n";
			std::cout << "\nPlease enter metric or imperial: ";
			std::cin >> unitSystem;
		}

		// Ask user what type of calculation they want to perform
		std::cout << "\nPlease choose a calculation to perform (BMI or speed): ";
		std::cin >> calculationType;

		while (calculationType != "BMI" && calculationType != "speed")
		{
			std::cout << "Invalid input.\n";
			std::cout << "Please enter BMI or speed: ";
			std::cin >> calculationType;
		}

		// Perform BMI calculation
		if (calculationType == "BMI")
		{
			//These are the objects of the classes that will be used to call the functions
			//Since the BMI_Calculator and Speed_Calculator classes are derived from the Converter class, we can use the Converter class to call the description function.
			//Similarly, since the WeightConerter, HeightConverter, and DistanceConverter classes are derived from the Converter class, we can use the base Converter class to call the description function. This uses polymorphism and dynamic binding.

			Calculator* calculator = new BMI_Calculator(); //creating a pointer to BMI_Calculator
			calculator->description(); //calling the description function from BMI_Calculator class

			Converter* weightConverter = new WeightConverter();
			weightConverter->description();

			Converter* heightConverter = new HeightConverter();
			heightConverter->description();

			bmiCalculation(unitSystem); //calling the bmiCalculation function

			//Old Code: This would have been static binding
			/*
			//BMI_Calculator bmiCalculator;
			//bmiCalculator.description(); //calling the description function from BMI_Calculator class

			//WeightConverter weightConverter;
			//weightConverter.description(); //calling the description function for WeightConverter

			//HeightConverter heightConverter;
			//heightConverter.description(); //calling the description function for HeightConverter

			//bmiCalculation(unitSystem); //calling the bmiCalculation function*/
		}
		// Perform speed calculation
		else if (calculationType == "speed")
		{
			Calculator* calculator = new Speed_Calculator();
			calculator->description();

			Converter* distanceConverter = new DistanceConverter();
			distanceConverter->description();

			speedCalculation(unitSystem); //calling the speedCalculation function
		}

		if (!anotherCalculation())
		{
			break; //breaks out of the loop if user chooses not to perform another calculation
		}
	} while (true); //loop will run at least once, and will continue to run until user chooses to exit

	return 0;
}