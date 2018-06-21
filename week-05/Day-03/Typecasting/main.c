#include <stdio.h>
#include <stdlib.h>

int main()
{

    // Modifiy this program to print out the number we want
    printf("%c\n",(char)65);



    // fix the program so it prints out the correct result!
    int seconds = 17;
    int DISTANCE= 999;
    float speed = DISTANCE / seconds;

    printf("%f\n", (float)speed);


    // print out the ascii values of the array
    int i;
    int array[] = { 103, 114, 101, 101, 110, 32, 102, 111, 120};
    for (i=0;i<sizeof(array)/sizeof(array[0]);i++)
        {
            printf("%c",(char)array[i]);
        }
    printf("\n");

    printf("Hello world!\n");
    return 0;
}
