Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myArray(100) As Integer 'Sets the array length to 100
        Dim odd As Integer = 0
        Dim even As Integer = 0
        Dim zero As Integer = 0
        Dim myRandom As Integer = 0
        Dim printArray As String = ""
        Dim smallest As Integer = 0
        Dim largest As Integer = 0
        Dim avg As Double = 0
        Dim sum As Integer = 0
        For index = 0 To myArray.GetUpperBound(0)
            myRandom = Int((100 * Rnd()) + 1)
            'every time the loop runs, it generates a new random number that will be saved in the myRandom variable
            myArray(index) = myRandom 'myArray(index) is the place where the random number is saved
            printArray += Convert.ToString(myRandom) + ", " 'saves all the random numbers
            If myArray(index) = 0 Then
                zero += 1
            ElseIf myArray(index) Mod 2 = 0 Then
                even += 1
            Else
                odd += 1
            End If
        Next
        If myRandom < smallest Then
            smallest = myRandom
        End If
        If myRandom > largest Then
            largest = myRandom
        End If
        sum += myRandom
        avg = sum / myArray.GetUpperBound(0)
        RichTextBox1.Text = printArray
        RichTextBox2.Text = ($"Even numbers: {even}, Odd numbers: {odd}, Zero numbers {zero} {vbCrLf}") + ($"Largest: {largest}, smallest: {smallest}")


    End Sub
End Class
