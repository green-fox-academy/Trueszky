# Expressions and Control Flow

## Materials & Resources

| Material | Time |
|:---------|-----:|
| [JavaScript for Beginners 02 - What is JavaScript?](https://www.youtube.com/watch?v=VB7y0yxZjro) | 4:03 |
| [TypeScript Tutorial 1: Welcome To TypeScript!](https://www.youtube.com/watch?v=hADI92zCIvE) | 3:23 |
| [JavaScript Tutorial For Beginners 03 - Hello World! in JavaScript](https://www.youtube.com/watch?v=ranSYb-EhrU) | 3:17 |
| [JavaScript Tutorial For Beginners #6 - Basic JavaScript Syntax & Rules](https://www.youtube.com/watch?v=QLatPwsbDrQ) | 7:49 |
| [JavaScript Tutorial For Beginners #7 - JavaScript Variables](https://www.youtube.com/watch?v=u0Mq3FzpsmI) | 8:59 |
| [let vs var - Topics of JavaScript/ES6](https://www.youtube.com/watch?v=q8SHaDQdul0) | 12:19 |
| [const - Topics of JavaScript/ES6](https://www.youtube.com/watch?v=2iLVFyYwyRA) | 7:41 |
| [JavaScript Tutorial For Beginners #8 - Basic Mathematical Operators](https://www.youtube.com/watch?v=_MC0Gw07w8M) | 6:16 |
| [JavaScript Tutorial For Beginners #9 - Math Operator Short-hand](https://www.youtube.com/watch?v=Z1eV0RBRam0) | 4:55 |
| [JavaScript Tutorial For Beginners #10 - Logging to the Console](https://www.youtube.com/watch?v=tH-q9QFNUdA) | 3:38 |
| [JavaScript Tutorial For Beginners #11 - Booleans in JavaScript](https://www.youtube.com/watch?v=B4ZCFdrBmbE) | 6:13 |
| [JavaScript Tutorial For Beginners #12 - If Statements](https://www.youtube.com/watch?v=Lp-Du2fKoug) | 8:45 |
| [JavaScript Tutorial For Beginners #13 - Else If Statements](https://www.youtube.com/watch?v=1v1Bk3Q02Sc) | 4:03 |
| [JavaScript Tutorial For Beginners #14 - Comparison Operators](https://www.youtube.com/watch?v=LjGaaWX_NbE) | 5:25 |
| [JavaScript Tutorial For Beginners #15 - Logical Operators](https://www.youtube.com/watch?v=mbT7sSmVUS8) | 6:01 |
| [JavaScript Tutorial For Beginners #16 - While Loops](https://www.youtube.com/watch?v=PpbFyLTtpWI) | 4:09 |
| [JavaScript Tutorial For Beginners #17 - For Loops](https://www.youtube.com/watch?v=U87UmD-5h4o) | 7:49 |
| [JavaScript Tutorial For Beginners #18 - Break & Continue](https://www.youtube.com/watch?v=QSuTH0C_3_Y) | 4:13 |
| [JavaScript Tutorial For Beginners #19 - Practical Example using Loops](https://www.youtube.com/watch?v=eZBTLsv2ktM) | 4:02 |
| [JavaScript Tutorial For Beginners #22 - Numbers](https://www.youtube.com/watch?v=TD3Pfuxgnuc) | 6:09 |
| [JavaScript Tutorial For Beginners - NaN (Not a Number)](https://www.youtube.com/watch?v=0ZiltZDg9Gg) | 6:34 |
| [JavaScript Tutorial For Beginners #24 - Strings](https://www.youtube.com/watch?v=k8MIbEVXhE0) | 9:37 |
| [Basic Types · TypeScript](https://www.typescriptlang.org/docs/handbook/basic-types.html) | reading |

### Environment

 -  Download and install [Node.js](https://nodejs.org/en/download/)
    (Latest LTS Version)
 -  Install [TypeScript](https://www.typescriptlang.org/)
    (`npm install -g typescript`)
 -  Install [TypeScript Node](https://www.npmjs.com/package/ts-node)
    (`npm install -g ts-node`)

## Material Review

 -  Node.js
     -  `node`
 -  TypeScript
     -  `tsc`
 -  TypeScript Node
     -  `ts-node`
 -  `console`
 -  variables
     -  `var`
     -  `let`
     -  `const`
 -  JavaScript types
     -  number
     -  string
     -  boolean
     -  null
     -  undefined
 -  TypeScript types
     -  any
 -  operators
     -  arithmetic (`+`, `-`, `/`, `*`, `%`, `**`, `++`, `--`)
     -  logical (`&&`, `||`, `!`)
     -  comparison (`==`, `!=`, `===`, `!==`, `<`, `<=`, `>`, `>=`)
     -  assignment (`=`)
     -  `typeof`
 -  control structures
     -  if
     -  for
     -  while
     -  do while
     -  (switch, break, continue)

## Workshop

### Printing to the terminal window

#### Hello World

```typescript
console.log('Hello World!');
```

#### Exercises

 -  [hello-me](hello-me/hello-me.ts)
 -  [humpty-dumpty](humpty-dumpty/humpty-dumpty.ts)
 -  [hello-others](hello-others/hello-others.ts)

### Comments

```typescript
// single line comment

/*
 multi line
 comment block
*/
```

### Types

#### Print values with different types

```typescript
// Prints a string to the terminal window
console.log('Hello world!');

// Prints an integer to the terminal window
console.log(42);

// Prints a floating point number to the terminal window
console.log(3.141592);

// Prints a boolean to the terminal window
console.log(true);
```

#### Integers

```typescript
// Positive, negative and zero
console.log(42); // Prints 42
console.log(-1); // Prints -1
console.log(0); // Prints 0

console.log(12341234123412341234); // 12341234123412340000
// In JavaScript numbers are rounded over a limit
// The maximal number that is not rounded (the maximum safe integer) is:
// 9007199254740991
// The reasoning behind that number is that JavaScript uses double-precision
// floating-point format numbers
// Link: http://en.wikipedia.org/wiki/Double_precision_floating-point_format
```

#### Floats

```typescript
// Positive, negative and zero
console.log(3.1415); // Prints 3.1415
console.log(-1.5); // Prints -1.5
console.log(0.0); // Prints 0

// Leading and closing zero is not mandatory
console.log(.5) // Prints 0.5
console.log(5.) // Prints 5.0
```

#### Number Operations

```typescript
// Arithmetic operations
console.log(1 + 1); // Prints 2
console.log(5 - 2); // Prints 3
console.log(3 * 4); // Prints 12
console.log(6 / 2); // Prints 3
console.log(5 / 2); // Prints 2.5
console.log(5 % 2); // Prints 1
```

#### Booleans

```typescript
// true, false
console.log(true); // Prints true
console.log(false); // Prints false

// Boolean Operators
// Negation
console.log(!true); // Prints false
console.log(!false); // Prints true

// And
console.log(true && true); // Prints true
console.log(true && false); // Prints false
console.log(false && true); // Prints false
console.log(false && false); // Prints false

// Or
console.log(true || true); // Prints true
console.log(true || false); // Prints true
console.log(false || true); // Prints true
console.log(false || false); // Prints false
```

```typescript
// String and special characters
console.log('apple'); // Prints apple
console.log('don\'t'); // Prints don't
console.log('"Everything you can imagine is real." - Picasso');
// Prints "Everything you can imagine is real." - Picasso

// String Operators
// Concatenation
console.log('tooth' + 'brush'); // Prints toothbrush

// Concat string with number
console.log('My favorite number is: ' + 8); // Prints My favorite number is: 8
```

#### Exercises

 -  [introduce-yourself](introduce-yourself/introduce-yourself.ts)
 -  [two-numbers](two-numbers/two-numbers.ts)
 -  [coding-hours](coding-hours/coding-hours.ts)

### Variables

#### Creating different variables for each type

```typescript
// String
let welcome: string = 'Hello, World';
console.log(welcome);

// Boolean
let isAwesome: boolean = true;
console.log(isAwesome);

// Integer
let theMeaningOfLifeAndTheUniverseAndEverything: number = 42;
console.log(theMeaningOfLifeAndTheUniverseAndEverything);

// Floating point number
let pi: number = 3.141592;
console.log(pi);

// Assigning and creating a variable, (define its value)
let number: number = 12;

// Mutate a variable, (redefine its value)
number = 23;

// Any
let dynamic: any = 5;
dynamic = true;
dynamic = 'strange';
```

#### Arithmetic Assignment Operators

```typescript
let a: number = 12;
a = a + 4;
console.log(a); // Prints 16

let b: number = 12;
b = b - 4;
console.log(b); // Prints 8

let c: number = 12;
c *= 3;
console.log(c); // Prints 36

let d: number = 12;
d /= 3;
console.log(d); // Prints 4

let e: number = 12;
e %= 7;
console.log(e); // Prints 5

let f: number = 12;
f++;
console.log(f); // Prints 13

let g: number = 12;
g--;
console.log(g); // Prints 11

let h: number = 10;
console.log(h); // Prints 10
console.log(h++); // Prints 10
console.log(h); // Prints 11

let i: number = 10;
console.log(i); // Prints 10
console.log(++i); // Prints 11
console.log(i); // Prints 11
```

#### Exercises

 -  [favorite-number](favorite-number/favorite-number.ts)
 -  [swap](swap/swap.ts)
 -  [bmi 💪](bmi/bmi.ts)
 -  [define-basic-info](define-basic-info/define-basic-info.ts)
 -  [variable-mutation](variable-mutation/variable-mutation.ts)
 -  [cuboid 💪](cuboid/cuboid.ts)
 -  [seconds-in-a-day](seconds-in-a-day/seconds-in-a-day.ts)

### Nothings

```typescript
undefined;
null;
NaN;

null !== undefined;
NaN !== undefined;
null !== NaN;

null == undefined;

typeof undefined; // 'undefined'
typeof null; // 'object'
typeof NaN; // 'number'

let apple;
console.log(apple); // undefined
console.log(apple + 1); // NaN
apple = null;
console.log(apple); // null
```

### Conditionals

```typescript
let a: number = 13;

if (a === 13) {
  console.log('Yaaay! The value of the \'a\' variable is 13'); // This block will run
}

if (a === 8) {
  console.log('Yaaay! The value of the \'a\' variable is 8'); // This block will NOT run
}


let b: number = 20;

if (b < 10) {
  console.log('Yaaay! The value of the \'b\' variable is lower than 10') // This block will NOT run
} else {
  console.log('Yaaay! The value of the \'b\' variable is higher than 10') // This block will run
}


let c: number = 15;

if (c < 10) {
  console.log('Yaaay! The value of the \'b\' variable is lower than 10'); // This block will NOT run
} else if (c < 20) {
  console.log('Yaaay! The value of the \'b\' variable is higher than 10'); // This block will run
} else {
  console.log('Yaaay! The value of the \'b\' variable is higher than 10'); // This block will NOT run
}


let thirsty: boolean = true;
let hungry: boolean = false;

if (thirsty && hungry) {
  console.log('Lunch time!');
} else if (thirsty || hungry) {
  console.log('Snack time!');
} else {
  console.log('No food for you.');
}
```

#### Exercises

 -  [14 - conditional-variable-mutation](conditional-variable-mutation/conditional-variable-mutation.ts)

### Loops

```typescript
let a: number = 0;
while (a < 10) {
  console.log(a); // Prints the numbers from 0 to 9
  a++;
}

for (let j: number = 0; j < 100; j++) {
  console.log(i); // Prints the numbers from 0 to 99
}
```

#### Exercises

 -  [i-wont-cheat-on-the-exams](i-wont-cheat-on-the-exams/i-wont-cheat-on-the-exams.ts)
 -  [print-even](print-even/print-even.ts)
 -  [multiplication-table](multiplication-table/multiplication-table.ts)
 -  [fizz-buzz](fizz-buzz/fizz-buzz.ts)
 -  [draw-triangle](draw-triangle/draw-triangle.ts)
 -  [draw-pyramid 💪](draw-pyramid/draw-pyramid.ts)
 -  [draw-diamond 💪](draw-diamond/draw-diamond.ts)
 -  [draw-square 💪](draw-square/draw-square.ts)
 -  [draw-diagonal](draw-diagonal/draw-diagonal.ts)
 -  [ParametricAverage 💪](parametric-average/parametric_average.ts) *exam*
 -  [draw-chess-table](draw-chess-table/draw-chess-table.ts)

### Plus one

 -  [Find the substring](substr/substr.ts)

## Individual Workshop Review

Please follow the [TypeScript styleguide](../../styleguide/typescript.md)

 -  Is the directory structure and the name of the files correct?
 -  Is every file in strict mode?
 -  Is the indentation good in each file?
 -  Is there unnecessary code?
 -  Can you find unnecessary code in comments?
 -  Is there unnecessary code duplication?
 -  Are there unnecessary empty blocks?
 -  Can you spot unused variables?
 -  Is the commit message meaningful?
 -  Are the names of things following the styleguide?
 -  Are all of the brackets in the perfect place?
 -  Are whitespaces where they should be?
