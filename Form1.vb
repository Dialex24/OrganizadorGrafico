Public Class Form1

    ' Crear una lista para almacenar las citas
    Dim citas As New List(Of Cita)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el DataGridView
        DataGridView1.ColumnCount = 4
        DataGridView1.Columns(0).Name = "Fecha"
        DataGridView1.Columns(1).Name = "Lugar"
        DataGridView1.Columns(2).Name = "Hora"
        DataGridView1.Columns(3).Name = "Urgente"
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Obtener los datos de la nueva cita
        Dim fecha As String = txtFecha.Text
        Dim lugar As String = txtLugar.Text
        Dim hora As String = txtHora.Text
        Dim urgente As Boolean = chkUrgente.Checked

        ' Crear una nueva instancia de Cita
        Dim nuevaCita As New Cita(fecha, lugar, hora, urgente)

        ' Agregar la cita a la lista
        citas.Add(nuevaCita)

        ' Mostrar las citas en el DataGridView
        MostrarCitas()
    End Sub

    Private Sub MostrarCitas()
        ' Limpiar el DataGridView
        DataGridView1.Rows.Clear()

        ' Ordenar la lista de citas (mostrar las urgentes primero)
        citas.Sort(Function(x, y) y.Urgente.CompareTo(x.Urgente))

        ' Mostrar las citas en el DataGridView
        For Each cita In citas
            Dim urgenteString As String
            If cita.Urgente Then
                urgenteString = "Sí"
            Else
                urgenteString = "No"
            End If
            DataGridView1.Rows.Add({cita.Fecha, cita.Lugar, cita.Hora, urgenteString})
        Next
    End Sub

End Class

Public Class Cita
    Public Property Fecha As String
    Public Property Lugar As String
    Public Property Hora As String
    Public Property Urgente As Boolean

    Public Sub New(ByVal fecha As String, ByVal lugar As String, ByVal hora As String, ByVal urgente As Boolean)
        Me.Fecha = fecha
        Me.Lugar = lugar
        Me.Hora = hora
        Me.Urgente = urgente
    End Sub
End Class

