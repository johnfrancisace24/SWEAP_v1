<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        ButtonClose = New Button()
        txtBoxPass = New TextBox()
        txtUser = New TextBox()
        Label3 = New Label()
        LinkLabelsignup = New LinkLabel()
        btnLogIn = New Button()
        CheckBoxShow = New CheckBox()
        Label2 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(29, 53)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(311, 243)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(153), CByte(0), CByte(0))
        Panel1.Controls.Add(ButtonClose)
        Panel1.Controls.Add(txtBoxPass)
        Panel1.Controls.Add(txtUser)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(LinkLabelsignup)
        Panel1.Controls.Add(btnLogIn)
        Panel1.Controls.Add(CheckBoxShow)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(8, 8)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(696, 348)
        Panel1.TabIndex = 2
        ' 
        ' ButtonClose
        ' 
        ButtonClose.BackColor = Color.Transparent
        ButtonClose.BackgroundImage = My.Resources.Resources.close_button
        ButtonClose.BackgroundImageLayout = ImageLayout.Stretch
        ButtonClose.FlatAppearance.BorderSize = 0
        ButtonClose.FlatStyle = FlatStyle.Flat
        ButtonClose.Location = New Point(668, 3)
        ButtonClose.Margin = New Padding(3, 2, 3, 2)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Size = New Size(24, 20)
        ButtonClose.TabIndex = 19
        ButtonClose.UseVisualStyleBackColor = False
        ' 
        ' txtBoxPass
        ' 
        txtBoxPass.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtBoxPass.Location = New Point(382, 149)
        txtBoxPass.Margin = New Padding(3, 2, 3, 2)
        txtBoxPass.Name = "txtBoxPass"
        txtBoxPass.PasswordChar = "*"c
        txtBoxPass.Size = New Size(253, 32)
        txtBoxPass.TabIndex = 18
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtUser.Location = New Point(382, 84)
        txtUser.Margin = New Padding(3, 2, 3, 2)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(253, 32)
        txtUser.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(400, 270)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 15)
        Label3.TabIndex = 16
        Label3.Text = "Dont have an account?"
        ' 
        ' LinkLabelsignup
        ' 
        LinkLabelsignup.AutoSize = True
        LinkLabelsignup.DisabledLinkColor = Color.Transparent
        LinkLabelsignup.ForeColor = Color.Aqua
        LinkLabelsignup.LinkColor = Color.AliceBlue
        LinkLabelsignup.Location = New Point(542, 269)
        LinkLabelsignup.Name = "LinkLabelsignup"
        LinkLabelsignup.Size = New Size(73, 15)
        LinkLabelsignup.TabIndex = 15
        LinkLabelsignup.TabStop = True
        LinkLabelsignup.Text = "Sign up now"
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        btnLogIn.FlatAppearance.BorderSize = 0
        btnLogIn.FlatStyle = FlatStyle.Flat
        btnLogIn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogIn.ForeColor = Color.White
        btnLogIn.Location = New Point(382, 217)
        btnLogIn.Margin = New Padding(3, 2, 3, 2)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(252, 31)
        btnLogIn.TabIndex = 14
        btnLogIn.Text = "LOGIN"
        btnLogIn.UseVisualStyleBackColor = False
        ' 
        ' CheckBoxShow
        ' 
        CheckBoxShow.AutoSize = True
        CheckBoxShow.ForeColor = Color.Transparent
        CheckBoxShow.Location = New Point(382, 183)
        CheckBoxShow.Margin = New Padding(3, 2, 3, 2)
        CheckBoxShow.Name = "CheckBoxShow"
        CheckBoxShow.Size = New Size(125, 19)
        CheckBoxShow.TabIndex = 13
        CheckBoxShow.Text = "SHOW PASSWORD"
        CheckBoxShow.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(385, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 24)
        Label2.TabIndex = 12
        Label2.Text = "PASSWORD"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(382, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 24)
        Label1.TabIndex = 11
        Label1.Text = "USERNAME"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(51))
        ClientSize = New Size(710, 365)
        ControlBox = False
        Controls.Add(Panel1)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabelsignup As LinkLabel
    Friend WithEvents btnLogIn As Button
    Friend WithEvents CheckBoxShow As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtBoxPass As TextBox
    Friend WithEvents ButtonClose As Button
End Class
