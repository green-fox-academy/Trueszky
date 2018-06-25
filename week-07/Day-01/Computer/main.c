#include <stdio.h>
#include <stdlib.h>
#include "Computers.h"
//#include "Computers.c"


// Use the Computer struct, give values to the fields and print them out in the main!
// Use the Notebook struct, give values to the fields and print them out in the main!

int main()
{
    Computer pcmaster;
    pcmaster.bits = 99;
    pcmaster.cpu_speed_GHz = 144;
    pcmaster.ram_size_GB = 4;
    printf("Computer has bits of %d and speed of %.2fMHz with a memory value of %iGB\n",pcmaster.bits,
                                                                                      pcmaster.cpu_speed_GHz,
                                                                                      pcmaster.ram_size_GB);


    Notebook macbad;
    macbad.bits = 1;
    macbad.cpu_speed_GHz = 8;
    macbad.ram_size_GB= 2;
    printf("Notebook has bits of %d and speed of %.2fMHz with a memory value of %iGB\n",macbad.bits,
                                                                                      macbad.cpu_speed_GHz,
                                                                                      macbad.ram_size_GB);



    printf("Hello world!\n");
    return 0;
}
