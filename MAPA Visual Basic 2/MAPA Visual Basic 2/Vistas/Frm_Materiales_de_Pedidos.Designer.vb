<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Materiales_de_Pedidos
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.RichTextBox()
        Me.txt_precio_total = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.txt_precio_unidad = New System.Windows.Forms.TextBox()
        Me.txt_material = New System.Windows.Forms.TextBox()
        Me.btn_vaciar_campos = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.precio_por_unidad = New System.Windows.Forms.Label()
        Me.lbl_descripción = New System.Windows.Forms.Label()
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.cb_unidad_medida = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.lblId)
        Me.Panel2.Controls.Add(Me.txt_descripcion)
        Me.Panel2.Controls.Add(Me.txt_precio_total)
        Me.Panel2.Controls.Add(Me.txt_cantidad)
        Me.Panel2.Controls.Add(Me.txt_precio_unidad)
        Me.Panel2.Controls.Add(Me.txt_material)
        Me.Panel2.Controls.Add(Me.btn_vaciar_campos)
        Me.Panel2.Controls.Add(Me.btn_eliminar)
        Me.Panel2.Controls.Add(Me.btn_editar)
        Me.Panel2.Controls.Add(Me.btn_guardar)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lbl_cantidad)
        Me.Panel2.Controls.Add(Me.precio_por_unidad)
        Me.Panel2.Controls.Add(Me.lbl_descripción)
        Me.Panel2.Controls.Add(Me.lbl_material)
        Me.Panel2.Controls.Add(Me.cb_unidad_medida)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(21, 20)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 251)
        Me.Panel2.TabIndex = 7
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.SystemColors.Control
        Me.lblId.Location = New System.Drawing.Point(135, 16)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(0, 24)
        Me.lblId.TabIndex = 16
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripcion.Location = New System.Drawing.Point(241, 68)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(207, 95)
        Me.txt_descripcion.TabIndex = 15
        Me.txt_descripcion.Text = ""
        '
        'txt_precio_total
        '
        Me.txt_precio_total.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_precio_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio_total.Location = New System.Drawing.Point(600, 197)
        Me.txt_precio_total.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_precio_total.Name = "txt_precio_total"
        Me.txt_precio_total.Size = New System.Drawing.Size(132, 29)
        Me.txt_precio_total.TabIndex = 14
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.Location = New System.Drawing.Point(600, 12)
        Me.txt_cantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(80, 29)
        Me.txt_cantidad.TabIndex = 13
        '
        'txt_precio_unidad
        '
        Me.txt_precio_unidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_precio_unidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio_unidad.Location = New System.Drawing.Point(241, 193)
        Me.txt_precio_unidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_precio_unidad.Name = "txt_precio_unidad"
        Me.txt_precio_unidad.Size = New System.Drawing.Size(207, 29)
        Me.txt_precio_unidad.TabIndex = 12
        '
        'txt_material
        '
        Me.txt_material.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_material.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_material.Location = New System.Drawing.Point(241, 12)
        Me.txt_material.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.Size = New System.Drawing.Size(207, 29)
        Me.txt_material.TabIndex = 10
        '
        'btn_vaciar_campos
        '
        Me.btn_vaciar_campos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_vaciar_campos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vaciar_campos.Location = New System.Drawing.Point(945, 201)
        Me.btn_vaciar_campos.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_vaciar_campos.Name = "btn_vaciar_campos"
        Me.btn_vaciar_campos.Size = New System.Drawing.Size(160, 33)
        Me.btn_vaciar_campos.TabIndex = 9
        Me.btn_vaciar_campos.Text = "Vaciar Campos"
        Me.btn_vaciar_campos.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(945, 140)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(160, 38)
        Me.btn_eliminar.TabIndex = 8
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.Location = New System.Drawing.Point(945, 76)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(160, 36)
        Me.btn_editar.TabIndex = 7
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Location = New System.Drawing.Point(945, 12)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(160, 37)
        Me.btn_guardar.TabIndex = 6
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(476, 201)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Precio Total:"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantidad.Location = New System.Drawing.Point(476, 16)
        Me.lbl_cantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(89, 24)
        Me.lbl_cantidad.TabIndex = 4
        Me.lbl_cantidad.Text = "Cantidad:"
        '
        'precio_por_unidad
        '
        Me.precio_por_unidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.precio_por_unidad.AutoSize = True
        Me.precio_por_unidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precio_por_unidad.Location = New System.Drawing.Point(4, 197)
        Me.precio_por_unidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.precio_por_unidad.Name = "precio_por_unidad"
        Me.precio_por_unidad.Size = New System.Drawing.Size(199, 24)
        Me.precio_por_unidad.TabIndex = 3
        Me.precio_por_unidad.Text = "Precio*UnidadMedida:"
        '
        'lbl_descripción
        '
        Me.lbl_descripción.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_descripción.AutoSize = True
        Me.lbl_descripción.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripción.Location = New System.Drawing.Point(4, 101)
        Me.lbl_descripción.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_descripción.Name = "lbl_descripción"
        Me.lbl_descripción.Size = New System.Drawing.Size(115, 24)
        Me.lbl_descripción.TabIndex = 2
        Me.lbl_descripción.Text = "Descripción:"
        '
        'lbl_material
        '
        Me.lbl_material.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_material.AutoSize = True
        Me.lbl_material.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_material.Location = New System.Drawing.Point(4, 16)
        Me.lbl_material.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(80, 24)
        Me.lbl_material.TabIndex = 1
        Me.lbl_material.Text = "Material:"
        '
        'cb_unidad_medida
        '
        Me.cb_unidad_medida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_unidad_medida.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_unidad_medida.FormattingEnabled = True
        Me.cb_unidad_medida.Items.AddRange(New Object() {"Lbs", "Lts", "Mts", "Inches", "Galón", "Unidad", "Simple"})
        Me.cb_unidad_medida.Location = New System.Drawing.Point(689, 12)
        Me.cb_unidad_medida.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_unidad_medida.Name = "cb_unidad_medida"
        Me.cb_unidad_medida.Size = New System.Drawing.Size(229, 32)
        Me.cb_unidad_medida.TabIndex = 0
        Me.cb_unidad_medida.Text = "Seleccione una opción"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 278)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1109, 366)
        Me.DataGridView1.TabIndex = 6
        '
        'Frm_Materiales_de_Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 665)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Frm_Materiales_de_Pedidos"
        Me.Text = "Frm_Materiales_de_Pedidos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblId As Label
    Friend WithEvents txt_descripcion As RichTextBox
    Friend WithEvents txt_precio_total As TextBox
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents txt_precio_unidad As TextBox
    Friend WithEvents txt_material As TextBox
    Friend WithEvents btn_vaciar_campos As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_cantidad As Label
    Friend WithEvents precio_por_unidad As Label
    Friend WithEvents lbl_descripción As Label
    Friend WithEvents lbl_material As Label
    Friend WithEvents cb_unidad_medida As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
