#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    // create a function which takes a char array as a parameter,
    // and splits a string to words by space
    // solve the problem with the proper string.h function

    char string[256];
    FILE *path = fopen("Test.txt", "w");
    printf("Type in a sentence:\n\n");
    gets(string);
    fprintf(path,string);
    for (char *p = strtok(string, " "); p != NULL; p = strtok(NULL, " "))
    {
        puts(p);
        fputs(p,path);
    }

    printf("Hello world!\n");
    return 0;
}
