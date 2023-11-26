﻿Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class LoginPage

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TxtBxPass.UseSystemPasswordChar = True Then

            ' Hide pass '
            TxtBxPass.UseSystemPasswordChar = False

        Else
            ' Show pass '
            TxtBxPass.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        login()
    End Sub



    Sub login()
        Dim myConnectionx As MySqlConnection
        Dim myCommandx As MySqlCommand
        Dim username As String = userTxtbx.Text
        Dim password As String = TxtBxPass.Text
        myConnectionx = Common.getDBConnectionX()

        myConnectionx.Open()
        myCommandx = New MySqlCommand($"SELECT userName, userPass FROM tblusers WHERE userName = @username AND userPass = @password", myConnectionx)
        myCommandx.Parameters.Add("@username", MySqlDbType.VarChar).Value = username
        myCommandx.Parameters.Add("@password", MySqlDbType.VarChar).Value = password

        Dim adapter As New MySqlDataAdapter(myCommandx)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count = 1 Then

            Me.Hide()
            SelectionOfUser.Show()
            SelectionOfUser.Focus()
        Else
            MessageBox.Show("INVALID USERNAME OR PASSWORD")

        End If

    End Sub




End Class