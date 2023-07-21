Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Declaracion de variables
        Dim valor1 As Double = 3
        Dim valor2 As Double = 10
        Dim resultado As Double

        'operamos con las variables
        'resultado = valor1 + valor2 'suma
        'resultado = valor1 - valor2 'resta
        'resultado = valor1 / valor2 'div
        'resultado = valor1 * valor2 'mult
        'resultado = valor1 ^ valor2 'exp
        'resultado = valor1 \ valor2 'div entera
        resultado = valor2 Mod valor1 'modulo
        resultado += 1

        'mostramos resultados
        MsgBox(resultado)


    End Sub
End Class
