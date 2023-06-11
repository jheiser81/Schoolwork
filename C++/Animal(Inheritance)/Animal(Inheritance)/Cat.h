#pragma once
#include "Animal.h"

class Cat : public Animal {
public:
	Cat(const std::string& name, const std::string& species, const std::string& sound);
	void makeSound() override;
};
