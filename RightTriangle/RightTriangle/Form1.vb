Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim result As Double
        Dim aSt As String = txtSideOne.Text
        Dim bSt As String = txtSideTwo.Text

        result = Hypotenuse(3, 4)
        txtHyp.Text = "Not Implemented Yet"

    End Sub

    Function Hypotenuse(ByVal a As Double, ByVal b As Double) _
        As Double

        Dim c As Double = Math.Sqrt(a ^ 2 + b ^ 2)

        Return c

    End Function

End Class
