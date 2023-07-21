Public Class Deportista
    Private nombre As String
    Private posicion As String
    Private edad As Integer
    Private estatura As Double

    Public Sub New()

    End Sub

    Public Sub New(nom As String, pos As String, e As Integer, est As Double)
        nombre = nom
        posicion = pos
        edad = e
        estatura = est

    End Sub

    Public Property nombreDeportista As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property posicionDeportista As String
        Get
            Return posicion
        End Get
        Set(value As String)
            posicion = value
        End Set
    End Property

    Public Property edadDeportista As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
        End Set
    End Property

    Public Property estaturaDeportista As Double
        Get
            Return estatura
        End Get
        Set(value As Double)
            estatura = value
        End Set
    End Property

End Class
