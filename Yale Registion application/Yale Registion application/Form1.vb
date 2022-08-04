Public Class Form1

    Const fulltimefee As Decimal = 5000D
    Const parttimefee As Decimal = 4000D

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decPaid As Decimal
        Dim decamount As Decimal
        Dim partfee As Decimal

        Dim part As Parttime
        Dim sfull As Fulltime

        sfull = New Fulltime(txtStuID.Text,
                             txtName.Text,
                             txtReg.Text,
                             decPaid)
        sfull.intStudentsID = txtStuID.Text
        sfull.strNames = txtName.Text
        sfull.dtRegistration = txtReg.Text
        sfull.Annualfees = CDec(txtAmount.Text)
        decamount = Convert.ToDecimal(txtAmount.Text)
        partfee = Convert.ToDecimal(txtAmount.Text)


        Dim decBalance As Decimal
        Dim decBalance1 As Decimal

        If radFullTime.Checked Then
            decPaid = sfull.AmountPaidForTuition()
            lblCourse.Text = decPaid
            decBalance = fulltimefee - decPaid
            lblBalance.Text = decBalance

            If decBalance > 0 Then
                MessageBox.Show("You still owe us " & decBalance)
            Else
                MessageBox.Show("You have paid in full " & decBalance)
            End If

        ElseIf radPartTime.Checked Then
            part = New Parttime(txtStuID.Text,
                                txtName.Text,
                                txtReg.Text,
                                partfee)
            part.intStudentsID = txtStuID.Text
            part.strNames = txtName.Text
            part.dtRegistration = txtReg.Text
            partfee = part.AmountPaidForTuition()
            lblCourse.Text = partfee
            decBalance1 = parttimefee - partfee
            lblBalance.Text = decBalance1

            If decBalance1 > 0 Then
                MessageBox.Show("You sill owe us " & decBalance1)
            Else
                MessageBox.Show("You have paid in full " & decBalance1)
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStuID.Text = " "
        txtName.Text = " "
        txtReg.Text = " "
        txtAmount.Text = " "
        lblBalance.Text = " "
        lblCourse.Text = " "
    End Sub
End Class
