Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Signup
    Dim cnstr As String = "server= 172.30.206.81; user = drugpusher; password= druguser; database = sweap; port=3306"
    Dim conn As New MySqlConnection(cnstr)
    Dim rid As MySqlDataReader
    Dim str As String


    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Hide()
        Form1.Show()
    End Sub


    'Pic Uploading
    Dim imgpath As String
    Dim arrimage() As Byte
    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        Try
            PictureBoxProfile.BackgroundImage = Nothing
            Dim ofd As FileDialog = New OpenFileDialog()
            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

            If ofd.ShowDialog() = DialogResult.OK Then
                imgpath = ofd.FileName
                PictureBoxProfile.ImageLocation = imgpath
            End If
            ofd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ButtonReg_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If (txtFname.Text = "" Or txtLname.Text = "") Then
            MsgBox("Fields can't be blank.")
        Else
            Dim getID As Integer
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO user(username, password, email, created_at, updated_at)
                                            VALUES(@NAME, @PW, @EMAIL, NOW(), NOW()", conn)
                Dim cmd2 As New MySqlCommand("SELECT * FROM user WHERE username=@USERNAME", conn)
                Dim cmd3 As New MySqlCommand("INSERT INTO user_info(user_id, first_name, last_name)VALUES(@UID, @FNAME, @LNAME)", conn)
                cmd.Parameters.AddWithValue("@NAME", txtCreateUsername.Text)
                cmd.Parameters.AddWithValue("@PW", txtCreatePw.Text)
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                cmd.ExecuteNonQuery()
                cmd2.Parameters.AddWithValue("@USERNAME", txtCreateUsername.Text)

                rid = cmd2.ExecuteReader
                While rid.Read
                    getID = rid.GetInt32("id")
                End While
                cmd3.Parameters.AddWithValue("@UID", getID)
                cmd3.Parameters.AddWithValue("FNAME", txtFname.Text)
                cmd3.Parameters.AddWithValue("@LNAME", txtLname.Text)
                cmd3.ExecuteNonQuery()
                MsgBox("successfully added")
            Catch ex As Exception
                MsgBox("Doesn't work lmao.")
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Sub clear()
        txtFname.Clear()
        txtContact.Clear()
        txtEmail.Clear()
        pickOffice.Text = ""
        pickPosition.Text = ""
        pickEmType.Text = ""
        pickRegion.Text = ""
        pickEmStat.Text = ""
        pickDesignation.Text = ""
        txtCreateUsername.Clear()
        txtCreatePw.Clear()
        PictureBoxProfile.Image = My.Resources.user
    End Sub


End Class