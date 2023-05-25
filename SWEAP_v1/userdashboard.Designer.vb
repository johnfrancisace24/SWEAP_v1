<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Button5 = New Button()
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
        Label13 = New Label()
        Panel7 = New Panel()
        cnt = New Label()
        Label12 = New Label()
        Panel6 = New Panel()
        Panel4 = New Panel()
        Label11 = New Label()
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
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(56), CByte(103), CByte(214))
        Panel2.Controls.Add(Button5)
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
        ' Button5
        ' 
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
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
        ' Button4
        ' 
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = SystemColors.ActiveCaptionText
        Button4.Image = My.Resources.Resources.dashboard__2_
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(3, 259)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(5, 0, 0, 0)
        Button4.Size = New Size(239, 48)
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
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.Image = My.Resources.Resources.group__2_
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(3, 363)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(5, 0, 0, 0)
        Button3.Size = New Size(239, 48)
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
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Image = My.Resources.Resources.avatar
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(3, 311)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(5, 0, 0, 0)
        Button2.Size = New Size(239, 48)
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
        PictureBox1.BackgroundImage = My.Resources.Resources.profile__1_
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
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
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
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
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
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
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
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
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
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
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
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
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
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
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
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
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
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
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
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
        Panel8.Controls.Add(Label13)
        Panel8.Location = New Point(14, 305)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(904, 281)
        Panel8.TabIndex = 1
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(12, 19)
        Label13.Name = "Label13"
        Label13.Size = New Size(131, 21)
        Label13.TabIndex = 2
        Label13.Text = "CONTRIBUTION:"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(cnt)
        Panel7.Controls.Add(Label12)
        Panel7.Location = New Point(483, 56)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(435, 131)
        Panel7.TabIndex = 1
        ' 
        ' cnt
        ' 
        cnt.AutoSize = True
        cnt.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cnt.Location = New Point(85, 94)
        cnt.Name = "cnt"
        cnt.Size = New Size(19, 21)
        cnt.TabIndex = 1
        cnt.Text = "0"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(8, 94)
        Label12.Name = "Label12"
        Label12.Size = New Size(80, 21)
        Label12.TabIndex = 0
        Label12.Text = "MEMBER:"
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
        ' Label11
        ' 
        Label11.Dock = DockStyle.Left
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = SystemColors.ControlLightLight
        Label11.Image = My.Resources.Resources.Logo1
        Label11.ImageAlign = ContentAlignment.MiddleLeft
        Label11.Location = New Point(0, 0)
        Label11.Name = "Label11"
        Label11.Padding = New Padding(5, 0, 0, 0)
        Label11.Size = New Size(429, 39)
        Label11.TabIndex = 3
        Label11.Text = "Social Welfare Employees Association Of The Philippines"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(239), CByte(243), CByte(246))
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
        TextBox1.Location = New Point(689, 14)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(237, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(620, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 21)
        Label3.TabIndex = 2
        Label3.Text = "Search:"
        ' 
        ' userdashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(56), CByte(103), CByte(214))
        ClientSize = New Size(1189, 640)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
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
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
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
    Friend WithEvents cnt As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button5 As Button
End Class
