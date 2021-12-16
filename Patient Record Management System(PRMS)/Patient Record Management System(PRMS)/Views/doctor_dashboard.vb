Imports System.IO

Public Class doctor_dashboard
    Dim ola As Integer
    Dim msg As String
    Public loggedInUser As String = ""
    Public userID As String = "doctor_dashboard"
    Dim patientBioTable As New DataTable
    Dim patientMedTable As New DataTable
    Dim patientHsTable As New DataTable
    Dim staffBioTable As New DataTable
    Dim patientMedCMP_wit_NurseSummaryTable As New DataTable
    Dim patientIDfronNurseTable As New DataTable
    Dim pixbyte() As Byte = Nothing
    Dim healthcare_no As String = ""
    Dim treatID As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Val(Label1.Text) - 1
        If Label1.Text = "0" Then
            Label1.Text = "120"
        End If
        If Label1.Text = "100" Then
            quote.Text = "The LAUTECH Teaching Hospital, Where Compassion and Healing come Together"
        ElseIf Label1.Text = "80" Then
            quote.Text = "To keep body in good health is our the duty"
        ElseIf Label1.Text = "60" Then
            quote.Text = "The Skill to Heal, the Spirit to Care. God Heals"
        ElseIf Label1.Text = "40" Then
            quote.Text = "Giving Staff and Students Care they deserve"
        ElseIf Label1.Text = "20" Then
            quote.Text = "We cares but God heals"
        ElseIf Label1.Text = "120" Then
            quote.Text = "Health is Wealth ,Stay Clean Stay Healthy"
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ola += 1
        TextBox1.Text += msg.Substring(ola - 1, 1)
        If ola = msg.Length Then
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If nametxt.Text = "" Or healthcare_no = "" Then
            MsgBox("please select the patient to treat by Enter Health_care and Search", MsgBoxStyle.Critical)
        Else
            diaghealthcarenotxt.Text = searchtxt.Text
            diaagetxt.Text = agetxt.Text
            diagendertxt.Text = gendertxt.Text
            diagnamestxt.Text = nametxt.Text
            diaphonetxt.Text = phonetxt.Text
            diagpix.Image = Image.FromStream(New MemoryStream(pixbyte))
            pixbyte = Nothing
            TabControl1.SelectedTab = diagnose
            patientIDfronNurseTable = getrecordtable("select * from nurse_checkups where healthcare_no='" & healthcare_no & "' and status='Not Yet Treat' order by checkup_date")
            If patientIDfronNurseTable.Rows.Count = 0 Then
                MsgBox("This patient need to visit Nurse first for Vital signs Checkup", MsgBoxStyle.Critical)
            Else
                heighttxt.Text = patientIDfronNurseTable.Rows(0)("height")
                weighttxt.Text = patientIDfronNurseTable.Rows(0)("weight")
                bmitxt.Text = patientIDfronNurseTable.Rows(0)("bmi")
                tempraturetxt.Text = patientIDfronNurseTable.Rows(0)("temperature")
                respiratorytxt.Text = patientIDfronNurseTable.Rows(0)("respiratory_rate")
                bptxt.Text = patientIDfronNurseTable.Rows(0)("blood_pressure")
                treatID = patientIDfronNurseTable.Rows(0)("id")
            End If
        End If

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        searchtxt.Text = TextBox19.Text
        searchbtn_Click(sender, e)
        TabControl1.SelectedTab = check_patient
    End Sub

    Private Sub HOMEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        TabControl1.SelectedTab = landingpage
        If Timer2.Enabled = True Then
            Timer2.Enabled = False
        End If
        Timer1.Enabled = True
    End Sub

    Private Sub NewPatientToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewPatientToolStripMenuItem.Click
        TabControl1.SelectedTab = check_patient
    End Sub

    Private Sub CheckPatientToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CheckPatientToolStripMenuItem.Click
        Me.TreatmentsTableAdapter.Fill(Me.PRMSdatabaseDataSet.treatments)
        TreatmentsBindingSource.Filter = "status='Not Yet Treat'"
        TabControl1.SelectedTab = pending_list
    End Sub

    Private Sub AboutSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSystemToolStripMenuItem.Click
        ola = 0
        msg = TextBox1.Text
        TextBox1.Text = " "
        Timer2.Enabled = True
        TabControl1.SelectedTab = About
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabControl1.SelectedTab = check_patient
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            labtxt.Visible = True
            Label29.Visible = True
        Else
            labtxt.Visible = False
            Label29.Visible = False
        End If

    End Sub

    Private Sub doctor_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loggedInUser = login.loggedInUser
        login.Close()
        staffBioTable = getrecordtable("select * from staff_biodata where employee_id='" & loggedInUser & "'")
        Dim firstname As String = staffBioTable.Rows(0)("first_name").ToString
        Dim othername As String = staffBioTable.Rows(0)("other_name").ToString
        Dim lastname As String = staffBioTable.Rows(0)("last_name").ToString
        doctornametxt.Text = lastname + " " + firstname.First.ToString.ToUpper + "." + othername.First.ToString.ToUpper
        doctoremailtxt.Text = staffBioTable.Rows(0)("phone").ToString
        employee_idtxt.Text = staffBioTable.Rows(0)("employee_id").ToString
        pixbyte = staffBioTable.Rows(0)("image")
        doctorpix.Image = Image.FromStream(New MemoryStream(pixbyte))
        pixbyte = Nothing
        Me.TreatmentsTableAdapter.Fill(Me.PRMSdatabaseDataSet.treatments)
        TreatmentsBindingSource.Filter = "status='Not Yet Treat'"
        all_pendigPatient_contxt.Text = TreatmentsBindingSource.Count

    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        If searchtxt.Text <> "" Then
            healthcare_no = searchtxt.Text
            Try
                patientBioTable = getrecordtable("select * from patient_biodata where healthcare_no='" & healthcare_no & "'")
                patientMedTable = getrecordtable("select * from treatments where healthcare_no='" & healthcare_no & "'and status='Not Yet Treat' order by treatment_date desc")
                patientHsTable = getrecordtable("select * from history where healthcare_no='" & healthcare_no & "'")
                treatID = patientMedTable.Rows(0)("id")
                If patientBioTable.Rows.Count = 0 Then
                    MsgBox("Check the Healthcare_No very well is seems it does not exist !", MsgBoxStyle.Critical)
                Else
                    'If patientMedTable.Rows.Count = 0 Then
                    '    MsgBox("Patient with Healthcare_No : " & healthcare_no & "does not have any Medical Records", MsgBoxStyle.Information)
                    'End If
                    'If patientHsTable.Rows.Count = 0 Then
                    '    MsgBox("Patient with Healthcare_No : " & healthcare_no & "does not have any Medical Past History", MsgBoxStyle.Information)
                    'End If
                    Dim firstname As String = patientBioTable.Rows(0)("first_name").ToString
                    Dim othername As String = patientBioTable.Rows(0)("other_name").ToString
                    Dim lastname As String = patientBioTable.Rows(0)("last_name").ToString
                    nametxt.Text = lastname & " " & firstname & " " & othername
                    occupationtxt.Text = patientBioTable.Rows(0)("occupation").ToString
                    gendertxt.Text = patientBioTable.Rows(0)("gender").ToString
                    agetxt.Text = patientBioTable.Rows(0)("age").ToString
                    phonetxt.Text = patientBioTable.Rows(0)("phone").ToString
                    emailtxt.Text = patientBioTable.Rows(0)("email").ToString
                    maritaltxt.Text = patientBioTable.Rows(0)("marital_status").ToString
                    addresstxt.Text = patientBioTable.Rows(0)("address").ToString
                    religiontxt.Text = patientBioTable.Rows(0)("religion").ToString
                    blood_group.Text = patientBioTable.Rows(0)("blood_group").ToString
                    pixbyte = patientBioTable.Rows(0)("image")
                    profpix.Image = Image.FromStream(New MemoryStream(pixbyte))
                    genotype.Text = patientBioTable.Rows(0)("genotype").ToString
                    If patientMedTable.Rows.Count <> 0 Then
                        medicaltxt.Text = patientMedTable.Rows(0)("nurse_summary")
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("Please enter Healthcare_No of the Patient and Search again", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If searchtxt.Text = "" Then
            MsgBox("Please Enter Healthcare_No and Search,then try this button again", MsgBoxStyle.Critical)
        Else
            If patientHsTable.Rows.Count = 0 Then
                MsgBox("No Medical History found", MsgBoxStyle.Information)
            Else
                medicaltxt.Text = patientHsTable.Rows(0)("medical_hs").ToString
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If searchtxt.Text = "" Then
            MsgBox("Please Enter Healthcare_No and Search,then try this button again", MsgBoxStyle.Critical)
        Else
            If patientHsTable.Rows.Count = 0 Then
                MsgBox("No Surgery History found", MsgBoxStyle.Information)
            Else
                medicaltxt.Text = patientHsTable.Rows(0)("surgery_hs").ToString
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If searchtxt.Text = "" Then
            MsgBox("Please Enter Healthcare_No and Search,then try this button again", MsgBoxStyle.Critical)
        Else
            If patientHsTable.Rows.Count = 0 Then
                MsgBox("No diagnosis History found", MsgBoxStyle.Information)
            Else
                medicaltxt.Text = patientHsTable.Rows(0)("diagnosis_hs").ToString
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If searchtxt.Text = "" Then
            MsgBox("Please Enter Healthcare_No and Search,then try this button again", MsgBoxStyle.Critical)
        Else
            If patientHsTable.Rows.Count = 0 Then
                MsgBox("No Family and social medical History found", MsgBoxStyle.Information)
            Else
                medicaltxt.Text = patientHsTable.Rows(0)("family_and_social_hs").ToString
            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If searchtxt.Text = "" Then
            MsgBox("Please Enter Healthcare_No and Search,then try this button again", MsgBoxStyle.Critical)
        Else
            If patientHsTable.Rows.Count = 0 Then
                MsgBox("No Dietary History found", MsgBoxStyle.Information)
            Else
                medicaltxt.Text = patientHsTable.Rows(0)("dietary_hs").ToString
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If searchtxt.Text = "" Then
            MsgBox("Please Enter Healthcare_No and Search,then try this button again", MsgBoxStyle.Critical)
        Else
            If patientHsTable.Rows.Count = 0 Then
                MsgBox("No Allergy History found", MsgBoxStyle.Information)
            Else
                medicaltxt.Text = patientHsTable.Rows(0)("allergy_hs").ToString
            End If
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If searchtxt.Text = "" Then
            MsgBox("Please Enter Healthcare_No and Search,then try this button again", MsgBoxStyle.Critical)
        Else
            If patientMedTable.Rows.Count <> 0 Then
                If patientMedTable.Rows(0)("doctor_summary").ToString = "" Then
                    MsgBox("No Doctor Summary found for Healthcare_No : " & searchtxt.Text & "", MsgBoxStyle.Information)
                Else
                    medicaltxt.Text = patientMedTable.Rows(0)("doctor_summary").ToString
                End If
            Else
                MsgBox("No Doctor Summary found for Healthcare_No : " & searchtxt.Text & "", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If searchtxt.Text = "" Then
            MsgBox("Please Enter Healthcare_No and Search,then try this button again", MsgBoxStyle.Critical)
        Else
            If patientMedTable.Rows.Count <> 0 Then
                If patientMedTable.Rows(0)("nurse_summary").ToString = "" Then
                    MsgBox("No Nurse Summary found for Healthcare_No : " & searchtxt.Text & "", MsgBoxStyle.Information)
                Else
                    medicaltxt.Text = patientMedTable.Rows(0)("nurse_summary").ToString
                End If
            Else
                MsgBox("No Nurse Summary found for Healthcare_No : " & searchtxt.Text & "", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If searchtxt.Text = "" Then
            MsgBox("Please Enter Healthcare_No and Search,then try this button again", MsgBoxStyle.Critical)
        Else
            If patientMedTable.Rows.Count <> 0 Then
                If patientMedTable.Rows(0)("lab_summary").ToString = "" Then
                    MsgBox("No Lab_officer Summary found for Healthcare_No : " & searchtxt.Text & "", MsgBoxStyle.Information)
                Else
                    medicaltxt.Text = patientMedTable.Rows(0)("lab_summary").ToString
                End If
            Else
                MsgBox("No Lab_officer Summary found for Healthcare_No : " & searchtxt.Text & "", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If searchtxt.Text = "" Then
            MsgBox("Please Enter Healthcare_No and Search,then try this button again", MsgBoxStyle.Critical)
        Else
            If patientMedTable.Rows.Count <> 0 Then
                If patientMedTable.Rows(0)("pharmacist_summary").ToString = "" Then
                    MsgBox("No Pharmacist Summary found for Healthcare_No : " & searchtxt.Text & "", MsgBoxStyle.Information)
                Else
                    medicaltxt.Text = patientMedTable.Rows(0)("pharmacist_summary").ToString
                End If
            Else
                MsgBox("No Pharmacist Summary found for Healthcare_No : " & searchtxt.Text & "", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If diaghealthcarenotxt.Text = "" Or diagnamestxt.Text = "" Or drug.Text = "" Or remark.Text = "" Or treatment.Text = "" Then
            MsgBox("Kindly fill all the fields", MsgBoxStyle.Information)
        Else
            txtreceipt.Text = " "
            txtreceipt.AppendText(" " + vbNewLine)
            txtreceipt.AppendText("The LAUTECH Teaching Hospital Osogbo, Osun State" + vbNewLine)
            txtreceipt.AppendText(" =================================" + vbNewLine)
            txtreceipt.AppendText("      MEDICAL REPORT AND TREATMENT" + vbNewLine)
            txtreceipt.AppendText(" =================================" + vbNewLine)
            txtreceipt.AppendText(" Doctor ID : " & employee_idtxt.Text & vbNewLine)
            txtreceipt.AppendText(" Patient Names : " & diagnamestxt.Text & vbNewLine)
            txtreceipt.AppendText(" Health care No : " & diaghealthcarenotxt.Text & vbNewLine)
            txtreceipt.AppendText(" Dignosis : " & diagnosis.Text & vbNewLine)
            txtreceipt.AppendText(" Injections/Drugs : " & drug.Text & vbNewLine)
            txtreceipt.AppendText(" Treatment/management : " & treatment.Text & vbNewLine)
            txtreceipt.AppendText(" Remarks : " & remark.Text & vbNewLine)
            If CheckBox1.Checked = True Then
                txtreceipt.AppendText(" Next Appointment date: " & next_appointment.Text & vbNewLine)
            End If
            If CheckBox2.Checked = True Then
                txtreceipt.AppendText(" Test to do : " & labtxt.Text & vbNewLine)
                txtreceipt.AppendText(" " + vbNewLine)
            End If
            txtreceipt.AppendText(" " + vbNewLine)
            txtreceipt.AppendText("=================================" + vbNewLine)
            txtreceipt.AppendText(vbTab & Today & vbTab & TimeOfDay + vbNewLine)
            txtreceipt.AppendText("=================================" + vbNewLine)
            txtreceipt.AppendText("HEALTH IS WEALTH...STAY CLEAN STAY HEALTHY" + vbNewLine)
            txtreceipt.AppendText("=================================" + vbNewLine)
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If remark.Text = "" Or drug.Text = "" Or diagnosis.Text = "" Or treatment.Text = "" Or txtreceipt.Text = "" Then
            MsgBox("Please make proper treatment", MsgBoxStyle.Information)
        Else
            updatetreatmentfromDoctor(diaghealthcarenotxt.Text)
            TabControl1.SelectedTab = pending_list
            searchtxt.Text = ""
            nametxt.Text = ""
            occupationtxt.Text = ""
            gendertxt.Text = ""
            agetxt.Text = ""
            phonetxt.Text = ""
            emailtxt.Text = ""
            profpix.Image = Nothing
            diagpix.Image = Nothing
            maritaltxt.Text = ""
            addresstxt.Text = ""
            religiontxt.Text = ""
            blood_group.Text = ""
            genotype.Text = ""
            heighttxt.Text = ""
            weighttxt.Text = ""
            bmitxt.Text = ""
            tempraturetxt.Text = ""
            respiratorytxt.Text = ""
            bptxt.Text = ""
            txtreceipt.Text = ""
            medicaltxt.Text = ""
            drug.Text = ""
            diagnose.Text = ""
            treatment.Text = ""
            remark.Text = ""
            next_appointment.Text = ""
            labtxt.Text = ""
            treatID = 0
        End If
    End Sub

    Private Sub DOCTORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DOCTORToolStripMenuItem.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
        End If
        If Timer2.Enabled = True Then
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
        End If
        If Timer2.Enabled = True Then
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim x = MsgBox("Are you sure you want to SignOut ?", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            next_appointment.Visible = True
            Label17.Visible = True
        Else
            next_appointment.Visible = False
            Label17.Visible = False
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TreatmentsBindingSource.MoveNext()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TreatmentsBindingSource.MovePrevious()
    End Sub
End Class