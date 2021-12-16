Imports System.Data.SqlClient
Imports System.IO
Module Module1
    Public con As SqlConnection = New SqlConnection("Server=SQLOLEDB.1;Password=olayiwola;Persist Security Info=True;User ID=sa;Initial Catalog=PRMSdatabase;Data Source=OLASQUARE\SQLEXPRESS")
    Dim dr As SqlDataReader
    Function getrecordtable(query As String)
        Dim table As New DataTable
        Try
            Dim cmd As SqlCommand = New SqlCommand(query, con)
            With con
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
            End With
            Dim adpt As SqlDataAdapter = New SqlDataAdapter(cmd)
            adpt.Fill(table)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            With con
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End With
        End Try
        Return table
    End Function
    Function IDgen()
        Dim year As Integer = Now.Year
        Dim rand As New Random
        Dim str As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim sb As New System.Text.StringBuilder
        Dim digitgen As String = ""
        Dim gen As String
        For i = 1 To 2
            Dim index As Integer = rand.Next(0, 25)
            Dim digen As Integer = rand.Next(0, 9)
            digitgen &= digen
            sb.Append(str.Substring(index, 1))
        Next
        gen = "OAU/" & year & "/" & sb.ToString & digitgen
        Return gen
    End Function
    Sub staffreg()
        Try
            If Adminpage.picbytes Is Nothing Then
            Else
                Dim cmd As SqlCommand = New SqlCommand("insert into staff_biodata(employee_id,first_name,other_name,last_name,gender,age,specialization,phone,email,marital_status,address,religion,nok,nok_address,blood_group,genotype,image,created_date)values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m,@n,@o,@p,@q,@r)", con)
                With con
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                End With
                Dim datetimes As String = Today.ToShortDateString & TimeOfDay.ToString
                With cmd.Parameters
                    .AddWithValue("@a", Adminpage.Employee_idtxt.Text)
                    .AddWithValue("@b", Adminpage.firstnametxt.Text)
                    .AddWithValue("@c", Adminpage.othernametxt.Text)
                    .AddWithValue("@d", Adminpage.lastnametxt.Text)
                    .AddWithValue("@e", Adminpage.gendercmb.Text)
                    .AddWithValue("@f", Adminpage.agecmb.Text)
                    .AddWithValue("@g", Adminpage.specializecmb.Text)
                    .AddWithValue("@h", Adminpage.phonetxt.Text)
                    .AddWithValue("@i", Adminpage.emailtxt.Text)
                    .AddWithValue("@j", Adminpage.maritalcmb.Text)
                    .AddWithValue("@k", Adminpage.addresstxt.Text)
                    .AddWithValue("@l", Adminpage.religoncmb.Text)
                    .AddWithValue("@m", Adminpage.noktxt.Text)
                    .AddWithValue("@n", Adminpage.nokaddresstxt.Text)
                    .AddWithValue("@o", Adminpage.bloodgpcmb.Text)
                    .AddWithValue("@p", Adminpage.genotypecmb.Text)
                    .AddWithValue("@q", Adminpage.picbytes)
                    .AddWithValue("@r", datetimes)
                End With
                If cmd.ExecuteNonQuery() Then
                    saveUsers()
                    MsgBox("Record Saved Successfully", MsgBoxStyle.Information)
                End If
                Adminpage.agecmb.Text = vbNull
                Adminpage.picbytes = Nothing
                Adminpage.maritalcmb.Text = vbNull
                Adminpage.gendercmb.Text = vbNull
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            With con
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End With
        End Try
    End Sub
    Sub patientreg()
        Try
            If record_officer_dashboard.pixbytes Is Nothing Then
            Else
                Dim cmd As SqlCommand = New SqlCommand("insert into patient_biodata(healthcare_no,first_name,other_name,last_name,gender,age,occupation,phone,email,marital_status,address,religion,nok,nok_address,blood_group,genotype,image,created_date)values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m,@n,@o,@p,@q,@r)", con)
                With con
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                End With
                Dim datetimes As String = Today & vbTab & TimeOfDay.ToString
                With cmd.Parameters
                    .AddWithValue("@a", record_officer_dashboard.healthcarenotxt.Text)
                    .AddWithValue("@b", record_officer_dashboard.firstnametxt.Text)
                    .AddWithValue("@c", record_officer_dashboard.othernametxt.Text)
                    .AddWithValue("@d", record_officer_dashboard.lastnametxt.Text)
                    .AddWithValue("@e", record_officer_dashboard.gendercmb.Text)
                    .AddWithValue("@f", record_officer_dashboard.agecmb.Text)
                    .AddWithValue("@g", record_officer_dashboard.occupationtxt.Text)
                    .AddWithValue("@h", record_officer_dashboard.phonetxt.Text)
                    .AddWithValue("@i", record_officer_dashboard.emailtxt.Text)
                    .AddWithValue("@j", record_officer_dashboard.maritalcmb.Text)
                    .AddWithValue("@k", record_officer_dashboard.addresstxt.Text)
                    .AddWithValue("@l", record_officer_dashboard.religoncmb.Text)
                    .AddWithValue("@m", record_officer_dashboard.noktxt.Text)
                    .AddWithValue("@n", record_officer_dashboard.nokaddresstxt.Text)
                    .AddWithValue("@o", record_officer_dashboard.bloodgpcmb.Text)
                    .AddWithValue("@p", record_officer_dashboard.genotypecmb.Text)
                    .AddWithValue("@q", record_officer_dashboard.pixbytes)
                    .AddWithValue("@r", datetimes)
                End With

                If cmd.ExecuteNonQuery() Then
                    MsgBox("Record Saved Successfully", MsgBoxStyle.Information)
                End If
                record_officer_dashboard.agecmb.Text = vbNull
                record_officer_dashboard.pixbytes = Nothing
                record_officer_dashboard.maritalcmb.Text = vbNull
                record_officer_dashboard.gendercmb.Text = vbNull
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            With con
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End With
        End Try
    End Sub
    Sub saveNurseCheckup()
        Dim healthcare_no As String = nurse_dashboard.searchtxt.Text
        Dim cmd As SqlCommand = New SqlCommand("select * from nurse_checkups where healthcare_no ='" & healthcare_no & "'and status='Not Yet Treat'", con)
        Dim adpt As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adpt.Fill(table)
        If table.Rows.Count > 0 Then
            Try
                Dim cmd1 As SqlCommand = New SqlCommand("update nurse_checkups set healthcare_no=@a,employee_id=@b,weight=@c,height=@d,bmi=@e,temperature=@f,respiratory_rate=@g,blood_pressure=@h,checkup_date=@i,status=@j,summary=@k where healthcare_no='" & healthcare_no & "'", con)
                With con
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    Dim datetimes As String = Today & vbTab & TimeOfDay.ToString
                    With cmd1.Parameters
                        .AddWithValue("@a", healthcare_no)
                        .AddWithValue("@b", nurse_dashboard.employee_idtxt.Text)
                        .AddWithValue("@c", nurse_dashboard.weighttxt.Text)
                        .AddWithValue("@d", nurse_dashboard.heighttxt.Text)
                        .AddWithValue("@e", nurse_dashboard.bmitxt.Text)
                        .AddWithValue("@f", nurse_dashboard.temperaturetxt.Text)
                        .AddWithValue("@g", nurse_dashboard.respiratorytxt.Text)
                        .AddWithValue("@h", nurse_dashboard.bptxt.Text)
                        .AddWithValue("@i", datetimes)
                        .AddWithValue("@j", "Not Yet Treat")
                        .AddWithValue("@k", nurse_dashboard.txtreceipt.Text)
                        cmd1.ExecuteNonQuery()
                        updateMedNurseSummary()
                        MsgBox("Patient Information has been sent to Doctor successfully", MsgBoxStyle.Information)
                    End With
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                With con
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End With
            End Try
        Else
            Try
                Dim cmd1 As SqlCommand = New SqlCommand("insert into nurse_checkups(healthcare_no,employee_id,weight,height,bmi,temperature,respiratory_rate,blood_pressure,checkup_date,status,summary)values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k)", con)
                With con
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    Dim datetimes As String = Today & vbTab & TimeOfDay.ToString
                    With cmd1.Parameters
                        .AddWithValue("@a", nurse_dashboard.searchtxt.Text)
                        .AddWithValue("@b", nurse_dashboard.employee_idtxt.Text)
                        .AddWithValue("@c", nurse_dashboard.weighttxt.Text)
                        .AddWithValue("@d", nurse_dashboard.heighttxt.Text)
                        .AddWithValue("@e", nurse_dashboard.bmitxt.Text)
                        .AddWithValue("@f", nurse_dashboard.temperaturetxt.Text)
                        .AddWithValue("@g", nurse_dashboard.respiratorytxt.Text)
                        .AddWithValue("@h", nurse_dashboard.bptxt.Text)
                        .AddWithValue("@i", datetimes)
                        .AddWithValue("@j", "Not Yet Treat")
                        .AddWithValue("@k", nurse_dashboard.txtreceipt.Text)

                        cmd1.ExecuteNonQuery()
                        updateMedNurseSummary()
                        MsgBox("Patient Information has been sent to Doctor successfully", MsgBoxStyle.Information)
                    End With
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                With con
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End With
            End Try
        End If
    End Sub
    Sub updateMedNurseSummary()
        Dim healthcare_no As String = nurse_dashboard.searchtxt.Text
        Dim cmd1 As SqlCommand = New SqlCommand("select * from treatments where healthcare_no ='" & healthcare_no & "'and status='Not Yet Treat'", con)
        Dim adpt As SqlDataAdapter = New SqlDataAdapter(cmd1)
        Dim table As New DataTable
        adpt.Fill(table)
        If table.Rows.Count > 0 Then
            Try
                Dim cmd As SqlCommand = New SqlCommand("update treatments set healthcare_no=@a, nurse_summary=@b where healthcare_no='" & healthcare_no & "'", con)
                With con
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    With cmd.Parameters
                        .AddWithValue("@a", healthcare_no)
                        .AddWithValue("@b", nurse_dashboard.txtreceipt.Text)

                    End With
                    cmd.ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                With con
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End With
            End Try
        Else
            Try
                Dim cmd As SqlCommand = New SqlCommand("insert into treatments(healthcare_no,nurse_summary,status)values (@a,@b,@c)", con)
                With con
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    With cmd.Parameters
                        .AddWithValue("@a", nurse_dashboard.searchtxt.Text)
                        .AddWithValue("@b", nurse_dashboard.txtreceipt.Text)
                        .AddWithValue("@c", "Not Yet Treat")
                    End With
                    cmd.ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                With con
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End With
            End Try
        End If

    End Sub
    Sub updateMedPharmacistSummary(id As Integer)
        Dim healthcare_no As String = pharmacist_dashboard.searchtxt.Text
        Dim cmd1 As SqlCommand = New SqlCommand("select * from treatments where healthcare_no='" & healthcare_no & "' and status='Treated'order by treatment_date DESC", con)
        Dim adpt As SqlDataAdapter = New SqlDataAdapter(cmd1)
        Dim table As New DataTable
        adpt.Fill(table)
        If table.Rows.Count > 0 Then
            If table.Rows(0)("pharmacist_summary").ToString = "" Then
                Try
                    Dim cmd As SqlCommand = New SqlCommand("update treatments set pharmacist_summary=@a where id ='" & id & "'", con)
                    With con
                        If con.State = ConnectionState.Closed Then
                            con.Open()
                        End If
                        With cmd.Parameters
                            .AddWithValue("@a", pharmacist_dashboard.txtreceipt.Text)
                        End With
                        cmd.ExecuteNonQuery()
                        MsgBox("Record Save Successfully", MsgBoxStyle.Information)
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    With con
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                    End With
                End Try
            Else
                Dim x = MsgBox("Drug has been Administered to this patient..Do you want to update the record to new one?", MsgBoxStyle.YesNo)
                If x = MsgBoxResult.Yes Then
                    Try
                        Dim cmd As SqlCommand = New SqlCommand("update treatments set pharmacist_summary=@a where id ='" & id & "'", con)
                        With con
                            If con.State = ConnectionState.Closed Then
                                con.Open()
                            End If
                            With cmd.Parameters
                                .AddWithValue("@a", pharmacist_dashboard.txtreceipt.Text)
                            End With
                            cmd.ExecuteNonQuery()
                            MsgBox("Record Update Successfully", MsgBoxStyle.Information)
                        End With
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    Finally
                        With con
                            If con.State = ConnectionState.Open Then
                                con.Close()
                            End If
                        End With
                    End Try
                End If
            End If
        Else
        End If

    End Sub
    Sub updateMedlabOfficerSummary(id As Integer)
        Dim healthcare_no As String = lab_officer_dashboard.searchtxt.Text
        Dim cmd1 As SqlCommand = New SqlCommand("select * from treatments where healthcare_no='" & healthcare_no & "' and status='Treated'order by treatment_date DESC", con)
        Dim adpt As SqlDataAdapter = New SqlDataAdapter(cmd1)
        Dim table As New DataTable
        adpt.Fill(table)
        If table.Rows.Count > 0 Then
            If table.Rows(0)("lab_summary").ToString = "" Then
                Try
                    Dim cmd As SqlCommand = New SqlCommand("update treatments set lab_summary=@a where id ='" & id & "'", con)
                    With con
                        If con.State = ConnectionState.Closed Then
                            con.Open()
                        End If
                        With cmd.Parameters
                            .AddWithValue("@a", lab_officer_dashboard.txtreceipt.Text)
                        End With
                        cmd.ExecuteNonQuery()
                        MsgBox("Record Save Successfully", MsgBoxStyle.Information)
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    With con
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                    End With
                End Try
            Else
                Dim x = MsgBox("This patient has Test Results before..Do you want to update the record to new one?", MsgBoxStyle.YesNo)
                If x = MsgBoxResult.Yes Then
                    Try
                        Dim cmd As SqlCommand = New SqlCommand("update treatments set lab_summary=@a where id ='" & id & "'", con)
                        With con
                            If con.State = ConnectionState.Closed Then
                                con.Open()
                            End If
                            With cmd.Parameters
                                .AddWithValue("@a", lab_officer_dashboard.txtreceipt.Text)
                            End With
                            cmd.ExecuteNonQuery()
                            MsgBox("Record Update Successfully", MsgBoxStyle.Information)
                        End With
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    Finally
                        With con
                            If con.State = ConnectionState.Open Then
                                con.Close()
                            End If
                        End With
                    End Try
                End If
            End If
        Else
        End If
    End Sub
    Sub savePharmacisttask()
        Try
            Dim cmd1 As SqlCommand = New SqlCommand("insert into pharmacist(healthcare_no,employee_id,drug_prescription,given_drug,pharmacist_remark,pharmacist_summary,administer_date)values(@a,@b,@c,@d,@e,@f,@g)", con)
            With con
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim datetimes As String = Today & vbTab & TimeOfDay.ToString
                With cmd1.Parameters
                    .AddWithValue("@a", pharmacist_dashboard.searchtxt.Text)
                    .AddWithValue("@b", pharmacist_dashboard.employee_idtxt.Text)
                    .AddWithValue("@c", pharmacist_dashboard.doctor_prescriptiontxt.Text)
                    .AddWithValue("@d", pharmacist_dashboard.drug_giventxt.Text)
                    .AddWithValue("@e", pharmacist_dashboard.pharmacist_remarkstxt.Text)
                    .AddWithValue("@f", pharmacist_dashboard.txtreceipt.Text)
                    .AddWithValue("@g", datetimes)
                    cmd1.ExecuteNonQuery()
                End With
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            With con
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End With

        End Try
    End Sub
    Sub savelab_officertask()
        Try
            Dim cmd1 As SqlCommand = New SqlCommand("insert into laboratory(healthcare_no,employee_id,test_request,result,lab_officer_remark,lab_officer_summary,test_date)values(@a,@b,@c,@d,@e,@f,@g)", con)
            With con
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim datetimes As String = Today & vbTab & TimeOfDay.ToString
                With cmd1.Parameters
                    .AddWithValue("@a", lab_officer_dashboard.searchtxt.Text)
                    .AddWithValue("@b", lab_officer_dashboard.employee_idtxt.Text)
                    .AddWithValue("@c", lab_officer_dashboard.doctor_requesttxt.Text)
                    .AddWithValue("@d", lab_officer_dashboard.test_resulttxt.Text)
                    .AddWithValue("@e", lab_officer_dashboard.lab_officer_remarkstxt.Text)
                    .AddWithValue("@f", lab_officer_dashboard.txtreceipt.Text)
                    .AddWithValue("@g", datetimes)
                    cmd1.ExecuteNonQuery()
                End With
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            With con
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End With

        End Try
    End Sub
    Sub savepatientHS()
        Try
            Dim cmd1 As SqlCommand = New SqlCommand("insert into history(healthcare_no,employee_id,medical_hs,surgery_hs,diagnosis_hs,family_and_social_hs,allergy_hs,dietary_hs,reg_date)values(@a,@b,@c,@d,@e,@f,@g,@h,@i)", con)
            With con
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim datetimes As String = Today.ToShortDateString & TimeOfDay.ToString
                With cmd1.Parameters
                    .AddWithValue("@a", record_officer_dashboard.healthcareno2txt.Text)
                    .AddWithValue("@b", record_officer_dashboard.employee_idtxt.Text)
                    .AddWithValue("@c", record_officer_dashboard.medicalhstxt.Text)
                    .AddWithValue("@d", record_officer_dashboard.surgeryhstxt.Text)
                    .AddWithValue("@e", record_officer_dashboard.diagnosishstxt.Text)
                    .AddWithValue("@f", record_officer_dashboard.fshstxt.Text)
                    .AddWithValue("@g", record_officer_dashboard.allergyhstxt.Text)
                    .AddWithValue("@h", record_officer_dashboard.dietaryhstxt.Text)
                    .AddWithValue("@i", datetimes)
                    cmd1.ExecuteNonQuery()
                    MsgBox("Patient Medical Histories Saved Successgully", MsgBoxStyle.Information)
                End With
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            With con
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End With

        End Try

    End Sub
    Sub saveUsers()
        Try
            Dim cmd1 As SqlCommand = New SqlCommand("insert into users(employee_id,password,specialization,security_answer,created_date)values(@a,@b,@c,@d,@e)", con)
            With con
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim datetimes As String = Today & vbTab & TimeOfDay.ToString
                With cmd1.Parameters
                    .AddWithValue("@a", Adminpage.Employee_idtxt.Text)
                    .AddWithValue("@b", Adminpage.firstnametxt.Text)
                    .AddWithValue("@c", Adminpage.specializecmb.Text)
                    .AddWithValue("@d", "anything")
                    .AddWithValue("@e", datetimes)
                    cmd1.ExecuteNonQuery()
                End With
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            With con
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End With

        End Try

    End Sub
    Sub staffregupdate(loggeInUser As String, profilepixbyte() As Byte)
        Try
            If edit_profile.picbytes Is Nothing Then
            Else
                Dim cmd As SqlCommand = New SqlCommand("update staff_biodata set employee_id=@a,first_name=@b,other_name=@c,last_name=@d,gender=@e,age=@f,specialization=@g,phone=@h,email=@i,marital_status=@j,address=@k,religion=@l,nok=@m,nok_address=@n,blood_group=@o,genotype=@p,image=@q where employee_id='" & loggeInUser & "'", con)
                With con
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                End With
                With cmd.Parameters
                    .AddWithValue("@a", loggeInUser)
                    .AddWithValue("@b", edit_profile.First_nameTextBox.Text)
                    .AddWithValue("@c", edit_profile.Other_nameTextBox.Text)
                    .AddWithValue("@d", edit_profile.Last_nameTextBox.Text)
                    .AddWithValue("@e", edit_profile.gendercmb.Text)
                    .AddWithValue("@f", edit_profile.agecmb.Text)
                    .AddWithValue("@g", edit_profile.specializationcmb.Text)
                    .AddWithValue("@h", edit_profile.PhoneTextBox.Text)
                    .AddWithValue("@i", edit_profile.EmailTextBox.Text)
                    .AddWithValue("@j", edit_profile.maritalcmb.Text)
                    .AddWithValue("@k", edit_profile.AddressTextBox.Text)
                    .AddWithValue("@l", edit_profile.religoncmb.Text)
                    .AddWithValue("@m", edit_profile.noktxt.Text)
                    .AddWithValue("@n", edit_profile.nokaddresstxt.Text)
                    .AddWithValue("@o", edit_profile.bloodgpcmb.Text)
                    .AddWithValue("@p", edit_profile.genotypecmb.Text)
                    .AddWithValue("@q", profilepixbyte)
                End With
                If cmd.ExecuteNonQuery() Then
                    MsgBox("Record Update Successfully", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            With con
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End With
        End Try
    End Sub
    Sub updatetreatmentfromDoctor(treatID As Integer)
        'Dim cmd1 As SqlCommand = New SqlCommand("select * from treatments where healthcare_no ='" & healthcare_no & "'and status='Not Yet Treat'", con)
        'Dim adpt As SqlDataAdapter = New SqlDataAdapter(cmd1)
        'Dim table As New DataTable
        'adpt.Fill(table)
        If treatID > 0 Then
            Try
                Dim cmd As SqlCommand = New SqlCommand("update treatments set healthcare_no=@a,employee_id=@b,diagnose=@c,drug_prescription=@d,lab_test_request=@e,doctor_remark=@f,doctor_summary=@g,treatment_date=@h,status=@i where id='" & treatID & "'", con)
                With con
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                End With
                Dim datetimes As String = Today & vbTab & TimeOfDay.ToString
                With cmd.Parameters
                    .AddWithValue("@a", doctor_dashboard.diaghealthcarenotxt.Text)
                    .AddWithValue("@b", doctor_dashboard.employee_idtxt.Text)
                    .AddWithValue("@c", doctor_dashboard.diagnosis.Text)
                    .AddWithValue("@d", doctor_dashboard.drug.Text)
                    .AddWithValue("@e", doctor_dashboard.labtxt.Text)
                    .AddWithValue("@f", doctor_dashboard.remark.Text)
                    .AddWithValue("@g", doctor_dashboard.txtreceipt.Text)
                    .AddWithValue("@h", datetimes)
                    .AddWithValue("@i", "Treated")
                End With
                If cmd.ExecuteNonQuery() Then
                    updatetreatmentstatus(doctor_dashboard.diaghealthcarenotxt.Text)
                    MsgBox("Record Saved Successfully", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                With con
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End With
            End Try

        Else
            Try
                Dim cmd As SqlCommand = New SqlCommand("insert into treatments(healthcare_no,employee_id,diagnose,drug_prescription,lab_test_request,doctor_remark,doctor_summary,treatment_date,status) values(@a,@b,@c,@d,@e,@f,@g,@h,@i)", con)
                With con
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                End With
                Dim datetimes As String = Today & vbTab & TimeOfDay.ToString
                With cmd.Parameters
                    .AddWithValue("@a", doctor_dashboard.diaghealthcarenotxt.Text)
                    .AddWithValue("@b", doctor_dashboard.employee_idtxt.Text)
                    .AddWithValue("@c", doctor_dashboard.diagnosis.Text)
                    .AddWithValue("@d", doctor_dashboard.drug.Text)
                    .AddWithValue("@e", doctor_dashboard.labtxt.Text)
                    .AddWithValue("@f", doctor_dashboard.remark.Text)
                    .AddWithValue("@g", doctor_dashboard.txtreceipt.Text)
                    .AddWithValue("@h", datetimes)
                    .AddWithValue("@i", "Treated")
                End With
                If cmd.ExecuteNonQuery() Then
                    MsgBox("Record Saved Successfully", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                With con
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End With
            End Try

        End If
    End Sub
    Sub updatetreatmentstatus(healthcare_no As String)
        Dim cmd As SqlCommand = New SqlCommand("Update nurse_checkups set status=@a where healthcare_no='" & healthcare_no & "'and status='Not Yet Treat'", con)
        With con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        End With
        With cmd.Parameters
            .AddWithValue("@a", "Treated")
        End With
        cmd.ExecuteNonQuery()
        With con
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End With
    End Sub
    Function checkvalidate(username As String, password As String, specialization As String)
        Dim cmd As SqlCommand
        Dim adpt As SqlDataAdapter
        Dim table As New DataTable
        Dim flag As Boolean = False
        Try
            With con
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                cmd = New SqlCommand("select * from users where employee_id ='" & username & "'and specialization='" & specialization & "'", con)
                adpt = New SqlDataAdapter(cmd)
                adpt.Fill(table)
                If table.Rows.Count = 0 Then
                    flag = False
                Else
                    Dim vrypassword = table.Rows(0)("password").ToString
                    If password = vrypassword Then
                        flag = True
                    End If
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            With con
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End With
        End Try
        Return flag
    End Function
    Sub firstupdatepassword(employee_id As String, new_password As String, security_answer As String)
        Try
            Dim cmd As SqlCommand = New SqlCommand("UPDATE users SET password=@a,security_answer=@b WHERE employee_id='" & employee_id & "'", con)
            With con
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                With cmd.Parameters
                    .AddWithValue("@employee_id", employee_id)
                    .AddWithValue("@a", new_password)
                    .AddWithValue("@b", security_answer)
                End With
                cmd.ExecuteNonQuery()
                MsgBox("Password and Security Questions and Answer are set Successfully", MsgBoxStyle.Information)

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            With con
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End With
        End Try
    End Sub
    Sub updatepassword(employee_id As String, new_password As String)
        Try
            Dim cmd As SqlCommand = New SqlCommand("UPDATE users SET password=@a WHERE employee_id='" & employee_id & "'", con)
            With con
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                With cmd.Parameters
                    .AddWithValue("@employee_id", employee_id)
                    .AddWithValue("@a", new_password)

                End With
                cmd.ExecuteNonQuery()
                MsgBox("Password Reset Successfully", MsgBoxStyle.Information)

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            With con
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End With
        End Try
    End Sub
End Module
