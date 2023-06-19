Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FirstName As String
        Dim LastName As String
        Dim fullName As String
        firstName = txtFirstName.Text
        lastName = txtLastName.Text
        fullName = FirstName & " " & LastName
        MessageBox.Show(fullName)
    End Sub
End Class
