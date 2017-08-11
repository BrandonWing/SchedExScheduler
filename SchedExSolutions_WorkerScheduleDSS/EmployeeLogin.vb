Public Class frmEmployeeLogin
    Private Sub frmEmployeeLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Check login credentials. Open Up employeelanding page with correct employee loaded in 
    Private Sub btnEmployeeSubmit_Click(sender As Object, e As EventArgs) Handles btnEmployeeSubmit.Click
        Dim userName As String = Me.Controls("txtEmployeeUsername").Text
        Dim password As String = Me.Controls("txtEmployeePassword").Text
        Dim database As New Database
        Dim loginTable As DataTable = database.dataSet.Tables("EmployeeLoginCreds")


        'End Sub if username or password is not inputted.
        If userName = "" Or password = "" Then
            MessageBox.Show("Please input BOTH your username and Password.")
            Exit Sub
        End If

        'Search through login table for username and password, open employee landing page if found and close this form
        For row As Integer = 0 To loginTable.Rows.Count - 1
            If loginTable.Rows(row)("Username") = userName Then
                If loginTable.Rows(row)("Password") = password Then

                    'Employees are in order on table as they are in list, use current row to get list index
                    Dim selectedEmployee As Employee = database.employeeList(row)
                    selectedEmployee.name = loginTable.Rows(row)("Employee Name")
                    EmployeeLand.currentEmployee = selectedEmployee
                    EmployeeLand.Show()
                    Me.Close()
                    Exit Sub
                End If
            End If
        Next

        'Sends back incorrect username/password message and allows user to try again indefinitely.
        MessageBox.Show("Username or Password was incorrect. Please try again.")
        Me.Controls("txtEmployeePassword").Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmWelcomePage.Show()
        Me.Close()
    End Sub
End Class