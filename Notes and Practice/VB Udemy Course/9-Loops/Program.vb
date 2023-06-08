Imports System

Module Program
    Sub Main()
        Dim i As Integer

        'For Loop
        Console.WriteLine("For Loop")
        Console.WriteLine("--------")
        For i = 0 To 100 'When loop starts, i = 0. Keep running loop until i = 100. Variable is assigned within loop
            Console.WriteLine(i)
        Next 'Ends for loop

        Console.WriteLine() 'Creates an empty line, used as a line break

        ''While Loop
        'Console.WriteLine("While Loop")
        'Console.WriteLine("--------")
        'i = 0 'Set i to 0. Variable must be assigned before the loop
        'While i <= 100
        '    Console.WriteLine(i) 'outputs value of i while i is less than or equal to 100
        '    i += 1 'increments i by 1 each loop, until it reaches 100 (condition is met)
        'End While 'Ends while loop

        'Console.WriteLine()

        ''Do While Loop
        'Console.WriteLine(" Do While Loop")
        'Console.WriteLine("--------")
        'i = 0 'Set value of variable
        'Do 'This will make the code run at least once 
        '    Console.WriteLine(i)
        '    i += 1 'increments by 1
        'Loop While (i <= 100) 'Sets condition to be checked
        ''Do While loop is similar to While Loop, but will always run at least once before the condition is checked
        'Dim index As Integer
        'For index = 1 To 5

        '    Console.WriteLine(index)
        'Next

        'Dim i As Integer
        'Dim sum As Integer
        'For i = 0 To 100
        '    sum = sum + i 'had to be inside the loop or it wouldn't work
        '    'Console.WriteLine(i + sum)
        '    Console.WriteLine($"{i} + {sum} = {i + sum}")
        'Next

        'Console.WriteLine()

        'Dim sum As Integer = 0
        'Dim i As Integer
        'For i = 1 To 9
        '    If i Mod 2 = 0 Then
        '        sum = sum + i
        '    End If
        'Next
        'Console.WriteLine($"The sum of all the even numbers is {sum}")


    End Sub
End Module
