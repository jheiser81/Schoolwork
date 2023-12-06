#include <stdio.h>

///Function Prototypes:

void printBoard(char board[3][3]); //declaration for print board function:

void updateBoard(char board[3][3], int row, int col, char player); //declaration for update board function:

//int check_winner(char board[3][3]); //declaration for check winner function
//
//int check_draw(char board[3][3]); //declaration for check draw function
//
//int check_valid_move(char board[3][3], int row, int col); //declaration for check valid move function
//
//int check_valid_input(int row, int col); //declaration for check valid input function

///Function Calls:

int main()
{
	//1. Initialize a 3x3 multi - dimensional array, or single - dimensional array to represent the game board.

	int row, col; //declare row and col variables
	char player = 'X'; //player X goes first

	char gameBoard[3][3] = { {'-', '-', '-'}, {'-', '-', '-'}, {'-', '-', '-'} }; //this is working

	printBoard(gameBoard); //call the printBoard function and pass in the gameBoard as a parameter

	// Game logic
	 // Prompt the current player for their move:
	 // Get the row and column from the player's input

	printf("Player %c, enter a row and column: ", player); //prompt the player to enter a row and column
	scanf_s("%d %d", &row, &col); //get the row and column from the player's input

	return 0;
}

///Function Definitions:

void printBoard(char board[3][3])
{
	printf("Current board:\n");
	printf("-------------\n");

	for (int i = 0; i < 3; i++) //outer loop iterates through the rows
	{
		for (int j = 0; j < 3; j++) //inner loop iterates through the columns
		{
			printf("%c ", board[i][j]); //prints the current element
		}
		printf("\n"); //prints a new line after each row
	}
	printf("-------------\n");
}

void updateBoard(char board[3][3], int row, int col, char player)
{
	board[row][col] = player; //sets the element at the specified row and column to the player's symbol
}

//int check_winner(char board[3][3])
//
//int check_draw(char board[3][3])
//
//int check_valid_move(char board[3][3], int row, int col)
//
//int check_valid_input(int row, int col) 