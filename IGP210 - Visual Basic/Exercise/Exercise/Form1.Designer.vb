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
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        TextBox6 = New TextBox()
        Button2 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(0, 0)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(179, 35)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Hello"' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(0, 78)
        TextBox2.Margin = New Padding(4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(179, 35)
        TextBox2.TabIndex = 1
        TextBox2.Text = "World!"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(258, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 30)
        Label1.TabIndex = 3
        Label1.Text = "Greeting"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(258, 78)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 30)
        Label2.TabIndex = 4
        Label2.Text = "Place"' 
        ' Button1
        ' 
        Button1.Location = New Point(4, 159)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(176, 41)
        Button1.TabIndex = 5
        Button1.Text = "Concatenate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(1, 244)
        TextBox3.Margin = New Padding(4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(179, 35)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(5, 316)
        TextBox4.Margin = New Padding(4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(179, 35)
        TextBox4.TabIndex = 7
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(453, 54)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(395, 168)
        RichTextBox1.TabIndex = 8
        RichTextBox1.Text = ChrW(8220) & "He who binds to himself a joy " & vbLf & "Does the winged life destroy; " & vbLf & "But he who kisses the joy as it flies " & vbLf & "Lives in eternity's sun rise." & ChrW(8221)
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(453, 302)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(395, 168)
        RichTextBox2.TabIndex = 9
        RichTextBox2.Text = ""' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(453, 0)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(192, 35)
        TextBox6.TabIndex = 11
        TextBox6.Text = "William Blake said"' 
        ' Button2
        ' 
        Button2.Location = New Point(453, 239)
        Button2.Name = "Button2"
        Button2.Size = New Size(244, 40)
        Button2.TabIndex = 12
        Button2.Text = "Concatenate"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(651, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 30)
        Label3.TabIndex = 13
        Label3.Text = "Author"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(867, 54)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 30)
        Label4.TabIndex = 14
        Label4.Text = "Quote"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1190, 540)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(TextBox6)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
