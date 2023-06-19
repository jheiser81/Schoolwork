// let beverage = prompt("What would you like to order?", "coffee");
// if (beverage === "coffee") {
//   alert("I'll have coffee");
// } else if (beverage === "tea") {
//   alert("I'll have tea");
// } else if (beverage === "soda") {
//   alert("I'll have soda");
// } else {
//   alert("I'll have water");
// }

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

// Case1) Input = 25
//     output = Buzz
// Case 2) Input = 30
//     output = FizzBuzz
// Case 3) Input = 12
//     output = Fizz
// Case 4) Input = 11
//     output = No fizz No buzz

let number = +prompt("Enter a number");
if (number % 3 == 0 && number % 5 == 0) {
  alert("FizzBuzz");
} else if (number % 3 == 0) {
  alert("Fizz");
} else if (number % 5 == 0) {
  alert("Buzz");
} else {
  alert("No Fizz, no Buzz");
}

