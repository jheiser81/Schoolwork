Imports System

Module Program
    Sub Main()
        Const Var1 As Integer = 4 'Specifies the variable is contant. Value must be assigned on the same line
        Dim Var2 As Integer
        Var2 = 5

        Console.WriteLine(Var1)
        Console.WriteLine(Var2)
        Console.WriteLine(Var1 + Var2)

        Var2 = Var1 'This will still run, because var2 is a normal variable
        Var1 = Var2 'This will not work, because Var1 is a constant variable, so cannot be changed or reassigned

    End Sub
End Module
