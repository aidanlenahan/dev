//Aidan Lenahan
//A4 CS2 
//this program is a student databse where the user can enter an ID, name, grade level, and gpa
//then a user can open the database for the specific student and find their information about these topics

#include <stdio.h>
#include <unistd.h>

struct Student
{
	char fname[80];
	char lname[80];
	int grade;
	float gpa;
};

int main(void)
{
	struct Student theStudent[1200];
	int action = 0;
	char junk;
	int id;
	
	while (action < 3)
	{
		printf("Welcome to the Student Database\n");
		printf("1 - Enter Student\n");
		printf("2 - Print Student \n");
		printf("3 - Exit\n");

		printf("Enter action: ");
		scanf("%d", &action);
		sleep(1);
		printf("\033[H\033[2J");

		if (action == 1)
		{
			printf("Enter Student ID: ");
			scanf("%d", &id);
			junk = getchar();

			printf("Enter Student First Name: ");
			fgets(theStudent[id].fname, 80, stdin);

			printf("Enter Students Last Name: ");
			fgets(theStudent[id].lname, 80, stdin);

			printf("Enter Students Grade Level: ");
			scanf("%d", &theStudent[id].grade);

			printf("Enter the student's GPA: ");
			scanf("%f", &theStudent[id].gpa);

			printf("\033[H\033[2J");
		}
		else if(action == 2)
		{
			printf("Enter Student ID: ");
			scanf("%d", &id);

			printf("The student's first name is %s\n", theStudent[id].fname);

			printf("The student's last name is %s\n", theStudent[id].lname);

			printf("The student's grade level is %d\n", theStudent[id].grade);

			printf("The student's GPA is %f\n", theStudent[id].gpa);
		}
	}
	printf("\n\nCome again!\n");
	sleep(3);
	printf("\033[H\033[2J");
} 
