#include <stdio.h>

void printMenu()
{
	printf("1. Option 1\n");
	printf("2. Another option\n");
	printf("3. So many options!\n");
}

float add(float op1, float op2)
{
	return(op1 + op2);
}

int main(void)
{
	float operand1 = 0;
	float operand2 = 0;
	float total = 0;

	printMenu();	
	printf("Give me a number: ");
	scanf("%f", &operand1);
	printf("Give me a second number: ");
	scanf("%f", &operand2);

	//total = operand1 + operand2
	total = add(operand1, operand2);

	printf("%f + %f = %f\n", operand1, operand2, total);
}
