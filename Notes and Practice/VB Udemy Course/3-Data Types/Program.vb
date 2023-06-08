Imports System

Module Program
    Sub Main()
        Dim IntVar As Integer 'Declares variable as a whole number (integer)
        IntVar = 214748364 'Does not work because the integer type has limited max value

        Dim LongVar As Long
        LongVar = 2147483648 'Works because the integer type has higher max value
        'LongVar = 4.5 'This does not work because of the data type

        Dim DecimalVar As Double
        DecimalVar = 4.5

        Dim CharVar As Char 'This specifies the variable is a single character
        CharVar = "A"

        Dim StringVar As String 'This specifies the variable is a string, or combination of characters
        StringVar = "Hello, World"

        Dim BoolVar As Boolean 'This specifies the variable as being a boolean, or true/false 
        BoolVar = True

        Console.WriteLine(IntVar)
        Console.WriteLine(LongVar)
        Console.WriteLine(DecimalVar)
        Console.WriteLine(CharVar)
        Console.WriteLine(StringVar)
        Console.WriteLine(BoolVar)

        Console.WriteLine()

        'Dim MyInt As Integer
        'Dim MyInt2 As Integer
        'MyInt = 55
        'MyInt2 = 40
        'Console.WriteLine(MyInt = MyInt2 + 15)
        'True

        'Console.WriteLine()

        'Dim MyString As String = "55"
        'Dim MyInt As Integer = 55
        'Console.WriteLine(MyInt <> MyString)
        ''False

        'Dim MyInt As String = 1
        'Dim MyInt2 As Integer = 55
        'Console.WriteLine(MyInt < MyInt2)
        ''True

        'Dim MyInt As String = 1
        'Dim MyInt2 As Integer = 55
        'Console.WriteLine(MyInt > MyInt2)
        ''False

        'Dim MyInt As Integer = 1
        'Dim MyInt2 As Integer = 55
        'Console.WriteLine(MyInt > MyInt2 And (MyInt <> 42))
        ''False

        'Dim MyInt As Integer = 1
        'Dim MyInt2 As Integer = 55
        'Console.WriteLine(MyInt > MyInt2 Or (MyInt <> 42))
        ''True

        'Dim MyInt As Integer = 1
        'Dim MyInt2 As Integer = 55
        'Console.WriteLine(MyInt > MyInt2 And Not (MyInt = 1))
        ''False

        'Dim MyInt As Integer = 1
        'Dim MyInt2 As Integer = 55
        'Console.WriteLine(MyInt > MyInt2 And (MyInt = 1))
        ''False





    End Sub

End Module
