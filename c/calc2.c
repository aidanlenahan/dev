//Aidan Lenahan
//Honors CS2
//B4
//10.16.23
//this program will take all floats and either add, subtract, multiply, or divide based on user input

#include <stdio.h>

int main(void)
{
	int numOperation = 0;
	float operand1;
	float operand2;
	float total;

	printf("\033[H\033[2J"); //ascii code to clear the screen
	printf("\nWelcome to cCALC!\n\n");

	while (numOperation < 5) //will loop as long as user does not enter value greater than 4
	{
		printf("-----------------------\n");
		printf("1. Add\n");
		printf("2. Subtract\n");
		printf("3. Multiply\n");
		printf("4. Divide\n");
		printf("5. Exit\n");
		printf("\n\n");

		printf("Type a number 1 through 5: ");
		scanf("%d", &numOperation); //will scan for user input and then save it to a variable called numOperation

		if (numOperation != 5) //code says that if user does not press 5 (to exit), the code will ask and search for both numbers needed to perform the calculation
		{
			printf("\nEnter a number: ");
			scanf("%f", &operand1); //scans for user's input for first number in equation

			printf("\nEnter a second number: ");
			scanf("%f", &operand2); //scans for user's input for second number in equation
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

		if (numOperation == 1 | numOperation == 2 | numOperation == 3 | numOperation == 4)
		{
			printf("\nThe total is: %f\n", total); //will display the calculated numbers done a few lines above
			printf("\n\n");
		}
	}

	printf("\033[H\033[2J"); //ascii code for clearing the screen
	printf("\ncCalc created by Aidan Lenahan.\n\n"); 
	return(0); //will throw no error messages, success
}
