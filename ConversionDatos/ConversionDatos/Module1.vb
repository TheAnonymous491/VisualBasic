Module Module1

    Sub Main()
        Console.WriteLine("Bienvenidos")
        Console.WriteLine("Introduzca el primer numero: ")
        Dim numero1 As Integer = CInt(Console.ReadLine)

        Console.WriteLine("Introduzca el segundo numero: ")
        Dim numero2 As Integer = CInt(Console.ReadLine)

        Console.WriteLine("El resultado es: " & numero1 + numero2)

    End Sub

End Module
