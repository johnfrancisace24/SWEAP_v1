﻿Imports System.Diagnostics.Eventing
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports MySql.Data.MySqlClient

Public Class userdashboard
    Dim co As String = "server=172.30.206.81;port=3306;user=drugpusher;password=druguser;database=sweap"
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
        Panel1.Show()
        Panel3.Hide()
        Panel5.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel5.Show()
        Panel1.Hide()
        Panel3.Hide()

    End Sub


    Public Sub flname()
        Try
            conn.Open()

            Dim query As String = "SELECT first_name, designation  FROM user"

            Dim cmd As New MySqlCommand(query, conn)

            'cmd.Parameters.AddWithValue("@id", dr.GetString("id"))
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                Dim name As String = dr.GetString("first_name")
                Dim des As String = dr.GetString("designation")
                'Dim pic As String = dr.GetString("")
                fname.Text = name
                designation.Text = des
            End If
            MsgBox("Gumana")


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
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
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `user` ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("first_name"), dr.Item("contact"), dr.Item("office"), dr.Item("region"), dr.Item("employment_type"), dr.Item("employment_status"), dr.Item("position"), dr.Item("designation"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub userdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim AnswerYes As String
        AnswerYes = MsgBox("Are you sure you want to Log out", vbQuestion + vbYesNo, "User Repsonse")

        If AnswerYes = vbYes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub fname_Click(sender As Object, e As EventArgs) Handles fname.Click

    End Sub
End Class