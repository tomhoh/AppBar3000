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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Labels = New System.Windows.Forms.Button()
        CType(Me.SettingsPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosePB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cms1.SuspendLayout()
        Me.Cms2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingsPB
        '
        Me.SettingsPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsPB.Image = Global.AppBar3000.My.Resources.Resources.Gear
        Me.SettingsPB.Location = New System.Drawing.Point(1122, 14)
        Me.SettingsPB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SettingsPB.Name = "SettingsPB"
        Me.SettingsPB.Size = New System.Drawing.Size(22, 23)
        Me.SettingsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SettingsPB.TabIndex = 0
        Me.SettingsPB.TabStop = False
        '
        'Form1FlowLayoutPanel1
        '
        Me.Form1FlowLayoutPanel1.AllowDrop = True
        Me.Form1FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Form1FlowLayoutPanel1.Location = New System.Drawing.Point(18, 14)
        Me.Form1FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 50, 5)
        Me.Form1FlowLayoutPanel1.Name = "Form1FlowLayoutPanel1"
        Me.Form1FlowLayoutPanel1.Size = New System.Drawing.Size(1000, 50)
        Me.Form1FlowLayoutPanel1.TabIndex = 2
        '
        'ClosePB
        '
        Me.ClosePB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClosePB.Cursor = System.Windows.Forms.Cursors.Default
        Me.ClosePB.Image = Global.AppBar3000.My.Resources.Resources.Close
        Me.ClosePB.Location = New System.Drawing.Point(1152, 1)
        Me.ClosePB.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ClosePB.Name = "ClosePB"
        Me.ClosePB.Size = New System.Drawing.Size(29, 23)
        Me.ClosePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ClosePB.TabIndex = 3
        Me.ClosePB.TabStop = False
        '
        'Cms1
        '
        Me.Cms1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Cms1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.Cms1.Name = "cms1"
        Me.Cms1.Size = New System.Drawing.Size(149, 68)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(148, 32)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(148, 32)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Cms2
        '
        Me.Cms2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Cms2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem})
        Me.Cms2.Name = "ContextMenuStrip1"
        Me.Cms2.Size = New System.Drawing.Size(149, 36)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(148, 32)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1024, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Log"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(1106, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 47)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Dash"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Labels
        '
        Me.Labels.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Labels.BackColor = System.Drawing.Color.SteelBlue
        Me.Labels.Cursor = System.Windows.Forms.Cursors.Default
        Me.Labels.FlatAppearance.BorderSize = 0
        Me.Labels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Labels.Location = New System.Drawing.Point(1188, 2)
        Me.Labels.Name = "Labels"
        Me.Labels.Size = New System.Drawing.Size(75, 47)
        Me.Labels.TabIndex = 5
        Me.Labels.Text = "Labels"
        Me.Labels.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Labels.UseVisualStyleBackColor = False
        '
        'AppBar3000
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1416, 162)
        Me.ContextMenuStrip = Me.Cms1
        Me.ControlBox = False
        Me.Controls.Add(Me.Labels)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SettingsPB)
        Me.Controls.Add(Me.ClosePB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Form1FlowLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Labels As Button
End Class
