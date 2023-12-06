Imports System.Drawing.Text
Imports System.Reflection.Metadata.Ecma335

Public Class Form1
    'Function MyFunc(x As Integer)
    '    If x = 0 Then
    '        Return x
    '    End If
    '    RichTextbox1.text += x.ToString() + ", "
    '    Return MyFunc(x - 1)
    'End Function
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'MessageBox.Show(MyFunc(10))
    'End Sub
    'Function factorial(x As Integer)
    '    Dim fact As Integer = 1
    '    For index = 1 To x
    '        fact *= index
    '    Next
    '    Return fact
    '    
    Function MyFunc(x As Integer)
        If x = 0 Then
            Return x
        End If
        RichTextBox2.text += x.tostring() + ", "
        Return MyFunc(x - 1)
    End Function

    Function factorial(x As Integer) As Integer
        Dim fact As Integer = 1
        For index = 1 To x 'we start from 1, because 0*0=0
            RichTextBox2.Text += $"{fact} * {index} = {fact * index}"
            fact *= index
        Next
        Return fact 'fact is the final number
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(factorial(10))
        MessageBox.Show(factorial(5)) 'this is where we assign the value to factorial function, which is 
    End Sub
End Class
