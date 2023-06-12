#include "Petowner.h"
#include <iostream>

PetOwner::PetOwner(const std::string& catName, const std::string& dogName, const std::string& catSound, const std::string& dogSound) : cat(catName, catSound), dog(dogName, dogSound), totalFetches(0) {}

void PetOwner::playFetchWithDog(const std::string& item) {
	totalFetches++;
	if (totalFetches >= 20) {
		std::cout << "The owner needs a break from playing with the dog. \n";
		dog.setName(dog.getName() + std::to_string(totalFetches));
		totalFetches = 0;
	}
	else {
		std::cout << "The owner is playing fetch with the dog. \n";
	}
}

Animal& PetOwner::getCat() {
	return cat;
}

Animal& PetOwner::getDog() {
	return dog;
}

void PetOwner::hearAnimalSound(Animal& animal) {
	animal.makeSound();
}

