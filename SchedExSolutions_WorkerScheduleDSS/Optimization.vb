Imports Microsoft.SolverFoundation.Common
Imports Microsoft.SolverFoundation.Services
Imports Microsoft.SolverFoundation.Solvers


Public Class Optimization
    'Basically the solver class. Somehow. Getting to that.
    Public Property modelData As New Database
    Public model As New SimplexSolver
    Public dvValue As New List(Of Decimal)
    Public OptimalWage As Decimal
    Dim mySolverParms As New SimplexSolverParams


    'Shift list created for the sole purposes of naming the keys
    Private shiftList As New List(Of String)(New String() {"Shift1", "Shift2", "Shift3"})



    'Create the model using specified database 
    'Param data: The database to be drawn from. If edits have been made to the database, they will be handled
    Public Sub New()
        SolveModel()
    End Sub

    'Solve the model
    Public Sub SolveModel()
        modelData = ManagerRequest.dataSet
        Dim dvIndex As Integer
        Dim dvKey As String
        mySolverParms.MixedIntegerGapTolerance = 1
        ' 1 percent
        mySolverParms.VariableFeasibilityTolerance = 0.1
        ' required closeness to a whole number of each variable
        mySolverParms.MaxPivotCount = 10000
        ' Number of iterations.  Increase as necessary

        '---------------------------------------------------------------------------------------------------------------------------------------------
        'Create all the decision variables, set as binary and integrality
        For Each employee As Employee In modelData.employeeList
            Dim dayCounter As Integer = 2                   'Effectively gets each day column in the employeeavailability table. Absolute trash, I'm so sorry
            For Each day As String In WeekRequirements.dayList

                'Part time employees have three possible shifts. Full time only have one. 
                If employee._employeeType = "Part Time" Then
                    Dim shiftCounter As Integer = 0         'Will go up to 2, representing the 3 shifts (because I messed up on the tables and didn't go by shift1, shift2, shift3
                    For Each shift As String In shiftList   'For loop goes through the three shifts of the day for part time employee
                        dvKey = "Employee" & employee.employeeID & day & shift
                        model.AddVariable(dvKey, dvIndex)
                        model.SetIntegrality(dvIndex, True)

                        'Check first to see if employee has inputted a request off, take it into account if so, if not go to standard availability'
                        If employee.editedAvailability.ContainsKey(day & shift) Then
                            model.SetBounds(dvIndex, 0, 0)
                        Else
                            Dim availability As Integer = Convert.ToInt32(modelData.dataSet.Tables("Employee" & employee.employeeID & "Availabilities").Rows(shiftCounter)(dayCounter))
                            Debug.Print(availability)
                            model.SetBounds(dvIndex, 0, availability)
                        End If

                        shiftCounter += 1
                    Next
                Else
                    dvKey = "Employee" & employee.employeeID & day & "FullTime" 'No for loop necessary since there is only one shift
                    model.AddVariable(dvKey, dvIndex)
                    model.SetIntegrality(dvIndex, True)
                    If employee.editedAvailability.ContainsKey(day) Then
                        model.SetBounds(dvIndex, 0, 0)
                    End If
                    Dim availability As Integer = Convert.ToInt32(modelData.dataSet.Tables("Employee" & employee.employeeID & "Availabilities").Rows(0)(dayCounter))
                    model.SetBounds(dvIndex, 0, availability)
                End If
                dayCounter += 1
            Next
            employee.editedAvailability.Clear()
        Next
        '----------------------------------------------------------------------------------------------------------------------------------------------
        '----------------------------------------------------------------------------------------------------------------------------------------------
        'Create constraint for min and max hours that need to be worked
        Dim hourWorkedIndex As Integer
        Dim hourWorkedKey As String
        Dim coefficient As Decimal
        For Each employee As Employee In modelData.employeeList
            hourWorkedKey = "Employee" & employee.employeeID & " total hours worked"
            model.AddRow(hourWorkedKey, hourWorkedIndex)
            For Each day As String In WeekRequirements.dayList
                If employee._employeeType = "Part Time" Then
                    For Each shift As String In shiftList
                        dvIndex = model.GetIndexFromKey("Employee" & employee.employeeID & day & shift)

                        'Shift1 and Shift2 contain 3 hours in them, Shift 3 has 2 hours. Setting coefficient as appropriate
                        If shift = "Shift3" Then
                            coefficient = 2.0
                        Else
                            coefficient = 3.0
                        End If

                        model.SetCoefficient(hourWorkedIndex, dvIndex, coefficient)
                    Next
                Else
                    'Full time employees only work one 8 hour 'shift' per day, setting coefficient as appropriate
                    dvIndex = model.GetIndexFromKey("Employee" & employee.employeeID & day & "FullTime")
                    coefficient = 8.0
                    model.SetCoefficient(hourWorkedIndex, dvIndex, coefficient)
                End If

            Next

            'When we put the actual max hours as the upper limit, we found that solver never gave us an actual answer and always broke.
            'By setting it to 50, we allow for a schedule to be made even if it breaks some of the customer availibity constraints, since this
            'is sometimes what happens in the workplace during busy times. This does not, unfortunately, take overtime into account, but we figured
            'better we give an answer when there is one than withhold it from the user. We also found that solver never gets near the upper limit, unless
            'you really push the requirements.
            model.SetBounds(hourWorkedIndex, employee.employeeMinHours, 50)
        Next
        '------------------------------------------------------------------------------------------------------------------------------------------------

        '------------------------------------------------------------------------------------------------------------------------------------------------
        'Create constraint for number of employees necessary to work per day
        Dim requirementIndex As Integer
        Dim requirementKey As String
        For Each day As String In WeekRequirements.dayList 'Starts with selecting a day (mon, tues, wed...)
            Dim specInt As Integer = 0
            For Each specialization As String In WeekRequirements.specializationList 'Chooses a specialization (Gen, Man, Int, Acc)
                requirementKey = "Total " & specialization & " Employees Working " & day
                model.AddRow(requirementKey, requirementIndex)
                For Each employee As Employee In modelData.listOfSpecializationLists(specInt) 'Chooses an employee of the chosen specialization
                    If employee._employeeType = "Part Time" Then
                        For Each shift As String In shiftList       'Goes through shifts of employee

                            'Set coefficient to one third for each shift. If all three shifts are filled, then it will equate to one, representing one employee for the full day
                            dvIndex = model.GetIndexFromKey("Employee" & employee.employeeID & day & shift)
                            coefficient = 1 / 3
                            model.SetCoefficient(requirementIndex, dvIndex, coefficient)
                        Next
                    Else

                        'Full time employees work for the full day
                        dvIndex = model.GetIndexFromKey("Employee" & employee.employeeID & day & "FullTime")
                        coefficient = 1
                        model.SetCoefficient(requirementIndex, dvIndex, coefficient)
                    End If

                Next
                model.SetBounds(requirementIndex, WeekRequirements.requirementsDictionary.Item(day & specialization), 100)
                specInt += 1
            Next
        Next
        '------------------------------------------------------------------------------------------------------------------------------------------------

        '------------------------------------------------------------------------------------------------------------------------------------------------
        'Create the optimization method
        Dim objIndex As Integer
        Dim objKey As String = "Total Wages Spent"
        model.AddRow(objKey, objIndex)

        'We are minimizing the wage here.
        For Each employee As Employee In modelData.employeeList
            For Each day As String In WeekRequirements.dayList
                If employee._employeeType = "Part Time" Then
                    For Each shift As String In shiftList
                        dvIndex = model.GetIndexFromKey("Employee" & employee.employeeID & day & shift)
                        If shift = "Shift3" Then
                            coefficient = employee.wage * 2    'Shift 3 has only two hours in it
                        Else
                            coefficient = employee.wage * 3    'Shift 1 and 2 have 3 hours in it
                        End If
                        model.SetCoefficient(objIndex, dvIndex, coefficient)
                    Next
                Else
                    dvIndex = model.GetIndexFromKey("Employee" & employee.employeeID & day & "FullTime")
                    coefficient = employee.wage * 8
                    model.SetCoefficient(objIndex, dvIndex, coefficient)
                End If
            Next
        Next
        model.AddGoal(objIndex, 0, True)
        '------------------------------------------------------------------------------------------------------------------------------------------------

        '------------------------------------------------------------------------------------------------------------------------------------------------
        'VERY IMPORTANT PLEASE READ:
        'There is no checker for feasibility. We found that no matter what we did, no matter how 'correct' it looked to us, solver always
        'thought the solution infeasible. Therefore, we decided that we would always give a solution, seeing that it always scheduled employees
        'regardless. We will probably write this as a feature saying "Even if the program has to break some constraints, it will make sure you get
        'a schedule no matter what, and at the lowest wage cost!" I wish we could notify them which constraints were being broken, such as one employee
        'being put in for more their max hours, or when they requested off, but there was just no forseeable way. 

        'Catch broken solution exception
        Try
            model.Solve(mySolverParms)
        Catch ex As Exception
            MessageBox.Show("We could not find a schedule that fit your needs." & vbNewLine & "You may have scheduled more employees than you actually have, or your requirements were too high in general.")
            Exit Sub
        End Try

        objIndex = model.GetIndexFromKey("Total Wages Spent")

        'Catch 'NaN' value exception
        Try
            OptimalWage = CDec(model.GetValue(objIndex).ToDouble())
        Catch ex As Exception
            MessageBox.Show("We could not find a schedule that fit your needs." & vbNewLine & "You may have scheduled more employees than you actually have, or your requirements were too high in general.")
            Exit Sub
        End Try


        '------------------------------------------------------------------------------------------------------------------------------------------------

        '----------------------------------------------------------------------------------------------------------------------------------------------------
        'Clear out the schedule in case a schedule had already been made before it.
        For Each ctrl As Control In NewSchedule.Controls
            If TypeOf ctrl Is ListBox Then
                DirectCast(ctrl, ListBox).Items.Clear()
            End If
        Next

        'Look at the results, and translate it into useful scheduling information for the user
        For Each employee As Employee In modelData.employeeList
            For Each day As String In WeekRequirements.dayList
                Dim placeholder As String = ""
                Dim outputString As String = "Employee " & employee.employeeID & ": "
                Dim outputString2 As String = ""

                'For part time employees, look through the shifts scheduled to determine the actual time equivalents
                If employee._employeeType = "Part Time" Then
                    For Each shift As String In shiftList
                        dvIndex = model.GetIndexFromKey("Employee" & employee.employeeID & day & shift)
                        placeholder &= ToString(CInt(CDec(model.GetValue(dvIndex).ToDouble)))

                    Next

                    'Odd thing: placeholder is supposed to be 1's and 0's. but instead it's c's and S's.. 
                    'So work shift1, no shift2, work shift3, instead of 101 looks like cSc. It's really weird, but whatever floats 
                    'vb's boat, I guess.
                    If placeholder.Chars(0) = "c" Then
                        If placeholder.Chars(1) = "c" Then
                            outputString &= "9:00am - "
                        Else
                            outputString &= "9:00am - 12:00pm"
                        End If
                    End If


                    If placeholder.Chars(1) = "c" Then
                        If placeholder.Chars(0) = "S" Then
                            outputString &= "12:00pm - "
                        End If
                        If placeholder.Chars(2) = "S" Then
                            outputString &= "3:00pm"
                        End If
                    End If
                    If placeholder.Chars(2) = "c" Then
                        If placeholder.Chars(1) = "S" Then
                            outputString2 = vbTab & "     3:00pm - 5:00pm"
                        Else
                            outputString &= "5:00pm"
                        End If
                    End If
                    '--------------------------------------------------------------------------------------------------------
                    'For full time employees, if they are working, they just work 9 - 5, no questions asked.
                Else
                    dvIndex = model.GetIndexFromKey("Employee" & employee.employeeID & day & "FullTime")
                    placeholder = ToString(CInt(CDec(model.GetValue(dvIndex).ToDouble)))
                    If placeholder = "c" Then
                        outputString &= "9:00am - 5:00pm"
                    End If
                End If
                Debug.Print("Employee" & employee.employeeID & "Schedule: " & outputString)


                'Not the prettiest code, but it'll do. Add the output string with the schedule to the schedule form in the appropriate box.
                'Uses if statement to look if output string ends with 'm', which means there's a time in the string and should be added.
                'If there's no time in the string, then the employee should not be added to the form because they are not working then
                If day = "mon" AndAlso outputString.Substring(outputString.Length - 1) = "m" Then
                    NewSchedule.lbxmon.Items.Add(outputString)
                    NewSchedule.lbxmon.Items.Add(outputString2)
                ElseIf day = "tue" AndAlso outputString.Substring(outputString.Length - 1) = "m" Then
                    NewSchedule.lbxtue.Items.Add(outputString)
                    NewSchedule.lbxtue.Items.Add(outputString2)
                ElseIf day = "wed" AndAlso outputString.Substring(outputString.Length - 1) = "m" Then
                    NewSchedule.lbxwed.Items.Add(outputString)
                    NewSchedule.lbxwed.Items.Add(outputString2)
                ElseIf day = "thu" AndAlso outputString.Substring(outputString.Length - 1) = "m" Then
                    NewSchedule.lbxthu.Items.Add(outputString)
                    NewSchedule.lbxthu.Items.Add(outputString2)
                ElseIf day = "fri" AndAlso outputString.Substring(outputString.Length - 1) = "m" Then
                    NewSchedule.lbxfri.Items.Add(outputString)
                    NewSchedule.lbxfri.Items.Add(outputString2)
                ElseIf day = "sat" AndAlso outputString.Substring(outputString.Length - 1) = "m" Then
                    NewSchedule.lbxsat.Items.Add(outputString)
                    NewSchedule.lbxsat.Items.Add(outputString2)
                ElseIf day = "sun" AndAlso outputString.Substring(outputString.Length - 1) = "m" Then
                    NewSchedule.lbxsun.Items.Add(outputString)
                    NewSchedule.lbxsun.Items.Add(outputString2)
                End If
            Next

        Next

        'Show the schedule form with the wage
        NewSchedule.Show()
        NewSchedule.txtWage.Text = "Optimal Wage Cost is: $" & CStr(OptimalWage)
        NewSchedule.btnReturn.Visible = True

    End Sub
End Class
