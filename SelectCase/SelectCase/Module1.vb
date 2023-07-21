Module Module1

    Sub Main()

        Dim tarjetas(2, 2) As String

        'ingresar los datos de la primer tarjeta
        tarjetas(0, 0) = "000000"
        tarjetas(0, 1) = "0000"
        tarjetas(0, 2) = "500"

        'ingresar los datos de la segunda tarjeta
        tarjetas(1, 0) = "111111"
        tarjetas(1, 1) = "1111"
        tarjetas(1, 2) = "1000"

        'ingresar los datos de la tercer tarjeta
        tarjetas(2, 0) = "222222"
        tarjetas(2, 1) = "2222"
        tarjetas(2, 2) = "2000"

        Console.Write("Por Favor introduzca su tarjeta: ")
        Dim numTarjeta As String = Console.ReadLine()
        Console.WriteLine("-----------------------------------------")
        Console.Write("Introduzca su pin: ")
        Dim pin As String = Console.ReadLine()

        Dim saldo As Decimal
        Dim encontrada As Boolean = False
        For i = 0 To 2
            If numTarjeta = tarjetas(i, 0) And pin = tarjetas(i, 1) Then
                encontrada = True
                saldo = CDec(tarjetas(i, 2))
            End If
        Next

        If encontrada = True Then

            Dim ingreso As Decimal
            Dim retirada As Decimal
            Dim opcionUsuario As Integer

            Do
                Console.Clear()
                Console.WriteLine("-----------------------------------------")
                Console.WriteLine("Bienvenido")
                Console.WriteLine("-----------------------------------------")
                Console.WriteLine()
                Console.WriteLine("Menu principal")
                Console.WriteLine("1. Consulta de saldo")
                Console.WriteLine("2. Ingresar")
                Console.WriteLine("3. Retirar")
                Console.WriteLine("4. Salir")
                Console.WriteLine("Seleccione una opcion: ")

                opcionUsuario = CInt(Console.ReadLine())

                Select Case opcionUsuario
                    Case 1
                        Console.WriteLine()
                        Console.WriteLine("-----------------------------------------------------")
                        Console.WriteLine("Su saldo actual es de: $" & saldo)
                        Console.WriteLine("-----------------------------------------------------")
                        Console.ReadLine()
                    Case 2
                        Console.WriteLine()
                        Console.WriteLine("-----------------------------------------------------")
                        Console.Write("Introduzca la cantidad a ingresar: ")
                        ingreso = CDec(Console.ReadLine())
                        Console.WriteLine("-----------------------------------------------------")
                        saldo = saldo + ingreso
                        Console.ReadLine()
                    Case 3
                        Console.WriteLine()
                        Console.WriteLine("-----------------------------------------------------")
                        Console.Write("Introduzca la cantidad a retirar: ")
                        retirada = CDec(Console.ReadLine())
                        Console.WriteLine("-----------------------------------------------------")
                        If retirada > saldo Then
                            Console.WriteLine("El saldo de su tarjeta es inferior a la cantidad a retirar. Indique una cantidad distinta")
                        Else
                            saldo = saldo - retirada
                        End If
                        Console.ReadLine()
                    Case 4
                        Console.WriteLine()
                        Console.WriteLine("-----------------------------------------------------")
                        Console.WriteLine("adios")
                        Console.WriteLine("-----------------------------------------------------")
                    Case Else
                        Console.WriteLine("opcion no valida")
                        Console.ReadLine()
                End Select

            Loop Until opcionUsuario = 4

        Else
            Console.WriteLine("-----------------------------------------")
            Console.WriteLine("Numero de tarjeta o pin incorrecto")
            Console.ReadLine()

        End If

    End Sub

End Module
