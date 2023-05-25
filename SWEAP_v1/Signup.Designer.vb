<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Signup))
        ButtonCancel = New Button()
        btnRegister = New Button()
        ButtonUpload = New Button()
        Label11 = New Label()
        Label10 = New Label()
        txtCreatePw = New TextBox()
        txtCreateUsername = New TextBox()
        pickDesignation = New ComboBox()
        pickPosition = New ComboBox()
        pickEmStat = New ComboBox()
        pickEmType = New ComboBox()
        pickRegion = New ComboBox()
        pickOffice = New ComboBox()
        txtEmail = New TextBox()
        txtContact = New TextBox()
        Label1 = New Label()
        txtFname = New TextBox()
        Label3 = New Label()
        Label9 = New Label()
        Label4 = New Label()
        pBoxCreateProfile = New PictureBox()
        Label5 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label12 = New Label()
        txtLname = New TextBox()
        CType(pBoxCreateProfile, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.BackColor = Color.PaleVioletRed
        ButtonCancel.FlatStyle = FlatStyle.Flat
        ButtonCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonCancel.Location = New Point(228, 434)
        ButtonCancel.Margin = New Padding(3, 2, 3, 2)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.Size = New Size(148, 31)
        ButtonCancel.TabIndex = 29
        ButtonCancel.Text = "CANCEL"
        ButtonCancel.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.SpringGreen
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegister.Location = New Point(446, 434)
        btnRegister.Margin = New Padding(3, 2, 3, 2)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(148, 31)
        btnRegister.TabIndex = 28
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' ButtonUpload
        ' 
        ButtonUpload.BackColor = Color.DeepSkyBlue
        ButtonUpload.FlatStyle = FlatStyle.Flat
        ButtonUpload.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonUpload.Image = CType(resources.GetObject("ButtonUpload.Image"), Image)
        ButtonUpload.ImageAlign = ContentAlignment.MiddleLeft
        ButtonUpload.Location = New Point(610, 203)
        ButtonUpload.Margin = New Padding(3, 2, 3, 2)
        ButtonUpload.Name = "ButtonUpload"
        ButtonUpload.Size = New Size(151, 31)
        ButtonUpload.TabIndex = 27
        ButtonUpload.Text = "UPLOAD"
        ButtonUpload.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(344, 340)
        Label11.Name = "Label11"
        Label11.Size = New Size(87, 16)
        Label11.TabIndex = 25
        Label11.Text = "PASSWORD "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(59, 340)
        Label10.Name = "Label10"
        Label10.Size = New Size(85, 16)
        Label10.TabIndex = 23
        Label10.Text = "USERNAME"
        ' 
        ' txtCreatePw
        ' 
        txtCreatePw.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtCreatePw.Location = New Point(344, 358)
        txtCreatePw.Margin = New Padding(3, 2, 3, 2)
        txtCreatePw.Name = "txtCreatePw"
        txtCreatePw.Size = New Size(224, 29)
        txtCreatePw.TabIndex = 21
        ' 
        ' txtCreateUsername
        ' 
        txtCreateUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtCreateUsername.Location = New Point(59, 358)
        txtCreateUsername.Margin = New Padding(3, 2, 3, 2)
        txtCreateUsername.Name = "txtCreateUsername"
        txtCreateUsername.Size = New Size(224, 29)
        txtCreateUsername.TabIndex = 20
        ' 
        ' pickDesignation
        ' 
        pickDesignation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickDesignation.FormattingEnabled = True
        pickDesignation.Location = New Point(344, 296)
        pickDesignation.Margin = New Padding(3, 2, 3, 2)
        pickDesignation.Name = "pickDesignation"
        pickDesignation.Size = New Size(224, 29)
        pickDesignation.TabIndex = 19
        ' 
        ' pickPosition
        ' 
        pickPosition.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickPosition.FormattingEnabled = True
        pickPosition.Items.AddRange(New Object() {"ΑΑΙ", "AA II", "AA II PANTAWID PAMILYA RPMO", "AA III", "AA III - Sr. Bookkeeper", "AA III / Information Officer NHTS-PR AA III-Municipal Roving Bookkeeper AA-II", "AA-II KALAHI-CIDDS", "AA-II KALAHI-CIDDS NCDDP_AF", "AC - KAASA", "Accountant I", "Accountant I/Officer In Charge", "Accountant II", "Accountant III", "Accounting Clerk", "Acting Secretary", "Acting Social Welfare Officer III", "Activity Therapist ", "Activity Worker I ", "Admin Aide I", "ADMIN AIDE III", "ADMIN AIDE IIII", "Admin Aide IV", "ADMIN AIDE VI", "Admin Assistant", "Admin Assistant III", "Admin Assistant III (Computer Operator II) ", "Admin Assistant V (Private Secretary I)", "Admin cum Finance Officer", "Admin Officer IV-Head, RROS", "Admin. Aide VI", "Admin.Assistant III/Information Officer (LIstahanan)", "Admin. Officer IV/Head", "Admin. Officer V-Unit Head", "Administrative Aide I", "Administrative Aide II", "Administrative Aide III", "Admin Aide IV", "ADMIN AIDE VI", "Admin Assistant", "Admin Assistant III", "Admin Assistant III (Computer Operator II) ", "Admin Assistant V (Private Secretary I)", "Admin cum Finance Officer", "Admin Officer IV-Head, RROS", "Admin. Aide VI", "Admin.Assistant III/Information Officer (LIstahanan)", "Admin.Officer IV/Head", "Admin. Officer V-Unit Head", "Administrative Aide I", "Administrative Aide II", "Administrative Aide III", "Administrative Aide III (Encoder)", "Administrative Aide IV", "Administrative Aide IV (Clerk II)", "Administrative Aide IV(Driver)", "Administrative Aide IV(Encoder)"})
        pickPosition.Location = New Point(344, 170)
        pickPosition.Margin = New Padding(3, 2, 3, 2)
        pickPosition.Name = "pickPosition"
        pickPosition.Size = New Size(224, 29)
        pickPosition.TabIndex = 18
        ' 
        ' pickEmStat
        ' 
        pickEmStat.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickEmStat.FormattingEnabled = True
        pickEmStat.Location = New Point(59, 296)
        pickEmStat.Margin = New Padding(3, 2, 3, 2)
        pickEmStat.Name = "pickEmStat"
        pickEmStat.Size = New Size(224, 29)
        pickEmStat.TabIndex = 17
        ' 
        ' pickEmType
        ' 
        pickEmType.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickEmType.FormattingEnabled = True
        pickEmType.Location = New Point(344, 231)
        pickEmType.Margin = New Padding(3, 2, 3, 2)
        pickEmType.Name = "pickEmType"
        pickEmType.Size = New Size(224, 29)
        pickEmType.TabIndex = 16
        ' 
        ' pickRegion
        ' 
        pickRegion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickRegion.FormattingEnabled = True
        pickRegion.Items.AddRange(New Object() {"BARMM, Bangsamoro Autonomous Region in Muslim Mindanao DSWD-ARMM, Autonomous Region in Muslim Mindanao", "DSWD-CAR, Cordillera Administrative Region", "DSWD-CARAGA, Caraga", "DSWD-Central Office, Central Office", "DSWD-NCR, National Capital Region", "DSWD-NIR, Negros Island Region DSWD-Region 1, Ilocos Region", "DSWD-Region 10, Northern Mindanao", "DSWD-Region 11, Davao Region", "DSWD-Region 12, SOCCSKSARGEN", "DSWD-Region 2, Cagayan Valley ", "DSWD-Region 3, Central Luzon ", "DSWD-Region 5, Bicol Region ", "DSWD-Region 6, Western Visayas ", "DSWD-Region 7, Central Visayas ", "DSWD-Region 8, Eastern Visayas", "DSWD-Region 9, Zamboanga Peninsula ", "DSWD-Region CALABARZON, CALABARZON ", "DSWD-Region MIMAROPA, MIMAROPA", "Dubai UAE, Dubai UAE"})
        pickRegion.Location = New Point(59, 231)
        pickRegion.Margin = New Padding(3, 2, 3, 2)
        pickRegion.Name = "pickRegion"
        pickRegion.Size = New Size(224, 29)
        pickRegion.TabIndex = 15
        ' 
        ' pickOffice
        ' 
        pickOffice.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickOffice.FormattingEnabled = True
        pickOffice.Location = New Point(59, 170)
        pickOffice.Margin = New Padding(3, 2, 3, 2)
        pickOffice.Name = "pickOffice"
        pickOffice.Size = New Size(224, 29)
        pickOffice.TabIndex = 14
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtEmail.Location = New Point(344, 110)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(224, 29)
        txtEmail.TabIndex = 13
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtContact.Location = New Point(59, 110)
        txtContact.Margin = New Padding(3, 2, 3, 2)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(224, 29)
        txtContact.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(59, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 16)
        Label1.TabIndex = 0
        Label1.Text = "FIRST NAME"
        ' 
        ' txtFname
        ' 
        txtFname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtFname.Location = New Point(59, 54)
        txtFname.Margin = New Padding(3, 2, 3, 2)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(224, 29)
        txtFname.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(59, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 16)
        Label3.TabIndex = 2
        Label3.Text = "CONTACT"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(344, 278)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 16)
        Label9.TabIndex = 10
        Label9.Text = "DESIGNATION"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(344, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 16)
        Label4.TabIndex = 3
        Label4.Text = "EMAIL"
        ' 
        ' pBoxCreateProfile
        ' 
        pBoxCreateProfile.BackgroundImage = My.Resources.Resources.user
        pBoxCreateProfile.BackgroundImageLayout = ImageLayout.Stretch
        pBoxCreateProfile.BorderStyle = BorderStyle.Fixed3D
        pBoxCreateProfile.Location = New Point(610, 54)
        pBoxCreateProfile.Margin = New Padding(3, 2, 3, 2)
        pBoxCreateProfile.Name = "pBoxCreateProfile"
        pBoxCreateProfile.Size = New Size(151, 145)
        pBoxCreateProfile.SizeMode = PictureBoxSizeMode.StretchImage
        pBoxCreateProfile.TabIndex = 9
        pBoxCreateProfile.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(59, 152)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 16)
        Label5.TabIndex = 4
        Label5.Text = "OFFICE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(59, 213)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 16)
        Label8.TabIndex = 8
        Label8.Text = "REGION"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(344, 152)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 16)
        Label6.TabIndex = 5
        Label6.Text = "POSITION"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(344, 213)
        Label7.Name = "Label7"
        Label7.Size = New Size(146, 16)
        Label7.TabIndex = 7
        Label7.Text = "EMPLOYMENT TYPE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(59, 278)
        Label2.Name = "Label2"
        Label2.Size = New Size(187, 16)
        Label2.TabIndex = 6
        Label2.Text = "STATUS OF EMPLOYMENT"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(23), CByte(192), CByte(235))
        Panel1.Controls.Add(ButtonCancel)
        Panel1.Controls.Add(btnRegister)
        Panel1.Controls.Add(ButtonUpload)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(txtCreatePw)
        Panel1.Controls.Add(txtCreateUsername)
        Panel1.Controls.Add(pickDesignation)
        Panel1.Controls.Add(pickPosition)
        Panel1.Controls.Add(pickEmStat)
        Panel1.Controls.Add(pickEmType)
        Panel1.Controls.Add(pickRegion)
        Panel1.Controls.Add(pickOffice)
        Panel1.Controls.Add(txtEmail)
        Panel1.Controls.Add(txtContact)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtLname)
        Panel1.Controls.Add(txtFname)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(pBoxCreateProfile)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(10, 9)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(822, 502)
        Panel1.TabIndex = 13
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(344, 37)
        Label12.Name = "Label12"
        Label12.Size = New Size(87, 16)
        Label12.TabIndex = 0
        Label12.Text = "LAST NAME"
        ' 
        ' txtLname
        ' 
        txtLname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtLname.Location = New Point(344, 54)
        txtLname.Margin = New Padding(3, 2, 3, 2)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(224, 29)
        txtLname.TabIndex = 11
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(6), CByte(82), CByte(221))
        ClientSize = New Size(844, 522)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Signup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Signup"
        CType(pBoxCreateProfile, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ButtonCancel As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents ButtonUpload As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCreatePw As TextBox
    Friend WithEvents txtCreateUsername As TextBox
    Friend WithEvents pickDesignation As ComboBox
    Friend WithEvents pickPosition As ComboBox
    Friend WithEvents pickEmStat As ComboBox
    Friend WithEvents pickEmType As ComboBox
    Friend WithEvents pickRegion As ComboBox
    Friend WithEvents pickOffice As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pBoxCreateProfile As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents txtLname As TextBox
End Class
