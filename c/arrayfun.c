#include <stdio.h>

int main(void)
{
	int gradeArray[1200];
	int i;
	
	gradeArray[1199] = 64;

	for (i = 0; i < 1200; i++) //zeros out all variables to reset memory
	{
		gradeArray[i] = 0;
	}

	for (i = 0; i < 1200; i++)
	{
		printf("Student %d got a %d\n", i, gradeArray[i]);
	}
}


