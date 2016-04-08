Public Class frmFutureValue
    Dim futureValue As Decimal
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim monthlyInvestment As Decimal = CDec(txtMonthlyInvestment.Text)
        Dim interestRate As Decimal = CDec(txtInterestRate.Text) / 12 / 100
        Dim months As Integer = CInt(CDec(txtYears.Text) * 12)

        'For i As Integer = 1 To months
        '    futureValue = (futureValue + monthlyInvestment) * (1 + interestRate)
        'Next i

        Dim i As Integer = 1
        Do While i <= months
            futureValue = (futureValue + monthlyInvestment) * (1 + interestRate)
            i += 1
            If futureValue >= 1000 Then
                Exit Do
            End If
        Loop

        txtFutureValue.Text = FormatCurrency(futureValue)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
