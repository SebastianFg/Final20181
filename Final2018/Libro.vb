Public Class Libro
    Inherits Material
    Private _ISBN As String


    Public Property ISBN() As String
        Get
            Return _ISBN
        End Get
        Set(value As String)
            _ISBN = value
        End Set
    End Property

    Public Function GananciaPorcentajeAutor() As Decimal
        Return (100 - Material.PorcentajeEditorPorLibro) / Material.cantidadAutores
    End Function

    Public Function toString() As String
        Return Titulo & " de " & ISBN
    End Function

    Sub New(isbn As String, titulo As String, montoContrato As Decimal)
        MyBase.New(titulo, montoContrato)
        Me.ISBN = isbn

    End Sub
End Class
