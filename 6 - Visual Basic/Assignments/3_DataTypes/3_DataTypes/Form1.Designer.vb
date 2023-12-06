<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(-1, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(175, 35)
        TextBox1.TabIndex = 0
        TextBox1.Text = "5"' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(-1, 48)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(175, 35)
        TextBox2.TabIndex = 1
        TextBox2.Text = "5"' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(-1, 164)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(175, 35)
        TextBox3.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(-1, 100)
        Button1.Name = "Button1"
        Button1.Size = New Size(175, 40)
        Button1.TabIndex = 3
        Button1.Text = "Add Numbers"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(344, 102)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 40)
        Button2.TabIndex = 4
        Button2.Text = "Concatenate"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(193, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 30)
        Label1.TabIndex = 5
        Label1.Text = "Num1"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(193, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 30)
        Label2.TabIndex = 6
        Label2.Text = "Num2"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(193, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 30)
        Label3.TabIndex = 7
        Label3.Text = "Answer"' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(344, 0)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(175, 35)
        TextBox4.TabIndex = 8
        TextBox4.Text = "5"' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(344, 48)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(175, 35)
        TextBox5.TabIndex = 9
        TextBox5.Text = "5"' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(344, 161)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(175, 35)
        TextBox6.TabIndex = 10
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(107, 268)
        Button3.Name = "Button3"
        Button3.Size = New Size(131, 40)
        Button3.TabIndex = 11
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1543, 696)
        Controls.Add(Button3)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button3 As Button
End Class
