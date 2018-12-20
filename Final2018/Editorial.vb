Public Class Editorial
    Private Shared _listaAutor As List(Of Autor)
    Private Shared _listaMaterial As List(Of Material)
    Private Shared _listaEmpleados As List(Of Autor)



    Friend Sub removeMaterial(material As Material)
        _listaMaterial.Add(material)
    End Sub

    ''lista autores x dni
    Public Shared Function GetAutor(dni As UInteger) As Autor
        For Each autor In _listaAutor
            If autor.Dni.Equals(dni) Then
                Return autor
            End If
        Next
    End Function
    ''lista autores por nombre
    Public Shared Function GetAllMateriales(nombre As String) As List(Of Autor)
        Dim _listaEmpleados = New List(Of Autor)
        For Each autor In _listaAutor
            If autor.Nombre.Equals(nombre) Then
                _listaEmpleados.Add(autor)
            End If
        Next
        Return _listaEmpleados
    End Function
    ''lista materiales
    Public Shared Function GetAllMateriales() As List(Of Material)
        Return _listaMaterial
    End Function

    Public Shared Function GetAllEmpleados() As List(Of Autor)
        Return _listaEmpleados
    End Function
End Class
