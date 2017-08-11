Public Class Employee
    Public Property employeeID As String
    Public Property employeeMaxHours As Integer
    Public Property employeeMinHours As Integer
    Public Property specialization As String
    Public Property wage As Decimal
    Public Property name As String

    'Will hold whether or not an employee is asking for off and when
    Public Property editedAvailability As New Dictionary(Of String, Integer)

    'Full time or part time
    Property _employeeType As String




    Public Sub New()

    End Sub

End Class
