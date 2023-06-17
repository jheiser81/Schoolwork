// //this is only functions (like thoughts), they don't work until we call for them to be used.
// function AddNumbersFrom1to100() {
//   let sum = 0;
//   for (let i = 1; i < 101; i++) {
//     sum += i;
//   }
//   console.log(sum);
// }

// function hello(greeting, place) {
//   console.log(`${greeting}, ${place}`);
//   console.log(greeting); //here it works
// }
// // console.log(greeting) - if put here then it will not run, error will appear in the console

// function Sum(x, y) {
//   let sum = x + y;
//   console.log("the value of sum is: " + sum);
// }

// //this is the only thing that runs. We call the function, that's when it runs.
// AddNumbersFrom1to100();
// hello("hello", "World");
// hello("goodbye", "home");
// Sum(1, 5);
// Sum(16, 7);

// function AddNumbersFromNtoM() {
//   let sum = 0;
//   let n = +prompt("enter start number");
//   let m = +prompt("enter end number");
//   for (let i = n; i <= m; i++) {
//     sum += i;
//   }
//   console.log(sum);
// }
// AddNumbersFromNtoM();

// function AddNumbersFromNtoM(n,m) {
//     let sum = 0;
//     for (let i = n; i <= m; i++) {
//       sum += i;
//     }
//     console.log(sum);
//   }
//   AddNumbersFromNtoM(5,10);

// //   multiplication, division, subtraction functions
//   function product(x,y) {
//     let product = x*y;
//     console.log(product);
//   }
//   function quotient(x,y) {
//     if (x === 0 || y === 0) { //just an add on from Maya. if divide by 0, infinity message comes up
//         return
//     }
//     let quotient = x/y;
//     console.log(quotient);
//   }
//   function difference(x,y) {
//     let difference = x - y;
//     console.log(difference);
//   }

//   product(8,4);
//   quotient(8,4);
//   difference(8,4);

//   // FEBRUARY 1
//   // Functions / Returns

//   // function RandomNumber(x) {
//   //   let myRandNumber = Math.floor(Math.random() * x);
//   //   return myRandNumber;
//   // }
//   // let myNewRandom = RandomNumber(5);

// // make an array of 5 names

//   function RandomNumber(X) {
//     let myRandNumber = Math.floor(Math.random() * X); //x is used to create a round number range. rand number itself is up to 1.0, so by *5 we create a range from 0-5
//     return myRandNumber;
//   }
//     let myNewRandom = RandomNumber(5);
//     console.log(myNewRandom)
//     let myNewRandom2 = RandomNumber(10);
//     console.log(myNewRandom2)
//     let myNewRandom3 = RandomNumber(10); //number here will be different from the previous line because we run the function every time we call for it, so on this line we called the function for the 3rd time
//     console.log(myNewRandom3)

//     const names = ["Maya", "Martin", "Joel", "Wendy", "Lily", "James", "Abdul", "Omaima", "Victoria", "Brian"]; //don't put this inside the function, will not be able to access it
//     console.log(`The next person is ${names[myNewRandom]}`);
//     console.log(`The next person is ${names[myNewRandom2]}`);
//     console.log(`The next person is ${names[myNewRandom3]}`);
//     RandomNumber(index)
//     console.log(nameArray[myRandNumber(5)]);

// Returns exercise

//     way 1

//     function arithmetic (operator, Number1, Number2) {
//       if (operator === '+') {
//         return Number1 + Number2;
//       }
//       else if (operator === '-') {
//         return Number1 - Number2;
//       }
//       else if (operator === '*') {
//         return Number1 * Number2;
//       }
//       else if (operator === '/') {
//         return Number1 / Number2;
//       }
//       else {
//         console.log("This code cannot solve the equation")
//       }
//     }
//     let productNum = arithmetic ('*', 5, 10);
//     console.log(`the product is ${productNum}`)
//     let sumNum = arithmetic ('+', 10, 55);
//     console.log(`the sum is ${sumNum}`)
//     let differenceNum = arithmetic ('-', 42, 2);
//     console.log(`the difference is ${differenceNum}`)
//     let quotientNum = arithmetic ('/', 100, 20);
//     console.log(`the quotient is ${quotientNum}`)

//     // way 2

//     function arithmetic (operator, Number1, Number2) {
//       if (operator === '+') {
//         let sumNum = Number1 + Number2;
//         return sumNum;
//         //if I delete line 147 and put return sumNum = Number1 + Number2; sumNum will be introduced as a global variable that can be accessed and changed from anywhere. Therefore it needs to be declared by let before return so we keep the variable within the scope.
//       }
//     }
//     arithmetic ('+', 10, 55);
//     console.log(`the sum is ${sumNum}`)

//     function arithmetic (operator, Number1, Number2) {
//       if (operator === '+') {
//         let sumNum = Number1 + Number2;
//         console.log(`the sum is ${sumNum}`) //can be located inside the function too.This will only print a result but not saved to memory. Needs to put above return for it to work
//         return sumNum; //has to be the last thing because anything under it within the scope will not work. Return saves the result to memory so we can use the data later.
//       }
//       let difference = Number1 - Number2; //this will run only if operator will not be +
//       console.log(`the sum is ${difference}`) //needs to put above return for it to work
//       return difference; //
//     }
//     arithmetic ('+', 10, 55);





//FEBRUARY 2 | THURSDAY

//FUNCTIONS. Multiple exercises:

// MAIN FUNCTION - 100 RANDOM NUMBERS

// function make100randomNum() {
//   const numArray = [];
//   for (let index = 0; index < 100; index++) {
//     let randomNum = Math.floor(Math.random() * 101); //randNum is a temporary variable we create to hold the  random number, and is only used for the function
//     numArray.push(randomNum); //we then push the random number into the array
//   }
//   return numArray; //return gives the final value of the array 
// }
// const my100Nums = make100randomNum();
// console.log(my100Nums);

//NOTES:
//LINE 163 - best to keep the variable inside the function so every time we call it, the function will start from fresh start ei empty numArray
//LINE 170 - here I have to declare another variable to hold the value of the run function. Use const to avoid the value to be overwritten and because it is an array.
//LINES 162, 165, 170 - x stands for the 100 numbers I want to get. Technically I just remove x and replace x in line 165 with 101 to limit the max value of each random calculator output to 100. I gonna do just like that

//my original version - Maya explained the issues I can face with this one. Time stamp 9:50am
// const numArray = [];
// function make100randomNum(x) {
//   for (let index = 0; index < 100; index++) {
//   let randomNum = Math.floor(Math.random() * x);
//   numArray.push(randomNum);
//   }
//   return numArray;
// }
// make100randomNum(101) //
// console.log(numArray);
// make100randomNum(101)
// console.log(numArray);
//LINE 179 - here the variable is global, therefore its value is saved even after the function is run.
//LINE 189 - because the variable is global, second function call will add 100 additional numbers to the existing global variable numArray


// all the consequent functions are module functions

//) SUM OF ALL NUMBERS

// function sumArray() {
//   let sumNumArray = 0;
//   for (let index = 0; index < my100Nums.length; index++) {
//     sumNumArray = sumNumArray + my100Nums[index];
//   }
//   return sumNumArray;
// }
// let totalArraySum = sumArray(); 
// console.log(`Sum1 equals to ${totalArraySum}`);
// totalArraySum = sumArray(make100randomNum()); 
// console.log(`sum 2 ${totalArraySum}`);

//NOTES:
//LINE 207 - I use a new variable holder. Can use let or const depending on the needs.
//LINE 209 - here the initial totalArraySum value will be overwritten by the second run of the sumArray function
//LINE 210 - If I kept the sumNumArray variable outside the function the second run would have added to the first function call output
//under LINE 200 - console.log(`previous sum  ${sumNumArray}`); can be used for display that the function starts fresh at every call. Can be removed


//)LARGEST NUMBER

// function findMax() {
//   let maxNum = 0;
//   for (let index = 0; index < my100Nums.length; index++) {
//     if (maxNum < my100Nums[index]) {
//       maxNum = my100Nums[index];
//     }
//   }
//   return maxNum;
// }
// let maxNumber = findMax(); // findMax ();
// console.log(`The maximum number is ${maxNumber}`);
//NOTES:
//LINE 220 - Removed numArray inside the brackets. 
//LINE 223 - I use my100Nums instead of numArray on lines 223, 224, 225 because it's the variable that holds the function value that was run. If I use numArray instead, the problem here is that we will run the main function again to calculate this module function which means the result will not be based on the first run result output. We need to make sure the module functions are using the main function first array as the only source of data, not run main f every time.


//)SMALLEST NUMBER

// function findMin() {
//   let minNum = 0;
//   for (let index = 0; index < my100Nums.length; index++) {
//     if (minNum > my100Nums[index]) {
//       minNum = my100Nums[index];
//     }
//   }
//   return minNum;
// }
// let minNumber = findMin();
// console.log(`The minimum number is ${minNumber}`);

//NOTES:
//LINE 247 - findMin(make100randomNum(101)) replaced by findMin(). Reason is for the module function to be based on the first array, not run main f again to get new data. Same situation as in line 229.


//) AVERAGE OF ALL NUMBERS IN THE ARRAY

// function averageArray() {
//   let averageNum = totalArraySum / my100Nums.length;
//   return averageNum;
// }
// let averageNumber = averageArray();
// console.log(`The average value is ${averageNumber}`);

//NOTES:
//LINE 257 - I used the result of the sum function put inside the variable totalArraySum based on the main f first output array and divided by the length of the first output array


//)COUNT ODD, EVEN, ZERO NUMBERS IN THE ARRAY

// function countOddEvenZero() {
//   let countEven = 0;
//   let countOdd = 0;
//   let countZero = 0;
//   for (let index = 0; index < 100; index++) {
//     if (my100Nums[index] === 0) {
//       countZero++;
//     } else if (my100Nums[index] % 2 === 0) {
//       countEven++;
//     } else {
//       countOdd++;
//     }
//   }
//   return [countEven, countOdd, countZero]; 
// }
// const OddEvenZero = countOddEvenZero();
// console.log(OddEvenZero); 
// console.log(`There are ${OddEvenZero[0]} even, ${OddEvenZero[1]} odd and ${OddEvenZero[2]} zero`); 

//NOTES:
//LINE 282 - the right way to return multiple values.
  //return (`There are ${countEven} even, ${countOdd} odd and ${countZero} zero`); - can return as a string too.
  //return countEven, countOdd, countZero doesn't work this way, need to put values as an array
//LINE 285 - this is suitable for the return(`...`) string as on line 290
//LINE 286 - this is suitable for the return[] array on line 282.
//console.log (`There are ${countEven} even, ${countOdd} odd and ${countZero} zero`); - this is not gonna work because the values are inside the function and that's why I will have to declare new variables to hold values in this case
// const MyClickFunction =() => {
//   alert("Hello, Click")
// }
// const btn = document.querySelector("#HideShow")
// btn.addEventListener("click", MyClickFunction);

//SetInterval and SetTimout
//I want to have the background color switch between 2 colors
// let counter = 0;
// const XxX = document.querySelector("body");
// const interval = setInterval(() => {
//   counter++; //I need to change the state from one to another
//   XxX.style.background = "red"; //this sets the background to red
//   if (counter === 10) { //this specifies how many times the change will repeat
    
//     // clearInterval(interval);
//   }
//   else if (counter % 2 === 0) { //this tells the state to change every even second
//     XxX.style.background = "blue"; //this changes the background to blue
//   }
//   console.log("hello, Interval")
// }, 1000); //this specifies the interval length
//once you have this down make the background change between red and blue
//you can do this with a body selector and style

//Events
//On Events


