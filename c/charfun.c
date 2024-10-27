#include <stdio.h>

int main(void)
{
	char theChar;
	char junk;

	printf("Please give me a car: ");
	theChar = getchar();
	junk = getchar();

	printf("You gave me: %c\n", theChar);

	if (theChar == 'A')
	{
		printf("A is for Aidan!\n");
	}


	printf("Please give me another car: ");
	theChar = getchar();
	junk = getchar();
		
	printf("Thank you for: %c\n", theChar);


	return(0);
}
