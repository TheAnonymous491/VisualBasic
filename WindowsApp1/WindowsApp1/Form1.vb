Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim num1 As Integer = 5
        Dim num2 As Integer = 10
        Dim resultado As Integer = num1 + num2

        MsgBox("El resultado de la suma es: " + resultado.ToString())


    End Sub
End Class
