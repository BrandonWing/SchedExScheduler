Public Class EmployeeLand
    Property currentEmployee As New Employee
    Property test As Integer
    Private Sub EmployeeLandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls("lblWelcomeEm").Text = "Welcome " & currentEmployee.name
    End Sub



    Private Sub btnTimeOff_Click(sender As Object, e As EventArgs) Handles btnTimeOff.Click

        'Open up the request off form
        EmployeeAvail.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Shut down the request off form if still opened, close down current form and bring back to welcome screen
        frmWelcomePage.Show()
        EmployeeAvail.Close()
        Me.Close()
    End Sub

    Private Sub btnEmSched_Click(sender As Object, e As EventArgs) Handles btnEmSched.Click

        'Display schedule to employee if it has been made
        If NewSchedule.lbxmon.Items.Count = 0 Then
            MessageBox.Show("No schedule has been made yet!")
        Else
            NewSchedule.btnReturn.Visible = False
            NewSchedule.Show()
        End If
    End Sub
End Class
