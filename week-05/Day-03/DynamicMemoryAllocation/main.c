#include <stdio.h>
#include <stdlib.h>

int main()
{
/*
    // with malloc
    // please allocate a 10 long array and fill it with 5!! numbers from 0 to 4, then print the whole array
    // please delete the array before the program exits
    int i;
    int *p = (int *)malloc(10*sizeof(int));
    for (i=0;i<5;i++)
        {
            p[i]=i;
        }
    for (i=0;i<10;i++)
        {
            printf("%d\n",p[i]);
        }


    // with calloc
    // please allocate a 10 long array and fill it with 5!! numbers from 0 to 4, then print the whole array
    // please delete the array before the program exits
    // what's the difference between this and the previous excersice?
    printf("\n\n");
    int *pointer = NULL;
    pointer = (int *)calloc(10,sizeof(10));
    for (i=0;i<5;i++)
        {
            pointer[i]=i;
        }
        for (i=0;i<10;i++)
        {
            printf("%d\n",pointer[i]);
        }
    free(pointer);

    // with malloc
    // please allocate a 10 long array and fill it with even numbers then print the whole array
    // please deallocate memory without using free
        int *p_deallocate = (int *)malloc(10*sizeof(int));
        realloc(p_deallocate, 0);

*/
    // please allocate a 10 long array and fill it with even numbers
    // please allocate a 10 long array and fill it with odd numbers
    // select an array, and push the elements into the another array
    // print it the array in descending order
    // delete the arrays after you don't use them
    int i;
    int *even =(int *)malloc(12*sizeof(int));
    int *odd =(int *)malloc(12*sizeof(int));
    int *temp;

    for (i=0;i<10;i++)
        {
            even[i]=i*2;
        }

    for (i=0;i<10;i++)
        {
            odd[i]=i*2+1;
        }

    temp = even;

    for (i=0;i<10;i++)
        {
            printf("%d\t",temp[i]);
        }
        printf("\n\n");

    even = (int *)realloc(even,20*sizeof(int));

    for (i=0;i<10;i++)
        {
            printf("%d\t",temp[i]);
        }
        printf("\n\n");
    for (i=0;i<20;i++)
        {
            if (i%2==0)
            {
            even[i]=odd[9-i/2];
            }
            else
            {
            even[i]=temp[9-i/2];
            }
        }
    for (i=0;i<20;i++)
        {
            printf("%d\n",even[i]);
        }


    free(even);
    free(odd);
    free(temp);



    return 0;
}

