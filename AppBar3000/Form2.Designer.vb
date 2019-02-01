<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.components = New System.ComponentModel.Container()
        Me.SettingsButtonOK = New System.Windows.Forms.Button()
        Me.AppBarPositionCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AppBarSizeTB = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CTrancparency = New System.Windows.Forms.CheckBox()
        Me.R90 = New System.Windows.Forms.RadioButton()
        Me.R80 = New System.Windows.Forms.RadioButton()
        Me.R70 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'SettingsButtonOK
        '
        Me.SettingsButtonOK.Location = New System.Drawing.Point(197, 131)
        Me.SettingsButtonOK.Name = "SettingsButtonOK"
        Me.SettingsButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.SettingsButtonOK.TabIndex = 0
        Me.SettingsButtonOK.Text = "Ok"
        Me.SettingsButtonOK.UseVisualStyleBackColor = True
        '
        'AppBarPositionCB
        '
        Me.AppBarPositionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppBarPositionCB.FormattingEnabled = True
        Me.AppBarPositionCB.Location = New System.Drawing.Point(10, 25)
        Me.AppBarPositionCB.Name = "AppBarPositionCB"
        Me.AppBarPositionCB.Size = New System.Drawing.Size(121, 21)
        Me.AppBarPositionCB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select AppBar Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(7, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AppBar Size"
        Me.Label2.Visible = False
        '
        'AppBarSizeTB
        '
        Me.AppBarSizeTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AppBarSizeTB.Enabled = False
        Me.AppBarSizeTB.Location = New System.Drawing.Point(10, 134)
        Me.AppBarSizeTB.Name = "AppBarSizeTB"
        Me.AppBarSizeTB.Size = New System.Drawing.Size(62, 20)
        Me.AppBarSizeTB.TabIndex = 4
        Me.AppBarSizeTB.Text = "75"
        Me.AppBarSizeTB.Visible = False
        '
        'CTrancparency
        '
        Me.CTrancparency.AutoSize = True
        Me.CTrancparency.Location = New System.Drawing.Point(10, 52)
        Me.CTrancparency.Name = "CTrancparency"
        Me.CTrancparency.Size = New System.Drawing.Size(127, 17)
        Me.CTrancparency.TabIndex = 5
        Me.CTrancparency.Text = "Enable Transparency"
        Me.CTrancparency.UseVisualStyleBackColor = True
        '
        'R90
        '
        Me.R90.AutoSize = True
        Me.R90.Location = New System.Drawing.Point(10, 75)
        Me.R90.Name = "R90"
        Me.R90.Size = New System.Drawing.Size(45, 17)
        Me.R90.TabIndex = 6
        Me.R90.TabStop = True
        Me.R90.Text = "90%"
        Me.R90.UseVisualStyleBackColor = True
        '
        'R80
        '
        Me.R80.AutoSize = True
        Me.R80.Location = New System.Drawing.Point(61, 75)
        Me.R80.Name = "R80"
        Me.R80.Size = New System.Drawing.Size(45, 17)
        Me.R80.TabIndex = 7
        Me.R80.TabStop = True
        Me.R80.Text = "80%"
        Me.R80.UseVisualStyleBackColor = True
        '
        'R70
        '
        Me.R70.AutoSize = True
        Me.R70.Location = New System.Drawing.Point(112, 75)
        Me.R70.Name = "R70"
        Me.R70.Size = New System.Drawing.Size(45, 17)
        Me.R70.TabIndex = 8
        Me.R70.TabStop = True
        Me.R70.Text = "70%"
        Me.R70.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 166)
        Me.ControlBox = False
        Me.Controls.Add(Me.R70)
        Me.Controls.Add(Me.R80)
        Me.Controls.Add(Me.R90)
        Me.Controls.Add(Me.CTrancparency)
        Me.Controls.Add(Me.AppBarSizeTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AppBarPositionCB)
        Me.Controls.Add(Me.SettingsButtonOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Settings"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SettingsButtonOK As Button
    Friend WithEvents AppBarPositionCB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AppBarSizeTB As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents CTrancparency As CheckBox
    Friend WithEvents R90 As RadioButton
    Friend WithEvents R80 As RadioButton
    Friend WithEvents R70 As RadioButton
End Class
