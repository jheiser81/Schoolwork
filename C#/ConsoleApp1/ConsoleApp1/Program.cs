using System;

//string x = "5";
//string y = "10";
//int sum = int.Parse(x + y);

//x and y are now going to be user inputs that can be any value.

//int x = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());
//int sum = x + y;
//Console.WriteLine($"The sum of {x} and {y} is {sum}");

//sum an array of numbers instead of just two numbers.

int[] nums = { 1, 2, 3, 4, 5 };
int sum = 0;

//sum the array

for (int i = 0; i < nums.Length; i++)
{
    sum += nums[i];
}

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
Console.WriteLine();

Console.WriteLine($"The sum of the array is {sum}");