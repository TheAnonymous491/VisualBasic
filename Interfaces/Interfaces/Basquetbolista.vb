Public Class Basquetbolista
    Inherits Deportista
    Implements IBasquetbolista

    Public Sub New(nom As String, pos As String, e As Integer, est As Double)
        MyBase.New(nom, pos, e, est)
    End Sub

    Public Function verificarEstatura() As Boolean Implements IBasquetbolista.verificarEstatura
        Throw New NotImplementedException()
    End Function
End Class
