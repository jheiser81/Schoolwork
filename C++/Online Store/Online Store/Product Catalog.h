#pragma once
#include <string>

//1) Create the Product Catalog component :
//Implement a class to represent the product catalog.
//Define the necessary attributes for each product, such as name, price, description, and stock quantity.
//Implement methods to search for products, view product details, and add products to the shopping cart.

class Products {
private:
	std::string name;
	double price;
	std::string description;
	int stockQuantity;

public:
	Products(const std::string& name, double price, const std::string& description, int stockQuantity);

	std::string& getName() const;
	double getPrice() const;
	std::string& getDescription() const;
	int getStockQuantity() const;
};
