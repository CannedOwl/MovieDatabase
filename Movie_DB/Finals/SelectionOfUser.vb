Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx


Public Class SelectionOfUser

    Private Sub SelectionOfUser_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TabPage.Appearance = TabAppearance.FlatButtons
            TabPage.ItemSize = New Size(0, 1)
            TabPage.SizeMode = TabSizeMode.Fixed

        Catch ex As Exception

        End Try

        'Viewgenre()
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, BtnProfile.Click
        Try
            Dim MyButton = DirectCast(sender, Button)

            Select Case MyButton.Name
                Case "Button1"
                    TabPage.SelectedTab = homeTab
                Case "Button2"
                    TabPage.SelectedTab = exploreTab
                Case "BtnProfile"
                    TabPage.SelectedTab = TabProfile
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        LoginPage.Show()
        LoginPage.Focus()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SearchData()
    End Sub

    Sub SearchData()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet
        Dim mtitle As String = TextBox1.Text

        myConnection1 = Common.getDBConnectionX()

        Try

            myConnection1.Open()
            myCommand1 = New MySqlCommand("SELECT title, year, genre FROM tblmovie WHERE title LIKE '" & (mtitle) & "%'", myConnection1)

            myAdapter2.SelectCommand = myCommand1
            myAdapter2.Fill(myDataSet2, "myData")
            'ito yung name nung tool
            DataGridView1.DataSource = myDataSet2.Tables("myData")

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try

    End Sub


    Sub ViewData()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet
        Dim mtitle As String = TextBox1.Text

        myConnection1 = Common.getDBConnectionX()

        Try

            myConnection1.Open()
            myCommand1 = New MySqlCommand("SELECT title, year, genre FROM tblmovie", myConnection1)

            myAdapter2.SelectCommand = myCommand1
            myAdapter2.Fill(myDataSet2, "myData")
            'ito yung name nung tool
            DataGridView1.DataSource = myDataSet2.Tables("myData")

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try

    End Sub

    'MAY CONFLICT BUG PAGDATING SA ViewYear() Function
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'Viewgenre()

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        'ViewYear()
    End Sub


    Private Sub BtnFilter_Click(sender As Object, e As EventArgs) Handles BtnFilter.Click
        Dim selectedGenre As String = ListBox1.GetItemText(ListBox1.SelectedItem)
        Dim selectedYear As String = ListBox2.SelectedItem?.ToString()

        If Not String.IsNullOrEmpty(selectedGenre) And Not String.IsNullOrEmpty(selectedYear) Then
            ' Both genre and release date are selected
            DisplayMoviesByGenreAndSelectedYear(selectedGenre, selectedYear)
        ElseIf Not String.IsNullOrEmpty(selectedGenre) Then
            ' Only genre is selected
            DisplayMoviesByGenre(selectedGenre)
        ElseIf Not String.IsNullOrEmpty(selectedYear) Then
            ' Only release date is selected
            DisplayMoviesByReleaseDate(selectedYear)
        End If
    End Sub


    Private Sub DisplayMoviesByGenreAndSelectedYear(genre As String, selectedYear As String)



        Dim query As String = "SELECT * FROM tblmovie WHERE genre LIKE @genre AND year LIKE @selectedYear"
        DisplayMovies(query, "%" & genre & "%", "%" & selectedYear & "%")
    End Sub

    Private Sub DisplayMoviesByGenre(genre As String)
        Dim query As String = "SELECT * FROM tblmovie WHERE genre like @genre"
        DisplayMovies(query, "%" & genre & "%")
    End Sub

    Private Sub DisplayMoviesByReleaseDate(selectedYear As String)
        Dim query As String = "SELECT * FROM tblmovie WHERE release_date LIKE @selectedYear"
        DisplayMovies(query, "%" & selectedYear & "%")
    End Sub

    Private Sub DisplayMovies(query As String, ParamArray parameters() As String)
        Dim myConnection1 As MySqlConnection
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet
        Dim mtitle As String = TextBox1.Text

        myConnection1 = Common.getDBConnectionX()


        Using command As New MySqlCommand(query, myConnection1)
            For i As Integer = 0 To parameters.Length - 1
                command.Parameters.AddWithValue("@" & If(i = 0, "genre", "selectedYear"), parameters(i))
            Next

            Using adapter As New MySqlDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable
            End Using
        End Using
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub






End Class