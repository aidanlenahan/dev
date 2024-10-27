#include <stdio.h>

int main(void)
{
	int gradebookArray2d[1200][10];
	int i;
	int j;

	for (i = 0; i < 1200; i++)
	{
		for (j = 0; j < 10; j ++)
		{
			gradebookArray2d[i][j] = 0;
		}
	}

	//gradebookArray2d[1199][8] = 42;

	for (i = 0; i < 1200; i++)
	{
		printf("%d\t", i);
		for (j = 0; j < 10; j++)
		{
			printf("%d\t", gradebookArray2d[i][j]);
		}
		printf("\n");
	}
}


