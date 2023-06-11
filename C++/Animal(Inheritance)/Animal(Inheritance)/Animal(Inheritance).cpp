#include <iostream>
#include "Cat.h"
#include "Dog.h"

//The `Dog` class should include an additional integer member variable `fetchCount`, which is initially set to 0, and a function `fetchItem()` that takes a string argument representing an item.Each time `fetchItem()` is called, increment `fetchCount` by 1. Once `fetchCount` is equal to or exceeds 10, print a message that the dog is tired, reset `fetchCount` to 0, and append the fetched item to the dog's original name

int main()
{
	Cat cat("Fluffy", "Cat", "Meow!");
	Dog dog("Fido", "Dog", "Woof!");

	std::cout << cat.showInfo() << "\n";
	std::cout << dog.showInfo() << "\n";

	cat.makeSound();
	dog.makeSound();

	std::cout << "\n";

	for (int i = 0; i < 10; i++) {
		dog.fetchItem("ball");
	}
	return 0;
}