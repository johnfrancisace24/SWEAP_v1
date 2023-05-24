Imports MySql.Data.MySqlClient
Public Class Form1
    Dim test As String = "server=172.30.206.81;port=3306;user=drugpusher;password=druguser;database=sweap"
    Dim conn As New MySqlConnection(test)
    Dim gagi As Integer
    Dim rid As MySqlDataReader
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
        Dim user, pass, status As String

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM user", conn)
            rid = cmd.ExecuteReader
            While rid.Read
                If (txtUser.Text = rid.GetString("username") And txtBoxPass.Text = rid.GetString("password")) Then
                    user = rid.GetString("username")
                    pass = rid.GetString("password")
                End If
            End While
        Catch ex As Exception
            MsgBox("lmao doesn't work")
        Finally
            conn.Close()
        End Try
        If () Then
            AdminDashboard.Show()
        Me.Hide()
    End Sub
End Class
