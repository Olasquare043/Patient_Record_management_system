Imports System.IO

Public Class pharmacist_dashboard
    Dim ola As Integer
    Dim msg As String
    Public loggedInUser As String = ""
    Public userID As String = "pharmacist"
    Public pixbytes() As Byte = Nothing
    Dim filepath As String = ""
    Dim staffBioTable As New DataTable
    Dim patientBioTable As New DataTable
    Dim patientMedTable As New DataTable
    Dim healthcare_no As String = ""
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

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Timer1.Enabled = False
        If Timer2.Enabled = True Then
            Timer2.Enabled = False
        End If
        TabControl1.SelectedTab = landingpage
    End Sub
    Private Sub CheckPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckPatientToolStripMenuItem.Click
        TabControl1.SelectedTab = check_patient
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ola += 1
        TextBox1.Text += msg.Substring(ola - 1, 1)
        If ola = msg.Length Then
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub AboutSystemToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutSystemToolStripMenuItem.Click
        ola = 0
        msg = TextBox1.Text
        TextBox1.Text = " "
        Timer2.Enabled = True
        TabControl1.SelectedTab = About
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            unavailable_drugtxt.Visible = True
            Label2.Visible = True
        Else
            unavailable_drugtxt.Visible = False
            Label2.Visible = False
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = landingpage
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        If searchtxt.Text = "" Or nametxt.Text = "" Or drug_giventxt.Text = "" Or pharmacist_remarkstxt.Text = "" Then
            MsgBox("Please fill all the Required Fields or research the Patient again to have his/her information fields", MsgBoxStyle.Critical)
        Else
            If doctor_prescriptiontxt.Text = "" Then
                MsgBox("Please ! the patient Should see Doctor first", MsgBoxStyle.Critical)
            Else
                txtreceipt.Text = " "
                txtreceipt.AppendText(" " + vbNewLine)
                txtreceipt.AppendText("The LAUTECH Teaching Hospital Osogbo, Osun State" + vbNewLine)
                txtreceipt.AppendText(" =================================" + vbNewLine)
                txtreceipt.AppendText("PHARMACIST REPORT AND TREATMENT             " + vbNewLine)
                txtreceipt.AppendText(" =================================" + vbNewLine)
                txtreceipt.AppendText(" Pharmacist ID : " & employee_idtxt.Text & vbNewLine)
                txtreceipt.AppendText(" Patient Names : " & nametxt.Text & vbNewLine)
                txtreceipt.AppendText(" Health care No : " & searchtxt.Text & vbNewLine)
                txtreceipt.AppendText(" Drug Prescription : " & doctor_prescriptiontxt.Text & vbNewLine)
                txtreceipt.AppendText(" Drug Given : " & drug_giventxt.Text & vbNewLine)
                If CheckBox2.Checked = False Then
                    txtreceipt.AppendText(" Unavailable Drug : " & unavailable_drugtxt.Text & vbNewLine)
                End If
                txtreceipt.AppendText(" Remarks : " & pharmacist_remarkstxt.Text & vbNewLine)
                txtreceipt.AppendText(" " + vbNewLine)
                txtreceipt.AppendText(" " + vbNewLine)
                txtreceipt.AppendText("=================================" + vbNewLine)
                txtreceipt.AppendText(vbTab & Today & vbTab & TimeOfDay + vbNewLine)
                txtreceipt.AppendText("=================================" + vbNewLine)
                txtreceipt.AppendText("HEALTH IS WEALTH...STAY CLEAN STAY HEALTHY" + vbNewLine)
                txtreceipt.AppendText("=================================" + vbNewLine)
                Button6.Enabled = True
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = landingpage
    End Sub

    Private Sub pharmacist_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loggedInUser = login.loggedInUser
        login.Close()
        staffBioTable = getrecordtable("select * from staff_biodata where employee_id='" & loggedInUser & "'")
        Dim firstname As String = staffBioTable.Rows(0)("first_name").ToString
        Dim othername As String = staffBioTable.Rows(0)("other_name").ToString
        Dim lastname As String = staffBioTable.Rows(0)("last_name").ToString
        pharmacisttxt.Text = lastname + " " + firstname.First.ToString.ToUpper + "." + othername.First.ToString.ToUpper
        pharmacist_phonetxt.Text = staffBioTable.Rows(0)("phone").ToString
        employee_idtxt.Text = staffBioTable.Rows(0)("employee_id").ToString
        pixbytes = staffBioTable.Rows(0)("image")
        PictureBox1.Image = Image.FromStream(New MemoryStream(pixbytes))
        pixbytes = Nothing
    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        If searchtxt.Text <> "" Then
            healthcare_no = searchtxt.Text
            Try
                patientBioTable = getrecordtable("select * from patient_biodata where healthcare_no='" & healthcare_no & "'")
                patientMedTable = getrecordtable("select * from treatments where healthcare_no='" & healthcare_no & "' and status='Treated'order by treatment_date DESC")
                If patientBioTable.Rows.Count = 0 Then
                    MsgBox("Check the Healthcare_No very well is seems it does not exist !", MsgBoxStyle.Critical)
                Else
                    Dim firstname As String = patientBioTable.Rows(0)("first_name").ToString
                    Dim othername As String = patientBioTable.Rows(0)("other_name").ToString
                    Dim lastname As String = patientBioTable.Rows(0)("last_name").ToString
                    nametxt.Text = lastname & " " & firstname & " " & othername
                    gendertxt.Text = patientBioTable.Rows(0)("gender").ToString
                    agetxt.Text = patientBioTable.Rows(0)("age").ToString
                    pixbytes = patientBioTable.Rows(0)("image")
                    PictureBox2.Image = Image.FromStream(New MemoryStream(pixbytes))
                    pixbytes = Nothing
                    If patientMedTable.Rows.Count = 0 Then
                        MsgBox("Patient with Healthcare_No : " & healthcare_no & "does not have any Medical Records Let Him/Her Go visit Doctor First", MsgBoxStyle.Information)
                    Else
                        doctor_prescriptiontxt.Text = patientMedTable.Rows(0)("drug_prescription").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("Please enter Healthcare_No of the Patient and Search again", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If searchtxt.Text = "" Or nametxt.Text = "" Or drug_giventxt.Text = "" Or pharmacist_remarkstxt.Text = "" Then
            MsgBox("Please fill all the Required Fields", MsgBoxStyle.Critical)
        Else

            savePharmacisttask()
            Dim id As Integer = patientMedTable.Rows(0)("id")
            updateMedPharmacistSummary(id)
            searchtxt.Text = ""
            pharmacist_remarkstxt.Text = ""
            doctor_prescriptiontxt.Text = ""
            drug_giventxt.Text = ""
            unavailable_drugtxt.Text = ""
            nametxt.Text = ""
            agetxt.Text = ""
            gendertxt.Text = ""
            PictureBox2.Image = Nothing
            txtreceipt.Text = ""
            Button6.Enabled = False
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim x = MsgBox("Are you sure you want to SignOut ?", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            login.Show()
            Me.Close()
        End If
    End Sub
End Class