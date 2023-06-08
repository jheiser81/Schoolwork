Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hours, parts, total As Double
        Dim name As String

        If IsNumeric(hours_txt.Text) And IsNumeric(parts_txt.Text) And name_txt.Text <> "" Then
            hours = CDbl(hours_txt.Text)
            parts = CDbl(parts_txt.Text)
            name = name_txt.Text
            'isNumeric checks if the input is a number, and if it is, it converts it to a double

            Dim labourCost As Double = hours * 35 '$35/hour cost
            Dim partsCost As Double = parts + (parts * 0.05) '5% sales tax
            total = labourCost + partsCost

            Bill_box.Text = $"Customer name: {name}{vbCrLf}Labour Cost: {labourCost:C}{vbCrLf}Parts Cost: {partsCost:C}{vbCrLf}Total Cost: {total:C}" ':C formats the output to currency
        Else
            MessageBox.Show("Please enter valid input") 'If the user enters invalid input, a message box will appear
        End If
    End Sub
End Class
