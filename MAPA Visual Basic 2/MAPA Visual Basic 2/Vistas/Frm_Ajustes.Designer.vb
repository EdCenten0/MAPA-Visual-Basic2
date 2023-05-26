<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ajustes
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
        Me.panel_contenedor_ajustes = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bt_taller = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_contenedor_ajustes
        '
        Me.panel_contenedor_ajustes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_contenedor_ajustes.Location = New System.Drawing.Point(200, 0)
        Me.panel_contenedor_ajustes.Name = "panel_contenedor_ajustes"
        Me.panel_contenedor_ajustes.Size = New System.Drawing.Size(696, 657)
        Me.panel_contenedor_ajustes.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.bt_taller)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 657)
        Me.Panel1.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Button3.Location = New System.Drawing.Point(0, 153)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 52)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Usuarios"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Button2.Location = New System.Drawing.Point(0, 101)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 52)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Roles"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bt_taller
        '
        Me.bt_taller.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_taller.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_taller.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.bt_taller.FlatAppearance.BorderSize = 0
        Me.bt_taller.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_taller.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.bt_taller.Location = New System.Drawing.Point(0, 49)
        Me.bt_taller.Margin = New System.Windows.Forms.Padding(5)
        Me.bt_taller.Name = "bt_taller"
        Me.bt_taller.Size = New System.Drawing.Size(200, 52)
        Me.bt_taller.TabIndex = 4
        Me.bt_taller.Text = "Taller"
        Me.bt_taller.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 49)
        Me.Panel2.TabIndex = 3
        '
        'Frm_Ajustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 657)
        Me.Controls.Add(Me.panel_contenedor_ajustes)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_Ajustes"
        Me.Text = "Frm_Ajustes"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_contenedor_ajustes As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bt_taller As Button
    Friend WithEvents Panel2 As Panel
End Class
