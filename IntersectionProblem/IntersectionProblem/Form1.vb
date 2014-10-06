﻿Option Strict On

Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Ast, Bst, Cst, Dst As String
        Dim A, B, C, D As Double

        ' Read the input from the user
        Ast = txtA.Text
        Bst = txtB.Text
        Cst = txtC.Text
        Dst = txtD.Text

        ' All input must be numbers
        If Not (IsNumeric(Ast) And IsNumeric(Bst) And IsNumeric(Cst) _
                And IsNumeric(Dst)) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
            Return
        End If

        ' Convert to double
        A = CDbl(Ast)
        B = CDbl(Bst)
        C = CDbl(Cst)
        D = CDbl(Dst)

        If (A < A Or D < C) Then
            MessageBox.Show("Please enter valid sumter", "Error!")
            Return
        End If

        txtResult.Text = FindIntersection(A, B, C, D)
        ' Please write your code here...
    End Sub
        Function FindIntersection(A As Double, B As Double, C As Double, D As Double) As String 
        Dim result As String
        If (B < C) Or (D < A) Then
            result = "No intersection"
        Else
            Dim begPoint As Double
            begPoint = Math.Max(A, C)

            Dim endPoint As Double
            endPoint = Math.Min(B, D)
            result = "The intersectoin is from " & begPoint & " to " & endPoint
        End If

        Return result
    End Function








End Class
