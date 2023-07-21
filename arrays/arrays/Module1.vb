Module Module1

    Sub Main()

        'Declaracion de array
        'Dim miArray(2) As String
        'miArray(0) = "Antonio"
        'miArray(1) = "Francisco"
        'miArray(2) = "Juan"

        'ReDim Preserve miArray(1) 'redimensionar un array (Preserve es para mantener los valores)


        Dim miArray(2, 2) As String
        miArray(0, 0) = "Antonio"
        miArray(0, 1) = "35"
        miArray(0, 2) = "9623456752"

        miArray(1, 0) = "Juan"
        miArray(1, 1) = "20"
        miArray(1, 2) = "9623455667"

        miArray(2, 0) = "Francisco"
        miArray(2, 1) = "30"
        miArray(2, 2) = "923456789"

        'Mostrar el valor en la consola 
        Console.WriteLine(miArray(2, 0) + " " + miArray(2, 1) + " " + miArray(2, 2))
        'Console.Read()



    End Sub

End Module
