// Linked List Practice 2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <stdio.h>
#include <string.h>

struct Node //
{
	int data;
	Node* next;
};

Node* start; //start is a pointer to the first node. Made it global pointer variable.

// 1) Create a node struture with two members, data and next
// 2) Create a pointer to the first node in the list
// 3) Set up function prototypes

// **Function prototypes**

void PrintList()
{
	Node* currentNode = start;

	while (currentNode != NULL)
	{
		printf("Data: %d \n", currentNode->data);
		currentNode = currentNode->next;
	}
}
void AddNodeToStart(int newData);

void AddNodeToEnd(int newData);

int main()
{
	start = NULL; //we do this because we want to start with an empty list

	AddNodeToStart(1);
	AddNodeToStart(2);
	AddNodeToStart(3);

	AddNodeToEnd(1);
	AddNodeToEnd(2);
	AddNodeToEnd(3);

	PrintList();
}

// **Function Defs**

void AddNodeToStart(int newData)
{
	Node* newNode = (Node*)malloc(sizeof(Node));//create a new node and allocate memory for it
	newNode->data = newData;//use arrow pointer -> to set newNode's data to newData
	newNode->next = start;//set the next node after newNode to start
	start = newNode;//set start to newNode

	/*  Node* newNode = (Node*)malloc(sizeof(Node)); //allocate mem for new node
		newNode->data = newData;					//use arrow pointer -> to set newNode's data to newData
		newNode->next = start;					   //set the next node after newNode to start
		start = newNode;						   //set start to newNode
		*/
}
void AddNodeToEnd(int newData) //takes an integer parameter newData
{
	/*Node* newNode = (Node*)malloc(sizeof(Node)); //allocate memory for new node

	newNode->data = newData; //use arrow pointer -> to set newNode's data to newData
	newNode->next = NULL; //use arrow pointer -> to set the next node after newNode to NULL, which indicates the end of the list
	Node* currentNode = start; //create a pointer variable currentNode and set it to start, so it now points to the first node in the list

	if (start == NULL)
	{
		start = newNode;
		return;
		//if the list is empty, set start to newNode and return
	}
	while (currentNode->next != NULL) //while the next node after currentNode is not NULL, keep moving currentNode to the next node
	{
		currentNode = currentNode->next; //use arrow pointer -> to set currentNode to the next node
	}
	currentNode->next = newNode; //set the next node after currentNode to newNode
	*/

	Node* newNode = (Node*)malloc(sizeof(Node));//allocate memory for new node

	newNode->data = newData; //use arrow pointer -> to set newNode's data to newData
	newNode->next = NULL;//use arrow pointer -> to set the next node after newNode to NULL, which indicates the end of the list
	Node* currentNode = start;//create a new node currentNode and set it to start, so it now points to the first node in the list

	if (start == NULL)//if the list is empty (start == NULL), set start to newNode and return
	{
		newNode = start;
		return;
	}
	while (currentNode->next != NULL)//while the next node after currentNode is not NULL, keep moving currentNode to the next node
	{
		currentNode = currentNode->next; //use arrow pointer -> to set currentNode to the next node
	}
	currentNode->next = newNode; //set the next node after currentNode to newNode
}