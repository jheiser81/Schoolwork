Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Mynumber As Integer
        Mynumber = TextBox1.Text
        If Mynumber Mod 2 = 0 Then
            MessageBox.Show("The number is an even number")
        Else
            MessageBox.Show("The number is an Odd number")
        End If
    End Sub
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim Beverage As String = TextBox2.Text
    '    If Beverage = "Coffee" Then
    '        MessageBox.Show("We have coffee!")
    '    ElseIf Beverage = "Tea" Then
    '        MessageBox.Show("We have tea!")
    '    ElseIf Beverage = "Soda" Then
    '        MessageBox.Show("We have soda!")
    '    Else
    '        MessageBox.Show("Sorry, we don't have that, you can have water")
    '    End If
    'End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim number = TextBox3.Text
        If number Mod 3 = 0 And number Mod 5 = 0 Then
            MessageBox.Show("Fizz Buzz")
        ElseIf number Mod 3 = 0 Then
            MessageBox.Show("Fizz")
        ElseIf number Mod 5 = 0 Then
            MessageBox.Show("Buzz")
        Else
            MessageBox.Show("No Fizz, no Buzz")
        End If
    End Sub
End Class

