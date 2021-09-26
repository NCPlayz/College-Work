# Processing taster lessons notes

## Functions

A function is just a container of code, that can be reused across your codebase.

The basic container types we've been taught are: `int`, `String`, `boolean`, `char`.

> If you don't want the function to return anything, the container type should be `void`.

### Declaring functions

```processing
// The pattern is <container type> <function name>(<parameters>) { ... }
void myFunction() {
    // Do Stuff
}

// Usually, a function that doesn't return a value is called a "procedure".
// To create a function that returns a value, we just need to declare the
// container type of what it returns correctly.

int myCoolFunction() {
    return 5;
}
```

### Calling functions

To call functions to run the code within it, use the function name and provide parameters within the parentheses.

```processing
// Since myFunction doesn't require any parameters,
// there's nothing between the parentheses.
myFunction();

// We store the returned value in a variable.
// See Variables section for more info.
int coolVariable = myCoolFunction();
```

## Variables

A variable is essentially a reference to a value.
In Processing, a variable has a container type, which means the value **MUST** match that container type.

```processing
// To declare a variable, simply write
// <container type> <variable name>;
int myInt;

// To assign a value to a variable:
// <variable name> = <value that matches the container type>;
myInt = 2;
// To declare AND assign at the same time:
// <container type> <variable name> = <value that matches the container type>;
int myInt = 2;
```

## Incrementing / Decrementing

A variable that stores an integer have simple "operators", so you can easily
add or subtract from it.

```processing
int myInt = 2;
// Increment the value that the variable references by 1:
myInt++; // Becomes 3
// Decrement by 1:
myInt--; // Becomes 2
```

These are just short-hands for incrementing / decrementing the value by 1.
To change the value by more than 1, we can use "compound assignments".
That means you re-assign the value, and add the change at the same time.

```processing
int myInt = 2;
// Compound assignment, that increments "myInt" by 2
myInt += 2; // Becomes 4
// This can be thought of as:
myInt = myInt + 2;
// Compound assignment, that decrements "myInt" by 2
myInt -= 2; // Becomes 2
// This can be thought of as:
myInt = myInt - 2;
```

## Selection (If / Else Statements)

`if` / `else` statements allows us to run different branches of code based on a condition.
In an `if` statement, the condition must evaluate to be `true` for the code within its branch to run.

```processing
int red = 0;
int green = 0;
int blue = 0;

void draw() {
    // If the value of "red" is more than 255,
    if (red > 255) {
        // Re-assign "red" to 0
        red = 0;
    }

    // Set the background to the values of the corresponding variables.
    background(red, green, blue);

    // Increment "red" by 1.
    red++;
}
```

```processing
int myInt = 5;
// Basic format:
// if (<condition>) { ... }
// Must be wrapped in parentheses
// The condition must always become a boolean, as If Statements
// only work if the condition are / become the values "true" or "false".
// See Boolean logic for more info
if (myInt == 5) {
   // If myInt is 5
   // Do Stuff
}
// Else statements are used if the if statement's condition
// doesn't succeed
else {
   // Do other stuff if myInt isn't 5
}
```

## Input / Output

```processing
// The way we learnt to get text input was with
import static javax.swing.JOptionPane.*;
String input = showInputDialog("Enter something: ");
// which opens a window. We can try to read
// the value as container types other than String
// by parsing them as such.

int inputAsInt = parseInt(input, MIN_INT);

// The second parameter here "MIN_INT" is used as a "fallback",
// in case the input can't be read as an integer.
// MIN_INT is just the smallest possible integer that Processing
// or the Operating System can handle.

// We also learnt about Processing's special "keyPressed" function,
// which detects when a key is pressed.
void keyPressed() {
  // "key" is a special variable that only exists within the "keyPressed" function --
  // Processing provides it to us!
  if (key == 'q') {
    // Do Stuff!
  }
}

// Do print things to the console, we can use:
print("Stuff!");
```

# For loops

```processing
// For loops consist of 4 components:
for (int i = 0; i < 5; i++) { print(i) }
// 1. A variable is declared and assigned to 0,
// 2. A condition is created, describing that the variable should be less than 5.
// 3. The behaviour after each loop is declared, in this case, after running the code within the curly brackets once, the variable is incremented by 1.
//
// This for loop essentially means:
// While "i" is less than 5, keep running the code each loop, and increment "i" by 1 each loop.
// Since "i" is assigned as 0, this means that the code will be ran 5 times.
```

## Arrays

An array is a collection of a container type, with a fixed size. The most simple form of it in Processing is `String`, which is essentially just a collection of singular characters, or the container type `char` in Processing.

```processing
// Let's make a string.
String myString = "hello";
// This could be thought of as:
char[] myString = { 'h', 'e', 'l', 'l', 'o' };
// An array of characters :sunglasses:
// A fixed size means that you can never increase or decrease the size, or length in this case, of the collection.
// We cannot add or remove anything to the array of characters. It is "read-only", or immutable.
// An array is also immutable, meaning that the value of it is fixed! It cannot be changed. Ever. EVER.
```

If you try to think of arrays from a memory's perspective, each item of the array has a fixed size.
Say for example, each item in the array has a size of "8", and the array was stored in address 80 of the memory.

```py
>>> myNewArrayOfIntegers = [2, 3, 4]
+----+----+----+
| 80 | 88 | 96 |
|----+----+----|
| 2  | 3  | 4  |
+----+----+----+
```

As you can see, at address 80, we have the first value stored, 2.
At address 88, we have the second value stored, 3, and so on.
The interval between these addresses is 8, because the size of each item in the array is 8!

When we say arrays have a fixed size, it's because it's designed to prevent accidentally accessing other bits of memory.
For my array `myNewArrayOfIntegers`, the size of the array is 3, and because the size of each item is 8, it is allocated 3 \* 8 addresses in memory, or rather, addresses 80 - 104.

We have no idea what the heck could be on address 105 onwards, because those addresses aren't allocated to us, or the array rather! It could be allocated to some other program, or a critical function like the operating system, or drawing onto the screen.
If we were allowed to set whatever was at address 105, we could potentially accidentally break the whole computer!

## Boolean Operators

There are a few "Boolean operators", or logic gates. We know them as AND, OR, and NOT.
In processing, they are `&&`, `||`, and `!`.

### AND

this logic gate requires two items, and tells us if both items are true. We can think of this as the intersection of a venn diagram.

### OR

this logic gate requires two items and tells us if either one of the items are true. We can think of this as covering all of the inner bits of a venn digram.

### NOT

this logic gate requires one item, and basically inverts the value of that item. If the item is true, the result is false. If the item is false, the result is true.
