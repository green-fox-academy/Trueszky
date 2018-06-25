#include <stdio.h>
#include <string.h>
#include "sandwich.h"

float price(sandwich type,int volume);

int main()
{

    /*
    Create a sandwich struct
    It should store:
     - name
     - price (float)
     - weight (float)
    Create a function which takes two parameters and returns the price of your order.
    The parameters should be:
     - a sandwich struct
     - and an integer that represents how many sandwiches you want to order
    */
    sandwich s1;
    strcpy(s1.name,"FineSchandWitch");
    s1.price = 0.99;
    s1.weight= 0.25;
    printf("It will cost u %.2f for the %s's  and would " ,price(s1,5),s1.name);


    printf("Hello world!\n");
    return 0;
}

float price(sandwich type,int volume)
{
   return type.price*volume;
}
