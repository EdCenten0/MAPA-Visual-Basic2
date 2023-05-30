<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Materiales_Por_Proveedor
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_vaciar_campos = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MaterialesporproveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAPADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAPADataSet = New MAPA_Visual_Basic_2.MAPADataSet()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdproveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdmaterialesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrematerialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad_de_medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_por_unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatalogoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RucDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Materiales_por_proveedorTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.materiales_por_proveedorTableAdapter()
        Me.ProveedoresTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.proveedoresTableAdapter()
        Me.Materiales_por_pedidoTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.materiales_por_pedidoTableAdapter()
        Me.MaterialesporproveedorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.MaterialesporproveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPADataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesporproveedorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 40)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Materiales Por Proveedor"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btn_vaciar_campos)
        Me.Panel1.Controls.Add(Me.btn_eliminar)
        Me.Panel1.Controls.Add(Me.btn_editar)
        Me.Panel1.Controls.Add(Me.btn_guardar)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_material)
        Me.Panel1.Location = New System.Drawing.Point(12, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1120, 204)
        Me.Panel1.TabIndex = 31
        '
        'btn_vaciar_campos
        '
        Me.btn_vaciar_campos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_vaciar_campos.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.btn_vaciar_campos.Location = New System.Drawing.Point(956, 145)
        Me.btn_vaciar_campos.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_vaciar_campos.Name = "btn_vaciar_campos"
        Me.btn_vaciar_campos.Size = New System.Drawing.Size(160, 36)
        Me.btn_vaciar_campos.TabIndex = 35
        Me.btn_vaciar_campos.Text = "Vaciar Campos"
        Me.btn_vaciar_campos.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.btn_eliminar.Location = New System.Drawing.Point(956, 101)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(160, 36)
        Me.btn_eliminar.TabIndex = 34
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_editar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.btn_editar.Location = New System.Drawing.Point(956, 57)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(160, 36)
        Me.btn_editar.TabIndex = 33
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.btn_guardar.Location = New System.Drawing.Point(956, 8)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(160, 36)
        Me.btn_guardar.TabIndex = 32
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label6.Location = New System.Drawing.Point(534, 73)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label5.Location = New System.Drawing.Point(534, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 8
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MaterialesporproveedorBindingSource, "id_materiales_por_proveedor", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(118, 15)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(256, 24)
        Me.ComboBox2.TabIndex = 7
        '
        'MaterialesporproveedorBindingSource
        '
        Me.MaterialesporproveedorBindingSource.DataMember = "materiales_por_proveedor"
        Me.MaterialesporproveedorBindingSource.DataSource = Me.MAPADataSetBindingSource
        '
        'MAPADataSetBindingSource
        '
        Me.MAPADataSetBindingSource.DataSource = Me.MAPADataSet
        Me.MAPADataSetBindingSource.Position = 0
        '
        'MAPADataSet
        '
        Me.MAPADataSet.DataSetName = "MAPADataSet"
        Me.MAPADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MaterialesporproveedorBindingSource, "id_materiales_por_proveedor", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(118, 73)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(256, 24)
        Me.ComboBox1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label4.Location = New System.Drawing.Point(406, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ID Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label3.Location = New System.Drawing.Point(406, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID Material:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label2.Location = New System.Drawing.Point(4, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Proveedor:"
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.lbl_material.Location = New System.Drawing.Point(4, 15)
        Me.lbl_material.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(79, 20)
        Me.lbl_material.TabIndex = 2
        Me.lbl_material.Text = "Material:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproveedorDataGridViewTextBoxColumn, Me.IdmaterialesDataGridViewTextBoxColumn, Me.NombrematerialDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.unidad_de_medida, Me.precio_por_unidad, Me.NombreDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CatalogoDataGridViewTextBoxColumn, Me.RucDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MaterialesporproveedorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 297)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1120, 313)
        Me.DataGridView1.TabIndex = 32
        '
        'IdproveedorDataGridViewTextBoxColumn
        '
        Me.IdproveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdproveedorDataGridViewTextBoxColumn.DataPropertyName = "id_proveedor"
        Me.IdproveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor ID"
        Me.IdproveedorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdproveedorDataGridViewTextBoxColumn.Name = "IdproveedorDataGridViewTextBoxColumn"
        '
        'IdmaterialesDataGridViewTextBoxColumn
        '
        Me.IdmaterialesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdmaterialesDataGridViewTextBoxColumn.DataPropertyName = "id_materiales"
        Me.IdmaterialesDataGridViewTextBoxColumn.HeaderText = "Materiales ID"
        Me.IdmaterialesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdmaterialesDataGridViewTextBoxColumn.Name = "IdmaterialesDataGridViewTextBoxColumn"
        '
        'NombrematerialDataGridViewTextBoxColumn
        '
        Me.NombrematerialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombrematerialDataGridViewTextBoxColumn.DataPropertyName = "nombre_material"
        Me.NombrematerialDataGridViewTextBoxColumn.HeaderText = "Material"
        Me.NombrematerialDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombrematerialDataGridViewTextBoxColumn.Name = "NombrematerialDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'unidad_de_medida
        '
        Me.unidad_de_medida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.unidad_de_medida.DataPropertyName = "unidad_de_medida"
        Me.unidad_de_medida.HeaderText = "Unidad de Medida"
        Me.unidad_de_medida.MinimumWidth = 6
        Me.unidad_de_medida.Name = "unidad_de_medida"
        '
        'precio_por_unidad
        '
        Me.precio_por_unidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.precio_por_unidad.DataPropertyName = "precio_por_unidad"
        Me.precio_por_unidad.HeaderText = "Precio por Unidad"
        Me.precio_por_unidad.MinimumWidth = 6
        Me.precio_por_unidad.Name = "precio_por_unidad"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'CatalogoDataGridViewTextBoxColumn
        '
        Me.CatalogoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CatalogoDataGridViewTextBoxColumn.DataPropertyName = "catalogo"
        Me.CatalogoDataGridViewTextBoxColumn.HeaderText = "Catálogo"
        Me.CatalogoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CatalogoDataGridViewTextBoxColumn.Name = "CatalogoDataGridViewTextBoxColumn"
        '
        'RucDataGridViewTextBoxColumn
        '
        Me.RucDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RucDataGridViewTextBoxColumn.DataPropertyName = "ruc"
        Me.RucDataGridViewTextBoxColumn.HeaderText = "RUC"
        Me.RucDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RucDataGridViewTextBoxColumn.Name = "RucDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'Materiales_por_proveedorTableAdapter
        '
        Me.Materiales_por_proveedorTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'Materiales_por_pedidoTableAdapter
        '
        Me.Materiales_por_pedidoTableAdapter.ClearBeforeFill = True
        '
        'MaterialesporproveedorBindingSource1
        '
        Me.MaterialesporproveedorBindingSource1.DataMember = "materiales_por_proveedor"
        Me.MaterialesporproveedorBindingSource1.DataSource = Me.MAPADataSet
        '
        'Frm_Materiales_Por_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 633)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_Materiales_Por_Proveedor"
        Me.Text = "Frm_Materiales_Por_Proveedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MaterialesporproveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPADataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesporproveedorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_material As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_vaciar_campos As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MAPADataSetBindingSource As BindingSource
    Friend WithEvents MAPADataSet As MAPADataSet
    Friend WithEvents MaterialesporproveedorBindingSource As BindingSource
    Friend WithEvents Materiales_por_proveedorTableAdapter As MAPADataSetTableAdapters.materiales_por_proveedorTableAdapter
    Friend WithEvents IdproveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdmaterialesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombrematerialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents unidad_de_medida As DataGridViewTextBoxColumn
    Friend WithEvents precio_por_unidad As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CatalogoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RucDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProveedoresTableAdapter As MAPADataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents Materiales_por_pedidoTableAdapter As MAPADataSetTableAdapters.materiales_por_pedidoTableAdapter
    Friend WithEvents MaterialesporproveedorBindingSource1 As BindingSource
End Class
