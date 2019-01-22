Imports System.IO
Imports System.Runtime.InteropServices

Public Class AppBar3000
    Public MonNum As Integer
    Public AppBarPosition As Integer
    Public AppBarSize As Integer

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
        ABE_LEFT = 0
        ABE_TOP = 1
        ABE_RIGHT = 2
        ABE_BOTTOM = 3
    End Enum

    Private fBarRegistered As Boolean = False

    Private Declare Function SHAppBarMessage Lib "shell32.dll" Alias "SHAppBarMessage" _
    (ByVal dwMessage As Integer, <MarshalAs(UnmanagedType.Struct)> ByRef pData As _
    APPBARDATA) As IntPtr

    Private Declare Function GetSystemMetrics Lib "user32" Alias "GetSystemMetrics" _
    (ByVal nIndex As Integer) As Integer

    Private Declare Function MoveWindow Lib "user32" Alias "MoveWindow" (ByVal hwnd As Integer,
    ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer,
    ByVal bRepaint As Integer) As Integer

    Private Declare Function RegisterWindowMessage Lib "user32" Alias "RegisterWindowMessageA" _
    (ByVal lpString As String) As Integer

    Private uCallBack As Integer

    Dim icons As Integer = 0

    Private Sub Form1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = DirectCast(e.Data.GetData(DataFormats.FileDrop, False), String())
            For Each file As String In files
                Dim pb As New PictureBox With {
                    .Size = New Size(32, 32),
                    .Location = New Point(12 + (icons * 44), 12),
                    .Tag = file
                }
                Dim icon As Icon = Icon.ExtractAssociatedIcon(file)
                pb.Image = icon.ToBitmap
                pb.Cursor = Cursors.Hand
                AddHandler pb.DoubleClick, AddressOf PictureBox1_DoubleClick
                ToolTip1.SetToolTip(pb, file)
                Me.Controls.Add(pb)
                icons += 1
            Next
        End If
    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        Process.Start(DirectCast(sender, PictureBox).Tag.ToString)
    End Sub

    Private Sub Form1_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles Me.DragOver
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        RegisterBar()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CheckSettings()
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        AppBarPosition = My.Settings.AppBarPosition
        RegisterBar()
        Me.Invalidate()
    End Sub

    Public Sub SaveSettings()
        My.Settings.AppBarPosition = AppBarPosition
        My.Settings.MonNum = MonNum
        My.Settings.AppBarSize = AppBarSize
        My.Settings.Save()
    End Sub

    Public Sub CheckSettings()
        Dim directory As String = AppDomain.CurrentDomain.BaseDirectory + "AppBar3000_exe.config"
        If File.Exists(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile) Then
            LoadSettings()
            MsgBox(directory)
        Else
            AppBarPosition = 0
            MonNum = 0
            AppBarSize = 75
            My.Computer.FileSystem.CopyFile(My.Resources.AppBar3000_exe, directory)
            My.Settings.AppBarPosition = 0
            My.Settings.MonNum = 0
            My.Settings.AppBarSize = 75
            My.Settings.Save()
            LoadSettings()
        End If
    End Sub

    Public Sub LoadSettings()
        AppBarPosition = My.Settings.AppBarPosition
        MonNum = My.Settings.MonNum
        AppBarSize = My.Settings.AppBarSize
    End Sub

    Private Sub RegisterBar()
        Dim abd As New APPBARDATA
        abd.cbSize = Marshal.SizeOf(abd)
        abd.hWnd = Me.Handle
        If Not fBarRegistered Then
            uCallBack = RegisterWindowMessage("AppBarMessage")
            abd.uCallbackMessage = uCallBack

            Dim ret As Integer = SHAppBarMessage(CType(ABMsg.ABM_NEW, Integer), abd)
            fBarRegistered = True

            ABSetPos()
        Else
            SHAppBarMessage(CType(ABMsg.ABM_REMOVE, Integer), abd)
            fBarRegistered = False
        End If
    End Sub

    Public Sub ABSetPos()

        Dim abd As New APPBARDATA()
        abd.cbSize = Marshal.SizeOf(abd)
        abd.hWnd = Me.Handle

        If AppBarPosition = 0 Then
            'Me.AutoScaleBaseSize = New Size(5, 13)
            'Me.ClientSize = New Size(75, 75)
            abd.uEdge = CInt(ABEdge.ABE_TOP)
            SettingsPB.Location = New Point(Screen.AllScreens(MonNum).WorkingArea.Width - 62.5, 12.5)
        ElseIf AppBarPosition = 1 Then
            'Me.AutoScaleBaseSize = New Size(5, 13)
            'Me.ClientSize = New Size(75, 75)
            abd.uEdge = CInt(ABEdge.ABE_BOTTOM)
            SettingsPB.Location = New Point(Screen.AllScreens(MonNum).WorkingArea.Width - 62.5, 12.5)
        ElseIf AppBarPosition = 2 Then
            'Me.AutoScaleBaseSize = New Size(5, 13)
            'Me.ClientSize = New Size(75, 75)
            abd.uEdge = CInt(ABEdge.ABE_LEFT)
            SettingsPB.Location = New Point(12.5, Screen.AllScreens(MonNum).WorkingArea.Height - 62.5)
        ElseIf AppBarPosition = 3 Then
            'Me.AutoScaleBaseSize = New Size(5, 13)
            'Me.ClientSize = New Size(75, 75)
            abd.uEdge = CInt(ABEdge.ABE_RIGHT)
            SettingsPB.Location = New Point(12.5, Screen.AllScreens(MonNum).WorkingArea.Height - 62.5)
        End If

        If abd.uEdge = CInt(ABEdge.ABE_LEFT) OrElse abd.uEdge = CInt(ABEdge.ABE_RIGHT) Then
            abd.rc.top = 0
            abd.rc.bottom = SystemInformation.PrimaryMonitorSize.Height
            If abd.uEdge = CInt(ABEdge.ABE_LEFT) Then
                abd.rc.left = 0
                abd.rc.right = AppBarSize
            Else
                abd.rc.right = SystemInformation.PrimaryMonitorSize.Width
                abd.rc.left = abd.rc.right - AppBarSize
            End If
        Else
            abd.rc.left = 0
            abd.rc.right = SystemInformation.PrimaryMonitorSize.Width
            If abd.uEdge = CInt(ABEdge.ABE_TOP) Then
                abd.rc.top = 0
                abd.rc.bottom = AppBarSize
            Else
                abd.rc.bottom = SystemInformation.PrimaryMonitorSize.Height
                abd.rc.top = abd.rc.bottom - AppBarSize
            End If
        End If

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
    End Sub

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

    Protected Overloads Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style And (Not 12582912)
            ' WS_CAPTION
            cp.Style = cp.Style And (Not 8388608)
            ' WS_BORDER
            cp.ExStyle = 128 Or 8
            ' WS_EX_TOOLWINDOW | WS_EX_TOPMOST
            Return cp
        End Get
    End Property

    Private Sub Form1_Doubleclick() Handles MyBase.DoubleClick
        Dim abd As New APPBARDATA
        fBarRegistered = True
        RegisterBar()
        Me.Close()
    End Sub

    Private Sub SettingsPB_Click(sender As Object, e As EventArgs) Handles SettingsPB.Click
        Settings.Visible = True
    End Sub
End Class