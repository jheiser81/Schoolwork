#pragma once
#include <string>

class Animal {
private:
	std::string name, sound;

public:
	//constructor
	Animal(const std::string& name, const std::string& sound);

	//getters
	std::string getName() const;
	std::string getSound() const;

	//setters
	void setName(const std::string& name);
	void setSound(const std::string& sound);

	//functions
	void makeSound() const; //does this need to be virtual?
};