<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalPay = New System.Windows.Forms.Label()
        Me.lblTaxCharges = New System.Windows.Forms.Label()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.txtPayRate = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalGross = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Hours Worked:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Pay Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tax Charges:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Paycheck After Taxes:"
        '
        'lblTotalPay
        '
        Me.lblTotalPay.AutoSize = True
        Me.lblTotalPay.Location = New System.Drawing.Point(250, 165)
        Me.lblTotalPay.Name = "lblTotalPay"
        Me.lblTotalPay.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalPay.TabIndex = 7
        Me.lblTotalPay.Text = "Label8"
        '
        'lblTaxCharges
        '
        Me.lblTaxCharges.AutoSize = True
        Me.lblTaxCharges.Location = New System.Drawing.Point(250, 140)
        Me.lblTaxCharges.Name = "lblTaxCharges"
        Me.lblTaxCharges.Size = New System.Drawing.Size(39, 13)
        Me.lblTaxCharges.TabIndex = 6
        Me.lblTaxCharges.Text = "Label7"
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(253, 32)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(47, 20)
        Me.txtHoursWorked.TabIndex = 8
        '
        'txtPayRate
        '
        Me.txtPayRate.Location = New System.Drawing.Point(253, 62)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(47, 20)
        Me.txtPayRate.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(53, 214)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(82, 39)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(163, 214)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 39)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(273, 214)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 39)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Total Gross:"
        '
        'lblTotalGross
        '
        Me.lblTotalGross.AutoSize = True
        Me.lblTotalGross.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblTotalGross.Location = New System.Drawing.Point(250, 104)
        Me.lblTotalGross.Name = "lblTotalGross"
        Me.lblTotalGross.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalGross.TabIndex = 14
        Me.lblTotalGross.Text = "Label6"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(408, 283)
        Me.Controls.Add(Me.lblTotalGross)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.lblTotalPay)
        Me.Controls.Add(Me.lblTaxCharges)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPay As System.Windows.Forms.Label
    Friend WithEvents lblTaxCharges As System.Windows.Forms.Label
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents txtPayRate As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalGross As System.Windows.Forms.Label

End Class
