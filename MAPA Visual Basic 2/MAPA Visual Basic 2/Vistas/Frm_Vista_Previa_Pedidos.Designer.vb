<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Vista_Previa_Pedidos
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
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAPADataSet = New MAPA_Visual_Basic_2.MAPADataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cb_seleccion_pedido = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PedidosTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.pedidosTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bt_imprimir_informe = New System.Windows.Forms.Button()
        Me.bt_finalizar_pedido = New System.Windows.Forms.Button()
        Me.tb_fecha = New System.Windows.Forms.TextBox()
        Me.tb_pedido = New System.Windows.Forms.TextBox()
        Me.bt_agregar_materiales = New System.Windows.Forms.Button()
        Me.lb_materiales_agregados = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_index = New System.Windows.Forms.TextBox()
        Me.tb_cliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "pedidos"
        Me.PedidosBindingSource.DataSource = Me.MAPADataSet
        '
        'MAPADataSet
        '
        Me.MAPADataSet.DataSetName = "MAPADataSet"
        Me.MAPADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.cb_seleccion_pedido)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 535)
        Me.Panel1.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Inter", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(72, 460)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 49)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Ver todo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cb_seleccion_pedido
        '
        Me.cb_seleccion_pedido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_seleccion_pedido.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PedidosBindingSource, "id_cliente", True))
        Me.cb_seleccion_pedido.DataSource = Me.PedidosBindingSource
        Me.cb_seleccion_pedido.DisplayMember = "descripcion"
        Me.cb_seleccion_pedido.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.cb_seleccion_pedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cb_seleccion_pedido.FormattingEnabled = True
        Me.cb_seleccion_pedido.Location = New System.Drawing.Point(4, 114)
        Me.cb_seleccion_pedido.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_seleccion_pedido.Name = "cb_seleccion_pedido"
        Me.cb_seleccion_pedido.Size = New System.Drawing.Size(285, 24)
        Me.cb_seleccion_pedido.TabIndex = 1
        Me.cb_seleccion_pedido.ValueMember = "id_pedido"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(121, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pedidos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.bt_imprimir_informe)
        Me.Panel2.Controls.Add(Me.bt_finalizar_pedido)
        Me.Panel2.Controls.Add(Me.tb_fecha)
        Me.Panel2.Controls.Add(Me.tb_pedido)
        Me.Panel2.Controls.Add(Me.bt_agregar_materiales)
        Me.Panel2.Controls.Add(Me.lb_materiales_agregados)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.tb_index)
        Me.Panel2.Controls.Add(Me.tb_cliente)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(293, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(679, 535)
        Me.Panel2.TabIndex = 30
        '
        'bt_imprimir_informe
        '
        Me.bt_imprimir_informe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_imprimir_informe.AutoSize = True
        Me.bt_imprimir_informe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_imprimir_informe.Font = New System.Drawing.Font("Inter", 9.0!)
        Me.bt_imprimir_informe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.bt_imprimir_informe.Location = New System.Drawing.Point(437, 421)
        Me.bt_imprimir_informe.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_imprimir_informe.Name = "bt_imprimir_informe"
        Me.bt_imprimir_informe.Size = New System.Drawing.Size(137, 36)
        Me.bt_imprimir_informe.TabIndex = 39
        Me.bt_imprimir_informe.Text = "Imprimir informe"
        Me.bt_imprimir_informe.UseVisualStyleBackColor = True
        '
        'bt_finalizar_pedido
        '
        Me.bt_finalizar_pedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_finalizar_pedido.AutoSize = True
        Me.bt_finalizar_pedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_finalizar_pedido.FlatAppearance.BorderSize = 0
        Me.bt_finalizar_pedido.Font = New System.Drawing.Font("Inter", 9.0!)
        Me.bt_finalizar_pedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.bt_finalizar_pedido.Location = New System.Drawing.Point(297, 420)
        Me.bt_finalizar_pedido.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_finalizar_pedido.Name = "bt_finalizar_pedido"
        Me.bt_finalizar_pedido.Size = New System.Drawing.Size(132, 37)
        Me.bt_finalizar_pedido.TabIndex = 38
        Me.bt_finalizar_pedido.Text = "Finalizar pedido"
        Me.bt_finalizar_pedido.UseVisualStyleBackColor = True
        '
        'tb_fecha
        '
        Me.tb_fecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "fecha_pedido", True))
        Me.tb_fecha.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.tb_fecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tb_fecha.Location = New System.Drawing.Point(219, 344)
        Me.tb_fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_fecha.Name = "tb_fecha"
        Me.tb_fecha.ReadOnly = True
        Me.tb_fecha.Size = New System.Drawing.Size(381, 24)
        Me.tb_fecha.TabIndex = 37
        '
        'tb_pedido
        '
        Me.tb_pedido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "descripcion", True))
        Me.tb_pedido.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.tb_pedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tb_pedido.Location = New System.Drawing.Point(219, 139)
        Me.tb_pedido.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pedido.Multiline = True
        Me.tb_pedido.Name = "tb_pedido"
        Me.tb_pedido.ReadOnly = True
        Me.tb_pedido.Size = New System.Drawing.Size(381, 148)
        Me.tb_pedido.TabIndex = 36
        '
        'bt_agregar_materiales
        '
        Me.bt_agregar_materiales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_agregar_materiales.AutoSize = True
        Me.bt_agregar_materiales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_agregar_materiales.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.bt_agregar_materiales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.bt_agregar_materiales.Location = New System.Drawing.Point(82, 420)
        Me.bt_agregar_materiales.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_agregar_materiales.Name = "bt_agregar_materiales"
        Me.bt_agregar_materiales.Size = New System.Drawing.Size(207, 36)
        Me.bt_agregar_materiales.TabIndex = 34
        Me.bt_agregar_materiales.Text = "Agregar materiales al pedido"
        Me.bt_agregar_materiales.UseVisualStyleBackColor = True
        '
        'lb_materiales_agregados
        '
        Me.lb_materiales_agregados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_materiales_agregados.AutoSize = True
        Me.lb_materiales_agregados.Cursor = System.Windows.Forms.Cursors.Default
        Me.lb_materiales_agregados.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.lb_materiales_agregados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lb_materiales_agregados.Location = New System.Drawing.Point(79, 464)
        Me.lb_materiales_agregados.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_materiales_agregados.Name = "lb_materiales_agregados"
        Me.lb_materiales_agregados.Size = New System.Drawing.Size(162, 17)
        Me.lb_materiales_agregados.TabIndex = 33
        Me.lb_materiales_agregados.Text = "Materiales agregados..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(78, 344)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Fecha de inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(140, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Pedido:"
        '
        'tb_index
        '
        Me.tb_index.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "id_cliente", True))
        Me.tb_index.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.tb_index.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tb_index.Location = New System.Drawing.Point(529, 53)
        Me.tb_index.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_index.Name = "tb_index"
        Me.tb_index.ReadOnly = True
        Me.tb_index.Size = New System.Drawing.Size(71, 24)
        Me.tb_index.TabIndex = 40
        '
        'tb_cliente
        '
        Me.tb_cliente.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.tb_cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tb_cliente.Location = New System.Drawing.Point(219, 53)
        Me.tb_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_cliente.Name = "tb_cliente"
        Me.tb_cliente.ReadOnly = True
        Me.tb_cliente.Size = New System.Drawing.Size(301, 24)
        Me.tb_cliente.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(140, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Cliente:"
        '
        'Frm_Vista_Previa_Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 535)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Vista_Previa_Pedidos"
        Me.Text = "Frm_Vista_Previa_Pedidos"
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents cb_seleccion_pedido As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MAPADataSet As MAPADataSet
    Friend WithEvents PedidosBindingSource As BindingSource
    Friend WithEvents PedidosTableAdapter As MAPADataSetTableAdapters.pedidosTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bt_imprimir_informe As Button
    Friend WithEvents bt_finalizar_pedido As Button
    Friend WithEvents tb_fecha As TextBox
    Friend WithEvents tb_pedido As TextBox
    Friend WithEvents bt_agregar_materiales As Button
    Friend WithEvents lb_materiales_agregados As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_index As TextBox
    Friend WithEvents tb_cliente As TextBox
    Friend WithEvents Label2 As Label
End Class
