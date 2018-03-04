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
        Me.txtEntry = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a positive number:"
        '
        'txtEntry
        '
        Me.txtEntry.Location = New System.Drawing.Point(216, 56)
        Me.txtEntry.Name = "txtEntry"
        Me.txtEntry.Size = New System.Drawing.Size(59, 20)
        Me.txtEntry.TabIndex = 1
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(68, 98)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(85, 38)
        Me.btnTest.TabIndex = 2
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(201, 98)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 38)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(150, 168)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(39, 13)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "Label2"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnTest
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(361, 199)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.txtEntry)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEntry As System.Windows.Forms.TextBox
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
