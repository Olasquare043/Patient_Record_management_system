Imports System.IO

Public Class nurse_dashboard
    Dim ola As Integer
    Dim msg As String
    Public loggedInUser As String = ""
    Public userID As String = "nurse_dashboard"
    Dim patientBioTable As New DataTable
    Dim healthcare_no As String = ""
    Dim pixbyte() As Byte = Nothing
    Dim staffBioTable As New DataTable


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

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = landingpage
    End Sub

    Private Sub CheckPatientToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = check_patient
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ola += 1
        TextBox1.Text += msg.Substring(ola - 1, 1)
        If ola = msg.Length Then
            Timer2.Enabled = False
        End If
    End Sub
    Private Sub HOMEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Timer1.Enabled = True
        If Timer2.Enabled = True Then
            Timer2.Enabled = False
        End If
        TabControl1.SelectedTab = landingpage
    End Sub

    Private Sub AboutSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSystemToolStripMenuItem.Click
        TabControl1.SelectedTab = About
        ola = 0
        msg = TextBox1.Text
        TextBox1.Text = " "
        Timer2.Enabled = True
        TabControl1.SelectedTab = About
    End Sub

    Private Sub nurse_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PRMSdatabaseDataSet.patient_biodata' table. You can move, or remove it, as needed.
        Me.Patient_biodataTableAdapter.Fill(Me.PRMSdatabaseDataSet.patient_biodata)
        'TODO: This line of code loads data into the 'PRMSdatabaseDataSet.nurse_checkups' table. You can move, or remove it, as needed.
        Me.Nurse_checkupsTableAdapter.Fill(Me.PRMSdatabaseDataSet.nurse_checkups)
        loggedInUser = login.loggedInUser
        login.Close()
        staffBioTable = getrecordtable("select * from staff_biodata where employee_id='" & loggedInUser & "'")
        Dim firstname As String = staffBioTable.Rows(0)("first_name").ToString
        Dim othername As String = staffBioTable.Rows(0)("other_name").ToString
        Dim lastname As String = staffBioTable.Rows(0)("last_name").ToString
        Nursenametxt.Text = lastname + " " + firstname.First.ToString.ToUpper + "." + othername.First.ToString.ToUpper
        nursephonetxt.Text = staffBioTable.Rows(0)("phone").ToString
        employee_idtxt.Text = staffBioTable.Rows(0)("employee_id").ToString
        pixbyte = staffBioTable.Rows(0)("image")
        nursepix.Image = Image.FromStream(New MemoryStream(pixbyte))
        pixbyte = Nothing
    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        If searchtxt.Text <> "" Then
            healthcare_no = searchtxt.Text
            Try
                patientBioTable = getrecordtable("select * from patient_biodata where healthcare_no='" & healthcare_no & "'")
                If patientBioTable.Rows.Count = 0 Then
                    MsgBox("Check the Healthcare_No very well is seems it does not exist !", MsgBoxStyle.Critical)
                Else
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
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("Please enter Healthcare_No of the Patient and Search again", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If nametxt.Text = "" Or searchtxt.Text = "" Then
            MsgBox("Kindly enter Healthcare_No and search first", MsgBoxStyle.Information)
        Else
            If heighttxt.Text = "" Or weighttxt.Text = "" Or bptxt.Text = "" Or temperaturetxt.Text = "" Or respiratorytxt.Text = "" Then
                MsgBox("Kindly enter the Vital signs First", MsgBoxStyle.Information)
            Else
                txtreceipt.Text = " "
                txtreceipt.AppendText(" " + vbNewLine)
                txtreceipt.AppendText("The LAUTECH Teaching Hospital Osogbo, Osun State" + vbNewLine)
                txtreceipt.AppendText(" =================================" + vbNewLine)
                txtreceipt.AppendText("NURSE CHECKUP AND TREATMENT             " + vbNewLine)
                txtreceipt.AppendText(" =================================" + vbNewLine)
                txtreceipt.AppendText(" Nurse ID : " & employee_idtxt.Text & vbNewLine)
                txtreceipt.AppendText(" Patient Names : " & nametxt.Text & vbNewLine)
                txtreceipt.AppendText(" Health care No : " & searchtxt.Text & vbNewLine)
                txtreceipt.AppendText(" Height : " & heighttxt.Text & vbNewLine)
                txtreceipt.AppendText(" weight : " & weighttxt.Text & vbNewLine)
                txtreceipt.AppendText(" BMI : " & bmitxt.Text & vbNewLine)
                txtreceipt.AppendText(" Temperature : " & temperaturetxt.Text & vbNewLine)
                txtreceipt.AppendText(" Respiratory Rate : " & respiratorytxt.Text & vbNewLine)
                txtreceipt.AppendText(" Blood Pressure : " & bptxt.Text & vbNewLine)
                txtreceipt.AppendText(" " + vbNewLine)
                txtreceipt.AppendText(" " + vbNewLine)
                txtreceipt.AppendText("=================================" + vbNewLine)
                txtreceipt.AppendText(vbTab & Today & vbTab & TimeOfDay + vbNewLine)
                txtreceipt.AppendText("=================================" + vbNewLine)
                txtreceipt.AppendText("HEALTH IS WEALTH...STAY CLEAN STAY HEALTHY" + vbNewLine)
                txtreceipt.AppendText("=================================" + vbNewLine)
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles heighttxt.TextChanged
        If IsNumeric(heighttxt.Text) Then
            If Val(heighttxt.Text) <> 0 Or heighttxt.Text <> "" Then
                Dim bmi As Double = Val(weighttxt.Text) / (Val(heighttxt.Text) * Val(heighttxt.Text))
                bmitxt.Text = FormatNumber(bmi)
            End If
        ElseIf heighttxt.Text = "" Then
        Else
            MsgBox("Height is Numerics not Letters", MsgBoxStyle.Critical)
            heighttxt.Text = ""
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TabControl1.SelectedTab = landingpage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If nametxt.Text = "" Or searchtxt.Text = "" Then
            MsgBox("Kindly enter Healthcare_No and search first", MsgBoxStyle.Information)
        Else
            saveNurseCheckup()
            nametxt.Text = ""
            occupationtxt.Text = ""
            gendertxt.Text = ""
            agetxt.Text = ""
            phonetxt.Text = ""
            emailtxt.Text = ""
            maritaltxt.Text = ""
            addresstxt.Text = ""
            religiontxt.Text = ""
            blood_group.Text = ""
            genotype.Text = ""
            heighttxt.Text = ""
            weighttxt.Text = ""
            bmitxt.Text = ""
            temperaturetxt.Text = ""
            respiratorytxt.Text = ""
            bptxt.Text = ""
            profpix.Image = Nothing
            searchtxt.Text = ""
            txtreceipt.Text = ""
            Button1.Enabled = False
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

    Private Sub weighttxt_Leave(sender As Object, e As EventArgs) Handles weighttxt.Leave
        If weighttxt.Text <> "" Then
            weighttxt.Text = FormatNumber(weighttxt.Text)
        End If

    End Sub

    Private Sub heighttxt_Leave(sender As Object, e As EventArgs) Handles heighttxt.Leave
        If heighttxt.Text <> "" Then
            heighttxt.Text = FormatNumber(heighttxt.Text)
        End If

    End Sub

    Private Sub weighttxt_TextChanged(sender As Object, e As EventArgs) Handles weighttxt.TextChanged
        If IsNumeric(weighttxt.Text) Then

        ElseIf weighttxt.Text = "" Then
        Else
            MsgBox("Weight is Numerics not Letters", MsgBoxStyle.Critical)
            weighttxt.Text = ""
        End If
    End Sub

    Private Sub bptxt_TextChanged(sender As Object, e As EventArgs) Handles bptxt.TextChanged
        If IsNumeric(bptxt.Text) Then

        ElseIf bptxt.Text = "" Then
        Else
            MsgBox("Blood Pressure is Numerics not Letters", MsgBoxStyle.Critical)
            bptxt.Text = ""
        End If
    End Sub

    Private Sub temperaturetxt_TextChanged(sender As Object, e As EventArgs) Handles temperaturetxt.TextChanged
        If IsNumeric(temperaturetxt.Text) Then

        ElseIf temperaturetxt.Text = "" Then
        Else
            MsgBox("Temperature is Numerics not Letters", MsgBoxStyle.Critical)
            temperaturetxt.Text = ""
        End If
    End Sub

    Private Sub respiratorytxt_TextChanged(sender As Object, e As EventArgs) Handles respiratorytxt.TextChanged
        If IsNumeric(respiratorytxt.Text) Then

        ElseIf respiratorytxt.Text = "" Then
        Else
            MsgBox("Respiratory Rate is Numerics not Letters", MsgBoxStyle.Critical)
            respiratorytxt.Text = ""
        End If

    End Sub

    Private Sub CheckPatientToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CheckPatientToolStripMenuItem.Click
        TabControl1.SelectedTab = check_patient
    End Sub

    Private Sub ListOfPatientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfPatientsToolStripMenuItem.Click
        Nurse_checkupsBindingSource.Filter = "employee_id='" & employee_idtxt.Text & "'"
        TabControl1.SelectedTab = list_of_patients
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        Patient_biodataBindingSource.Filter = "'healthcare_no='" & TextBox18.Text & "'"
        TextBox19.Text = Last_nameLabel1.Text & " " & First_nameLabel1.Text & " " & Last_nameLabel1.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Nurse_checkupsBindingSource.Filter = "status='" & ComboBox1.SelectedItem & "'"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Nurse_checkupsBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Nurse_checkupsBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Nurse_checkupsBindingSource.RemoveFilter()
    End Sub
End Class