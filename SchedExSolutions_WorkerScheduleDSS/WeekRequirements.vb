Public Class WeekRequirements
    Public dayList As New List(Of String)(New String() {"mon", "tue", "wed", "thu", "fri", "sat", "sun"})
    Public specializationList As New List(Of String)(New String() {"Gen", "Man", "Int", "Acc"})
    Public requirementsDictionary As New Dictionary(Of String, Integer)

    Private Sub WeeklyWorkRequirements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adds key and values to dictionary object. Ex: ["monGen", 2] for 2 general employees on monday

    End Sub

    'Store required workers for each day using dictionary
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        requirementsDictionary.Clear()
        'Checks to make sure that all inputs have been filled in, exits sub if not.
        For Each control In Me.Controls
            If TypeOf control Is TextBox Then
                If control.Text = "" Then
                    MessageBox.Show("Please input a number into every text box. If no employees are required, input 0.")
                    Exit Sub
                End If

                'Checks to make sure only number values have been put into program
                Try
                    Convert.ToInt32(control.Text)
                Catch ex As Exception
                    MessageBox.Show("Please input an actual number into every textbox. If no employees are required, input 0.")
                    Exit Sub
                End Try
                'Makes sure user doesn't overload system with high requirements
                If Convert.ToInt32(control.Text) > 5 Then
                    MessageBox.Show("Please input a number less than or equal to five.")
                End If
            End If
        Next
        'Creates a dictionary object to hold the requirements, ordered by day and specialization
        For Each day In dayList
            For Each specialization In specializationList
                requirementsDictionary.Add(day & specialization, Me.Controls(day & specialization).Text)
            Next
        Next



        Dim result As New Optimization()
    End Sub

    Private Sub friGen_TextChanged(sender As Object, e As EventArgs) Handles friGen.TextChanged

    End Sub

    Private Sub thuGen_TextChanged(sender As Object, e As EventArgs) Handles thuGen.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ManagerLand.Show()
        Me.Close()
    End Sub
End Class