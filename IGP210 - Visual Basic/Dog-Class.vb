Public Class Dog
    '' these are your properties, whcih can be called data members 
    Private name As String
    Private age As Integer
    Private breed As String
    Private color As String

    Public Sub New() '' this is a defatult constructor 
        name = ""
        age = 0
        breed = ""
        color = ""
    End Sub
    Public Sub New(name As String, age As Integer, breed As String, color As String) 'this is an overloaded constructor
        Me.name = name
        Me.age = age
        Me.breed = breed
        Me.color = color
    End Sub
    Public Sub New(dog As Dog)
        Me.name = dog.name
        Me.age = dog.age
        Me.breed = dog.breed
        Me.color = dog.color
    End Sub
    Public Function Print() As String

        Return $"Hi, my name is {name} a {breed} who is {age}, and I have a {color} Coat"
    End Function
End Class
