Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Form1
    Dim boardArray(9, 9) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make an array Of five numbers, add all the numbers together. (no loops just use the indexes of array)

        'Input = 5, 1, 22, 4, 3
        'Output = 35


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Create an array Of 10 unique numbers from 0 - 20, count how many odd numbers, even numbers (that aren't zero) and zeros there are in the array.
        '  Input = 1, 5, 8, 0, 19, 4, 6, 15, 10, 13
        'Output = “There are 5 odd, 4 even and 1 zero”
        RichTextBox1.Clear()
        Dim Months() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        For index = 0 To Months.GetUpperBound(0)
            '' outter for loop as getting the month
            For innerIndex = 0 To Months(index).Length - 1
                ''inner for loop is getting the letter from the selected month
                RichTextBox1.Text += Months(index)(innerIndex) + ", "
            Next
            RichTextBox1.Text += vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Clear()
        Dim Months() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        For index = 0 To Months.GetUpperBound(0)
            If index = 0 Then
                For innerIndex = 0 To 10
                    If innerIndex = 0 Then
                        RichTextBox1.Text += "   " + innerIndex.ToString + ", "
                        Continue For
                    End If
                    RichTextBox1.Text += innerIndex.ToString + ", "
                Next
                RichTextBox1.Text += vbCrLf
            End If
            RichTextBox1.Text += index.ToString + ", "
            '' put a zero in front of january
            For innerIndex = 0 To Months(index).Length - 1
                RichTextBox1.Text += Months(index)(innerIndex) + ", "
            Next
            RichTextBox1.Text += vbCrLf
        Next
    End Sub
    Sub PrintBoard()
        RichTextBox1.Clear()
        For index = 0 To boardArray.GetUpperBound(0)
            For innerindex = 0 To boardArray.GetUpperBound(1)
                RichTextBox1.Text += boardArray(index, innerindex)
            Next
            RichTextBox1.Text += vbCrLf
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For index = 0 To boardArray.GetUpperBound(0)
            For innerIndex = 0 To boardArray.GetUpperBound(1)
                boardArray(index, innerIndex) = " * "
            Next
        Next
        PrintBoard()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As Integer = TextBox1.Text
        Dim y As Integer = TextBox2.Text
        boardArray(y, x) = "x"
        PrintBoard()
    End Sub
End Class
