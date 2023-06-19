<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Clientes
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdclienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtiendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAPADataSet = New MAPA_Visual_Basic_2.MAPADataSet()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IDCliente = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NombreCliente = New System.Windows.Forms.RichTextBox()
        Me.CedulaCliente = New System.Windows.Forms.RichTextBox()
        Me.TelefonoCliente = New System.Windows.Forms.RichTextBox()
        Me.EmailCliente = New System.Windows.Forms.RichTextBox()
        Me.ApellidoCliente = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Busqueda = New System.Windows.Forms.RichTextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.clientesTableAdapter()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IDTCliente = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdclienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.IdtiendaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 421)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1017, 255)
        Me.DataGridView1.TabIndex = 72
        '
        'IdclienteDataGridViewTextBoxColumn
        '
        Me.IdclienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente"
        Me.IdclienteDataGridViewTextBoxColumn.HeaderText = "Cliente ID"
        Me.IdclienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdclienteDataGridViewTextBoxColumn.Name = "IdclienteDataGridViewTextBoxColumn"
        Me.IdclienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cédula"
        Me.CedulaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdtiendaDataGridViewTextBoxColumn
        '
        Me.IdtiendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdtiendaDataGridViewTextBoxColumn.DataPropertyName = "id_tienda"
        Me.IdtiendaDataGridViewTextBoxColumn.HeaderText = "Tienda ID"
        Me.IdtiendaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdtiendaDataGridViewTextBoxColumn.Name = "IdtiendaDataGridViewTextBoxColumn"
        Me.IdtiendaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.MAPADataSet
        '
        'MAPADataSet
        '
        Me.MAPADataSet.DataSetName = "MAPADataSet"
        Me.MAPADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.Button4.Location = New System.Drawing.Point(755, 274)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(207, 36)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Vaciar Campos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.Button3.Location = New System.Drawing.Point(755, 230)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(207, 36)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.Button2.Location = New System.Drawing.Point(755, 186)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 36)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.Button1.Location = New System.Drawing.Point(755, 142)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IDCliente
        '
        Me.IDCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "id_cliente", True))
        Me.IDCliente.Enabled = False
        Me.IDCliente.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.IDCliente.Location = New System.Drawing.Point(114, 112)
        Me.IDCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.IDCliente.Name = "IDCliente"
        Me.IDCliente.ShortcutsEnabled = False
        Me.IDCliente.Size = New System.Drawing.Size(76, 24)
        Me.IDCliente.TabIndex = 99
        Me.IDCliente.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label7.Location = New System.Drawing.Point(17, 117)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 20)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Cliente ID:"
        '
        'NombreCliente
        '
        Me.NombreCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.NombreCliente.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.NombreCliente.Location = New System.Drawing.Point(113, 162)
        Me.NombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.Size = New System.Drawing.Size(214, 24)
        Me.NombreCliente.TabIndex = 1
        Me.NombreCliente.Text = ""
        '
        'CedulaCliente
        '
        Me.CedulaCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cedula", True))
        Me.CedulaCliente.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.CedulaCliente.Location = New System.Drawing.Point(114, 202)
        Me.CedulaCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.CedulaCliente.Name = "CedulaCliente"
        Me.CedulaCliente.Size = New System.Drawing.Size(213, 24)
        Me.CedulaCliente.TabIndex = 3
        Me.CedulaCliente.Text = ""
        '
        'TelefonoCliente
        '
        Me.TelefonoCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "telefono", True))
        Me.TelefonoCliente.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.TelefonoCliente.Location = New System.Drawing.Point(113, 248)
        Me.TelefonoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TelefonoCliente.Name = "TelefonoCliente"
        Me.TelefonoCliente.Size = New System.Drawing.Size(214, 24)
        Me.TelefonoCliente.TabIndex = 5
        Me.TelefonoCliente.Text = ""
        '
        'EmailCliente
        '
        Me.EmailCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "email", True))
        Me.EmailCliente.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.EmailCliente.Location = New System.Drawing.Point(465, 207)
        Me.EmailCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailCliente.Name = "EmailCliente"
        Me.EmailCliente.Size = New System.Drawing.Size(213, 24)
        Me.EmailCliente.TabIndex = 4
        Me.EmailCliente.Text = ""
        '
        'ApellidoCliente
        '
        Me.ApellidoCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "apellido", True))
        Me.ApellidoCliente.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.ApellidoCliente.Location = New System.Drawing.Point(465, 162)
        Me.ApellidoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.ApellidoCliente.Name = "ApellidoCliente"
        Me.ApellidoCliente.Size = New System.Drawing.Size(214, 24)
        Me.ApellidoCliente.TabIndex = 2
        Me.ApellidoCliente.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label4.Location = New System.Drawing.Point(378, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label5.Location = New System.Drawing.Point(17, 248)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Teléfono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label3.Location = New System.Drawing.Point(378, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label2.Location = New System.Drawing.Point(16, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label1.Location = New System.Drawing.Point(17, 207)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Cédula:"
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(880, 375)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 36)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Refrescar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Busqueda
        '
        Me.Busqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Busqueda.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.Busqueda.Location = New System.Drawing.Point(114, 383)
        Me.Busqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(437, 24)
        Me.Busqueda.TabIndex = 11
        Me.Busqueda.Text = ""
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(736, 375)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 36)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label8.Location = New System.Drawing.Point(15, 382)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Buscar:"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.Button7.Location = New System.Drawing.Point(755, 318)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(207, 36)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Reporte"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label6.Location = New System.Drawing.Point(17, 297)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Tienda ID:"
        '
        'IDTCliente
        '
        Me.IDTCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "id_tienda", True))
        Me.IDTCliente.Enabled = False
        Me.IDTCliente.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.IDTCliente.Location = New System.Drawing.Point(114, 297)
        Me.IDTCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTCliente.Name = "IDTCliente"
        Me.IDTCliente.Size = New System.Drawing.Size(76, 24)
        Me.IDTCliente.TabIndex = 101
        Me.IDTCliente.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Inter Medium", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 40)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Clientes"
        '
        'Frm_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 690)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Busqueda)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.IDTCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.IDCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NombreCliente)
        Me.Controls.Add(Me.CedulaCliente)
        Me.Controls.Add(Me.TelefonoCliente)
        Me.Controls.Add(Me.EmailCliente)
        Me.Controls.Add(Me.ApellidoCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Clientes"
        Me.Text = "Cliente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MAPADataSet As MAPADataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As MAPADataSetTableAdapters.clientesTableAdapter
    Friend WithEvents IDCliente As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NombreCliente As RichTextBox
    Friend WithEvents CedulaCliente As RichTextBox
    Friend WithEvents TelefonoCliente As RichTextBox
    Friend WithEvents EmailCliente As RichTextBox
    Friend WithEvents ApellidoCliente As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Busqueda As RichTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents IDTCliente As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents IdclienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdtiendaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
