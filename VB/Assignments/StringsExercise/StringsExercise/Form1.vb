Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FirstName As String = TextBox1.Text
        Dim LastName As String = TextBox2.Text
        Dim Age As Integer = Convert.ToInt32(TextBox3.Text)
        TextBox4.Text = $"Hello, {FirstName} {LastName}, you are {Age} years old."
        MessageBox.Show($"Hello, {FirstName} {LastName}, you are {Age} years old.")
        'built in function similar to Alert in js
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Place As String = TextBox5.Text
        Dim Friend_Name As String = TextBox6.Text
        Dim Activity As String = TextBox7.Text
        Dim Thing1 As String = TextBox8.Text
        Dim Thing2 As String = TextBox9.Text
        Dim Thing3 As String = TextBox10.Text
        Dim Result As String = TextBox11.Text
        RichTextBox1.Text = $"Hi! Last week I went {Place}. My friend {Friend_Name} and I had so much {Activity}. There were {Thing1} and {Thing2} and a really fat {Thing3}. When we saw it we felt really {Result}. You should come next time!" 'template literals allow for greater control over string concatenation 


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim bday As String
        bday = "Happy Birthday"
        MessageBox.Show(bday(0))
    End Sub
End Class
