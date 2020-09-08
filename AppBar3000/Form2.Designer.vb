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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SettingsCancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SettingsButtonOK
        '
        Me.SettingsButtonOK.Location = New System.Drawing.Point(338, 290)
        Me.SettingsButtonOK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SettingsButtonOK.Name = "SettingsButtonOK"
        Me.SettingsButtonOK.Size = New System.Drawing.Size(112, 35)
        Me.SettingsButtonOK.TabIndex = 0
        Me.SettingsButtonOK.Text = "Ok"
        Me.SettingsButtonOK.UseVisualStyleBackColor = True
        '
        'AppBarPositionCB
        '
        Me.AppBarPositionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppBarPositionCB.FormattingEnabled = True
        Me.AppBarPositionCB.Location = New System.Drawing.Point(15, 38)
        Me.AppBarPositionCB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AppBarPositionCB.Name = "AppBarPositionCB"
        Me.AppBarPositionCB.Size = New System.Drawing.Size(180, 28)
        Me.AppBarPositionCB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select AppBar Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 182)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AppBar Size"
        Me.Label2.Visible = False
        '
        'AppBarSizeTB
        '
        Me.AppBarSizeTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AppBarSizeTB.Location = New System.Drawing.Point(15, 206)
        Me.AppBarSizeTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AppBarSizeTB.Name = "AppBarSizeTB"
        Me.AppBarSizeTB.Size = New System.Drawing.Size(92, 26)
        Me.AppBarSizeTB.TabIndex = 4
        Me.AppBarSizeTB.Text = "50"
        Me.AppBarSizeTB.Visible = False
        '
        'CTrancparency
        '
        Me.CTrancparency.AutoSize = True
        Me.CTrancparency.Location = New System.Drawing.Point(15, 80)
        Me.CTrancparency.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CTrancparency.Name = "CTrancparency"
        Me.CTrancparency.Size = New System.Drawing.Size(185, 24)
        Me.CTrancparency.TabIndex = 5
        Me.CTrancparency.Text = "Enable Transparency"
        Me.CTrancparency.UseVisualStyleBackColor = True
        '
        'R90
        '
        Me.R90.AutoSize = True
        Me.R90.Location = New System.Drawing.Point(15, 115)
        Me.R90.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R90.Name = "R90"
        Me.R90.Size = New System.Drawing.Size(66, 24)
        Me.R90.TabIndex = 6
        Me.R90.TabStop = True
        Me.R90.Text = "90%"
        Me.R90.UseVisualStyleBackColor = True
        '
        'R80
        '
        Me.R80.AutoSize = True
        Me.R80.Location = New System.Drawing.Point(92, 115)
        Me.R80.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R80.Name = "R80"
        Me.R80.Size = New System.Drawing.Size(66, 24)
        Me.R80.TabIndex = 7
        Me.R80.TabStop = True
        Me.R80.Text = "80%"
        Me.R80.UseVisualStyleBackColor = True
        '
        'R70
        '
        Me.R70.AutoSize = True
        Me.R70.Location = New System.Drawing.Point(168, 115)
        Me.R70.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R70.Name = "R70"
        Me.R70.Size = New System.Drawing.Size(66, 24)
        Me.R70.TabIndex = 8
        Me.R70.TabStop = True
        Me.R70.Text = "70%"
        Me.R70.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 38)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Advanced"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SettingsCancelButton
        '
        Me.SettingsCancelButton.Location = New System.Drawing.Point(218, 290)
        Me.SettingsCancelButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SettingsCancelButton.Name = "SettingsCancelButton"
        Me.SettingsCancelButton.Size = New System.Drawing.Size(112, 35)
        Me.SettingsCancelButton.TabIndex = 10
        Me.SettingsCancelButton.Text = "Cancel"
        Me.SettingsCancelButton.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 337)
        Me.ControlBox = False
        Me.Controls.Add(Me.SettingsCancelButton)
        Me.Controls.Add(Me.Button1)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents SettingsCancelButton As Button
End Class
