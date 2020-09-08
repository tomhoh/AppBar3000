Public Class AdvancedSettings
    Private Sub PropertyGrid1_Click(sender As Object, e As EventArgs) Handles PropertyGrid1.Click

    End Sub

    Private Sub AdvancedSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PropertyGrid1.SelectedObject = My.Settings
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Save()
    End Sub
End Class