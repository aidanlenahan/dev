#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>
#include <ctype.h>

int main() {
    int length;
    char charset[128];
    char choice;

    // Seed the random number generator
    srand(time(NULL));

    // Prompt for string length (validating input)
    do {
        printf("Enter the desired string length (between 1 and 4096): ");
        scanf("%d", &length);
    } while (length < 1 || length > 4096);

    // Explain character set options
    printf("\nCharacter set options:\n");
    printf("L: Uppercase letters only\n");
    printf("l: Lowercase letters only\n");
    printf("n: Numbers only\n");
    printf("N: Special characters only\n");
    printf("a or A: All characters\n");
    printf("Custom combination of L, l, N, n (e.g., Nl for special and lowercase)\n");
    printf("C or c: Custom set of characters\n");

    // Prompt for character set choice
    do {
        printf("\nChoose your character set: ");
        scanf(" %c", &choice);
        choice = tolower(choice); // Convert to lowercase for easier comparison

        switch (choice) {
            case 'l':
                strcpy(charset, "abcdefghijklmnopqrstuvwxyz");
                break;
            case 'n':
                strcpy(charset, "1234567890");
                break;
            case 'u':
                strcpy(charset, "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
                break;
            case 's':
                strcpy(charset, "!@#$%^&*()-=_+~[]\\{}|<>?,./\"\':;");
                break;
            case 'a':
                strcpy(charset, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-=_+~[]\\{}|<>?,./\"\':;");
                break;
            case 'c':
                printf("Enter your custom character set: ");
                scanf(" %[^\n]", charset); // Read up to newline
                break;
            default:
                printf("Invalid choice. Please try again.\n");
        }
    } while (choice != 'l' && choice != 'n' && choice != 'u' && choice != 's' && choice != 'a' && choice != 'c');

    // Generate the random string
    char string[length + 1];
    for (int i = 0; i < length; i++) {
        int index = rand() % strlen(charset);
        string[i] = charset[index];
    }
    string[length] = '\0'; // Null-terminate the string

    printf("\nGenerated random string: %s\n", string);

    return 0;
}

