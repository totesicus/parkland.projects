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
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblThird = New System.Windows.Forms.Label()
        Me.lblFourth = New System.Windows.Forms.Label()
        Me.lblFifth = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFirst
        '
        Me.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirst.Location = New System.Drawing.Point(26, 45)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(49, 27)
        Me.lblFirst.TabIndex = 0
        Me.lblFirst.Text = """"""
        Me.lblFirst.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSecond
        '
        Me.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecond.Location = New System.Drawing.Point(84, 45)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(49, 27)
        Me.lblSecond.TabIndex = 1
        Me.lblSecond.Text = """"""
        Me.lblSecond.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblThird
        '
        Me.lblThird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThird.Location = New System.Drawing.Point(142, 45)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(49, 27)
        Me.lblThird.TabIndex = 2
        Me.lblThird.Text = """"""
        Me.lblThird.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFourth
        '
        Me.lblFourth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFourth.Location = New System.Drawing.Point(200, 45)
        Me.lblFourth.Name = "lblFourth"
        Me.lblFourth.Size = New System.Drawing.Size(49, 27)
        Me.lblFourth.TabIndex = 3
        Me.lblFourth.Text = """"""
        Me.lblFourth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFifth
        '
        Me.lblFifth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFifth.Location = New System.Drawing.Point(258, 45)
        Me.lblFifth.Name = "lblFifth"
        Me.lblFifth.Size = New System.Drawing.Size(49, 27)
        Me.lblFifth.TabIndex = 4
        Me.lblFifth.Text = """"""
        Me.lblFifth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(71, 111)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(83, 35)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate Numbers"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(179, 111)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 35)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 176)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblFifth)
        Me.Controls.Add(Me.lblFourth)
        Me.Controls.Add(Me.lblThird)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents lblThird As System.Windows.Forms.Label
    Friend WithEvents lblFourth As System.Windows.Forms.Label
    Friend WithEvents lblFifth As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
