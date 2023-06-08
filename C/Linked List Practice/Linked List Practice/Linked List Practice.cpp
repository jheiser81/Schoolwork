// Linked List Practice.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <stdio.h>
#include <string.h>

struct Node
{
	int data;
	Node* next;
};
struct Person
{
	int age;
	char name[50];
	Person* next;
};

Node* start = NULL; //should this be null as well? or can it be and still work?

Person* personStart = NULL;

void addNodeToStart(int newData);

void deleteNodeFromStart();

void addPersonToStart(const char* newPersonName, int newPersonAge); //had to make const char* instead of char* because it was giving me an error

int main()
{
	struct Node* newNode = NULL;
	struct Person* newPerson = NULL;

	addNodeToStart(4);
	addNodeToStart(3);
	addNodeToStart(2);
	addNodeToStart(1);

	deleteNodeFromStart();

	struct Node* tempPtr = start;
	while (tempPtr != NULL)
	{
		printf("Data: %d, Address: %p, Next Address: %p\n", tempPtr->data, tempPtr, tempPtr->next);
		tempPtr = tempPtr->next;
	}
	printf("\n\n");

	addPersonToStart("Peter", 35);
	addPersonToStart("Mary", 30);
	addPersonToStart("John", 25);

	struct Person* PersonPtr = personStart;
	while (PersonPtr != NULL)
	{
		printf("Name: %s, Age: %d, Address: %p\n", PersonPtr->name, PersonPtr->age, PersonPtr, PersonPtr->next);
		PersonPtr = PersonPtr->next;
	}

	//Person linked list
	/*struct Person* personPtr = NULL; // NULL is a pointer to nothing. It is normal to set pointers to NULL when they are first created.
	struct Person* personPtr2 = NULL;
	struct Person* personPtr3 = NULL;

	personPtr = (struct Person*)malloc(sizeof(struct Person)); //malloc allocates memory for the struct and returns a pointer to the memory location

	if (personPtr != NULL) //if malloc was successful, it will return a pointer to the memory location. If it fails, it will return NULL
	{
		strcpy_s(personPtr->name, "John"); //strcpy_s copies the string from the second parameter to the first parameter
		personPtr->age = 25; //-> is used to access the members of a struct when using a pointer to the struct
		personPtr->next = NULL; //sets the next pointer to NULL so that we know it is the end of the list

		personPtr2 = (struct Person*)malloc(sizeof(struct Person)); //allocating memory for the next person in the list

		if (personPtr2 != NULL)
		{
			strcpy_s(personPtr2->name, "Mary");
			personPtr2->age = 30;
			personPtr2->next = NULL;

			personPtr3 = (struct Person*)malloc(sizeof(struct Person));

			if (personPtr3 != NULL)
			{
				strcpy_s(personPtr3->name, "Peter");
				personPtr3->age = 35;
				personPtr3->next = NULL;

				personPtr->next = personPtr2; //setting the next pointer of the first person to the second person
				personPtr2->next = personPtr3; //setting the next pointer of the second person to the third person

				//This is how we create a linked list. We can keep adding people to the list by setting the next pointer of the last person to the new person, so long as the memory has been allocated for the new person

				struct Person* tempPtr = personPtr; //creating a temporary pointer to the first person in the list. We do this because we don't want to lose the pointer to the first person in the list, so it helps to track the first person in the list with a temporary pointer

				while (tempPtr != NULL) //while the temporary pointer is not NULL, we can print the information of the person it is pointing to
				{
					printf("Name: %s\n", tempPtr->name);
					printf("Age: %d\n", tempPtr->age);
					tempPtr = tempPtr->next;
				}
			}
			else {
				printf("Memory allocation failed");
			}
		}
		else {
			printf("Memory allocation failed");
		}
	}
	else {
		printf("Memory allocation failed");
	}
	*/
}

void addNodeToStart(int newData)
{
	struct Node* newNode = (struct Node*)malloc(sizeof(struct Node));
	newNode->data = newData;
	newNode->next = start;
	start = newNode;
}

void deleteNodeFromStart()
{
	struct Node* temp = start;
	start = start->next;
	free(temp);
}

void addPersonToStart(const char* newPersonName, int newPersonAge)
{
	struct Person* newPerson = (struct Person*)malloc(sizeof(struct Person));
	strcpy_s(newPerson->name, newPersonName);
	newPerson->age = newPersonAge;
	newPerson->next = personStart;
	personStart = newPerson;
}