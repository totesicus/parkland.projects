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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkLubeJob = New System.Windows.Forms.CheckBox()
        Me.chkOilChange = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkTransmissionFlush = New System.Windows.Forms.CheckBox()
        Me.chkRadiatorFlush = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkInspection = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkReplaceMuffler = New System.Windows.Forms.CheckBox()
        Me.chkTireRotation = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTotalFees = New System.Windows.Forms.Label()
        Me.lblTaxOnParts = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.lblServicesAndLabor = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCalculateCharges = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkLubeJob)
        Me.GroupBox1.Controls.Add(Me.chkOilChange)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 69)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oil and Lube"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "($18.00)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "($26.00)"
        '
        'chkLubeJob
        '
        Me.chkLubeJob.AutoSize = True
        Me.chkLubeJob.Location = New System.Drawing.Point(25, 43)
        Me.chkLubeJob.Name = "chkLubeJob"
        Me.chkLubeJob.Size = New System.Drawing.Size(70, 17)
        Me.chkLubeJob.TabIndex = 1
        Me.chkLubeJob.Text = "Lube Job"
        Me.chkLubeJob.UseVisualStyleBackColor = True
        '
        'chkOilChange
        '
        Me.chkOilChange.AutoSize = True
        Me.chkOilChange.Location = New System.Drawing.Point(25, 19)
        Me.chkOilChange.Name = "chkOilChange"
        Me.chkOilChange.Size = New System.Drawing.Size(78, 17)
        Me.chkOilChange.TabIndex = 0
        Me.chkOilChange.Text = "Oil Change"
        Me.chkOilChange.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.chkTransmissionFlush)
        Me.GroupBox2.Controls.Add(Me.chkRadiatorFlush)
        Me.GroupBox2.Location = New System.Drawing.Point(275, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 79)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flushes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "($80.00)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "($30.00)"
        '
        'chkTransmissionFlush
        '
        Me.chkTransmissionFlush.AutoSize = True
        Me.chkTransmissionFlush.Location = New System.Drawing.Point(14, 43)
        Me.chkTransmissionFlush.Name = "chkTransmissionFlush"
        Me.chkTransmissionFlush.Size = New System.Drawing.Size(115, 17)
        Me.chkTransmissionFlush.TabIndex = 2
        Me.chkTransmissionFlush.Text = "Transmission Flush"
        Me.chkTransmissionFlush.UseVisualStyleBackColor = True
        '
        'chkRadiatorFlush
        '
        Me.chkRadiatorFlush.AutoSize = True
        Me.chkRadiatorFlush.Location = New System.Drawing.Point(14, 20)
        Me.chkRadiatorFlush.Name = "chkRadiatorFlush"
        Me.chkRadiatorFlush.Size = New System.Drawing.Size(94, 17)
        Me.chkRadiatorFlush.TabIndex = 0
        Me.chkRadiatorFlush.Text = "Radiator Flush"
        Me.chkRadiatorFlush.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtLabor)
        Me.GroupBox3.Controls.Add(Me.txtParts)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(289, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(218, 102)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parts and Labor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Labor:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Parts:"
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(60, 59)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(55, 20)
        Me.txtLabor.TabIndex = 10
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(60, 33)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(55, 20)
        Me.txtParts.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(124, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "($20.00 per hour)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.chkInspection)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.chkReplaceMuffler)
        Me.GroupBox4.Controls.Add(Me.chkTireRotation)
        Me.GroupBox4.Location = New System.Drawing.Point(31, 127)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(228, 102)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Misc"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(155, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "($20.00)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(155, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "($15.00)"
        '
        'chkInspection
        '
        Me.chkInspection.AutoSize = True
        Me.chkInspection.Location = New System.Drawing.Point(22, 19)
        Me.chkInspection.Name = "chkInspection"
        Me.chkInspection.Size = New System.Drawing.Size(75, 17)
        Me.chkInspection.TabIndex = 4
        Me.chkInspection.Text = "Inspection"
        Me.chkInspection.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(155, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "($100.00)"
        '
        'chkReplaceMuffler
        '
        Me.chkReplaceMuffler.AutoSize = True
        Me.chkReplaceMuffler.Location = New System.Drawing.Point(22, 49)
        Me.chkReplaceMuffler.Name = "chkReplaceMuffler"
        Me.chkReplaceMuffler.Size = New System.Drawing.Size(101, 17)
        Me.chkReplaceMuffler.TabIndex = 6
        Me.chkReplaceMuffler.Text = "Replace Muffler"
        Me.chkReplaceMuffler.UseVisualStyleBackColor = True
        '
        'chkTireRotation
        '
        Me.chkTireRotation.AutoSize = True
        Me.chkTireRotation.Location = New System.Drawing.Point(22, 79)
        Me.chkTireRotation.Name = "chkTireRotation"
        Me.chkTireRotation.Size = New System.Drawing.Size(87, 17)
        Me.chkTireRotation.TabIndex = 8
        Me.chkTireRotation.Text = "Tire Rotation"
        Me.chkTireRotation.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTotalFees)
        Me.GroupBox5.Controls.Add(Me.lblTaxOnParts)
        Me.GroupBox5.Controls.Add(Me.lblParts)
        Me.GroupBox5.Controls.Add(Me.lblServicesAndLabor)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Location = New System.Drawing.Point(31, 235)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(476, 135)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Summary"
        '
        'lblTotalFees
        '
        Me.lblTotalFees.AutoSize = True
        Me.lblTotalFees.Location = New System.Drawing.Point(259, 105)
        Me.lblTotalFees.Name = "lblTotalFees"
        Me.lblTotalFees.Size = New System.Drawing.Size(45, 13)
        Me.lblTotalFees.TabIndex = 16
        Me.lblTotalFees.Text = "Label18"
        '
        'lblTaxOnParts
        '
        Me.lblTaxOnParts.AutoSize = True
        Me.lblTaxOnParts.Location = New System.Drawing.Point(259, 79)
        Me.lblTaxOnParts.Name = "lblTaxOnParts"
        Me.lblTaxOnParts.Size = New System.Drawing.Size(45, 13)
        Me.lblTaxOnParts.TabIndex = 15
        Me.lblTaxOnParts.Text = "Label17"
        '
        'lblParts
        '
        Me.lblParts.AutoSize = True
        Me.lblParts.Location = New System.Drawing.Point(259, 53)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(45, 13)
        Me.lblParts.TabIndex = 14
        Me.lblParts.Text = "Label16"
        '
        'lblServicesAndLabor
        '
        Me.lblServicesAndLabor.AutoSize = True
        Me.lblServicesAndLabor.Location = New System.Drawing.Point(259, 27)
        Me.lblServicesAndLabor.Name = "lblServicesAndLabor"
        Me.lblServicesAndLabor.Size = New System.Drawing.Size(45, 13)
        Me.lblServicesAndLabor.TabIndex = 13
        Me.lblServicesAndLabor.Text = "Label15"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(108, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Total Fees"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(108, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Services and Labor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(108, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Parts"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(108, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Tax (on parts)"
        '
        'btnCalculateCharges
        '
        Me.btnCalculateCharges.Location = New System.Drawing.Point(104, 386)
        Me.btnCalculateCharges.Name = "btnCalculateCharges"
        Me.btnCalculateCharges.Size = New System.Drawing.Size(87, 45)
        Me.btnCalculateCharges.TabIndex = 3
        Me.btnCalculateCharges.Text = "Calculate Charges"
        Me.btnCalculateCharges.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(226, 386)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(87, 45)
        Me.btnClearForm.TabIndex = 4
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(348, 386)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 45)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(466, 424)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Tyler Turner"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculateCharges
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(542, 446)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnCalculateCharges)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkLubeJob As System.Windows.Forms.CheckBox
    Friend WithEvents chkOilChange As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkTransmissionFlush As System.Windows.Forms.CheckBox
    Friend WithEvents chkRadiatorFlush As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtLabor As System.Windows.Forms.TextBox
    Friend WithEvents txtParts As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkInspection As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkReplaceMuffler As System.Windows.Forms.CheckBox
    Friend WithEvents chkTireRotation As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnCalculateCharges As System.Windows.Forms.Button
    Friend WithEvents btnClearForm As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTotalFees As System.Windows.Forms.Label
    Friend WithEvents lblTaxOnParts As System.Windows.Forms.Label
    Friend WithEvents lblParts As System.Windows.Forms.Label
    Friend WithEvents lblServicesAndLabor As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class
