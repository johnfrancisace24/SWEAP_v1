<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Panel1 = New Panel()
        bttnLogout = New Button()
        pnlFund = New Panel()
        pnlEmp = New Panel()
        PnlDash = New Panel()
        bttnFundtran = New Button()
        bttnEmploy = New Button()
        bttnDashboard = New Button()
        PictureBox1 = New PictureBox()
        Panel5 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(51))
        Panel1.Controls.Add(bttnLogout)
        Panel1.Controls.Add(pnlFund)
        Panel1.Controls.Add(pnlEmp)
        Panel1.Controls.Add(PnlDash)
        Panel1.Controls.Add(bttnFundtran)
        Panel1.Controls.Add(bttnEmploy)
        Panel1.Controls.Add(bttnDashboard)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(239, 640)
        Panel1.TabIndex = 0
        ' 
        ' bttnLogout
        ' 
        bttnLogout.FlatAppearance.BorderSize = 0
        bttnLogout.FlatStyle = FlatStyle.Flat
        bttnLogout.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        bttnLogout.Image = My.Resources.Resources._exit
        bttnLogout.ImageAlign = ContentAlignment.MiddleLeft
        bttnLogout.Location = New Point(0, 603)
        bttnLogout.Margin = New Padding(3, 2, 3, 2)
        bttnLogout.Name = "bttnLogout"
        bttnLogout.Padding = New Padding(44, 0, 0, 0)
        bttnLogout.Size = New Size(239, 35)
        bttnLogout.TabIndex = 9
        bttnLogout.Text = "LOGOUT"
        bttnLogout.UseVisualStyleBackColor = True
        ' 
        ' pnlFund
        ' 
        pnlFund.Location = New Point(228, 326)
        pnlFund.Margin = New Padding(3, 2, 3, 2)
        pnlFund.Name = "pnlFund"
        pnlFund.Size = New Size(9, 49)
        pnlFund.TabIndex = 8
        ' 
        ' pnlEmp
        ' 
        pnlEmp.Location = New Point(228, 272)
        pnlEmp.Margin = New Padding(3, 2, 3, 2)
        pnlEmp.Name = "pnlEmp"
        pnlEmp.Size = New Size(9, 49)
        pnlEmp.TabIndex = 7
        ' 
        ' PnlDash
        ' 
        PnlDash.Location = New Point(228, 219)
        PnlDash.Margin = New Padding(3, 2, 3, 2)
        PnlDash.Name = "PnlDash"
        PnlDash.Size = New Size(9, 49)
        PnlDash.TabIndex = 6
        ' 
        ' bttnFundtran
        ' 
        bttnFundtran.FlatAppearance.BorderSize = 0
        bttnFundtran.FlatStyle = FlatStyle.Flat
        bttnFundtran.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        bttnFundtran.Image = My.Resources.Resources.fund
        bttnFundtran.ImageAlign = ContentAlignment.MiddleLeft
        bttnFundtran.Location = New Point(0, 326)
        bttnFundtran.Margin = New Padding(3, 2, 3, 2)
        bttnFundtran.Name = "bttnFundtran"
        bttnFundtran.Padding = New Padding(4, 0, 9, 0)
        bttnFundtran.Size = New Size(237, 49)
        bttnFundtran.TabIndex = 5
        bttnFundtran.Text = "FUND TRANSFER"
        bttnFundtran.TextAlign = ContentAlignment.MiddleRight
        bttnFundtran.UseVisualStyleBackColor = True
        ' 
        ' bttnEmploy
        ' 
        bttnEmploy.FlatAppearance.BorderSize = 0
        bttnEmploy.FlatStyle = FlatStyle.Flat
        bttnEmploy.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        bttnEmploy.Image = My.Resources.Resources.group__2_
        bttnEmploy.ImageAlign = ContentAlignment.MiddleLeft
        bttnEmploy.Location = New Point(0, 272)
        bttnEmploy.Margin = New Padding(3, 2, 3, 2)
        bttnEmploy.Name = "bttnEmploy"
        bttnEmploy.Padding = New Padding(4, 0, 9, 0)
        bttnEmploy.Size = New Size(237, 49)
        bttnEmploy.TabIndex = 4
        bttnEmploy.Text = "EMPLOYEES"
        bttnEmploy.TextAlign = ContentAlignment.MiddleRight
        bttnEmploy.UseVisualStyleBackColor = True
        ' 
        ' bttnDashboard
        ' 
        bttnDashboard.FlatAppearance.BorderSize = 0
        bttnDashboard.FlatStyle = FlatStyle.Flat
        bttnDashboard.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        bttnDashboard.Image = My.Resources.Resources.dashboard__2_
        bttnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        bttnDashboard.Location = New Point(0, 219)
        bttnDashboard.Margin = New Padding(3, 2, 3, 2)
        bttnDashboard.Name = "bttnDashboard"
        bttnDashboard.Padding = New Padding(4, 0, 9, 0)
        bttnDashboard.Size = New Size(237, 49)
        bttnDashboard.TabIndex = 3
        bttnDashboard.Text = "DASHBOARD"
        bttnDashboard.TextAlign = ContentAlignment.MiddleRight
        bttnDashboard.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(21, 16)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(191, 148)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.DarkRed
        Panel5.Controls.Add(Label1)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(239, 0)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(950, 81)
        Panel5.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(73, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(805, 26)
        Label1.TabIndex = 0
        Label1.Text = "SOCIAL WELFARE EMPLOYEES ASSOCIATION OF THE PHILIPPINES"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(204), CByte(51))
        Panel2.Location = New Point(243, 87)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(943, 548)
        Panel2.TabIndex = 2
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkRed
        ClientSize = New Size(1189, 640)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel5)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "AdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminDashboard"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bttnFundtran As Button
    Friend WithEvents bttnEmploy As Button
    Friend WithEvents bttnDashboard As Button
    Friend WithEvents pnlFund As Panel
    Friend WithEvents pnlEmp As Panel
    Friend WithEvents PnlDash As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents bttnLogout As Button
    Friend WithEvents Panel2 As Panel
End Class
