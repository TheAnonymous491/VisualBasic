Module Module1

    Sub Main()
        Dim cliente1 As Cliente = New Cliente("Pepito", "123", "calle falsa 123", "5678")
        Dim cuenta1 As CuenteAhorros = New CuenteAhorros(cliente1, 250)

        Console.WriteLine(cuenta1.getSaldo())

        cuenta1.depositarDinero(350)

        Console.WriteLine(cuenta1.getSaldo)

        cuenta1.retirarDinero(500)

        Console.WriteLine(cuenta1.getSaldo)

        Console.WriteLine(cuenta1.ClienteCuenta.nombre)
    End Sub

End Module
