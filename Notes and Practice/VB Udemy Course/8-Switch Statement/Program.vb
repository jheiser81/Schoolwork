Imports System

Module Program
    Sub Main()
        Dim MyInput As Integer
        MyInput = Console.ReadLine()
        'If (MyInput = 1) Then
        '    Console.WriteLine("Menu Option 1 is selected")
        'ElseIf (MyInput = 2) Then
        '    Console.WriteLine("Menu Option 2 is selected")
        'ElseIf (MyInput = 3) Then
        '    Console.WriteLine("Menu Option 3 is selected")
        'ElseIf (MyInput = 4) Then
        '    Console.WriteLine("Menu Option 4 is selected")
        'Else
        '    Console.WriteLine("Invalid Option")
        'End If

        Select Case MyInput
            Case 1
                Console.WriteLine("Menu Option 1 is selected")
            Case 2
                Console.WriteLine("Menu Option 2 is selected")
            Case 3
                Console.WriteLine("Menu Option 3 is selected")
            Case 4
                Console.WriteLine("Menu Option 4 is selected")
            Case Else
                Console.WriteLine("Invalid Option")
        End Select
    End Sub
End Module
