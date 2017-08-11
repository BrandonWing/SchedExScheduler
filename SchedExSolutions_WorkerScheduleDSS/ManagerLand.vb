Public Class ManagerLand
    Private Sub btnSetSched_Click(sender As Object, e As EventArgs) Handles btnSetSched.Click
        WeekRequirements.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Close out weeklyworkrequirements form if it was still opened, so an employee can't touch it, then close current form
        frmWelcomePage.Show()
        WeekRequirements.Close()
        Me.Close()
    End Sub

    Private Sub btnManSched_Click(sender As Object, e As EventArgs) Handles btnManSched.Click

        'Checks first to see if a schedule has been created before it shows the schedule.
        If NewSchedule.lbxmon.Items.Count = 0 Then
            MessageBox.Show("No schedule has been made yet!")
        Else
            NewSchedule.Show()
        End If
    End Sub

    Private Sub ManagerLandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class