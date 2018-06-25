#include <stdio.h>
#include <stdlib.h>
#include "cartypes.h"

void carinfo(car type);

int main()
{

    // Write a function that takes a car as an argument and prints all it's stats
    // If the car is a Tesla it should not print it's gas level
    car s1;
    s1.type = TOYOTA;
    s1.gas = 50;
    s1.km = 100;
    carinfo(s1);

    printf("Hello world!\n");
    return 0;
}
void carinfo(car item)
{
    if(item.type == TESLA) {
        printf("%.2fkm and electric \n",item.km);
    }
    else {
        printf("%.2fkm and %.2f l \n",item.km,item.gas);
    }
}
