Imports System.IO
Imports System.Runtime.InteropServices


Public Class AppBar3000
    Public MonNum As Integer
    Public AppBarPosition As Integer
    Public AppBarSize As Integer
    Public DisNum As Integer
    Public Shortcuts As New List(Of String)
    Public ListLocation = My.Computer.FileSystem.CurrentDirectory & "\Shortcut.txt"
    Public RShortcut As String
    Public PBNum As Integer
    Public pbtags As New List(Of String)
    Public RClick As Integer = 0
    Public TBar As Integer
    Public TBarValue As Decimal
    Public DeletedBox As String
    Public DeletedBoxName As Object
    Public CurrentMonitor As Integer


    Private Structure RECT

        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer

    End Structure

    Private Structure APPBARDATA

        Public cbSize As Integer
        Public hWnd As IntPtr
        Public uCallbackMessage As Integer
        Public uEdge As Integer
        Public rc As RECT
        Public lParam As IntPtr

    End Structure

    Private Enum ABMsg As Integer

        ABM_NEW = 0
        ABM_REMOVE = 1
        ABM_QUERYPOS = 2
        ABM_SETPOS = 3
        ABM_GETSTATE = 4
        ABM_GETTASKBARPOS = 5
        ABM_ACTIVATE = 6
        ABM_GETAUTOHIDEBAR = 7
        ABM_SETAUTOHIDEBAR = 8
        ABM_WINDOWPOSCHANGED = 9
        ABM_SETSTATE = 10

    End Enum

    Private Enum ABNotify As Integer

        ABN_STATECHANGE = 0
        ABN_POSCHANGED
        ABN_FULLSCREENAPP
        ABN_WINDOWARRANGE

    End Enum

    Private Enum ABEdge As Integer

        ABE_LEFT = &H0
        ABE_TOP = &H1
        ABE_RIGHT = &H2
        ABE_BOTTOM = &H3

    End Enum

    Private fBarRegistered As Boolean = False

    Private Declare Function SHAppBarMessage Lib "shell32.dll" Alias "SHAppBarMessage" _
    (ByVal dwMessage As Integer, <MarshalAs(UnmanagedType.Struct)> ByRef pData As _
    APPBARDATA) As IntPtr

    Private Declare Function LockWorkStation Lib "user32.dll" Alias "LockWorkStation" () As Boolean

    Private Declare Function GetSystemMetrics Lib "user32" Alias "GetSystemMetrics" _
    (ByVal nIndex As Integer) As Integer

    Private Declare Function MoveWindow Lib "user32" Alias "MoveWindow" (ByVal hwnd As Integer,
    ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer,
    ByVal bRepaint As Integer) As Integer

    Private Declare Function RegisterWindowMessage Lib "user32" Alias "RegisterWindowMessageA" _
    (ByVal lpString As String) As Integer

    Private uCallBack As Integer

    Dim icons As Integer = 0

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Select Case keyData
            Case Keys.F12
                'LockWorkStation()
                GetAll(Me, GetType(PictureBox)).ToList.ForEach(
            Sub(c)
                Console.WriteLine("{0}.{1}", c.Parent.Name, c.Name)
            End Sub)
        End Select
        Return 0

    End Function

    Protected Overloads Overrides Sub WndProc(ByRef m As Message)

        If m.Msg = uCallBack Then
            Select Case m.WParam.ToInt32()
                Case CInt(ABNotify.ABN_POSCHANGED)
                    ABSetPos()
                    Exit Select
            End Select
        End If
        MyBase.WndProc(m)

    End Sub

    Public Function GetAll(ByVal sender As Control, ByVal T As Type) As IEnumerable(Of Control)
        Dim controls = sender.Controls.Cast(Of Control)()
        Return controls.SelectMany(
            Function(ctrl) GetAll(ctrl, T)).Concat(controls).Where(
            Function(c) c.GetType() Is T)
    End Function

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        PBNum = 0
        Me.Visible = False
        SettingsPB.Visible = False
        ClosePB.Visible = True
        CheckSettings()
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        RegisterBar()
        SetTransparency()
        ABSetPos()
        Me.Invalidate()
        LoadShortcuts()
        CmsMenu()

    End Sub

    Public Sub CmsMenu()
        Dim Cms1 = New ContextMenuStrip
        Dim Menu1Item1 = Cms1.Items.Add("Settings")
        ' Dim Menu1Item2 = Cms1.Items.Add("Exit")

        Dim Cms2 = New ContextMenuStrip
        Dim Menu2Item1 = Cms2.Items.Add("Remove")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Visible = True
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Form1FlowLayoutPanel1.Controls.Remove(DeletedBoxName)

        RemoveShortcut(DeletedBox)
    End Sub
    Public Sub SetTransparency()
        If TBar = 1 Then
            Me.Opacity = TBarValue
        Else
            Me.Opacity = 1
        End If
    End Sub

    Public Sub CheckSettings()

        Dim directory As String = AppDomain.CurrentDomain.BaseDirectory + "AppBar3000.exe.config"
        If File.Exists(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile) Then
            AppBarPosition = My.Settings.AppBarPosition
            MonNum = My.Settings.MonNum
            AppBarSize = My.Settings.AppBarSize
            DisNum = My.Settings.DisNum
            TBar = My.Settings.TBar
            TBarValue = My.Settings.TBarValue
        Else
            File.WriteAllText(directory, My.Resources.AppBar3000Config)
            MsgBox("Configuration file not found" & vbCrLf + "Default settings have been loaded", 64, "Defaults")
            AppBarPosition = 0
            AppBarSize = 75
            DisNum = 1
            MonNum = 0
            TBar = 1
            TBarValue = 0.9
        End If

    End Sub

    Public Sub SaveSettings()

        If File.Exists(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile) Then
            My.Settings.AppBarPosition = AppBarPosition
            My.Settings.AppBarSize = AppBarSize
            My.Settings.MonNum = MonNum
            My.Settings.DisNum = DisNum
            My.Settings.TBarValue = TBarValue
            My.Settings.TBar = TBar
            My.Settings.Save()
        End If

        File.WriteAllLines(ListLocation, Shortcuts.ToArray)

    End Sub

    Private Sub LoadShortcuts()

        Dim ListLocation = My.Computer.FileSystem.CurrentDirectory & "\Shortcut.txt"
        Dim TextLine As String = ""
        PBNum = PBNum + 1
        If File.Exists(ListLocation) = True Then
            Using Reader As New StreamReader(ListLocation)
                While Reader.EndOfStream = False
                    Shortcuts.Add(Reader.ReadLine())
                End While
            End Using
            For Each Shortcut As String In Shortcuts
                If File.Exists(Shortcut) = True Then
                    Dim pb As New PictureBox With {
                    .Size = New Size(32, 32),
                    .Location = New Point(12 + (icons * 44), 12),
                    .Tag = Shortcut,
                    .Name = "pb" + PBNum.ToString,
                    .ContextMenuStrip = Cms2
                }
                    Dim icon As Icon = Icon.ExtractAssociatedIcon(Shortcut)
                    pb.Image = icon.ToBitmap
                    pb.Cursor = Cursors.Hand
                    AddHandler pb.DoubleClick, AddressOf PictureBox_DoubleClick
                    AddHandler pb.MouseDown, AddressOf PictureBox_MouseDown
                    AddHandler pb.MouseUp, AddressOf PictureBox_MouseUp
                    ToolTip1.SetToolTip(pb, Shortcut)
                    PBNum = PBNum + 1
                    pbtags.Add(Shortcut)
                    Form1FlowLayoutPanel1.Controls.Add(pb)
                    icons += 1
                End If
            Next
        End If

    End Sub

    Private Function RemoveShortcut(ByVal RShortcut As String)

        'Dim ListLocation = My.Computer.FileSystem.CurrentDirectory & "\Shortcut.txt"
        'Dim fileContents = File.ReadAllLines(ListLocation).ToList

        ' Remove unwanted stuff
        For i = Shortcuts.Count - 1 To 0 Step -1
            If Shortcuts(i).Contains(RShortcut) Then
                Shortcuts.RemoveAt(i)
            End If
        Next

        ' Write the file to disk
        Return 0

    End Function

    Private Sub RegisterBar()

        Dim abd As New APPBARDATA
        abd.cbSize = Marshal.SizeOf(abd)
        abd.hWnd = Handle
        If Not fBarRegistered Then
            uCallBack = RegisterWindowMessage("AppBarMessage")
            abd.uCallbackMessage = uCallBack

            Dim ret As Integer = SHAppBarMessage(CType(ABMsg.ABM_NEW, Integer), abd)
            fBarRegistered = True

            ABSetPos()
        Else
            'abd.cbSize = Marshal.SizeOf(abd)
            abd.cbSize = 0
            SHAppBarMessage(CType(ABMsg.ABM_REMOVE, Integer), abd)
            fBarRegistered = False
        End If

    End Sub

    Public Sub ABSetPos()

        Dim abd As New APPBARDATA()
        abd.cbSize = Marshal.SizeOf(abd)
        abd.hWnd = Me.Handle

        'Locate Num of Monitors
        If SystemInformation.MonitorCount = 1 Then
            DisNum = 1
            MonNum = 0
        ElseIf SystemInformation.MonitorCount = 2 Then
            If DisNum = 1 Then
                MonNum = 0
            ElseIf DisNum = 2 Then
                MonNum = 1
            End If
        ElseIf SystemInformation.MonitorCount = 3 Then
            If DisNum = 1 Then
                MonNum = 0
            ElseIf DisNum = 2 Then
                MonNum = 1
            ElseIf DisNum = 3 Then
                MonNum = 2
            End If
        End If

        If AppBarPosition = 0 Then
            abd.uEdge = CInt(ABEdge.ABE_TOP)
        ElseIf AppBarPosition = 1 Then
            abd.uEdge = CInt(ABEdge.ABE_BOTTOM)
        ElseIf AppBarPosition = 2 Then
            abd.uEdge = CInt(ABEdge.ABE_LEFT)
        ElseIf AppBarPosition = 3 Then
            abd.uEdge = CInt(ABEdge.ABE_RIGHT)
        End If

        If abd.uEdge = CInt(ABEdge.ABE_RIGHT) Then
            abd.rc.top = Screen.AllScreens(MonNum).Bounds.Top
            abd.rc.left = Screen.AllScreens(MonNum).Bounds.Right - AppBarSize
            abd.rc.right = Screen.AllScreens(MonNum).Bounds.Right
            abd.rc.bottom = Screen.AllScreens(MonNum).Bounds.Height
        ElseIf abd.uEdge = CInt(ABEdge.ABE_LEFT) Then
            abd.rc.top = Screen.AllScreens(MonNum).Bounds.Top
            abd.rc.left = Screen.AllScreens(MonNum).Bounds.Left
            abd.rc.right = Screen.AllScreens(MonNum).Bounds.Right + AppBarSize
            abd.rc.bottom = Screen.AllScreens(MonNum).Bounds.Height
        ElseIf abd.uEdge = CInt(ABEdge.ABE_TOP) Then
            abd.rc.top = Screen.AllScreens(MonNum).Bounds.Top
            abd.rc.left = Screen.AllScreens(MonNum).Bounds.Left
            abd.rc.right = Screen.AllScreens(MonNum).Bounds.Right
            abd.rc.bottom = Screen.AllScreens(MonNum).Bounds.Top + AppBarSize
        ElseIf abd.uEdge = CInt(ABEdge.ABE_BOTTOM) Then
            abd.rc.top = Screen.AllScreens(MonNum).Bounds.Bottom - AppBarSize
            abd.rc.left = Screen.AllScreens(MonNum).Bounds.Left
            abd.rc.right = Screen.AllScreens(MonNum).Bounds.Right
            abd.rc.bottom = Screen.AllScreens(MonNum).Bounds.Bottom
        End If

        SHAppBarMessage(CInt(ABMsg.ABM_QUERYPOS), abd)

        ' Query the system for an approved size and position. 
        SHAppBarMessage(CInt(ABMsg.ABM_QUERYPOS), abd)

        ' Adjust the rectangle, depending on the edge to which the 
        ' appbar is anchored. 
        Select Case abd.uEdge
            Case CInt(ABEdge.ABE_LEFT)
                abd.rc.right = abd.rc.left + AppBarSize
                Exit Select
            Case CInt(ABEdge.ABE_RIGHT)
                abd.rc.left = abd.rc.right - AppBarSize
                Exit Select
            Case CInt(ABEdge.ABE_TOP)
                abd.rc.bottom = abd.rc.top + AppBarSize
                Exit Select
            Case CInt(ABEdge.ABE_BOTTOM)
                abd.rc.top = abd.rc.bottom - AppBarSize
                Exit Select
        End Select

        ' Pass the final bounding rectangle to the system. 
        SHAppBarMessage(CInt(ABMsg.ABM_SETPOS), abd)

        ' Move and size the appbar so that it conforms to the 
        ' bounding rectangle passed to the system. 
        MoveWindow(abd.hWnd, abd.rc.left, abd.rc.top, abd.rc.right - abd.rc.left, abd.rc.bottom - abd.rc.top, True)

        SettingsLoc()
        Me.Visible = True

    End Sub

    Private Sub SettingsLoc()

        If AppBarPosition = 0 Then
            SettingsPB.Location = New Point(Me.Size.Width - 150, 20)
            ClosePB.Location = New Point(Me.Size.Width - 15, 0)
            Form1FlowLayoutPanel1.Location = New Point(0, 0)
            Form1FlowLayoutPanel1.Size = New Point(Me.Size.Width - (Me.Size.Width * 0.5), AppBarSize)
            Form1FlowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight
        ElseIf AppBarPosition = 1 Then
            SettingsPB.Location = New Point(Me.Size.Width - 15, 20)
            ClosePB.Location = New Point(Me.Size.Width - 15, Me.Size.Width - 15)
            Form1FlowLayoutPanel1.Location = New Point(0, 0)
            Form1FlowLayoutPanel1.Size = New Point(Me.Size.Width - 75, AppBarSize)
            Form1FlowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight
        ElseIf AppBarPosition = 2 Then
            SettingsPB.Location = New Point(12.5, Me.Size.Height - 62.5)
            ClosePB.Location = New Point(0, Me.Size.Height - 15)
            Form1FlowLayoutPanel1.Location = New Point(0, 0)
            Form1FlowLayoutPanel1.Size = New Point(AppBarSize, Me.Size.Height - 75)
            Form1FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        ElseIf AppBarPosition = 3 Then
            SettingsPB.Location = New Point(12.5, Me.Size.Height - 62.5)
            ClosePB.Location = New Point(Me.Size.Width - 15, Me.Size.Height - 15)
            Form1FlowLayoutPanel1.Location = New Point(0, 0)
            Form1FlowLayoutPanel1.Size = New Point(AppBarSize, Me.Size.Height - 75)
            Form1FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        End If

    End Sub

    Private Sub Form1FlowLayoutPanel1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles Form1FlowLayoutPanel1.DragDrop

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = DirectCast(e.Data.GetData(DataFormats.FileDrop, False), String())
            For Each file As String In files
                Dim pb As New PictureBox With {
                    .Size = New Size(32, 32),
                    .Location = New Point(12 + (icons * 34), 12),
                    .Tag = file,
                    .Name = "pb" + PBNum.ToString,
                    .ContextMenuStrip = Cms2
                }
                Dim icon As Icon = Icon.ExtractAssociatedIcon(file)
                pb.Image = icon.ToBitmap
                pb.Cursor = Cursors.Hand
                AddHandler pb.DoubleClick, AddressOf PictureBox_DoubleClick
                AddHandler pb.Click, AddressOf Mouse_Click
                AddHandler pb.MouseDown, AddressOf PictureBox_MouseDown
                AddHandler pb.MouseUp, AddressOf PictureBox_MouseUp
                ToolTip1.SetToolTip(pb, file)
                PBNum = PBNum + 1
                pbtags.Add(file)
                Form1FlowLayoutPanel1.Controls.Add(pb)
                icons += 1
                Shortcuts.Add(file)
            Next
        End If

    End Sub

    Private Sub PictureBox_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)

        If File.Exists(DirectCast(sender, PictureBox).Tag.ToString) Then
            Try
                Process.Start(DirectCast(sender, PictureBox).Tag.ToString)
            Catch
                End
            End Try
        End If

    End Sub

    Private Sub Form1FlowLayoutPanel1_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles Form1FlowLayoutPanel1.DragOver

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub PictureBox_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)

        If e.Button = MouseButtons.Right Then
            RClick = 1
        End If

    End Sub

    Private Sub PictureBox_MouseUp(sender As Object, ByVal e As EventArgs)

        If RClick = 1 Then
            'DirectCast(sender, PictureBox).Dispose()
            RClick = 0

            'DeletedBox = DirectCast(sender, PictureBox).Tag.ToString
            DeletedBox = DirectCast(sender, PictureBox).Tag.ToString
            'DeletedBoxName = DirectCast(sender, PictureBox).Name.ToString
            DeletedBoxName = sender
            'RemoveShortcut(DirectCast(sender, PictureBox).Tag.ToString)
        End If

    End Sub

    Private Sub Mouse_Click(sender As Object, ByVal e As MouseEventArgs)

    End Sub

    Private Sub SettingsPB_Click(sender As Object, e As EventArgs) Handles SettingsPB.Click

        Settings.Visible = True

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        fBarRegistered = True
        RegisterBar()
        SaveSettings()

    End Sub

    Private Sub ClosePB_Click(sender As Object, e As EventArgs) Handles ClosePB.Click

        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of Form3).Any Then
            If Form3.Visible = True Then
                frmCollection.Item("Form3").Hide()
            Else
                frmCollection.Item("Form3").Show()
            End If

        Else
            ''Dim newForm2 = New Form2

            Form3.Show()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of Web).Any Then
            If Web.Visible = True Then
                frmCollection.Item("Web").Hide()
            Else
                frmCollection.Item("Web").Show()
            End If

        Else
            ''Dim newForm2 = New Form2

            Web.Show()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Labels.Click
        'Web2.Show()
    End Sub
End Class
