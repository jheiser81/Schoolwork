Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Meeko As New Dog("Meeko", 2, "Terrier", "White and brown spotted")
        RichTextBox1.Text += vbCrLf + Meeko.Print()
        Dim Sparky As New Dog(Meeko)
        RichTextBox1.Text += vbCrLf + Sparky.Print()
        Dim molly As New Dog()
        molly.SetName("Molly")
        molly.SetAge(3)
        RichTextBox1.Text += molly.Print()
    End Sub
End Class
