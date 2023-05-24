Imports MySql.Data.MySqlClient

Public Class userdashboard
    Dim co As String = "server=localhost;port=3306;user=root;password=;database=sweap"
    Dim conn As New MySqlConnection(co)
    Dim cmd As MySqlCommand
    Dim i As Integer
    Dim dr As MySqlDataReader


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel3.Show()
        Panel1.Hide()
        Panel5.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel3.Hide()
        Panel1.Show()
        Panel5.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel5.Show()
        Panel1.Hide()
        Panel3.Hide()

    End Sub

End Class