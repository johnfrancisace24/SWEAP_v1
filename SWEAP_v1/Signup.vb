Imports System.IO
Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class Signup
    Dim cnstr As String = "server=172.30.206.81;user=sweapp;password=druguser;database=sweap;port=3306"
    Dim conn As New MySqlConnection(cnstr)
    Dim rid As MySqlDataReader
    Dim str As String
    Dim sourceFilePath As String


    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Form1.Show()
    End Sub


    'Pic Uploading
    Dim imgpath As String
    Dim arrimage() As Byte
    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        ' Dim imageInput As String
        ' Dim locateProject As String = My.Application.Info.DirectoryPath
        ' Dim indext As Integer = locateProject.IndexOf("bin\Debug\net6.0-windows")
        ' Dim location As String = locateProject.Substring(0, indext)
        ' MsgBox(locateProject)
        ' MsgBox(location)
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.jpg; *.png; *.gif) | * .jpg; *.png; *.gif"
        'opf.InitialDirectory = "C:\"
        If opf.ShowDialog = DialogResult.OK Then
            'imageInput = System.IO.Path.GetFullPath(opf.FileName)
            sourceFilePath = System.IO.Path.GetFullPath(opf.FileName)
            pBoxCreateProfile.BackgroundImage = System.Drawing.Image.FromFile(sourceFilePath)
        End If


        ' Dim destinationPath As String = location & "\Resources\" & txtCreateUsername.Text & Path.GetExtension(opf.FileName)
        ' File.Copy(sourceFilePath, destinationPath, True)
        ' MsgBox("File saved to " & destinationPath)
        ' MessageBox.Show("File transferred successfully.")

    End Sub

    Private Sub ButtonReg_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If (txtFname.Text = "" Or txtLname.Text = "") Then
            MsgBox("Fields can't be blank.")
        Else
            '-------------------------SAVE PROFILE---------------------------------------
            Dim locateProject As String = My.Application.Info.DirectoryPath
            Dim indext As Integer = locateProject.IndexOf("bin\Debug\net6.0-windows")
            Dim location As String = locateProject.Substring(0, indext)
            MsgBox(locateProject)
            MsgBox(location)
            Dim opf As New OpenFileDialog


            Dim destinationPath As String = location & "\Resources\" & txtCreateUsername.Text & Path.GetExtension(opf.FileName)
            File.Copy(sourceFilePath, destinationPath, True)
            MsgBox("File saved to " & destinationPath)
            MessageBox.Show("File transferred successfully.")
            '------------------------------------------------------------
            Dim imageInput As String = txtCreateUsername.Text & Path.GetExtension(opf.FileName)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO user(username, password, first_name, middle_name, last_name, address, contact, email, educational, 
                                                bdate, is_admin, office, position, employment_status, committee, image, created_at, updated_at) VALUES(@UNAME, @PW, @FNAME, 
                                             @MNAME, @LNAME, @ADRS, @CONTACT, @EMAIL, @EDUC, @BDAY, @ISADMIN, @OFFICE, @POSITION, @EMSTAT, @COMITEE, @IMG, NOW(), NOW())", conn)
                cmd.Parameters.AddWithValue("@UNAME", txtCreateUsername.Text)
                cmd.Parameters.AddWithValue("@PW", txtCreatePw.Text)
                cmd.Parameters.AddWithValue("@FNAME", txtFname.Text)
                cmd.Parameters.AddWithValue("@MNAME", txtMname.Text)
                cmd.Parameters.AddWithValue("@LNAME", txtLname.Text)
                cmd.Parameters.AddWithValue("@ADRS", txtAddress.Text)
                cmd.Parameters.AddWithValue("@CONTACT", txtContact.Text)
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                cmd.Parameters.AddWithValue("@EDUC", txtEduc.Text)
                cmd.Parameters.AddWithValue("@BDAY", pickBDate.Value)
                cmd.Parameters.AddWithValue("@ISADMIN", 0)
                cmd.Parameters.AddWithValue("@OFFICE", pickOffice.SelectedItem)
                cmd.Parameters.AddWithValue("@POSITION", pickPosition.SelectedItem)
                'cmd.Parameters.AddWithValue("@SKILLS", txtSkills)
                cmd.Parameters.AddWithValue("@EMSTAT", pickEmStat.SelectedItem)
                cmd.Parameters.AddWithValue("@COMITEE", pickCommittee.SelectedItem)
                cmd.Parameters.AddWithValue("@IMG", imageInput)
                cmd.ExecuteNonQuery()
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

        pickEmStat.Text = ""
        pickCommittee.Text = ""
        txtCreateUsername.Clear()
        txtCreatePw.Clear()
        pBoxCreateProfile.Image = My.Resources.user
    End Sub
End Class