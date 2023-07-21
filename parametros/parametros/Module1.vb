Module Module1

    Sub Main()

        Console.Write("Introduzca un numero: ")
        Dim numero As Integer = CInt(Console.ReadLine())

        Dim resultado As Integer = doble(numero)
        Console.WriteLine("El doble de {0} es: {1}", numero, resultado)


    End Sub

    Function doble(num As Integer) As Integer
        num *= 2
        Return num
    End Function

End Module
