Imports System.IO

Public Class lab_officer_dashboard
    Dim ola As Integer
    Dim msg As String
    Public loggedInUser As String = ""
    Public userID As String = "lab_officer"
    Dim healthcare_no As String = ""
    Dim pixbyte() As Byte = Nothing
    Dim staffBioTable As New DataTable
    Dim patientBioTable As New DataTable
    Dim patientMedTable As New DataTable
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

    Private Sub HOMEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click

        Timer1.Enabled = True
        If Timer2.Enabled = True Then
            Timer2.Enabled = False
        End If
        TabControl1.SelectedTab = landingpage
    End Sub
    Private Sub CheckPatientToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CheckPatientToolStripMenuItem.Click
        TabControl1.SelectedTab = check_patient
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ola += 1
        TextBox1.Text += msg.Substring(ola - 1, 1)
        If ola = msg.Length Then
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub AboutSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSystemToolStripMenuItem.Click
        ola = 0
        msg = TextBox1.Text
        TextBox1.Text = " "
        Timer2.Enabled = True
        TabControl1.SelectedTab = About
    End Sub

    Private Sub lab_officers_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loggedInUser = login.loggedInUser
        login.Close()
        staffBioTable = getrecordtable("select * from staff_biodata where employee_id='" & loggedInUser & "'")
        Dim firstname As String = staffBioTable.Rows(0)("first_name").ToString
        Dim othername As String = staffBioTable.Rows(0)("other_name").ToString
        Dim lastname As String = staffBioTable.Rows(0)("last_name").ToString
        Dim fname As String = lastname.Substring(0, 1).ToString
        Dim lname As String = lastname.Substring(0, 1).ToString
        labofficernametxt.Text = lastname + " " + fname.ToUpper + "." + lname.ToUpper
        lab_officerphonetxt.Text = staffBioTable.Rows(0)("phone").ToString
        employee_idtxt.Text = staffBioTable.Rows(0)("employee_id").ToString
        pixbyte = staffBioTable.Rows(0)("image")
        PictureBox1.Image = Image.FromStream(New MemoryStream(pixbyte))
        pixbyte = Nothing
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If test_resulttxt.Text = "" Or lab_officer_remarkstxt.Text = "" Or searchtxt.Text = "" Then
            MsgBox("Please fill all the required fields", MsgBoxStyle.Critical)
        Else
            If doctor_requesttxt.Text = "" Then
                MsgBox("Please ! the patient Should see Doctor first", MsgBoxStyle.Critical)
            Else
                txtreceipt.Text = " "
                txtreceipt.AppendText(" " + vbNewLine)
                txtreceipt.AppendText("The LAUTECH Teaching Hospital Osogbo, Osun State" + vbNewLine)
                txtreceipt.AppendText(" =================================" + vbNewLine)
                txtreceipt.AppendText(" LAB. OFFICER REPORT AND TREATMENT             " + vbNewLine)
                txtreceipt.AppendText(" =================================" + vbNewLine)
                txtreceipt.AppendText(" Lab.Officer ID : " & employee_idtxt.Text & vbNewLine)
                txtreceipt.AppendText(" Patient Names : " & nametxt.Text & vbNewLine)
                txtreceipt.AppendText(" Health care No : " & searchtxt.Text & vbNewLine)
                txtreceipt.AppendText(" Test Request : " & doctor_requesttxt.Text & vbNewLine)
                txtreceipt.AppendText(" Test Result : " & test_resulttxt.Text & vbNewLine)
                txtreceipt.AppendText(" Remarks : " & lab_officer_remarkstxt.Text & vbNewLine)
                txtreceipt.AppendText(" " + vbNewLine)
                txtreceipt.AppendText(" " + vbNewLine)
                txtreceipt.AppendText("=================================" + vbNewLine)
                txtreceipt.AppendText(vbTab & Today & vbTab & TimeOfDay + vbNewLine)
                txtreceipt.AppendText("=================================" + vbNewLine)
                txtreceipt.AppendText("HEALTH IS WEALTH...STAY CLEAN STAY HEALTHY" + vbNewLine)
                txtreceipt.AppendText("=================================" + vbNewLine)
                Save.Enabled = True
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = landingpage
    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        If searchtxt.Text <> "" Then
            healthcare_no = searchtxt.Text
            Try
                patientBioTable = getrecordtable("select * from patient_biodata where healthcare_no='" & healthcare_no & "'")
                patientMedTable = getrecordtable("select * from treatments where healthcare_no='" & healthcare_no & "'and status='Treated' order by treatment_date desc")
                If patientBioTable.Rows.Count = 0 Then
                    MsgBox("Check the Healthcare_No very well is seems it does not exist !", MsgBoxStyle.Critical)
                Else
                    Dim firstname As String = patientBioTable.Rows(0)("first_name").ToString
                    Dim othername As String = patientBioTable.Rows(0)("other_name").ToString
                    Dim lastname As String = patientBioTable.Rows(0)("last_name").ToString
                    nametxt.Text = lastname & " " & firstname & " " & othername
                    gendertxt.Text = patientBioTable.Rows(0)("gender").ToString
                    agetxt.Text = patientBioTable.Rows(0)("age").ToString
                    pixbyte = patientBioTable.Rows(0)("image")
                    PictureBox2.Image = Image.FromStream(New MemoryStream(pixbyte))
                    pixbyte = Nothing
                    If patientMedTable.Rows.Count = 0 Then
                        MsgBox("Patient with Healthcare_No : " & healthcare_no & "does not have any Medical Records Let Him or Her Go visit Doctor First", MsgBoxStyle.Information)
                    Else
                        doctor_requesttxt.Text = patientMedTable.Rows(0)("lab_test_request").ToString
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("Please enter Healthcare_No of the Patient and Search again", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If test_resulttxt.Text = "" Or lab_officer_remarkstxt.Text = "" Or searchtxt.Text = "" Or nametxt.Text = "" Then
            MsgBox("Please fill all the required fields", MsgBoxStyle.Critical)
        Else
            If doctor_requesttxt.Text = "" Then
                MsgBox("Please ! the patient Should see Doctor first", MsgBoxStyle.Critical)
            Else
                savelab_officertask()
                Dim id As Integer = patientMedTable.Rows(0)("id")
                updateMedlabOfficerSummary(id)
                searchtxt.Text = ""
                lab_officer_remarkstxt.Text = ""
                doctor_requesttxt.Text = ""
                test_resulttxt.Text = ""
                nametxt.Text = ""
                agetxt.Text = ""
                gendertxt.Text = ""
                PictureBox2.Image = Nothing
                txtreceipt.Text = ""
                Save.Enabled = False
            End If

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim x = MsgBox("Are you sure you want to SignOut ?", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            login.Show()
            Me.Close()
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
End Class