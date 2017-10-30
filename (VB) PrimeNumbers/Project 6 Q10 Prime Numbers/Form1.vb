Public Class Form1
    ' Prime number finder program.
    ' Made by Tyler Turner for CIS-122
    ' 11/4/15
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Prime Number Finder"
        lblResult.Text = ""
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        IsPrime()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Function IsPrime() As Boolean
        Dim intInput, intNumber As Integer
        Dim boolTrueOrFalse As Boolean
        Do While txtEntry.Text = String.Empty
            If Not Integer.TryParse(txtEntry.Text, intInput) Then
                txtEntry.Text = InputBox("Enter a positive integer.", "Error!")
            End If
        Loop
        intInput = CInt(txtEntry.Text)
        boolTrueOrFalse = True
        For intNumber = 2 To (intInput - 1)
            If intInput Mod intNumber = 0 Then
                boolTrueOrFalse = False
                Exit For
            End If
        Next intNumber
        If boolTrueOrFalse Then
            lblResult.Text = intInput & " is a prime number."
            Return True
        Else
            lblResult.Text = intInput & " is not a prime number."
            Return False
        End If
    End Function
End Class
