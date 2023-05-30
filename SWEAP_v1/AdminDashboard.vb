Imports MySql.Data.MySqlClient

Public Class AdminDashboard

    Dim cnstr As String = "server=172.30.206.156;user=sweapp;password=druguser;database=sweap;port=3306"
    Dim conn As New MySqlConnection(cnstr)
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    Public Sub DGV_Load()
        GDataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT *, CONCAT(first_name, ' ', middle_name, ' ', last_name) as Name FROM user", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                GDataGridView1.Rows.Add(dr.Item("Name"), dr.Item("address"), dr.Item("contact"), dr.Item("email"), dr.Item("educational"), dr.Item("birthdate"), dr.Item("office"), dr.Item("position"), dr.Item("employment_status"), dr.Item("committee"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Load()

        Dim locateProject As String = My.Application.Info.DirectoryPath
        Dim indext As Integer = locateProject.IndexOf("bin\Debug\net6.0-windows")
        Dim location As String = locateProject.Substring(0, indext)
        Dim destinationPath As String = location & "Resources"

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("Select *, CONCAT(first_name, ' ', middle_name, ' ', last_name) AS FullName FROM user WHERE id=@ID", conn)
            cmd.Parameters.AddWithValue("@ID", Form1.log_id)
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Dim imagePath As String = dr.GetString("image")
                Dim imagePathInResources As String = (destinationPath + imagePath)
                GimgProfile.BackgroundImage = Image.FromFile(imagePathInResources)
                lblFllname.Text = dr.GetString("FullName")
                lblPos.Text = dr.GetString("position")
            End If
        Catch ex As Exception
            MsgBox("doesn't wokr lmao2")
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        pnlDashboard.Show()
        pnlList.Hide()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        pnlList.Show()
        pnlDashboard.Hide()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim AnswerYes As String
        AnswerYes = MsgBox("Are you sure you want to Log out", vbQuestion + vbYesNo, "User Repsonse")

        If AnswerYes = vbYes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub lblPos_Click(sender As Object, e As EventArgs) Handles lblPos.Click

    End Sub
End Class