Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Hello As String = TextBox1.Text
        Dim World As String = TextBox2.Text
        TextBox3.Text = Hello + "," + " " + World
        TextBox4.Text = $"{Hello}, {World}"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Author As String = TextBox6.Text
        Dim Quote As String = RichTextBox1.Text
        RichTextBox1.Text = Author + ":" + Quote
        RichTextBox2.Text = $"{Author}: {Quote}"
    End Sub
End Class
