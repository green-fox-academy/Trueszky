#include <stdio.h>
#include <stdlib.h>
#include "coordinate.h"

int main()
{
    // Create a struct to store coordinates (for example: int x and int y)
    // Create an array which can store coordinates, do not create multidimensonal arrays here
    // Fill up the coordinates in the array with random number.
    int j;
    int i=0;
    coordinate tomb[10];
    for(j=0;j<10;j++) {
    int r=rand()%99;
        tomb[j].x=r;
    }
    for(j=0;j<10;j++) {
    int r=rand()%99;
        tomb[j].y=r;
    }


    while(i<sizeof(tomb)/sizeof(tomb[0])) {
        printf("x = %.2f   y = %.2f \n",tomb[i].x,tomb[i].y);
        i++;
    }
    return 0;
}
