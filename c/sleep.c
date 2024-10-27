#include <stdio.h>
#include <unistd.h>

int main(void)
{
    printf("This is printed immediately.\n");

    // Delay for 3 seconds
    sleep(3);

    printf("This is printed after a 3-second delay.\n");

    return 0;
}

