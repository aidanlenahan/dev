#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, char *argv[]) {
    if (argc != 2) {
        printf("Usage: 0c <filename> OR 0c help\n");
        return 1;
    }

    if (strcmp(argv[1], "help") == 0) {
        printf("\n0sec clang compiler from https://github.com/aidanlenahan/0sec-clang\n");
        printf("- 0c <filename>: Compiles a C file named <filename>.c and creates an executable with the same name.\n");
        printf("- 0c help: Displays this help menu.\n");
        printf("- THIS PROGRAM DEPENDS ON CLANG!\n");
        printf("- To install, run <apt install clang> (with no brackets)\n");
        printf("- Created by Aidan Lenahan, Feb 2024\n");
        return 0;
    }

    char command[200];
    sprintf(command, "clang %s.c -o %s", argv[1], argv[1]);

    system(command);

    printf("Compilation completed.\n");

    return 0;
}

