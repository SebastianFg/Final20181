Public MustInherit Class Material
    Private _titulo As String
    Private _montoContrato As Decimal
    Private Shared _porcentajeEditorPorBorrador As Byte
    Private Shared _porcentajeEditorPorLibro As Byte
    Private Shared _autor As New List(Of Autor)
    Private _Editor As Editor



    'Public Property Editor() As Editor
    '    Get
    '        Return _Editor
    '    End Get
    '    Set(value As Editor)

    '        _Editor = value
    '    End Set
    'End Property

    Public Property Titulo() As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            If value.Length < 3 Then
                Throw New Exception("La cantidad de caracteres minima es 3")
            Else
                _titulo = value
            End If
        End Set
    End Property


    Public Property MontoContrato() As Decimal
        Get
            Return _montoContrato
        End Get
        Set(value As Decimal)
            If value < 3 Then
                Throw New Exception("Solo numeros positivos")
            Else
                _montoContrato = value
            End If
        End Set
    End Property


    Public Shared Property PorcentajeEditorPorBorrador() As Byte
        Get
            Return _porcentajeEditorPorBorrador
        End Get
        Set(value As Byte)

            _porcentajeEditorPorBorrador = value

        End Set
    End Property
    Public Shared Property PorcentajeEditorPorLibro() As Byte
        Get
            Return _porcentajeEditorPorLibro
        End Get
        Set(value As Byte)
            If value < 3 Then
                Throw New Exception("Solo numeros positivos")
            Else
                _porcentajeEditorPorLibro = value
            End If
        End Set
    End Property


    Protected Shared Function cantidadAutores() As Integer
        Return _autor.Count
    End Function

    Friend Sub addAutor(autor As Autor)
        If _autor.Count <= 3 Then
            autor.addMaterial(Me)
            _autor.Add(autor)
        Else
            Throw New Exception("Supera los 3")
        End If
    End Sub

    Friend Sub removeAlumno(autor As Autor)
        autor = Nothing
        _autor.Remove(autor)
    End Sub

    Public Sub addEditor(editor As Editor)

        _Editor = editor
    End Sub

    Sub New(titulo As String, montocontrato As Decimal)
        Me.Titulo = titulo
        Me.MontoContrato = montocontrato
        _autor = New List(Of Autor)
    End Sub

    Public Function ToString() As String
        Return Titulo
    End Function
End Class
