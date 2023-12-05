﻿Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class LoginPage


    Private Sub txtbxpassword_TextChanged(sender As Object, e As EventArgs) Handles txtbxpassword.TextChanged
        txtbxpassword.PasswordChar = "●"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' If the checkbox is checked, show the password
            txtbxpassword.PasswordChar = ControlChars.NullChar ' Set to null to show actual characters
        Else
            ' If the checkbox is unchecked, hide the password
            txtbxpassword.PasswordChar = "●"
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        login()
    End Sub


    'Login Function'
    Sub login()
        Dim username As String = userTxtbx.Text
        Dim password As String = txtbxpassword.Text
        Dim myConnectionx As MySqlConnection
        Dim myCommandx As MySqlCommand

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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ' Create an instance of Form2
        Dim register As New CreateAccount()

        ' Show Form2
        register.Show()
    End Sub


End Class