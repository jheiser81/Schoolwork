Public Class Dog
    'these are the properties, which can be called data members
    Private name As String
    Private age As Integer
    Private breed As String
    Private color As String
    Public Sub New() 'this is called a "constructor"
        name = ""
        age = 0
        breed = ""
        color = ""
    End Sub
    Public Sub New(name As String, age As Integer, breed As String, color As String)
        'this is an "overloaded" constructor
        'me.name is the name of the class
        Me.name = name
        Me.age = age
        Me.breed = breed
        Me.color = color
    End Sub
    Public Sub New(dog As Dog) 'copy constructor
        Me.name = dog.name
        Me.age = dog.age
        Me.breed = dog.breed
        Me.color = dog.color
    End Sub
    Public Function Print() As String 'member function
        Return $"Hi, my name is {name}, I am {age} years old. I am a {breed} with {color} coloring."
    End Function
    Public Function GetName() As String
        Return name
    End Function
    Public Sub SetName(name As String)
        Me.name = name
    End Sub
    Public Function GetAge() As String
        Return age
    End Function
    Public Sub SetAge(age As Integer)
        If age < 30 And age >= 0 Then
            Me.age = age
        Else
            Me.age = 0
        End If
    End Sub
End Class
'objects are held in classes
'objects have data members(properties). These are the variables for the classs
'
