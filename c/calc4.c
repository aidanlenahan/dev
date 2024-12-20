//Aidan Lenahan
//Honors CS2
//B4
//10.24.23
//this program will take all floats and either add, subtract, multiply, or divide based on user input, but contradicting to calc2 andcalc3,
//this will take characters such as +, -, *, /, and "e"/"E" for operations instead of taking integers which corresponded to specific operations, and functions will be called for specific operations, instead of having all operations inside of conditionals, all inside the same function
//only different from calc4 due to reprinting of equation before printing total, along with clearing the screen of everything before that except the results

#include <stdio.h>

void printOps() //when called, this prints the available operations
{
	printf("-----------------------\n");
	printf(" +    Add\n");
	printf(" -    Subtract\n");
	printf(" *    Multiply\n");
	printf(" /    Divide\n");
	printf(" i    Program Information\n");
	printf(" e    Exit\n");
	printf("\n\n");
	printf("Enter an operation ( +  -  *  /  i  e ): ");
}
void infoScreen()
{
	printf("\033[H\033[2J"); //ascii code to clear the screen
        printf("\ncCALC 4.1 Oct 2023 PROGRAM INFORMATION\n");
        printf("----------------------------------\n\n");
        printf("This program will ONLY OUTPUT INTEGERS! Any numbers which don't divide perfectly into each other will round to the nearest whole number.\n\n");
        printf("This program will overflow and give an incorrect answer if the answer is above 46,339^2\n\n");
        printf("This program may bug out and loop if the user's first input is not 1-6 which is an integer. If this happens, make sure to press CTRL+C to kill process.\n\n");
        printf("\n");
        printf("Version 4.1, created on October 18th, 2023\n");
	printf("Last edited October 20th, 2023");
	printf("\n\n");
	printf("cCALC 4.1 created by Aidan Lenahan October 2023.\n\n\n\n");
}

//functions to calculate total (NOT USED TO SAVE LINES)
float add(float op1, float op2)
{
	return(op1 + op2);
}

float subtr(float op1, float op2)
{
	return(op1 - op2);
}

float mult(float op1, float op2)
{
	return(op1 * op2);
}

float div(float op1, float op2)
{
	return(op1 / op2);
}

int main(void)
{
	char op = 0;
	char junk; //used for dealing with the 'enter' key ascii; will prevent from getting input from enter key
	float operand1;
	float operand2;
	float total;
	

	printf("\033[H\033[2J"); //ascii code to clear the screen
	printf("\nWelcome to cCALC 4.1!\n\n");

	while (op != 'e' && op != 'E') //will loop as long as user does not enter value equal to e/E (for exit)
	{
		printOps();

		//user input
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
		if (op == '+') //if user inputted '+' for addition, then add the two numbers
		{
			total = add(operand1, operand2);
		}
		if (op == '-') //if user inputted '-' for subtraction, then subtract the two numbers
		{
			total = subtr(operand1, operand2);
		}
		if (op == '*') //if user inputted '*' for multiplication, then multiply the two numbers
		{
			total = mult(operand1, operand2);
		}
		if (op == '/') //if user inputted '/' for division, then divide the two numbers
		{
			total = div(operand1, operand2);
		}
		if (op == 'i' || op == 'I') //program info
		{
			infoScreen();
		}
		if (op != 'e' && op != 'E' && op != 'i') //checking if the user inputted an operation other than exiting or program information
		{
			printf("\033[H\033[2J"); //ascii code for clearing the screen
			printf("\n%f %c %f", operand1, op, operand2); //will print equation once more
			printf("\nThe total is: %f\n", total); //will display the calculated numbers done a few lines above
			printf("\n\n");
		}
	}

	printf("\033[H\033[2J"); //ascii code for clearing the screen
	printf("\ncCALC 3.1 created by Aidan Lenahan.\n\n"); 
	return(0); //will throw no error messages, success
}
