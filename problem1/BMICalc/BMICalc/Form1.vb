Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click

        Dim wSt As String
        Dim hSt As String

        hSt = txtHeight.Text
        wSt = txtWeight.Text

        Dim h As Double
        Dim w As Double

        h = CDbl(hSt)
        w = CDbl(wSt)

        Dim bmi As Double
        bmi = (w * 703) / (h ^ 2)

        TextBox1.Text = CStr(bmi)


    End Sub
End Class
