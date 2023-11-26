<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectionOfUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectionOfUser))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Panel1 = New Panel()
        BtnProfile = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        TabPage = New TabControl()
        homeTab = New TabPage()
        Label3 = New Label()
        exploreTab = New TabPage()
        BtnFilter = New Button()
        BtnClear = New Button()
        Label5 = New Label()
        ListBox2 = New ListBox()
        Label4 = New Label()
        Label1 = New Label()
        ListBox1 = New ListBox()
        Button4 = New Button()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        TabProfile = New TabPage()
        Label7 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        TextBox2 = New TextBox()
        Label8 = New Label()
        TextBox4 = New TextBox()
        Label9 = New Label()
        TextBox5 = New TextBox()
        Guna2ShadowPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        TabPage.SuspendLayout()
        homeTab.SuspendLayout()
        exploreTab.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabProfile.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        Guna2ShadowPanel1.BackgroundImage = CType(resources.GetObject("Guna2ShadowPanel1.BackgroundImage"), Image)
        Guna2ShadowPanel1.Controls.Add(Guna2ControlBox2)
        Guna2ShadowPanel1.Controls.Add(Guna2ControlBox1)
        Guna2ShadowPanel1.Dock = DockStyle.Top
        Guna2ShadowPanel1.FillColor = Color.Transparent
        Guna2ShadowPanel1.Location = New Point(0, 0)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.ShadowColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        Guna2ShadowPanel1.ShadowDepth = 70
        Guna2ShadowPanel1.ShadowShift = 100
        Guna2ShadowPanel1.Size = New Size(1031, 31)
        Guna2ShadowPanel1.TabIndex = 4
        ' 
        ' Guna2ControlBox2
        ' 
        Guna2ControlBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox2.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox2.FillColor = Color.Transparent
        Guna2ControlBox2.IconColor = Color.DimGray
        Guna2ControlBox2.Location = New Point(974, 3)
        Guna2ControlBox2.Name = "Guna2ControlBox2"
        Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox2.Size = New Size(24, 24)
        Guna2ControlBox2.TabIndex = 10
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges3
        Guna2ControlBox1.FillColor = Color.Transparent
        Guna2ControlBox1.IconColor = Color.DimGray
        Guna2ControlBox1.Location = New Point(1004, 3)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2ControlBox1.Size = New Size(24, 24)
        Guna2ControlBox1.TabIndex = 9
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = Guna2ShadowPanel1
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' Guna2ContextMenuStrip1
        ' 
        Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(CByte(151), CByte(143), CByte(255))
        Guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro
        Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White
        Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White
        Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro
        Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        Guna2ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.Controls.Add(BtnProfile)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(115, 519)
        Panel1.TabIndex = 5
        ' 
        ' BtnProfile
        ' 
        BtnProfile.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnProfile.Location = New Point(1, 391)
        BtnProfile.Name = "BtnProfile"
        BtnProfile.Size = New Size(111, 61)
        BtnProfile.TabIndex = 12
        BtnProfile.Text = "PROFILE"
        BtnProfile.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.RosyBrown
        Button3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(0, 458)
        Button3.Name = "Button3"
        Button3.Size = New Size(111, 61)
        Button3.TabIndex = 11
        Button3.Text = "LOG OUT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(0, 73)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 61)
        Button2.TabIndex = 10
        Button2.Text = "BROWSE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(0, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 61)
        Button1.TabIndex = 9
        Button1.Text = "HOME"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(206, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(822, 519)
        Panel2.TabIndex = 6
        ' 
        ' TabPage
        ' 
        TabPage.Controls.Add(homeTab)
        TabPage.Controls.Add(exploreTab)
        TabPage.Controls.Add(TabProfile)
        TabPage.Location = New Point(117, 37)
        TabPage.Name = "TabPage"
        TabPage.SelectedIndex = 0
        TabPage.Size = New Size(902, 510)
        TabPage.TabIndex = 6
        ' 
        ' homeTab
        ' 
        homeTab.BackColor = SystemColors.AppWorkspace
        homeTab.Controls.Add(Label3)
        homeTab.Location = New Point(4, 24)
        homeTab.Name = "homeTab"
        homeTab.Padding = New Padding(3)
        homeTab.Size = New Size(894, 482)
        homeTab.TabIndex = 0
        homeTab.Text = "Home"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(6, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 21)
        Label3.TabIndex = 0
        Label3.Text = "Welcome Back!"
        ' 
        ' exploreTab
        ' 
        exploreTab.BackColor = SystemColors.ButtonShadow
        exploreTab.Controls.Add(BtnFilter)
        exploreTab.Controls.Add(BtnClear)
        exploreTab.Controls.Add(Label5)
        exploreTab.Controls.Add(ListBox2)
        exploreTab.Controls.Add(Label4)
        exploreTab.Controls.Add(Label1)
        exploreTab.Controls.Add(ListBox1)
        exploreTab.Controls.Add(Button4)
        exploreTab.Controls.Add(TextBox1)
        exploreTab.Controls.Add(DataGridView1)
        exploreTab.Controls.Add(Label2)
        exploreTab.Location = New Point(4, 24)
        exploreTab.Name = "exploreTab"
        exploreTab.Padding = New Padding(3)
        exploreTab.Size = New Size(894, 482)
        exploreTab.TabIndex = 1
        exploreTab.Text = "Explore"
        ' 
        ' BtnFilter
        ' 
        BtnFilter.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnFilter.Location = New Point(711, 63)
        BtnFilter.Name = "BtnFilter"
        BtnFilter.Size = New Size(166, 42)
        BtnFilter.TabIndex = 12
        BtnFilter.Text = "Filter search"
        BtnFilter.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClear.Location = New Point(711, 128)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(166, 42)
        BtnClear.TabIndex = 11
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(528, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 19)
        Label5.TabIndex = 10
        Label5.Text = "Year"
        Label5.Visible = False
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Items.AddRange(New Object() {"1996", "1995", "1994", "1993", "1992", "1988", "1977", "1976", "1967", "1965", "1964"})
        ListBox2.Location = New Point(528, 63)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(152, 139)
        ListBox2.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(15, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 19)
        Label4.TabIndex = 8
        Label4.Text = "Search"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(248, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 19)
        Label1.TabIndex = 7
        Label1.Text = "Genre"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Children", "Comedy", "Crime", "Documentary", "Drama", "Fantasy", "Horror", "Musical", "Mystery", "Romance", "Sci-Fi", "Thriller", "War", "Western"})
        ListBox1.Location = New Point(248, 63)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(211, 169)
        ListBox1.TabIndex = 6
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(15, 102)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 5
        Button4.Text = "Search"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(15, 63)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(202, 23)
        TextBox1.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(15, 255)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(862, 221)
        DataGridView1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(15, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 25)
        Label2.TabIndex = 1
        Label2.Text = "Browse"
        ' 
        ' TabProfile
        ' 
        TabProfile.BackColor = Color.LightGray
        TabProfile.Controls.Add(Label9)
        TabProfile.Controls.Add(TextBox5)
        TabProfile.Controls.Add(Label8)
        TabProfile.Controls.Add(TextBox4)
        TabProfile.Controls.Add(Label7)
        TabProfile.Controls.Add(TextBox3)
        TabProfile.Controls.Add(Label6)
        TabProfile.Controls.Add(TextBox2)
        TabProfile.Location = New Point(4, 24)
        TabProfile.Name = "TabProfile"
        TabProfile.Padding = New Padding(3)
        TabProfile.Size = New Size(894, 482)
        TabProfile.TabIndex = 2
        TabProfile.Text = "TabProfile"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(31, 125)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 3
        Label7.Text = "Label7"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(31, 143)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(31, 63)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 1
        Label6.Text = "Label6"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(31, 81)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(189, 63)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 15)
        Label8.TabIndex = 5
        Label8.Text = "Label8"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(189, 81)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 4
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(189, 125)
        Label9.Name = "Label9"
        Label9.Size = New Size(41, 15)
        Label9.TabIndex = 7
        Label9.Text = "Label9"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(189, 143)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 6
        ' 
        ' SelectionOfUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1031, 550)
        Controls.Add(TabPage)
        Controls.Add(Panel1)
        Controls.Add(Guna2ShadowPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SelectionOfUser"
        Text = "SelectionOfUser"
        Guna2ShadowPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        TabPage.ResumeLayout(False)
        homeTab.ResumeLayout(False)
        homeTab.PerformLayout()
        exploreTab.ResumeLayout(False)
        exploreTab.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabProfile.ResumeLayout(False)
        TabProfile.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabPage As TabControl
    Friend WithEvents homeTab As TabPage
    Friend WithEvents exploreTab As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnFilter As Button
    Friend WithEvents TabProfile As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnProfile As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
End Class