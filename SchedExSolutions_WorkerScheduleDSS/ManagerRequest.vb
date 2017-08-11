Public Class ManagerRequest
    'This form, which is never shown, will basically hold the datbase that will hold all info for the time.
    'I could not figure out a better way to store a database object which could be accessed and modified by all other forms without
    'worrying about it being reset by some form closing down.
    Public dataSet As New Database
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ManagersRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class