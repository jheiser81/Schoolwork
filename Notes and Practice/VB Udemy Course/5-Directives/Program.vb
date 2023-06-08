Imports System
Imports System.Linq.Expressions

Module Program
#Const name = "Joel" 'creates a variable before compilation takes place, which can't be changed
    Sub Main()
#If name = "Noel" Then 'This doesn't work because variable was declared before compilation, so it decides what is being compiled and what is not being compiled
        Console.WriteLine("Enter") 
#End If

        '#Const constname = expression https://learn.microsoft.com/en-us/dotnet/visual-basic/language-reference/directives/const-directive
        '#If expression Then
        '   statements
        '[ #ElseIf expression Then
        '   [ statements ]
        '...
        '#ElseIf expression Then
        '   [ statements ] ]
        '[ #Else
        '   [ statements ] ]
        '#End If
        'Expression
        'Required for #If And #ElseIf statements, optional elsewhere. Any expression, consisting exclusively Of one Or more conditional compiler constants, literals, And operators, that evaluates to True Or False.

        'Statements
        'Required for #If statement block, optional elsewhere. Visual Basic program lines Or compiler directives that are compiled if the associated expression evaluates to True.

        '#End If
        'Terminates the #If statement block.
        'https://learn.microsoft.com/en-us/dotnet/visual-basic/language-reference/directives/if-then-else-directives
    End Sub
End Module
