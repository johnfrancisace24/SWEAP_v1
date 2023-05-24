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
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        ButtonClose = New Button()
        TextBoxPass = New TextBox()
        TextBoxUser = New TextBox()
        Label3 = New Label()
        LinkLabelsignup = New LinkLabel()
        ButtonLogIn = New Button()
        CheckBoxShow = New CheckBox()
        Label2 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(255), CByte(77), CByte(77))
        PictureBox1.BackgroundImage = My.Resources.Resources.Logo
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(34, 70)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(355, 324)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(77), CByte(77))
        Panel1.Controls.Add(ButtonClose)
        Panel1.Controls.Add(TextBoxPass)
        Panel1.Controls.Add(TextBoxUser)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(LinkLabelsignup)
        Panel1.Controls.Add(ButtonLogIn)
        Panel1.Controls.Add(CheckBoxShow)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(9, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(795, 464)
        Panel1.TabIndex = 2
        ' 
        ' ButtonClose
        ' 
        ButtonClose.BackColor = Color.Transparent
        ButtonClose.BackgroundImage = My.Resources.Resources.close_button
        ButtonClose.BackgroundImageLayout = ImageLayout.Stretch
        ButtonClose.FlatAppearance.BorderSize = 0
        ButtonClose.FlatStyle = FlatStyle.Flat
        ButtonClose.Location = New Point(764, 4)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Size = New Size(27, 27)
        ButtonClose.TabIndex = 19
        ButtonClose.UseVisualStyleBackColor = False
        ' 
        ' TextBoxPass
        ' 
        TextBoxPass.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxPass.Location = New Point(437, 198)
        TextBoxPass.Name = "TextBoxPass"
        TextBoxPass.PasswordChar = "*"c
        TextBoxPass.Size = New Size(289, 38)
        TextBoxPass.TabIndex = 18
        ' 
        ' TextBoxUser
        ' 
        TextBoxUser.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxUser.Location = New Point(437, 112)
        TextBoxUser.Name = "TextBoxUser"
        TextBoxUser.Size = New Size(289, 38)
        TextBoxUser.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(457, 360)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 20)
        Label3.TabIndex = 16
        Label3.Text = "Dont have an account?"
        ' 
        ' LinkLabelsignup
        ' 
        LinkLabelsignup.AutoSize = True
        LinkLabelsignup.DisabledLinkColor = Color.Transparent
        LinkLabelsignup.ForeColor = Color.Aqua
        LinkLabelsignup.LinkColor = Color.AliceBlue
        LinkLabelsignup.Location = New Point(619, 358)
        LinkLabelsignup.Name = "LinkLabelsignup"
        LinkLabelsignup.Size = New Size(91, 20)
        LinkLabelsignup.TabIndex = 15
        LinkLabelsignup.TabStop = True
        LinkLabelsignup.Text = "Sign up now"
        ' 
        ' ButtonLogIn
        ' 
        ButtonLogIn.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        ButtonLogIn.FlatAppearance.BorderSize = 0
        ButtonLogIn.FlatStyle = FlatStyle.Flat
        ButtonLogIn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonLogIn.ForeColor = Color.White
        ButtonLogIn.Location = New Point(437, 289)
        ButtonLogIn.Name = "ButtonLogIn"
        ButtonLogIn.Size = New Size(288, 41)
        ButtonLogIn.TabIndex = 14
        ButtonLogIn.Text = "LOGIN"
        ButtonLogIn.UseVisualStyleBackColor = False
        ' 
        ' CheckBoxShow
        ' 
        CheckBoxShow.AutoSize = True
        CheckBoxShow.ForeColor = Color.Transparent
        CheckBoxShow.Location = New Point(437, 244)
        CheckBoxShow.Name = "CheckBoxShow"
        CheckBoxShow.Size = New Size(157, 24)
        CheckBoxShow.TabIndex = 13
        CheckBoxShow.Text = "SHOW PASSWORD"
        CheckBoxShow.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(440, 166)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 29)
        Label2.TabIndex = 12
        Label2.Text = "PASSWORD"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(437, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 29)
        Label1.TabIndex = 11
        Label1.Text = "USERNAME"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(56), CByte(103), CByte(214))
        ClientSize = New Size(812, 486)
        ControlBox = False
        Controls.Add(Panel1)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.FixedSingle
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
    Friend WithEvents ButtonLogIn As Button
    Friend WithEvents CheckBoxShow As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents ButtonClose As Button
End Class
