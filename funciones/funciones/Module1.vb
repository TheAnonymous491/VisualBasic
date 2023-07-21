Module Module1

    Sub Main()

        'pedimos el alto del triangulo
        Console.Write("Introduzca el alto del triangulo: ")
        Dim alto As Integer = CInt(Console.ReadLine())

        'pedimos el ancho del triangulo
        Console.Write("Introduzca el ancho del triangulo: ")
        Dim ancho As Integer = CInt(Console.ReadLine())

        Dim miArea As Double = areaTriangulo(alto, ancho)
        Console.WriteLine("El area del triangulo es: {0} porque su alto es {1} y su ancho es {2}", miArea, alto, ancho)
    End Sub

    Sub area(al As Integer, an As Integer)
        Dim area As Double = (al * an) / 2
        Console.WriteLine("El area del triangulo es: " & area)

    End Sub

    Function areaTriangulo(al As Integer, an As Integer) As Double
        Dim area As Double = (al * an) / 2
        Return area

    End Function

End Module
