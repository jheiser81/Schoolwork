Public Class Form1
    Sub Print()
        RichTextBox1.Text += "Hello, Sub!"
        'This is a user-created subroutine called Print()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Print()
        'Calls the Print() subroutine on form load
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Print()
        'Calls the Print() subroutine again on button click
    End Sub
End Class

'When we call a function, it means we are going to be running it on that specific line.
