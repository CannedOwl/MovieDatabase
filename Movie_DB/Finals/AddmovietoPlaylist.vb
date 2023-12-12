Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Data
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices
Imports Mysqlx.XDevAPI.Relational
Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement



Public Class AddmovietoPlaylist


    Private Sub PopulateListBoxes()
        Dim Connection As MySqlConnection
        Connection = Common.getDBConnectionX()
        Connection.Open()

        Dim query As String = "SELECT playlist_id, playlist_name FROM playlists WHERE users_no = 1"
        Using command As New MySqlCommand(query, Connection)
            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    ListBox1.Items.Add(reader("playlist_name"))
                    ListView2.Items.Add(reader("playlist_id"))
                End While
            End Using
        End Using

    End Sub
    Private selectedMovieIds As List(Of Integer)

    Public Sub New(movieIds As List(Of Integer))
        InitializeComponent()
        selectedMovieIds = movieIds
    End Sub

    Private Sub PlaylistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load playlists into ListView1 and ListView2
        ' Populate ListView1 with playlist names and ListView2 with playlist IDs
        ' Make sure the index of both lists match, i.e., the playlist at index i in ListView1 corresponds to the playlist ID at index i in ListView2.
        ' ...

        ' Example:
        PopulateListBoxes()
        ' ...
    End Sub

    Private Sub BtnAddmovie_Click(sender As Object, e As EventArgs)
        Dim test = 1
        If test > 0 Then
            'Dim selectedPlaylistId As Integer = CInt(ListBox2.SelectedItems(0).Text)

            ' Perform the database insertion
            Dim Connection As MySqlConnection
            Connection = Common.getDBConnectionX
            Connection.Open()

            For Each movieId In selectedMovieIds
                Using command As New MySqlCommand("INSERT INTO playlist_movies (playlist_id, movie_no) VALUES (1, @movie_no)", Connection)
                    ' command.Parameters.AddWithValue("@playlist_id", selectedPlaylistId)
                    command.Parameters.AddWithValue("@movie_no", movieId)
                    command.ExecuteNonQuery()
                End Using
            Next


            MessageBox.Show("Movies added to playlist successfully.")
            Close()
        Else
            MessageBox.Show("Please select a playlist.")
        End If
    End Sub


End Class