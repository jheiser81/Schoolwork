let sum = 0;                                     
for (i = 0; i <= 100; i++) {                    
  console.log(`${i} + ${sum} = ${i+sum}`)
sum = sum + i;
}
//setting the sum to 0
//initialize variable

// let sum = 0                                    //initialize sum as 0
// let userInput = null                          //make our user input null so we can access it outside of the loop
// while (userInput !== 0) {                    //if user input is 0 break the loop
//   userInput = +prompt("Input a number to add to the current sum ${sum}") //taking the user input
//   sum = sum + userInput                     //taking the user input
// }
// alert( `the sum of all of your numbers is ${sum}`) //print sum

// Take in one number, and check if it is even or odd
// Case 1) Input = 55
//     output = odd
// Case 2) input = 22
//     output = even

// //check if the number is even
// let number = +prompt("Enter a number");
// if (number % 2 == 0) {
//   alert("The number is even");
// }
// //check if the number is odd
// else {
//   alert("The number is odd");
// }

// The user inputs two numbers
// The program will print and sum all the even numbers between the user’s input.
// Input = 1, 9
// Output = 2, 4, 6, 8 (this could be in the console) “The sum of all the even numbers is 20”

// let sum = 0;
// for (i = 1; i <= 9; i++) {
//   if (i % 2 == 0) {
//     sum = sum + i;
//   }
// }
// console.log(`The sum of all the even numbers is ${sum}`);

// let sum = 0
// let userInput = null
// while (userInput !== 0) {
//     userInput = +prompt(`Put in a number to add to your current sum ${sum}`)
//     sum = sum + userInput
// }
// alert(`the sum of all of your numbers is ${sum}`)

// let name1 = prompt("What is your first name?", "Jeff")
// let name2 = prompt("What is your last name?", "Bezos")
// let age = prompt("How old are you?", "58")
// let job = prompt("What is your occupation?", "business owner")

// alert(`"Hi, my name is ${name1} ${name2}. I am ${age} years old and I am a ${job}`)

// let a = 12;
// let b = 3;
// let sum = a + b;
// let difference = a - b;
// let product = a * b;
// let quotient = a / b;

// console.log(
//   `${a} + ${b} = ${sum}, ${a} - ${b} = ${difference}, ${a} * ${b} = ${product}, ${a} / ${b} = ${quotient}`
// );

// let a = +prompt("Input a number");
// let b = +prompt("Input a number");
// if (a % 2 !== 0 && b % 2 !== 0) {
//   alert(a * b);
// } else if (a % 2 == 0 && b % 2 == 0) {
//   alert(a / b);
// } else if (a % 2 !== 0 && b % 2 == 0) {
//   alert(a + b);
// } else if (a % 2 == 0 && b % 2 !== 0) {
//   alert(a - b);
// }

// Exercise 2:
// Make a loop that finds the highest number from a set of user inputs
// Input = 1,5,6,8,9,55,10,9
// Output =  55

// let highestNumber = 0
// let moreData = null
//   while (moreData != -999) {
//     moreData = +prompt("Add next number")
//     if (moreData > highestNumber) {
//       highestNumber = moreData
//     }
// }

// let largestNumber = 0
// let keepCheckingData = true
// while (keepCheckingData = true) {
//   inputData = +prompt("Add next number")
//   if (inputData > largestNumber) {
//     largestNumber = inputData
//   }
//     keepCheckingData = prompt("Would you like to input another number?")

// }

// Using inputs/outputs, variables, and loops write a flow chart or Pseudo Code that takes in a user input and prints all the
// numbers from 1 – 100 while multiplying the user input by the current loop counter:
// Input = 3
// Output =
// “3 x 1 = 3”
// “3 x 2 = 6”
// “3 x 3 = 9”
// “3 x 4 = 12”
// ... this will repeat till you get to
// “3 x 99 = 297”
// “3 x 100 = 300”

// let userNumber = 3;
// let counter = 1
// for (let counter = 1; counter <= 100; counter++) {
//   console.log(`${counter} * ${userNumber} = ${counter * userNumber}`);
// }     