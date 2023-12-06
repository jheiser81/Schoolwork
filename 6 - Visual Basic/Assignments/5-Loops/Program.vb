Imports System
Imports System.Runtime.Intrinsics
Imports System.Security.Cryptography

Module Program
    Sub Main()
        'FOR LOOPS

        '-----Loop Exercise 1-----

        Dim index As Integer
        Dim sum As Integer
        For index = 0 To 100
            Console.WriteLine($"{index} + {sum} = {index + sum}")
            sum += index
        Next

        '--STEPS--

        '1) i and sum are declared and initialized to 0. i will be used as a loop counter and sum will be used to keep track of the running total.
        '2) A For loop is used to iterate over the values of i from 0 to 100 inclusive. The loop counter i is updated automatically by the loop.
        '3) Template literals used to show the calculation steps and prints to the console
        '4) The value of i is added to sum using the += operator. This updates the value of sum for the next iteration of the loop.

        '--NOTES--

        'sums all numbers from 1-100, incrementing by 1 each pass through
        '-sum = sum + i can be shortened by using compound statement "sum += i"
        '-used template literals to show the actual calculation steps, instead of just the answer

        Console.WriteLine() 'line break

        '-----Loop Exercise 2-----

        'METHOD 1

        'Dim newsum As Integer = 0
        'Dim counter As Integer
        'For counter = 1 To 9
        '    If counter Mod 2 = 0 Then
        '        Console.WriteLine($"Previous sum {newsum} + {counter} = {newsum + counter}")
        '        newsum += counter
        '    End If
        'Next
        'Console.WriteLine($"The sum of all the even numbers is {newsum}")

        Dim newsum As Integer = 0
        Dim counter As Integer
        For counter = 1 To 9
            If counter Mod 2 = 0 Then
                newsum += counter
                Console.WriteLine($"Adding {counter} to the sum, which is now {newsum}")
            Else
                Console.WriteLine($"Skipping {counter} because it is odd")
            End If
        Next
        Console.WriteLine($"The sum of all the even numbers is {newsum}")


        '--STEPS--

        '1) Declare a variable and set its initial value to 0. This variable will be used to store the sum of all the even numbers between the user's input.
        '2) Declare a second variable. This variable will be used as a counter in the loop that will iterate through all the numbers between the user's input.
        '3) Use a For loop to iterate through all the numbers between 1 and 9.
        '4) Using an if statement, check if the current value of the counter is even by using the Mod operator to determine if it is divisible by 2 with no remainder. If counter is even, add it to the sum variable.
        '5) Prints the sum of the even numbers and outputs to the console

        '--NOTES--

        '-output had to be outside the loop for it to work. Makes sense 
        '-combined for loop with if statement

        Console.WriteLine() 'line break

        'METHOD 2

        Dim num1 As Integer
        Dim num2 As Integer
        Dim evenSum As Integer = 0

        Console.Write("Enter the first number:")
        num1 = CInt(Console.ReadLine())
        Console.Write("Enter the second number:")
        num2 = CInt(Console.ReadLine())

        For x = num1 To num2
            If x Mod 2 = 0 Then
                Console.WriteLine(x)
                evenSum += x
            End If
        Next

        Console.WriteLine($"The sum of all the even numbers is {evenSum}")

        '--STEPS--

        '1) Declare three variables: num1 and num2 to hold the user's input, and evenSum to hold the sum of all even numbers found.
        '2) Prompt the user to enter the first number using Console.Write() And read their input from the console using Console.ReadLine(). Convert the input string to an integer using CInt() And assignit to num1.
        '3) Prompt the user to enter the second number using Console.Write() and read their input from theconsole using Console.ReadLine(). Convert the input string to an integer using CInt() and   assign it to num2.
        '4) Use a For loop to iterate over the range of numbers from num1 to num2, inclusive. For each number in the range, check whether it is even using the Mod operator. If the number is even, print it to the console using Console.WriteLine() and add it to evenSum.
        '5) Print the final output to the console using Console.WriteLine(). Use string interpolation to include the value of evenSum in the output string.

        Console.WriteLine() 'line break

        '-----Exercise 3-----

        Dim i, j As Integer
        Dim t As Boolean
        i = Console.ReadLine() 'or any other input number
        t = True
        For j = 2 To i - 1
            If i Mod j = 0 Then
                t = False
                Exit For
            End If
        Next
        If t = True Then
            Console.WriteLine("It is True. Your number is prime.")
        Else
            Console.WriteLine("It is False. Your number is not prime.")
        End If

        '1) Two variables, i and j, are declared as integers.
        '2) A Boolean variable t Is declared And set to True.
        '3) The Input number is assigned to i.
        '4) A For loop Is used to iterate from 2 to i minus 1. This loop checks all possible divisors of i to   determine if i Is prime.
        '5) The If statement checks whether i Is divisible by j using the Mod operator. If it Is, then t Is     set to False And the loop Is exited using the Exit For statement.
        '6) After the Loop finishes, t Is checked To see If it Is still True, which means that i Is prime. If   t Is True, a message Is printed To the console stating that the input number Is prime. If t Is      False, a message Is printed to the console stating that the input number Is Not prime.

        Console.WriteLine() 'line break

        'For index = 1 To 10
        '    If index = 5 Then
        '        Continue For
        '    End If
        '    If index = 7 Then
        '        Exit For
        '    End If
        '    Console.WriteLine(index)
        'Next

        'WHILE LOOPS
        'skips 5 and 7


        'ARRAYS
        Console.WriteLine("------------------")

        'METHOD 1

        Dim myArray() As Integer = {5, 1, 22, 4, 3}
        Dim arrsum As Integer = myArray.Sum()
        Console.WriteLine("The sum of the numbers in the array is: " & arrsum)

        'METHOD 2
        'Dim myArray() As Integer = {5, 1, 22, 4, 3}
        'Dim sum As Integer = myArray(0) + myArray(1) + myArray(2) + myArray(3) + myArray(4)
        'Console.WriteLine($"The sum of the numbers in the array is: {sum}")

        Console.WriteLine("--------------------")



        Dim myArray2() As Integer = {1, 5, 8, 0, 19, 4, 6, 15, 10, 13}
        Dim odd As Integer = 0
        Dim even As Integer = 0
        Dim zero As Integer = 0

        For i As Integer = 0 To myArray2.GetUpperBound(0)
            If myArray2(i) = 0 Then
                zero += 1
            ElseIf myArray2(i) Mod 2 = 0 Then
                even += 1
            Else
                odd += 1
            End If
        Next

        Console.WriteLine("There are " & odd & " odd, " & even & " even, and " & zero & " zero(s) in the array.")

        'Dim myArray() As Integer = {1, 5, 8, 0, 19, 4, 6, 15, 10, 13}
        'Dim oddCount As Integer = 0
        'Dim evenCount As Integer = 0
        'Dim zeroCount As Integer = 0

        'For index = 0 To myArray.GetUpperBound(0)
        '    If myArray(index) = 0 Then
        '        zeroCount += 1
        '    ElseIf myArray(index) Mod 2 = 0 Then
        '        evenCount += 1
        '    Else
        '        oddCount += 1
        '    End If
        'Next

        'Console.WriteLine("There are " & oddCount & " odd, " & evenCount & " even, and " & zeroCount & " zero(s) in the array.")

        '1) Dim myArray() As Integer = {1, 5, 8, 0, 19, 4, 6, 15, 10, 13}
        'This line declares an array variable named myArray And initializes it with 10 integers. The integers are hard-coded in curly braces {} And separated by commas. This array contains 10 unique numbers between 0 And 20.

        '2) Dim oddCount As Integer = 0
        'Dim evenCount As Integer = 0
        'Dim zeroCount As Integer = 0
        'These lines declare three integer variables named oddCount, evenCount, and zeroCount and initialize them to 0. These variables will be used to count the number of odd, even, and zero elements in the array, respectively.

        '3)For index = 0 To myArray.GetUpperBound(0)
        'If myArray(Index) = 0 Then
        '    zeroCount += 1
        'ElseIf myArray(Index) Mod 2 = 0 Then
        '    evenCount += 1
        'Else
        '    oddCount += 1
        'End If
        'Next

        'This is a For loop that iterates through each element of the myArray array. The GetUpperBound(0) method is used to get the upper bound of the first dimension of the array, which is the same as the index of the last element in the array. This ensures that we loop through all elements of the array.

        'Inside the Loop, we use an If statement To check whether the current element Is equal To zero, even, Or odd.If the current element Is equal To zero, we increment the zeroCount variable by 1. If the current element Is even (i.e., its remainder when divided by 2 Is zero), we increment the evenCount variable by 1. Otherwise, we increment the oddCount variable by 1.

        '4) Console.WriteLine("There are " & oddCount & " odd, " & evenCount & " even, and " & zeroCount & " zero(s) in the array.")

        'This line outputs the counts of odd, even, and zero elements in the array to the console. The counts are concatenated with the strings "There are", "odd,", "even,", and "zero(s) in the array." using the ampersand & operator, and the result is passed as an argument to the Console.WriteLine() method. The output string will look like "There are 5 odd, 4 even, and 1 zero(s) in the array."

        'Create an array of 10 unique numbers from 0 - 20,
        'count how many odd numbers, even numbers
        '(that aren't zero) and zeros there are in the array.
        'Input = 1, 5, 8, 0, 19, 4, 6, 15, 10, 13
        'Output = “There are 5 odd, 4 even and 1 zero”

        Console.WriteLine("----------------------")

        Randomize()
        Dim oddCount As Integer = 0
        Dim evenCount As Integer = 0
        Dim zeroCount As Integer = 0
        Dim numbers(99) As Integer

        For i = 0 To 99
            numbers(i) = Int(Rnd() * 101)
        Next

        For i = 0 To 99
            If numbers(i) = 0 Then
                zeroCount += 1
            ElseIf numbers(i) Mod 2 = 0 Then
                evenCount += 1
            Else
                oddCount += 1
            End If
        Next

        Console.WriteLine("Odd numbers: " & oddCount)
        Console.WriteLine("Even numbers: " & evenCount)
        Console.WriteLine("Zero numbers: " & zeroCount)

        '--STEPS--

        '1) Use the Randomize function to initialize the random number generator 
        '2) Declare an array of integers with a length of 100
        '3) Declare three integer variables to store the counts of odd, even, and zero numbers
        '4) Use a loop to generate 100 random numbers and assign them to the elements of the array
        '5) Use a loop to iterate through the array and count the number of odd, even, and zero numbers
    End Sub
End Module

