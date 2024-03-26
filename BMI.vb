Imports System.Runtime.CompilerServices

Public Class Form1
    Dim st1 As String
    Dim st2 As String
    Public Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        st1 = TextBox1.Text
    End Sub
    Public Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        st2 = TextBox2.Text
    End Sub
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double
        a = CDbl(st1)
        b = CDbl(st2)
        Dim ans As Double
        ans = b / Math.Pow(a, 2)
        MsgBox("BMI數值為:" & ans)
    End Sub
End Class
