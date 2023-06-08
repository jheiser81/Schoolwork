#include <iostream>

int main()
{
	//The number S is called the mean of two numbers R1 and R2 if S is equal to(R1 + R2) / 2. Mirko’s birthday present for Slavko was two integers R1 and R2.Slavko promptly calculated their mean which also happened to be an integer but then lost R2!Help Slavko restore R2.

	//The formula for calculating the mean of two integers is as follows: (R1 + R2) / 2 = S

	//Input
	//The first and only line of input contains two integers R1 and S, both between - 1000 and 1000.

	//Output
	//Output R2 on a single line.

	//Case 1: Input: 11 15 Output: 19
	//Case 2: Input: 4 3 Output: 2

	int R1;
	int S;
	int R2;

	std::cin >> R1 >> S;

	R2 = (S * 2) - R1;

	std::cout << R2;

	return 0;
}