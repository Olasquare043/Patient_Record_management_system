Imports System.IO
Public Class Adminpage
    Dim filepath As String = ""
    Public picbytes() As Byte = Nothing
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Me.TreatmentsTableAdapter.Fill(Me.PRMSdatabaseDataSet.treatments)
        reportstatxt.Text = TreatmentsBindingSource.Count
        Me.Staff_biodataTableAdapter.Fill(Me.PRMSdatabaseDataSet.staff_biodata)
        all_staff_contxt.Text = Staff_biodataBindingSource.Count
        Staff_biodataBindingSource.Filter = "specialization='doctor'"
        doctor_countxt.Text = Staff_biodataBindingSource.Count
        Staff_biodataBindingSource.Filter = "specialization='nurse'"
        nurse_countxt.Text = Staff_biodataBindingSource.Count
        Staff_biodataBindingSource.Filter = "specialization='lab_officer'"
        labofficer_countxt.Text = Staff_biodataBindingSource.Count
        Staff_biodataBindingSource.Filter = "specialization='record_officer'"
        recordofficer_countxt.Text = Staff_biodataBindingSource.Count
        Staff_biodataBindingSource.Filter = "specialization='pharmacist'"
        pharmacist_countxt.Text = Staff_biodataBindingSource.Count
        Staff_biodataBindingSource.RemoveFilter()
        Me.Patient_biodataTableAdapter.Fill(Me.PRMSdatabaseDataSet.patient_biodata)
        all_patient_countxt.Text = Patient_biodataBindingSource.Count
        TabControl1.SelectedTab = landing_page
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TabControl1.SelectedTab = all_patient
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TabControl1.SelectedTab = All_staff
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Employee_idtxt.Text = IDgen()
        TabControl1.SelectedTab = New_Staff
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TabControl1.SelectedTab = medical_history
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TabControl1.SelectedTab = report
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using OpenFileDialog As New OpenFileDialog
            OpenFileDialog.Filter = "select your picture (*.png,*.jpg,*.jpeg)|*.png;*.jpg;*.jpeg"
            If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox2.ImageLocation = OpenFileDialog.FileName
                filepath = OpenFileDialog.FileName
                picbytes = File.ReadAllBytes(filepath)
            End If
        End Using
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = landing_page
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If picbytes Is Nothing Or firstnametxt.Text = "" Or othernametxt.Text = "" Or lastnametxt.Text = "" Or phonetxt.Text = "+234" Or addresstxt.Text = "" Or religoncmb.Text = "" Or maritalcmb.Text = "" Or specializecmb.Text = "" Or agecmb.Text = "" Or Employee_idtxt.Text = "" Or emailtxt.Text = "" Or gendercmb.Text = "" Or nokaddresstxt.Text = "" Or noktxt.Text = "" Or bloodgpcmb.Text = "" Or genotypecmb.Text = "" Then
            MsgBox("Please upload your Profile picture and fill all the Fields", MsgBoxStyle.Information)
        Else
            staffreg()

            firstnametxt.Text = ""
            othernametxt.Text = ""
            lastnametxt.Text = ""
            specializecmb.SelectedItem = Nothing
            agecmb.SelectedItem = Nothing
            Employee_idtxt.Text = ""
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
            PictureBox2.ImageLocation = Nothing
            Employee_idtxt.Text = IDgen()
            picbytes = Nothing
        End If
    End Sub

    Private Sub Adminpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HistoryTableAdapter.Fill(Me.PRMSdatabaseDataSet.history)
        Staff_biodataBindingSource.RemoveFilter()
        TreatmentsBindingSource.RemoveFilter()
        Patient_biodataBindingSource.RemoveFilter()
        Me.TreatmentsTableAdapter.Fill(Me.PRMSdatabaseDataSet.treatments)
        reportstatxt.Text = TreatmentsBindingSource.Count
        Me.Staff_biodataTableAdapter.Fill(Me.PRMSdatabaseDataSet.staff_biodata)
        all_staff_contxt.Text = Staff_biodataBindingSource.Count
        Staff_biodataBindingSource.Filter = "specialization='doctor'"
        doctor_countxt.Text = Staff_biodataBindingSource.Count
        Staff_biodataBindingSource.Filter = "specialization='nurse'"
        nurse_countxt.Text = Staff_biodataBindingSource.Count
        Staff_biodataBindingSource.Filter = "specialization='lab_officer'"
        labofficer_countxt.Text = Staff_biodataBindingSource.Count
        Staff_biodataBindingSource.Filter = "specialization='record_officer'"
        recordofficer_countxt.Text = Staff_biodataBindingSource.Count
        Staff_biodataBindingSource.Filter = "specialization='pharmacist'"
        pharmacist_countxt.Text = Staff_biodataBindingSource.Count
        Staff_biodataBindingSource.RemoveFilter()
        Me.Patient_biodataTableAdapter.Fill(Me.PRMSdatabaseDataSet.patient_biodata)
        all_patient_countxt.Text = Patient_biodataBindingSource.Count
        login.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim x = MsgBox("Are you sure you want to SignOut ?", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            login.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Patient_biodataBindingSource.MovePrevious()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Patient_biodataBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Patient_biodataBindingSource.Filter = "gender='" & ComboBox1.SelectedItem & "'"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Patient_biodataBindingSource.Filter = "last_name='" & TextBox21.Text & "'"

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Patient_biodataBindingSource.Filter = "healthcare='" & TextBox22.Text & "'"

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Staff_biodataBindingSource.Filter = "specialization='" & ComboBox2.SelectedItem & "'"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Staff_biodataBindingSource.Filter = "employee_id='" & TextBox13.Text & "'"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Staff_biodataBindingSource.Filter = "employee_id='" & TextBox12.Text & "'"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Staff_biodataBindingSource.MoveNext()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Staff_biodataBindingSource.MovePrevious()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TreatmentsBindingSource.Filter = "health_care='" & TextBox23.Text & "'"
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Staff_biodataBindingSource.RemoveFilter()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Patient_biodataBindingSource.RemoveFilter()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        HistoryBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        HistoryBindingSource.MoveNext()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        HistoryBindingSource.Filter = "healthcare_no='" & TextBox31.Text & "'"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        HistoryBindingSource.RemoveFilter()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        TreatmentsBindingSource.RemoveFilter()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TreatmentsBindingSource.MovePrevious()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TreatmentsBindingSource.MoveNext()
    End Sub
End Class