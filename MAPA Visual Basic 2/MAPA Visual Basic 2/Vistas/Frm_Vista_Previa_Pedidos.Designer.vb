﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Vista_Previa_Pedidos
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
        Me.bt_imprimir_informe = New System.Windows.Forms.Button()
        Me.bt_finalizar_pedido = New System.Windows.Forms.Button()
        Me.tb_fecha = New System.Windows.Forms.TextBox()
        Me.tb_pedido = New System.Windows.Forms.TextBox()
        Me.bt_agregar_materiales = New System.Windows.Forms.Button()
        Me.lb_materiales_agregados = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cb_seleccion_pedido = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_index = New System.Windows.Forms.TextBox()
        Me.tb_cliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MAPADataSet = New MAPA_Visual_Basic_2.MAPADataSet()
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.pedidosTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_imprimir_informe
        '
        Me.bt_imprimir_informe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_imprimir_informe.Font = New System.Drawing.Font("Inter", 9.0!)
        Me.bt_imprimir_informe.Location = New System.Drawing.Point(741, 415)
        Me.bt_imprimir_informe.Name = "bt_imprimir_informe"
        Me.bt_imprimir_informe.Size = New System.Drawing.Size(136, 39)
        Me.bt_imprimir_informe.TabIndex = 28
        Me.bt_imprimir_informe.Text = "Imprimir informe"
        Me.bt_imprimir_informe.UseVisualStyleBackColor = True
        '
        'bt_finalizar_pedido
        '
        Me.bt_finalizar_pedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_finalizar_pedido.Font = New System.Drawing.Font("Inter", 9.0!)
        Me.bt_finalizar_pedido.Location = New System.Drawing.Point(588, 416)
        Me.bt_finalizar_pedido.Name = "bt_finalizar_pedido"
        Me.bt_finalizar_pedido.Size = New System.Drawing.Size(147, 39)
        Me.bt_finalizar_pedido.TabIndex = 27
        Me.bt_finalizar_pedido.Text = "Finalizar pedido"
        Me.bt_finalizar_pedido.UseVisualStyleBackColor = True
        '
        'tb_fecha
        '
        Me.tb_fecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "fecha_pedido", True))
        Me.tb_fecha.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.tb_fecha.Location = New System.Drawing.Point(455, 288)
        Me.tb_fecha.Name = "tb_fecha"
        Me.tb_fecha.Size = New System.Drawing.Size(567, 28)
        Me.tb_fecha.TabIndex = 26
        '
        'tb_pedido
        '
        Me.tb_pedido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "descripcion", True))
        Me.tb_pedido.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.tb_pedido.Location = New System.Drawing.Point(455, 119)
        Me.tb_pedido.Multiline = True
        Me.tb_pedido.Name = "tb_pedido"
        Me.tb_pedido.Size = New System.Drawing.Size(567, 119)
        Me.tb_pedido.TabIndex = 25
        '
        'bt_agregar_materiales
        '
        Me.bt_agregar_materiales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_agregar_materiales.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.bt_agregar_materiales.Location = New System.Drawing.Point(363, 415)
        Me.bt_agregar_materiales.Name = "bt_agregar_materiales"
        Me.bt_agregar_materiales.Size = New System.Drawing.Size(216, 39)
        Me.bt_agregar_materiales.TabIndex = 23
        Me.bt_agregar_materiales.Text = "Agregar materiales al pedido"
        Me.bt_agregar_materiales.UseVisualStyleBackColor = True
        '
        'lb_materiales_agregados
        '
        Me.lb_materiales_agregados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_materiales_agregados.AutoSize = True
        Me.lb_materiales_agregados.Cursor = System.Windows.Forms.Cursors.Default
        Me.lb_materiales_agregados.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.lb_materiales_agregados.Location = New System.Drawing.Point(372, 457)
        Me.lb_materiales_agregados.Name = "lb_materiales_agregados"
        Me.lb_materiales_agregados.Size = New System.Drawing.Size(162, 17)
        Me.lb_materiales_agregados.TabIndex = 22
        Me.lb_materiales_agregados.Text = "Materiales agregados..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label5.Location = New System.Drawing.Point(315, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Fecha de inicio:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.cb_seleccion_pedido)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 555)
        Me.Panel1.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Inter", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(58, 495)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 39)
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
        Me.cb_seleccion_pedido.FormattingEnabled = True
        Me.cb_seleccion_pedido.Location = New System.Drawing.Point(3, 91)
        Me.cb_seleccion_pedido.Name = "cb_seleccion_pedido"
        Me.cb_seleccion_pedido.Size = New System.Drawing.Size(274, 24)
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
        Me.Label1.Location = New System.Drawing.Point(97, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pedidos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label3.Location = New System.Drawing.Point(315, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Pedido:"
        '
        'tb_index
        '
        Me.tb_index.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_index.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "id_cliente", True))
        Me.tb_index.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.tb_index.Location = New System.Drawing.Point(926, 53)
        Me.tb_index.Name = "tb_index"
        Me.tb_index.Size = New System.Drawing.Size(96, 28)
        Me.tb_index.TabIndex = 29
        '
        'tb_cliente
        '
        Me.tb_cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_cliente.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.tb_cliente.Location = New System.Drawing.Point(455, 50)
        Me.tb_cliente.Name = "tb_cliente"
        Me.tb_cliente.Size = New System.Drawing.Size(401, 28)
        Me.tb_cliente.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(316, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Cliente:"
        '
        'MAPADataSet
        '
        Me.MAPADataSet.DataSetName = "MAPADataSet"
        Me.MAPADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "pedidos"
        Me.PedidosBindingSource.DataSource = Me.MAPADataSet
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'Frm_Vista_Previa_Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 555)
        Me.Controls.Add(Me.bt_imprimir_informe)
        Me.Controls.Add(Me.bt_finalizar_pedido)
        Me.Controls.Add(Me.tb_fecha)
        Me.Controls.Add(Me.tb_pedido)
        Me.Controls.Add(Me.bt_agregar_materiales)
        Me.Controls.Add(Me.lb_materiales_agregados)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_index)
        Me.Controls.Add(Me.tb_cliente)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Frm_Vista_Previa_Pedidos"
        Me.Text = "Frm_Vista_Previa_Pedidos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_imprimir_informe As Button
    Friend WithEvents bt_finalizar_pedido As Button
    Friend WithEvents tb_fecha As TextBox
    Friend WithEvents tb_pedido As TextBox
    Friend WithEvents bt_agregar_materiales As Button
    Friend WithEvents lb_materiales_agregados As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents cb_seleccion_pedido As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_index As TextBox
    Friend WithEvents tb_cliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MAPADataSet As MAPADataSet
    Friend WithEvents PedidosBindingSource As BindingSource
    Friend WithEvents PedidosTableAdapter As MAPADataSetTableAdapters.pedidosTableAdapter
End Class
