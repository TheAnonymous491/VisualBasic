Module Module1

    Sub Main()
        Dim resultado As Double = promedio(8, 4.5, 2)
        Console.WriteLine(resultado)

    End Sub

    Function promedio(ByVal num1 As Integer, ByVal num2 As Integer) As Double
        Return (num1 + num2) / 2
    End Function

    Function promedio(num1 As Integer, num2 As Integer, num3 As Integer) As Double
        Return (num1 + num2 + num3) / 3
    End Function

    Function promedio(num1 As Double, num2 As Integer, num3 As Integer) As Double
        Return (num1 + num2 + num3) / 3
    End Function

    Function promedio(num1 As Integer, num2 As Double, num3 As Integer) As Double
        Return (num1 + num2 + num3) / 3
    End Function

End Module
