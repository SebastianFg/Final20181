Imports Final2018

Public Class Borrador
    Inherits Material
    Sub New(titulo As String, montoContrato As Decimal)
        MyBase.New(titulo, montoContrato)
    End Sub

    Public Function GanciaPorcentajeAutor()
        Return (100 - Material.PorcentajeEditorPorBorrador) / Material.cantidadAutores
    End Function

    Public Function toString() As String
        Return GanciaPorcentajeAutor()
    End Function
End Class
