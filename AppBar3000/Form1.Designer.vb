<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppBar3000
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
        Me.SettingsPB = New System.Windows.Forms.PictureBox()
        Me.Form1FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ClosePB = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cms1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cms2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SettingsPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosePB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cms1.SuspendLayout()
        Me.Cms2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingsPB
        '
        Me.SettingsPB.Image = Global.AppBar3000.My.Resources.Resources.Gear
        Me.SettingsPB.Location = New System.Drawing.Point(33, 361)
        Me.SettingsPB.Name = "SettingsPB"
        Me.SettingsPB.Size = New System.Drawing.Size(15, 15)
        Me.SettingsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SettingsPB.TabIndex = 0
        Me.SettingsPB.TabStop = False
        '
        'Form1FlowLayoutPanel1
        '
        Me.Form1FlowLayoutPanel1.AllowDrop = True
        Me.Form1FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.Form1FlowLayoutPanel1.Name = "Form1FlowLayoutPanel1"
        Me.Form1FlowLayoutPanel1.Size = New System.Drawing.Size(134, 318)
        Me.Form1FlowLayoutPanel1.TabIndex = 2
        '
        'ClosePB
        '
        Me.ClosePB.Cursor = System.Windows.Forms.Cursors.Default
        Me.ClosePB.Image = Global.AppBar3000.My.Resources.Resources.Close
        Me.ClosePB.Location = New System.Drawing.Point(12, 361)
        Me.ClosePB.Name = "ClosePB"
        Me.ClosePB.Size = New System.Drawing.Size(15, 15)
        Me.ClosePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ClosePB.TabIndex = 3
        Me.ClosePB.TabStop = False
        '
        'Cms1
        '
        Me.Cms1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.Cms1.Name = "cms1"
        Me.Cms1.Size = New System.Drawing.Size(117, 48)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Cms2
        '
        Me.Cms2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem})
        Me.Cms2.Name = "ContextMenuStrip1"
        Me.Cms2.Size = New System.Drawing.Size(181, 48)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'AppBar3000
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(158, 398)
        Me.ContextMenuStrip = Me.Cms1
        Me.ControlBox = False
        Me.Controls.Add(Me.ClosePB)
        Me.Controls.Add(Me.Form1FlowLayoutPanel1)
        Me.Controls.Add(Me.SettingsPB)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AppBar3000"
        Me.Opacity = 0.7R
        Me.RightToLeftLayout = True
        CType(Me.SettingsPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClosePB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cms1.ResumeLayout(False)
        Me.Cms2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SettingsPB As PictureBox
    Friend WithEvents Form1FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ClosePB As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Cms1 As ContextMenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Cms2 As ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
End Class
