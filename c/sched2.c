/* Aidan Lenahan
 * Honors CS 2
 * Block 4B
 * 9/20/2023
 *
 * The program gets your input if whether you want to see the normal RBR bell schedule, delayed opening schedule, or the half day schedule*/

#include <stdio.h>

int main(void) 
{
        int schedule;

        printf("\n\nWelcome to the RBR Bell Schedule viewer!");
	printf("\n\nWhich RBR schedule would you like to view?");
        printf("\nPress 1 to view RBR Regular Bell Schedule, press 2 for the RBR half day opening schedule, and press 3 for the RBR");
	printf(" delayed opening schedule.");
	printf("\n\nType 1, 2, or 3, then press enter: ");

	scanf("%d", &schedule);

        if (schedule == 1)
        {
        	printf("\n\nRBR Regular Bell Schedule\n");
        	printf("Block 1: 7:35am - 8:57am\n");
        	printf("Block 2: 9:01am - 10:23am\n");
        	printf("Mod 1 Lunch: 10:27am - 11:02am\n");
        	printf("Mod 2 Study Hall 11:04am - 11:39am\n");
        	printf("Block 3: 11:43am - 1:05pm\n");
        	printf("Block 4: 1:09pm - 2:31pm\n\n");
        }
        if (schedule == 2)
        {	
        	printf("\n\nRBR Half Day Schedule\n");
        	printf("Block 1: 7:35am - 8:31am\n");
        	printf("Block 2: 8:35am - 9:31am\n");
        	printf("Block 3: 9:35am - 10:31am\n");
        	printf("Block 4: 10:35am - 11:35am\n\n");
        }
        if (schedule == 3)
        {
        	printf("\nRBR Delayed Opening Schedule\n");
        	printf("Block 1: 9:35am - 10:27am\n");
        	printf("Block 2: 10:31am - 11:23am\n");
        	printf("Mod 1 Lunch: 11:27am - 12:02pm\n");
        	printf("Mod 2 Study Hall 12:04pm - 12:39pm\n");
        	printf("Block 3: 12:43pm - 1:35pm\n");
        	printf("Block 4: 1:39pm - 2:31pm\n\n");
        }

 	printf("\nProgram created by Aidan Lenahan.\n\n");
	return 0;
}
