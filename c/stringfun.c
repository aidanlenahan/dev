#include <stdio.h>
#include <string.h>

int main(void)
{
	char myString[80];
	int i = 0;


	printf("What is your name? ");
	scanf("%s", myString);



	//this line of code does the same thing as the next two clusters of code
	printf("Hi, %s\n", myString);
	



	for (i = 0; myString[i] != 0; i++)
	{
		putchar(myString[i]);
	}
	putchar('\n');




	for (i = 0; i < strlen(myString); i++)
	{
		putchar(myString[i]);
	}
	putchar('\n');

	printf("\n");
}
