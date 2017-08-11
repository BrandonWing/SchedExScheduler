Public Class frmManagerLogin
    Private Sub frmManagerLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnManagerSubmit_Click(sender As Object, e As EventArgs) Handles btnManagerSubmit.Click
        'Exit sub if username or password has not been input
        If Me.Controls("txtManagerUsername").Text = "" Or Me.Controls("txtManagerPassword").Text = "" Then
            MessageBox.Show("Please input both a username and password")
            Exit Sub
        End If

        'Open manager landing page if username and password are correct
        If Me.Controls("txtManagerUsername").Text = "admin" And Me.Controls("txtManagerPassword").Text = "admin" Then
            ManagerLand.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtManagerPassword_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmWelcomePage.Show()
        Me.Close()
    End Sub
End Class
