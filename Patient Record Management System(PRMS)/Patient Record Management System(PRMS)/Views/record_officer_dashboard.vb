Imports System.IO

Public Class record_officer_dashboard
    Dim ola As Integer
    Dim msg As String
    Public loggedInUser As String = ""
    Public userID As String = "record_officer"
    Public pixbytes() As Byte = Nothing
    Dim filepath As String = ""
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
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ola += 1
        TextBox1.Text += msg.Substring(ola - 1, 1)
        If ola = msg.Length Then
            Timer2.Enabled = False
        End If
    End Sub
    Private Sub CheckPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckPatientToolStripMenuItem.Click
        TabControl1.SelectedTab = check_patient
    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Timer1.Enabled = False
        If Timer2.Enabled = True Then
            Timer2.Enabled = False
        End If
        TabControl1.SelectedTab = landingpage
    End Sub
    Private Sub AboutSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSystemToolStripMenuItem.Click
        ola = 0
        msg = TextBox1.Text
        TextBox1.Text = " "
        Timer2.Enabled = True
        TabControl1.SelectedTab = About
    End Sub

    Private Sub NewPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPatientToolStripMenuItem.Click
        healthcarenotxt.Text = IDgen()
        TabControl1.SelectedTab = new_patient
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If pixbytes Is Nothing Or firstnametxt.Text = "" Or othernametxt.Text = "" Or lastnametxt.Text = "" Or phonetxt.Text = "+234" Or addresstxt.Text = "" Or religoncmb.Text = "" Or maritalcmb.Text = "" Or occupationtxt.Text = "" Or agecmb.Text = "" Or employee_idtxt.Text = "" Or emailtxt.Text = "" Or gendercmb.Text = "" Or nokaddresstxt.Text = "" Or noktxt.Text = "" Or bloodgpcmb.Text = "" Or genotypecmb.Text = "" Then
            MsgBox("Please upload your Profile picture and fill all the Fields", MsgBoxStyle.Information)
        Else
            patientreg()
            healthcareno2txt.Text = healthcarenotxt.Text
            firstnametxt.Text = ""
            othernametxt.Text = ""
            lastnametxt.Text = ""
            occupationtxt.Text = ""
            agecmb.SelectedItem = Nothing
            healthcarenotxt.Text = ""
            emailtxt.Text = ""
            gendercmb.SelectedItem = Nothing
            maritalcmb.SelectedItem = Nothing
            nokaddresstxt.Text = ""
            noktxt.Text = ""
            addresstxt.Text = ""
            phonetxt.Text = "+234"
            religoncmb.SelectedItem = Nothing
            bloodgpcmb.SelectedItem = Nothing
            genotypecmb.SelectedItem = Nothing
            PictureBox3.ImageLocation = Nothing
            healthcarenotxt.Text = IDgen()
            pixbytes = Nothing
            healthcarenotxt.Text = IDgen()
            TabControl1.SelectedTab = history_report
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using OpenFileDialog As New OpenFileDialog
            OpenFileDialog.Filter = "select your picture (*.png,*.jpg,*.jpeg)|*.png;*.jpg;*.jpeg"
            If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox3.ImageLocation = OpenFileDialog.FileName
                filepath = OpenFileDialog.FileName
                pixbytes = File.ReadAllBytes(filepath)
            End If
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = landingpage
    End Sub
    Private Sub record_officer_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PRMSdatabaseDataSet.patient_biodata' table. You can move, or remove it, as needed.
        Me.Patient_biodataTableAdapter.Fill(Me.PRMSdatabaseDataSet.patient_biodata)
        loggedInUser = login.loggedInUser
        login.Close()
        staffBioTable = getrecordtable("select * from staff_biodata where employee_id='" & loggedInUser & "'")
        Dim firstname As String = staffBioTable.Rows(0)("first_name").ToString
        Dim othername As String = staffBioTable.Rows(0)("other_name").ToString
        Dim lastname As String = staffBioTable.Rows(0)("last_name").ToString
        record_officertxt.Text = lastname + " " + firstname.First.ToString.ToUpper + "." + othername.First.ToString.ToUpper
        record_officeerphonetxt.Text = staffBioTable.Rows(0)("phone").ToString
        employee_idtxt.Text = staffBioTable.Rows(0)("employee_id").ToString
        pixbytes = staffBioTable.Rows(0)("image")
        PictureBox1.Image = Image.FromStream(New MemoryStream(pixbytes))
        pixbytes = Nothing
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If medicalhstxt.Text = "" Or surgeryhstxt.Text = "" Or allergyhstxt.Text = "" Or dietaryhstxt.Text = "" Or fshstxt.Text = "" Or diagnosishstxt.Text = "" Then
            MsgBox("Please fill all the fields", MsgBoxStyle.Critical)
        Else
            savepatientHS()
            TabControl1.SelectedTab = new_patient
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim x = MsgBox("Note: If you click save, No Medical Histories will be Save for this Patient !.  Have you saved Medical History for this Patient", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            TabControl1.SelectedTab = landingpage
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

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)
        TextBox3.Text = Last_nameTextBox.Text & " " & First_nameTextBox.Text & " " & Other_nameTextBox.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Patient_biodataBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Patient_biodataBindingSource.MoveNext()
    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        Patient_biodataBindingSource.Filter = " healthcare_no='" & searchtxt.Text & "'"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Patient_biodataTableAdapter.Fill(Me.PRMSdatabaseDataSet.patient_biodata)
    End Sub
End Class