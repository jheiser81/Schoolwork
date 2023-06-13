#include <iostream>
#include "Petowner.h"
#include "Animal.h"

int main()
{
	Animal dog("Oli", "Bark");
	Animal cat("Miau Miau", "Meow");
	//dog and cat are objects of the Animal class

	PetOwner owner(dog, cat); //owner is an object of the PetOwner class, and uses the dog and cat objects as parameters

	std::cout << "Dog name: " << dog.getName() << "\n";
	std::cout << "Cat name: " << cat.getName() << "\n\n"; //calling the getName function with the dog and cat objects to print their names

	owner.hearAnimalSound(dog);
	owner.hearAnimalSound(cat); //calling the hearAnimalSound function with the dog and cat objects to print their sounds

	std::cout << "\n";

	for (int i = 0; i < 41; i++)
	{
		owner.playFetchWithDog("frisbee");
	}
	return 0;
}