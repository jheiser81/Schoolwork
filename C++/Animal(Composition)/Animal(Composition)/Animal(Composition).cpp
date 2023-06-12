#include <iostream>
#include "Petowner.h"
#include "Animal.h"

int main()
{
    PetOwner petOwner("Mittens", "Roger", "Meow", "Woof");

    petOwner.hearAnimalSound(petOwner.getCat()); //this was giving me an inaccessible error, had to look up how to fix it.    
    petOwner.hearAnimalSound(petOwner.getDog());

    for (int i = 0; i < 20; i++) {
		petOwner.playFetchWithDog("ball");
	}

    std::cout << "The dog's name is now " << petOwner.getDog().getName() << "\n";

    return 0;
}


