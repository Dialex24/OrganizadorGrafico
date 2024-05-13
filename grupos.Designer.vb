<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grupos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreGrupo = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.cmbCitas = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(198, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Grupo O Etiqueta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese el nombre del nuevo grupo"
        '
        'txtNombreGrupo
        '
        Me.txtNombreGrupo.Location = New System.Drawing.Point(247, 111)
        Me.txtNombreGrupo.Name = "txtNombreGrupo"
        Me.txtNombreGrupo.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreGrupo.TabIndex = 2
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(224, 214)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(84, 43)
        Me.btnConfirmar.TabIndex = 3
        Me.btnConfirmar.Text = "Agregar Grupos"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'cmbCitas
        '
        Me.cmbCitas.FormattingEnabled = True
        Me.cmbCitas.Location = New System.Drawing.Point(206, 160)
        Me.cmbCitas.Name = "cmbCitas"
        Me.cmbCitas.Size = New System.Drawing.Size(121, 21)
        Me.cmbCitas.TabIndex = 4
        '
        'grupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 331)
        Me.Controls.Add(Me.cmbCitas)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtNombreGrupo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "grupos"
        Me.Text = "grupos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreGrupo As TextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents cmbCitas As ComboBox
End Class
