//JavaScript is a dynamically typed language. It means that a variable doesn’t associate with a type. In other words, a variable can hold a value of different types. For example:

// let counter = 120; // counter is a number
// counter = false; // counter is now a boolean
// counter = "foo"; // counter is now a string

//To get the current type of the value that the variable stores, you use the typeof operator:

// let counter = 120;
// console.log(typeof counter); // "number"

// counter = false;
// console.log(typeof counter); // "boolean"

// counter = "Hi";
// console.log(typeof counter); // "string"

//-----UNDEFINED TYPE VARIABLE-----

//The undefined type is a primitive type that has only one value undefined. By default, when a variable is declared but not initialized, it is assigned the value of undefined.

// let counter;
// console.log(counter);        // undefined
// console.log(typeof counter); // undefined

//-----NULL TYPE VARIABLE-----

//The null type is the second primitive data type that also has only one value null. For example:

// let obj = null;
// console.log(typeof obj); // object

// console.log(null == undefined); // true

//-----NUMBER TYPE VARIABLES-----

// JavaScript uses the number type to represent both integer and floating-point numbers.

// The following statement declares a variable and initializes its value with an integer:

// let num = 100;
// console.log(num);

// To represent a floating-point number, you include a decimal point followed by at least one number. 

// let price = 12.5;
// let discount = 0.05;
// console.log(price);
// console.log(discount);

//Note that JavaScript automatically converts a floating-point number into an integer number if the number appears to be a whole number.

// let price = 200.00; // interpreted as an integer 200
// console.log(price);

// To get the range of the number type, you use Number.MIN_VALUE and Number.MAX_VALUE. For example:

// console.log(Number.MAX_VALUE); // 1.7976931348623157e+308
// console.log(Number.MIN_VALUE); // 5e-324

// Also, you can use Infinity and -Infinity to represent the infinite number. For example:

// console.log(Number.MAX_VALUE + Number.MAX_VALUE); // Infinity
// console.log(-Number.MAX_VALUE - Number.MAX_VALUE); // -Infinity

//-----NaN-----

// NaN stands for Not a Number. It is a special numeric value that indicates an invalid number. For example, the division of a string by a number returns NaN:.

// console.log('a'/2); // NaN;

// The NaN has two special characteristics:

// Any operation with NaN returns NaN.
// The NaN does not equal any value, including itself.
// Here are some examples:

// console.log(NaN/2); // NaN
// console.log(NaN == NaN); // false

// -----STRING TYPE VARIABLES-----

// In JavaScript, a string is a sequence of zero or more characters. A string literal begins and ends with either a single quote(') or a double quote (").

// A string that begins with a double quote must end with a double quote. Likewise, a string that begins with a single quote must also end with a single quote:

// let greeting = "Hi";
// let message = "Bye";
// console.log(greeting);
// console.log(message);

// If you want to single quote or double quotes in a literal string, you need to use the backslash to escape it. For example:

// let message = 'I\'m also a valid string';
// console.log(message);
 // use \ to escape the single quote (')

//  JavaScript strings are immutable. This means that it cannot be modified once created. However, you can create a new string from an existing string. For example:

// let str = "JavaScript";
// str = str + " String";
// console.log(str);

// In this example:

// First, declare the str variable and initialize it to a string of 'JavaScript'.
// Second, use the + operator to combine 'JavaScript' with ' String' to make its value as 'Javascript String'.
// Behind the scene, the JavaScript engine creates a new string that holds the new string 'JavaScript String' and destroys the original strings 'JavaScript' and ' String'.

// The following example attempts to change the first character of the string JavaScript:

// let s = "JavaScript";
// s[0] = "j";
// console.log(s);

// The output is:'JavaScript' but not 'javaScript'

//-----BOOLEAN TYPE-----

// The boolean type has two literal values: true and false in lowercase. The following example declares two variables that hold the boolean values.

let inProgress = true;
let completed = false;

console.log(typeof completed); // boolean