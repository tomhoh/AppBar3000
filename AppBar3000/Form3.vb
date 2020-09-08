Option Strict On
' uncomment to load exe inside form
'Imports System.Runtime.InteropServices
Public Class Form3
    ' uncomment to load exe inside form
    'Private Const WM_SYSCOMMAND As Integer = &H112
    'Private Const SC_MINIMIZE As Integer = &HF020
    'Private Const SC_MAXIMIZE As Integer = &HF030
    '<Runtime.InteropServices.DllImport("user32.dll")>
    'Public Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    'End Function

    '<Runtime.InteropServices.DllImport("user32.dll")>
    'Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    ' End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.CenterToParent()
        Me.Location = New Point((AppBar3000.Width \ 2) - (Me.Width \ 2), AppBar3000.Top + AppBar3000.Height)

        'uncomment below to start program inside panel on form
        'Dim Thread As System.Threading.Thread
        'Dim proc As Process
        'Try

        '    proc = Process.Start("Calc.exe")
        '    proc.WaitForInputIdle()
        '    System.Threading.Thread.Sleep(1000)
        '    ' SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
        '    SetParent(proc.MainWindowHandle, Me.Panel1.Handle)
        '    System.Threading.Thread.Sleep(1000)
        '    SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)

        'Catch ex As InvalidOperationException

        '    ' purposely do nothing here - the process exited before we told it to.

        'End Try

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class