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
    coordinate tomb[15];
    for(j=0;j<sizeof(tomb)/sizeof(tomb[0]);j++) {
        tomb[j].x=rand()%99;;
        tomb[j].y=rand()%99;;
    }


    while(i<sizeof(tomb)/sizeof(tomb[0])) {
        printf("x = %.2f   y = %.2f \n",tomb[i].x,tomb[i].y);
        i++;
    }
    return 0;
}
