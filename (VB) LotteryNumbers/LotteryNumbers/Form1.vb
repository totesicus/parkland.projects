Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Lottery Numbers"
        lblFirst.Text = ""
        lblSecond.Text = ""
        lblThird.Text = ""
        lblFourth.Text = ""
        lblFifth.Text = ""
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ' Create an array to hold five lottery numbers.
        Const intMAX_SUBSCRIPT As Integer = 4       ' The maximum subscript.
        Dim intNumbers(intMAX_SUBSCRIPT) As Integer ' Array declaration.
        Dim intCount As Integer                     ' Loop counter.

        ' Create a new random object.
        Dim rand As New Random

        ' Fill the array with random numbers.
        ' Each number will be in the range of 0-99.
        For intCount = 0 To intMAX_SUBSCRIPT
            intNumbers(intCount) = rand.Next(100)
        Next

        ' Display the array elements in the labels.
        lblFirst.Text = intNumbers(0).ToString()
        lblSecond.Text = intNumbers(1).ToString()
        lblThird.Text = intNumbers(2).ToString()
        lblFourth.Text = intNumbers(3).ToString()
        lblFifth.Text = intNumbers(4).ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
