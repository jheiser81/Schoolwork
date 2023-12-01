/* Assignment: Task Management System**

In this assignment, you will be working with a simple task management system implemented in C.The system allows the user to add tasks, remove tasks, and display the current list of tasks.

The provided code includes a `Task` struct, an array of `Task` structs, and functions to add a task, remove a task, and print all tasks.The main function presents a menu to the user and performs the chosen operation.

Your task is to enhance this system by implementing the following features :

1. * *Task Prioritization * *: Modify the `Task` struct to include a priority field(an integer).Update the `addTask` function to accept a priority along with the task name and id.The tasks should be stored in the array in order of their priority(highest priority first).

2. * *Task Completion * *: Add a new operation to the menu that allows the user to mark a task as completed.Completed tasks should not be removed from the list, but they should be marked in some way when the tasks are printed.

3. * *Error Handling * *: Improve the error handling in the system.For example, what happens if the user tries to remove a task that doesn't exist, or add a task when the array is already full? Make sure these conditions are handled gracefully.

4. * *Code Documentation * *: Add comments to the code to explain what each function does, what the parameters are, and what the return value is(if any).Also add comments to any complex or important lines of code within the functions.

5. * *Testing * *: Write a series of tests for your task management system.These tests should demonstrate that all of the features of the system work correctly, including the new features you have added.

** Bonus Task** : Modify the task array to behave as a stack or a doubly - ended queue(deque).In a stack, the last task added is the first one to be removed(LIFO : Last In First Out).In a deque, tasks can be added or removed from either end.Implement the necessary operations for your chosen data structure(e.g., push / pop for a stack, push_front / push_back / pop_front / pop_back for a deque).

** Submission Guidelines**

-Your code should be written in C and should be compatible with the Visual Studio 2022 compiler.
- Include your source code files and a README file that explains how to compile and run your code.
- Submit your files as a zip archive.

* *Grading Criteria * *

-Correctness: Your code should compile without errors and all features should work as described.
- Code Quality : Your code should be well - structured and easy to read, with good use of functions, variables, and control structures.
- Documentation : Your code should be well - documented with comments explaining what your code is doing.
- Testing : You should provide a thorough set of tests that demonstrate that your code works correctly.

Good luck!
*/

//---------------------- - Code To Fill In-----------------------

#include <stdio.h>
#include <iostream>
#define MAX_TASKS 50

// Define the Task struct

typedef struct //the typedef makes it so you dont have to type struct Task every time you want to use it
{
	char name[50];
	int id;
	//int priority; //dont need this apparently, the id is the priority
}Task;

// Declare an array of Tasks

Task tasks[MAX_TASKS]; //Task struct is the data type, tasks is the name of the array, MAX_TASKS is the size of the array

// Initialize a counter for the current number of tasks
int currentTasks = 0;
void addTask(const char* name, int id);
void removeTask(int id);
void printTask();

int main()
{
	int choice = 0;

	do
	{
		printf("Choose an option:\n");
		printf("1) Add a task\n2) Remove task\n3) Display tasks\n4) Exit program\n");
		scanf_s("%d", &choice);
		getchar();

		switch (choice)
		{
		case 1:
			char taskToAdd[100];
			printf("Enter a task to add: ");
			/*scanf_s("%s", taskToAdd, sizeof(taskToAdd));*/ //this isn't working, it's not prompting for the priority input
			fgets(taskToAdd, sizeof(taskToAdd), stdin);
			taskToAdd[strcspn(taskToAdd, "\n")] = 0; //removes the newline
			printf("Input priority: ");
			int priority;
			scanf_s("%d", &priority);
			getchar(); //what does this do?
			addTask(taskToAdd, priority);
			break;

		case 2:
			int taskToRemove;
			printf("Which task would you like to remove? ");
			scanf_s("%d", &taskToRemove);
			getchar();
			removeTask(taskToRemove);
			break;

		case 3:
			printTask();
			break;

		default:
			printf("Exit program\n");
			break;
		}
	} while (choice != 4);
	return 0;
}

void addTask(const char* name, int id)
{
	if (currentTasks < MAX_TASKS) {
		strcpy_s(tasks[currentTasks].name, sizeof(tasks[currentTasks].name), name);
		tasks[currentTasks].id = id;
		currentTasks++;
	}
	else {
		printf("Error: Task list is full\n");
	}
}

// Function to remove a task by id
void removeTask(int id) {
	for (int i = 0; i < currentTasks; i++) {
		if (tasks[i].id == id) {
			for (int j = i; j < currentTasks - 1; j++) {
				tasks[j] = tasks[j + 1];
				tasks[j + 1].id = 0;
				strcpy_s(tasks[j + 1].name, sizeof(tasks[currentTasks].name), "");
			}
			currentTasks--;
			return;
		}
	}
}

void printTask() {
	printf("--- Start of Task List ---\n");
	for (size_t i = 0; i < currentTasks; i++) //what is this?
	{
		printf("%d. %s\n", tasks[i].id, tasks[i].name);
	}
	printf("--- End of Task List ---\n");
}