Imports System

Module Program
    Enum Phones
        iPhone = 6 'defined value
        Samsung 'no defined value, so it increments by 1
        Google = 90
        Other
    End Enum
    Sub Main()
        Console.WriteLine(Phones.iPhone) 'has a value starting at 0, if not defined
        Console.WriteLine(Phones.Samsung) 'value increments by 1 if not defined
        Console.WriteLine(Phones.Google) 'value increments by 1 if not defined
        Console.WriteLine(Phones.Other) 'value increments by 1 if not defined

        'Enumerations offer an easy way to work with sets of related constants. An enumeration, or Enum, is a symbolic name for a set of values. Enumerations are treated as data types, and you can use them to create sets of constants for use with variables and properties. https://learn.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/constants-enums/when-to-use-an-enumeration
    End Sub
End Module
