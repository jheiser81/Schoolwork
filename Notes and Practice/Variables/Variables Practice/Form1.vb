Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim author As String = "William Blake said:"
        Dim quote As String = "He who binds To himself a joy Does the winged life destroy; But he who kisses the joy As it flies Lives In eternity's sun rise."
        RichTextBox2.Text = $"{author + vbCrLf + quote}"
    End Sub
End Class
