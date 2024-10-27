//Aidan Lenahan
//Honors CS2
//B4
//10.18.23
//this program will take all floats and either add, subtract, multiply, or divide based on user input, but contradicting to calc2, this will take characters such as +, -, *, /, and "e"/"E" for operations

//NOTE: I WANT TO SWITCH OPERATION QUESTION AND OPERAND WHERE OPERAND QUESTION COMES FIRST
//WORK IN PROGRESS, WILL NOT WORK!!


#include <stdio.h>

void progInfo() {
        printf("\033[H\033[2J"); //ascii code to clear the screen
        printf("\ncCALC 3.1 Oct 2023 PROGRAM INFORMATION\n");
        printf("----------------------------------\n\n");
        printf("This program will ONLY OUTPUT INTEGERS! Any numbers which don't divide perfectly into each other will round to the nearest whole number.\n\n");
        printf("This program will overflow and give an incorrect answer if the answer is above 46,339^2\n\n");
        printf("This program may bug out and loop if the user's first input is not 1-6 which is an integer. If this happens, make sure to press CTRL+C to kill process.");
        printf("\n\n\n");
        printf("Version 3.1, created on October 18th, 2023\n");
        printf("Last edited October 20th, 2023");
        printf("\n\n");
        printf("cCALC 3.1 created by Aidan Lenahan October 2023.\n\n\n\n\n");
}
        



int main(void)
{
	char op;
	char junk; //used for dealing with the 'enter' key ascii; will prevent from getting input from enter key
	char div0 = 'n'; //used for if user tries to divide by zero, no by default
	char pre;
	float operand1;
	float operand2;
	float total;
	

	printf("\033[H\033[2J"); //ascii code to clear the screen
	printf("\nWelcome to cCALC!\n\n");

		
	while (op != 'e' || op != 'E' || pre != 'e' || pre != 'E')
	{
		printf("-----------------------\n");
		printf(" i    Program Information\n");
		printf(" e    Exit\n\n");
		printf("Enter i for Program Information, e to exit, or any other key to continue: ");
		
		pre = getchar();
		printf("\n\n\n");
		
		if (pre == 'i')
		{
			progInfo();
		}
		else //code says that if user does not enter e/E (to exit), the code will ask and search for both operands needed to perform the calculation
		{
			printf("\033[H\033[2J"); //ascii code to clear the screen
			printf("\ncCALC 3.1\n");
			printf("----------\n\n");
			
			printf("\nEnter a number: ");
                        scanf("%f", &operand1); //scans for user's input for first number in equation

			printf("\n\nAvailable operations/options:\n");
			printf(" +    Add\n");
               		printf(" -    Subtract\n");
               		printf(" *    Multiply\n");
               		printf(" /    Divide\n");
               		printf(" i    Program Information\n");
                	printf(" e    Exit\n");
	       		printf("\n\n");	
			
			
			printf("Enter an option: ");
			op = getchar();
			junk = getchar();
			printf("\n\n");

			if (op == 'i' || op == 'I')
			{
				progInfo();
			}
			else if (op != 'i' && op != 'I' && op != 'e' && op != 'E')
			{
				printf("\nEnter a second number: ");
				printf("\n%f %c ", operand1,op);
				scanf("%f", &operand2); //scans for user's input for second number in equation
				junk = getchar();
				printf("\n\n");


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
					if (operand2 == 0)
					{
						printf("Cannot divide by zero!\n\n");
						div0 = 'y';
					}
					else
					{
						total = operand1 / operand2;
						div0 = 'n';
					}
				}
				//program info display
				if (op == 'i') 
				{
					progInfo();
				}

				if (div0 == 'y' && op == '+' || op == '-' || op == '*' || op == '/')
				{
					printf("\n%f %c %f = %f\n", operand1,op,operand1,total); //will display the calculated numbers done a few lines above
					printf("The total is %f\n", total);
					printf("\n\n");
				}
			}
		}
	}

	printf("\033[H\033[2J"); //ascii code for clearing the screen
	printf("\ncCALC 3.1 created by Aidan Lenahan.\n\n"); 
	return(0); //will throw no error messages, success
}
