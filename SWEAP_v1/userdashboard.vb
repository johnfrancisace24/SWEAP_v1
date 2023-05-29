Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports MySql.Data.MySqlClient

Public Class userdashboard
    Dim co As String = "server=127.0.0.1;user=sweapp;password=druguser;database=sweap;port=3306"
    Dim conn As New MySqlConnection(co)
    Dim cmd As MySqlCommand
    Dim i As Integer
    Dim dr As MySqlDataReader


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnprof.Click
        Panel3.Show()
        Panel1.Hide()
        Panel5.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btndash.Click
        Panel1.Show()
        Panel3.Hide()
        Panel5.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Panel5.Show()
        Panel3.Hide()
        Panel1.Hide()
    End Sub

    Public Sub mem()
        'conn.Open()
        'cmd = New MySqlCommand("SELECT count(*) FROM `user` ", conn)

        'Dim count1 = Convert.ToString(cmd.ExecuteScalar)

        'cnt.Text = count1
        'conn.Close()
    End Sub
    Public Sub DGV_load()

    End Sub
    Private Sub userdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mem()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AnswerYes As String
        AnswerYes = MsgBox("Are you sure you want to Exit", vbQuestion + vbYesNo, "User Repsonse")

        If AnswerYes = vbYes Then
            Application.Exit()
        End If
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim AnswerYes As String
        AnswerYes = MsgBox("Are you sure you want to Log out", vbQuestion + vbYesNo, "User Repsonse")

        If AnswerYes = vbYes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `user` SET `username`=@username,`password`=@password,`address`=@address, `position`=@position WHERE `id`=@id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", Form1.log_id)
            cmd.Parameters.AddWithValue("@username", userTxt.Text)
            cmd.Parameters.AddWithValue("@password", passTxt.Text)
            cmd.Parameters.AddWithValue("@address", addTxt.Text)
            cmd.Parameters.AddWithValue("@position", posTxt.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Updated successfully!", "ALERT")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        Dim locateProject As String = My.Application.Info.DirectoryPath
        Dim indext As Integer = locateProject.IndexOf("bin\Debug\net6.0-windows")
        Dim location As String = locateProject.Substring(0, indext)
        Dim destinationPath As String = location & "Resources"
        Dim pathCatcher As String
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("Select *, CONCAT(first_name, ' ', middle_name, ' ', last_name) AS fullName FROM user WHERE id=@ID", conn)
            cmd.Parameters.AddWithValue("@ID", Form1.log_id)
            dr = cmd.ExecuteReader
            If dr.Read() Then
                'imgProfile.Image = Image.FromFile(destinationPath & dr.GetString("username"))
                'Dim data As Byte() = DirectCast(dr("image"), Byte())
                'Dim ms As New MemoryStream(data)
                'imgProfile.Image = Image.FromStream(ms)
                lblFname.Text = dr.GetString("fullName")
                lblpostion.Text = dr.GetString("position")

                txtfname.Text = dr.GetString("fullName")
                txtadd.Text = dr.GetString("address")
                txtcontact.Text = dr.GetString("contact")
                txtemail.Text = dr.GetString("email")
                txteduc.Text = dr.GetString("educational")
                txtbdate.Text = dr.GetString("birthdate")
                txtoffice.Text = dr.GetString("office")
                txtpos.Text = dr.GetString("position")
                txtemploy.Text = dr.GetString("employment_status")
                txtcom.Text = dr.GetString("committee")

                userTxt.Text = dr.GetString("username")
                passTxt.Text = dr.GetString("password")
                addTxt.Text = dr.GetString("address")
                posTxt.Text = dr.GetString("position")

                Dim imagePath As String = dr.GetString("image")
                If Not String.IsNullOrEmpty(imagePath) Then
                    Dim imagePathInResources As String = (destinationPath + imagePath)
                    If File.Exists(imagePathInResources) Then
                        imgProfile.Image = Image.FromFile(imagePathInResources)

                    Else

                        MsgBox(imagePathInResources)
                        MsgBox(destinationPath)
                        ' Handle case when the image file does not exist
                        imgProfile.Image = Nothing ' Set a default image or display a placeholder
                    End If
                Else
                    ' Handle case when the image path is empty or null
                    imgProfile.Image = Nothing ' Set a default image or display a placeholder
                End If
            End If
        Catch ex As Exception
            MsgBox("doesn't wokr lmao2")
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Edit()
    End Sub

    Private Sub lblFname_Click(sender As Object, e As EventArgs) Handles lblFname.Click

    End Sub
End Class