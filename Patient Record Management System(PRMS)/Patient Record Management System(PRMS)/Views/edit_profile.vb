Imports System.IO

Public Class edit_profile
    Dim filepath As String = ""
    Public picbytes() As Byte = Nothing
    Public userID As String = ""
    Public loggedInUser As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using OpenFileDialog As New OpenFileDialog
            OpenFileDialog.Filter = "select your picture (*.png,*.jpg,*.jpeg)|*.png;*.jpg;*.jpeg"
            If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                profile_pix.ImageLocation = OpenFileDialog.FileName
                filepath = OpenFileDialog.FileName
                picbytes = File.ReadAllBytes(filepath)
            End If
        End Using
    End Sub

    Private Sub edit_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If doctor_dashboard.userID = userID Then
            loggedInUser = doctor_dashboard.loggedInUser
        ElseIf nurse_dashboard.userID = userID Then
            loggedInUser = nurse_dashboard.loggedInUser
        ElseIf lab_officer_dashboard.userID = userID Then
            loggedInUser = lab_officer_dashboard.loggedInUser
        ElseIf record_officer_dashboard.userID = userID Then
            loggedInUser = record_officer_dashboard.loggedInUser
        ElseIf pharmacist_dashboard.userID = userID Then
            loggedInUser = pharmacist_dashboard.loggedInUser
        End If
    End Sub
End Class