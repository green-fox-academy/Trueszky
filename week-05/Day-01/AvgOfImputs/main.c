#include <stdio.h>
#include <stdlib.h>

int main()
{
    // Write a program that asks for 5 integers in a row,
    // then it should print the sum and the average of these numbers like:
    //
    // Sum: 22, Average: 4.4
    float temp,a,b=0;
    printf("Give me 5 numbers: ");
    while(b<=4)
        {
            scanf("%f",&temp);
            a+=temp;
            b++;
        }
    printf("Sum: %.0f  Average: %.1f ",a ,a/b);
}
