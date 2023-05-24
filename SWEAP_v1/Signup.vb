Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Signup

    Dim conn As New MySqlConnection
    Dim cnstr As String = "server= 172.30.206.81; user = drugpusher; password= druguser; database = sweap; port=3306"
    Dim cmd As New MySqlCommand
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

    Private Sub ButtonReg_Click(sender As Object, e As EventArgs) Handles ButtonReg.Click

        Try


            conn = New MySqlConnection(cnstr)
            conn.Open()
            str = "insert into register (name, contact, email, office, region, employment_type, status_of_employment, position, designation, username, password ) values (@name,@contact,@email,@office,@region,@emtype,@stat,@pos,@desig,@username,@password)"
            cmd.Connection = conn
            cmd.CommandText = str

            cmd.Parameters.AddWithValue("@name", txtFname.Text)
            cmd.Parameters.AddWithValue("@contact", txtContact.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@office", pickOffice.Text)
            cmd.Parameters.AddWithValue("@region", pickRegion.Text)
            cmd.Parameters.AddWithValue("@emtype", pickEmType.Text)
            cmd.Parameters.AddWithValue("@stat", pickEmStat.Text)
            cmd.Parameters.AddWithValue("@pos", pickPosition.Text)
            cmd.Parameters.AddWithValue("@desig", pickDesignation.Text)
            cmd.Parameters.AddWithValue("@username", txtCreateUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtCreatePw.Text)



            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Account Successfully Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
                Me.Close()
                Form1.Show()
            Else
                MessageBox.Show("Account Cannot be Created!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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