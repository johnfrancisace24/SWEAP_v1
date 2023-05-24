Public Class AdminDashboard

    Private Sub bttnDashboard_Click(sender As Object, e As EventArgs) Handles bttnDashboard.Click
        PnlDash.Height = bttnDashboard.Height
        PnlDash.Top = bttnDashboard.Top
        PnlDash.BackColor = Color.FromArgb(255, 77, 77)
        pnlEmp.BackColor = Color.FromArgb(56, 103, 214)
        pnlFund.BackColor = Color.FromArgb(56, 103, 214)
    End Sub
    Private Sub bttnEmploy_Click(sender As Object, e As EventArgs) Handles bttnEmploy.Click
        pnlEmp.Height = bttnEmploy.Height
        pnlEmp.Top = bttnEmploy.Top
        PnlDash.BackColor = Color.FromArgb(56, 103, 214)
        pnlEmp.BackColor = Color.FromArgb(255, 77, 77)
        pnlFund.BackColor = Color.FromArgb(56, 103, 214)
    End Sub
    Private Sub bttnFundtran_Click(sender As Object, e As EventArgs) Handles bttnFundtran.Click
        pnlFund.Height = bttnFundtran.Height
        pnlFund.Top = bttnFundtran.Top
        PnlDash.BackColor = Color.FromArgb(56, 103, 214)
        pnlEmp.BackColor = Color.FromArgb(56, 103, 214)
        pnlFund.BackColor = Color.FromArgb(255, 77, 77)
    End Sub
    Private Sub bttnLogout_MouseEnter(sender As Object, e As EventArgs) Handles bttnLogout.MouseEnter
        bttnLogout.BackColor = Color.FromArgb(255, 77, 77)
    End Sub
    Private Sub bttnLogout_MouseLeave(sender As Object, e As EventArgs) Handles bttnLogout.MouseLeave
        bttnLogout.BackColor = Color.FromArgb(56, 103, 214)
    End Sub
    Private Sub bttnLogout_Click(sender As Object, e As EventArgs) Handles bttnLogout.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class