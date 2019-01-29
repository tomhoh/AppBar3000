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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuRemoveItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClosePB = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SettingsPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Form1FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ClosePB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SettingsPB
        '
        Me.SettingsPB.Image = Global.AppBar3000.My.Resources.Resources.Gear
        Me.SettingsPB.Location = New System.Drawing.Point(96, 336)
        Me.SettingsPB.Name = "SettingsPB"
        Me.SettingsPB.Size = New System.Drawing.Size(50, 50)
        Me.SettingsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SettingsPB.TabIndex = 0
        Me.SettingsPB.TabStop = False
        '
        'Form1FlowLayoutPanel1
        '
        Me.Form1FlowLayoutPanel1.AllowDrop = True
        Me.Form1FlowLayoutPanel1.Controls.Add(Me.PictureBox1)
        Me.Form1FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.Form1FlowLayoutPanel1.Name = "Form1FlowLayoutPanel1"
        Me.Form1FlowLayoutPanel1.Size = New System.Drawing.Size(134, 318)
        Me.Form1FlowLayoutPanel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuRemoveItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 48)
        '
        'MenuRemoveItem
        '
        Me.MenuRemoveItem.Name = "MenuRemoveItem"
        Me.MenuRemoveItem.Size = New System.Drawing.Size(180, 22)
        Me.MenuRemoveItem.Text = "Remove"
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
        'AppBar3000
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(158, 398)
        Me.ControlBox = False
        Me.Controls.Add(Me.ClosePB)
        Me.Controls.Add(Me.Form1FlowLayoutPanel1)
        Me.Controls.Add(Me.SettingsPB)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AppBar3000"
        Me.Opacity = 0.9R
        Me.RightToLeftLayout = True
        CType(Me.SettingsPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Form1FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ClosePB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SettingsPB As PictureBox
    Friend WithEvents Form1FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ClosePB As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuRemoveItem As ToolStripMenuItem
End Class
