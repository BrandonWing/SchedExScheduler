Public Class EmployeeAvail
    Private Sub EmployeeAvailability_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles monShift1.CheckedChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ctrl As Control
        Dim checkCount As Int16 = 0

        'Goes through all checkboxes to see if user has checked off any shifts they do not wish to work
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                'Set availability of an employee to be used later
                If EmployeeLand.currentEmployee._employeeType = "Full Time" And Not EmployeeLand.currentEmployee.editedAvailability.ContainsKey(ctrl.Name.Substring(0, 3)) Then
                    EmployeeLand.currentEmployee.editedAvailability.Add(ctrl.Name.Substring(0, 3), 0)
                Else
                    EmployeeLand.currentEmployee.editedAvailability.Add(ctrl.Name, 0)
                End If
                checkCount += 1
            End If

        Next

        'Updates the database with the new availability. If no checkboxes were cheked, throw an error
        If checkCount <> 0 Then
            'Set the main database version of this employee equal to the currently modified one
            ManagerRequest.dataSet.employeeList(Convert.ToInt32(EmployeeLand.currentEmployee.employeeID) - 1) = EmployeeLand.currentEmployee
            MessageBox.Show("Request saved and awaiting processing!")
            EmployeeLand.Show()
            Me.Close()
        Else
            'Informs user that they did not check any boxes off
            MessageBox.Show("Please check at least one shift!")
            Exit Sub
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EmployeeLand.Show()
        Me.Close()
    End Sub
End Class