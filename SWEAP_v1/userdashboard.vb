Imports System.Diagnostics.Eventing
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports MySql.Data.MySqlClient

Public Class userdashboard
    Dim co As String = "server=172.30.206.81;port=3306;user=sweapp;password=druguser;database=sweap"
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


    Public Sub flname()
        Try
            conn.Open()

            Dim query As String = "SELECT username, password, address, first_name, middle_name, last_name, position FROM user WHERE id=2"

            Dim cmd As New MySqlCommand(query, conn)

            'cmd.Parameters.AddWithValue("@id", dr.GetString("id"))
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                Dim name As String = (dr.GetString("first_name") + " " + dr.GetString("middle_name") + " " + dr.GetString("last_name"))
                Dim des As String = dr.GetString("position")
                Dim username As String = dr.GetString("username")
                Dim password As String = dr.GetString("password")
                Dim address As String = dr.GetString("Address")
                Dim position As String = dr.GetString("position")
                'Dim pic As String = dr.GetString("")

                fname.Text = name
                designation.Text = des
                userTxt.Text = username
                passTxt.Text = password
                addTxt.Text = address
                posTxt.Text = position
            End If
            MsgBox("Gumana")


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If dr IsNot Nothing Then
                dr.Close()
            End If
            conn.Close()
        End Try

    End Sub

    Public Sub mem()
        conn.Open()
        cmd = New MySqlCommand("SELECT count(*) FROM `user` ", conn)

        Dim count1 = Convert.ToString(cmd.ExecuteScalar)

        cnt.Text = count1
        conn.Close()
    End Sub
    Public Sub DGV_load()

    End Sub
    Private Sub userdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flname()
        mem()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AnswerYes As String
        AnswerYes = MsgBox("Are you sure you want to Exit", vbQuestion + vbYesNo, "User Repsonse")

        If AnswerYes = vbYes Then
            Me.Hide()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class