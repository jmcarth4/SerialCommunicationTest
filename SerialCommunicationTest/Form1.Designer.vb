<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelR = New System.Windows.Forms.Label()
        Me.BLabel = New System.Windows.Forms.Label()
        Me.LabelG = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BlueTrackBar = New System.Windows.Forms.TrackBar()
        Me.RedTrackBar = New System.Windows.Forms.TrackBar()
        Me.GreenTrackBar = New System.Windows.Forms.TrackBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HScrollBar4 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar3 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.XLabel = New System.Windows.Forms.Label()
        Me.yLabel = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.HelloTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HEXTextBox = New System.Windows.Forms.TextBox()
        Me.LEDTextBox = New System.Windows.Forms.TextBox()
        Me.LEDPictureBox = New System.Windows.Forms.PictureBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GreenLabel = New System.Windows.Forms.Label()
        Me.RedLabel = New System.Windows.Forms.Label()
        Me.BlueTextBox = New System.Windows.Forms.TextBox()
        Me.GreenTextBox = New System.Windows.Forms.TextBox()
        Me.RedTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        CType(Me.BlueTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RedTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreenTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEDPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(28, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(133, 324)
        Me.ListBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(51, 472)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 55)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelR
        '
        Me.LabelR.AutoSize = True
        Me.LabelR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelR.Location = New System.Drawing.Point(484, 489)
        Me.LabelR.Name = "LabelR"
        Me.LabelR.Size = New System.Drawing.Size(21, 20)
        Me.LabelR.TabIndex = 58
        Me.LabelR.Text = "R"
        '
        'BLabel
        '
        Me.BLabel.AutoSize = True
        Me.BLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BLabel.Location = New System.Drawing.Point(916, 499)
        Me.BLabel.Name = "BLabel"
        Me.BLabel.Size = New System.Drawing.Size(20, 20)
        Me.BLabel.TabIndex = 57
        Me.BLabel.Text = "B"
        '
        'LabelG
        '
        Me.LabelG.AutoSize = True
        Me.LabelG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelG.Location = New System.Drawing.Point(696, 499)
        Me.LabelG.Name = "LabelG"
        Me.LabelG.Size = New System.Drawing.Size(22, 20)
        Me.LabelG.TabIndex = 56
        Me.LabelG.Text = "G"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(559, 532)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 55
        '
        'BlueTrackBar
        '
        Me.BlueTrackBar.Location = New System.Drawing.Point(840, 429)
        Me.BlueTrackBar.Maximum = 255
        Me.BlueTrackBar.Name = "BlueTrackBar"
        Me.BlueTrackBar.Size = New System.Drawing.Size(155, 69)
        Me.BlueTrackBar.TabIndex = 54
        Me.BlueTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'RedTrackBar
        '
        Me.RedTrackBar.Location = New System.Drawing.Point(422, 429)
        Me.RedTrackBar.Maximum = 255
        Me.RedTrackBar.Name = "RedTrackBar"
        Me.RedTrackBar.Size = New System.Drawing.Size(151, 69)
        Me.RedTrackBar.TabIndex = 52
        Me.RedTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'GreenTrackBar
        '
        Me.GreenTrackBar.Location = New System.Drawing.Point(615, 429)
        Me.GreenTrackBar.Maximum = 255
        Me.GreenTrackBar.Name = "GreenTrackBar"
        Me.GreenTrackBar.Size = New System.Drawing.Size(195, 69)
        Me.GreenTrackBar.TabIndex = 53
        Me.GreenTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HScrollBar4)
        Me.GroupBox1.Controls.Add(Me.HScrollBar3)
        Me.GroupBox1.Controls.Add(Me.HScrollBar2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.XLabel)
        Me.GroupBox1.Controls.Add(Me.yLabel)
        Me.GroupBox1.Controls.Add(Me.ResetButton)
        Me.GroupBox1.Controls.Add(Me.HScrollBar1)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Location = New System.Drawing.Point(1218, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 367)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'HScrollBar4
        '
        Me.HScrollBar4.Location = New System.Drawing.Point(200, 290)
        Me.HScrollBar4.Maximum = 255
        Me.HScrollBar4.Name = "HScrollBar4"
        Me.HScrollBar4.Size = New System.Drawing.Size(153, 45)
        Me.HScrollBar4.TabIndex = 27
        Me.HScrollBar4.TabStop = True
        '
        'HScrollBar3
        '
        Me.HScrollBar3.Location = New System.Drawing.Point(19, 290)
        Me.HScrollBar3.Maximum = 255
        Me.HScrollBar3.Name = "HScrollBar3"
        Me.HScrollBar3.Size = New System.Drawing.Size(153, 45)
        Me.HScrollBar3.TabIndex = 26
        Me.HScrollBar3.TabStop = True
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(19, 235)
        Me.HScrollBar2.Maximum = 255
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(153, 45)
        Me.HScrollBar2.TabIndex = 25
        Me.HScrollBar2.TabStop = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(279, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 24
        '
        'XLabel
        '
        Me.XLabel.AutoSize = True
        Me.XLabel.ForeColor = System.Drawing.Color.Maroon
        Me.XLabel.Location = New System.Drawing.Point(172, 22)
        Me.XLabel.Name = "XLabel"
        Me.XLabel.Size = New System.Drawing.Size(0, 20)
        Me.XLabel.TabIndex = 23
        '
        'yLabel
        '
        Me.yLabel.AutoSize = True
        Me.yLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.yLabel.Location = New System.Drawing.Point(196, 222)
        Me.yLabel.Name = "yLabel"
        Me.yLabel.Size = New System.Drawing.Size(0, 20)
        Me.yLabel.TabIndex = 22
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ResetButton.ForeColor = System.Drawing.Color.Black
        Me.ResetButton.Location = New System.Drawing.Point(183, 103)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(93, 45)
        Me.ResetButton.TabIndex = 20
        Me.ResetButton.Text = "&Reset "
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(13, 79)
        Me.HScrollBar1.Maximum = 255
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(153, 45)
        Me.HScrollBar1.TabIndex = 16
        Me.HScrollBar1.TabStop = True
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 10
        Me.TrackBar1.Location = New System.Drawing.Point(13, 163)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(153, 69)
        Me.TrackBar1.TabIndex = 17
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'HelloTextBox
        '
        Me.HelloTextBox.Location = New System.Drawing.Point(1098, 316)
        Me.HelloTextBox.Name = "HelloTextBox"
        Me.HelloTextBox.Size = New System.Drawing.Size(100, 26)
        Me.HelloTextBox.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1021, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "HEX Value"
        '
        'HEXTextBox
        '
        Me.HEXTextBox.Location = New System.Drawing.Point(1007, 224)
        Me.HEXTextBox.Name = "HEXTextBox"
        Me.HEXTextBox.Size = New System.Drawing.Size(100, 26)
        Me.HEXTextBox.TabIndex = 46
        '
        'LEDTextBox
        '
        Me.LEDTextBox.Location = New System.Drawing.Point(807, 224)
        Me.LEDTextBox.Name = "LEDTextBox"
        Me.LEDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.LEDTextBox.TabIndex = 45
        '
        'LEDPictureBox
        '
        Me.LEDPictureBox.Location = New System.Drawing.Point(559, 224)
        Me.LEDPictureBox.Name = "LEDPictureBox"
        Me.LEDPictureBox.Size = New System.Drawing.Size(100, 50)
        Me.LEDPictureBox.TabIndex = 44
        Me.LEDPictureBox.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.ForeColor = System.Drawing.Color.Black
        Me.ClearButton.Location = New System.Drawing.Point(1078, 453)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(93, 45)
        Me.ClearButton.TabIndex = 43
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExitButton.ForeColor = System.Drawing.Color.Black
        Me.ExitButton.Location = New System.Drawing.Point(1436, 499)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(93, 45)
        Me.ExitButton.TabIndex = 42
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(1025, 365)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 50)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "&Set Colour"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(895, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Blue"
        '
        'GreenLabel
        '
        Me.GreenLabel.AutoSize = True
        Me.GreenLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GreenLabel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GreenLabel.Location = New System.Drawing.Point(719, 322)
        Me.GreenLabel.Name = "GreenLabel"
        Me.GreenLabel.Size = New System.Drawing.Size(54, 20)
        Me.GreenLabel.TabIndex = 39
        Me.GreenLabel.Text = "Green"
        '
        'RedLabel
        '
        Me.RedLabel.AutoSize = True
        Me.RedLabel.BackColor = System.Drawing.Color.Red
        Me.RedLabel.ForeColor = System.Drawing.Color.Black
        Me.RedLabel.Location = New System.Drawing.Point(500, 322)
        Me.RedLabel.Name = "RedLabel"
        Me.RedLabel.Size = New System.Drawing.Size(39, 20)
        Me.RedLabel.TabIndex = 38
        Me.RedLabel.Text = "Red"
        '
        'BlueTextBox
        '
        Me.BlueTextBox.Location = New System.Drawing.Point(873, 371)
        Me.BlueTextBox.Name = "BlueTextBox"
        Me.BlueTextBox.Size = New System.Drawing.Size(100, 26)
        Me.BlueTextBox.TabIndex = 37
        '
        'GreenTextBox
        '
        Me.GreenTextBox.Location = New System.Drawing.Point(710, 371)
        Me.GreenTextBox.Name = "GreenTextBox"
        Me.GreenTextBox.Size = New System.Drawing.Size(100, 26)
        Me.GreenTextBox.TabIndex = 36
        '
        'RedTextBox
        '
        Me.RedTextBox.Location = New System.Drawing.Point(488, 371)
        Me.RedTextBox.Name = "RedTextBox"
        Me.RedTextBox.Size = New System.Drawing.Size(100, 26)
        Me.RedTextBox.TabIndex = 35
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(176, 12)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(143, 324)
        Me.ListBox2.TabIndex = 59
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(196, 357)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 55)
        Me.Button3.TabIndex = 60
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(357, 360)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 55)
        Me.Button4.TabIndex = 61
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(334, 12)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(143, 324)
        Me.ListBox3.TabIndex = 62
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1618, 773)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.LabelR)
        Me.Controls.Add(Me.BLabel)
        Me.Controls.Add(Me.LabelG)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.BlueTrackBar)
        Me.Controls.Add(Me.RedTrackBar)
        Me.Controls.Add(Me.GreenTrackBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.HelloTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HEXTextBox)
        Me.Controls.Add(Me.LEDTextBox)
        Me.Controls.Add(Me.LEDPictureBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GreenLabel)
        Me.Controls.Add(Me.RedLabel)
        Me.Controls.Add(Me.BlueTextBox)
        Me.Controls.Add(Me.GreenTextBox)
        Me.Controls.Add(Me.RedTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BlueTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RedTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreenTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEDPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LabelR As Label
    Friend WithEvents BLabel As Label
    Friend WithEvents LabelG As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BlueTrackBar As TrackBar
    Friend WithEvents RedTrackBar As TrackBar
    Friend WithEvents GreenTrackBar As TrackBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents XLabel As Label
    Friend WithEvents yLabel As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents HelloTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents HEXTextBox As TextBox
    Friend WithEvents LEDTextBox As TextBox
    Friend WithEvents LEDPictureBox As PictureBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GreenLabel As Label
    Friend WithEvents RedLabel As Label
    Friend WithEvents BlueTextBox As TextBox
    Friend WithEvents GreenTextBox As TextBox
    Friend WithEvents RedTextBox As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents HScrollBar3 As HScrollBar
    Friend WithEvents HScrollBar2 As HScrollBar
    Friend WithEvents HScrollBar4 As HScrollBar
End Class
