Public Class Cuenta
    Protected numCuenta As Integer
    Protected saldo As Double
    Protected cliente As Cliente
    Protected Shared id As Integer = 1

    Public Sub New()
        numCuenta = id
        cliente = Nothing
        saldo = 0
        id += 1
    End Sub

    Public Sub New(cl As Cliente, sa As Double)
        numCuenta = id
        cliente = cl
        saldo = sa
        id += 1
    End Sub

    Public Sub retirarDinero(valor As Double)
        If saldo >= valor Then
            saldo = saldo - valor
        Else
            Console.WriteLine("No se puede retirar")
        End If

    End Sub

    Public Sub ingresarDinero(valor As Double)
        saldo = saldo + valor
    End Sub

    Public Function getSaldo() As Double
        Return saldo
    End Function

    Public Function getNumCuenta() As Integer
        Return numCuenta
    End Function

    Public Property ClienteCuenta As Cliente
        Get
            Return cliente
        End Get
        Set(value As Cliente)
            If cliente Is Nothing Then
                cliente = value

            Else
                Console.WriteLine("El cliente ya esta asignado a la cuenta")
            End If
        End Set
    End Property

End Class
