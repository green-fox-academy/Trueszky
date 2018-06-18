#include <stdio.h>
#include <stdlib.h>

int main()
{
    // Write a program that asks for two integers
    // The first represents the number of chickens the farmer has
    // The second represents the number of pigs owned by the farmer
    // It should print how many legs all the animals have
    float a,b;
    printf("Give me two number: ");
    scanf("%f %f",&a, &b);
    printf("%.1f",a*2+b*4 );

    return 0;
}


