Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.Design

Public Class Form1

    Function Arithmetic(Op As String, num1 As Integer, num2 As Integer)
        If Op = "+" Then
            Return num1 + num2
        ElseIf Op = "-" Then
            Return num1 - num2
        ElseIf Op = "*" Then
            Return num1 * num2
        ElseIf Op = "/" Then
            Return num1 / num2
        End If
        Return 0 'needs to return something here to end the statement. Could also be a string
    End Function

    Private Sub Sum(Op As String, num1 As Integer, num2 As Integer)
        RichTextBox1.Text += $"If addition, the sum of {num1} and {num2} is {num1 + num2}"
    End Sub

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    Dim sum As Integer = Arithmetic("+", 10, 55)
    '    '1) Declare variable as integer 2) Call arithmetic function 3) If Op variable contains "+", add num1 and num2 together 4) Output sum
    '    Dim diff As Integer = Arithmetic("-", 42, 2)
    '    Dim prod As Integer = Arithmetic("*", 5, 10)
    '    Dim quot As Integer = Arithmetic("/", 100, 20)
    '    RichTextBox1.Text += $"Sum is {sum}, difference is {diff}, {prod} is {quot} {vbCrLf}"

    'End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer = Arithmetic("+", 10, 55)
        Dim diff As Integer = Arithmetic("-", 42, 2)
        Dim prod As Integer = Arithmetic("*", 5, 10)
        Dim quot As Integer = Arithmetic("/", 100, 20)
        RichTextBox1.Text += $"The Sum is {sum}, difference is {diff}, {prod} is {quot} {vbCrLf}"
    End Sub

    Dim myArray(100) As Integer 'Sets the array length to 100
    Dim odd As Integer
    Dim even As Integer
    Dim zero As Integer
    Dim printArray As String = ""
    Dim smallest As Integer
    Dim largest As Integer
    Dim avg As Double
    Dim arrsum As Integer

    Sub largestNum()
        largest = Integer.MinValue 'internet said i needed this, but seems to run fine without?
        For index = 0 To myArray.GetUpperBound(0)
            If myArray(index) > largest Then
                largest = myArray(index)
            End If
        Next
        RichTextBox2.Text += $"The largest number is {largest}{vbCrLf}"
    End Sub

    Sub smallestNum()
        smallest = Integer.MaxValue ''internet said i needed this, but seems to run fine without?
        For index = 0 To myArray.GetUpperBound(0)
            If myArray(index) < smallest Then
                smallest = myArray(index)
            End If
        Next
        RichTextBox2.Text += $"The smallest number is {smallest}{vbCrLf}"
    End Sub

    Sub arraySum()
        For index = 0 To myArray.GetUpperBound(0)
            arrsum += myArray(index)
        Next
        RichTextBox2.Text += $"The total of the array is {arrsum}{vbCrLf}"
    End Sub

    Sub avgNum()
        avg = arrsum / myArray.Length
        RichTextBox2.Text += $"The average of all the numbers is {avg}{vbCrLf}"
    End Sub

    Sub EvenOddZero()
        For index = 0 To myArray.GetUpperBound(0)
            If myArray(index) = 0 Then
                zero += 1
            ElseIf myArray(index) Mod 2 = 0 Then
                even += 1
            Else
                odd += 1
            End If
        Next
        RichTextBox2.Text += printArray + $"Even numbers: {even}, Odd numbers: {odd}, Zero numbers {zero}{vbCrLf}"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For index = 0 To myArray.GetUpperBound(0)
            myArray(index) = Int((100 * Rnd()) + 1)
            'printArray += Convert.ToString(myArray(index)) + ", " 'this prints out the random numbers in the array, leaving it out just prints the results
        Next
        largestNum()
        smallestNum()
        EvenOddZero()
        arraySum()
        avgNum()
        'calling the subs
    End Sub

    Dim currentBalance As Double = 1000

    Private Sub Bal_check_Click(sender As Object, e As EventArgs) Handles Bal_check.Click
        DisplayBal()
    End Sub

    Private Sub Withdraw_btn_Click(sender As Object, e As EventArgs) Handles Withdraw_btn.Click
        Dim amount As Double = Convert.ToDouble(TextBox1.Text)
        Dim withdrawnAmount As Double = ATM(amount, currentBalance)

        If withdrawnAmount > 0 Then
            currentBalance -= withdrawnAmount
            DisplayBal()
        End If
    End Sub

    Private Sub DisplayBal()
        MessageBox.Show($"Current balance is: ${currentBalance}.")
    End Sub

    Private Function ATM(toWithdraw As Double, balance As Double)
        If toWithdraw > balance Then
            MessageBox.Show($"Insufficient funds.")
            Return 0
        Else
            balance -= toWithdraw
            MessageBox.Show($"Amount withdrawn: ${toWithdraw}.")
            Return toWithdraw
        End If
    End Function

End Class

'Exercise 1:
'•Look back at the 100 random number array we
'made.
'•Move the find largest, find smallest, sum,
'average, And the(even, odd, zero counter) into
'separate subprograms.
'
'Dim myArray(100) As Integer 'Sets the array length to 100
'Dim odd As Integer = 0
'Dim even As Integer = 0
'Dim zero As Integer = 0
'Dim myRandom As Integer = 0
'Dim printArray As String = ""
'Dim smallest As Integer = 0
'Dim largest As Integer = 0
'Dim avg As Double = 0
'Dim sum As Integer = 0
'For index = 0 To myArray.GetUpperBound(0)
'    myRandom = Int((100 * Rnd()) + 1)
'    myArray(index) = myRandom
'    printArray += Convert.ToString(myRandom) + ", "
'    If myArray(index) = 0 Then
'        zero += 1
'    ElseIf myArray(index) Mod 2 = 0 Then
'        even += 1
'    Else
'        odd += 1
'    End If
'Next
'RichTextBox2.Text = printArray + ($"Even numbers: {even}, Odd numbers: {odd}, Zero numbers {zero} {vbCrLf}")

'---------------------------------------------------------------------------------------------------------------
'Exercise 2:
'Using a function and subroutine, use the function to
'Return the amount withdrawn As a messagebox. Use
'the subroutine To print the balance In a message
'box.Print the balance when after you withdraw