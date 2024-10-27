//Aidan Lenahan
//Honors CS2
//B4
//10.18.23
//this program will take all floats and either add, subtract, multiply, or divide based on user input, but contradicting to calc2, this will take characters such as +, -, *, /, and "e"/"E" for operations

#include <stdio.h>

int main(void)
{
	char op = 0;
	char junk; //used for dealing with the 'enter' key ascii; will prevent from getting input from enter key
	float operand1;
	float operand2;
	float total;
	

	printf("\033[H\033[2J"); //ascii code to clear the screen
	printf("\nWelcome to cCALC!\n\n");

	while (op != 'e' && op != 'E') //will loop as long as user does not enter value equal to e/E (for exit)
	{
		printf("-----------------------\n");
		printf(" +    Add\n");
		printf(" -    Subtract\n");
		printf(" *    Multiply\n");
		printf(" /    Divide\n");
		printf(" i    Program Information\n");
		printf(" e    Exit\n");
		printf("\n\n");


		//user input
		printf("Enter an operation ( +  -  *  /  i  e ): ");
		op = getchar(); //will scan for user input and then save it to a variable called op
		junk = getchar(); //dealing with enter ascii

		if (op != 'e' && op != 'E' && op != 'i') //code says that if user does not enter e/E (to exit), the code will ask and search for both operands needed to perform the calculation
		{
			printf("\nEnter a number: ");
			scanf("%f", &operand1); //scans for user's input for first number in equation
			
			printf("\nEnter a second number: ");
			scanf("%f", &operand2); //scans for user's input for second number in equation
			junk = getchar();
		}



		//conditionals for determining operation to ultimately output the answer
		if (op == '+') //if user inputted + for addition, then add the two numbers
		{
			total = operand1 + operand2;
		}
		if (op == '-') //if user inputted - for subtraction, then subtract the two numbers
		{
			total = operand1 - operand2;
		}
		if (op == '*') //if user inputted * for multiplication, then multiply the two numbers
		{
			total = operand1 * operand2;
		}
		if (op == '/') //if user inputted / for division, then divide the two numbers
		{
			total = operand1 / operand2;
		}
		//program info display
		if (op == 'i')
		{
			printf("\033[H\033[2J"); //ascii code to clear the screen
			printf("\ncCALC 3.1 Oct 2023 PROGRAM INFORMATION\n");
			printf("----------------------------------\n\n");
			printf("This program will ONLY OUTPUT INTEGERS! Any numbers which don't divide perfectly into each other will round to the nearest whole number.\n\n");
			printf("This program will overflow and give an incorrect answer if the answer is above 46,339^2\n\n");
			printf("This program may bug out and loop if the user's first input is not 1-6 which is an integer. If this happens, make sure to press CTRL+C to kill process.\n\n");
			printf("\n");
			printf("Version 3.1, created on October 18th, 2023\n");
			printf("Last edited October 20th, 2023");
			printf("\n\n");
			printf("cCALC 3.1 created by Aidan Lenahan October 2023.\n\n\n\n\n"); 
		}

		if (op == '+' || op == '-' || op == '*' || op == '/')
		{
			printf("\n%f %c %f = %f\n", operand1,op,operand1,total); //will display the calculated numbers done a few lines above
			printf("The total is %f\n", total);
			printf("\n\n");
		}
	}

	printf("\033[H\033[2J"); //ascii code for clearing the screen
	printf("\ncCALC 3.1 created by Aidan Lenahan.\n\n"); 
	return(0); //will throw no error messages, success
}
