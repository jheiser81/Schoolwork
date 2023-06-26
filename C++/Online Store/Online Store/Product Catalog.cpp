#include "Product Catalog.h"
#include <iostream>

Products::Products(const std::string& name, double price, const std::string& description, int StockQuantity) : name(name), price(price), description(description), stockQuantity(stockQuantity) {}

std::string& Products::getName() const {
	return name;
}