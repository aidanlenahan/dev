//Aidan Lenahan
//11.27.23
//CS2
//this program is a temporary database (while the program's process is running) that will let user add or change a student's (defined by ID number) grade, print a specified student's grade, print
//all student's grades, or exit 

#include <stdio.h>

void options()
{
	//printf("\033[H\033[2J"); //ascii to clear screen
	printf("\n\n");
	printf("1. Update specific grade\n");
	printf("2. View specific grade\n");
	printf("3. View all grades\n");
	printf("4. Exit\n\n");
	printf("Enter an option: ");
}

int main(void)
{
	int gradeArray2d[1200][10];
	int i;
	int j;
	int gradeID;
	int menuChoice = 0;
	int studentChoice = 0;
	
	printf("\033[H\033[2J"); //ascii to clear screen
	
	printf("Welcome to cGBook!\n");
	printf("All inputs are assumed as perfect.\n");
	printf("The default grade is 0, and there are 1199 available variables to store students' grades\n");

	for (i = 0; i < 1200; i++) //zeros out all variables to reset memory
	{
		for (j = 0; j < 10; j ++)
		{
			gradeArray2d[i][j] = 0;
		}

	}

	while (menuChoice < 4)
	{
		options();
		scanf("%d", &menuChoice);
		printf("\033[H\033[2J"); //ascii to clear screen
		printf("\n");

		if (menuChoice == 1) //prompt user to enter grade for specified student
		{
			printf("Your choice: 1. Update specific grade\n");
			printf("All user inputs are assumed perfect.\n");
			printf("Enter a student ID (0 - 1199): ");
			scanf("%d", &studentChoice);
			
			printf("Enter the assignment ID (0-9): "); //which grade; new addition
			scanf("%d", &gradeID);

			printf("Enter the grade student %d has gotten (1 - 100): ", studentChoice);
			scanf("%d", &gradeArray2d[studentChoice][gradeID]); //updates variable to user input

			printf("Student %d has a %d for assignment %d\n", studentChoice, gradeArray2d[studentChoice][gradeID], gradeID);
		}
		if (menuChoice == 2) //print specific student's grade
		{
			printf("Your choice: 2. View specific grade\n");
			printf("All user inputs are assumed perfect.\n");
                        printf("Enter a student ID (0 - 1199): ");
                        scanf("%d", &studentChoice);

			printf("ID\t0\t1\t2\t3\t4\t5\t6\t7\t8\t9\n");
			printf("---------------------------------------------------------------------------------\n");
                        printf("%d:\t", studentChoice);
			for (j = 0; j < 10; j++)
                        {
                        	printf("%d\t", gradeArray2d[studentChoice][j]);
                        }
		}
		if (menuChoice == 3) //print all grades
		{
			printf("Your choice: 3. View all grades\n\n");
			
			printf("ID\t0\t1\t2\t3\t4\t5\t6\t7\t8\t9\n");
			printf("---------------------------------------------------------------------------------\n");

			for (i = 0; i < 1200; i++) //to print each grade
        		{
				printf("%d\t", i);
				for (j = 0; j < 10; j++)
				{
					printf("%d\t", gradeArray2d[i][j]);
				}
				printf("\n");
			}	
		}
	}
	
	printf("\033[H\033[2J"); //ascii code to clear the screen
	printf("All Rights Reserved, October 2023.\n");
	printf("cGBook made by Aidan Lenahan.\n\n\n");

	return(0);
}


