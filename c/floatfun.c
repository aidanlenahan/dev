#include <stdio.h>

int main(void)
{
	float jag;

	printf("Please give me a floating point number: ")
	scand("%f", &jag);

	printf("You gave me: %f\n", jag);
}
