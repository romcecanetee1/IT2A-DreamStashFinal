Public Class Registration_Successful
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        'Registration Successful!(Done) Show Login
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint
        lblRegisterSFullName.Text = Register.txtFirstName.Text + " " + Register.txtLastName.Text
    End Sub
End Class