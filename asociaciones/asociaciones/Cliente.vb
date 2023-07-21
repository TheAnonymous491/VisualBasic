Public Class Cliente
    Public nombre As String
    Public cedula As String
    Public direccion As String
    Public telefono As String

    Public Sub New()

    End Sub

    Public Sub New(nom As String, ced As String, dire As String, tel As String)
        nombre = nom
        cedula = ced
        direccion = dire
        telefono = tel
    End Sub

    Public Property NombreCliente() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property CedulaCliente() As String
        Get
            Return cedula
        End Get
        Set(value As String)
            cedula = value
        End Set
    End Property

    Public Property DireccionCliente() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property TelefonoCliente() As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

End Class
