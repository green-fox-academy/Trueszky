#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    // create a function which takes a char array as a parameter,
    // and splits a string to words by space
    // solve the problem with the proper string.h function
/*
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
*/

    // create a function which takes a char array as a parameter and
    // lists all position where character 'i' is found

    char string[55] = "This is a string for testing";
    char *p;

    printf("Hello world!\n");
    return 0;
}
void icounter(char *string)
{
    for (char *p = strtok(sentence, " "); p != NULL; p = strtok(NULL, "i"))

}
