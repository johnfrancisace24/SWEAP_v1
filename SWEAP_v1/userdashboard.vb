﻿Imports System.Diagnostics.Eventing
Imports System.IO
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        Dim locateProject As String = My.Application.Info.DirectoryPath
        Dim indext As Integer = locateProject.IndexOf("bin\Debug\net6.0-windows")
        Dim location As String = locateProject.Substring(0, indext)
        Dim destinationPath As String = location & "\Resources"
        Dim pathCatcher As String
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT CONCAT(first_name, ' ', middle_name, ' ', last_name) AS fullName, * FROM user WHERE id=@ID", conn)
            cmd.Parameters.AddWithValue("@ID", Form1.log_id)
            dr = cmd.ExecuteReader
            While dr.Read
                lblFname.Text = dr.GetString("fullName")
                'pathCatcher = dr.GetString("image")
                'lblpostion.Text = dr.GetString("position")
                'userTxt.Text = dr.GetString("username")
                ' passTxt.Text = dr.GetString("password")
                'addTxt.Text = dr.GetString("address")
                'posTxt.Text = dr.GetString("position")

            End While
        Catch ex As Exception
            MsgBox("doesn't wokr lmao2")
        Finally
            conn.Close()
        End Try
        'imgProfile.BackgroundImage = Image.FromFile(destinationPath & pathCatcher)
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class