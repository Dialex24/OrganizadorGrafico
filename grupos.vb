Public Class grupos


    ' Lista de citas disponibles para seleccionar
    Private citasDisponibles As List(Of Cita)

    ' Constructor que recibe la lista de citas disponibles
    Public Sub New(ByVal citasDisponibles As List(Of Cita))
        InitializeComponent()

        ' Asignar la lista de citas disponibles al campo local
        Me.citasDisponibles = citasDisponibles

        ' Configurar el ComboBox para que muestre el lugar de la cita
        cmbCitas.DisplayMember = "Lugar"

        ' Rellenar el ComboBox con las citas disponibles
        For Each cita As Cita In citasDisponibles
            cmbCitas.Items.Add(cita)
        Next
    End Sub

    ' Manejar el clic del botón de confirmación
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        ' Crear un nuevo grupo con el nombre ingresado
        Dim nuevoGrupo As New Grupo(txtNombreGrupo.Text)

        ' Agregar las citas seleccionadas al grupo
        If cmbCitas.SelectedItem IsNot Nothing Then
            nuevoGrupo.Citas.Add(TryCast(cmbCitas.SelectedItem, Cita))
        End If

        ' Pasar el nuevo grupo de vuelta a la vista principal
        CType(Owner, Form1).AgregarGrupo(nuevoGrupo)

        ' Cerrar la ventana de creación de grupo
        Me.Close()
    End Sub

End Class