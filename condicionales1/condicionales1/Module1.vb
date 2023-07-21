Module Module1

    Sub Main()

        Console.WriteLine("Bienvenido")
        Console.WriteLine("-----------------------------------------")
        Console.WriteLine()
        Console.WriteLine("Menu principal")
        Console.WriteLine("1. Consulta de saldo")
        Console.WriteLine("2. Ingresar")
        Console.WriteLine("3. Retirar")
        Console.WriteLine("4. Salir")
        Console.WriteLine("Seleccione una opcion: ")

        Dim opcion As Integer = CInt(Console.ReadLine())
        If opcion = 1 Then
            Console.WriteLine("opcion 1")
        ElseIf opcion = 2 Then
            Console.WriteLine("opcion 2")
        ElseIf opcion = 3 Then
            Console.WriteLine("opcion 3")
        Else
            Console.WriteLine("adios")
        End If



    End Sub

End Module
