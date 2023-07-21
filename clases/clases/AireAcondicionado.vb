Public Class AireAcondicionado

    Private marca As String
    Private modelo As String
    Private color As String
    Private voltaje As Integer
    Private btu As Integer
    Private temperatura As Integer

    Public Sub New(ma As String, co As String, vo As Integer, bt As Integer)
        marca = ma
        color = co
        voltaje = vo
        btu = bt
        temperatura = 17
        modelo = marca.Substring(0, 2) & voltaje.ToString & "ac" & btu.ToString.Substring(0, 2) & "k2020"

    End Sub

    Public Sub New(ma As String, vo As Integer, bt As Integer)
        marca = ma
        voltaje = vo
        btu = bt
        temperatura = 17
        modelo = marca.Substring(0, 2) & voltaje.ToString & "ac" & btu.ToString.Substring(0, 2) & "k2020"
    End Sub

    Public Sub New()

    End Sub

    Public Sub subirTemperatura()

        If temperatura < 30 Then
            temperatura += 1
        End If

    End Sub

    Public Sub subirTemperatura(grados As Integer)
        Dim temp As Integer = temperatura + grados

        If temp > 30 Then
            temperatura = 30
        Else
            temperatura = temp

        End If

    End Sub

    Public Sub bajarTemperatura()
        If temperatura > 17 Then
            temperatura -= 1
        End If

    End Sub

    Public Sub bajarTemperatura(grados As Integer)
        Dim temp As Integer = temperatura - grados
        If temp < 17 Then
            temperatura = 17
        Else
            temperatura = temp
        End If
    End Sub

    Public Property MarcaAire As String

        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property

    Public Property ModeloAire As String

        Get
            Return modelo
        End Get
        Set(value As String)
            modelo = value
        End Set
    End Property

    Public Property ColorAire As String

        Get
            Return color
        End Get
        Set(value As String)
            color = value
        End Set
    End Property

    Public Property VoltajeAire As String

        Get
            Return voltaje
        End Get
        Set(value As String)
            voltaje = value
        End Set
    End Property

    Public Property BtuAire As String

        Get
            Return btu
        End Get
        Set(value As String)
            btu = value
        End Set
    End Property

    Public Property TemperaturaAire As String

        Get
            Return temperatura
        End Get
        Set(value As String)
            temperatura = value
        End Set
    End Property
End Class
