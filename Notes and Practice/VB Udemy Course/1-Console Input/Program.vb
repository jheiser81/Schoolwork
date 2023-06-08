Imports System

Module Program
    Sub Main()
        Dim Num1 As Integer 'Declares variable as a number (integer)
        Num1 = 10 'Assigns variable value
        Console.WriteLine(Num1) 'outputs variable to the console window
        Dim Num2 As Integer
        Num2 = 5
        Console.WriteLine(Num2)
        Console.WriteLine(Num1 + Num2)
        Console.WriteLine(Num1 - Num2)
        Console.WriteLine(Num1 * Num2)
        Console.WriteLine(Num1 / Num2)
        Console.WriteLine(Num1 Mod Num2)

        Dim FirstName As String
        Console.Write("Enter First Name:") 'The Console class uses Write() or WriteLine() to display values in the DOS window. As opposed to displaying something on the screen, you may want to request a value from the user. To support this, the Console class provides the Read() method.
        FirstName = Console.ReadLine() ' 'When the user types something and presses Enter, what the user had typed would be assigned to the variable specified on the left side of the assignment operator.
        'Besides Read(), the Console class also provides ReadLine(). Like WriteLine(), after performing its assignment, ReadLine() sends the caret to the next line. Otherwise, it plays the same role as the Read() function.

        'Console.WriteLine("Input a number")
        'Num2 = Console.ReadLine() 'reads a user input
        'Console.WriteLine(Num2)
        'Console.WriteLine(Num1 + Num2)
        'Console.WriteLine(Num1 - Num2)
        'Console.WriteLine(Num1 * Num2)
        'Console.WriteLine(Num1 / Num2)
        'Console.WriteLine(Num1 Mod Num2)
        Console.Write("Awesome," + " you are amazing ") 'Console.write will output to the same line
        Console.WriteLine("Hello, World!") 'Console.Writeline will output to the next line
        Console.WriteLine("Project")

    End Sub
End Module
