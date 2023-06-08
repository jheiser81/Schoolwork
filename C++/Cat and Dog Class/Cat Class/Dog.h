#pragma once
#include <string>

//making the class
class Dog {
private:
	std::string name;
	std::string breed;
	std::string color;
	int age;

public:
	//making the constructor
	Dog(const std::string& name, const std::string& breed, const std::string& color, int age);

	//Getters and setters
	std::string getName() const;
	void setName(const std::string& name);

	std::string getBreed() const;
	void setBreed(const std::string& breed);

	std::string getColor() const;
	void setColor(const std::string& color);

	int getAge() const;
	void setAge(int age);

	//Other functions
	void bark() const;
	void tailWag() const;
	void drool() const;
};
