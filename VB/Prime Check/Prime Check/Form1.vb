

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'METHOD ONE

        'Dim i, j As Integer
        'Dim t As Boolean
        'i = TextBox1.Text
        't = True
        'For j = 2 To i - 1
        '    If i Mod j = 0 Then
        '        t = False
        '    End If
        'Next
        'If t = True Then
        '    MessageBox.Show("The number " & i & " is a Prime Number.")
        'Else
        '    MessageBox.Show("The number " & i & " is not a Prime Number")
        'End If

        '1) Declare two integer variables i And j, And a boolean variable t.()
        '2) Assign the value Of the user input from a textbox To the i variable.
        '3) Initialize the Boolean variable t As True. This variable will be used To determine whether Or Not i Is a prime number.
        '4) Use a For Loop To iterate through all the numbers between 2 And i-1. We don't need to check for numbers less than 2 since they are not prime numbers.
        '5) Inside the For Loop, check If i Is divisible by the current value Of j Using the modulo Operator. If it Is divisible, it means that i Is Not a prime number, so Set the value Of t To False.
        '6) After the Loop, check the value Of t. If it Is still True, it means that i Is a prime number, so display a message box indicating that. Otherwise, display a message box indicating that i Is Not a prime number.

        'Overall, this code works by iterating through all the numbers between 2 And i-1 And checking if i Is divisible by any of them. If i Is Not divisible by any of them, it Is a prime number.
        'This method requires LINQ (Language Integrated Query) by using imports.system.linq

        'METHOD 2

        Dim i, j As Integer
        Dim isPrime As Boolean = True

        i = TextBox1.Text

        If i < 2 Then
            isPrime = False
        End If

        For j = 2 To Math.Sqrt(i)
            If i Mod j = 0 Then
                isPrime = False
                Exit For
            End If
        Next

        If isPrime Then
            MessageBox.Show("The number " & i & " is a Prime Number.")
        Else
            MessageBox.Show("The number " & i & " is not a Prime Number.")
        End If

        'In this alternative solution, instead of using the LINQ method, it uses Math.Sqrt method to determine the upper limit of the loop for checking prime numbers. The Exit For statement is used to break out of the loop as soon as a factor of i is found, which reduces the number of iterations required to check whether the number is prime.


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer = 0
        While i < 10
            RichTextBox1.Text += i.ToString() + ", "
            i += 1
        End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        '-----METHOD 1-----
        'Randomize()
        Dim myRandom As Single = 0
        RichTextBox2.Text = ""
        While myRandom <> 42
            myRandom = Int((100 * Rnd()) + 1)
            RichTextBox2.Text += myRandom.ToString() + ", "
        End While

        '1) Randomize() is called To initialize the random number generator.
        '2) The variable myRandom Is declared And initialized to 0.
        '3) The Text Property Of RichTextBox2 Is Set To an empty String, which clears the contents of the control.
        '4) The While loop Is started. The loop will continue to execute as long as the value of myRandom Is Not equal to both 42.
        '5) Inside the Loop, a random number between 1 And 100 Is generated using the Rnd() function And  the Int() function Is used to convert it to an integer. The generated number Is assigned to the variable myRandom.
        '6) The generated number Is appended to the Text property of RichTextBox2 using the ToString() method And the concatenation operator +. A comma And a space are added after the number to separate it from the next number that will be printed.
        '7) The loop continues to execute until myRandom Is equal to 42 Or 62, at which point the loop will exit And the program will continue executing any subsequent code.

        '--Notes--
        ' The Rnd Function In Visual Basic generates a random number between 0 And 1. It uses a pseudorandom number generator algorithm To produce the random number. The algorithm Is deterministic, which means that it will always produce the same sequence of random numbers when given the same starting seed.

        'By default, the Rnd Function uses the system timer As the seed, so Each time the program Is run, it will produce a different sequence Of random numbers. However, you can set the seed using the Randomize statement to produce a specific sequence of random numbers.

        'The Rnd Function can be used To generate random integers by multiplying the random number by the range Of values you want To generate And Then rounding the result To an Integer. For example, to generate a random integer between 1 And 100, you can use the following code:

        'Dim randomNumber As Integer
        'randomNumber = Int((100 * Rnd()) + 1)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim myArray() As Integer = {5, 1, 22, 4, 3}
        Dim sum As Integer = myArray.Sum()
        MessageBox.Show($"The sum of the array is: {sum}")



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim counter As Integer
        counter = RichTextBox3.Text
        For i = 1 To 9
            If i Mod 2 = 0 Then
                counter = counter + i
            End If
        Next
        RichTextBox3.Text += counter.ToString() + ", "
    End Sub
End Class
