// Structs Practice.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

//Assignment: 3D Space Distance Calculator
/*
**Objective : **
In this assignment, you will design and implement a simple program in C++ that calculates the distance between two points in a 3D space.This will be achieved by defining a structure to represent a 3D point and creating a function that calculates the distance between two points.

* *Details : **

1. * *Define a 3D Point Structure * *: Your structure should have three members : `x`, `y`, and `z`, which represent the coordinates of a point in 3D space.

2. * *Create a Distance Function * *: Write a function `calculateDistance()` that takes two 3D points as parameters and returns the distance between them.The distance between two points `(x1, y1, z1)` and `(x2, y2, z2)` in 3D space is calculated using the formula : `sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2 + (z2 - z1) ^ 2)`.

3. * *Testing Your Program * *: Test your program with different sets of 3D points.Make sure to cover various scenarios to validate your implementation.For example, check the case where the two points have the same coordinates.

** Requirements:**

	-Properly utilize structures in your implementation.
	- Your function should be able to handle negative coordinates.
	- Code should be well - commented and easy to read.

	* *Submission:**
	Upload your C++ source code file.The filename should be in the following format : `YourLastName_3DSpaceDistance.cpp`.

	* *Grading Criteria : **
	-Correctness of code : 60 %
	-Clarity of code(includes comments) : 20 %
	-Testing thoroughness : 20 %

	**Note : **
	Understanding how to work with structures is a fundamental aspect of programming in C++.This assignment will allow you to practice and become more comfortable with structures and their uses in C++.Good luck!

	Sure, here are some sample test cases that your students can use to test their programs :

**Test Case 1 : **

Input :

	Point 1 : x = 0, y = 0, z = 0
	Point 2 : x = 1, y = 1, z = 1

	Output :

	The distance between the two points is approximately 1.732.

	* *Test Case 2 : **

	Input :

	Point 1 : x = -1, y = -1, z = -1
	Point 2 : x = 1, y = 1, z = 1

	Output :

	The distance between the two points is approximately 3.464.

	* *Test Case 3 : **

	Input :

	Point 1 : x = 2, y = 3, z = -1
	Point 2 : x = 2, y = 3, z = -1

	Output :

	The distance between the two points is 0.

	* *Test Case 4 : **

	Input :

	Point 1 : x = -2.5, y = 3.1, z = 1
	Point 2 : x = 2, y = -1, z = 4.5

	Output :

	The distance between the two points is approximately 6.855.

	* *Note : **The output values can slightly vary depending on the precision level you choose when doing the calculations.The formula for the distance in a 3D space uses square root, which often results in irrational numbers.Therefore, the distance is often rounded to a certain number of decimal places.*/

#include <iostream>
#include <stdio.h>
#include <math.h>

typedef struct Point
{
	float x;
	float y;
	float z;
} Point;

float calculateDistance(Point point1, Point point2);

int main()
{
	Point point1;
	Point point2;

	//getting error about unitialzed local variable 'point1' and 'point2'. How to fix?
	//ok it was a syntax error, i had the double quotes enclosing the whole line, instead of just the format specifiers
	//C is so annoying

	printf("Enter the coordinates of the first point (x, y, z): ");
	scanf_s("%f %f %f", &point1.x, &point1.y, &point1.z);

	printf("Enter the coordinates of the second point (x, y, x): ");
	scanf_s("%f %f %f", &point2.x, &point2.y, &point2.z);

	float distance = calculateDistance(point1, point2);
	printf("The distance between points is: %.3f\n", distance);

	//ok this is working but the result i am getting is 1.732051, not 1.732, which seems like it's a rounded number result. How do i get it to round to 3 decimal places?
	//ok i had to look this up, I had to use a format specifier of %.3f to get it to round to 3 decimal places

	return 0;
}

float calculateDistance(Point point1, Point point2) {
	//The distance between two points `(x1, y1, z1)` and `(x2, y2, z2)` in 3D space is calculated using the formula : `sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2 + (z2 - z1) ^ 2)`.

	float distance = sqrt(pow(point2.x - point1.x, 2) + pow(point2.y - point1.y, 2) + pow(point2.z - point1.z, 2));

	return distance;
}