// Structs.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <stdio.h>

//it is customary to put structs at the top of the file, before function prototypes and before the main function
//this is because the function prototypes and the main function will use the structs, so they need to be defined first

struct Student //this is the struct definition
{
	char name[50]; //Member 1: name
	int age;	   //Member 2: age
	float gpa;	   //Member 3: gpa
};

struct DOB //this is a struct that is used in the Person struct
{
	int day;
	int month;
	int year;
};
struct Person //this is a struct that contains another struct
{
	char FirstName[50];
	char LastName[50];
	DOB DateOfBirth;
};

void printStudent(struct Student student); //this is the function prototype for the printStudent function

void updateGPA(struct Student* student, float newGPA);

struct Student createStudent(const char* name, int age, float gpa);

int main()
{
	Student student1 = { "John", 20, 3.5 };
	Student student2 = { "Alice", 22, 3.8 };
	Student student3 = { "Tom Foolery", 25, 2.0 };

	/*make a student that takes in user input*/
	Student student4;
	printf("Enter the name of the student: ");
	scanf_s("%s", student4.name, 50); //need to specify the size of the array to avoid buffer overflow
	printf("Enter the age of the student: ");
	scanf_s("%d", &student4.age); //need to use the & operator to get the address of the variable
	printf("Enter the GPA of the student: ");
	scanf_s("%f", &student4.gpa);

	printf("\n");

	//Calling the printStudent function to print the values of the student struct
	printStudent(student1);
	printf("\n");
	printStudent(student2);
	printf("\n");
	printStudent(student3);
	printf("\n");
	printStudent(student4);
	printf("\n");

	//call the createStudent function to create a student
	Student student5 = createStudent("Bob", 20, 3.5);
	printStudent(student5);

	updateGPA(&student1, 4.0);

	//this is printing the values of the student struct without using the printStudent function. This is printing by value
	//printf("\n");
	//printf("Student 1: %s, %d, %f\n\n", student1.name, student1.age, student1.gpa); //has to follow the exact same format as the struct, so string, int, float
	//printf("Student 2: %s, %d, %f\n\n", student2.name, student2.age, student2.gpa);
	//printf("Student 3: %s, %d, %f\n\n", student3.name, student3.age, student3.gpa);
	//printf("Student 4: %s, %d, %f\n\n", student4.name, student4.age, student4.gpa);

	//Person person1 = { "John", "Doe", { 1, 1, 2000 } };
	//Person person2 = { "Alice", "Smith", { 1, 1, 2000 } };

	//printf("Person 1: %s, %s, %d/%d/%d\n", person1.FirstName, person1.LastName, person1.DateOfBirth.day, person1.DateOfBirth.month, person1.DateOfBirth.year);
	//printf("Person 2: %s, %s, %d/%d/%d\n", person2.FirstName, person2.LastName, person2.DateOfBirth.day, person2.DateOfBirth.month, person2.DateOfBirth.year);
}

void printStudent(struct Student student) //this is a function that prints the values of the student struct
{
	printf("Name: %s\n", student.name);
	printf("Age: %d\n", student.age);
	printf("GPA: %f\n", student.gpa);
}

void updateGPA(struct Student* student, float newGPA) //this is a function that updates the GPA of a student by reference instead of by value
{
	student->gpa = newGPA; //this uses the -> operator to access the member of the struct
}

struct Student createStudent(const char* name, int age, float gpa)
{
	struct Student student;
	strcpy_s(student.name, name); //this is how you copy a string into a char array
	student.age = age;
	student.gpa = gpa;
	return student;
}