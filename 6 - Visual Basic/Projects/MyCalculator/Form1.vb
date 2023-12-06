Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    'these variables are placed at the top, before any sub routines, so they can be accessible everywhere
    Dim previousStorage As Double = 0 'Set double so we can use decimals
    Dim arithmeticOp As String = "" 'sets to a blank space by default
    Dim OperatorSelected As Boolean = False
    Sub Calculate() 'this is to do the equal calculation
        OperatorSelected = True 'run calculate function if an operator has been selected
        Dim Result As Double 'result variable
        If arithmeticOp = "+" Then 'check which operator is being used to calculate
            Result = previousStorage + Convert.ToDouble(ResultBox.Text) 'sum the previous values with the current textbox value and convert textbox value to a number
            ResultBox.Text = Result.ToString() 'print result to textbox
        ElseIf arithmeticOp = "-" Then 'subtraction
            Result = previousStorage - Convert.ToDouble(ResultBox.Text)
            ResultBox.Text = Result.ToString()
        ElseIf arithmeticOp = "*" Then 'multiplication
            Result = previousStorage * Convert.ToDouble(ResultBox.Text)
            ResultBox.Text = Result.ToString()
        ElseIf arithmeticOp = "/" Then 'division
            Result = previousStorage / Convert.ToDouble(ResultBox.Text)
            ResultBox.Text = Result.ToString()
        ElseIf arithmeticOp = "." Then 'decimal point
            Result = previousStorage
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This is button 1
        If ResultBox.Text = "0" Or OperatorSelected = True Then 'This checks if the resultbox has a default of 0
            ResultBox.Text = "1" 'If it is 0, 0 is replaced with a 1
            OperatorSelected = False 'allows calculate function to be run
            TextBox1.Text += " 1" 'space for readability
        Else
            ResultBox.Text += "1" 'If it is not 0, then we want to add another 1 
            TextBox1.Text += "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ResultBox.Text = "0" Or OperatorSelected = True Then
            ResultBox.Text = "2"
            OperatorSelected = False
            TextBox1.Text += " 2"
        Else
            ResultBox.Text += "2"
            TextBox1.Text += "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ResultBox.Text = "0" Or OperatorSelected = True Then
            ResultBox.Text = "3"
            OperatorSelected = False
            TextBox1.Text += " 3"
        Else
            ResultBox.Text += "3"
            TextBox1.Text += "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ResultBox.Text = "0" Or OperatorSelected = True Then
            ResultBox.Text = "4"
            OperatorSelected = False
            TextBox1.Text += " 4"
        Else
            ResultBox.Text += "4"
            TextBox1.Text += "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ResultBox.Text = "0" Or OperatorSelected = True Then
            ResultBox.Text = "5"
            OperatorSelected = False
            TextBox1.Text += " 5"
        Else
            ResultBox.Text += "5"
            TextBox1.Text += "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ResultBox.Text = "0" Or OperatorSelected = True Then
            ResultBox.Text = "6"
            OperatorSelected = False
            TextBox1.Text += " 6"
        Else
            ResultBox.Text += "6"
            TextBox1.Text += "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ResultBox.Text = "0" Or OperatorSelected = True Then
            ResultBox.Text = "7"
            OperatorSelected = False
            TextBox1.Text += " 7"
        Else
            ResultBox.Text += "7"
            TextBox1.Text += "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ResultBox.Text = "0" Or OperatorSelected = True Then
            ResultBox.Text = "8"
            OperatorSelected = False
            TextBox1.Text += " 8"
        Else
            ResultBox.Text += "8"
            TextBox1.Text += "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If ResultBox.Text = "0" Or OperatorSelected = True Then
            ResultBox.Text = "9"
            OperatorSelected = False
            TextBox1.Text += " 9"
        Else
            ResultBox.Text += "9"
            TextBox1.Text += " 9"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If ResultBox.Text = Not "0" Or OperatorSelected = True Then
            ResultBox.Text = "0"
            OperatorSelected = False
            TextBox1.Text += " 0"
        Else
            ResultBox.Text += "0"
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click 'addition
        TextBox1.Text += " +"
        If arithmeticOp <> "" Then 'runs calculate function if there is a value stored in arithmeticOp
            Calculate()
            'previousStorage = ResultBox.Text
            'Return
        End If
        OperatorSelected = True
        arithmeticOp = "+" 'indicates the operator to be used when the = button is clicked
        'ResultBox.Text = "0" 'clear text
        previousStorage = ResultBox.Text 'store the number from resultbox for later
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text += " -"
        If arithmeticOp <> "" Then
            Calculate()
        End If
        OperatorSelected = True
        arithmeticOp = "-"
        previousStorage = ResultBox.Text
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text += " *"
        If arithmeticOp <> "" Then
            Calculate()
        End If
        OperatorSelected = True
        arithmeticOp = "*"
        previousStorage = ResultBox.Text
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text += " /"
        If arithmeticOp <> "" Then
            Calculate()
        End If
        OperatorSelected = True
        arithmeticOp = "/"
        previousStorage = ResultBox.Text
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Not ResultBox.Text.Contains(".") Then
            ResultBox.Text += "."
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If ResultBox.TextLength <> 0 Then
            Dim textLength As Integer = TextBox1.TextLength - 1
            Dim textboxText As String = TextBox1.Text
            TextBox1.Text = textboxText.Substring(0, textLength)
            Dim resultLength As Integer = ResultBox.TextLength - 1
            Dim resultboxText As String = ResultBox.Text
            ResultBox.Text = resultboxText.Substring(0, resultLength)

        End If
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click  'equal button, performs calculation
        Calculate()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Clear()
        ResultBox.Clear()
        previousStorage = 0
        arithmeticOp = ""
    End Sub


End Class
