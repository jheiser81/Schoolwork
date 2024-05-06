// Linked Lists.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <stdio.h>
#include <string.h>

struct Node
{
	int data;
	Node* next;
};

//what does a linked list include?
//it includes a struct, pointers, and malloc

Node* start; //pointer to start. Declaring it globally so it can be used wherever it's called

Node* end; //dont think this is being used. Maybe just example code

void printList()
{
	Node* currentNode = start;
	printf("<-Start-> \n");

	while (currentNode != NULL)
	{
		printf("Data: % d, Address : % p, Next Adddress : % p\n", currentNode->data, currentNode, currentNode->next);
		currentNode = currentNode->next;
	}
	printf("<-End->\n");
}

// **function prototypes**

void addNodeToStartofList(int newData);

void addNodeToEndofList(int newData);

void deleteNodeFromStart();

void deleteNodeFromEnd();

void addNewNodeAfterSpecificItemInList(int item, int newData);

void addNewNodeBeforeSpecificItemInList(int item, int newData);

void deleteNodeAfterSpecificItemInList(int data);

void deleteNodeBeforeSpecificItemInList(int data);

int main()
{
	start = NULL;
	printf("--Start of list--\n");
	addNodeToStartofList(55);
	addNodeToStartofList(3);
	addNodeToStartofList(2);
	addNodeToStartofList(1);
	//this is adding a new node to the start of the list, but since it's written sequentially, the order will still be 1, 2, 3, because each new node is added to the start of the list

	printf("\n"); //linebreak

	printf("--Add to end of list--\n");
	addNodeToEndofList(1);
	addNodeToEndofList(2);
	addNodeToEndofList(3);
	addNodeToEndofList(55);
	//this is adding a new node to the end of the list, so the order will be 3, 2, 1, because each new node is added to the end of the list

	printf("\n"); //line break

	deleteNodeFromStart(); //working. Deletes 1 from the start of the list

	deleteNodeFromEnd(); //working. Deletes 55 from the end of the list

	addNewNodeAfterSpecificItemInList(88, 2); //working. Adds 88 after 2

	addNewNodeBeforeSpecificItemInList(20, 2); //working. Adds 20 before 2

	deleteNodeAfterSpecificItemInList(2); //working. Deletes the node after 2 (3)

	deleteNodeBeforeSpecificItemInList(2); //working. Deletes the node before 2 (20)

	printList();

	//Original code:
		/*Node start;
		Node* node2 = (Node*)malloc(sizeof(Node));
		Node* node3 = (Node*)malloc(sizeof(Node));
		Node* node4 = (Node*)malloc(sizeof(Node));
		start.data = 1;
		start.next = node2;
		node2->data = 2;
		node2->next = node3;
		node3->data = 3;
		node3->next = node4;
		node4->next = NULL;

		printf("Start Data: %d, Start Address: %p\n", start.data, &start, start.next);
		printf("Node2 Data: %d, Node2 Address: %p\n", node2->data, node2, node2->next);
		printf("Node3 Data: %d, Node3 Address: %p\n", node3->data, node3, node3->next);
		printf("Start Next Data: %d, Start Next Address %p, Start Next Next Address %p\n ", start.next->data, start.next, start.next->next);

		printf("\n\n");

		//how to use a while loop to print out all the data in the linked list

		Node* currentNode = &start; //creates a pointer to the start of the linked list called 'currentNode'.

		while (currentNode != NULL) //condition: while currentNode is not null
		{
			printf("Data: %d, Address: %p, Next Address: %p\n", currentNode->data, currentNode, currentNode->next);
			currentNode = currentNode->next;
		}*/

		//Here's how it works:
			/*
					•The code initializes a pointer currentNode to the address of the first node in the linked list(&start).currentNode is later used to traverse the list.

					•It then enters a while loop with the condition that currentNode is not NULL.

					•Inside the while loop, it prints the Data, Address, and Next Address of each node in the list using printf() function.The arguments of printf() are formatted to display the correct data.

					•Finally, currentNode is set to the pointer to the next node in the list using the currentNode = currentNode->next; statement.*/
}

// **Definitions**

void addNodeToStartofList(int newData)
{
	struct Node* newNode = (struct Node*)malloc(sizeof(struct Node));
	newNode->data = newData;
	newNode->next = start;
	start = newNode;

	printf("Data: %d \n", newNode->data);

	//Breakdown of what this is doing:
	/*
	  •The function takes an integer argument newData.
	  •It creates a new node using the malloc() function and sizeof operator, and assigns the address of the new node to a pointer newNode.
	  •It assigns the data of the new node to the newData argument.
	  •It assigns the next pointer of the new node to the start pointer.
	  •It assigns the start pointer to the new node
	  •The new node is now the first node in the list.*/

	  //Breakdown of the reason for each step:
	  /*
		  •First, we need to create a new node to add to the list. We do this by using the malloc() function to allocate memory for the new node. We then assign the address of the new node to a pointer  newNode. We use the struct keyword to specify that the pointer is of type Node, which is the struct we defined earlier. We also use the sizeof() function to specify the size of the new node.  The size of the new node is the size of the Node struct, which is 8 bytes. We then cast the result of the malloc() function to a Node pointer.
		  •Next, we assign the data of the new node to the newData argument. This is the data that we want to add to the list. We do this by using the arrow operator(->) to access the data field of the   new node and assign it to the newData argument. The arrow operator is used to access the data field of a struct pointer.
		  •Next, we assign the next pointer of the new node to the start pointer. This is because we want the new node to point to the start of the list. We do this by using the arrow operator(->) to access the next field of the new node and assign it to the start pointer.
		  •Finally, we assign the start pointer to the new node. This is because we want the new node to be the first node in the list. */
}

void deleteNodeFromStart()
{
	if (start == NULL)
	{
		return;
	}

	Node* temp = start;
	start = start->next;
	free(temp);

	//Breakdown of what this is doing:
	/*
  •The function takes no arguments because it deletes the first node in the list regardless of the data in the node.
  •It creates a temporary pointer temp to store the address of the first node in the list.
  •It assigns the start pointer to the next pointer of the first node in the list.
  •It frees the memory allocated to the first node in the list using the free() function.*/

  //Breakdown of the reason for each step:
  /*
  •First, we need to create a temporary pointer to store the address of the first node in the list. We do this by declaring a pointer temp of type Node and assigning it to the start pointer. This is because we want to free the memory allocated to the first node in the list. If we don't store the address of the first node in the list in a temporary pointer, we will lose the address of the first node in the list when we assign the start pointer to the next pointer of the first node in the list.

  •Next, we assign the start pointer to the next pointer of the first node in the list. This is because we want the second node in the list to be the first node in the list. We do this by using the arrow operator(->) to access the next field of the first node in the list and assign it to the start pointer.

  •Finally, we free the memory allocated to the first node in the list using the free() function. We do this by passing the address of the first node in the list to the free() function.*/
}

void addNodeToEndofList(int newData)
{
	struct Node* newNode = (struct Node*)malloc(sizeof(struct Node));
	newNode->data = newData;
	newNode->next = NULL; //this is the last node in the list, so it's next pointer is NULL
	printf("Data: %d \n", newNode->data);

	if (start == NULL)
	{
		start = newNode;
		return;
	}
	else
	{
		struct Node* currentNode = start;

		while (currentNode->next != NULL)
		{
			currentNode = currentNode->next;
		}
		currentNode->next = newNode;
	}

	//Breakdown of what this is doing:
	/*
		•The function takes an integer argument newData.
		•It creates a new node using the malloc() function and sizeof operator, and assigns the address of the new node to a pointer newNode.
		•It assigns the data of the new node to the newData argument.
		•It assigns the next pointer of the new node to NULL because it is the last node in the list.
		•It assigns the start pointer to the new node if the list is empty.
		•It traverses the list until it reaches the last node in the list.
		•It assigns the next pointer of the last node in the list to the new node.*/

		//Breakdown of the reason for each step:
		/*
			•First, we need to create a new node to add to the list. We do this by using the malloc() function to allocate memory for the new node. We then assign the address of the new node to a pointer  newNode. We use the struct keyword to specify that the pointer is of type Node, which is the struct we defined earlier. We also use the sizeof() function to specify the size of the new node. The size of the new node is the size of the Node struct, which is 8 bytes. We then cast the result of the malloc() function to a Node pointer.

			•Next, we assign the data of the new node to the newData argument. This is the data that we want to add to the list. We do this by using the arrow operator(->) to access the data field of the   new node and assign it to the newData argument. The arrow operator is used to access the data field of a struct pointer.

			•Next, we assign the next pointer of the new node to NULL because it is the last node in the list. We do this by using the arrow operator(->) to access the next field of the new node and assign it to NULL.

			•Next, we assign the start pointer to the new node if the list is empty. This is because we want the new node to be the first node in the list. We do this by using an if statement to check if the start pointer is NULL. If it is, we assign the start pointer to the new node.

			•Next, we traverse the list until we reach the last node in the list. We do this by using a while loop to check if the next pointer of the current node is NULL. If it is, we assign the next pointer of the current node to the new node.

			•Finally, we assign the next pointer of the last node in the list to the new node. This is because we want the new node to be the last node in the list. We do this by using the arrow operator(->) to access the next field of the last node in the list and assign it to the new node. */
}

void deleteNodeFromEnd()
{	// **First method**:
	if (start == NULL) //if list is empty, exit
	{
		printf("Node cannot be deleted from empty list\n");
		return;
	}

	if (start->next == NULL) //checks if the next node is null, which would mean there is only one node in the list
	{
		free(start);
		start = NULL;
		printf("Node is now empty\n");
		return;
	}

	Node* current = start;
	Node* temp = NULL;

	while (current->next != NULL)
	{
		/*printf("Current data: %d \n", current->data);*/
		temp = current;
		current = current->next;
	}
	temp->next = NULL;
	free(current);

	//Breakdown of what this is doing:
/*
	•The function takes no arguments because it deletes the last node in the list regardless of the data in the node.
	•It checks if the list is empty. If it is, it prints a message and exits the function.
	•It checks if the list has only one node. If it does, it frees the memory allocated to the node and assigns the start pointer to NULL.
	•It creates a temporary pointer second_last to store the address of the second to last node in the list.
	•It assigns the next pointer of the second to last node in the list to NULL because it is the last node in the list.
	•It frees the memory allocated to the last node in the list using the free() function.*/

	//Breakdown of the reason for each step:
	/*
	•First, we need to check if the list is empty. We do this by using an if statement to check if the start pointer is NULL. If it is, we print a message and exit the function.

	•Next, we need to check if the list has only one node. We do this by using an if statement to check if the next pointer of the start pointer is NULL. If it is, we free the memory allocated to the start pointer using the free() function. We then assign the start pointer to NULL.

	•Next, we need to delete the last node in the list. We do this by creating a temporary pointer second_last to store the address of the second to last node in the list. We then use a while loop to traverse the list until we reach the second to last node in the list. We do this by using an if statement to check if the next pointer of the current node is NULL. If it is, we assign the address of the current node to the second_last pointer. We then assign the next pointer of the second to last node in the list to NULL because it is the last node in the list. We do this by using the arrow operator(->) to access the next field of the second to last node in the list and assign it to NULL. We then free the memory allocated to the last node in the list using the free() function.*/

	// **Second method**:
   /*if (start == NULL) //if list is empty, exit
   {
	   printf("Node cannot be deleted from empty list\n");
	   return;
   }

   if (start->next == NULL) //checks if the next node is null, which would mean there is only one node in the list
   {
	   free(start);
	   start = NULL;
	   return;
   }

   Node* second_last = start; //create temporary pointer to store address of second to last node
   while (second_last->next->next != NULL) //traverse list until second to last node is reached
   {
	   second_last = second_last->next; //assign address of next node to second_last
   }

   free(second_last->next); //delete last node
   second_last->next = NULL; //change next of second last node to NULL*/
}

void addNewNodeAfterSpecificItemInList(int data, int dataToFind)
{
	// **Maya's Code**:

	Node* currentNode = start; //set current node to start pointer
	bool found = false;

	while (currentNode != NULL)
	{
		if (currentNode->data == dataToFind) //check if current node data is equal to dataToFind
		{
			/*printf("Current data: %d \n", currentNode->data);*/
			found = true;
			break;
		}
		currentNode = currentNode->next; //assign current node to next node
	}

	if (!found)
	{
		printf("Data not found\n");
		return;
	}

	Node* newNode = (Node*)malloc(sizeof(Node)); //create new node
	newNode->data = data; //assign new node data to data
	newNode->next = currentNode->next; //assign new node next to current node next
	currentNode->next = newNode; //assign current node next to new node

	//Breakdown of what this is doing:
	/*
	•The function takes two arguments: data and dataToFind. The data argument is the data to be stored in the new node. The dataToFind argument is the data of the node after which the new node is to be inserted.
	•We create a temporary pointer currentNode to store the address of the current node in the list.
	•We create a boolean variable found and assign it to false. This variable is used to check if the dataToFind is found in the list.
	•We use a while loop to traverse the list until we reach the end of the list. We do this by using an if statement to check if the currentNode is NULL. If it is, we exit the loop.
	•We use an if statement to check if the data of the current node is equal to the dataToFind. If it is, we assign the address of the current node to the newNode pointer and exit the loop.
	•We assign the address of the next node of the current node to the currentNode pointer. We do this by using the arrow operator(->) to access the next field of the current node and assign it to the currentNode pointer.
	•We use an if statement to check if the found variable is false. If it is, we print a message and exit the function.
	•We create a new node using the malloc() function and assign it to the newNode pointer.
	•We assign the data argument to the data field of the new node. We do this by using the arrow operator(->) to access the data field of the new node and assign it to the data argument.
	•We assign the next field of the new node to the next field of the current node. We do this by using the arrow operator(->) to access the next field of the new node and assign it to the next field of the current node.
	•Last, we assign the next field of the current node to the new node. We do this by using the arrow operator(->) to access the next field of the current node and assign it to the new node.*/

	//Breakdown of the reason for each step:
	/*
	•First, we need to check if the list is empty. We do this by using an if statement to check if the start pointer is NULL. If it is, we print a message and exit the function.

	•Next, we need to check if the list has only one node. We do this by using an if statement to check if the next pointer of the start pointer is NULL. If it is, we create a new node using the malloc() function and assign it to the newNode pointer. We then assign the data argument to the data field of the new node. We do this by using the arrow operator(->) to access the data field of the new node and assign it to the data argument. We then assign the next field of the new node to the next field of the start pointer. We do this by using the arrow operator(->) to access the next field of the new node and assign it to the next field of the start pointer. We then assign the next field of the start pointer to the new node. We do this by using the arrow operator(->) to access the next field of the start pointer and assign it to the new node. We then exit the function.

	•If the list has more than one node, we need to traverse the list until we reach the end of the list. We do this by using a while loop to traverse the list until the next pointer of the start pointer is NULL. We do this by using an if statement to check if the next pointer of the start pointer is NULL. If it is, we exit the loop.

	•We then create a temporary pointer second_last to store the address of the second to last node in the list. We do this by assigning the start pointer to the second_last pointer.

	•We then use a while loop to traverse the list until we reach the second to last node. We do this by using an if statement to check if the next pointer of the next pointer of the second_last pointer is NULL. If it is, we exit the loop.

	•We then free the last node in the list using the free() function. We do this by using the free() function to free the next pointer of the second_last pointer.

	•Last, we assign the next field of the second_last pointer to NULL, which is the last node in the list.
	*/
}

void addNewNodeBeforeSpecificItemInList(int data, int nodeToFind)
{
	// **Maya's Code**:
	Node* currentNode = start; //set current node to start pointer

	if (start == NULL) { return; }

	if (start->data == nodeToFind)
	{
		addNodeToStartofList(data);
		return;
	}

	bool found = false;
	while (currentNode->next != NULL)
	{
		if (currentNode->next->data == nodeToFind)
		{
			printf("Found current data: %d \n", currentNode->data);
			found = true;
			break;
		}
		currentNode = currentNode->next; //assign current node to next node
	}

	if (!found)
	{
		printf("Data not found\n");
		return;
	}

	Node* newNode = (Node*)malloc(sizeof(Node)); //create new node
	newNode->data = data; //assign new node data to data
	newNode->next = currentNode->next; //assign new node next to current node next
	currentNode->next = newNode; //assign current node next to new node

	//Breakdown of what this is doing:
	/*
	•The function takes two arguments: data and dataToFind. The data argument is the data to be stored in the new node. The dataToFind argument is the data of the node after which the new node is to be inserted.
	•We create a temporary pointer currentNode to store the address of the current node in the list.
	•We create a boolean variable found and assign it to false. This variable is used to check if the dataToFind is found in the list.
	•We use a while loop to traverse the list until we reach the end of the list. We do this by using an if statement to check if the currentNode is NULL. If it is, we exit the loop.
	•We use an if statement to check if the data of the next node of the current node is equal to the dataToFind. If it is, we assign the address of the current node to the newNode pointer and exit the loop.
	•We assign the address of the next node of the current node to the currentNode pointer. We do this by using the arrow operator(->) to access the next field of the current node and assign it to the currentNode pointer.
	•We use an if statement to check if the found variable is false. If it is, we print a message and exit the function.
	•We create a new node using the malloc() function and assign it to the newNode pointer.
	•We assign the data argument to the data field of the new node. We do this by using the arrow operator(->) to access the data field of the new node and assign it to the data argument.
	•We assign the next field of the new node to the next field of the current node. We do this by using the arrow operator(->) to access the next field of the new node and assign it to the next field of the current node.
	•We assign the next field of the current node to the new node. We do this by using the arrow operator(->) to access the next field of the current node and assign it to the new node.
	*/

	//Breakdown of the reason for each step:
	/*
	•First, we need to check if the list is empty. We do this by using an if statement to check if the start pointer is NULL. If it is, we print a message and exit the function.

	•Next, we need to check if the list has only one node. We do this by using an if statement to check if the next pointer of the start pointer is NULL. If it is, we create a new node using the malloc() function and assign it to the newNode pointer. We then assign the data argument to the data field of the new node. We do this by using the arrow operator(->) to access the data field of the new node and assign it to the data argument. We then assign the next field of the new node to the next field of the start pointer. We do this by using the arrow operator(->) to access the next field of the new node and assign it to the next field of the start pointer. We then assign the next field of the start pointer to the new node. We do this by using the arrow operator(->) to access the next field of the start pointer and assign it to the new node. We then exit the function.

	•If the list has more than one node, we need to traverse the list until we reach the end of the list. We do this by using a while loop to traverse the list until the next pointer of the start pointer is NULL. We do this by using an if statement to check if the next pointer of the start pointer is NULL. If it is, we exit the loop.

	•We then create a temporary pointer currentNode to store the address of the current node in the list. We do this by assigning the start pointer to the currentNode pointer.

	•We then use a while loop to traverse the list until we reach the end of the list. We do this by using an if statement to check if the next pointer of the currentNode pointer is NULL. If it is, we exit the loop.

	•We then use an if statement to check if the data of the next node of the current node is equal to the dataToFind. If it is, we assign the address of the current node to the newNode pointer and exit the loop.

	•We then assign the address of the next node of the current node to the currentNode pointer. We do this by using the arrow operator(->) to access the next field of the current node and assign it to the currentNode pointer.

	•We then use an if statement to check if the found variable is false. If it is, we print a message and exit the function.

	•We then create a new node using the malloc() function and assign it to the newNode pointer.

	•We then assign the data argument to the data field of the new node. We do this by using the arrow operator(->) to access the data field of the new node and assign it to the data argument.

	•We then assign the next field of the new node to the next field of the current node. We do this by using the arrow operator(->) to access the next field of the new node and assign it to the next field of the current node.

	•We then assign the next field of the current node to the new node. We do this by using the arrow operator(->) to access the next field of the current node and assign it to the new node.
	*/
}

void deleteNodeAfterSpecificItemInList(int data)
{
	if (start == NULL)
	{
		return; //checks if the list is empty(start=NULL). If it is, exits
	}

	Node* currentNode = start; //assigns current node to start

	while (currentNode != NULL)
	{
		if (currentNode->data == data) //checks if current node data is equal to data
		{
			Node* nodeToDelete = currentNode->next; //assigns node to delete to current node next
			currentNode->next = nodeToDelete->next; //assigns current node next to node to delete next
			free(nodeToDelete); //frees node to delete
			return;
		}
		currentNode = currentNode->next; //assigns current node to next node
	}
}

void deleteNodeBeforeSpecificItemInList(int data)
{
	if (start == NULL || start->next == NULL)
	{
		return; //checks if the list is empty(start=NULL) or if there is only one node in the list(start->next=NULL). If it is, exits
	}

	if (start->next->data == data)
	{
		Node* nodeToDelete = start;
		start = start->next;
		free(nodeToDelete);
		return;
	}

	Node* currentNode = start;
	Node* prevNode = start;

	while (currentNode != NULL)
	{
		if (currentNode->data == data)
		{
			Node* nodeToDelete = prevNode;
			prevNode->next = currentNode->next;
			free(nodeToDelete);
			return;
		}
		prevNode = currentNode;
		currentNode = currentNode->next;
	}
}