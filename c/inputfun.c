#include <stdio.h>

int main(void)
{
	int age;

	printf("How old are you? ");
	scanf("%d", &age);

	printf("Wow, you are %d years old!\n", age);

	if (age > 18)
	{
		printf("OLDIEEEE\n\n");
	}
	else if (age < 18)
	{
		printf("Haha you can't vote!!!!\n");
	}
	else
	{
		printf("Welcome to adulthood\n");
	}

}
