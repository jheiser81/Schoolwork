Imports System

Module Program
    Sub Main()
        Dim uniqueArray() As Integer = {1, 5, 8, 0, 19, 4, 6, 15, 10, 13}
        Dim odd As Integer = 0
        Dim even As Integer = 0
        Dim zero As Integer = 0
        For index = 0 To uniqueArray.GetUpperBound(0) 'grabs the index of the last number in the array each pass through
            If uniqueArray(index) = 0 Then 'place the index inside the array
                zero += 1
            ElseIf uniqueArray(index) Mod 2 = 0 Then
                even += 1
            ElseIf uniqueArray(index) Mod 2 <> 0 Then
                odd += 1
            End If
        Next
        Console.WriteLine($"There are {even} even numbers, {odd} odd numbers, and {zero} zero numbers in the array.")
        'Create an array Of 10 unique numbers from 0 - 20,
        'count how many odd numbers, even numbers
        '(that aren't zero) and zeros there are in the array.
        'Input = 1, 5, 8, 0, 19, 4, 6, 15, 10, 13
        'Output = “There are 5 odd, 4 even and 1 zero”

        Console.WriteLine("----------------------------")

        Dim smallArray() As Integer = {1, 5, 6, 9, 15}
        Dim smallArraySum As Integer = smallArray.Sum
        Console.WriteLine($"The sum of the numbers in the array is: {smallArraySum}.")

        Console.WriteLine("-----------------------------")
    End Sub
End Module
