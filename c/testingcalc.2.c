#include <stdio.h>

int main(void)
{
	int numOperation = 0;
	int operand1;
	int operand2;
	int total;

	printf("\033[H\033[2J"); //ascii code to clear the screen

	printf("\nWelcome to cCALC!\n");

	while (numOperation < 7) //will loop as long as user does not enter value greater than 5
	{
		printf("------------------\n\n\n");
		printf("1. Add\n");
		printf("2. Subtract\n");
		printf("3. Multiply\n");
		printf("4. Divide\n");
		printf("5. Exponent (2nd number is exponent)\n");
		printf("6. Program info\n");
		printf("7. Exit\n");
		printf("\n\n");

		printf("Type a number 1 through 6: ");
		scanf("%d", &numOperation); //will scan for user input and then save it to a variable called numOperation

		if (numOperation != 6 && numOperation != 5) //code says that if user does not press 5 (for info) or 6 (to exit), the code will ask and search for both numbers needed to perform the calculation
		{
			printf("\nEnter a number: ");
			scanf("%d", &operand1); //scans for user's input for first number in equation

			printf("\nEnter a second number: ");
			scanf("%d", &operand2); //scans for user's input for second number in equation
		}



		if (numOperation == 1) //if user inputted 1 for addition, then add the two numbers
		{
			total = operand1 + operand2;
		}
		if (numOperation == 2) //if user inputted 2 for subtraction, then subtract the two numbers
		{
			total = operand1 - operand2;
		}
		if (numOperation == 3) //if user inputted 3 for multiplication, then multiply the two numbers
		{
			total = operand1 * operand2;
		}
		if (numOperation == 4) //if user inputted 4 for division, then divide the two numbers
		{
			total = operand1 / operand2;
		}
		if (numOperation == 5)
		{
			printf("\033[H\033[2J"); //ascii code to clear the screen
			printf("\ncCALC Oct 2023 PROGRAM INFORMATION\n");
			printf("----------------------------------\n\n");
			printf("This program will ONLY OUTPUT INTEGERS! Any numbers which don't divide perfectly into each other will round to the nearest whole number.\n\n");
			printf("This program will overflow and give an incorrect answer if the answer is above 46,339^2\n\n");
			printf("This program may bug out and loop if the user's first input is not 1-6 which is an integer. If this happens, make sure to press CTRL+C to kill process.\n\n");
			printf("\n\n\n\n");
			printf("cCalc created by Aidan Lenahan October 2023.\n\n\n\n\n");
		}
		if (numOperation == 1 | numOperation == 2 | numOperation == 3 | numOperation == 4)
		{
			printf("\nThe total is: %d\n", total); //will display the calculated numbers done a few lines above
			printf("\n\n");
		}
	}

	printf("\033[H\033[2J"); //ascii code for clearing the screen
	printf("cCALC created by Aidan Lenahan.\n\n"); 
	return(0); //will throw no error messages, success
}
