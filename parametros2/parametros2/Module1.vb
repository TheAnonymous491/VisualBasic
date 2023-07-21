Module Module1

    Sub Main()

        Dim miPromedio As Integer = promedio(10, 50, 20, 30)
        Dim miPromedio2 As Integer = promedio(30, 10, 10, 10)

        Dim miArray() As Integer = {1, 2, 3}
        Dim miSuma As Integer = suma(miArray)

        Console.WriteLine("El promedio de promedio 1 es {0} ", miPromedio)
        Console.WriteLine("El promedio de promedio 1 es {0} ", miPromedio2)

    End Sub

    Function suma(ByVal num1() As Integer) As Integer


    End Function

    Function promedio(ParamArray ByVal nums() As Integer) As Integer
        Dim resultado As Integer = 0
        For i As Integer = 0 To nums.Count - 1
            resultado += nums(i)
        Next

        Return resultado / nums.Count

    End Function



End Module
