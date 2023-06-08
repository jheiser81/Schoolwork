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
        Me.name_txt = New System.Windows.Forms.TextBox()
        Me.hours_txt = New System.Windows.Forms.TextBox()
        Me.parts_txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Bill_box = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'name_txt
        '
        Me.name_txt.Location = New System.Drawing.Point(195, 12)
        Me.name_txt.Name = "name_txt"
        Me.name_txt.Size = New System.Drawing.Size(175, 35)
        Me.name_txt.TabIndex = 0
        '
        'hours_txt
        '
        Me.hours_txt.Location = New System.Drawing.Point(195, 63)
        Me.hours_txt.Name = "hours_txt"
        Me.hours_txt.Size = New System.Drawing.Size(175, 35)
        Me.hours_txt.TabIndex = 1
        '
        'parts_txt
        '
        Me.parts_txt.Location = New System.Drawing.Point(195, 118)
        Me.parts_txt.Name = "parts_txt"
        Me.parts_txt.Size = New System.Drawing.Size(175, 35)
        Me.parts_txt.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(391, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 69)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Display Bill"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hours of Labour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cost of Parts"
        '
        'Bill_box
        '
        Me.Bill_box.Location = New System.Drawing.Point(195, 188)
        Me.Bill_box.Name = "Bill_box"
        Me.Bill_box.Size = New System.Drawing.Size(327, 168)
        Me.Bill_box.TabIndex = 7
        Me.Bill_box.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Bill_box)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.parts_txt)
        Me.Controls.Add(Me.hours_txt)
        Me.Controls.Add(Me.name_txt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents name_txt As TextBox
    Friend WithEvents hours_txt As TextBox
    Friend WithEvents parts_txt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Bill_box As RichTextBox
End Class
