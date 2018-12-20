Imports Final2018
Public NotInheritable Class Autor
    Implements Empleado
    Private _dni As UInteger
    Private _nombre As String
    Private _total As Decimal
    Protected _listaMaterial As List(Of Material)

    Public Property Dni As UInteger Implements Empleado.Dni
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            If value < 0 Then
                Throw New Exception("Solo numeros positivos")
            Else
                _dni = value
            End If
        End Set
    End Property

    Public Property Nombre As String Implements Empleado.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length < 3 Then
                Throw New Exception("Nombre demaciado corto, 3 caracteres minimo")
            Else
                _nombre = value
            End If
        End Set
    End Property

    Public Function CalcularGanancia() As Decimal Implements Empleado.CalcularGanancia
        _total += Material.PorcentajeEditorPorLibro
        Return _total
    End Function



    Public Sub addMaterial(material As Material)
        _listaMaterial.Add(material)
    End Sub

    Friend Sub removeAlumno(material As Material)
        _listaMaterial.Remove(material)
    End Sub

    Public Function ToString() As String
        Return _nombre & " " & _dni
    End Function


    Sub New(dni As UInteger, nombre As String)
        Me.Dni = dni
        Me.Nombre = nombre
        '' _listaMaterial = New List(Of Material)
    End Sub
End Class
