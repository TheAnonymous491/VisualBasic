Module Module1

    Sub Main()
        encabezado("        Bienvenidos")

        Console.Write("Introduzca el primer factor: ")
        Dim factor1 As Integer = CInt(Console.ReadLine())

        Console.Write("Introduzca el segundo factor: ")
        Dim factor2 As Integer = CInt(Console.ReadLine())

        encabezado("Resultado de la multiplicacion")
        multiplicar(factor1, factor2)

    End Sub

    Private Sub multiplicar(f1 As Integer, f2 As Integer)
        Dim producto As Integer = f1 * f2
        Console.WriteLine("el producto es: " & producto)
    End Sub
    Private Sub encabezado(texto As String)
        Console.WriteLine()
        Console.WriteLine(" ------------------------------------")
        Console.WriteLine(texto)
        Console.WriteLine(" ------------------------------------")
        Console.WriteLine()
    End Sub


End Module
