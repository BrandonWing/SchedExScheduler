Public Class NewSchedule
    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close down the weeklyworkrequirements if it is still up, close current form.
        WeekRequirements.Hide()
        Me.Hide()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Show the weeklyworkrequirements so that schedule can be changed
        WeekRequirements.Show()
        Me.Hide()
    End Sub

    Private Sub NewSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class