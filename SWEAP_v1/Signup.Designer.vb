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
        Label6 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label12 = New Label()
        txtLname = New TextBox()
        Label13 = New Label()
        txtMname = New TextBox()
        txtAdd = New TextBox()
        Label14 = New Label()
        txtEduc = New TextBox()
        Label15 = New Label()
        DatePickerBdate = New DateTimePicker()
        Label16 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        TextBox13 = New TextBox()
        TextBox14 = New TextBox()
        TextBox15 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        CType(pBoxCreateProfile, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(255), CByte(211), CByte(42))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancel.Location = New Point(344, 627)
        btnCancel.Margin = New Padding(3, 2, 3, 2)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(176, 34)
        btnCancel.TabIndex = 29
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(255), CByte(211), CByte(42))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegister.Location = New Point(622, 627)
        btnRegister.Margin = New Padding(3, 2, 3, 2)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(176, 34)
        btnRegister.TabIndex = 28
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' ButtonUpload
        ' 
        ButtonUpload.BackColor = Color.FromArgb(CByte(255), CByte(211), CByte(42))
        ButtonUpload.FlatStyle = FlatStyle.Flat
        ButtonUpload.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonUpload.Image = CType(resources.GetObject("ButtonUpload.Image"), Image)
        ButtonUpload.ImageAlign = ContentAlignment.MiddleLeft
        ButtonUpload.Location = New Point(873, 215)
        ButtonUpload.Margin = New Padding(3, 2, 3, 2)
        ButtonUpload.Name = "ButtonUpload"
        ButtonUpload.Size = New Size(174, 31)
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
        Label11.Location = New Point(328, 342)
        Label11.Name = "Label11"
        Label11.Size = New Size(96, 16)
        Label11.TabIndex = 25
        Label11.Text = "PASSWORD "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Yellow
        Label10.Location = New Point(43, 342)
        Label10.Name = "Label10"
        Label10.Size = New Size(93, 16)
        Label10.TabIndex = 23
        Label10.Text = "USERNAME"
        ' 
        ' txtCreatePw
        ' 
        txtCreatePw.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtCreatePw.Location = New Point(328, 360)
        txtCreatePw.Margin = New Padding(3, 2, 3, 2)
        txtCreatePw.Name = "txtCreatePw"
        txtCreatePw.Size = New Size(224, 29)
        txtCreatePw.TabIndex = 21
        ' 
        ' txtCreateUsername
        ' 
        txtCreateUsername.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtCreateUsername.Location = New Point(43, 360)
        txtCreateUsername.Margin = New Padding(3, 2, 3, 2)
        txtCreateUsername.Name = "txtCreateUsername"
        txtCreateUsername.Size = New Size(224, 29)
        txtCreateUsername.TabIndex = 20
        ' 
        ' pickDesignation
        ' 
        pickDesignation.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        pickDesignation.FormattingEnabled = True
        pickDesignation.Items.AddRange(New Object() {"Education, Information & Research", "Organizing & Membership", "Grievances", "Welfare", "Finance", "Sports & Culture"})
        pickDesignation.Location = New Point(331, 297)
        pickDesignation.Margin = New Padding(3, 2, 3, 2)
        pickDesignation.Name = "pickDesignation"
        pickDesignation.Size = New Size(224, 29)
        pickDesignation.TabIndex = 19
        ' 
        ' pickPosition
        ' 
        pickPosition.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        pickPosition.FormattingEnabled = True
        pickPosition.Items.AddRange(New Object() {"ΑΑΙ", "AA II", "AA II PANTAWID PAMILYA RPMO", "AA III", "AA III - Sr. Bookkeeper", "AA III / Information Officer NHTS-PR AA III-Municipal Roving Bookkeeper AA-II", "AA-II KALAHI-CIDDS", "AA-II KALAHI-CIDDS NCDDP_AF", "AC - KAASA", "Accountant I", "Accountant I/Officer In Charge", "Accountant II", "Accountant III", "Accounting Clerk", "Acting Secretary", "Acting Social Welfare Officer III", "Activity Therapist ", "Activity Worker I ", "Admin Aide I", "ADMIN AIDE III", "ADMIN AIDE IIII", "Admin Aide IV", "ADMIN AIDE VI", "Admin Assistant", "Admin Assistant III", "Admin Assistant III (Computer Operator II) ", "Admin Assistant V (Private Secretary I)", "Admin cum Finance Officer", "Admin Officer IV-Head, RROS", "Admin. Aide VI", "Admin.Assistant III/Information Officer (LIstahanan)", "Admin. Officer IV/Head", "Admin. Officer V-Unit Head", "Administrative Aide I", "Administrative Aide II", "Administrative Aide III", "Admin Aide IV", "ADMIN AIDE VI", "Admin Assistant", "Admin Assistant III", "Admin Assistant III (Computer Operator II) ", "Admin Assistant V (Private Secretary I)", "Admin cum Finance Officer", "Admin Officer IV-Head, RROS", "Admin. Aide VI", "Admin.Assistant III/Information Officer (LIstahanan)", "Admin.Officer IV/Head", "Admin. Officer V-Unit Head", "Administrative Aide I", "Administrative Aide II", "Administrative Aide III", "Administrative Aide III (Encoder)", "Administrative Aide IV", "Administrative Aide IV (Clerk II)", "Administrative Aide IV(Driver)", "Administrative Aide IV(Encoder)"})
        pickPosition.Location = New Point(616, 233)
        pickPosition.Margin = New Padding(3, 2, 3, 2)
        pickPosition.Name = "pickPosition"
        pickPosition.Size = New Size(224, 29)
        pickPosition.TabIndex = 18
        ' 
        ' pickEmStat
        ' 
        pickEmStat.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        pickEmStat.FormattingEnabled = True
        pickEmStat.Items.AddRange(New Object() {"MOA/COS", "CASUAL/CONTRACTUAL", "REGULAR", "TEMPORARY"})
        pickEmStat.Location = New Point(43, 297)
        pickEmStat.Margin = New Padding(3, 2, 3, 2)
        pickEmStat.Name = "pickEmStat"
        pickEmStat.Size = New Size(224, 29)
        pickEmStat.TabIndex = 17
        ' 
        ' pickOffice
        ' 
        pickOffice.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        pickOffice.FormattingEnabled = True
        pickOffice.Items.AddRange(New Object() {"4Ps, Pantawid Pamilya Pilipino Program Division", "ADRP, Accounting Division for Regular Programs", "AS-BGMD, Building and Grounds Management Division", "AS-GCD, General Services Division", "AS-OD, Administrative Service ", "AS-PSAMD, Property, Supply Asset Management Division", "AS-RAMD, Records and Archive Management Division", "BangUn Project, Bangsamoro umpungan sa Nutrisyon Project", "BDRP, FMS, Budget Division for regular programs", "CANCELLED, FOR CANCELLATION OF INCORRECT QTY IN STOCK CARD", "CDRP, Cash Division for Regular Programs", "CLinic, Clinic", "CO-SWEAP, Social Welfare Employees Association of the philippines", "COA, Commision on Adult", "CPSB, Community Programs and Services Bureau", "DEF, DEFAULT", "DFA Doha Qatar", "DLLO, Department Legislative", "DMG-DRMB, Disaster Response and Management Group", "DSWD AOC, DSWD Agency Operation Centre", "EPAHP-NPMO, Enhanced Partnership Against Hunger and Proverty", "Exhausted EUL, For Properties with Exhausted Useful Live", "FMS-AD, FMS-Accounting Division", "FMS-ADSP, FMS-Accounting Division for Special Program", "FMS-BD, Budget Division", "FMS-CD, Cash Division", "FMS-GDSP, FMS-Grants Division for Special Program", "FMS-MD, FMS-Management Division", "FMS-OASD, FMS-Office of Assistant Service Director", "FMS-OD, Financial Management Service", "FMS-SP, FMS-Special Project", "FMS-SP, FMS-Strengthening System", "For WRITE-OFF, List of Property for WRITE-OFF", "GASSG-HDPRC, Human Development and Proverty Reduction Cluster", "GASSG-LS, Legal Service", "HRMDS, Human Resource Management & Development", "HRMDS-PAD, HRMDS-Personnel Administration Division", "HRPPMD, HRDS, Human Resource Planning and Performance Mgt. Division", "Human Resource Welfare Div., HRWD, HRDS", "ICTMS, ICTMS", "IDG-OUSEC, Office of U/sec for IDG", "INACTIVE, INACTIVE RECORDS", "Inactive Properties, Expired and Exhausted Properties and Supplies", "ISSO, International Social Service Office", "KC-NCDDP, National Community Driven Development Program (KALAHI-CIDSS)", "Learning and Dev't Div., LDD, HRDS", "LOBBY, Properties in Lobby", "NHTO, National Household Targeting Office", "NRLMB, National Resource & Logistic Management Bureau", "Resource Center", "OAS-Administration, OAS-Administration", "OAS-CIOSD, Office of A/Sec for Centers and Institutions and Other Special Directives", "OAS-Finance For GASSG, OAS-Finance for GASSG", "OAS-LA Office of the Assistant Secretary for Luzon Affairs", "OAS-OPG, Protective", "OAS-OSEC, Office of the Assistant Secretary for OSEC", "OAS-OSEC Concerns, Office of the Assistant Secretary for OSEC Concerns", "OAS-PP, Office of the Assistant Secretary for policy and Plans", "OAS-SCBG, Office of the Assistant Secretary for Standards and Capacity Building Group", "OAS-SP, OAS Statutory Programs", "OAS-Special Projects, Office of the Assistant Secretary for Special Project", "OAS-SS, Office of the Assistant Secretary for Support Service", "OAS-SWD, Office of the Assistant Secretary for Social Welfare and Depelopment", "OAS-VA, Office of the Assistant Secretary for Visayas Affairs", "OASDRMG, Office of the Assistant Secretary for Disaster Response Management group", "OASIMHTS, Office of the Assistant Secretary for Information Management and Household", "Targeting System", "OASMA, Office of the Assistant Secretary for Mindanao Affairs", "OASOPG-PP, Office of Asst. Secretary for OPG-Protective Programs", "OASPP-PDPB, Policy Development and Planning Bureau", "OASPP-RMO, Risk Management Office", "OASPPG-(SB-UCT), Standards Bureau and Unconditional Cash Transfer Project Management", "Office", "OASSC-STB, Social Technology Bureau", "OASSCB - SWIDB, Social Welfare Institutional Development Bureau", "OASSCB-SB, Standard Bureau", "OASSPEP, OAS Specialized Programs", "OASSWCC, Office of the Assistant Secretary for Special Women's and Children's Concern", "OFTRO, Office of the Resident Ombudsman", "OIC, U/SEC for GASSG, OIC, Office of the Undersecretary for GASSG", "OPG-NCTSU, National Convergence Technical Support Unit", "OSEC, Office of the Secretary", "OSG, Office of the Secretary Group", "OSG-IAS, Internal Audit Service", "OSG-SMS, Social Marketing Service", "OSM, OFFICE FOR STRATEGY MANAGEMENT", "OUS-EC, Office of the Undersecretary for Exigent concerns", "OUS-LLA, Office of the Undersecretary Legislative Liason Affairs", "OUS-OPG-Protective, OUS-OPG-Protective", "OUS-PPDLLO, Office of the Secretary for Policy and Plans and Deparment Legislative Liaison Office", "OUS-SC, Office of the Under Secretary for Special Concern", "OUS-Special Projects, Office of the Undersecretary for Special Projects", "OUS-SWD, Office of the Undersecretary for Social Welfare and Development", "OUSDRM, Office of the Undersecretary for Disaster Response Management Group", "OUSEC-ADMIN for GASSG, GENERAL ADMINISTRATION AND SUPPORT SERVICES GROUP", "OUSEC-PPG, Office of U/Sec for PPG - DO NOT USE ", "OUSISP, Office of the Undersecretary for Inclusive and Sustainable Peace", "OUSO, Office of the Undersecretary for Operation", "OUSPPG, Office of the Undersecretary for Policy and plans Group", "OUSSCBG, Office of the Undersecretary for Standards and Capacity Building Group", "OUSSPIM, Office of the Undersecretary for Support Programs Infastructure Management", "PMB, Program Management Bureau", "PMD, Procurement Management Division", "PMD-BACSS, Bids and Awards Commitee Secretariat Section", "PMD-CMS, Contract Management Section", "PMD-PPMS, Procurement Planning and Management Section", "PROMOTIVE-OPG, Promotive Operation and Programs Group", "PROPERTY, WAREHOUSE, PROPERTY, WAREHOUSE", "PROTECTIVE-OPG, Protective Operation and Programs Group", "PSB-SWATO, Social Welfare Attche", "PSFMO-CIU, PSFMO-CIU", "RECLASSIFIED PROPERTY, RECLASSIFIED PROPERTY", "RGMO, Resource Generation and Management Office", "Security Guard, Security Guard", "SLP, Sustainable Livelihood Program", "Supplier, DSWD - Supplier", "SWADCAP, Social Welfare And Development Center Asia Pacific", "SWEMC, SWEMC", "SWIDB, (DO NOT USE) Social Welfare Institutional Development Bureau", "TCT,NPMO, Targeted Cash transfer NPMO", "", "", "", "", "", "", "", "", ""})
        pickOffice.Location = New Point(331, 233)
        pickOffice.Margin = New Padding(3, 2, 3, 2)
        pickOffice.Name = "pickOffice"
        pickOffice.Size = New Size(224, 29)
        pickOffice.TabIndex = 14
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtEmail.Location = New Point(328, 176)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(224, 29)
        txtEmail.TabIndex = 13
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtContact.Location = New Point(43, 176)
        txtContact.Margin = New Padding(3, 2, 3, 2)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(224, 29)
        txtContact.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(43, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 16)
        Label1.TabIndex = 0
        Label1.Text = "FIRST NAME"
        ' 
        ' txtFname
        ' 
        txtFname.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtFname.Location = New Point(43, 54)
        txtFname.Margin = New Padding(3, 2, 3, 2)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(224, 29)
        txtFname.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Yellow
        Label3.Location = New Point(43, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 16)
        Label3.TabIndex = 2
        Label3.Text = "CONTACT"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.Yellow
        Label9.Location = New Point(331, 279)
        Label9.Name = "Label9"
        Label9.Size = New Size(270, 16)
        Label9.TabIndex = 10
        Label9.Text = "COMMITTEE'S YOU WANT TO JOIN"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Yellow
        Label4.Location = New Point(328, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 16)
        Label4.TabIndex = 3
        Label4.Text = "EMAIL"
        ' 
        ' pBoxCreateProfile
        ' 
        pBoxCreateProfile.BackgroundImage = My.Resources.Resources.user
        pBoxCreateProfile.BackgroundImageLayout = ImageLayout.Stretch
        pBoxCreateProfile.BorderStyle = BorderStyle.Fixed3D
        pBoxCreateProfile.Location = New Point(873, 54)
        pBoxCreateProfile.Margin = New Padding(3, 2, 3, 2)
        pBoxCreateProfile.Name = "pBoxCreateProfile"
        pBoxCreateProfile.Size = New Size(174, 151)
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
        Label5.Location = New Point(331, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 16)
        Label5.TabIndex = 4
        Label5.Text = "OFFICE"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Yellow
        Label6.Location = New Point(616, 215)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 16)
        Label6.TabIndex = 5
        Label6.Text = "POSITION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Yellow
        Label2.Location = New Point(43, 279)
        Label2.Name = "Label2"
        Label2.Size = New Size(181, 16)
        Label2.TabIndex = 6
        Label2.Text = "EMPLOYMENT STATUS"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkRed
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TextBox13)
        Panel1.Controls.Add(TextBox14)
        Panel1.Controls.Add(TextBox15)
        Panel1.Controls.Add(TextBox12)
        Panel1.Controls.Add(TextBox11)
        Panel1.Controls.Add(TextBox10)
        Panel1.Controls.Add(TextBox9)
        Panel1.Controls.Add(TextBox8)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(btnRegister)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(DatePickerBdate)
        Panel1.Controls.Add(txtEduc)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(txtAdd)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(txtMname)
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(ButtonUpload)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(txtCreatePw)
        Panel1.Controls.Add(txtCreateUsername)
        Panel1.Controls.Add(pickDesignation)
        Panel1.Controls.Add(pickPosition)
        Panel1.Controls.Add(pickEmStat)
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
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(10, 9)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1078, 675)
        Panel1.TabIndex = 13
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.Yellow
        Label12.Location = New Point(616, 37)
        Label12.Name = "Label12"
        Label12.Size = New Size(96, 16)
        Label12.TabIndex = 0
        Label12.Text = "LAST NAME"
        ' 
        ' txtLname
        ' 
        txtLname.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtLname.Location = New Point(616, 54)
        txtLname.Margin = New Padding(3, 2, 3, 2)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(224, 29)
        txtLname.TabIndex = 11
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.Yellow
        Label13.Location = New Point(328, 37)
        Label13.Name = "Label13"
        Label13.Size = New Size(118, 16)
        Label13.TabIndex = 30
        Label13.Text = "MIDDLE NAME"
        ' 
        ' txtMname
        ' 
        txtMname.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtMname.Location = New Point(328, 54)
        txtMname.Margin = New Padding(3, 2, 3, 2)
        txtMname.Name = "txtMname"
        txtMname.Size = New Size(224, 29)
        txtMname.TabIndex = 31
        ' 
        ' txtAdd
        ' 
        txtAdd.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtAdd.Location = New Point(43, 111)
        txtAdd.Margin = New Padding(3, 2, 3, 2)
        txtAdd.Multiline = True
        txtAdd.Name = "txtAdd"
        txtAdd.Size = New Size(797, 38)
        txtAdd.TabIndex = 33
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.ForeColor = Color.Yellow
        Label14.Location = New Point(43, 93)
        Label14.Name = "Label14"
        Label14.Size = New Size(124, 16)
        Label14.TabIndex = 32
        Label14.Text = "FULL ADDRESS"
        ' 
        ' txtEduc
        ' 
        txtEduc.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtEduc.Location = New Point(616, 176)
        txtEduc.Margin = New Padding(3, 2, 3, 2)
        txtEduc.Name = "txtEduc"
        txtEduc.Size = New Size(224, 29)
        txtEduc.TabIndex = 35
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.ForeColor = Color.Yellow
        Label15.Location = New Point(616, 158)
        Label15.Name = "Label15"
        Label15.Size = New Size(227, 16)
        Label15.TabIndex = 34
        Label15.Text = "EDUCATIONAL ATTAINMENT"
        ' 
        ' DatePickerBdate
        ' 
        DatePickerBdate.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        DatePickerBdate.Location = New Point(43, 233)
        DatePickerBdate.Name = "DatePickerBdate"
        DatePickerBdate.Size = New Size(224, 29)
        DatePickerBdate.TabIndex = 36
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.ForeColor = Color.Yellow
        Label16.Location = New Point(43, 214)
        Label16.Name = "Label16"
        Label16.Size = New Size(96, 16)
        Label16.TabIndex = 37
        Label16.Text = "BIRTHDATE"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(108, 448)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(425, 29)
        TextBox1.TabIndex = 39
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(108, 481)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(425, 29)
        TextBox2.TabIndex = 40
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(108, 514)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(425, 29)
        TextBox3.TabIndex = 41
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(108, 547)
        TextBox4.Margin = New Padding(3, 2, 3, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(425, 29)
        TextBox4.TabIndex = 42
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(539, 448)
        TextBox5.Margin = New Padding(3, 2, 3, 2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(257, 29)
        TextBox5.TabIndex = 43
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox6.Location = New Point(539, 481)
        TextBox6.Margin = New Padding(3, 2, 3, 2)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(257, 29)
        TextBox6.TabIndex = 44
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox7.Location = New Point(539, 514)
        TextBox7.Margin = New Padding(3, 2, 3, 2)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(257, 29)
        TextBox7.TabIndex = 45
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox8.Location = New Point(539, 547)
        TextBox8.Margin = New Padding(3, 2, 3, 2)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(257, 29)
        TextBox8.TabIndex = 46
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox9.Location = New Point(802, 448)
        TextBox9.Margin = New Padding(3, 2, 3, 2)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(136, 29)
        TextBox9.TabIndex = 47
        ' 
        ' TextBox10
        ' 
        TextBox10.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox10.Location = New Point(802, 481)
        TextBox10.Margin = New Padding(3, 2, 3, 2)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(136, 29)
        TextBox10.TabIndex = 48
        ' 
        ' TextBox11
        ' 
        TextBox11.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox11.Location = New Point(802, 514)
        TextBox11.Margin = New Padding(3, 2, 3, 2)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(136, 29)
        TextBox11.TabIndex = 49
        ' 
        ' TextBox12
        ' 
        TextBox12.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox12.Location = New Point(802, 547)
        TextBox12.Margin = New Padding(3, 2, 3, 2)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(136, 29)
        TextBox12.TabIndex = 50
        ' 
        ' TextBox13
        ' 
        TextBox13.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox13.Location = New Point(802, 580)
        TextBox13.Margin = New Padding(3, 2, 3, 2)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(136, 29)
        TextBox13.TabIndex = 53
        ' 
        ' TextBox14
        ' 
        TextBox14.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox14.Location = New Point(539, 580)
        TextBox14.Margin = New Padding(3, 2, 3, 2)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(257, 29)
        TextBox14.TabIndex = 52
        ' 
        ' TextBox15
        ' 
        TextBox15.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox15.Location = New Point(108, 580)
        TextBox15.Margin = New Padding(3, 2, 3, 2)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(425, 29)
        TextBox15.TabIndex = 51
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Yellow
        Label7.Location = New Point(280, 430)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 16)
        Label7.TabIndex = 54
        Label7.Text = "NAME"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Yellow
        Label8.Location = New Point(600, 430)
        Label8.Name = "Label8"
        Label8.Size = New Size(123, 16)
        Label8.TabIndex = 55
        Label8.Text = "RELATIONSHIP"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.ForeColor = Color.Yellow
        Label17.Location = New Point(845, 430)
        Label17.Name = "Label17"
        Label17.Size = New Size(38, 16)
        Label17.TabIndex = 56
        Label17.Text = "AGE"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.ForeColor = Color.Yellow
        Label18.Location = New Point(6, 5)
        Label18.Name = "Label18"
        Label18.Size = New Size(231, 23)
        Label18.TabIndex = 57
        Label18.Text = "MEMBERSHIP FORM"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.ForeColor = Color.Yellow
        Label19.Location = New Point(6, 405)
        Label19.Name = "Label19"
        Label19.Size = New Size(185, 23)
        Label19.TabIndex = 58
        Label19.Text = "BENEFICIARIES"
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(51))
        ClientSize = New Size(1100, 695)
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtEduc As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DatePickerBdate As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
End Class
