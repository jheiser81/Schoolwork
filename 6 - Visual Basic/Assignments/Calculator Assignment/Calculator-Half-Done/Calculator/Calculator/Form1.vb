Public Class Form1
    Dim previousStorage As Integer = 0
    Dim aritmeticOperator As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''this is button 1 with a number value of 1
        If TextBox1.Text = "0" Then 'this checks if the textbox1 has a default 0 
            TextBox1.Text = "1" ' if it is a 0 it needs to be replaced with a 1
        Else
            TextBox1.Text += "1" 'if it is not a 0 then we want to add another 1 to the textbox
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ''this is button 2 with a number value of 2
        If TextBox1.Text = "0" Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text += "2"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        '' This is addition
        previousStorage = TextBox1.Text 'Store the number form textbox 1 to use later
        aritmeticOperator = "+" ''we indicate the operator that was used so when we press the = button we can know to add
        TextBox1.Text = "0" '' clear text
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '' subtraction 
        previousStorage = TextBox1.Text
        aritmeticOperator = "-"
        TextBox1.Text = "0"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        '' This is to do the equal calulation
        Dim result As Integer '' result variable
        If aritmeticOperator = "+" Then 'check which operator is being used to calculate, in this case we are using additon
            result = previousStorage + Convert.ToInt32(TextBox1.Text) 'sum the previous values with the current textbox value
            TextBox1.Text = result.ToString() 'print result to textbox1
        ElseIf aritmeticOperator = "-" Then 'this is where we subtract
            result = previousStorage - Convert.ToInt32(TextBox1.Text)
            TextBox1.Text = result.ToString()
        End If

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim textLength As Integer = TextBox1.TextLength - 1
        Dim textboxText As String = TextBox1.Text
        TextBox1.Text = textboxText.Substring(0, textLength)
    End Sub
End Class
