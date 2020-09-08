Imports CefSharp
Imports CefSharp.WinForms

Public Class Web
    Public browser As ChromiumWebBrowser
    Private Sub Web_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = Screen.AllScreens(AppBar3000.MonNum).WorkingArea.Width - 50
        'Me.Width = My.Computer.Screen.WorkingArea.Width - 50
        Me.Location = New Point((AppBar3000.Width \ 2) - (Me.Width \ 2), AppBar3000.Top + AppBar3000.Height)

    End Sub

    Sub New()

    InitializeComponent()
    InitBrowser()
End Sub
Public Sub InitBrowser()
    CefSharp.Cef.Initialize(New CefSettings())
        browser = New ChromiumWebBrowser(My.Settings.Webaddress)
        Me.Controls.Add(browser)
    browser.Dock = DockStyle.Fill
        'AddHandler browser.LoadingStateChanged, AddressOf browser_LoadingStateChanged
    End Sub

Private Sub browser_LoadingStateChanged(ByVal sender As Object, ByVal e As LoadingStateChangedEventArgs)
    If e.IsLoading = False Then
        browser.ExecuteScriptAsync("alert('All Resources Have Loaded');")
    End If
End Sub

End Class