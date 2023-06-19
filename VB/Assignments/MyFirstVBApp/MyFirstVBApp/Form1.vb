Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'this allows us to program our button called sum
        Dim num1 As Integer 'this takes in textbox data as a string from textbox1
        Dim num2 As Integer 'this takes in textbox data as a string from textbox2
        num1 = Convert.ToInt32(TextBox1.Text)
        num2 = Convert.ToInt32(TextBox2.Text)
        Dim sum As Integer
        sum = num1 + num2
        TextBox3.Text = sum.ToString() 'this will take data from textbox1 and textbox 2, add them together, and output to textbox
    End Sub

    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num3 As Integer
        Dim num4 As Integer
        num3 = Convert.ToInt32(TextBox4.Text)
        num4 = Convert.ToInt32(TextBox5.Text)
        Dim difference As Integer
        difference = num3 - num4
        TextBox6.Text = difference.ToString()
    End Sub

    'Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    'End Sub

    'Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    'End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num5 As Integer
        Dim num6 As Integer
        num5 = Convert.ToInt32(TextBox7.Text)
        num6 = Convert.ToInt32(TextBox8.Text)
        Dim product As Integer
        product = num5 * num6
        TextBox9.Text = product.ToString()
    End Sub

    'Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    'End Sub

    'Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    'End Sub

    'Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    'End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num7 As Integer
        Dim num8 As Integer
        num7 = Convert.ToInt32(TextBox10.Text)
        num8 = Convert.ToInt32(TextBox11.Text)
        Dim quotient = num7 / num8
        TextBox12.Text = quotient.ToString()

    End Sub

    'Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    'End Sub

    'Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    'End Sub

    'Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    'End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num9 As Integer
        Dim num10 As Integer
        num9 = Convert.ToInt32(TextBox13.Text)
        num10 = Convert.ToInt32(TextBox14.Text)
        Dim modulus = num9 Mod num10
        TextBox15.Text = modulus.ToString()
    End Sub
End Class
