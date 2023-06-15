#pragma once
#include <string>
#include <iostream>

//Part 3: Base Class Calculator
/*Next, design a base class called Calculator that contains the following member functions :
1. virtual double calculate(double val1, double val2) = 0 : This function should take two numerical
inputs and compute a calculation based on them.The exact nature of this calculation will
depend on the derived classes.

2. void printResult(double result) : This function should take the computed result and print it in a
user - friendly manner.
3. virtual void description() const : This function should print a description detailing the specific
functionality of each calculator class.
4. protected virtual std::string interpretResult(double result) = 0 : This function should take a result
value and return an interpretation.The interpretation should be in a form that is easy for users
to understand and relevant to the computation that has been performed.*/

class Calculator
{
public:
	//default constructor, no parameters. Destructor is virtual so that child classes can use it
	Calculator();
	virtual ~Calculator();

	virtual double calculate(double valToCalc1, double valToCalc2) = 0;
	void printResult(double result);

	virtual void description() const
	{
		std::cout << "This is a calculator. It performs basic arithmetic operations.\n";
	}

protected:
	virtual std::string interpretResult(double result) = 0;
};
