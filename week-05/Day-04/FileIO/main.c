#include <stdio.h>
#include <stdlib.h>

void WriteMultipleLine(FILE *path,char *word,int num);

int main()
{
/*
    // Write a program that opens a file called "my-file.txt", then prints
    // each of lines form the file.
    // You have to create the file, you can use C-programming but it is not mandatory
    FILE *path= fopen("my-file.txt", "w");
    int i,j;
    int abc=97;
    char sztring[49];
    for (i=0;i<9;i++) {
            for (j=i;j<9;j++) {
            fprintf(path,"%c",(char)abc+j);
            }
            fprintf(path,"\n");
    }
    fclose(path);
    path= fopen("my-file.txt", "r");
    while (!feof(path)) {
        fgets(sztring,49,path);
        printf("%s\n",sztring);
    }
    fclose(path);
    printf("\n\n");


    // Write a function that takes a filename as string,
    // then returns the number of lines the file contains.
    // It should return zero if it can't open the file

    int counter=0;
    path= fopen("my-file.txt", "r");
    while (!feof(path))
        {
            fgets(sztring,49, path);
            counter++;
        }
    fclose(path);
    printf("%d\n\n",counter);


    // Open a file called "my-file.txt"
    // Write your name in it as a single line

    path=fopen("my-file.txt","a");
    fprintf(path," Andreas von Germeny");
    fclose(path);
*/
    WriteMultipleLine("fileForMuiltipleLine.txt","Alma",6);
    printf("Hello world!\n");
    return 0;
}
void WriteMultipleLine(FILE *path,char *word,int num)
{
// Create a function that takes 3 parameters: a path, a word and a number,
// than it should write to a file.
// The path parameter should describes the location of the file.
// The word parameter should be a string, that will be written to the file as lines
// The number paramter should describe how many lines the file should have.
// So if the word is "apple" and the number is 5, than it should write 5 lines
// to the file and each line should be "apple"
    int i;
    path=fopen(path,"w");
    for (i=0;i<num;i++)
    {
         fprintf(path,"%s\n",word);
    }
    fclose(path);
}
