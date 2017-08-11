'Our database class will hold all of our tables and objects.
Imports System.Data.OleDb

Public Class Database

    Public dataSet As New DataSet
    Dim SQLString As String
    Dim empConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SchedexRevised.accdb"
    Dim loginConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SchedexLogin.accdb"
    Dim dataAdapter As OleDbDataAdapter
    Dim tableName As String
    Public employeeList As New List(Of Employee)

    'Created four lists for the four different types of employees
    Public generalEmployeeList As New List(Of Employee)
    Public accountingEmployeeList As New List(Of Employee)
    Public managerEmployeeList As New List(Of Employee)
    Public internetEmployeeList As New List(Of Employee)

    'create a list that will hold all specializatoin lists
    Public listOfSpecializationLists As New List(Of List(Of Employee))


    Private tableNameList As New List(Of String)

    'Fills the datasets for each table in our access database
    Public Sub New()
        createTableNameList()
        For Each tabName As String In tableNameList
            fillDataSet(tabName)
        Next
        createEmployees()
        fillListOfLists()
    End Sub


    '---------------------------------------------------------------------------------------------------------
    'Get all the names of the tables and put into a list of strings. Created so that any additional tables added
    'later on would be instantly accomadated into the code.
    Public Sub createTableNameList()

        Dim Tables As DataTable = Nothing
        Dim connection As System.Data.OleDb.OleDbConnection = New System.Data.OleDb.OleDbConnection()
        connection.ConnectionString = empConnectionString
        connection.Open()

        'Get list of tables
        Tables = connection.GetSchema("Tables")
        connection.Close()

        'Add list of table names to a list
        Dim i As Integer
        For i = 0 To Tables.Rows.Count - 1 Step i + 1
            Dim tempName As String = Tables.Rows(i).ItemArray(2)
            If tempName.Substring(0, 2) <> "MS" Then
                tableNameList.Add(tempName)
            End If
        Next

        'Add login table as extra, since it comes from a different connection
        tableNameList.Add("EmployeeLoginCreds")
    End Sub


    'Filling dataSet up with different tables where necessary
    Public Sub fillDataSet(tableName)
        SQLString = "SELECT * FROM " & tableName

        'If table is not login table, use empConnectionString, else use loginConnectionString
        If tableName <> "EmployeeLoginCreds" Then
            dataAdapter = New OleDbDataAdapter(SQLString, empConnectionString)
        Else
            dataAdapter = New OleDbDataAdapter(SQLString, loginConnectionString)
        End If
        dataAdapter.Fill(dataSet, tableName)
    End Sub

    Public Sub createEmployees()
        'Set up all employees using EmployeeSetWages table
        For tableRow As Integer = 0 To dataSet.Tables("EmployeeInfo").Rows.Count - 1
            Dim employeeObject As New Employee

            'Put in all basic employee info
            employeeObject.employeeID = dataSet.Tables("EmployeeInfo").Rows(tableRow)("ID")
            employeeObject.specialization = dataSet.Tables("EmployeeInfo").Rows(tableRow)("Specification")
            employeeObject.wage = dataSet.Tables("EmployeeInfo").Rows(tableRow)("Wage")
            employeeObject.employeeMaxHours = dataSet.Tables("EmployeeInfo").Rows(tableRow)("Max Hours to Work")
            employeeObject.employeeMinHours = dataSet.Tables("EmployeeInfo").Rows(tableRow)("Min Hours to Work")

            'Forgot to add a Full Time/Part Time section to the table
            'If statement will check if employee as 40 hours min max required hours, then set based on result
            If employeeObject.employeeMinHours = 40 Then
                employeeObject._employeeType = "Full Time"
            Else
                employeeObject._employeeType = "Part Time"
            End If

            'Add employee to specialization list depending on their attribute, then add to employeeList
            If employeeObject.specialization = "General" Then
                generalEmployeeList.Add(employeeObject)
            ElseIf employeeObject.specialization = "Internet" Then
                internetEmployeeList.Add(employeeObject)
            ElseIf employeeObject.specialization = "Accounting" Then
                accountingEmployeeList.Add(employeeObject)
            Else
                managerEmployeeList.Add(employeeObject)
            End If
            employeeList.Add(employeeObject)

        Next

    End Sub

    'Adds all lists into one giant list in same order as weeklyworkrequirements.specializationList
    Public Sub fillListOfLists()
        listOfSpecializationLists.Add(generalEmployeeList)
        listOfSpecializationLists.Add(managerEmployeeList)
        listOfSpecializationLists.Add(internetEmployeeList)
        listOfSpecializationLists.Add(accountingEmployeeList)
    End Sub


End Class
