<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class watchlist_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(watchlist_form))
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Label1 = New Label()
        BtnCreatePlaylist = New Guna.UI2.WinForms.Guna2Button()
        Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox4 = New Guna.UI2.WinForms.Guna2ControlBox()
        txtPlaylistName = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2ShadowPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 74)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 4
        Label1.Text = "Playlists"
        ' 
        ' BtnCreatePlaylist
        ' 
        BtnCreatePlaylist.AutoRoundedCorners = True
        BtnCreatePlaylist.BorderRadius = 19
        BtnCreatePlaylist.CustomizableEdges = CustomizableEdges13
        BtnCreatePlaylist.DisabledState.BorderColor = Color.DarkGray
        BtnCreatePlaylist.DisabledState.CustomBorderColor = Color.DarkGray
        BtnCreatePlaylist.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnCreatePlaylist.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnCreatePlaylist.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCreatePlaylist.ForeColor = Color.White
        BtnCreatePlaylist.Location = New Point(86, 154)
        BtnCreatePlaylist.Margin = New Padding(2)
        BtnCreatePlaylist.Name = "BtnCreatePlaylist"
        BtnCreatePlaylist.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        BtnCreatePlaylist.Size = New Size(106, 41)
        BtnCreatePlaylist.TabIndex = 6
        BtnCreatePlaylist.Text = "Create Playlist"
        ' 
        ' Guna2ShadowPanel2
        ' 
        Guna2ShadowPanel2.BackColor = Color.Transparent
        Guna2ShadowPanel2.BackgroundImage = CType(resources.GetObject("Guna2ShadowPanel2.BackgroundImage"), Image)
        Guna2ShadowPanel2.BackgroundImageLayout = ImageLayout.Stretch
        Guna2ShadowPanel2.Controls.Add(Guna2ControlBox2)
        Guna2ShadowPanel2.Controls.Add(Guna2ControlBox3)
        Guna2ShadowPanel2.Controls.Add(Guna2ControlBox1)
        Guna2ShadowPanel2.Controls.Add(Guna2ControlBox4)
        Guna2ShadowPanel2.Dock = DockStyle.Top
        Guna2ShadowPanel2.FillColor = Color.Transparent
        Guna2ShadowPanel2.Location = New Point(0, 0)
        Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Guna2ShadowPanel2.ShadowColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        Guna2ShadowPanel2.Size = New Size(303, 27)
        Guna2ShadowPanel2.TabIndex = 4
        ' 
        ' Guna2ControlBox2
        ' 
        Guna2ControlBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox2.CustomizableEdges = CustomizableEdges15
        Guna2ControlBox2.FillColor = Color.Transparent
        Guna2ControlBox2.IconColor = Color.DimGray
        Guna2ControlBox2.Location = New Point(257, 3)
        Guna2ControlBox2.Name = "Guna2ControlBox2"
        Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Guna2ControlBox2.Size = New Size(24, 21)
        Guna2ControlBox2.TabIndex = 14
        ' 
        ' Guna2ControlBox3
        ' 
        Guna2ControlBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox3.CustomizableEdges = CustomizableEdges17
        Guna2ControlBox3.FillColor = Color.Transparent
        Guna2ControlBox3.IconColor = Color.DimGray
        Guna2ControlBox3.Location = New Point(457, 3)
        Guna2ControlBox3.Name = "Guna2ControlBox3"
        Guna2ControlBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        Guna2ControlBox3.Size = New Size(24, 24)
        Guna2ControlBox3.TabIndex = 12
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges19
        Guna2ControlBox1.FillColor = Color.Transparent
        Guna2ControlBox1.IconColor = Color.DimGray
        Guna2ControlBox1.Location = New Point(279, 3)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Guna2ControlBox1.Size = New Size(24, 21)
        Guna2ControlBox1.TabIndex = 13
        ' 
        ' Guna2ControlBox4
        ' 
        Guna2ControlBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox4.CustomizableEdges = CustomizableEdges21
        Guna2ControlBox4.FillColor = Color.Transparent
        Guna2ControlBox4.IconColor = Color.DimGray
        Guna2ControlBox4.Location = New Point(487, 3)
        Guna2ControlBox4.Name = "Guna2ControlBox4"
        Guna2ControlBox4.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        Guna2ControlBox4.Size = New Size(24, 24)
        Guna2ControlBox4.TabIndex = 11
        ' 
        ' txtPlaylistName
        ' 
        txtPlaylistName.CustomizableEdges = CustomizableEdges23
        txtPlaylistName.DefaultText = ""
        txtPlaylistName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPlaylistName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPlaylistName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPlaylistName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPlaylistName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPlaylistName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPlaylistName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPlaylistName.Location = New Point(43, 102)
        txtPlaylistName.Name = "txtPlaylistName"
        txtPlaylistName.PasswordChar = ChrW(0)
        txtPlaylistName.PlaceholderText = ""
        txtPlaylistName.SelectedText = ""
        txtPlaylistName.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        txtPlaylistName.Size = New Size(200, 36)
        txtPlaylistName.TabIndex = 15
        ' 
        ' watchlist_form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(303, 248)
        Controls.Add(txtPlaylistName)
        Controls.Add(Guna2ShadowPanel2)
        Controls.Add(BtnCreatePlaylist)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "watchlist_form"
        Text = "watchlist_form"
        Guna2ShadowPanel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents BtnCreatePlaylist As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox4 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents txtPlaylistName As Guna.UI2.WinForms.Guna2TextBox
End Class
