﻿' Mon1 = 0, 1, 2, 3
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
            AppBarSizeTB.Text = "40"
        Else
            AppBar3000.AppBarSize = AppBarSizeTB.Text
        End If
        AppBar3000.SetTransparency()
        AppBar3000.SaveSettings()
        AppBar3000.ABSetPos()
    End Sub

    Private Sub AppBarPositionCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AppBarPositionCB.SelectedIndexChanged
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AppBarSizeTB.Visible = True
        Label2.Visible = True
        If AppBar3000.TBar = 0 Then
            CTrancparency.Checked() = False
            R90.Enabled = False
            R80.Enabled = False
            R70.Enabled = False
        Else
            CTrancparency.Checked() = True
            R90.Enabled = True
            R80.Enabled = True
            R70.Enabled = True
        End If

        If AppBar3000.TBarValue = 0.9 Then
            R90.Checked = True
            R80.Checked = False
            R70.Checked = False
        ElseIf AppBar3000.TBarValue = 0.8 Then
            R90.Checked = False
            R80.Checked = True
            R70.Checked = False
        ElseIf AppBar3000.TBarValue = 0.7 Then
            R90.Checked = False
            R80.Checked = False
            R70.Checked = True
        End If

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

    Private Sub CTrancparency_CheckedChanged(sender As Object, e As EventArgs) Handles CTrancparency.CheckedChanged

        If CTrancparency.Checked() = True Then
            R90.Enabled = True
            R80.Enabled = True
            R70.Enabled = True
            AppBar3000.TBar = 1
        ElseIf CTrancparency.Checked() = False Then
            R90.Enabled = False
            R80.Enabled = False
            R70.Enabled = False
            AppBar3000.TBar = 0
        End If

    End Sub

    Private Sub R90_CheckedChanged(sender As Object, e As EventArgs) Handles R90.CheckedChanged

        If R90.Checked = True Then
            AppBar3000.TBarValue = 0.9
            R80.Checked = False
            R70.Checked = False
        End If

    End Sub

    Private Sub R80_CheckedChanged(sender As Object, e As EventArgs) Handles R80.CheckedChanged

        If R80.Checked = True Then
            AppBar3000.TBarValue = 0.7
            R90.Checked = False
            R70.Checked = False
        End If

    End Sub

    Private Sub R70_CheckedChanged(sender As Object, e As EventArgs) Handles R70.CheckedChanged

        If R70.Checked = True Then
            AppBar3000.TBarValue = 0.3
            R90.Checked = False
            R80.Checked = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdvancedSettings.Show()
    End Sub

    Private Sub SettingsCancelButton_Click(sender As Object, e As EventArgs) Handles SettingsCancelButton.Click
        Me.Close()
    End Sub
End Class