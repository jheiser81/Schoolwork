Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection

Public Class Form1
    Dim BizClass(20) As PictureBox                                  'declare an array of 20 pictureboxes
    Dim BizReso(20) As RichTextBox                                  'declare an array of 20 richtextboxes
    Dim EcoClass(100) As PictureBox                                 'declare an array of 100 pictureboxes
    Dim EcoReso(100) As RichTextBox                                 'declare an array of 100 richtextboxes
    Dim FullSeat As String = ".\Full Seat.png"                      'path to Full Seat image file
    Dim EmptSeat As String = ".\Empty Seat.png"                     'path to Empty Seat image file
    Dim NameBoxes(2) As TextBox                                     'declare 2 textboxes
    Dim NameLabel(2) As Label                                       'declare 2 labels
    Dim Names(2) As String                                          'declare 2 strings
    Dim ConnectionObj As SqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim baseDirectory As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)

        Dim relativeMdfPath As String = Path.Combine(baseDirectory, "Airline.mdf")
        ConnectionObj = New SqlConnection($"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={relativeMdfPath};Integrated Security=True")

        'had to use single quotes on the file path:'G:\My Drive\Schoolwork\VS Repos\ICR140\ARS\Airline.mdf'

        ConnectionObj.Open()
        Dim xLocation As Integer = 10                               'starting x location for picture boxes
        Dim yLocation As Integer = 10                               'starting y location for picture boxes

        Names(0) = "First Name"                                     'sets the name of Names(0) string
        Names(1) = "Last Name"                                      'sets the name of Names(1) string

        '                          --------------------Business Class--------------------

        For index = 0 To 19                                         'loop 20 times (indexes 0-19
            BizClass(index) = New PictureBox() With {               'creates new picturebox
               .ImageLocation = EmptSeat,                           'sets the image of the PictureBox to EmptSeat
               .Size = New Size(200, 200),'                          sets size of image
               .Location = New Point(xLocation, yLocation),         'sets the location of the PictureBox
               .Name = "BizPictureBox" + index.ToString(), '         sets the name of the PictureBox + index
               .Visible = True,                                     'sets to visible
               .Enabled = True,                                     'set to enabled
               .Cursor = Cursors.Hand                               'sets the cursor to a hand when hovering
            }
            Tab1.Controls.Add(BizClass(index))                      'adds the PictureBox Tab1 for BizClass

            AddHandler BizClass(index).Click, AddressOf PictureBoxClick
            'attaches an event handler to the PictureBox,so that when it is clicked,
            'the PictureBoxClick subprogram is executed

            '                   --------------------Business Reservation--------------------

            BizReso(index) = New RichTextBox() With {               'creates new RTB
                .Size = New Size(200, 150),                         'sets the size of the RTB
                .Location = New Point(xLocation, yLocation + 200),  'add + 200 to yLocation (below PB's)
                .Name = "RichTextBox" + index.ToString(),           'sets the name of the RTB
                .Visible = True,                                    'sets to visible
                .Enabled = True,                                    'sets to enabled
                .Cursor = Cursors.Hand                              'sets cursor to hand on hover
            }
            Tab1.Controls.Add(BizReso(index))                       'adds the PictureBox to Tab1 for BizClass

            xLocation += 220                                        'moves the xlocation 220px to the right,                                                                   then repeats on the next iteration

            If (index + 1) Mod 4 = 0 Then
                'if we have done 4 iterations, Then it goes into the body Of the If statement
                'And moves To the Next line

                'index starts at 0, then we say index(0) + 1 = 1, check if index + 1 mod 4 = 0 is true.
                'If it's false, we skip the if statement, then check for the next number,
                'so index(1) + 1 mod 4 = 0, skip again until we get to index(3) + 1 mod 4 = 0 which is true.
                'We then repeat checking index + 1 until we get to the next value that would satisfy
                'the condition. Evaluates to true every 4 iterations. Repeat until all 20 PB's are created

                xLocation = 10                                      'next line xlocation is going to be the same,                                                          because we haven't changed it from the original

                yLocation += 320                                    'moves yLocation to the next line by 320px
            End If
        Next

        '                           --------------------Name Boxes & Labels--------------------

        NameBoxes(0) = New TextBox With {                           'create new textbox
                .Name = "TextBox0",                                 'set the name of the textbox to TextBox0
                .Location = New Point(1325, 400),                   'sets the location of Textbox0
        .Size = New Size(150, 100)                                  'sets the size of TextBox0
                }
        NameBoxes(1) = New TextBox With {                           'create new TextBox
                    .Name = "TextBox1",                             'specify name of the TB to TextBox1
                    .Location = New Point(1325, 450),               'sets the location of the TextBox1 50px below TextBox0
            .Size = New Size(150, 100)                              'sets the size of the TextBox
                    }
        Me.Controls.Add(NameBoxes(0))
        Me.Controls.Add(NameBoxes(1))

        NameLabel(0) = New Label With {                             'create new label
                        .Name = "Label0",                           'sets name of the label to label0
                    .Location = New Point(1200, 400),               'sets the location of label0
                    .Text = Names(0),                               'sets the text of the label to Names(0)
                    .Size = New Size(150, 50)                       'sets size of the label
                 }
        NameLabel(1) = New Label With {                             'create new label
                        .Name = "Label1",                           'sets name of the label to label1
                    .Location = New Point(1200, 450),               'sets the location of label1
                    .Text = Names(1),                               'sets the text of the label to names(1)
                    .Size = New Size(150, 50)                       'sets size of the label
                 }
        Me.Controls.Add(NameLabel(0))
        Me.Controls.Add(NameLabel(1))

        xLocation = 10                                              'default x and y locations
        yLocation = 10

        '                          --------------------Economy Class--------------------

        For index = 0 To 99                                         'loop 100 times
            EcoClass(index) = New PictureBox() With {               'creates new PB with specified properties
                .ImageLocation = EmptSeat,                          'sets image of the PictureBox to the EmptSeat image
                .Size = New Size(200, 200),                         'sets size of PB
                .Location = New Point(xLocation, yLocation),        'sets the location of the PictureBox on the form
                .Name = "EcoPictureBox" + index.ToString(),         'sets the name of the PB to "EcoPictureBox" plus index
                .Visible = True,                                    'sets to visible
                .Enabled = True,                                    'sets to enabled
                .Cursor = Cursors.Hand                              'sets curor to hand on hover
            }
            TabPage2.Controls.Add(EcoClass(index))                  'controls for tabPage2 (EcoClass)

            AddHandler EcoClass(index).Click, AddressOf PictureBoxClick '
            'Attaches an event handler to the picture box, so that when a PB is clicked, the PictureBoxClicked subprogram we created is called

            EcoReso(index) = New RichTextBox() With {               'Create new RTB with the specified properties
                .Size = New Size(200, 150),                         'Set size of the RTB
                .Location = New Point(xLocation, yLocation + 200),  'Set the default x and y locations, sets yLocation                                                     200px below the PictureBoxes
                .Name = "RichTextBox" + index.ToString(),           'set name of the RTB
                .Visible = True,                                    'sets to visible
                .Enabled = True,                                    'sets to enabled
                .Cursor = Cursors.Hand                              'sets the cursor to a hand on hover
            }
            TabPage2.Controls.Add(EcoReso(index))                   'contols for tabPage2 (EcoReso)
            xLocation += 220                                        'moves the xlocation 220px right, then iterates

            If (index + 1) Mod 5 = 0 Then '

                'if we have done 5 iterations, then it goes into the body of the if statement
                'and moves to the next line

                'index starts at 0, then we say index(0) + 1 = 1, check if index + 1 mod 5 = 0 is true.
                'If it's false, we skip the if statement, then check for the next number,
                'so index(1) + 1 mod 5 = 0, skip again until we get to index(4) + 1 mod 5 = 0 which is true.
                'We then repeat checking index + 1 until we get to the next value that would satisfy the condition.
                'Evaluates to true every 5 iterations. Repeat until all 100 PB's are created

                xLocation = 10                                       'default x location, stays the same

                yLocation += 320                                     'moves to the next line by 320px, iterates
            End If
        Next
        '                        --------------------SQL Connections--------------------

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
        'create new function called PictureBoxClick
        'Get the clicked picturebox seat number from its name

        Dim PictureBoxClicked As PictureBox = sender
        'get the clicked PictureBox control from sender

        Dim PicBoxNumber As Integer = Convert.ToInt32(PictureBoxClicked.Name.Substring(13))
        'get the number part of the PictureBox name by removing the first 13 characters
        'and converting to an integer

        Dim BizOrEco As String = (PictureBoxClicked.Name.Substring(0, 3))
        'get the first 3 characters of the PictureBox name to determine if it is a biz or eco class seat

        '---------------------------------------------------------------------------------------------
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
            'checks if value of BizorEco is "Biz"

            If (NameBoxes(0).Text = "" Or NameBoxes(1).Text = "") And BizReso(PicBoxNumber).Text = "" Then
                'Checks if first and second name boxes are empty and if the current biz box is empty

                MessageBox.Show($"Please fill in {Names(0)} and {Names(1)}")
                'If the boxes are empty, shows a message box asking the user to fill in the missing names
                Return
            End If
        End If

        If PictureBoxClicked.ImageLocation = EmptSeat And BizOrEco = "Biz" Then
            'Check if the clicked PictureBox control is empty and is in the business class.

            PictureBoxClicked.ImageLocation = FullSeat
            'Set the ImageLocation Property Of the PictureBox control to FullSeat
            BizReso(PicBoxNumber).Text = $"{Names(0)}: {NameBoxes(0).Text} {vbCrLf}{Names(1)}: {NameBoxes(1).Text}"
            'Set the business reservation box to the name of the person reserving the seat

            MessageBox.Show($"{NameBoxes(0).Text + " " + NameBoxes(1).Text}, your seat has been reserved.")
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
            'checks if value of BizorEco is "Eco"

            If (NameBoxes(0).Text = "" Or NameBoxes(1).Text = "") And EcoReso(PicBoxNumber).Text = "" Then
                'Checks if the first and second name boxes are empty and if the current eco box is empty

                MessageBox.Show($"Please fill in {Names(0)} and {Names(1)}")
                'If the boxes are empty, shows a message box asking the user to fill in the missing names
                Return
            End If
        End If

        If PictureBoxClicked.ImageLocation = EmptSeat And BizOrEco = "Eco" Then
            'Check if the clicked PictureBox control is empty and is in the economy class.

            PictureBoxClicked.ImageLocation = FullSeat
            'Set the ImageLocation property of the PictureBox control to FullSeat

            EcoReso(PicBoxNumber).Text = $"{Names(0)}: {NameBoxes(0).Text} {vbCrLf}{Names(1)}: {NameBoxes(1).Text}"
            'Set the ecoreso box to the name of the person reserving the seat

            MessageBox.Show($"{NameBoxes(0).Text + " " + NameBoxes(1).Text}, Your seat has been reserved.")
            'prints message telling the user their seat has been reserved

            Dim queryString As String = $"INSERT INTO EcoClass (Seat, FirstName, LastName) VALUES ({PicBoxNumber}, '{NameBoxes(0).Text}', '{NameBoxes(1).Text}');"
            Dim Cmd As New SqlCommand(queryString, ConnectionObj)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Record Added")
            NameBoxes(0).Clear()
            NameBoxes(1).Clear()
            Return
        End If

        '                      --------------------Cancellation messagebox--------------------
        If PictureBoxClicked.ImageLocation = FullSeat And BizOrEco = "Biz" Then
            'Checks if the PictureBoxClicked ImageLocation is equal to FullSeat
            'and if the seat is in the Biz class section

            Dim result As DialogResult = MessageBox.Show("Do you want to cancel your reservation?", "Please confirm", MessageBoxButtons.YesNo)
            'If true, asks the user to confirm their cancellation by clicking a yes or no button.

            If result = DialogResult.Yes Then
                'If the user selects Yes, the following code runs. If no, nothing happens

                PictureBoxClicked.ImageLocation = EmptSeat
                'The PictureBoxClicked's ImageLocation is set to EmptSeat, making the seat unoccupied again

                BizReso(PicBoxNumber).Text = ""
                'The corresponding RichTextBox Text is cleared

                Dim command As New SqlCommand($"DELETE FROM BizClass WHERE Seat = '{PicBoxNumber}'; ", ConnectionObj)
                command.ExecuteNonQuery()
                MessageBox.Show("Record Delete successful")
                MessageBox.Show($"Your reservation has been cancelled")
                'A message is displayed that the reservation has been cancelled
            End If
            Return
        End If

        If PictureBoxClicked.ImageLocation = FullSeat And BizOrEco = "Eco" Then
            'Checks if the PictureBoxClicked's ImageLocation is equal to FullSeat
            'and if the seat is in the Eco class section

            Dim result As DialogResult = MessageBox.Show("Do you want to cancel your reservation?", "Please confirm", MessageBoxButtons.YesNo)
            'If true, asks the user to confirm their cancellation by clicking a yes or no button.

            If result = DialogResult.Yes Then
                'If the user selects Yes, the following code runs. If no, nothing happens

                PictureBoxClicked.ImageLocation = EmptSeat
                'The PictureBoxClicked's ImageLocation is set to EmptSeat, making the seat unoccupied again

                EcoReso(PicBoxNumber).Text = ""
                'The corresponding RichTextBox Text is cleared

                Dim command As New SqlCommand($"DELETE FROM EcoClass WHERE Seat = '{PicBoxNumber}'; ", ConnectionObj)
                command.ExecuteNonQuery()
                MessageBox.Show("Record Delete successful")
                MessageBox.Show($"Your reservation has been cancelled")
                'A message is displayed that the reservation has been cancelled
            End If
            Return
        End If
    End Sub

    '1) We click on a picturebox
    '2) We check if the seat is full
    '3) If the seat is full, display messsage to ask if you want to cancel the reservation
    '4) Display yes/no prompt asking to confirm you want to cancel. Need to look this up
    '5) If yes, set the seat to empty again, display message and clear the richtextbox.
    '6) If no, nothing happens

End Class