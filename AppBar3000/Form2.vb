' Mon1 = 0, 1, 2, 3
' 0 = Top, 1 = Bottom, 2 = Left, 3 = Right
' Mon2 = 4, 5, 6, 7
' 4 = Top, 5 = Bottom, 6 = Left, 7 = Right
' Mon3 = 8, 9, 10, 11
' 8 = Top, 9 = Bottom, 10 = Left, 11 = Right


Imports System.Text.RegularExpressions

Public Class Settings

    Private Sub SettingsButtonOK_Click(sender As Object, e As EventArgs) Handles SettingsButtonOK.Click
        Me.Visible = False

        If AppBarPositionCB.SelectedIndex = 0 Then
            AppBar3000.AppBarPosition = 0
            AppBar3000.DisNum = 1
        ElseIf AppBarPositionCB.SelectedIndex = 1 Then
            AppBar3000.AppBarPosition = 1
            AppBar3000.DisNum = 1
        ElseIf AppBarPositionCB.SelectedIndex = 2 Then
            AppBar3000.AppBarPosition = 2
            AppBar3000.DisNum = 1
        ElseIf AppBarPositionCB.SelectedIndex = 3 Then
            AppBar3000.AppBarPosition = 3
            AppBar3000.DisNum = 1
        ElseIf AppBarPositionCB.SelectedIndex = 4 Then
            AppBar3000.AppBarPosition = 0
            AppBar3000.DisNum = 2
        ElseIf AppBarPositionCB.SelectedIndex = 5 Then
            AppBar3000.AppBarPosition = 1
            AppBar3000.DisNum = 2
        ElseIf AppBarPositionCB.SelectedIndex = 6 Then
            AppBar3000.AppBarPosition = 2
            AppBar3000.DisNum = 2
        ElseIf AppBarPositionCB.SelectedIndex = 7 Then
            AppBar3000.AppBarPosition = 3
            AppBar3000.DisNum = 2
        ElseIf AppBarPositionCB.SelectedIndex = 8 Then
            AppBar3000.AppBarPosition = 0
            AppBar3000.DisNum = 3
        ElseIf AppBarPositionCB.SelectedIndex = 9 Then
            AppBar3000.AppBarPosition = 1
            AppBar3000.DisNum = 3
        ElseIf AppBarPositionCB.SelectedIndex = 10 Then
            AppBar3000.AppBarPosition = 2
            AppBar3000.DisNum = 3
        ElseIf AppBarPositionCB.SelectedIndex = 11 Then
            AppBar3000.AppBarPosition = 3
            AppBar3000.DisNum = 3
        End If

        If AppBarSizeTB.Text = "" Then
            AppBarSizeTB.Text = "75"
        Else
            AppBar3000.AppBarSize = AppBarSizeTB.Text
        End If

        AppBar3000.ABSetPos()
    End Sub

    Private Sub AppBarSizeTB_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles AppBarSizeTB.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub AppBarSizeTB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AppBarSizeTB.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        AppBarSizeTB.Text = digitsOnly.Replace(AppBarSizeTB.Text, "")
    End Sub

    Private Sub AppBarSizeTB_MouseMoved(ByVal sender As Object, ByVal e As System.EventArgs) Handles AppBarSizeTB.MouseMove
        ToolTip2.SetToolTip(AppBarSizeTB, "Please Enter Numbers Only")
    End Sub

    Private Sub AppBarPositionCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AppBarPositionCB.SelectedIndexChanged
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AppBarSizeTB.Visible = False
        Label2.Visible = False
        If Screen.AllScreens().Length = 1 Then
            AppBarPositionCB.Items.Add("Top")
            AppBarPositionCB.Items.Add("Bottom")
            AppBarPositionCB.Items.Add("Left")
            AppBarPositionCB.Items.Add("Right")
        Else
            If Screen.AllScreens().Length = 2 Then
                'Mon1:
                AppBarPositionCB.Items.Add("Mon1: Top")
                AppBarPositionCB.Items.Add("Mon1: Bottom")
                AppBarPositionCB.Items.Add("Mon1: Left")
                AppBarPositionCB.Items.Add("Mon1: Right")
                'Mon2:
                AppBarPositionCB.Items.Add("Mon2: Top")
                AppBarPositionCB.Items.Add("Mon2: Bottom")
                AppBarPositionCB.Items.Add("Mon2: Left")
                AppBarPositionCB.Items.Add("Mon2: Right")
            End If
            If Screen.AllScreens().Length = 3 Then
                'Mon1:
                AppBarPositionCB.Items.Add("Mon1: Top")
                AppBarPositionCB.Items.Add("Mon1: Bottom")
                AppBarPositionCB.Items.Add("Mon1: Left")
                AppBarPositionCB.Items.Add("Mon1: Right")
                'Mon2:
                AppBarPositionCB.Items.Add("Mon2: Top")
                AppBarPositionCB.Items.Add("Mon2: Bottom")
                AppBarPositionCB.Items.Add("Mon2: Left")
                AppBarPositionCB.Items.Add("Mon2: Right")
                'Mon3:
                AppBarPositionCB.Items.Add("Mon3: Top")
                AppBarPositionCB.Items.Add("Mon3: Bottom")
                AppBarPositionCB.Items.Add("Mon3: Left")
                AppBarPositionCB.Items.Add("Mon3: Right")
            End If
        End If
        'Set Default to Current App Bar Position
        AppBarPositionCB.SelectedIndex = AppBar3000.AppBarPosition

    End Sub
End Class