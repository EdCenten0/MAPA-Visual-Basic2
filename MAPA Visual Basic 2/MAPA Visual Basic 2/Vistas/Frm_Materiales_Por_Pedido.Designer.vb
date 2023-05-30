<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Materiales_Por_Pedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_id_material = New System.Windows.Forms.Label()
        Me.MaterialesporpedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAPADataSet = New MAPA_Visual_Basic_2.MAPADataSet()
        Me.lbl_id_pedido = New System.Windows.Forms.Label()
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
        Me.IdmaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrematerialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidaddemedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioporunidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciototalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdpedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Materiales_por_pedidoTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.materiales_por_pedidoTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.MaterialesporpedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(19, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 40)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Materiales"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.lbl_id_material)
        Me.Panel2.Controls.Add(Me.lbl_id_pedido)
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
        Me.Panel2.Location = New System.Drawing.Point(18, 52)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 201)
        Me.Panel2.TabIndex = 28
        '
        'lbl_id_material
        '
        Me.lbl_id_material.AutoSize = True
        Me.lbl_id_material.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesporpedidoBindingSource, "id_material", True))
        Me.lbl_id_material.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_id_material.Location = New System.Drawing.Point(722, 137)
        Me.lbl_id_material.Name = "lbl_id_material"
        Me.lbl_id_material.Size = New System.Drawing.Size(71, 25)
        Me.lbl_id_material.TabIndex = 18
        Me.lbl_id_material.Text = "Label2"
        '
        'MaterialesporpedidoBindingSource
        '
        Me.MaterialesporpedidoBindingSource.DataMember = "materiales_por_pedido"
        Me.MaterialesporpedidoBindingSource.DataSource = Me.MAPADataSet
        '
        'MAPADataSet
        '
        Me.MAPADataSet.DataSetName = "MAPADataSet"
        Me.MAPADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_id_pedido
        '
        Me.lbl_id_pedido.AutoSize = True
        Me.lbl_id_pedido.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_id_pedido.Location = New System.Drawing.Point(629, 137)
        Me.lbl_id_pedido.Name = "lbl_id_pedido"
        Me.lbl_id_pedido.Size = New System.Drawing.Size(71, 25)
        Me.lbl_id_pedido.TabIndex = 17
        Me.lbl_id_pedido.Text = "Label2"
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
        Me.txt_descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesporpedidoBindingSource, "descripcion", True))
        Me.txt_descripcion.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.txt_descripcion.Location = New System.Drawing.Point(161, 76)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(417, 62)
        Me.txt_descripcion.TabIndex = 15
        Me.txt_descripcion.Text = ""
        '
        'txt_precio_total
        '
        Me.txt_precio_total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesporpedidoBindingSource, "precio_total", True))
        Me.txt_precio_total.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.txt_precio_total.Location = New System.Drawing.Point(703, 76)
        Me.txt_precio_total.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_precio_total.Name = "txt_precio_total"
        Me.txt_precio_total.Size = New System.Drawing.Size(177, 24)
        Me.txt_precio_total.TabIndex = 14
        '
        'txt_cantidad
        '
        Me.txt_cantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesporpedidoBindingSource, "cantidad", True))
        Me.txt_cantidad.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.txt_cantidad.Location = New System.Drawing.Point(699, 9)
        Me.txt_cantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(80, 24)
        Me.txt_cantidad.TabIndex = 13
        '
        'txt_precio_unidad
        '
        Me.txt_precio_unidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesporpedidoBindingSource, "precio_por_unidad", True))
        Me.txt_precio_unidad.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.txt_precio_unidad.Location = New System.Drawing.Point(161, 163)
        Me.txt_precio_unidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_precio_unidad.Name = "txt_precio_unidad"
        Me.txt_precio_unidad.Size = New System.Drawing.Size(417, 24)
        Me.txt_precio_unidad.TabIndex = 12
        '
        'txt_material
        '
        Me.txt_material.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesporpedidoBindingSource, "nombre_material", True))
        Me.txt_material.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.txt_material.Location = New System.Drawing.Point(161, 9)
        Me.txt_material.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.Size = New System.Drawing.Size(417, 24)
        Me.txt_material.TabIndex = 10
        '
        'btn_vaciar_campos
        '
        Me.btn_vaciar_campos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_vaciar_campos.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.btn_vaciar_campos.Location = New System.Drawing.Point(949, 146)
        Me.btn_vaciar_campos.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_vaciar_campos.Name = "btn_vaciar_campos"
        Me.btn_vaciar_campos.Size = New System.Drawing.Size(160, 36)
        Me.btn_vaciar_campos.TabIndex = 9
        Me.btn_vaciar_campos.Text = "Vaciar Campos"
        Me.btn_vaciar_campos.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.btn_eliminar.Location = New System.Drawing.Point(945, 102)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(160, 36)
        Me.btn_eliminar.TabIndex = 8
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_editar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.btn_editar.Location = New System.Drawing.Point(945, 56)
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
        Me.btn_guardar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.btn_guardar.Location = New System.Drawing.Point(945, 12)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(160, 36)
        Me.btn_guardar.TabIndex = 6
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label4.Location = New System.Drawing.Point(586, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Precio Total:"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.lbl_cantidad.Location = New System.Drawing.Point(586, 9)
        Me.lbl_cantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(88, 20)
        Me.lbl_cantidad.TabIndex = 4
        Me.lbl_cantidad.Text = "Cantidad:"
        '
        'precio_por_unidad
        '
        Me.precio_por_unidad.AutoSize = True
        Me.precio_por_unidad.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.precio_por_unidad.Location = New System.Drawing.Point(4, 147)
        Me.precio_por_unidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.precio_por_unidad.Name = "precio_por_unidad"
        Me.precio_por_unidad.Size = New System.Drawing.Size(155, 40)
        Me.precio_por_unidad.TabIndex = 3
        Me.precio_por_unidad.Text = "Precio Por Unidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de Medida:"
        '
        'lbl_descripción
        '
        Me.lbl_descripción.AutoSize = True
        Me.lbl_descripción.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.lbl_descripción.Location = New System.Drawing.Point(4, 76)
        Me.lbl_descripción.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_descripción.Name = "lbl_descripción"
        Me.lbl_descripción.Size = New System.Drawing.Size(107, 20)
        Me.lbl_descripción.TabIndex = 2
        Me.lbl_descripción.Text = "Descripción:"
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.lbl_material.Location = New System.Drawing.Point(4, 16)
        Me.lbl_material.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(79, 20)
        Me.lbl_material.TabIndex = 1
        Me.lbl_material.Text = "Material:"
        '
        'cb_unidad_medida
        '
        Me.cb_unidad_medida.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesporpedidoBindingSource, "unidad_de_medida", True))
        Me.cb_unidad_medida.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.cb_unidad_medida.FormattingEnabled = True
        Me.cb_unidad_medida.Items.AddRange(New Object() {"Lbs", "Lts", "Mts", "Inches", "Galón", "Unidad", "Simple"})
        Me.cb_unidad_medida.Location = New System.Drawing.Point(787, 9)
        Me.cb_unidad_medida.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_unidad_medida.Name = "cb_unidad_medida"
        Me.cb_unidad_medida.Size = New System.Drawing.Size(92, 24)
        Me.cb_unidad_medida.TabIndex = 0
        Me.cb_unidad_medida.Text = "Unidades"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdmaterialDataGridViewTextBoxColumn, Me.NombrematerialDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.UnidaddemedidaDataGridViewTextBoxColumn, Me.PrecioporunidadDataGridViewTextBoxColumn, Me.PreciototalDataGridViewTextBoxColumn, Me.IdpedidoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MaterialesporpedidoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(18, 260)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1109, 366)
        Me.DataGridView1.TabIndex = 27
        '
        'IdmaterialDataGridViewTextBoxColumn
        '
        Me.IdmaterialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdmaterialDataGridViewTextBoxColumn.DataPropertyName = "id_material"
        Me.IdmaterialDataGridViewTextBoxColumn.HeaderText = "id_material"
        Me.IdmaterialDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdmaterialDataGridViewTextBoxColumn.Name = "IdmaterialDataGridViewTextBoxColumn"
        Me.IdmaterialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombrematerialDataGridViewTextBoxColumn
        '
        Me.NombrematerialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombrematerialDataGridViewTextBoxColumn.DataPropertyName = "nombre_material"
        Me.NombrematerialDataGridViewTextBoxColumn.HeaderText = "nombre_material"
        Me.NombrematerialDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombrematerialDataGridViewTextBoxColumn.Name = "NombrematerialDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'UnidaddemedidaDataGridViewTextBoxColumn
        '
        Me.UnidaddemedidaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UnidaddemedidaDataGridViewTextBoxColumn.DataPropertyName = "unidad_de_medida"
        Me.UnidaddemedidaDataGridViewTextBoxColumn.HeaderText = "unidad_de_medida"
        Me.UnidaddemedidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UnidaddemedidaDataGridViewTextBoxColumn.Name = "UnidaddemedidaDataGridViewTextBoxColumn"
        '
        'PrecioporunidadDataGridViewTextBoxColumn
        '
        Me.PrecioporunidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PrecioporunidadDataGridViewTextBoxColumn.DataPropertyName = "precio_por_unidad"
        Me.PrecioporunidadDataGridViewTextBoxColumn.HeaderText = "precio_por_unidad"
        Me.PrecioporunidadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioporunidadDataGridViewTextBoxColumn.Name = "PrecioporunidadDataGridViewTextBoxColumn"
        '
        'PreciototalDataGridViewTextBoxColumn
        '
        Me.PreciototalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PreciototalDataGridViewTextBoxColumn.DataPropertyName = "precio_total"
        Me.PreciototalDataGridViewTextBoxColumn.HeaderText = "precio_total"
        Me.PreciototalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PreciototalDataGridViewTextBoxColumn.Name = "PreciototalDataGridViewTextBoxColumn"
        '
        'IdpedidoDataGridViewTextBoxColumn
        '
        Me.IdpedidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdpedidoDataGridViewTextBoxColumn.DataPropertyName = "id_pedido"
        Me.IdpedidoDataGridViewTextBoxColumn.HeaderText = "id_pedido"
        Me.IdpedidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdpedidoDataGridViewTextBoxColumn.Name = "IdpedidoDataGridViewTextBoxColumn"
        '
        'Materiales_por_pedidoTableAdapter
        '
        Me.Materiales_por_pedidoTableAdapter.ClearBeforeFill = True
        '
        'Frm_Materiales_Por_Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 633)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Frm_Materiales_Por_Pedido"
        Me.Text = "Frm_Materiales_Por_Pedidovb"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.MaterialesporpedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
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
    Friend WithEvents MaterialesporpedidoBindingSource As BindingSource
    Friend WithEvents MAPADataSet As MAPADataSet
    Friend WithEvents Materiales_por_pedidoTableAdapter As MAPADataSetTableAdapters.materiales_por_pedidoTableAdapter
    Friend WithEvents lbl_id_pedido As Label
    Friend WithEvents lbl_id_material As Label
    Friend WithEvents IdmaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombrematerialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidaddemedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioporunidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciototalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdpedidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
