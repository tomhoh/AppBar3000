<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.SettingsButtonOK = New System.Windows.Forms.Button()
        Me.AppBarPositionCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AppBarSizeTB = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'SettingsButtonOK
        '
        Me.SettingsButtonOK.Location = New System.Drawing.Point(197, 126)
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
        Me.Label2.Location = New System.Drawing.Point(7, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AppBar Size"
        '
        'AppBarSizeTB
        '
        Me.AppBarSizeTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AppBarSizeTB.Location = New System.Drawing.Point(10, 65)
        Me.AppBarSizeTB.Name = "AppBarSizeTB"
        Me.AppBarSizeTB.Size = New System.Drawing.Size(62, 20)
        Me.AppBarSizeTB.TabIndex = 4
        Me.AppBarSizeTB.Text = "75"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.ControlBox = False
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
End Class
