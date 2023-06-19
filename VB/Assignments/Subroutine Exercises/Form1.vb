Imports System.Reflection

Public Class Form1
    Sub Sum(form_event As String, num1 As Integer, num2 As Integer) 'string, integer, integer
        RichTextBox1.Text += $"The sum of {num1} and {num2} is {num1 + num2} {vbCrLf}"
        'num1 and num2 are not declared here, but specified in the form1_load and button1_click private subs
    End Sub
    Sub Difference(form_event As String, num1 As Integer, num2 As Integer) 'string, integer, integer
        RichTextBox1.Text += $"The difference of {num1} and {num2} is {num1 - num2} {vbCrLf}"
    End Sub
    Sub Product(form_event As String, num1 As Integer, num2 As Integer) 'string, integer, integer
        RichTextBox1.Text += $"The product of {num1} and {num2} is {num1 * num2} {vbCrLf}"
    End Sub
    Sub Quotient(form_event As String, num1 As Integer, num2 As Integer) 'string, integer, integer
        RichTextBox1.Text += $"The quotient of {num1} and {num2} is {num1 / num2} {vbCrLf}"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sum("Form Load", 10, 5) 'string, integer, integer 
        Difference("Form Load", 10, 5)
        Product("Form Load", 10, 5)
        Quotient("Form Load", 10, 5)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'This calls all the 
        Sum("Button click", 50, 25)
        Difference("Button click", 50, 25)
        Product("Button click", 50, 25)
        Quotient("Button click", 50, 25)
    End Sub
End Class
'1) The first four subs (Sum, Difference, Product, Quotient) are subroutines that take in 3 arguemtns: form_event, num1, and num2. The form_event is a string, and num1 and num2 are integers. Each of these subs perform an arithmetic operation on the two integers and outputs the result to a RichTextBox. 

'2) The Private Sub Form1_Load() is a built-in event handler in VB.net that runs when the form is loaded. It calls the Sum, Difference, Product, and Quotient subroutines. It passes in the String "Form Load" as the form_event argument, and the integers 10 and 5 as the num1 and num2 arguments.
' Double-clicked on the form itself to create the event handler

'3) The Private Sub Button1_Click is another built-in event handler that runs when Button1 is clicked. It also calls the 4 arithmetic subroutines, and passes in the string "Button Click" as the form_event argument and the integers 50 for num1 and 25 for num 2.

'4) The result of each subroutine call is output to the RichTextBox1 using the += operator and string interpolation (template literals).

'NOTES:
'-The program performs basic arithmetic operations and displays the results in a RichTextBox. When the form loads or the button is clicked, the corresponding event handler is executed and calls each of the arithmetic subroutines, then prints the result in the RichTextBox1 output.
'-The purpose of the form_event variable is to identify and keep track of the event that triggers the subroutine call ; it is not used in the actual arithmetic operations themselves, but is used in the output message with string interpolation.