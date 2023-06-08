Imports System
Imports System.ComponentModel.Design
Imports System.Runtime.InteropServices

Module Program
    Sub Main()
        Dim MyInput As Integer
        MyInput = Console.ReadLine() 'Asks for a user input
        If (MyInput = 1) Then 'Syntax: If (Condition is true) Then Console.WriteLine(code) End If
            Console.WriteLine("Menu Option 1 is selected") 'Prints text if condition is true, if not, does not print
        ElseIf (MyInput = 2) Then
            Console.WriteLine("Menu Option 2 is selected") 'Prints text if condition is true, if not, does not print
        ElseIf (MyInput = 3) Then
            Console.WriteLine("Menu Option 3 is selected") 'Prints text if condition is true, if not, does not print
        ElseIf (MyInput = 4) Then
            Console.WriteLine("Menu Option 4 is selected") 'Prints text if condition is true, if not, does not print
        Else                                       'Else statement will run code as default if no other condition is true
            Console.WriteLine("Invalid Option")
        End If

        Dim x As Integer = 22
        Dim y As Integer = 55
        If x <> y And Not (x <> 22) Or y > 65 Then
            'True because Or statement needs only 1 true result to equal true
            Console.WriteLine("True")
        Else
            Console.WriteLine("False")
        End If



    End Sub
End Module
