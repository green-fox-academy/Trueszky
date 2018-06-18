#include <stdio.h>
#include <stdlib.h>

int main()
{
    // Write a program that asks for two numbers and prints the bigger one
    float a,b;
    printf("Give me two numbers a decide which is bigger $$$ !\n");
    scanf("%f %f",&a,&b);
    if (a==b)
        {
            printf("They Are The same u fool!");
        }
    else if (a<b)
        {
            printf("The %.0f is bigger then the other one.",b);
        }
    else
        {
            printf("The %.0f is bigger then the other one.",a);
        }
    return 0;
}
