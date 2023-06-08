Imports System.Data.SqlClient
Public Class Form1
    Dim BizClass(20) As PictureBox
    Dim BizReso(20) As RichTextBox
    Dim EcoClass(100) As PictureBox
    Dim EcoReso(100) As RichTextBox
    Dim FullSeat As String = ".\Full Seat.png"
    Dim EmptSeat As String = ".\Empty Seat.png"
    Dim NameBoxes(2) As TextBox
    Dim NameLabel(2) As Label
    Dim Names(2) As String
    Dim ConnectionObj As SqlConnection
    'declare an array of 20 pictureboxes
    'declare an array of 20 richtextboxes
    'declare an array of 100 pictureboxes
    'declare an array of 100 richtextboxes
    'path to Full Seat image file
    'path to Empty Seat image file
    'declare 2 textboxes
    'declare 2 labels
    'declare 2 strings
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConnectionObj = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='G:\My Drive\Schoolwork\VS Repos\ICR140\ARS-Old\Airline.mdf';Integrated Security=True")
        'had to use single quotes on the file path:'G:\My Drive\Schoolwork\VS Repos\ICR140\ARS\Airline.mdf'

        ConnectionObj.Open()

        Dim xLocation As Integer = 10
        Dim yLocation As Integer = 10
        Names(0) = "First Name"
        Names(1) = "Last Name"

        'starting x location for picture boxes
        'starting y location for picture boxes
        'sets the name of Names(0) string
        'sets the name of Names(1) string

        '                        --------------------Business Class--------------------
        For index = 0 To 19
            BizClass(index) = New PictureBox() With {
               .ImageLocation = EmptSeat,
               .Size = New Size(200, 200),'                          
               .Location = New Point(xLocation, yLocation),
               .Name = "BizPictureBox" + index.ToString(),
               .Visible = True,
               .Enabled = True,
               .Cursor = Cursors.Hand
            }
            'loop 20 times (indexes 0-19
            'creates new picturebox
            'sets the image of the PictureBox to the EmptSeat image
            'sets size of image, this is in pixels
            'sets the location of the PictureBox on the form
            'sets the name of the PictureBox to "BizPictureBox" + the index number
            'sets to visible
            'set to enabled
            'sets the cursor to a hand when hovering 

            Tab1.Controls.Add(BizClass(index))
            'adds the PictureBox to the Controls of Tab1 for BizClass

            AddHandler BizClass(index).Click, AddressOf PictureBoxClick
            'attaches an event handler to the PictureBox,
            'so that when it is clicked,the PictureBoxClick
            'subprogram is executed

            '                   --------------------Business Reservation--------------------

            BizReso(index) = New RichTextBox() With {
                .Size = New Size(200, 150),
                .Location = New Point(xLocation, yLocation + 200),
                .Name = "RichTextBox" + index.ToString(),
                .Visible = True,
                .Enabled = True,
                .Cursor = Cursors.Hand
            }
            'creates new RTB with the specified properties
            'sets the size of the RTB add + 200 to yLocation to place richtextboxes under
            'pictureboxes.y10 + 200 shifts ylocation downward by 200px, xlocation stays the same
            'sets the name of the RTB
            'sets to visible
            'sets to enabled
            'sets cursor to hand on hover

            Tab1.Controls.Add(BizReso(index))
            'adds the PictureBox to the Controls of Tab1 for BizClass

            xLocation += 220
            'moves the xlocation 220px to the right, then repeats on the next iteration

            If (index + 1) Mod 4 = 0 Then
                'if we have done 4 iterations, then it goes into the body of the If statement
                'and moves to the next line                                                         

                'index starts at 0, then we say index(0) + 1 = 1, check if index + 1 mod 4 = 0 is true.
                'If it's false, we skip the if statement, then check for the next number,
                'so index(1) + 1 mod 4 = 0, skip again until we get to index(3) + 1 mod 4 = 0
                'We then repeat checking index + 1 until we get to the next value that would
                'satisfy the condition. Evaluates to true every 4 iterations.
                'Repeat until all 20 PB's are created
                '
                xLocation = 10
                'next line xlocation is going to be the same, because we haven't changed it from the original 

                yLocation += 320
                'moves yLocation to the next line by 320px
            End If
        Next
        '                           --------------------Name Boxes & Labels--------------------

        NameBoxes(0) = New TextBox With {
                .Name = "TextBox0",
                .Location = New Point(1325, 400),
                .Size = New Size(150, 100)
                }
        'create new textbox with the specified properties
        'set the name of the textbox to TextBox0
        'sets the location of Textbox0
        'sets the size of TextBox0

        NameBoxes(1) = New TextBox With {
                    .Name = "TextBox1",
                    .Location = New Point(1325, 450),
                    .Size = New Size(150, 100)
                    }
        'create new TextBox with the specified properties
        'specify name of the TB to TextBox1
        'sets the location of the TextBox1 50px below TextBox0
        'sets the size of the TextBox

        Me.Controls.Add(NameBoxes(0))
        Me.Controls.Add(NameBoxes(1))
        'used me.controls instead of tab controls so it shows up for both tabs

        NameLabel(0) = New Label With {
                    .Name = "Label0",
                    .Location = New Point(1200, 400),
                    .Text = Names(0),
                    .Size = New Size(150, 50)
                 }
        'create new label with specified properties
        'sets name of the label to label0 
        'sets the location of label0
        'sets the text of the label to contents of names(0)
        'sets size of the label

        NameLabel(1) = New Label With {
                    .Name = "Label1",
                    .Location = New Point(1200, 450),
                    .Text = Names(1),
                    .Size = New Size(150, 50)
                 }
        'create new label with specified properties
        'sets name of the label to label1
        'sets the location of label1
        'sets the text of the label to contents of names(1)
        'sets size of the label

        Me.Controls.Add(NameLabel(0))
        Me.Controls.Add(NameLabel(1))
        'adds the labels to the form

        xLocation = 10
        yLocation = 10
        'default x and y locations

        '                          --------------------Economy Class--------------------

        For index = 0 To 99
            EcoClass(index) = New PictureBox() With {
                .ImageLocation = EmptSeat,
                .Size = New Size(200, 200),
                .Location = New Point(xLocation, yLocation),
                .Name = "EcoPictureBox" + index.ToString(),
                .Visible = True,
                .Enabled = True,
                .Cursor = Cursors.Hand
                }
            'loop 100 times
            'creates new PB with specified properties
            'sets image of the PictureBox to the EmptSeat image
            'sets size of PB 
            'sets the location of the PictureBox on the form
            'sets the name of the PB to "EcoPictureBox" plus index
            'sets to visible
            'sets to enabled
            'sets curor to hand on hover

            TabPage2.Controls.Add(EcoClass(index))
            'controls the display/generation of the second tab for EcoClass 

            AddHandler EcoClass(index).Click, AddressOf PictureBoxClick                                                  'Attaches an event handler to the picture box, so that when a PB is clicked, the                              PictureBoxClicked subprogram is called

            EcoReso(index) = New RichTextBox() With {
                .Size = New Size(200, 150),
                .Location = New Point(xLocation, yLocation + 200),
                .Name = "RichTextBox" + index.ToString(),
                .Visible = True,
                .Enabled = True,
                .Cursor = Cursors.Hand
            }
            'Create new RTB with the specified properties
            'Set size of the RTB
            'Set the default x and y locations, sets the 
            'set name of the RTB
            'sets to visible
            'sets to enabled
            'sets the cursor to a hand on hover

            TabPage2.Controls.Add(EcoReso(index))
            'contols the display/generation of the second tab for EcoReso

            xLocation += 220
            'moves the xlocation 220px to the right, then repeats on the next iteration

            If (index + 1) Mod 5 = 0 Then
                'if we have done 4 iterations, then it goes into the body of the if statement and moves to the          next line

                'index starts at 0, then we say index(0) + 1 = 1, check if index + 1 mod 5 = 0 is true.
                'If it's false, we skip the if statement, then check for the next number,
                'so index(1) + 1 mod 5 = 0, skip again until we get to index(4) + 1 mod 5 = 0 which is true.
                'We then repeat checking index + 1 until we get to the next value that would satisfy the condition.
                'Evaluates to true every 5 iterations. Repeat until all 100 PB's are made


                xLocation = 10
                'default x location, we keep this the same we don't want it to change or iterate

                yLocation += 320
                'moves to the next line by 320px
            End If
        Next
        '                             --------------------SQL Connections--------------------
        Dim Cmd As New SqlCommand($"SELECT * FROM BizClass;", ConnectionObj)
        Dim reader As SqlDataReader
        reader = Cmd.ExecuteReader
        If reader.HasRows = False Then
            reader.Close()
            Return
        End If

        While reader.Read
            Dim seat As Integer = Convert.ToInt32(reader.GetValue(0))
            Dim FirstName As String = reader.GetValue(1).ToString
            Dim LastName As String = reader.GetValue(2).ToString
            BizClass(seat).ImageLocation = FullSeat
            BizReso(seat).Text = $"{Names(0)}: {FirstName} {vbCrLf} {Names(1)}: {LastName}"
        End While
        reader.Close()
        Dim Cmd2 As New SqlCommand($"SELECT * FROM EcoClass;", ConnectionObj)
        Dim reader2 As SqlDataReader
        reader2 = Cmd2.ExecuteReader
        If reader2.HasRows = False Then
            reader2.Close()
            Return
        End If

        While reader2.Read
            Dim seat As Integer = Convert.ToInt32(reader2.GetValue(0))
            Dim FirstName As String = reader2.GetValue(1).ToString
            Dim LastName As String = reader2.GetValue(2).ToString
            EcoClass(seat).ImageLocation = FullSeat
            EcoReso(seat).Text = $"{Names(0)}: {FirstName} {vbCrLf} {Names(1)}: {LastName}"
        End While
        reader2.Close()
    End Sub

    '                          --------------------Full or Empty Seat Toggle--------------------

    Private Sub PictureBoxClick(sender As Object, e As EventArgs)
        Dim PictureBoxClicked As PictureBox = sender
        Dim PicBoxNumber As Integer = Convert.ToInt32(PictureBoxClicked.Name.Substring(13))
        Dim BizOrEco As String = (PictureBoxClicked.Name.Substring(0, 3))

        'create new function called PictureBoxClick. Get the clicked picturebox seat number from its  name             
        'get the clicked PictureBox control from the sender
        'get the number part of the PictureBox name by removing the first 13 characters and converting to an integer   
        'get the first 3 characters of the PictureBox name to determine if it is a business or economy class seat

        '------------------------------------------------------------------------------------------------------------------
        'This was giving me an array out of bounds issue. For this to work, I would need to have the Eco class code placed before the business class code, because eco class is a larger array.

        'If (NameBoxes(0).Text = "" Or NameBoxes(1).Text = "") And EcoReso(PicBoxNumber).Text = "" And BizOrEco = "Eco" Then
        '    MessageBox.Show($"Please fill in {Names(0)} and {Names(1)}")
        '    Return
        'End If

        'If (NameBoxes(0).Text = "" Or NameBoxes(1).Text = "") And BizOrEco = "Biz" And BizReso(PicBoxNumber).Text = "" Then
        '    MessageBox.Show($"Please fill in {Names(0)} and {Names(1)}")
        '    Return
        'End If
        '----------------------------------------------------------------------------------------------------------------- 

        If BizOrEco = "Biz" Then
            If (NameBoxes(0).Text = "" Or NameBoxes(1).Text = "") And BizReso(PicBoxNumber).Text = "" Then
                MessageBox.Show($"Please fill in {Names(0)} and {Names(1)}")
                Return
            End If
        End If

        'checks if value of BizorEco is "Biz"
        'Checks if the first and second name boxes are empty and if the current business reservation box is empty
        'If the boxes are empty, shows a message box asking the user to fill in the missing names
        'Returns from the current function without doing anything else

        If PictureBoxClicked.ImageLocation = EmptSeat And BizOrEco = "Biz" Then
            PictureBoxClicked.ImageLocation = FullSeat
            BizReso(PicBoxNumber).Text = $"{Names(0)}: {NameBoxes(0).Text} {vbCrLf}{Names(1)}: {NameBoxes(1).Text}"
            MessageBox.Show($"{NameBoxes(0).Text + " " + NameBoxes(1).Text}, your seat has been reserved.")

            'Check if the clicked PictureBox control is empty and is in the business class.
            'Set the ImageLocation Property Of the PictureBox control to FullSeat
            'Set the Text property of the associated business reservation box to the name of the
            'person reserving the seat                 
            'Prints a message telling the user their seat has been reserved

            Dim queryString As String = $"INSERT INTO BizClass (Seat, FirstName, LastName) VALUES ({PicBoxNumber}, '{NameBoxes(0).Text}', '{NameBoxes(1).Text}');"
            Dim Cmd As New SqlCommand(queryString, ConnectionObj)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Record Added")
            NameBoxes(0).Clear()
            NameBoxes(1).Clear()
            Return
        End If

        If BizOrEco = "Eco" Then
            If (NameBoxes(0).Text = "" Or NameBoxes(1).Text = "") And EcoReso(PicBoxNumber).Text = "" Then
                MessageBox.Show($"Please fill in {Names(0)} and {Names(1)}")
                Return
            End If
        End If

        'checks if value of BizorEco is "Eco"
        'Checks if the first and second name boxes are empty and if the current business reservation box is empty       
        'If the boxes are empty, shows a message box asking the user to fill in the missing names                  
        'Returns from the current function without doing anything else
        '
        If PictureBoxClicked.ImageLocation = EmptSeat And BizOrEco = "Eco" Then
            PictureBoxClicked.ImageLocation = FullSeat
            EcoReso(PicBoxNumber).Text = $"{Names(0)}: {NameBoxes(0).Text} {vbCrLf}{Names(1)}: {NameBoxes(1).Text}"
            MessageBox.Show($"{NameBoxes(0).Text + " " + NameBoxes(1).Text}, Your seat has been reserved.")

            'Check if the clicked PictureBox control is empty and is in the economy class.
            'Set the ImageLocation property of the PictureBox control to FullSeat
            'Set the Text property of the associated business reservation box to the name of the
            'person reserving the seat
            'prints message telling the user their seat has been reserved

            Dim queryString As String = $"INSERT INTO EcoClass (Seat, FirstName, LastName) VALUES ({PicBoxNumber}, '{NameBoxes(0).Text}', '{NameBoxes(1).Text}');"
            Dim Cmd As New SqlCommand(queryString, ConnectionObj)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Record Added")
            NameBoxes(0).Clear()
            NameBoxes(1).Clear()
            Return
            'Returns from the current function without doing anything else
        End If

        '                      --------------------Cancellation messagebox--------------------

        If PictureBoxClicked.ImageLocation = FullSeat And BizOrEco = "Biz" Then
            Dim result As DialogResult = MessageBox.Show("Do you want to cancel your reservation?", "Please confirm", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                PictureBoxClicked.ImageLocation = EmptSeat
                BizReso(PicBoxNumber).Text = ""

                'Checks if the PictureBoxClicked ImageLocation is equal to FullSeat and if the seat is in the
                'Business class section
                'If true, asks the user to confirm their cancellation by clicking a yes or no button. 
                'If the user selects Yes, the rest of the code runs. If no, nothing happens
                'The PictureBoxClicked's ImageLocation is set to EmptSeat, making the seat unoccupied again
                'The corresponding RichTextBox Text is cleared

                Dim command As New SqlCommand($"DELETE FROM BizClass WHERE Seat = '{PicBoxNumber}'; ", ConnectionObj)
                command.ExecuteNonQuery()
                MessageBox.Show("Record Delete successful")
                MessageBox.Show($"Your reservation has been cancelled")
            End If
            Return
        End If

        If PictureBoxClicked.ImageLocation = FullSeat And BizOrEco = "Eco" Then
            Dim result As DialogResult = MessageBox.Show("Do you want to cancel your reservation?", "Please confirm", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                PictureBoxClicked.ImageLocation = EmptSeat
                EcoReso(PicBoxNumber).Text = ""

                'Checks if the PictureBoxClicked's ImageLocation is equal to FullSeat and if the seat is in the
                'Economy class section
                'If the conditions are true, then it displays a message box with a confirmation question,
                'which asks the user to confirm whether they want to cancel their reservation or not. 
                'If the user selects Yes, the rest of the code runs. If no, nothing happens
                'The PictureBoxClicked's ImageLocation is set to EmptSeat, making the seat unoccupied again
                'The corresponding RichTextBox Text is cleared

                Dim command As New SqlCommand($"DELETE FROM EcoClass WHERE Seat = '{PicBoxNumber}'; ", ConnectionObj)
                command.ExecuteNonQuery()
                MessageBox.Show("Record Delete successful")
                MessageBox.Show($"Your reservation has been cancelled")
            End If
            Return
        End If
    End Sub
End Class
















































































