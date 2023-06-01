
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userdashboard
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
        Panel2 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        designation = New Label()
        fname = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Panel3 = New Panel()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label9 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label8 = New Label()
        Panel1 = New Panel()
        Label10 = New Label()
        Panel8 = New Panel()
        Panel7 = New Panel()
        Panel6 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label11 = New Label()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(77), CByte(77))
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(designation)
        Panel2.Controls.Add(fname)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 39)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(245, 601)
        Panel2.TabIndex = 1
        ' 
        ' Button4
        ' 
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Image = My.Resources.Resources.layout
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(3, 245)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(5, 0, 0, 0)
        Button4.Size = New Size(239, 35)
        Button4.TabIndex = 5
        Button4.Text = "DASHBOARD"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Image = My.Resources.Resources.team
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(3, 327)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(5, 0, 0, 0)
        Button3.Size = New Size(239, 35)
        Button3.TabIndex = 4
        Button3.Text = "VIEW MEMBER"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Image = My.Resources.Resources.profile
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(3, 286)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(5, 0, 0, 0)
        Button2.Size = New Size(239, 35)
        Button2.TabIndex = 3
        Button2.Text = "PROFILE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' designation
        ' 
        designation.Dock = DockStyle.Top
        designation.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        designation.ForeColor = SystemColors.ButtonFace
        designation.Location = New Point(0, 190)
        designation.Name = "designation"
        designation.Size = New Size(245, 20)
        designation.TabIndex = 2
        designation.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' fname
        ' 
        fname.Dock = DockStyle.Top
        fname.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        fname.ForeColor = SystemColors.ButtonFace
        fname.Location = New Point(0, 164)
        fname.Name = "fname"
        fname.Size = New Size(245, 26)
        fname.TabIndex = 1
        fname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(245, 164)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button1.Dock = DockStyle.Right
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(1142, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(47, 39)
        Button1.TabIndex = 2
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(239), CByte(243), CByte(246))
        Panel3.Controls.Add(TextBox6)
        Panel3.Controls.Add(TextBox7)
        Panel3.Controls.Add(TextBox8)
        Panel3.Controls.Add(TextBox9)
        Panel3.Controls.Add(TextBox5)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(252, 42)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(930, 591)
        Panel3.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(597, 218)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(257, 23)
        TextBox6.TabIndex = 18
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(597, 184)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(257, 23)
        TextBox7.TabIndex = 17
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(597, 150)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(257, 23)
        TextBox8.TabIndex = 16
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(597, 116)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(257, 23)
        TextBox9.TabIndex = 15
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(146, 216)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(257, 23)
        TextBox5.TabIndex = 14
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(146, 182)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(257, 23)
        TextBox4.TabIndex = 13
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(146, 148)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(257, 23)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(146, 114)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(257, 23)
        TextBox2.TabIndex = 11
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(490, 184)
        Label9.Name = "Label9"
        Label9.Size = New Size(101, 21)
        Label9.TabIndex = 10
        Label9.Text = "Designation:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(415, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 21)
        Label2.TabIndex = 8
        Label2.Text = "Status of employment:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(448, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 21)
        Label1.TabIndex = 7
        Label1.Text = "Employment type:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(74, 218)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 21)
        Label7.TabIndex = 6
        Label7.Text = "Region:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(81, 184)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 21)
        Label6.TabIndex = 5
        Label6.Text = "Office:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(69, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 21)
        Label5.TabIndex = 4
        Label5.Text = "Contact:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(83, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 21)
        Label4.TabIndex = 3
        Label4.Text = "Name:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(523, 218)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 21)
        Label8.TabIndex = 9
        Label8.Text = "Postion:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(239), CByte(243), CByte(246))
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel6)
        Panel1.Location = New Point(251, 42)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(930, 591)
        Panel1.TabIndex = 19
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(14, 21)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 17)
        Label10.TabIndex = 2
        Label10.Text = "Dashboard"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Location = New Point(14, 305)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(904, 281)
        Panel8.TabIndex = 1
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Location = New Point(483, 56)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(435, 131)
        Panel7.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Location = New Point(14, 56)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(463, 131)
        Panel6.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Button1)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1189, 39)
        Panel4.TabIndex = 5
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Teal
        Panel5.Controls.Add(DataGridView1)
        Panel5.Controls.Add(TextBox1)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(251, 42)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(931, 591)
        Panel5.TabIndex = 5
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8})
        DataGridView1.Location = New Point(4, 51)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(922, 535)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Name"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Contact"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Office"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Region"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column5.HeaderText = "Employment Type"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column6.HeaderText = "Status of Employment"
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column7.HeaderText = "Postion"
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column8.HeaderText = "Designation"
        Column8.Name = "Column8"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(689, 13)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(237, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(620, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 21)
        Label3.TabIndex = 2
        Label3.Text = "Search:"
        ' 
        ' Label11
        ' 
        Label11.Dock = DockStyle.Left
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = SystemColors.ControlLightLight
        Label11.Location = New Point(0, 0)
        Label11.Name = "Label11"
        Label11.Padding = New Padding(5, 0, 0, 0)
        Label11.Size = New Size(369, 39)
        Label11.TabIndex = 3
        Label11.Text = "Social Welfare Employees Association of the Philippines"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' userdashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(56), CByte(103), CByte(214))
        ClientSize = New Size(1189, 640)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "userdashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "userdashboard"
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents designation As Label
    Friend WithEvents fname As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label11 As Label
End Class
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userdashboard
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(userdashboard))
        Panel2 = New Panel()
        Button2 = New Button()
        Button5 = New Button()
        btndash = New Button()
        btnprof = New Button()
        lblpostion = New Label()
        lblFname = New Label()
        imgProfile = New PictureBox()
        Button1 = New Button()
        Panel3 = New Panel()
        Label20 = New Label()
        Label13 = New Label()
        Label9 = New Label()
        txtoffice = New TextBox()
        Label19 = New Label()
        txtbdate = New TextBox()
        Label18 = New Label()
        txteduc = New TextBox()
        Label17 = New Label()
        txtemail = New TextBox()
        Label7 = New Label()
        txtpos = New TextBox()
        txtemploy = New TextBox()
        txtcom = New TextBox()
        txtcontact = New TextBox()
        txtadd = New TextBox()
        txtfname = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label8 = New Label()
        Panel1 = New Panel()
        Label21 = New Label()
        Label12 = New Label()
        Panel6 = New Panel()
        Label10 = New Label()
        Panel4 = New Panel()
        Label11 = New Label()
        Panel5 = New Panel()
        Button3 = New Button()
        posTxt = New TextBox()
        addTxt = New TextBox()
        passTxt = New TextBox()
        userTxt = New TextBox()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label3 = New Label()
        Panel2.SuspendLayout()
        CType(imgProfile, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(51))
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(btndash)
        Panel2.Controls.Add(btnprof)
        Panel2.Controls.Add(lblpostion)
        Panel2.Controls.Add(lblFname)
        Panel2.Controls.Add(imgProfile)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 39)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(245, 601)
        Panel2.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(235), CByte(204), CByte(100))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Image = My.Resources.Resources.settings
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(3, 492)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(5, 0, 0, 0)
        Button2.Size = New Size(239, 48)
        Button2.TabIndex = 7
        Button2.Text = "ACCOUNT SETTING"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(235), CByte(204), CByte(100))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = SystemColors.ActiveCaptionText
        Button5.Image = My.Resources.Resources._exit
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(3, 546)
        Button5.Name = "Button5"
        Button5.Padding = New Padding(5, 0, 0, 0)
        Button5.Size = New Size(239, 48)
        Button5.TabIndex = 6
        Button5.Text = "LOG OUT"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' btndash
        ' 
        btndash.Cursor = Cursors.Hand
        btndash.FlatAppearance.BorderSize = 0
        btndash.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(235), CByte(204), CByte(100))
        btndash.FlatStyle = FlatStyle.Flat
        btndash.ForeColor = SystemColors.ActiveCaptionText
        btndash.Image = My.Resources.Resources.dashboard__2_
        btndash.ImageAlign = ContentAlignment.MiddleLeft
        btndash.Location = New Point(3, 259)
        btndash.Name = "btndash"
        btndash.Padding = New Padding(5, 0, 0, 0)
        btndash.Size = New Size(239, 48)
        btndash.TabIndex = 5
        btndash.Text = "DASHBOARD"
        btndash.UseVisualStyleBackColor = True
        ' 
        ' btnprof
        ' 
        btnprof.Cursor = Cursors.Hand
        btnprof.FlatAppearance.BorderSize = 0
        btnprof.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(235), CByte(204), CByte(100))
        btnprof.FlatStyle = FlatStyle.Flat
        btnprof.ForeColor = SystemColors.ActiveCaptionText
        btnprof.Image = My.Resources.Resources.user__1_
        btnprof.ImageAlign = ContentAlignment.MiddleLeft
        btnprof.Location = New Point(3, 311)
        btnprof.Name = "btnprof"
        btnprof.Padding = New Padding(5, 0, 0, 0)
        btnprof.Size = New Size(239, 48)
        btnprof.TabIndex = 3
        btnprof.Text = "PROFILE"
        btnprof.UseVisualStyleBackColor = True
        ' 
        ' lblpostion
        ' 
        lblpostion.Font = New Font("Segoe UI", 7.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblpostion.ForeColor = SystemColors.ActiveCaptionText
        lblpostion.Location = New Point(3, 202)
        lblpostion.Name = "lblpostion"
        lblpostion.Size = New Size(242, 20)
        lblpostion.TabIndex = 2
        lblpostion.Text = "--------------------"
        lblpostion.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFname
        ' 
        lblFname.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lblFname.ForeColor = SystemColors.ActiveCaptionText
        lblFname.Location = New Point(0, 173)
        lblFname.Name = "lblFname"
        lblFname.Size = New Size(242, 26)
        lblFname.TabIndex = 1
        lblFname.Text = "---------------------"
        lblFname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' imgProfile
        ' 
        imgProfile.BackgroundImage = My.Resources.Resources.profile__1_
        imgProfile.BackgroundImageLayout = ImageLayout.Stretch
        imgProfile.Dock = DockStyle.Top
        imgProfile.Location = New Point(0, 0)
        imgProfile.Margin = New Padding(0)
        imgProfile.Name = "imgProfile"
        imgProfile.Size = New Size(245, 171)
        imgProfile.TabIndex = 0
        imgProfile.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button1.Cursor = Cursors.Hand
        Button1.Dock = DockStyle.Right
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(1143, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(46, 39)
        Button1.TabIndex = 2
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.FromArgb(CByte(239), CByte(243), CByte(246))
        Panel3.Controls.Add(Label20)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(txtoffice)
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(txtbdate)
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(txteduc)
        Panel3.Controls.Add(Label17)
        Panel3.Controls.Add(txtemail)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(txtpos)
        Panel3.Controls.Add(txtemploy)
        Panel3.Controls.Add(txtcom)
        Panel3.Controls.Add(txtcontact)
        Panel3.Controls.Add(txtadd)
        Panel3.Controls.Add(txtfname)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(252, 39)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(937, 601)
        Panel3.TabIndex = 4
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(64, 25)
        Label20.Name = "Label20"
        Label20.Size = New Size(70, 15)
        Label20.TabIndex = 29
        Label20.Text = "Information"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(13, 23)
        Label13.Name = "Label13"
        Label13.Size = New Size(54, 17)
        Label13.TabIndex = 28
        Label13.Text = "Profile |"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(140, 400)
        Label9.Name = "Label9"
        Label9.Size = New Size(103, 21)
        Label9.TabIndex = 27
        Label9.Text = "Contribution"
        ' 
        ' txtoffice
        ' 
        txtoffice.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtoffice.Enabled = False
        txtoffice.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        txtoffice.Location = New Point(482, 147)
        txtoffice.Name = "txtoffice"
        txtoffice.Size = New Size(298, 25)
        txtoffice.TabIndex = 26
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.ForeColor = SystemColors.ActiveCaptionText
        Label19.Location = New Point(482, 123)
        Label19.Name = "Label19"
        Label19.Size = New Size(55, 21)
        Label19.TabIndex = 25
        Label19.Text = "Office"
        ' 
        ' txtbdate
        ' 
        txtbdate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtbdate.Enabled = False
        txtbdate.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        txtbdate.Location = New Point(482, 95)
        txtbdate.Name = "txtbdate"
        txtbdate.Size = New Size(298, 25)
        txtbdate.TabIndex = 24
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.ForeColor = SystemColors.ActiveCaptionText
        Label18.Location = New Point(482, 71)
        Label18.Name = "Label18"
        Label18.Size = New Size(78, 21)
        Label18.TabIndex = 23
        Label18.Text = "Birthdate"
        ' 
        ' txteduc
        ' 
        txteduc.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txteduc.Enabled = False
        txteduc.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        txteduc.Location = New Point(140, 324)
        txteduc.Name = "txteduc"
        txteduc.Size = New Size(298, 25)
        txteduc.TabIndex = 22
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.ForeColor = SystemColors.ActiveCaptionText
        Label17.Location = New Point(140, 300)
        Label17.Name = "Label17"
        Label17.Size = New Size(177, 21)
        Label17.TabIndex = 21
        Label17.Text = "Educational attainment" & vbCrLf
        ' 
        ' txtemail
        ' 
        txtemail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtemail.Enabled = False
        txtemail.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        txtemail.Location = New Point(140, 264)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(298, 25)
        txtemail.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(140, 240)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 21)
        Label7.TabIndex = 19
        Label7.Text = "Email"
        ' 
        ' txtpos
        ' 
        txtpos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtpos.Enabled = False
        txtpos.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        txtpos.Location = New Point(482, 204)
        txtpos.Name = "txtpos"
        txtpos.Size = New Size(298, 25)
        txtpos.TabIndex = 18
        ' 
        ' txtemploy
        ' 
        txtemploy.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtemploy.Enabled = False
        txtemploy.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        txtemploy.Location = New Point(483, 264)
        txtemploy.Name = "txtemploy"
        txtemploy.Size = New Size(298, 25)
        txtemploy.TabIndex = 16
        ' 
        ' txtcom
        ' 
        txtcom.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtcom.Enabled = False
        txtcom.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        txtcom.Location = New Point(483, 324)
        txtcom.Name = "txtcom"
        txtcom.Size = New Size(298, 25)
        txtcom.TabIndex = 15
        ' 
        ' txtcontact
        ' 
        txtcontact.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtcontact.Enabled = False
        txtcontact.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        txtcontact.Location = New Point(140, 204)
        txtcontact.Name = "txtcontact"
        txtcontact.Size = New Size(298, 25)
        txtcontact.TabIndex = 13
        ' 
        ' txtadd
        ' 
        txtadd.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtadd.Enabled = False
        txtadd.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        txtadd.Location = New Point(140, 148)
        txtadd.Name = "txtadd"
        txtadd.Size = New Size(298, 25)
        txtadd.TabIndex = 12
        ' 
        ' txtfname
        ' 
        txtfname.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txtfname.Enabled = False
        txtfname.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        txtfname.Location = New Point(140, 95)
        txtfname.Name = "txtfname"
        txtfname.Size = New Size(298, 25)
        txtfname.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(483, 240)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 21)
        Label2.TabIndex = 8
        Label2.Text = "Employment status"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(483, 300)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 21)
        Label1.TabIndex = 7
        Label1.Text = "Committee"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(140, 180)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 21)
        Label6.TabIndex = 5
        Label6.Text = "Contact"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(140, 124)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 21)
        Label5.TabIndex = 4
        Label5.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(140, 71)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 21)
        Label4.TabIndex = 3
        Label4.Text = "Name"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(482, 180)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 21)
        Label8.TabIndex = 9
        Label8.Text = "Postion"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(51))
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Label10)
        Panel1.Location = New Point(251, 39)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(938, 601)
        Panel1.TabIndex = 19
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(34, 240)
        Label21.Name = "Label21"
        Label21.Size = New Size(0, 15)
        Label21.TabIndex = 4
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(96, 23)
        Label12.Name = "Label12"
        Label12.Size = New Size(148, 15)
        Label12.TabIndex = 0
        Label12.Text = "SWEAP monitoring system"
        ' 
        ' Panel6
        ' 
        Panel6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel6.BackColor = Color.DarkRed
        Panel6.Location = New Point(14, 55)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(912, 143)
        Panel6.TabIndex = 3
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(14, 21)
        Label10.Name = "Label10"
        Label10.Size = New Size(82, 17)
        Label10.TabIndex = 2
        Label10.Text = "Dashboard |"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.DarkRed
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Button1)
        Panel4.Dock = DockStyle.Top
        Panel4.ForeColor = SystemColors.ControlLightLight
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1189, 39)
        Panel4.TabIndex = 5
        ' 
        ' Label11
        ' 
        Label11.Dock = DockStyle.Top
        Label11.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(0, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(1143, 39)
        Label11.TabIndex = 3
        Label11.Text = "SOCIAL WELFARE EMPLOYEES ASSOCIATION OF THE PHILIPPINES"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel5.BackColor = Color.FromArgb(CByte(239), CByte(243), CByte(246))
        Panel5.Controls.Add(Button3)
        Panel5.Controls.Add(posTxt)
        Panel5.Controls.Add(addTxt)
        Panel5.Controls.Add(passTxt)
        Panel5.Controls.Add(userTxt)
        Panel5.Controls.Add(Label16)
        Panel5.Controls.Add(Label15)
        Panel5.Controls.Add(Label14)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(251, 39)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(938, 601)
        Panel5.TabIndex = 20
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(51))
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(472, 214)
        Button3.Name = "Button3"
        Button3.Size = New Size(104, 32)
        Button3.TabIndex = 8
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' posTxt
        ' 
        posTxt.Anchor = AnchorStyles.Top
        posTxt.Location = New Point(420, 185)
        posTxt.Name = "posTxt"
        posTxt.Size = New Size(213, 23)
        posTxt.TabIndex = 7
        ' 
        ' addTxt
        ' 
        addTxt.Anchor = AnchorStyles.Top
        addTxt.Location = New Point(420, 156)
        addTxt.Name = "addTxt"
        addTxt.Size = New Size(213, 23)
        addTxt.TabIndex = 6
        ' 
        ' passTxt
        ' 
        passTxt.Anchor = AnchorStyles.Top
        passTxt.Location = New Point(420, 126)
        passTxt.Name = "passTxt"
        passTxt.PasswordChar = "*"c
        passTxt.Size = New Size(213, 23)
        passTxt.TabIndex = 5
        ' 
        ' userTxt
        ' 
        userTxt.Anchor = AnchorStyles.Top
        userTxt.Location = New Point(420, 97)
        userTxt.Name = "userTxt"
        userTxt.Size = New Size(213, 23)
        userTxt.TabIndex = 4
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(342, 187)
        Label16.Name = "Label16"
        Label16.Size = New Size(72, 21)
        Label16.TabIndex = 3
        Label16.Text = "Position:"
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(340, 158)
        Label15.Name = "Label15"
        Label15.Size = New Size(74, 21)
        Label15.TabIndex = 2
        Label15.Text = "Address:"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(331, 128)
        Label14.Name = "Label14"
        Label14.Size = New Size(83, 21)
        Label14.TabIndex = 1
        Label14.Text = "Password:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(327, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 21)
        Label3.TabIndex = 0
        Label3.Text = "Username:"
        ' 
        ' userdashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(153), CByte(0), CByte(0))
        ClientSize = New Size(1189, 640)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(Panel5)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "userdashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "userdashboard"
        WindowState = FormWindowState.Minimized
        Panel2.ResumeLayout(False)
        CType(imgProfile, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnprof As Button
    Friend WithEvents lblpostion As Label
    Friend WithEvents lblFname As Label
    Friend WithEvents imgProfile As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btndash As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpos As TextBox
    Friend WithEvents txtemploy As TextBox
    Friend WithEvents txtcom As TextBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents txtadd As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents posTxt As TextBox
    Friend WithEvents addTxt As TextBox
    Friend WithEvents passTxt As TextBox
    Friend WithEvents userTxt As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtoffice As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtbdate As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txteduc As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label11 As Label
End Class

