Public Class Form1
    Dim num1, num2, result As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            num1 = CDbl(TextBox1.Text)
            num2 = CDbl(TextBox2.Text)
            result = num1 + num2
            TextBox3.Text = $"The result of {num1} + {num2} is {num1 + num2}"

            Button1.BackColor = Color.LightBlue
            Button2.BackColor = Color.FromArgb(224, 224, 224)
            Button3.BackColor = Color.FromArgb(224, 224, 224)
            Button4.BackColor = Color.FromArgb(224, 224, 224)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            num1 = CDbl(TextBox1.Text)
            num2 = CDbl(TextBox2.Text)
            result = num1 - num2
            TextBox3.Text = $"The result of {num1} - {num2} is {num1 - num2}"

            Button1.BackColor = Color.FromArgb(224, 224, 224)
            Button2.BackColor = Color.LightBlue
            Button3.BackColor = Color.FromArgb(224, 224, 224)
            Button4.BackColor = Color.FromArgb(224, 224, 224)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            num1 = CDbl(TextBox1.Text)
            num2 = CDbl(TextBox2.Text)
            result = num1 + num2
            TextBox3.Text = $"The result of {num1} + {num2} is {num1 + num2}"

            Button1.BackColor = Color.FromArgb(224, 224, 224)
            Button2.BackColor = Color.FromArgb(224, 224, 224)
            Button3.BackColor = Color.LightBlue
            Button4.BackColor = Color.FromArgb(224, 224, 224)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            num1 = CDbl(TextBox1.Text)
            num2 = CDbl(TextBox2.Text)
            result = num1 + num2
            TextBox3.Text = $"The result of {num1} + {num2} is {num1 + num2}"

            Button1.BackColor = Color.FromArgb(224, 224, 224)
            Button2.BackColor = Color.FromArgb(224, 224, 224)
            Button3.BackColor = Color.FromArgb(224, 224, 224)
            Button4.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox3.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox3.Clear()
    End Sub
End Class
