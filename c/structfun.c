// structure - multiple data types in one array/var

#include <stdio.h>

struct Student
{
	char fname[80];
	char lname[80];
	float gpa;
	int grade;
	int studentID;
};

int main(void)
{
	struct Student theStudent;
	struct Student theStudentDB[1200];
	
	printf("What is the student's ID? ");
	scanf("%d", &theStudent.studentID);

	printf("What is the student's first name? ");
	fgets(theStudent.fname, 80, stdin); //structure/database and specific data point within, will check if 80 char, stdin=standard input
	printf("The first name is : %s\n", theStudent.fname);

	printf("What is their GPA? ");
	scanf("%f", &theStudent.gpa);
	//fgets(theStudent.gpa

	printf("Their GPA is: %f\n", theStudent.gpa);

	return(0);
}
