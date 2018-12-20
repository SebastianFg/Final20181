Imports Final2018

Public Class Editor
    Implements Empleado
    Private _dni As UInteger
    Private _nombre As String
    Private _listaMateriales As New List(Of Material)


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

    Public Sub addMaterial(material As Material)
        material.addEditor(Me)

        _listaMateriales.Add(material)
    End Sub

    Public Function CalcularGanancia() As Decimal Implements Empleado.CalcularGanancia
        Return Material.PorcentajeEditorPorLibro + 0.05
    End Function

    Public Function toString() As String
        Return Nombre & " " & Dni
    End Function



    Sub New(dni As UInteger, nombre As String)
        Me.Dni = dni
        Me.Nombre = nombre
        _listaMateriales = New List(Of Material)
    End Sub
    'Public Overrides Sub addMaterial(material As Material)
    '    material.addAutor(Me)
    '    _asignatura.Add(asignatura)
    'End Sub
    'Public Overrides Sub removeAsignatura(asignatura As Asignatura)
    '    asignatura.removeAlumno(Me)
    '    MyBase.RemoveAsignatura(asignatura)
    'End Sub
End Class
