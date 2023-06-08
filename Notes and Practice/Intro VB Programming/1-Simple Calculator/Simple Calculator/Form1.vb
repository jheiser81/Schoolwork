Public Class Form1
    Dim firstNum, secondNum, result As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            firstNum = CDbl(TextBox1.Text)  'explicitly declares value as a double
            secondNum = CDbl(TextBox2.Text)
            result = firstNum + secondNum
            TextBox3.Text = $"The result of {firstNum} + {secondNum} is {firstNum + secondNum}"
        Else
            MessageBox.Show("Please enter both numbers") 'prevents program from running unless both textboxes have input numbers
        End If

        Button1.BackColor = Color.LightBlue 'changes + btn to lightblue when clicked
        Button2.BackColor = Color.FromArgb(224, 224, 224)
        Button3.BackColor = Color.FromArgb(224, 224, 224)
        Button4.BackColor = Color.FromArgb(224, 224, 224)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            firstNum = CDbl(TextBox1.Text)
            secondNum = CDbl(TextBox2.Text)
            result = firstNum - secondNum
            TextBox3.Text = $"The result of {firstNum} - {secondNum} is {firstNum - secondNum}"
        Else
            MessageBox.Show("Please enter both numbers")
        End If

        Button1.BackColor = Color.FromArgb(224, 224, 224)
        Button2.BackColor = Color.LightBlue
        Button3.BackColor = Color.FromArgb(224, 224, 224)
        Button4.BackColor = Color.FromArgb(224, 224, 224)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox3.Clear()
        'clears the result textbox when textbox1 changes
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox3.Clear()
        'clears the result textbox when textbox2 changes
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            firstNum = CDbl(TextBox1.Text)
            secondNum = CDbl(TextBox2.Text)
            result = firstNum * secondNum
            TextBox3.Text = $"The result of {firstNum} * {secondNum} is {firstNum * secondNum}"
        Else
            MessageBox.Show("Please enter both numbers")
        End If

        Button1.BackColor = Color.FromArgb(224, 224, 224)
        Button2.BackColor = Color.FromArgb(224, 224, 224)
        Button3.BackColor = Color.LightBlue
        Button4.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            firstNum = CDbl(TextBox1.Text)
            secondNum = CDbl(TextBox2.Text)
            result = firstNum / secondNum
            TextBox3.Text = $"The result of {firstNum} / {secondNum} is {firstNum / secondNum}"
        Else
            MessageBox.Show("Please enter both numbers")
        End If

        Button1.BackColor = Color.FromArgb(224, 224, 224)
        Button2.BackColor = Color.FromArgb(224, 224, 224)
        Button3.BackColor = Color.FromArgb(224, 224, 224)
        Button4.BackColor = Color.LightBlue
    End Sub
End Class
