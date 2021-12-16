Public Class login
    Public loggedInUser As String = ""
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x = MsgBox("Are you sure you want to close this Application ?", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 
        If usernametxt.Text = "" Or passwordtxt.Text = "" Then
            MsgBox("Please enter both Username and Password", MsgBoxStyle.Information)
        Else
            Dim username As String = usernametxt.Text
            Dim password As String = passwordtxt.Text
            If username = My.Settings.username And password = My.Settings.password Then
                Adminpage.Show()
                Me.Hide()
            Else
                If specializationcmb.SelectedItem = "Doctor" Then
                    If checkvalidate(username, password, "Doctor") = True Then
                        loggedInUser = username
                        doctor_dashboard.Show()
                    Else
                        MsgBox("No Doctor with Employee_ID : " & username & "or you entered incorrect Password", MsgBoxStyle.Critical)
                    End If
                ElseIf specializationcmb.SelectedItem = "Nurse" Then
                    If checkvalidate(username, password, "Nurse") = True Then
                        loggedInUser = username
                        nurse_dashboard.Show()
                    Else
                        MsgBox("No Nurse with Employee_ID : " & username & "or you entered incorrect Password", MsgBoxStyle.Critical)
                    End If
                ElseIf specializationcmb.SelectedItem = "Lab_Officer" Then
                    If checkvalidate(username, password, "Lab_Officer") = True Then
                        loggedInUser = username
                        lab_officer_dashboard.Show()
                    Else
                        MsgBox("No Lab_Officer with Employee_ID : " & username & "or you entered incorrect Password", MsgBoxStyle.Critical)
                    End If
                ElseIf specializationcmb.SelectedItem = "Pharmacist" Then
                    If checkvalidate(username, password, "Pharmacist") = True Then
                        loggedInUser = username
                        pharmacist_dashboard.Show()
                    Else
                        MsgBox("No Pharmacist with Employee_ID : " & username & "or you entered incorrect Password", MsgBoxStyle.Critical)
                    End If
                ElseIf specializationcmb.SelectedItem = "Record_Officer" Then
                    If checkvalidate(username, password, "Record_Officer") = True Then
                        loggedInUser = username
                        record_officer_dashboard.Show()
                    Else
                        MsgBox("No Record_Officer with Employee_ID : " & username & "or you entered incorrect Password", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("Please select your Specialization", MsgBoxStyle.Critical)
                End If
                End If
        End If
    End Sub
End Class
