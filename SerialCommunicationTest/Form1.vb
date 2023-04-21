Option Explicit On
Option Strict On
Public Class Form1



    Dim recieveBytes(18) As Byte
    Dim sendBytes(9) As Byte
    Dim sendInt As Integer

    'good  Keep ???? or in other form...????
    'Private Sub EUSARTtest_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    SerialPort1.PortName = "COM7"
    '    SerialPort1.BaudRate = 9600
    '    SerialPort1.DataBits = 8
    '    SerialPort1.StopBits = IO.Ports.StopBits.One
    '    SerialPort1.Parity = IO.Ports.Parity.None
    '    SerialPort1.Open()

    '    Timer1.Enabled = True
    'End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Want here ????
        SerialPort1.PortName = "COM8"
        SerialPort1.BaudRate = 9600
        SerialPort1.DataBits = 8
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.Open()

        Timer1.Enabled = True

        TrackBar1.BackColor = Color.Green

        RedTrackBar.Value = 20
        GreenTrackBar.Value = 20
        BlueTrackBar.Value = 20
        HScrollBar1.Value = 123
        TrackBar1.Value = 128
        HScrollBar2.Value = 127
        HScrollBar3.Value = 127
        HScrollBar4.Value = 127

        'notneed
        'arrHmm(0) = RedTrackBar.Value
        'arrHmm(1) = 0
        'arrHmm(2) = 0

    End Sub


    'example from jamison
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    'sendInt = CInt(TextBox1.Text)

    '    sendBytes(0) = CByte(Hex(36))
    '    sendBytes(1) = CByte(0)
    '    sendBytes(2) = CByte(1)
    '    sendBytes(3) = CByte(24)
    '    sendBytes(4) = CByte(3)
    '    sendBytes(5) = CByte(4)
    '    sendBytes(6) = CByte(5)
    '    sendBytes(7) = CByte(6)
    '    sendBytes(8) = CByte(170)
    '    SerialPort1.Write(sendBytes, 0, 9)

    '    'Timer2.Enabled = True
    'End Sub

    'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
    '    sendInt = CInt(TextBox1.Text)

    '    Timer2.Enabled = False
    '    sendBytes(1) = CByte(sendInt)

    '    SerialPort1.Write(sendBytes, 1, 1)
    'End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Timer1.Enabled = False

    '    ListBox1.Items.Clear()
    '    For x As Integer = 0 To 5
    '        ListBox1.Items.Add(Hex(recieveBytes(x)))
    '    Next

    '    ListBox1.Items.Add(" ")

    '    'sendByte(0) = 55
    '    'sendByte(1) = CByte(sendInt)

    '    For x As Integer = 0 To 9
    '        ListBox1.Items.Add(Hex(sendBytes(x)))
    '    Next

    '    'SerialPort1.Write(sendBytes, 0, 10)

    '    'ListBox2.Items.Clear()
    '    'For x As Integer = 0 To 9
    '    '    ListBox2.Items.Add(sendI)
    '    'Next


    '    Timer1.Enabled = True


    'End Sub



    'not need -not recieving data
    'Private Sub SerialPort1_DataRecieved(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
    '    SerialPort1.Read(recieveBytes, 0, 18)
    'End Sub


    Dim arrIntegerData(8) As Integer
    Dim arrSendByte(9) As Byte
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox3.Items.Clear()

        arrIntegerData(0) = RedTrackBar.Value
        arrIntegerData(1) = GreenTrackBar.Value
        arrIntegerData(2) = BlueTrackBar.Value
        arrIntegerData(3) = HScrollBar1.Value
        arrIntegerData(4) = TrackBar1.Value
        arrIntegerData(5) = HScrollBar2.Value
        arrIntegerData(6) = HScrollBar3.Value
        arrIntegerData(7) = HScrollBar4.Value


        For f = 0 To 8
            ListBox3.Items.Add(arrIntegerData(f))
        Next

        arrSendByte(0) = CByte(Hex(36))
        arrSendByte(1) = CByte(RedTrackBar.Value)
        arrSendByte(2) = CByte(GreenTrackBar.Value)
        arrSendByte(3) = CByte(BlueTrackBar.Value)
        arrSendByte(4) = CByte(HScrollBar1.Value)
        arrSendByte(5) = CByte(TrackBar1.Value)
        arrSendByte(6) = CByte(HScrollBar2.Value)
        arrSendByte(7) = CByte(HScrollBar3.Value)
        arrSendByte(8) = CByte(HScrollBar4.Value)
        SerialPort1.Write(arrSendByte, 0, 9)

        ListBox3.Items.Add("")

        For s = 0 To 9
            ListBox3.Items.Add(arrSendByte(s))
        Next
    End Sub

    'array testing 
    'works
    Dim arrName() As String = {"R", "G", "B", "X", "Y", "Z", "Zoom", "Focus"}
    ' Dim arrValue() As Integer = {0, 0, 0}

    Dim arrUUUU(2, 2) As Integer
    Dim arrHmm(3) As Integer

    'Not work
    ' Dim arrTTT() As Integer = {r}
    ' Dim arrRRRR() As Integer  = {RedTrackBar.Value, HScrollBar1.Value}
    '  Dim r As Integer = CInt(RedTrackBar.Value)
    'Dim g As Integer = GreenTrackBar.Value
    'Dim b As Integer = BlueTrackBar.Value

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox2.Items.Clear()

        For i = 0 To 7
            ListBox2.Items.Add(arrName(i))
        Next

        'For x = 0 To 2
        '    ListBox2.Items.Add(arrValue(x))
        'Next
        ListBox2.Items.Add("")

        ListBox2.Items.Add(RedTrackBar.Value)
        ListBox2.Items.Add(GreenTrackBar.Value)
        ListBox2.Items.Add(BlueTrackBar.Value)
        ListBox2.Items.Add(HScrollBar1.Value)
        ListBox2.Items.Add(TrackBar1.Value)

        ListBox2.Items.Add("")

        'arrUUUU(0, 0) = CInt(255)
        'arrUUUU(1, 0) = 134
        'arrUUUU(2, 0) = 0
        'arrUUUU(0, 1) = 255


        'For a = 0 To 2
        '    For b = 0 To 2
        '        ListBox2.Items.Add(arrUUUU(a, b))
        '    Next
        'Next

        'For d = 0 To 0
        '    ListBox2.Items.Add(arrTTT(d))
        'Next
        arrHmm(0) = RedTrackBar.Value
        arrHmm(1) = GreenTrackBar.Value
        arrHmm(2) = BlueTrackBar.Value

        For d = 0 To 2
            ListBox2.Items.Add(arrHmm(d))
        Next

    End Sub



    ' Test values  
    'From test 

    Sub SetColor()
        Dim redVariable, greenVariable, blueVariable As Integer

        'Sets color of text box and picture box with user input.
        redVariable = CInt(RedTextBox.Text)
        greenVariable = CInt(GreenTextBox.Text)
        blueVariable = CInt(BlueTextBox.Text)

        LEDTextBox.BackColor = Color.FromArgb(redVariable, greenVariable, blueVariable)
        LEDPictureBox.BackColor = Color.FromArgb(redVariable, greenVariable, blueVariable)
        HEXTextBox.Text = Hex(redVariable) & " - " & Hex(greenVariable) & " - " & Hex(blueVariable)

        'combine two systems of color input
        RedTrackBar.Value = CInt(RedTextBox.Text)
        LabelR.Text = CStr(RedTrackBar.Value)
        LabelR.BackColor = Color.FromArgb(RedTrackBar.Value, 0, 0)

        GreenTrackBar.Value = CInt(GreenTextBox.Text)
        LabelG.Text = CStr(GreenTrackBar.Value)
        LabelG.BackColor = Color.FromArgb(0, GreenTrackBar.Value, 0)

        BlueTrackBar.Value = CInt(BlueTextBox.Text)
        BLabel.Text = CStr(BlueTrackBar.Value)
        BLabel.BackColor = Color.FromArgb(0, 0, BlueTrackBar.Value)

    End Sub

    Private Sub RedTrackBar_Scroll(sender As Object, e As EventArgs) Handles RedTrackBar.Scroll

        TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        LabelR.Text = CStr(RedTrackBar.Value)
        LabelR.BackColor = Color.FromArgb(RedTrackBar.Value, 0, 0)

        RedTextBox.Text = CStr(RedTrackBar.Value)
        LEDTextBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)

        ' SetColor()
        'Displayhex()
        DisplayH()
    End Sub



    Private Sub GreenTrackBar_Scroll(sender As Object, e As EventArgs) Handles GreenTrackBar.Scroll
        TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        LabelG.Text = CStr(GreenTrackBar.Value)
        LabelG.BackColor = Color.FromArgb(0, GreenTrackBar.Value, 0)

        GreenTextBox.Text = CStr(GreenTrackBar.Value)
        '  LEDTextBox.BackColor = Color.FromArgb(redVariable, GreenTrackBar.Value, blueVariable)
        LEDTextBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)

        ' SetColor()
        ' Displayhex()
        DisplayH()
    End Sub

    Private Sub BlueTrackBar_Scroll(sender As Object, e As EventArgs) Handles BlueTrackBar.Scroll

        TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        BLabel.Text = CStr(BlueTrackBar.Value)
        BLabel.BackColor = Color.FromArgb(0, 0, BlueTrackBar.Value)

        BlueTextBox.Text = CStr(BlueTrackBar.Value)

        'LEDTextBox.BackColor = Color.FromArgb(redVariable, greenVariable, BlueTrackBar.Value)
        LEDTextBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)

        ' SetColor()
        'Displayhex()
        DisplayH()

    End Sub

    Sub DisplayH()
        Dim redHEX, greenHex, blueHex As String
        Dim numberCharatersR, numberCharatersG, numberCharactersB As Integer
        Dim redDisplay, greenDisplay, blueDisplay As String

        'Convert color input to hex numbers.
        'displayed as strings
        redHEX = Hex(RedTrackBar.Value)
        greenHex = Hex(GreenTrackBar.Value)
        blueHex = Hex(BlueTrackBar.Value)

        'Count the number of characters in string of each color's hex value.
        numberCharatersR = Len(redHEX)
        numberCharatersG = Len(greenHex)
        numberCharactersB = Len(blueHex)

        'Set display of Hex color values to digit display.
        If numberCharatersR < 2 Then
            redDisplay = "0" & redHEX
        Else
            redDisplay = redHEX

        End If

        If numberCharatersG < 2 Then
            greenDisplay = "0" & greenHex
        Else
            greenDisplay = greenHex

        End If

        If numberCharactersB < 2 Then
            blueDisplay = "0" & blueHex
        Else
            blueDisplay = blueHex

        End If

        HelloTextBox.Text = redDisplay & " - " & greenDisplay & " - " & blueDisplay
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SetColor()
        ' Displayhex()
        DisplayH()
        TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub




    'Resets motor stuff in group box 1
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        TrackBar1.Value = 124
        yLabel.Text = CStr(TrackBar1.Value)
        HScrollBar1.Value = 150
        XLabel.Text = CStr(HScrollBar1.Value)
        HScrollBar2.Value = 127
        HScrollBar3.Value = 127
        HScrollBar4.Value = 127
    End Sub



    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        XLabel.Text = CStr(HScrollBar1.Value)
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        yLabel.Text = CStr(TrackBar1.Value)
    End Sub




    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RedTextBox.Clear()
        GreenTextBox.Clear()
        BlueTextBox.Clear()
        RedTrackBar.Value = 0
        GreenTrackBar.Value = 0
        BlueTrackBar.Value = 0
        LEDTextBox.BackColor = Color.FromArgb(0, 0, 0)
        LEDPictureBox.BackColor = Color.FromArgb(0, 0, 0)
        HEXTextBox.Clear()
        HelloTextBox.Clear()
        TextBox1.BackColor = Color.FromArgb(0, 0, 0)
        LabelR.Text = ""
        LabelG.Text = ""
        BLabel.Text = "B"
    End Sub

End Class
