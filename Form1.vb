Public Class Form1

    ' Crear una lista para almacenar las citas
    Dim citas As New List(Of Cita)
    ' Crear una lista para almacenar los grupos
    Dim grupos As New List(Of Grupo)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el DataGridView
        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).Name = "Fecha"
        DataGridView1.Columns(1).Name = "Lugar"
        DataGridView1.Columns(2).Name = "Hora"
        DataGridView1.Columns(3).Name = "Urgente"
        DataGridView1.Columns(4).Name = "Grupo"

        citas.Add(New Cita("2024-05-13", "Oficina", "09:00", True))
        citas.Add(New Cita("2024-05-14", "Cafetería", "15:30", False))
        citas.Add(New Cita("2024-05-15", "Gimnasio", "18:00", True))

        MostrarCitas()
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
            Dim grupo As String = ""
            ' Buscar el grupo al que pertenece la cita (si tiene alguno)
            For Each g In grupos
                If g.Citas.Contains(cita) Then
                    grupo = g.Nombre
                    Exit For
                End If
            Next
            DataGridView1.Rows.Add({cita.Fecha, cita.Lugar, cita.Hora, urgenteString, grupo})
        Next
    End Sub

    Private Sub btnCrearGrupo_Click(sender As Object, e As EventArgs) Handles btnCrearGrupo.Click
        ' Crear una instancia de la ventana de creación de grupo
        Dim grupos As New grupos(citas)
        ' Mostrar la ventana de creación de grupo
        grupos.ShowDialog(Me)
    End Sub

    Public Sub AgregarGrupo(ByVal grupo As Grupo)
        ' Agregar el grupo a la lista de grupos
        grupos.Add(grupo)

        ' Mostrar las citas en el DataGridView actualizando los grupos
        MostrarCitas()
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

Public Class Grupo
    Public Property Nombre As String
    Public Property Citas As New List(Of Cita)

    Public Sub New(ByVal nombre As String)
        Me.Nombre = nombre
    End Sub
End Class

