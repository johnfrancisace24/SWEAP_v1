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
        ' Dim imageInput As String
        Dim locateProject As String = Path.GetDirectoryName(Application.StartupPath)
        Dim opf As New OpenFileDialog
        Dim sourceFilePath As String
        opf.Filter = "Choose Image(*.jpg; *.png; *.gif) | * .jpg; *.png; *.gif"
        'opf.InitialDirectory = "C:\"
        If opf.ShowDialog = DialogResult.OK Then
            'imageInput = System.IO.Path.GetFullPath(opf.FileName)
            sourceFilePath = System.IO.Path.GetFullPath(opf.FileName)
            pBoxCreateProfile.BackgroundImage = System.Drawing.Image.FromFile(sourceFilePath)
        End If
        Dim destinationPath As String = locateProject & "\" & txtCreateUsername.Text & Path.GetExtension(opf.FileName)

        File.Copy(sourceFilePath, destinationPath, True)
        MsgBox("File saved to " & destinationPath)
        MessageBox.Show("File transferred successfully.")

    End Sub

    Private Sub ButtonReg_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If (txtFname.Text = "" Or txtLname.Text = "") Then
            MsgBox("Fields can't be blank.")
        Else
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO user(username, password, first_name, last_name, contact, email, is_admin, create_at, updated_at) VALUES(@UNAME, @PW, @FNAME, 
                                             @LNAME, @CONTACT, @EMAIL, @ISADMIN, NOW(), NOW())", conn)
                cmd.Parameters.AddWithValue("@UNAME", txtCreateUsername.Text)
                cmd.Parameters.AddWithValue("@PW", txtCreatePw.Text)
                cmd.Parameters.AddWithValue("@FNAME", txtFname.Text)
                cmd.Parameters.AddWithValue("@LNAME", txtLname.Text)
                cmd.Parameters.AddWithValue("@CONTACT", txtContact.Text)
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                'cmd.Parameters.AddWithValue("@OFFICE", pickOffice.SelectedValue)
                'cmd.Parameters.AddWithValue("@REGION", txtCreateUsername.Text)
                'cmd.Parameters.AddWithValue("@EMTYPE", txtCreateUsername.Text)
                'cmd.Parameters.AddWithValue("@EMSTAT", txtCreateUsername.Text)
                'cmd.Parameters.AddWithValue("@POSITION", txtCreateUsername.Text)
                ' cmd.Parameters.AddWithValue("@DESIGNATION", txtCreateUsername.Text)
                'cmd.Parameters.AddWithValue("@IMG", txtCreateUsername.Text)
                cmd.Parameters.AddWithValue("@ISADMIN", 0)
                MsgBox("successfully added")
                Me.Hide()
                Form1.Show()
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
        pBoxCreateProfile.Image = My.Resources.user
    End Sub


End Class