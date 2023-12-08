Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Data
Imports System.Windows.Forms


Public Class SelectionOfUser
    'Getting the Values from the LoginPage
    Private _username As String

    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property
    Private Sub SelectionOfUser_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TabWatchlist.Appearance = TabAppearance.FlatButtons
            TabWatchlist.ItemSize = New Size(0, 1)
            TabWatchlist.SizeMode = TabSizeMode.Fixed

        Catch ex As Exception

        End Try


    End Sub

    'Side Menu Buttons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, BtnProfile.Click, BtnWtchlst.Click
        Try
            Dim MyButton = DirectCast(sender, Button)

            Select Case MyButton.Name
                Case "Button1"
                    TabWatchlist.SelectedTab = homeTab
                Case "Button2"
                    TabWatchlist.SelectedTab = exploreTab
                Case "BtnProfile"
                    TabWatchlist.SelectedTab = TabProfile
                Case "BtnWatchlst"
                    TabWatchlist.SelectedTab = Watchlist
            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        LoginPage.Show()
        LoginPage.Focus()

    End Sub

    Private Sub BtnSrch_Click(sender As Object, e As EventArgs)
        SearchData()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles BtnSrch.Click
        SearchData()
    End Sub
    'manual data search
    Sub SearchData()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet
        Dim mtitle As String = Guna2TextBox1.Text

        myConnection1 = Common.getDBConnectionX()

        Try

            myConnection1.Open()
            myCommand1 = New MySqlCommand("SELECT title, year, genre FROM tblmovie WHERE title LIKE '" & (mtitle) & "%'", myConnection1)

            myAdapter2.SelectCommand = myCommand1
            myAdapter2.Fill(myDataSet2, "myData")
            'eto magpapashow ng data
            Guna2DataGridView1.DataSource = myDataSet2.Tables("myData")

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try

    End Sub


    'Filter Search
    Private Sub GbtnFS_Click(sender As Object, e As EventArgs) Handles GbtnFS.Click
        Dim selectedGenre As String = ListBox1.GetItemText(ListBox1.SelectedItem)
        Dim selectedYear As String = ListBox2.GetItemText(ListBox2.SelectedItem)

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

    Private Sub DisplayMoviesByGenreAndSelectedYear(selectedGenre As String, selectedYear As String)

        Dim query As String = "SELECT title, genre, year FROM tblmovie WHERE genre LIKE @selectedGenre AND year LIKE @selectedYear"
        DisplayMovies(query, "%" & selectedGenre & "%", selectedYear)
    End Sub

    Private Sub DisplayMoviesByGenre(selectedGenre As String)
        Dim query As String = "SELECT title, genre, year FROM tblmovie WHERE genre LIKE @selectedGenre"
        DisplayMovies(query, "%" & selectedGenre & "%")
    End Sub

    Private Sub DisplayMoviesByReleaseDate(selectedYear As String)
        Dim query As String = "SELECT title, genre, year FROM tblmovie WHERE year LIKE " & selectedYear
        DisplayMovies(query, "%" & selectedYear & "%")
    End Sub

    Private Sub DisplayMovies(query As String, ParamArray parameters() As String)
        Dim myConnection1 As MySqlConnection
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet
        Dim mtitle As String = Guna2TextBox1.Text

        myConnection1 = Common.getDBConnectionX()


        Using command As New MySqlCommand(query, myConnection1)
            For i As Integer = 0 To parameters.Length - 1
                command.Parameters.AddWithValue("@" & If(i = 0, "selectedGenre", "selectedYear"), parameters(i))
            Next

            Using adapter As New MySqlDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                Guna2DataGridView1.DataSource = dataTable
            End Using
        End Using
    End Sub


    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ' Clear selected items in the first ListBox
        ListBox1.ClearSelected()

        ' Clear selected items in the second ListBox
        ListBox2.ClearSelected()
    End Sub

    '===================================== WORK IN PROGRESS =============================================='



    Dim myConnection As MySqlConnection

    Public Sub CreatePlaylist(name As String)

        myConnection = Common.getDBConnectionX()

        myConnection.Open()

        Dim query As String = "INSERT INTO playlists (name) VALUES (@name)"
        Using cmd As New MySqlCommand(query, myConnection)

        End Using

    End Sub

    Public Sub AddMovieToPlaylist(playlistId As Integer, movieId As Integer)
        Using connection As New MySqlConnection()
            connection.Open()

            Dim query As String = "INSERT INTO playlist_movies (playlist_id, movie_id) VALUES (@playlistId, @movieId)"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@playlistId", playlistId)
                cmd.Parameters.AddWithValue("@movieId", movieId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetMoviesByPlaylist(playlistId As Integer) As DataTable
        Dim dataTable As New DataTable()

        Using connection As New MySqlConnection()
            connection.Open()

            Dim query As String = "SELECT m.* FROM movies m INNER JOIN playlist_movies pm ON m.movie_id = pm.movie_id WHERE pm.playlist_id = @playlistId"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@playlistId", playlistId)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using
        End Using

        Return dataTable
    End Function

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Access the username value
        Dim usernameValue As String = Me.Username


        Label6.Text = usernameValue


    End Sub

    Private Sub BtnNewPlylst_Click(sender As Object, e As EventArgs) Handles BtnNewPlylst.Click

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub
End Class