//Aidan Lenahan
//CS2
//11.13.23
//This program will take a single word from the user and reverse it and print it out

#include <stdio.h>
#include <string.h>

int main(void)
{
	char theWord[80];
	int i = 0;

	printf("\033[H\033[2J");
	printf("Welcome to BackWORDS Generator 1.0!\n");
	printf("-----------------------------------\n");
	printf("What is the one word you want backwards?\n");
	scanf("%s", theWord);

	printf("BackWORD: ");
	for (i = strlen(theWord) - 1; i >= 0; i--) //i equals the length of theWord, and while i is greater than or equal to zero, repeat the following, then subtract i by one
	{
		putchar(theWord[i]);
	}
	putchar('\n');

	printf("\n");

	return 0;
}
