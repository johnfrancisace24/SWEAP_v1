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
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(56), CByte(103), CByte(214))
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(271, 790)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(56), CByte(103), CByte(214))
        PictureBox1.BackgroundImage = My.Resources.Resources.love
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(24, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(218, 198)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(0, 292)
        Button1.Name = "Button1"
        Button1.Size = New Size(271, 65)
        Button1.TabIndex = 3
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(0, 363)
        Button2.Name = "Button2"
        Button2.Size = New Size(271, 65)
        Button2.TabIndex = 4
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(0, 434)
        Button3.Name = "Button3"
        Button3.Size = New Size(271, 65)
        Button3.TabIndex = 5
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(77), CByte(77))
        ClientSize = New Size(1396, 790)
        ControlBox = False
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminDashboard"
        Text = "AdminDashboard"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
