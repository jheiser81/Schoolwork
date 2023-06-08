Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myArray() As Integer = {5, 1, 22, 4, 3}
        Dim arrsum As Integer = myArray.Sum()
        RichTextBox1.Text = $"The sum of the numbers in the array is: {arrsum}"

        '--Sum the numbers in an array--
        '1. Declare a new array, add numbers inside {} which will hardcode the numbers
        '2. .Sum() will sum the value of the integers in the array
        '3. Output 
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim months() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        For index = 0 To months.GetUpperBound(0)
            RichTextBox2.Text += months(index) + ", "
        Next

        '--Create an array of strings--
        '1. Declare a new array
        '2. Make a For loop that iterates over each element of the months array. The loop variable index is initially set to 0 and is incremented by 1 each time the loop iterates. 
        '3. During each iteration of the loop, the name of the current month (retrieved by accessing the months array with the current value of index) is concatenated with a comma and a space
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim names() As String = {"John", "Sam", "Jen", "Carry", "Eugene", "John"}
        Dim count As Integer = 0
        For index = 0 To names.GetUpperBound(0)
            RichTextBox3.Text += names(index) + ", "
            If names(index) = TextBox1.Text Then
                count += 1
            End If
        Next
        If count = 1 Then
            RichTextBox3.Text = $"The name {TextBox1.Text} appears {count} time."
        Else
            RichTextBox3.Text = $"The name {TextBox1.Text} appears {count} times."
        End If

        'make an array of names
        'make a variable to count
        'going to need a for loop
        'going to need if statement, how to format?
        'make dynamic by using textbox.text to enter a user input
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim myarray As Integer() = {1, 5, 8, 0, 19, 4, 6, 15, 10, 13}
        Dim odd As Integer = 0
        Dim even As Integer = 0
        Dim zero As Integer = 0
        For index = 0 To myarray.GetUpperBound(0)
            If myarray(index) = 0 Then
                zero += 1
            ElseIf myarray(index) Mod 2 Then
                even += 1
            Else
                odd += 1
            End If
        Next
        RichTextBox4.Text = $"There are {even} even numbers, {odd} odd numbers, and {zero} zero numbers in the array."
        'Create an array Of 10 unique numbers from 0 - 20,
        'count how many odd numbers, even numbers, and zero numbers
        '(that aren't zero) and zeros there are in the array.
        'Input = 1, 5, 8, 0, 19, 4, 6, 15, 10, 13
        'Output = “There are 5 odd, 4 even and 1 zero”
    End Sub
End Class