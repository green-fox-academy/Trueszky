#include <stdio.h>
#include <stdlib.h>

void Greet(char al[]);
int Sum(int i);
int Factorial(int i);
void Double(int *i);

int main()
{
    char al[] = "Greenfox";
    Greet(al);

    int i;
    scanf("%i",&i);
    printf("%i\n",Sum(i));

    scanf("%i",&i);
    printf("%i\n",Factorial(i));

    scanf("%i",&i);
    Double(&i);
    printf("%i",i);

    return 0;
}
void Greet(char al[])
{
    // - Create a char array variable named `al` and assign the value `Greenfox` to it
    // - Create a function called `greet` that greets it's input parameter
    //     - Greeting is printing e.g. `Greetings dear, Greenfox`
    // - Greet `al`
    printf("Greetings dear,%s \n\n",al);
}
char AppendA(char al[])
{
    // - Create a char array variable named `am` and assign the value `kuty` to it
    // - Write a function called `appendA` that gets a string as an input,
    //   appends an 'a' character to its end and returns with a string
    // - Print the result of `appendAFunc(am)`
    return ;
}
int Sum(int i)
{
    // - Write a function called `sum` that sum all the numbers
    //   until the given parameter and returns with an integer
    int a=0,j;
    for (j=1;j<=i;j++)
        {
            a+=j;
        }
    return a;
}
int Factorial(int i)
{
    // - Write a function called `sum` that sum all the numbers
    //   until the given parameter and returns with an integer
    int a=1,j;
    for (j=1;j<i;j++)
        {
            a+=a*j;
        }
    return a;
}
void Double(int *i)
{
    // - Create a function called `doubling` that doubles it's input parameter and returns with an integer
    // - parameter should be a pointer to the variable you want to double
    *i*=2;
}
