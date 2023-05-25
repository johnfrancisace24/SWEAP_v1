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
        btnCancel = New Button()
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
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(255), CByte(211), CByte(42))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancel.Location = New Point(326, 723)
        btnCancel.Margin = New Padding(4, 3, 4, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(211, 52)
        btnCancel.TabIndex = 29
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(255), CByte(211), CByte(42))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegister.Location = New Point(637, 723)
        btnRegister.Margin = New Padding(4, 3, 4, 3)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(211, 52)
        btnRegister.TabIndex = 28
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' ButtonUpload
        ' 
        ButtonUpload.BackColor = Color.FromArgb(CByte(255), CByte(211), CByte(42))
        ButtonUpload.FlatStyle = FlatStyle.Flat
        ButtonUpload.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonUpload.Image = CType(resources.GetObject("ButtonUpload.Image"), Image)
        ButtonUpload.ImageAlign = ContentAlignment.MiddleLeft
        ButtonUpload.Location = New Point(871, 338)
        ButtonUpload.Margin = New Padding(4, 3, 4, 3)
        ButtonUpload.Name = "ButtonUpload"
        ButtonUpload.Size = New Size(216, 52)
        ButtonUpload.TabIndex = 27
        ButtonUpload.Text = "UPLOAD"
        ButtonUpload.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.Yellow
        Label11.Location = New Point(491, 567)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(144, 23)
        Label11.TabIndex = 25
        Label11.Text = "PASSWORD "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Yellow
        Label10.Location = New Point(84, 567)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(138, 23)
        Label10.TabIndex = 23
        Label10.Text = "USERNAME"
        ' 
        ' txtCreatePw
        ' 
        txtCreatePw.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtCreatePw.Location = New Point(491, 597)
        txtCreatePw.Margin = New Padding(4, 3, 4, 3)
        txtCreatePw.Name = "txtCreatePw"
        txtCreatePw.Size = New Size(318, 39)
        txtCreatePw.TabIndex = 21
        ' 
        ' txtCreateUsername
        ' 
        txtCreateUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtCreateUsername.Location = New Point(84, 597)
        txtCreateUsername.Margin = New Padding(4, 3, 4, 3)
        txtCreateUsername.Name = "txtCreateUsername"
        txtCreateUsername.Size = New Size(318, 39)
        txtCreateUsername.TabIndex = 20
        ' 
        ' pickDesignation
        ' 
        pickDesignation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickDesignation.FormattingEnabled = True
        pickDesignation.Location = New Point(491, 493)
        pickDesignation.Margin = New Padding(4, 3, 4, 3)
        pickDesignation.Name = "pickDesignation"
        pickDesignation.Size = New Size(318, 40)
        pickDesignation.TabIndex = 19
        ' 
        ' pickPosition
        ' 
        pickPosition.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickPosition.FormattingEnabled = True
        pickPosition.Items.AddRange(New Object() {"ΑΑΙ", "AA II", "AA II PANTAWID PAMILYA RPMO", "AA III", "AA III - Sr. Bookkeeper", "AA III / Information Officer NHTS-PR AA III-Municipal Roving Bookkeeper AA-II", "AA-II KALAHI-CIDDS", "AA-II KALAHI-CIDDS NCDDP_AF", "AC - KAASA", "Accountant I", "Accountant I/Officer In Charge", "Accountant II", "Accountant III", "Accounting Clerk", "Acting Secretary", "Acting Social Welfare Officer III", "Activity Therapist ", "Activity Worker I ", "Admin Aide I", "ADMIN AIDE III", "ADMIN AIDE IIII", "Admin Aide IV", "ADMIN AIDE VI", "Admin Assistant", "Admin Assistant III", "Admin Assistant III (Computer Operator II) ", "Admin Assistant V (Private Secretary I)", "Admin cum Finance Officer", "Admin Officer IV-Head, RROS", "Admin. Aide VI", "Admin.Assistant III/Information Officer (LIstahanan)", "Admin. Officer IV/Head", "Admin. Officer V-Unit Head", "Administrative Aide I", "Administrative Aide II", "Administrative Aide III", "Admin Aide IV", "ADMIN AIDE VI", "Admin Assistant", "Admin Assistant III", "Admin Assistant III (Computer Operator II) ", "Admin Assistant V (Private Secretary I)", "Admin cum Finance Officer", "Admin Officer IV-Head, RROS", "Admin. Aide VI", "Admin.Assistant III/Information Officer (LIstahanan)", "Admin.Officer IV/Head", "Admin. Officer V-Unit Head", "Administrative Aide I", "Administrative Aide II", "Administrative Aide III", "Administrative Aide III (Encoder)", "Administrative Aide IV", "Administrative Aide IV (Clerk II)", "Administrative Aide IV(Driver)", "Administrative Aide IV(Encoder)"})
        pickPosition.Location = New Point(491, 283)
        pickPosition.Margin = New Padding(4, 3, 4, 3)
        pickPosition.Name = "pickPosition"
        pickPosition.Size = New Size(318, 40)
        pickPosition.TabIndex = 18
        ' 
        ' pickEmStat
        ' 
        pickEmStat.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickEmStat.FormattingEnabled = True
        pickEmStat.Location = New Point(84, 493)
        pickEmStat.Margin = New Padding(4, 3, 4, 3)
        pickEmStat.Name = "pickEmStat"
        pickEmStat.Size = New Size(318, 40)
        pickEmStat.TabIndex = 17
        ' 
        ' pickEmType
        ' 
        pickEmType.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickEmType.FormattingEnabled = True
        pickEmType.Location = New Point(491, 385)
        pickEmType.Margin = New Padding(4, 3, 4, 3)
        pickEmType.Name = "pickEmType"
        pickEmType.Size = New Size(318, 40)
        pickEmType.TabIndex = 16
        ' 
        ' pickRegion
        ' 
        pickRegion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickRegion.FormattingEnabled = True
        pickRegion.Items.AddRange(New Object() {"BARMM, Bangsamoro Autonomous Region in Muslim Mindanao DSWD-ARMM, Autonomous Region in Muslim Mindanao", "DSWD-CAR, Cordillera Administrative Region", "DSWD-CARAGA, Caraga", "DSWD-Central Office, Central Office", "DSWD-NCR, National Capital Region", "DSWD-NIR, Negros Island Region DSWD-Region 1, Ilocos Region", "DSWD-Region 10, Northern Mindanao", "DSWD-Region 11, Davao Region", "DSWD-Region 12, SOCCSKSARGEN", "DSWD-Region 2, Cagayan Valley ", "DSWD-Region 3, Central Luzon ", "DSWD-Region 5, Bicol Region ", "DSWD-Region 6, Western Visayas ", "DSWD-Region 7, Central Visayas ", "DSWD-Region 8, Eastern Visayas", "DSWD-Region 9, Zamboanga Peninsula ", "DSWD-Region CALABARZON, CALABARZON ", "DSWD-Region MIMAROPA, MIMAROPA", "Dubai UAE, Dubai UAE"})
        pickRegion.Location = New Point(84, 385)
        pickRegion.Margin = New Padding(4, 3, 4, 3)
        pickRegion.Name = "pickRegion"
        pickRegion.Size = New Size(318, 40)
        pickRegion.TabIndex = 15
        ' 
        ' pickOffice
        ' 
        pickOffice.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickOffice.FormattingEnabled = True
        pickOffice.Items.AddRange(New Object() {"4Ps, Pantawid Pamilya Pilipino Program Division", "ADRP, Accounting Division for Regular Programs", "AS-BGMD, Building and Grounds Management Division", "AS-GCD, General Services Division", "AS-OD, Administrative Service ", "AS-PSAMD, Property, Supply Asset Management Division", "AS-RAMD, Records and Archive Management Division", "BangUn Project, Bangsamoro umpungan sa Nutrisyon Project", "BDRP, FMS, Budget Division for regular programs", "CANCELLED, FOR CANCELLATION OF INCORRECT QTY IN STOCK CARD", "CDRP, Cash Division for Regular Programs", "CLinic, Clinic", "CO-SWEAP, Social Welfare Employees Association of the philippines", "COA, Commision on Adult", "CPSB, Community Programs and Services Bureau", "DEF, DEFAULT", "DFA Doha Qatar", "DLLO, Department Legislative", "DMG-DRMB, Disaster Response and Management Group", "DSWD AOC, DSWD Agency Operation Centre", "EPAHP-NPMO, Enhanced Partnership Against Hunger and Proverty", "Exhausted EUL, For Properties with Exhausted Useful Live", "FMS-AD, FMS-Accounting Division", "FMS-ADSP, FMS-Accounting Division for Special Program", "FMS-BD, Budget Division", "FMS-CD, Cash Division", "FMS-GDSP, FMS-Grants Division for Special Program", "FMS-MD, FMS-Management Division", "FMS-OASD, FMS-Office of Assistant Service Director", "FMS-OD, Financial Management Service", "FMS-SP, FMS-Special Project", "FMS-SP, FMS-Strengthening System", "For WRITE-OFF, List of Property for WRITE-OFF", "GASSG-HDPRC, Human Development and Proverty Reduction Cluster", "GASSG-LS, Legal Service", "HRMDS, Human Resource Management & Development", "HRMDS-PAD, HRMDS-Personnel Administration Division", "HRPPMD, HRDS, Human Resource Planning and Performance Mgt. Division", "Human Resource Welfare Div., HRWD, HRDS", "ICTMS, ICTMS", "IDG-OUSEC, Office of U/sec for IDG", "INACTIVE, INACTIVE RECORDS", "Inactive Properties, Expired and Exhausted Properties and Supplies", "ISSO, International Social Service Office", "KC-NCDDP, National Community Driven Development Program (KALAHI-CIDSS)", "Learning and Dev't Div., LDD, HRDS", "LOBBY, Properties in Lobby", "NHTO, National Household Targeting Office", "NRLMB, National Resource & Logistic Management Bureau", "Resource Center", "OAS-Administration, OAS-Administration", "OAS-CIOSD, Office of A/Sec for Centers and Institutions and Other Special Directives", "OAS-Finance For GASSG, OAS-Finance for GASSG", "OAS-LA Office of the Assistant Secretary for Luzon Affairs", "OAS-OPG, Protective", "OAS-OSEC, Office of the Assistant Secretary for OSEC", "OAS-OSEC Concerns, Office of the Assistant Secretary for OSEC Concerns", "OAS-PP, Office of the Assistant Secretary for policy and Plans", "OAS-SCBG, Office of the Assistant Secretary for Standards and Capacity Building Group", "OAS-SP, OAS Statutory Programs", "OAS-Special Projects, Office of the Assistant Secretary for Special Project", "OAS-SS, Office of the Assistant Secretary for Support Service", "OAS-SWD, Office of the Assistant Secretary for Social Welfare and Depelopment", "OAS-VA, Office of the Assistant Secretary for Visayas Affairs", "OASDRMG, Office of the Assistant Secretary for Disaster Response Management group", "OASIMHTS, Office of the Assistant Secretary for Information Management and Household", "Targeting System", "OASMA, Office of the Assistant Secretary for Mindanao Affairs", "OASOPG-PP, Office of Asst. Secretary for OPG-Protective Programs", "OASPP-PDPB, Policy Development and Planning Bureau", "OASPP-RMO, Risk Management Office", "OASPPG-(SB-UCT), Standards Bureau and Unconditional Cash Transfer Project Management", "Office", "OASSC-STB, Social Technology Bureau", "OASSCB - SWIDB, Social Welfare Institutional Development Bureau", "OASSCB-SB, Standard Bureau", "OASSPEP, OAS Specialized Programs", "OASSWCC, Office of the Assistant Secretary for Special Women's and Children's Concern", "OFTRO, Office of the Resident Ombudsman", "OIC, U/SEC for GASSG, OIC, Office of the Undersecretary for GASSG", "OPG-NCTSU, National Convergence Technical Support Unit", "OSEC, Office of the Secretary", "OSG, Office of the Secretary Group", "OSG-IAS, Internal Audit Service", "OSG-SMS, Social Marketing Service", "OSM, OFFICE FOR STRATEGY MANAGEMENT", "OUS-EC, Office of the Undersecretary for Exigent concerns", "OUS-LLA, Office of the Undersecretary Legislative Liason Affairs", "OUS-OPG-Protective, OUS-OPG-Protective", "OUS-PPDLLO, Office of the Secretary for Policy and Plans and Deparment Legislative Liaison Office", "OUS-SC, Office of the Under Secretary for Special Concern", "OUS-Special Projects, Office of the Undersecretary for Special Projects", "OUS-SWD, Office of the Undersecretary for Social Welfare and Development", "OUSDRM, Office of the Undersecretary for Disaster Response Management Group", "OUSEC-ADMIN for GASSG, GENERAL ADMINISTRATION AND SUPPORT SERVICES GROUP", "OUSEC-PPG, Office of U/Sec for PPG - DO NOT USE ", "OUSISP, Office of the Undersecretary for Inclusive and Sustainable Peace", "OUSO, Office of the Undersecretary for Operation", "OUSPPG, Office of the Undersecretary for Policy and plans Group", "OUSSCBG, Office of the Undersecretary for Standards and Capacity Building Group", "OUSSPIM, Office of the Undersecretary for Support Programs Infastructure Management", "PMB, Program Management Bureau", "PMD, Procurement Management Division", "PMD-BACSS, Bids and Awards Commitee Secretariat Section", "PMD-CMS, Contract Management Section", "PMD-PPMS, Procurement Planning and Management Section", "PROMOTIVE-OPG, Promotive Operation and Programs Group", "PROPERTY, WAREHOUSE, PROPERTY, WAREHOUSE", "PROTECTIVE-OPG, Protective Operation and Programs Group", "PSB-SWATO, Social Welfare Attche", "PSFMO-CIU, PSFMO-CIU", "RECLASSIFIED PROPERTY, RECLASSIFIED PROPERTY", "RGMO, Resource Generation and Management Office", "Security Guard, Security Guard", "SLP, Sustainable Livelihood Program", "Supplier, DSWD - Supplier", "SWADCAP, Social Welfare And Development Center Asia Pacific", "SWEMC, SWEMC", "SWIDB, (DO NOT USE) Social Welfare Institutional Development Bureau", "TCT,NPMO, Targeted Cash transfer NPMO", "", "", "", "", "", "", "", "", ""})
        pickOffice.Location = New Point(84, 283)
        pickOffice.Margin = New Padding(4, 3, 4, 3)
        pickOffice.Name = "pickOffice"
        pickOffice.Size = New Size(318, 40)
        pickOffice.TabIndex = 14
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtEmail.Location = New Point(491, 183)
        txtEmail.Margin = New Padding(4, 3, 4, 3)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(318, 39)
        txtEmail.TabIndex = 13
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtContact.Location = New Point(84, 183)
        txtContact.Margin = New Padding(4, 3, 4, 3)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(318, 39)
        txtContact.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(84, 60)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 23)
        Label1.TabIndex = 0
        Label1.Text = "FIRST NAME"
        ' 
        ' txtFname
        ' 
        txtFname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtFname.Location = New Point(84, 90)
        txtFname.Margin = New Padding(4, 3, 4, 3)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(318, 39)
        txtFname.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Yellow
        Label3.Location = New Point(84, 160)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 23)
        Label3.TabIndex = 2
        Label3.Text = "CONTACT"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.Yellow
        Label9.Location = New Point(491, 463)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(171, 23)
        Label9.TabIndex = 10
        Label9.Text = "DESIGNATION"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Yellow
        Label4.Location = New Point(491, 153)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 23)
        Label4.TabIndex = 3
        Label4.Text = "EMAIL"
        ' 
        ' pBoxCreateProfile
        ' 
        pBoxCreateProfile.BackgroundImage = My.Resources.Resources.user
        pBoxCreateProfile.BackgroundImageLayout = ImageLayout.Stretch
        pBoxCreateProfile.BorderStyle = BorderStyle.Fixed3D
        pBoxCreateProfile.Location = New Point(871, 90)
        pBoxCreateProfile.Margin = New Padding(4, 3, 4, 3)
        pBoxCreateProfile.Name = "pBoxCreateProfile"
        pBoxCreateProfile.Size = New Size(214, 239)
        pBoxCreateProfile.SizeMode = PictureBoxSizeMode.StretchImage
        pBoxCreateProfile.TabIndex = 9
        pBoxCreateProfile.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Yellow
        Label5.Location = New Point(84, 253)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 23)
        Label5.TabIndex = 4
        Label5.Text = "OFFICE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Yellow
        Label8.Location = New Point(84, 355)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 23)
        Label8.TabIndex = 8
        Label8.Text = "REGION"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Yellow
        Label6.Location = New Point(491, 253)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 23)
        Label6.TabIndex = 5
        Label6.Text = "POSITION"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Yellow
        Label7.Location = New Point(491, 355)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(236, 23)
        Label7.TabIndex = 7
        Label7.Text = "EMPLOYMENT TYPE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Yellow
        Label2.Location = New Point(84, 463)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(304, 23)
        Label2.TabIndex = 6
        Label2.Text = "STATUS OF EMPLOYMENT"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkRed
        Panel1.Controls.Add(btnCancel)
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
        Panel1.Location = New Point(14, 15)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"

        Panel1.Size = New Size(822, 562)

        Panel1.Size = New Size(1174, 837)


        Panel1.Size = New Size(1174, 837)

        Panel1.TabIndex = 13
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.Yellow
        Label12.Location = New Point(491, 62)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(141, 23)
        Label12.TabIndex = 0
        Label12.Text = "LAST NAME"
        ' 
        ' txtLname
        ' 
        txtLname.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtLname.Location = New Point(491, 90)
        txtLname.Margin = New Padding(4, 3, 4, 3)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(318, 39)
        txtLname.TabIndex = 11
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(51))

        ClientSize = New Size(844, 582)

        ClientSize = New Size(1206, 870)


        ClientSize = New Size(1206, 870)

        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Signup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Signup"
        CType(pBoxCreateProfile, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCancel As Button
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
