Public Class Form1
    Private Sub CheckBoxShow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShow.CheckedChanged
        If CheckBoxShow.Checked = False Then
            txtBoxPass.PasswordChar = "*"
        Else
            txtBoxPass.PasswordChar = ""
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelsignup.LinkClicked
        Me.Hide()
        Signup.Show()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

    End Sub
End Class
