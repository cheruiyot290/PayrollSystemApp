Public Class Form1
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles txtDeduction.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtGrossSalary.TextChanged
        txtGrosSalary.Text = Val(txtGrossSalary.Text)
        txtTax.Text = Val(txtGrossSalary.Text) * 0.15
        txtPhilHealth.Text = Val(txtGrossSalary.Text) * 0.05
        txtSss.Text = Val(txtGrossSalary.Text) * 0.02
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtPhilHealth.TextChanged
        txtTotaRedu.Text = Val(txtTax.Text) + Val(txtPhilHealth.Text) + Val(txtSss.Text)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtRateperHour_TextChanged(sender As Object, e As EventArgs) Handles txtRateperHour.TextChanged
        txtGrossSalary.Text = Val(txtRateperHour.Text) * Val(txtHourPerDay.Text) * Val(txtNumberOfdays.Text)
    End Sub

    Private Sub txtHourPerDay_TextChanged(sender As Object, e As EventArgs) Handles txtHourPerDay.TextChanged
        txtGrossSalary.Text = Val(txtRateperHour.Text) * Val(txtHourPerDay.Text) * Val(txtNumberOfdays.Text)
    End Sub

    Private Sub txtNumberOfdays_TextChanged(sender As Object, e As EventArgs) Handles txtNumberOfdays.TextChanged
        txtGrossSalary.Text = Val(txtRateperHour.Text) * Val(txtHourPerDay.Text) * Val(txtNumberOfdays.Text)
    End Sub

    Private Sub txtTotaRedu_TextChanged(sender As Object, e As EventArgs) Handles txtTotaRedu.TextChanged
        txtDeduction.Text = Val(txtTotaRedu.Text)
    End Sub

    Private Sub txtTax_TextChanged(sender As Object, e As EventArgs) Handles txtTax.TextChanged
        txtTotaRedu.Text = Val(txtTax.Text) + Val(txtPhilHealth.Text) + Val(txtSss.Text)
    End Sub

    Private Sub txtSss_TextChanged(sender As Object, e As EventArgs) Handles txtSss.TextChanged
        txtTotaRedu.Text = Val(txtTax.Text) + Val(txtPhilHealth.Text) + Val(txtSss.Text)
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        txtNetSalary.Text = Val(txtGrosSalary.Text) - Val(txtDeduction.Text)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim R As VariantType
        R = MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If R = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
        txtRateperHour.Focus()
    End Sub

    Private Sub Ctrl_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTotaRedu.KeyUp, txtTax.KeyUp, txtSss.KeyUp, txtRateperHour.KeyUp, txtPhilHealth.KeyUp, txtNumberOfdays.KeyUp, txtNetSalary.KeyUp, txtHourPerDay.KeyUp, txtGrossSalary.KeyUp, txtGrosSalary.KeyUp, txtDeduction.KeyUp, btnExit.KeyUp, btnCompute.KeyUp, btnClear.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub
End Class
