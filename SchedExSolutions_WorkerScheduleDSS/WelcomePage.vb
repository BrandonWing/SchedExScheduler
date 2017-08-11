Public Class frmWelcomePage
    Public Property dataSet As New Database
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnEmployeeLogin_Click(sender As Object, e As EventArgs) Handles btnEmployeeLogin.Click
        'Open up the employee login form
        frmEmployeeLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnManagerLogin_Click(sender As Object, e As EventArgs) Handles btnManagerLogin.Click
        'Open up the manager login form
        frmManagerLogin.Show()
        Me.Hide()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Shut down the program
        End

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Open up the help form
        HelpForm.Show()
    End Sub
End Class
