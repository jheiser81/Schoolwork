#pragma once
#include "Animal.h"

class Dog : public Animal {
private:
	int fetchCount = 0; //not sure if this should be private or protected?
public:
	Dog(const std::string& name, const std::string& species, const std::string& sound);
	void fetchItem(const std::string& item);
	void makeSound() override;
};
