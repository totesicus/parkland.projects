Public Class Form1

    Const decLABOR_PER_HOUR As Decimal = 20D           ' To charge per hour of labor.
    Const decSALES_TAX As Decimal = 0.06D              ' Sales tax charge for parts only.
    Const decOIL_CHANGE As Decimal = 26D               ' Cost of an oil change.
    Const decLUBE_JOB As Decimal = 18D                 ' Cost of a lube job.
    Const decRADIATOR_FLUSH As Decimal = 30D           ' Cost of a radiator flush.
    Const decTRANSMISSION_FLUSH As Decimal = 80D       ' Cost of a transmission flush.
    Const decINSPECTION As Decimal = 15D               ' Cost of an inspection.
    Const decREPLACE_MUFFLER As Decimal = 100D         ' Cost of a muffle replacement.
    Const decTIRE_ROTATION As Decimal = 20D            ' Cost of a tire replacement.

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Joe's Automotive Services Calculator"    ' Change the name of the form.
        lblServicesAndLabor.Text = ""                       ' Set the Services and Labor label to empty upon form load.
        lblParts.Text = ""                                  ' Set the Parts label to empty upon form load.
        lblTaxOnParts.Text = ""                             ' Set the Tax (on parts) label to empty upon form load.
        lblTotalFees.Text = ""                              ' Set the Total Fees label to empty upon form load.
    End Sub

    Private Sub btnCalculateCharges_Click(sender As Object, e As EventArgs) Handles btnCalculateCharges.Click

        Dim decServicesAndLabor As Decimal      ' Holds the services and labor total.
        Dim decParts As Decimal                 ' Holds the parts total.
        Dim decTaxOnParts As Decimal            ' Holds the tax on parts total.
        Dim decTotalFees As Decimal             ' Holds the total charges for the order.

        ValidateParts()                         ' Validate that the Parts textbox has a numeric value greater than zero.
        ValidateLabor()                         ' Validate that the Labor textbox has a numeric value greater than zero.

        decServicesAndLabor = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() ' Give the variable the value of the functions called.
        decParts = PartsCharges()                                                                ' Give the variable the value of the functions called.
        decTaxOnParts = TaxCharges(decParts)                                                     ' Give the variable the value of the functions called.
        decTotalFees = decServicesAndLabor + decTaxOnParts + decParts                            ' Give the variable the value of the functions called.

        lblServicesAndLabor.Text = decServicesAndLabor.ToString("c")            ' Convert the output value of the variable to string currency format.
        lblParts.Text = decParts.ToString("c")                                  ' Convert the output value of the variable to string currency format.
        lblTaxOnParts.Text = decTaxOnParts.ToString("c")                        ' Convert the output value of the variable to string currency format.
        lblTotalFees.Text = decTotalFees.ToString("c")                          ' Convert the output value of the variable to string currency format.
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click

        ResetOilLubeCharges()           ' Reset the oil and lube charges checkboxes.
        ResetFlushCharges()             ' Reset the flush charges checkboxes.
        ResetMiscCharges()

        txtLabor.Clear()                ' Reset the Labor textbox.
        txtParts.Clear()                ' Reset the Parts textbox.

        lblServicesAndLabor.Text = ""   ' Clear the Services and Labor label.
        lblParts.Text = ""              ' Clear the Parts label.
        lblTaxOnParts.Text = ""         ' Clear the Tax (on parts) label.
        lblTotalFees.Text = ""          ' Clear the Total Fees label.

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()      ' Close the form.
    End Sub

    Function ValidateParts() As Boolean     ' Function to validate that the Parts textbox has input.
        Dim decTempParts As Decimal
        If Not Decimal.TryParse(txtParts.Text, decTempParts) OrElse decTempParts < 0D Then                             ' Parse the Parts textbox for a decimal input.
            txtParts.Text = InputBox("Please enter a positive numeric value for Parts.", "Error!")
            Return False
        End If

        Return True
    End Function

    Function ValidateLabor() As Boolean
        Dim decTempLabor As Decimal
        If Not Decimal.TryParse(txtLabor.Text, decTempLabor) OrElse decTempLabor < 0D Then
            txtLabor.Text = InputBox("Please enter a positive numeric value for Labor.", "Error")
            Return False
        End If

        Return True
    End Function

    Function OilLubeCharges() As Decimal
        Dim decOilLubeCharges As Decimal = 0D

        If chkOilChange.Checked = True Then
            decOilLubeCharges += decOIL_CHANGE
        End If

        If chkLubeJob.Checked = True Then
            decOilLubeCharges += decLUBE_JOB
        End If

        Return decOilLubeCharges
    End Function

    Function FlushCharges() As Decimal
        Dim decFlushCharges As Decimal = 0D

        If chkRadiatorFlush.Checked = True Then
            decFlushCharges += decRADIATOR_FLUSH
        End If

        If chkTransmissionFlush.Checked = True Then
            decFlushCharges += decTRANSMISSION_FLUSH
        End If

        Return decFlushCharges
    End Function

    Function MiscCharges() As Decimal
        Dim decMiscCharges As Decimal = 0D

        If chkInspection.Checked = True Then
            decMiscCharges += decINSPECTION
        End If

        If chkReplaceMuffler.Checked = True Then
            decMiscCharges += decREPLACE_MUFFLER
        End If

        If chkTireRotation.Checked = True Then
            decMiscCharges += decTIRE_ROTATION
        End If

        Return decMiscCharges
    End Function

    Function PartsCharges() As Decimal
        Dim decPartsCharge As Decimal
        If txtParts.Text = String.Empty Then
            Return 0
        Else
            decPartsCharge = CDec(txtParts.Text)
            Return decPartsCharge
        End If

    End Function

    Function OtherCharges() As Decimal
        Dim decLaborCharge As Decimal
        If txtLabor.Text = String.Empty Then
            Return 0
        Else
            decLaborCharge = CDec(txtLabor.Text)
            Return decLaborCharge * decLABOR_PER_HOUR
        End If
    End Function

    Function TaxCharges(ByVal decAmount As Decimal) As Decimal
        Dim decPartsCost As Decimal
        If txtParts.Text = String.Empty Then
            Return 0
        Else
            decPartsCost = CDec(txtParts.Text)
            Return decPartsCost * decSALES_TAX
        End If
    End Function

    Private Sub ResetOilLubeCharges()
        chkOilChange.Checked = False
        chkLubeJob.Checked = False
    End Sub

    Sub ResetFlushCharges()
        chkRadiatorFlush.Checked = False
        chkTransmissionFlush.Checked = False
    End Sub

    Sub ResetMiscCharges()
        chkInspection.Checked = False
        chkTireRotation.Checked = False
        chkReplaceMuffler.Checked = False
    End Sub

End Class
