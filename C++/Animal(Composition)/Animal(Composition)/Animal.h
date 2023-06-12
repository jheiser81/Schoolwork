#pragma once
#include <string>

class Animal {
protected:
	std::string name, sound;

public:
	Animal(const std::string& name, const std::string& sound);

	std::string getName() const;
	void setName(const std::string& name);

	virtual void makeSound();
};
