#include <stdio.h>
#include <stdlib.h>

int main()
{




    int number = 1234;
    int *number_pointer = &number;

    // print the memory address of the variable
    printf("%p \n\n",&number);

    // print the value of number using the "number_pointer"
    printf("%i \n\n",*number_pointer);

    // update the value of number variable to 42 using the "number_pointer"
    *number_pointer = 42;
    printf("%i \n\n",number);


    //Add two numbers using pointers

    int a = 20;
    int b = 17;
    int *pa=&a,*pb=&b;
    printf("%i \n\n",*pa+*pb);


    //Print out the addresses with and without pointer
    //print out the values with and without pointer

    int number2 = 2017;
    float Pi = 3.14;
    char letter = 't';
    int *pNumber2=&number2;
    float *pPi=&Pi;
    char *pLetter =&letter;
    printf("\t\t WithoutP\tWithP\n");

    printf("Address:\t%p\t%p\n",pNumber2,&number2);
    printf("Address:\t%p\t%p\n",pPi,&Pi);
    printf("Address:\t%p\t%p\n",pLetter,&letter);

    printf("Values\t\tWithoutP\tWithP\n");

    printf("Address:\t%i\t%i\n",*pNumber2,number2);
    printf("Address:\t%f\t%f\n",*pPi,Pi);
    printf("Address:\t%c\t%c\n\n",*pLetter,letter);



    // The "other_high_number_pointer" should point to the same memory address
    // without using the "&" operator.

    int high_number = 6655;
    int low_number = 2;

    int *hight_number_pointer = &high_number;
    int *other_hight_number_pointer;
    other_hight_number_pointer=hight_number_pointer;
    printf("%p\n",hight_number_pointer);



    return 0;
}
