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

    return 0;
}
