Imports System.Net.Security

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer 'declares variable as an integer
        Dim num2 As Integer 'declares variable as an integer
        'num1 = Convert.ToInt32(TextBox1.Text)
        'num2 = Convert.ToInt32(TextBox2.Text) 'converts value of variable into integer, if it is not already
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        Dim answer As Integer 'declares variable as an integer
        answer = num1 + num2
        TextBox3.Text = answer.ToString() 'outputs value as a string to specified location
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As String 'declares variable as a string
        Dim num2 As String 'declares variable as a string
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        Dim answer As String 'declares variable as a string
        answer = num1 + num2
        'TextBox6.Text = answer.ToString()
        TextBox6.Text = $"{num1}{num2}" 'sets variable(s) as template literals
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Hello, World")
    End Sub
End Class
