#pragma once
#include "Animal.h"
#include <string>

class PetOwner {
private:
	Animal dog;
	Animal cat;
	int totalFetches = 0;

public:
	PetOwner(const Animal& dog, const Animal& cat); //passing Animal objects dog and cat by reference

	void playFetchWithDog(std::string item);
	void hearAnimalSound(const Animal& animal);
};
