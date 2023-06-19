Imports System.Windows.Forms.Design

Public Class Form1
    Dim boardArray(4, 4) As String 'vb requires 5x5 to be written as 4x4 because it counts 0 as a starting point? I guess?
    'boardArray is declared as global variable so it can be accessed anywhere
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myUniqueArray() As Integer = {1, 5, 8, 0, 19, 4, 6, 15, 10, 13}
        Dim evenCount As Integer = 0
        Dim oddcount As Integer = 0
        Dim zerocount As Integer = 0
        For index = 0 To myUniqueArray.GetUpperBound(0)
            If myUniqueArray(index) = 0 Then
                zerocount += 1
            ElseIf myUniqueArray(index) Mod 2 = 0 Then
                evenCount += 1
            ElseIf myUniqueArray(index) Mod 2 <> 0 Then
                oddcount += 1
            End If
        Next
        RichTextBox3.Text = $"There are {oddcount} odd, {evenCount} even, and {zerocount} zero numbers."

        '---In Class Exercise 1---
        'Create an array Of 10 unique numbers from 0 - 20,
        'count how many odd numbers, even numbers
        '(that aren't zero) and zeros there are in the array.
        'Input = 1, 5, 8, 0, 19, 4, 6, 15, 10, 13
        'Output = “There are 5 odd, 4 even and 1 zero”
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myArray(100) As Integer 'Sets the array length to 100
        Dim odd As Integer = 0
        Dim even As Integer = 0
        Dim zero As Integer = 0
        Dim myRandom As Integer = 0
        Dim printArray As String = ""
        Dim smallest As Integer = 0
        Dim largest As Integer = 0
        Dim avg As Double = 0
        Dim sum As Integer = 0
        For index = 0 To myArray.GetUpperBound(0)
            myRandom = Int((100 * Rnd()) + 1)
            'every time the loop runs, it generates a new random number that will be saved in the myRandom variable
            myArray(index) = myRandom 'myArray(index) is the place where the random number is saved
            printArray += Convert.ToString(myRandom) + ", " 'saves all the random numbers
            If myArray(index) = 0 Then
                zero += 1
            ElseIf myArray(index) Mod 2 = 0 Then
                even += 1
            Else
                odd += 1
            End If
        Next
        RichTextBox1.Text = printArray + ($"Even numbers: {even}, Odd numbers: {odd}, Zero numbers {zero} {vbCrLf}")


        '-----Exercise 2-----
        'Create an array Of 100 random numbers, then
        'calculate how many odd numbers, even numbers
        '(even excluding 0) And zeros there are in the
        'Array.


    End Sub
    '-----Exercise 3-----
    'Use the same array in exercise 2 to check for the
    'largest number, smallest number, add the whole
    'Array together, And find the average.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myArray(100) As Integer
        Dim odd As Integer = 0
        Dim even As Integer = 0
        Dim zero As Integer = 0
        Dim myRandom As Integer = 0
        Dim printArray As String = ""
        Dim smallest As Integer = 0
        Dim largest As Integer = 0
        Dim avg As Double = 0
        Dim sum As Integer = 0
        For index = 0 To myArray.GetUpperBound(0)
            myRandom = Int((100 * Rnd()) + 1)
            myArray(index) = myRandom
            printArray += Convert.ToString(myRandom) + ", "
            If myArray(index) = 0 Then
                zero += 1
            ElseIf myArray(index) Mod 2 = 0 Then
                even += 1
            Else
                odd += 1
            End If
            If index = 0 Then 'initiaze to 0 at the beginning
                smallest = myArray(index)
                largest = myArray(index)
            Else
                If myArray(index) < smallest Then
                    smallest = myArray(index)
                End If

                If myArray(index) > largest Then
                    largest = myArray(index)
                End If
            End If
            sum += myArray(index)
        Next
        avg = sum / myArray.Length 'avg was inside the loop and being calculated with GetUpperBound, which was only getting the last number 
        RichTextBox4.Text = printArray + ($"Largest: {largest}, smallest: {smallest}, sum of numbers: {sum}, average of numbers: {avg}")
    End Sub
    'Declare and ()initialize variables: The code begins by declaring And initializing a number Of variables that will be used later In the Loop. These include an Integer array (myArray) With 100 slots, And several Integer variables (odd, even, And zero) that will be used To keep track Of how many odd, even, And zero values are In the array. The code also declares Integer variables To store the smallest And largest values (smallest And largest, respectively), the sum Of all the values In the array (sum), And the average value Of the array (avg).

    'Generate random values For array: The code Then enters a Loop that will generate random Integer values between 1 And 100 And store them In the myArray array. Each time a value Is generated, it Is added To a String (printArray) that will be used later To display the array.

    'Count number Of odd, even, And zero values: Within the Loop, the code checks Each value In the myArray array To see If it Is odd, even, Or zero. Depending On the value, it increments one Of the three variables (odd, even, Or zero).

    'Find smallest And largest values, calculate sum: Also within the Loop, the code checks Each value In the myArray array To see If it Is smaller than the current smallest value Or larger than the current largest value. If it Is, the appropriate variable Is updated. Additionally, Each value In the myArray array Is added To the sum variable.

    'Calculate average value: After the Loop completes, the code calculates the average value Of the array by dividing the sum variable by the length Of the array (myArray.Length).

    'Display results : Finally, the code displays the printArray String (which contains all the values In the array), As well As the smallest, largest, And avg values.
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim months() As String = {"Janaury", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Decemeber"}
        For index = 0 To months.GetUpperBound(0)
            For innerIndex = 0 To months(index).Length - 1
                RichTextBox5.Text += months(index)(innerIndex) + ", "
            Next
            RichTextBox5.Text += vbCrLf
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim months() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

        For index = 0 To months.GetUpperBound(0)
            RichTextBox6.Text += months(index) + ", "
        Next
    End Sub
    Sub PrintBoard() 'creates a function
        RichTextBox7.Clear() 'clears the board
        For index = 0 To boardArray.GetUpperBound(0) '
            For innerindex = 0 To boardArray.GetUpperBound(1)
                RichTextBox7.Text += boardArray(index, innerindex)
            Next
            RichTextBox7.Text += vbCrLf
        Next
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For index = 0 To boardArray.GetUpperBound(0)
            For innerIndex = 0 To boardArray.GetUpperBound(1)
                boardArray(index, innerIndex) = " * "
            Next
        Next
        PrintBoard()

        '--Exercise 1--
        'Using a multidimensional array populate(fill up) the array And print out a 5 x 5 tile board Like the one below into a rich textbox
        '* * * * *
        '* * * * *
        '* * * * *
        '* * * * *
        '* * * * *
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim x As Integer = TextBox1.Text
        Dim y As Integer = TextBox2.Text
        boardArray(y, x) = "x"
        PrintBoard()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim names() As String = {"John", "Sam", "Jen", "Carry", "Eugene", "John"}
        Dim count As Integer = 0
        For index = 0 To names.GetUpperBound(0)
            RichTextBox8.Text += names(index) + ", "
            If names(index) = TextBox3.Text Then
                count += 1
            End If
        Next
        If count = 1 Then
            MessageBox.Show($"The name {TextBox3.Text} appears {count} time.")
        Else
            MessageBox.Show($"The name {TextBox3.Text} appears {count} times.")
        End If

        'make an array of names
        'make a variable to counter
        'going to need a for loop
        'going to need if statement, how to format?
        'make dynamic by using textbox.text to enter a user input
    End Sub
    '--Exercise 2--
    'Create a program that has an array Of names.
    'When the program runs calculate how many times the name Is repeated.

    'Input = {John, Sam, Jen, Bob, Carry, Eugine, John}

    'The output will be:

    'Name
    'John: 2 times

    'If
    'there Is only one name you will have to output:

    'Name
    'John: 1 time
End Class


