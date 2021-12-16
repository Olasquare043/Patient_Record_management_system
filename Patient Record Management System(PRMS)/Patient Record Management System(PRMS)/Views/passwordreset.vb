Public Class passwordreset

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
            TextBox3.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
            TextBox3.PasswordChar = "*"
        End If
    End Sub
End Class