<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Proveedores
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
        Me.ProveedoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bt_refrescar = New System.Windows.Forms.Button()
        Me.Textbox_catalogo = New System.Windows.Forms.RichTextBox()
        Me.ProveedoresBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAPADataSet = New MAPA_Visual_Basic_2.MAPADataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Textbox_direccion = New System.Windows.Forms.RichTextBox()
        Me.Textbox_telefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Textbox_ruc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Textbox_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt_vaciar = New System.Windows.Forms.Button()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.bt_editar = New System.Windows.Forms.Button()
        Me.Textbox_id = New System.Windows.Forms.TextBox()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textbox_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_Proveedor = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdproveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatalogoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RucDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProveedoresTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.proveedoresTableAdapter()
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Proveedor.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProveedoresBindingSource1
        '
        Me.ProveedoresBindingSource1.DataMember = "proveedores"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Inter Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(9, 2)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 40)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Proveedores"
        '
        'bt_refrescar
        '
        Me.bt_refrescar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_refrescar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.bt_refrescar.Location = New System.Drawing.Point(802, 294)
        Me.bt_refrescar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_refrescar.Name = "bt_refrescar"
        Me.bt_refrescar.Size = New System.Drawing.Size(207, 36)
        Me.bt_refrescar.TabIndex = 48
        Me.bt_refrescar.Text = "Refrescar tabla"
        Me.bt_refrescar.UseVisualStyleBackColor = True
        '
        'Textbox_catalogo
        '
        Me.Textbox_catalogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textbox_catalogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textbox_catalogo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource2, "catalogo", True))
        Me.Textbox_catalogo.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.Textbox_catalogo.Location = New System.Drawing.Point(135, 279)
        Me.Textbox_catalogo.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox_catalogo.Name = "Textbox_catalogo"
        Me.Textbox_catalogo.Size = New System.Drawing.Size(646, 62)
        Me.Textbox_catalogo.TabIndex = 45
        Me.Textbox_catalogo.Text = ""
        '
        'ProveedoresBindingSource2
        '
        Me.ProveedoresBindingSource2.DataMember = "proveedores"
        Me.ProveedoresBindingSource2.DataSource = Me.MAPADataSet
        '
        'MAPADataSet
        '
        Me.MAPADataSet.DataSetName = "MAPADataSet"
        Me.MAPADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label6.Location = New System.Drawing.Point(3, 279)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Catalogo:"
        '
        'Textbox_direccion
        '
        Me.Textbox_direccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textbox_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textbox_direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource2, "direccion", True))
        Me.Textbox_direccion.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.Textbox_direccion.Location = New System.Drawing.Point(135, 209)
        Me.Textbox_direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox_direccion.Name = "Textbox_direccion"
        Me.Textbox_direccion.Size = New System.Drawing.Size(646, 62)
        Me.Textbox_direccion.TabIndex = 43
        Me.Textbox_direccion.Text = ""
        '
        'Textbox_telefono
        '
        Me.Textbox_telefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textbox_telefono.BackColor = System.Drawing.Color.White
        Me.Textbox_telefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource2, "telefono", True))
        Me.Textbox_telefono.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.Textbox_telefono.Location = New System.Drawing.Point(137, 126)
        Me.Textbox_telefono.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox_telefono.Name = "Textbox_telefono"
        Me.Textbox_telefono.Size = New System.Drawing.Size(417, 24)
        Me.Textbox_telefono.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label7.Location = New System.Drawing.Point(5, 126)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Telefono:"
        '
        'Textbox_ruc
        '
        Me.Textbox_ruc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textbox_ruc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource2, "ruc", True))
        Me.Textbox_ruc.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.Textbox_ruc.Location = New System.Drawing.Point(136, 165)
        Me.Textbox_ruc.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox_ruc.Name = "Textbox_ruc"
        Me.Textbox_ruc.Size = New System.Drawing.Size(417, 24)
        Me.Textbox_ruc.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label8.Location = New System.Drawing.Point(4, 165)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "RUC:"
        '
        'Textbox_email
        '
        Me.Textbox_email.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textbox_email.BackColor = System.Drawing.Color.White
        Me.Textbox_email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource2, "email", True))
        Me.Textbox_email.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.Textbox_email.Location = New System.Drawing.Point(137, 90)
        Me.Textbox_email.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox_email.Name = "Textbox_email"
        Me.Textbox_email.Size = New System.Drawing.Size(417, 24)
        Me.Textbox_email.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label3.Location = New System.Drawing.Point(5, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label5.Location = New System.Drawing.Point(3, 209)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Dirección:"
        '
        'bt_vaciar
        '
        Me.bt_vaciar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_vaciar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.bt_vaciar.Location = New System.Drawing.Point(802, 250)
        Me.bt_vaciar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_vaciar.Name = "bt_vaciar"
        Me.bt_vaciar.Size = New System.Drawing.Size(207, 36)
        Me.bt_vaciar.TabIndex = 34
        Me.bt_vaciar.Text = "Vaciar"
        Me.bt_vaciar.UseVisualStyleBackColor = True
        '
        'bt_guardar
        '
        Me.bt_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_guardar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.bt_guardar.Location = New System.Drawing.Point(802, 114)
        Me.bt_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(207, 36)
        Me.bt_guardar.TabIndex = 31
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'bt_editar
        '
        Me.bt_editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_editar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.bt_editar.Location = New System.Drawing.Point(802, 202)
        Me.bt_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_editar.Name = "bt_editar"
        Me.bt_editar.Size = New System.Drawing.Size(207, 36)
        Me.bt_editar.TabIndex = 33
        Me.bt_editar.Text = "Editar"
        Me.bt_editar.UseVisualStyleBackColor = True
        '
        'Textbox_id
        '
        Me.Textbox_id.BackColor = System.Drawing.Color.White
        Me.Textbox_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource2, "id_proveedor", True))
        Me.Textbox_id.Enabled = False
        Me.Textbox_id.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.Textbox_id.Location = New System.Drawing.Point(136, 6)
        Me.Textbox_id.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox_id.Name = "Textbox_id"
        Me.Textbox_id.ReadOnly = True
        Me.Textbox_id.Size = New System.Drawing.Size(93, 24)
        Me.Textbox_id.TabIndex = 27
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_eliminar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.bt_eliminar.Location = New System.Drawing.Point(802, 158)
        Me.bt_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(207, 36)
        Me.bt_eliminar.TabIndex = 32
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ID:"
        '
        'Textbox_nombre
        '
        Me.Textbox_nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textbox_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource2, "nombre", True))
        Me.Textbox_nombre.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.Textbox_nombre.Location = New System.Drawing.Point(137, 49)
        Me.Textbox_nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox_nombre.Name = "Textbox_nombre"
        Me.Textbox_nombre.Size = New System.Drawing.Size(417, 24)
        Me.Textbox_nombre.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label2.Location = New System.Drawing.Point(5, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Nombre:"
        '
        'Panel_Proveedor
        '
        Me.Panel_Proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Proveedor.Controls.Add(Me.DataGridView1)
        Me.Panel_Proveedor.Controls.Add(Me.Panel2)
        Me.Panel_Proveedor.Controls.Add(Me.Label4)
        Me.Panel_Proveedor.Location = New System.Drawing.Point(0, -1)
        Me.Panel_Proveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_Proveedor.Name = "Panel_Proveedor"
        Me.Panel_Proveedor.Size = New System.Drawing.Size(1045, 693)
        Me.Panel_Proveedor.TabIndex = 29
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproveedorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CatalogoDataGridViewTextBoxColumn, Me.RucDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProveedoresBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(16, 441)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1013, 235)
        Me.DataGridView1.TabIndex = 29
        '
        'IdproveedorDataGridViewTextBoxColumn
        '
        Me.IdproveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdproveedorDataGridViewTextBoxColumn.DataPropertyName = "id_proveedor"
        Me.IdproveedorDataGridViewTextBoxColumn.HeaderText = "id_proveedor"
        Me.IdproveedorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdproveedorDataGridViewTextBoxColumn.Name = "IdproveedorDataGridViewTextBoxColumn"
        Me.IdproveedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'CatalogoDataGridViewTextBoxColumn
        '
        Me.CatalogoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CatalogoDataGridViewTextBoxColumn.DataPropertyName = "catalogo"
        Me.CatalogoDataGridViewTextBoxColumn.HeaderText = "catalogo"
        Me.CatalogoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CatalogoDataGridViewTextBoxColumn.Name = "CatalogoDataGridViewTextBoxColumn"
        '
        'RucDataGridViewTextBoxColumn
        '
        Me.RucDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RucDataGridViewTextBoxColumn.DataPropertyName = "ruc"
        Me.RucDataGridViewTextBoxColumn.HeaderText = "ruc"
        Me.RucDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RucDataGridViewTextBoxColumn.Name = "RucDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.bt_refrescar)
        Me.Panel2.Controls.Add(Me.Textbox_catalogo)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Textbox_direccion)
        Me.Panel2.Controls.Add(Me.Textbox_telefono)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Textbox_ruc)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Textbox_email)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.bt_vaciar)
        Me.Panel2.Controls.Add(Me.bt_guardar)
        Me.Panel2.Controls.Add(Me.bt_editar)
        Me.Panel2.Controls.Add(Me.Textbox_id)
        Me.Panel2.Controls.Add(Me.bt_eliminar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Textbox_nombre)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(16, 46)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1013, 347)
        Me.Panel2.TabIndex = 28
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'Frm_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 690)
        Me.Controls.Add(Me.Panel_Proveedor)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Proveedores"
        Me.Text = "Form3"
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Proveedor.ResumeLayout(False)
        Me.Panel_Proveedor.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProveedoresBindingSource1 As BindingSource
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents Label4 As Label
    Friend WithEvents bt_refrescar As Button
    Friend WithEvents Textbox_catalogo As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Textbox_direccion As RichTextBox
    Friend WithEvents Textbox_telefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Textbox_ruc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Textbox_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bt_vaciar As Button
    Friend WithEvents bt_guardar As Button
    Friend WithEvents bt_editar As Button
    Friend WithEvents Textbox_id As TextBox
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Textbox_nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_Proveedor As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MAPADataSet As MAPADataSet
    Friend WithEvents ProveedoresBindingSource2 As BindingSource
    Friend WithEvents ProveedoresTableAdapter As MAPADataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents IdproveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CatalogoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RucDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
