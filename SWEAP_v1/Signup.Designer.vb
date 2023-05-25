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
        pickCommittee = New ComboBox()
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
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        txtBenifAge5 = New TextBox()
        txtBenifRel5 = New TextBox()
        txtBenifName5 = New TextBox()
        txtBenifAge4 = New TextBox()
        txtBenifAge3 = New TextBox()
        txtBenifAge2 = New TextBox()
        txtBenifAge1 = New TextBox()
        txtBenifRel4 = New TextBox()
        txtBenifRel3 = New TextBox()
        txtBenifRel2 = New TextBox()
        txtBenifRel1 = New TextBox()
        txtBenifName4 = New TextBox()
        txtBenifName3 = New TextBox()
        txtBenifName2 = New TextBox()
        txtBenifName1 = New TextBox()
        Label16 = New Label()
        pickBDate = New DateTimePicker()
        txtEduc = New TextBox()
        Label15 = New Label()
        txtAddress = New TextBox()
        Label14 = New Label()
        Label13 = New Label()
        txtMname = New TextBox()
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
        btnCancel.Location = New Point(311, 603)
        btnCancel.Margin = New Padding(2, 1, 2, 1)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(139, 39)
        btnCancel.TabIndex = 29
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(255), CByte(211), CByte(42))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegister.Location = New Point(545, 603)
        btnRegister.Margin = New Padding(2, 1, 2, 1)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(139, 39)
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
        ButtonUpload.Location = New Point(803, 204)
        ButtonUpload.Margin = New Padding(2, 1, 2, 1)
        ButtonUpload.Name = "ButtonUpload"
        ButtonUpload.Size = New Size(164, 32)
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
        Label11.Location = New Point(290, 325)
        Label11.Margin = New Padding(2, 0, 2, 0)
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
        Label10.Location = New Point(41, 325)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(93, 16)
        Label10.TabIndex = 23
        Label10.Text = "USERNAME"
        ' 
        ' txtCreatePw
        ' 
        txtCreatePw.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtCreatePw.Location = New Point(290, 342)
        txtCreatePw.Margin = New Padding(2, 1, 2, 1)
        txtCreatePw.Name = "txtCreatePw"
        txtCreatePw.Size = New Size(230, 29)
        txtCreatePw.TabIndex = 21
        ' 
        ' txtCreateUsername
        ' 
        txtCreateUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtCreateUsername.Location = New Point(41, 342)
        txtCreateUsername.Margin = New Padding(2, 1, 2, 1)
        txtCreateUsername.Name = "txtCreateUsername"
        txtCreateUsername.Size = New Size(230, 29)
        txtCreateUsername.TabIndex = 20
        ' 
        ' pickCommittee
        ' 
        pickCommittee.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickCommittee.FormattingEnabled = True
        pickCommittee.Items.AddRange(New Object() {"Education, Information & Research", "Organizing & Membership", "Grievances", "Welfare", "Finance", "Sports & Culture"})
        pickCommittee.Location = New Point(290, 282)
        pickCommittee.Margin = New Padding(2, 1, 2, 1)
        pickCommittee.Name = "pickCommittee"
        pickCommittee.Size = New Size(230, 29)
        pickCommittee.TabIndex = 19
        ' 
        ' pickPosition
        ' 
        pickPosition.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickPosition.FormattingEnabled = True
        pickPosition.Items.AddRange(New Object() {"ΑΑΙ", "AA II", "AA II PANTAWID PAMILYA RPMO", "AA III", "AA III - Sr. Bookkeeper", "AA III / Information Officer NHTS-PR AA III-Municipal Roving Bookkeeper AA-II", "AA-II KALAHI-CIDDS", "AA-II KALAHI-CIDDS NCDDP_AF", "AC - KAASA", "Accountant I", "Accountant I/Officer In Charge", "Accountant II", "Accountant III", "Accounting Clerk", "Acting Secretary", "Acting Social Welfare Officer III", "Activity Therapist ", "Activity Worker I ", "Admin Aide I", "ADMIN AIDE III", "ADMIN AIDE IIII", "Admin Aide IV", "ADMIN AIDE VI", "Admin Assistant", "Admin Assistant III", "Admin Assistant III (Computer Operator II) ", "Admin Assistant V (Private Secretary I)", "Admin cum Finance Officer", "Admin Officer IV-Head, RROS", "Admin. Aide VI", "Admin.Assistant III/Information Officer (LIstahanan)", "Admin. Officer IV/Head", "Admin. Officer V-Unit Head", "Administrative Aide I", "Administrative Aide II", "Administrative Aide III", "Admin Aide IV", "ADMIN AIDE VI", "Admin Assistant", "Admin Assistant III", "Admin Assistant III (Computer Operator II) ", "Admin Assistant V (Private Secretary I)", "Admin cum Finance Officer", "Admin Officer IV-Head, RROS", "Admin. Aide VI", "Admin.Assistant III/Information Officer (LIstahanan)", "Admin.Officer IV/Head", "Admin. Officer V-Unit Head", "Administrative Aide I", "Administrative Aide II", "Administrative Aide III", "Administrative Aide III (Encoder)", "Administrative Aide IV", "Administrative Aide IV (Clerk II)", "Administrative Aide IV(Driver)", "Administrative Aide IV(Encoder)"})
        pickPosition.Location = New Point(538, 224)
        pickPosition.Margin = New Padding(2, 1, 2, 1)
        pickPosition.Name = "pickPosition"
        pickPosition.Size = New Size(230, 29)
        pickPosition.TabIndex = 18
        ' 
        ' pickEmStat
        ' 
        pickEmStat.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickEmStat.FormattingEnabled = True
        pickEmStat.Items.AddRange(New Object() {"MOA/COS", "CASUAL/CONTRACTUAL", "REGULAR", "TEMPORARY"})
        pickEmStat.Location = New Point(41, 282)
        pickEmStat.Margin = New Padding(2, 1, 2, 1)
        pickEmStat.Name = "pickEmStat"
        pickEmStat.Size = New Size(230, 29)
        pickEmStat.TabIndex = 17
        ' 
        ' pickOffice
        ' 
        pickOffice.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickOffice.FormattingEnabled = True
        pickOffice.Items.AddRange(New Object() {"4Ps, Pantawid Pamilya Pilipino Program Division", "ADRP, Accounting Division for Regular Programs", "AS-BGMD, Building and Grounds Management Division", "AS-GCD, General Services Division", "AS-OD, Administrative Service ", "AS-PSAMD, Property, Supply Asset Management Division", "AS-RAMD, Records and Archive Management Division", "BangUn Project, Bangsamoro umpungan sa Nutrisyon Project", "BDRP, FMS, Budget Division for regular programs", "CANCELLED, FOR CANCELLATION OF INCORRECT QTY IN STOCK CARD", "CDRP, Cash Division for Regular Programs", "CLinic, Clinic", "CO-SWEAP, Social Welfare Employees Association of the philippines", "COA, Commision on Adult", "CPSB, Community Programs and Services Bureau", "DEF, DEFAULT", "DFA Doha Qatar", "DLLO, Department Legislative", "DMG-DRMB, Disaster Response and Management Group", "DSWD AOC, DSWD Agency Operation Centre", "EPAHP-NPMO, Enhanced Partnership Against Hunger and Proverty", "Exhausted EUL, For Properties with Exhausted Useful Live", "FMS-AD, FMS-Accounting Division", "FMS-ADSP, FMS-Accounting Division for Special Program", "FMS-BD, Budget Division", "FMS-CD, Cash Division", "FMS-GDSP, FMS-Grants Division for Special Program", "FMS-MD, FMS-Management Division", "FMS-OASD, FMS-Office of Assistant Service Director", "FMS-OD, Financial Management Service", "FMS-SP, FMS-Special Project", "FMS-SP, FMS-Strengthening System", "For WRITE-OFF, List of Property for WRITE-OFF", "GASSG-HDPRC, Human Development and Proverty Reduction Cluster", "GASSG-LS, Legal Service", "HRMDS, Human Resource Management & Development", "HRMDS-PAD, HRMDS-Personnel Administration Division", "HRPPMD, HRDS, Human Resource Planning and Performance Mgt. Division", "Human Resource Welfare Div., HRWD, HRDS", "ICTMS, ICTMS", "IDG-OUSEC, Office of U/sec for IDG", "INACTIVE, INACTIVE RECORDS", "Inactive Properties, Expired and Exhausted Properties and Supplies", "ISSO, International Social Service Office", "KC-NCDDP, National Community Driven Development Program (KALAHI-CIDSS)", "Learning and Dev't Div., LDD, HRDS", "LOBBY, Properties in Lobby", "NHTO, National Household Targeting Office", "NRLMB, National Resource & Logistic Management Bureau", "Resource Center", "OAS-Administration, OAS-Administration", "OAS-CIOSD, Office of A/Sec for Centers and Institutions and Other Special Directives", "OAS-Finance For GASSG, OAS-Finance for GASSG", "OAS-LA Office of the Assistant Secretary for Luzon Affairs", "OAS-OPG, Protective", "OAS-OSEC, Office of the Assistant Secretary for OSEC", "OAS-OSEC Concerns, Office of the Assistant Secretary for OSEC Concerns", "OAS-PP, Office of the Assistant Secretary for policy and Plans", "OAS-SCBG, Office of the Assistant Secretary for Standards and Capacity Building Group", "OAS-SP, OAS Statutory Programs", "OAS-Special Projects, Office of the Assistant Secretary for Special Project", "OAS-SS, Office of the Assistant Secretary for Support Service", "OAS-SWD, Office of the Assistant Secretary for Social Welfare and Depelopment", "OAS-VA, Office of the Assistant Secretary for Visayas Affairs", "OASDRMG, Office of the Assistant Secretary for Disaster Response Management group", "OASIMHTS, Office of the Assistant Secretary for Information Management and Household", "Targeting System", "OASMA, Office of the Assistant Secretary for Mindanao Affairs", "OASOPG-PP, Office of Asst. Secretary for OPG-Protective Programs", "OASPP-PDPB, Policy Development and Planning Bureau", "OASPP-RMO, Risk Management Office", "OASPPG-(SB-UCT), Standards Bureau and Unconditional Cash Transfer Project Management", "Office", "OASSC-STB, Social Technology Bureau", "OASSCB - SWIDB, Social Welfare Institutional Development Bureau", "OASSCB-SB, Standard Bureau", "OASSPEP, OAS Specialized Programs", "OASSWCC, Office of the Assistant Secretary for Special Women's and Children's Concern", "OFTRO, Office of the Resident Ombudsman", "OIC, U/SEC for GASSG, OIC, Office of the Undersecretary for GASSG", "OPG-NCTSU, National Convergence Technical Support Unit", "OSEC, Office of the Secretary", "OSG, Office of the Secretary Group", "OSG-IAS, Internal Audit Service", "OSG-SMS, Social Marketing Service", "OSM, OFFICE FOR STRATEGY MANAGEMENT", "OUS-EC, Office of the Undersecretary for Exigent concerns", "OUS-LLA, Office of the Undersecretary Legislative Liason Affairs", "OUS-OPG-Protective, OUS-OPG-Protective", "OUS-PPDLLO, Office of the Secretary for Policy and Plans and Deparment Legislative Liaison Office", "OUS-SC, Office of the Under Secretary for Special Concern", "OUS-Special Projects, Office of the Undersecretary for Special Projects", "OUS-SWD, Office of the Undersecretary for Social Welfare and Development", "OUSDRM, Office of the Undersecretary for Disaster Response Management Group", "OUSEC-ADMIN for GASSG, GENERAL ADMINISTRATION AND SUPPORT SERVICES GROUP", "OUSEC-PPG, Office of U/Sec for PPG - DO NOT USE ", "OUSISP, Office of the Undersecretary for Inclusive and Sustainable Peace", "OUSO, Office of the Undersecretary for Operation", "OUSPPG, Office of the Undersecretary for Policy and plans Group", "OUSSCBG, Office of the Undersecretary for Standards and Capacity Building Group", "OUSSPIM, Office of the Undersecretary for Support Programs Infastructure Management", "PMB, Program Management Bureau", "PMD, Procurement Management Division", "PMD-BACSS, Bids and Awards Commitee Secretariat Section", "PMD-CMS, Contract Management Section", "PMD-PPMS, Procurement Planning and Management Section", "PROMOTIVE-OPG, Promotive Operation and Programs Group", "PROPERTY, WAREHOUSE, PROPERTY, WAREHOUSE", "PROTECTIVE-OPG, Protective Operation and Programs Group", "PSB-SWATO, Social Welfare Attche", "PSFMO-CIU, PSFMO-CIU", "RECLASSIFIED PROPERTY, RECLASSIFIED PROPERTY", "RGMO, Resource Generation and Management Office", "Security Guard, Security Guard", "SLP, Sustainable Livelihood Program", "Supplier, DSWD - Supplier", "SWADCAP, Social Welfare And Development Center Asia Pacific", "SWEMC, SWEMC", "SWIDB, (DO NOT USE) Social Welfare Institutional Development Bureau", "TCT,NPMO, Targeted Cash transfer NPMO", "", "", "", "", "", "", "", "", ""})
        pickOffice.Location = New Point(290, 221)
        pickOffice.Margin = New Padding(2, 1, 2, 1)
        pickOffice.Name = "pickOffice"
        pickOffice.Size = New Size(230, 29)
        pickOffice.TabIndex = 14
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtEmail.Location = New Point(290, 162)
        txtEmail.Margin = New Padding(2, 1, 2, 1)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(230, 29)
        txtEmail.TabIndex = 13
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtContact.Location = New Point(41, 162)
        txtContact.Margin = New Padding(2, 1, 2, 1)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(230, 29)
        txtContact.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(41, 27)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 16)
        Label1.TabIndex = 0
        Label1.Text = "FIRST NAME"
        ' 
        ' txtFname
        ' 
        txtFname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtFname.Location = New Point(41, 44)
        txtFname.Margin = New Padding(2, 1, 2, 1)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(230, 29)
        txtFname.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Yellow
        Label3.Location = New Point(41, 145)
        Label3.Margin = New Padding(2, 0, 2, 0)
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
        Label9.Location = New Point(290, 265)
        Label9.Margin = New Padding(2, 0, 2, 0)
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
        Label4.Location = New Point(290, 145)
        Label4.Margin = New Padding(2, 0, 2, 0)
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
        pBoxCreateProfile.Location = New Point(802, 44)
        pBoxCreateProfile.Margin = New Padding(2, 1, 2, 1)
        pBoxCreateProfile.Name = "pBoxCreateProfile"
        pBoxCreateProfile.Size = New Size(165, 147)
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
        Label5.Location = New Point(290, 204)
        Label5.Margin = New Padding(2, 0, 2, 0)
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
        Label6.Location = New Point(538, 204)
        Label6.Margin = New Padding(2, 0, 2, 0)
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
        Label2.Location = New Point(41, 265)
        Label2.Margin = New Padding(2, 0, 2, 0)
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
        Panel1.Controls.Add(txtBenifAge5)
        Panel1.Controls.Add(txtBenifRel5)
        Panel1.Controls.Add(txtBenifName5)
        Panel1.Controls.Add(txtBenifAge4)
        Panel1.Controls.Add(txtBenifAge3)
        Panel1.Controls.Add(txtBenifAge2)
        Panel1.Controls.Add(txtBenifAge1)
        Panel1.Controls.Add(txtBenifRel4)
        Panel1.Controls.Add(txtBenifRel3)
        Panel1.Controls.Add(txtBenifRel2)
        Panel1.Controls.Add(txtBenifRel1)
        Panel1.Controls.Add(txtBenifName4)
        Panel1.Controls.Add(txtBenifName3)
        Panel1.Controls.Add(txtBenifName2)
        Panel1.Controls.Add(txtBenifName1)
        Panel1.Controls.Add(btnRegister)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(pickBDate)
        Panel1.Controls.Add(txtEduc)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(txtAddress)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(txtMname)
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(ButtonUpload)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(txtCreatePw)
        Panel1.Controls.Add(txtCreateUsername)
        Panel1.Controls.Add(pickCommittee)
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
        Panel1.Location = New Point(7, 5)
        Panel1.Margin = New Padding(2, 1, 2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(994, 650)
        Panel1.TabIndex = 13
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.ForeColor = Color.Yellow
        Label19.Location = New Point(4, 383)
        Label19.Margin = New Padding(2, 0, 2, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(185, 23)
        Label19.TabIndex = 58
        Label19.Text = "BENEFICIARIES"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.ForeColor = Color.Yellow
        Label18.Location = New Point(4, 0)
        Label18.Margin = New Padding(2, 0, 2, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(231, 23)
        Label18.TabIndex = 57
        Label18.Text = "MEMBERSHIP FORM"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.ForeColor = Color.Yellow
        Label17.Location = New Point(630, 412)
        Label17.Margin = New Padding(2, 0, 2, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(38, 16)
        Label17.TabIndex = 56
        Label17.Text = "AGE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Yellow
        Label8.Location = New Point(433, 412)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(123, 16)
        Label8.TabIndex = 55
        Label8.Text = "RELATIONSHIP"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Yellow
        Label7.Location = New Point(178, 412)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 16)
        Label7.TabIndex = 54
        Label7.Text = "NAME"
        ' 
        ' txtBenifAge5
        ' 
        txtBenifAge5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifAge5.Location = New Point(597, 555)
        txtBenifAge5.Margin = New Padding(2, 1, 2, 1)
        txtBenifAge5.Name = "txtBenifAge5"
        txtBenifAge5.Size = New Size(111, 29)
        txtBenifAge5.TabIndex = 53
        ' 
        ' txtBenifRel5
        ' 
        txtBenifRel5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifRel5.Location = New Point(389, 555)
        txtBenifRel5.Margin = New Padding(2, 1, 2, 1)
        txtBenifRel5.Name = "txtBenifRel5"
        txtBenifRel5.Size = New Size(204, 29)
        txtBenifRel5.TabIndex = 52
        ' 
        ' txtBenifName5
        ' 
        txtBenifName5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifName5.Location = New Point(38, 555)
        txtBenifName5.Margin = New Padding(2, 1, 2, 1)
        txtBenifName5.Name = "txtBenifName5"
        txtBenifName5.Size = New Size(347, 29)
        txtBenifName5.TabIndex = 51
        ' 
        ' txtBenifAge4
        ' 
        txtBenifAge4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifAge4.Location = New Point(597, 524)
        txtBenifAge4.Margin = New Padding(2, 1, 2, 1)
        txtBenifAge4.Name = "txtBenifAge4"
        txtBenifAge4.Size = New Size(111, 29)
        txtBenifAge4.TabIndex = 50
        ' 
        ' txtBenifAge3
        ' 
        txtBenifAge3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifAge3.Location = New Point(597, 493)
        txtBenifAge3.Margin = New Padding(2, 1, 2, 1)
        txtBenifAge3.Name = "txtBenifAge3"
        txtBenifAge3.Size = New Size(111, 29)
        txtBenifAge3.TabIndex = 49
        ' 
        ' txtBenifAge2
        ' 
        txtBenifAge2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifAge2.Location = New Point(597, 462)
        txtBenifAge2.Margin = New Padding(2, 1, 2, 1)
        txtBenifAge2.Name = "txtBenifAge2"
        txtBenifAge2.Size = New Size(111, 29)
        txtBenifAge2.TabIndex = 48
        ' 
        ' txtBenifAge1
        ' 
        txtBenifAge1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifAge1.Location = New Point(597, 431)
        txtBenifAge1.Margin = New Padding(2, 1, 2, 1)
        txtBenifAge1.Name = "txtBenifAge1"
        txtBenifAge1.Size = New Size(111, 29)
        txtBenifAge1.TabIndex = 47
        ' 
        ' txtBenifRel4
        ' 
        txtBenifRel4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifRel4.Location = New Point(389, 524)
        txtBenifRel4.Margin = New Padding(2, 1, 2, 1)
        txtBenifRel4.Name = "txtBenifRel4"
        txtBenifRel4.Size = New Size(204, 29)
        txtBenifRel4.TabIndex = 46
        ' 
        ' txtBenifRel3
        ' 
        txtBenifRel3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifRel3.Location = New Point(389, 493)
        txtBenifRel3.Margin = New Padding(2, 1, 2, 1)
        txtBenifRel3.Name = "txtBenifRel3"
        txtBenifRel3.Size = New Size(204, 29)
        txtBenifRel3.TabIndex = 45
        ' 
        ' txtBenifRel2
        ' 
        txtBenifRel2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifRel2.Location = New Point(389, 462)
        txtBenifRel2.Margin = New Padding(2, 1, 2, 1)
        txtBenifRel2.Name = "txtBenifRel2"
        txtBenifRel2.Size = New Size(204, 29)
        txtBenifRel2.TabIndex = 44
        ' 
        ' txtBenifRel1
        ' 
        txtBenifRel1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifRel1.Location = New Point(389, 431)
        txtBenifRel1.Margin = New Padding(2, 1, 2, 1)
        txtBenifRel1.Name = "txtBenifRel1"
        txtBenifRel1.Size = New Size(204, 29)
        txtBenifRel1.TabIndex = 43
        ' 
        ' txtBenifName4
        ' 
        txtBenifName4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifName4.Location = New Point(38, 524)
        txtBenifName4.Margin = New Padding(2, 1, 2, 1)
        txtBenifName4.Name = "txtBenifName4"
        txtBenifName4.Size = New Size(347, 29)
        txtBenifName4.TabIndex = 42
        ' 
        ' txtBenifName3
        ' 
        txtBenifName3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifName3.Location = New Point(38, 493)
        txtBenifName3.Margin = New Padding(2, 1, 2, 1)
        txtBenifName3.Name = "txtBenifName3"
        txtBenifName3.Size = New Size(347, 29)
        txtBenifName3.TabIndex = 41
        ' 
        ' txtBenifName2
        ' 
        txtBenifName2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifName2.Location = New Point(38, 462)
        txtBenifName2.Margin = New Padding(2, 1, 2, 1)
        txtBenifName2.Name = "txtBenifName2"
        txtBenifName2.Size = New Size(347, 29)
        txtBenifName2.TabIndex = 40
        ' 
        ' txtBenifName1
        ' 
        txtBenifName1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtBenifName1.Location = New Point(38, 431)
        txtBenifName1.Margin = New Padding(2, 1, 2, 1)
        txtBenifName1.Name = "txtBenifName1"
        txtBenifName1.Size = New Size(347, 29)
        txtBenifName1.TabIndex = 39
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.ForeColor = Color.Yellow
        Label16.Location = New Point(41, 203)
        Label16.Margin = New Padding(2, 0, 2, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(96, 16)
        Label16.TabIndex = 37
        Label16.Text = "BIRTHDATE"
        ' 
        ' pickBDate
        ' 
        pickBDate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pickBDate.Location = New Point(41, 221)
        pickBDate.Margin = New Padding(2)
        pickBDate.Name = "pickBDate"
        pickBDate.Size = New Size(230, 29)
        pickBDate.TabIndex = 36
        ' 
        ' txtEduc
        ' 
        txtEduc.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtEduc.Location = New Point(538, 162)
        txtEduc.Margin = New Padding(2, 1, 2, 1)
        txtEduc.Name = "txtEduc"
        txtEduc.Size = New Size(230, 29)
        txtEduc.TabIndex = 35
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.ForeColor = Color.Yellow
        Label15.Location = New Point(538, 145)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(227, 16)
        Label15.TabIndex = 34
        Label15.Text = "EDUCATIONAL ATTAINMENT"
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtAddress.Location = New Point(41, 101)
        txtAddress.Margin = New Padding(2, 1, 2, 1)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(727, 29)
        txtAddress.TabIndex = 33
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.ForeColor = Color.Yellow
        Label14.Location = New Point(41, 84)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(124, 16)
        Label14.TabIndex = 32
        Label14.Text = "FULL ADDRESS"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.Yellow
        Label13.Location = New Point(290, 26)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(118, 16)
        Label13.TabIndex = 30
        Label13.Text = "MIDDLE NAME"
        ' 
        ' txtMname
        ' 
        txtMname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtMname.Location = New Point(290, 44)
        txtMname.Margin = New Padding(2, 1, 2, 1)
        txtMname.Name = "txtMname"
        txtMname.Size = New Size(230, 29)
        txtMname.TabIndex = 31
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.Yellow
        Label12.Location = New Point(538, 26)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(96, 16)
        Label12.TabIndex = 0
        Label12.Text = "LAST NAME"
        ' 
        ' txtLname
        ' 
        txtLname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtLname.Location = New Point(538, 44)
        txtLname.Margin = New Padding(3, 2, 3, 2)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(230, 29)
        txtLname.TabIndex = 11
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(51))
        ClientSize = New Size(1012, 665)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 1, 2, 1)
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
    Friend WithEvents pickCommittee As ComboBox
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
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtEduc As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents pickBDate As DateTimePicker
    Friend WithEvents txtBenifName1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBenifAge5 As TextBox
    Friend WithEvents txtBenifRel5 As TextBox
    Friend WithEvents txtBenifName5 As TextBox
    Friend WithEvents txtBenifAge4 As TextBox
    Friend WithEvents txtBenifAge3 As TextBox
    Friend WithEvents txtBenifAge2 As TextBox
    Friend WithEvents txtBenifAge1 As TextBox
    Friend WithEvents txtBenifRel4 As TextBox
    Friend WithEvents txtBenifRel3 As TextBox
    Friend WithEvents txtBenifRel2 As TextBox
    Friend WithEvents txtBenifRel1 As TextBox
    Friend WithEvents txtBenifName4 As TextBox
    Friend WithEvents txtBenifName3 As TextBox
    Friend WithEvents txtBenifName2 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
End Class
