Module Module1

    Sub Main()
        Dim banco As New Banco("Santander")
        banco.crearCuentaCliente(New Cliente("Joancy", "123", "aqui", "4444"), 2000)
        banco.crearCuentaCliente(New Cliente("Lupe", "321", "alla", "5555"), 2000)

        banco.depositarDineroCuenta(1, 400)
        banco.depositarDineroCuenta(2, 500)

        Console.WriteLine(banco.getSaldoCuenta(1))
        Console.WriteLine(banco.getSaldoCuenta(2))

        banco.retirarDineroCuenta(1, 800)
        banco.retirarDineroCuenta(2, 450)

        Console.WriteLine(banco.getSaldoCuenta(1))
        Console.WriteLine(banco.getSaldoCuenta(2))

        Dim ca As CuentaAhorros = banco.buscarCuentaCliente("321")
        Console.WriteLine("No de cuenta-> " & ca.getNumCuenta)
        Console.WriteLine("Nombre del cliente->" & ca.ClienteCuenta.nombrePersona)


    End Sub

End Module
