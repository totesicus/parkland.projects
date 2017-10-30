Public Class Form1

    Const decTAX_RATE As Decimal = 0.255D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Pay Rate Calculator"

        lblTaxCharges.Text = ""
        lblTotalPay.Text = ""
        lblTotalGross.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decTotalGross As Decimal
        Dim decTaxCharges As Decimal
        Dim decTotalPaycheck As Decimal

        ValidateInputFields()

        decTotalGross = TotalGross()
        decTaxCharges = TaxCharges(decTotalGross)
        decTotalPaycheck = decTotalGross - decTaxCharges

        lblTotalGross.Text = decTotalGross.ToString("c")
        lblTaxCharges.Text = decTaxCharges.ToString("c")
        lblTotalPay.Text = decTotalPaycheck.ToString("c")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Function ValidateInputFields() As Boolean
        Dim decHoursWorked As Decimal
        Dim decPayRate As Decimal

        If Not Decimal.TryParse(txtHoursWorked.Text, decHoursWorked) OrElse decHoursWorked < 0 Then
            txtHoursWorked.Text = InputBox("Please enter a positive numeric value for hours worked.", "Error!")
            Return False
        End If

        If Not Decimal.TryParse(txtPayRate.Text, decPayRate) OrElse decPayRate < 0 Then
            txtPayRate.Text = InputBox("Please enter a positive numeric value for pay rate.", "Error!")
            Return False
        End If

        Return True
    End Function

    Function HoursWorked() As Decimal
        Dim decHoursWorked As Decimal = 0D

        If txtHoursWorked.Text = String.Empty Then
            Return 0
        Else
            decHoursWorked = CDec(txtHoursWorked.Text)
            Return decHoursWorked
        End If
    End Function

    Function PayRate() As Decimal
        Dim decPayRate As Decimal = 0D

        If txtPayRate.Text = String.Empty Then
            Return 0
        Else
            decPayRate = CDec(txtPayRate.Text)
            Return decPayRate
        End If
    End Function

    Function TotalGross() As Decimal
        Dim decTotalGross As Decimal = 0D

        If txtHoursWorked.Text = String.Empty Then
            Return 0
        ElseIf txtPayRate.Text = String.Empty Then
            Return 0
        Else
            decTotalGross = CDec(txtHoursWorked.Text) * CDec(txtPayRate.Text)
            Return decTotalGross
        End If
    End Function

    Function TaxCharges(ByVal decAmount As Decimal) As Decimal
        Dim decTaxCharges As Decimal = 0D

        If txtHoursWorked.Text = String.Empty Then
            Return 0
        ElseIf txtPayRate.Text = String.Empty Then
            Return 0
        Else
            decTaxCharges = CDec(txtHoursWorked.Text) * CDec(txtPayRate.Text)
            Return decTaxCharges * decTAX_RATE
        End If

    End Function

    Sub ClearForm()

        txtHoursWorked.Text = ""
        txtPayRate.Text = ""
        lblTotalGross.Text = ""
        lblTaxCharges.Text = ""
        lblTotalPay.Text = ""
    End Sub

End Class
