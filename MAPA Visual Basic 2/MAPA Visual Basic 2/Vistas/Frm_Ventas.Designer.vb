<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ventas
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.RichTextBox8 = New System.Windows.Forms.RichTextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.IDFVenta = New System.Windows.Forms.RichTextBox()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAPADataSet = New MAPA_Visual_Basic_2.MAPADataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDTVenta = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IDVenta = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CantidadVenta = New System.Windows.Forms.RichTextBox()
        Me.DescripcionVenta = New System.Windows.Forms.RichTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdventaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtiendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdfacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.ventasTableAdapter()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(813, 332)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(134, 36)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Refrescar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'RichTextBox8
        '
        Me.RichTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox8.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.RichTextBox8.Location = New System.Drawing.Point(148, 288)
        Me.RichTextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox8.Name = "RichTextBox8"
        Me.RichTextBox8.Size = New System.Drawing.Size(351, 24)
        Me.RichTextBox8.TabIndex = 9
        Me.RichTextBox8.Text = ""
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(329, 336)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(169, 36)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'IDFVenta
        '
        Me.IDFVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "id_factura", True))
        Me.IDFVenta.Enabled = False
        Me.IDFVenta.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.IDFVenta.Location = New System.Drawing.Point(357, 227)
        Me.IDFVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.IDFVenta.Name = "IDFVenta"
        Me.IDFVenta.Size = New System.Drawing.Size(93, 24)
        Me.IDFVenta.TabIndex = 4
        Me.IDFVenta.Text = ""
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        Me.VentasBindingSource.DataSource = Me.MAPADataSet
        '
        'MAPADataSet
        '
        Me.MAPADataSet.DataSetName = "MAPADataSet"
        Me.MAPADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label1.Location = New System.Drawing.Point(244, 227)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Factura ID:"
        '
        'IDTVenta
        '
        Me.IDTVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "id_tienda", True))
        Me.IDTVenta.Enabled = False
        Me.IDTVenta.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.IDTVenta.Location = New System.Drawing.Point(148, 227)
        Me.IDTVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTVenta.Name = "IDTVenta"
        Me.IDTVenta.Size = New System.Drawing.Size(88, 24)
        Me.IDTVenta.TabIndex = 3
        Me.IDTVenta.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label6.Location = New System.Drawing.Point(33, 227)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Tienda ID:"
        '
        'IDVenta
        '
        Me.IDVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "id_venta", True))
        Me.IDVenta.Enabled = False
        Me.IDVenta.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.IDVenta.Location = New System.Drawing.Point(148, 75)
        Me.IDVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.IDVenta.Name = "IDVenta"
        Me.IDVenta.ShortcutsEnabled = False
        Me.IDVenta.Size = New System.Drawing.Size(105, 24)
        Me.IDVenta.TabIndex = 85
        Me.IDVenta.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label7.Location = New System.Drawing.Point(30, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Venta ID:"
        '
        'CantidadVenta
        '
        Me.CantidadVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "cantidad", True))
        Me.CantidadVenta.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.CantidadVenta.Location = New System.Drawing.Point(148, 114)
        Me.CantidadVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.CantidadVenta.Name = "CantidadVenta"
        Me.CantidadVenta.Size = New System.Drawing.Size(302, 24)
        Me.CantidadVenta.TabIndex = 1
        Me.CantidadVenta.Text = ""
        '
        'DescripcionVenta
        '
        Me.DescripcionVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "descripcion", True))
        Me.DescripcionVenta.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.DescripcionVenta.Location = New System.Drawing.Point(148, 160)
        Me.DescripcionVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.DescripcionVenta.Name = "DescripcionVenta"
        Me.DescripcionVenta.Size = New System.Drawing.Size(302, 51)
        Me.DescripcionVenta.TabIndex = 2
        Me.DescripcionVenta.Text = ""
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(715, 270)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(169, 36)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Vaciar Campos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(715, 226)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 36)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(715, 182)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 36)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(715, 138)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 36)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label3.Location = New System.Drawing.Point(30, 160)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label2.Location = New System.Drawing.Point(30, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Cantidad:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdventaDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.IdtiendaDataGridViewTextBoxColumn, Me.IdfacturaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VentasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 380)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1028, 293)
        Me.DataGridView1.TabIndex = 75
        '
        'IdventaDataGridViewTextBoxColumn
        '
        Me.IdventaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdventaDataGridViewTextBoxColumn.DataPropertyName = "id_venta"
        Me.IdventaDataGridViewTextBoxColumn.HeaderText = "Venta ID"
        Me.IdventaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdventaDataGridViewTextBoxColumn.Name = "IdventaDataGridViewTextBoxColumn"
        Me.IdventaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
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
        'IdfacturaDataGridViewTextBoxColumn
        '
        Me.IdfacturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdfacturaDataGridViewTextBoxColumn.DataPropertyName = "id_factura"
        Me.IdfacturaDataGridViewTextBoxColumn.HeaderText = "Factura ID"
        Me.IdfacturaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdfacturaDataGridViewTextBoxColumn.Name = "IdfacturaDataGridViewTextBoxColumn"
        Me.IdfacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.btn_guardar.Location = New System.Drawing.Point(671, 332)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(134, 36)
        Me.btn_guardar.TabIndex = 11
        Me.btn_guardar.Text = "Reporte"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label4.Location = New System.Drawing.Point(33, 292)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Buscar:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Inter Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(13, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 40)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Ventas"
        '
        'Frm_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 690)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.RichTextBox8)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.IDFVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IDTVenta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.IDVenta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CantidadVenta)
        Me.Controls.Add(Me.DescripcionVenta)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Ventas"
        Me.Text = "Ventas"
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents RichTextBox8 As RichTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents IDFVenta As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IDTVenta As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents IDVenta As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CantidadVenta As RichTextBox
    Friend WithEvents DescripcionVenta As RichTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MAPADataSet As MAPADataSet
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As MAPADataSetTableAdapters.ventasTableAdapter
    Friend WithEvents btn_guardar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents IdventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdtiendaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdfacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
