# Expressions and Control Flow
Get into *C programming*, installing a development environment and then running our first programs.

## Materials & Resources
### Environment
- Make sure that *Code::Blocks or any other C IDE* is installed on your machine

| Material | Time |
|:---------|-----:|
|[C](https://en.wikipedia.org/wiki/C_(programming_language))|-|
|[Code::Blocks Download Link](http://www.codeblocks.org/downloads)|-|
|[Setting Up Code::Blocks](https://www.youtube.com/watch?v=3DeLiClDd04)|6:37|

### Materials

| Material | Time |
|:---------|-----:|
|[Compiling a program](https://courses.cs.washington.edu/courses/cse378/97au/help/compilation.html)|-|
|[Print text to the console](https://www.youtube.com/watch?v=oSpmApiUsHw)|3:32|
|[Get input from the console](https://www.youtube.com/watch?v=hSHFjPvqFjw)|7:37|
|[Format specifiers](https://www.w3schools.in/c-tutorial/format-specifiers/)|-|
|[Basic data types](https://os.mbed.com/handbook/C-Data-Types)|-|
|[Constants](https://www.w3schools.in/c-tutorial/constants/)|-|
|[Keywords](https://www.w3schools.in/c-tutorial/keywords/)|-|
|[Operators](https://www.w3schools.in/c-tutorial/operators/)|-|
|[Switch statement](https://www.youtube.com/watch?v=qZRP5hKGHrs)|7:30|
|[For loop](https://www.youtube.com/watch?v=FPjLbPu5BsQ)|5:19|
|[While loop](https://www.youtube.com/watch?v=7pAXm7WEA2I)|8:28|
|[Do while loop](https://www.youtube.com/watch?v=eU6no0EEJM0)|10:42|
|[If statement](https://www.youtube.com/watch?v=PXwWoL0IG5A)|7:53|
|[Nesting if statement](https://www.youtube.com/watch?v=FtZ1YgSFqs0)|4:45|

## Optional materials
| Material | Time |
|:---------|-----:|

## Material Review
- how compilation works
  - preprocessor
  - compiler
  - assembler
  - linker
- printf basics
- comments
- variables
  - keywords
  - datatype
    - void, int, float, double, char
    - unsigned int and char
    - char, short, int, longlong
    - why do we use instead stdint.h types
       - `int8_t`, `int16_t`, `int32_t`, `int64_t`
       - `uint8_t`, `uint16_t`, `uint32_t`, `uint64_t`
  - constants
  - literals
    - integers
    - binary (0b011)
    - hexadecimal (0xFF)
    - floats (0.125f) vs. double (0.125)
- switch
- while loop
- do while loop
- for loop
- conditions
- math operators
  - `+`, `-`, `*`, `/`, `%`
  - `--i`/`++i` and `i--`/`i++`
  - `+=`, `-=`, `*=`, `/=`
- logical operators
  - `==`, `>`, `>=`, `<`, `<=`, `!=`
  - `&&`, `||`, `!`
  - no boolean datatype by deafult

## Workshop

💪: If you see this emoji, it means that you can skip the exercise if you are
in lack of time. You can practice with these exercises later to deepen your
knowledge (or to prepare for the exam).

#### Hello World
```cpp
#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Hello world!\n");
    return 0;
}
```

#### Exercises
 -  [hello_me](hello-me/hello_me.c)
 -  [humpty_dumpty](humpty-dumpty/humpty_dumpty.c)
 -  [hello_others](hello-others/hello_others.c)

#### Print values with different types
```cpp
#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Hello\n");
    printf("%d\n", 43);
    printf("%.2f\n", 12.71);
    return 0;
}
```

#### Number Operations
```cpp
#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("%d\n", 2 + 4);
    printf("%d\n", 9 - 7);
    printf("%d\n", 2 * 5);
    printf("%d\n", 6 / 2);
    printf("%d\n", 7 % 2);
    printf("%.2f\n", 7 / 2.0);
    return 0;
}
```

#### Exercises
 -  [introduce_yourself](introduce-yourself/introduce_yourself.c)
 -  [two_numbers](two-numbers/two_numbers.c)
 -  [coding_hours](coding-hours/coding_hours.c)

#### Creating different variables for each type
```cpp
#include <stdio.h>
#include <stdlib.h>

int main()
{
    // char
    char letter = 'g';
    printf("%c\n", letter);

    // whole number
    int a = 23;
    printf("%d\n", a);

    // floating point number
    float pi = 3.14;
    printf("%.2f\n", pi);

    // declaring a variable
    int number;

    // assigning a variable, (define its value)
    number = 12;

    // mutate a variable, (redefine its value)
    number = 23;

    return 0;
}
```

#### Arithmetic Assignment Operators
```cpp
#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a = 12;
    a += 4;
    // prints 16
    printf("%d\n", a);

    int b = 12;
    b -= 4;
    // prints 8
    printf("%d\n", b);

    int c = 12;
    // prints 12
    printf("%d\n", c++);
    // prints 13
    printf("%d\n", c);

    int d = 12;
    // prints 13
    printf("%d\n", ++d);
     // prints 13
    printf("%d\n", d);

    int e = 12;
    // prints 12
    printf("%d\n", e--);
    // prints 11
    printf("%d\n", e);

    int f = 12;
    // prints 11
    printf("%d\n", --f);
     // prints 11
    printf("%d\n", f);

    int g = 12;
    g *= 3;
    // prints 36
    printf("%d\n", g);

    int h = 12;
    h /= 3;
    // prints 4
    printf("%d\n", h);

    int i = 12;
    i %= 7;
    // prints 5
    printf("%d\n", i);

    return 0;
}
```

#### Exercises
 -  [FavoriteNumber](favorite-number/favorite_number.c)
 -  [Swap](swap/swap.c)
 -  [Bmi 💪](bmi/bmi.c)
 -  [DefineBasicInfo](define-basic-info/define_basic_info.c)
 -  [VariableMutation](variable-mutation/variable_mutation.c)
 -  [Cuboid 💪](cuboid/cuboid.c)
 -  [SecondsInADay](seconds-in-a-day/Seconds_in_a_day.c)

#### User input (scanner)

```cpp
#include <stdio.h>
#include <stdlib.h>

int main()
{
    int age;
    printf("Hello user, how old are you?\n");
    scanf("%d", &age);

    printf("%d is a nice age", age);

    return 0;
}
```

#### Exercises
 -  [hello_user](hello-user/hello_user.c)
 -  [mile_to_km](mile-to-km-converter/mile_to_km.c)
 -  [animals_and_legs 💪](animals-and-legs/animals_and_legs.c)
 -  [average_of_input 💪](average-of-input/average_of_input.c)

#### Conditionals
```cpp
#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a = 13;

    if (a == 13)
    {
        // this block will run
        printf("Yaaay! The value of the \"a\" variable is 13\n");
    }

    if (a == 8)
    {
        // this block will NOT run
        printf("Yaaay! The value of the \"a\" variable is 8\n");
    }


    int b = 20;

    if (b < 10)
    {
        // this block will NOT run
        printf("Yaaay! The value of the \"b\" variable is lower than 10\n");
    }
    else
    {
        // this block will run
        printf("Yaaay! The value of the \"b\" variable is higher than 10\n");
    }


    int c = 15;

    if (c < 10)
    {
        // this block will NOT run
        printf("Yaaay! The value of the \"b\" variable is lower than 10\n");
    }
    else if (c < 20)
    {
        // this block will run
        printf("Yaaay! The value of the \"b\" variable is higher than 10 but less then 20\n");
    }
    else
    {
        // this block will NOT run
        printf("Yaaay! The value of the \"b\" variable is higher than 10\n");
    }

    return 0;
}
```

#### Exercises
 -  [odd_even](odd-even/odd_even.c)
 -  [one_two_a_lot](one-two-a-lot/one_two_a_lot.c)
 -  [print_bigger 💪](print-bigger/Print_bigger.c)
 -  [party_indicator](party-indicator/PartyIndicator.c)

#### Loops
```cpp
#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("while loop\n");
    int a = 0;
    while(a < 10){
        printf("%d\n", a++);
    }

    printf("\n\ndo while loop\n");
    int b = 0;
    do{
        printf("%d\n", b++);
    } while(b < 10);

    printf("\n\nfor loop\n");
    int i = 0;
    for (i; i < 10; i++){
        printf("%d\n", i);
    }

    return 0;
}
```

#### Exercises
 -  [i_wont_cheat_on_the_exams](i-wont-cheat-on-the-exams/i_wont_cheat_on_the_exams.c)
 -  [print_even](print-even/print_even.c)
 -  [multiplication_table](multiplication-table/multiplication_table.c)
 -  [count_from_to](count-from-to/count_from_to.c)
 -  [fizz_buzz](fizz-buzz/fizz_buzz.c)
 -  [fizz_buzz_switch 💪](fizz-buzz/fizz_buzz_switch.c)
 -  [draw_triangle](draw-triangle/draw_triangle.c)
 -  [draw_pyramid 💪](draw-pyramid/draw_pyramid.c)
 -  [draw_diamond 💪](draw-diamond/draw_diamond.c)
 -  [draw_square 💪](draw-square/draw_square.c)
 -  [draw_diagonal](draw-diagonal/draw_diagonal.c)
 -  [guess_the_number](guess-the-number/guess_the_number.c)
 -  [parametric_average 💪](parametric-average/Parametric_average.c) *exam*
 -  [draw_chess_table](draw-chess-table/draw_chess_table.c)
 -  [days_to_years](days-to-years/days_to_years.c)
 -  [amount_of_money](amount-of-money/amount_of_money.c)

## Individual Workshop Review
Please follow the styleguide: [Our C styleguide](https://github.com/greenfox-academy/teaching-materials/blob/master/styleguide/c.md)

 - Is the directory structure and the name of the files correct?
 - Are the includes placed on the top of the files?
 - Is the indentation good in each file?
 - Is there unnecessary code?
 - Can you find unnecessary code in comments?
 - Is there unnecessary code duplication?
 - Are there unnecessary empty blocks?
 - Can you spot unused variables?
 - Is the commit message meaningful?
