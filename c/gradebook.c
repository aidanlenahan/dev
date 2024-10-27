//Aidan Lenahan
//11.1.23
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
	int amount = 1200; //defines the amount of students
	int gradeArray[amount]; //creates specified amount of seperate items within gradeArray array which store the students' grades
	int i;
	int menuChoice = 0;
	int specificStudentChoice = 0;
	
	printf("\033[H\033[2J"); //ascii to clear screen
	
	printf("Welcome to cGBook!\n");
	printf("All inputs are assumed as perfect.\n");
	printf("The default grade is 0, and there are 1199 available variables to store students' grades\n");

	for (i = 0; i < amount; i++) //zeros out all variables to reset memory
	{
		gradeArray[i] = 0;
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
			scanf("%d", &specificStudentChoice);
			
			printf("Enter the grade student %d has gotten (1 - 100): ", specificStudentChoice);
			scanf("%d", &gradeArray[specificStudentChoice]); //updates variable to user input

			printf("Student %d has a %d\n", specificStudentChoice, gradeArray[specificStudentChoice]);
		}
		if (menuChoice == 2) //print specific student's grade
		{
			printf("Your choice: 2. View specific grade\n");
			printf("All user inputs are assumed perfect. (Must be an INTEGER!)\n");
                        printf("Enter a student ID (0 - 1199): ");
                        scanf("%d", &specificStudentChoice);

                        printf("Student %d has a %d\n", specificStudentChoice, gradeArray[specificStudentChoice]);
		}
		if (menuChoice == 3) //print all grades
		{
			printf("Your choice: 3. View all grades\n\n");
			printf("Student ID	Grade\n");
			for (i = 0; i < amount; i++) //to print all grade
        		{
				printf("Student %d	   %d\n", i, gradeArray[i]);
        		}	
		}
	}
	
	printf("\033[H\033[2J"); //ascii code to clear screen
	printf("All Rights Reserved, October 2023.\n");
	printf("cGBook made by Aidan Lenahan.\n\n\n");

	return(0);
}


