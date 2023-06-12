#include "Petowner.h"
#include <iostream>

PetOwner::PetOwner(const Animal& dog, const Animal& cat) : dog(dog), cat(cat) {}

void PetOwner::playFetchWithDog(std::string item) {
	totalFetches++;
	std::cout << "Playing fetch with " << dog.getName() << " using a " << item << "\n";

	if (totalFetches >= 20) { //will print out the name of the dog and the total number of fetches only once totalFetches is greater than or equal to 20
		std::cout << "The owner needs a break from playing. " << "\n\n";
		dog.setName(dog.getName() + "_" + std::to_string(totalFetches)); //added underscore to separate the dog's name from the count of fetches
		totalFetches = 0;
	}
}

void PetOwner::hearAnimalSound(const Animal& animal) {
	animal.makeSound();
}