﻿Imports MySql.Data.MySqlClient
Public Class Form1
    '---------------------------FOR SESSION--------------------------------------------------------
    Public Shared log_id As Integer

    '----------------------------------------------------------------------------------------------

    Dim test As String = "server=172.30.206.156;user=sweapp;password=druguser;database=sweap;port=3306"
    Dim conn As New MySqlConnection(test)
    Dim gagi As Integer
    Dim rid As MySqlDataReader
    Private Sub CheckBoxShow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShow.CheckedChanged
        If CheckBoxShow.Checked = False Then
            txtBoxPass.PasswordChar = "*"
        Else
            txtBoxPass.PasswordChar = ""
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelsignup.LinkClicked
        Me.Hide()
        Signup.Show()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        If (txtUser.Text = "") Then
            MsgBox("Username can't be blank.")
        ElseIf (txtBoxPass.Text = "") Then
            MsgBox("Password can't be blank.")
        Else
            Dim status As Integer = 3
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM user WHERE username=@NAME AND password=@PASS", conn)
                cmd.Parameters.AddWithValue("@NAME", txtUser.Text)
                cmd.Parameters.AddWithValue("@PASS", txtBoxPass.Text)
                rid = cmd.ExecuteReader
                While rid.Read
                    status = rid.GetInt32("is_admin")
                    log_id = rid.GetInt32("id")
                End While
            Catch ex As Exception
                MsgBox("Account doesn't exist.")
            Finally
                conn.Close()
            End Try
            If (status = 1) Then
                AdminDashboard.Show()
                Me.Hide()
            ElseIf (status = 0) Then
                userdashboard.Show()
                Me.Hide()
            Else
                MsgBox("Invalid username or passowrd.")
            End If
        End If


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
