#include <stdio.h>

int main(void)
{
	int numOperation = 0;
	int operand1;
	int operand2;
	int total;

	while (numOperation < 5)
	{
		printf("\n\n\n\n\n\n\n");
		printf("1. Add\n");
		printf("2. Subtract\n");
		printf("3. Multiply\n");
		printf("4. Divide\n");
		printf("5. Exit\n");
		printf("\n\n");

		printf("Type a number 1 through 5: ");
		scanf("%d", &numOperation);

		if (numOperation != 5)
		{
			printf("\nEnter a number: ");
			scanf("%d", &operand1);

			printf("\nEnter a second number: ");
			scanf("%d", &operand2);
		}



		if (numOperation == 1)
		{
			total = operand1 + operand2;
		}
		if (numOperation == 2)
		{
			total = operand1 - operand2;
		}
		if (numOperation == 3)
		{
			total = operand1 * operand2;
		}
		if (numOperation == 4)
		{
			total = operand1 / operand2;
		}

		printf("\nThe total is: %d\n", total);
		printf("\n\n");
	}

	printf("cCalc created by Aidan Lenahan.");
	printf("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"); 
	return(0);
}
