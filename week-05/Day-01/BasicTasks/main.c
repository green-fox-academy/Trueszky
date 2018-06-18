#include <stdio.h>
#include <stdlib.h>

int main()
{
    // Modify this program to greet you instead of the World!
    printf("Hello Andreas von Germany\n\n");

        // Modify this program to print Humpty Dumpty riddle correctly
    printf("Humpty Dumpty sat on a wall,\n");
    printf("Humpty Dumpty had a great fall.\n");
    printf("All the king's horses and all the king's men\n");
    printf("Couldn't put Humpty together again.\n\n");

      // Greet 3 of your classmates with this program, in three separate lines
    // like:
    //
    // Hello, Esther!
    printf("Hello Esther!\n");
    // Hello, Mary!
    printf("Hello Mary!\n");
    // Hello, Joe!
    printf("Hello Joe!\n\n");

      // Write a program that prints a few details to the terminal window about you
        // It should print each detail to a new line.
        //  - Your name
        char name[]="Andreas von Germany";
        //  - Your age
        int age = 27;
        //  - Your height in meters (as a decimal fraction)
        float height = 1.82;
        //
        //  Example output:
        //  John Doe
        //  31
        //  1.87
        printf("%s\n", name);
        printf("%d\n", age);
        printf("%.2f\n\n", height);

        // Create a program that prints a few operations on two numbers: 22 and 13
        int a=22;
        int b=13;
        int var;
        // Print the result of 13 added to 22
        printf("%d \n",var=a+b);
        // Print the result of 13 substracted from 22
        printf("%d \n",var=a-b);
        // Print the result of 22 multiplied by 13
        printf("%d \n",var=a*b);
        // Print the result of 22 divided by 13 (as a decimal fraction)
        printf("%d \n",var=a/b);
        // Print the reminder of 22 divided by 13
        printf("%d \n\n",var=a%b);

        // An average Green Fox attendee codes 6 hours daily
        // The semester is 17 weeks long
        float precent;
        // Print how many hours is spent with coding in a semester by an attendee,
        // if the attendee only codes on workdays.
        var = 5*17*6;
        printf("%d \n", var);
        // Print the percentage of the coding hours in the semester if the average
        // work hours weekly is 52
        precent=5*6*100/52;
        printf("%.2f %%\n\n",precent);



    return 0;
}
