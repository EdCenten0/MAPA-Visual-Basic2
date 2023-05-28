<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_imprimir_informe
        '
        Me.bt_imprimir_informe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_imprimir_informe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_imprimir_informe.Location = New System.Drawing.Point(556, 337)
        Me.bt_imprimir_informe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_imprimir_informe.Name = "bt_imprimir_informe"
        Me.bt_imprimir_informe.Size = New System.Drawing.Size(102, 32)
        Me.bt_imprimir_informe.TabIndex = 28
        Me.bt_imprimir_informe.Text = "Imprimir informe"
        Me.bt_imprimir_informe.UseVisualStyleBackColor = True
        '
        'bt_finalizar_pedido
        '
        Me.bt_finalizar_pedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_finalizar_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_finalizar_pedido.Location = New System.Drawing.Point(441, 338)
        Me.bt_finalizar_pedido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_finalizar_pedido.Name = "bt_finalizar_pedido"
        Me.bt_finalizar_pedido.Size = New System.Drawing.Size(110, 32)
        Me.bt_finalizar_pedido.TabIndex = 27
        Me.bt_finalizar_pedido.Text = "Finalizar pedido"
        Me.bt_finalizar_pedido.UseVisualStyleBackColor = True
        '
        'tb_fecha
        '
        Me.tb_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.tb_fecha.Location = New System.Drawing.Point(341, 234)
        Me.tb_fecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_fecha.Name = "tb_fecha"
        Me.tb_fecha.Size = New System.Drawing.Size(426, 23)
        Me.tb_fecha.TabIndex = 26
        '
        'tb_pedido
        '
        Me.tb_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.tb_pedido.Location = New System.Drawing.Point(341, 97)
        Me.tb_pedido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_pedido.Multiline = True
        Me.tb_pedido.Name = "tb_pedido"
        Me.tb_pedido.Size = New System.Drawing.Size(426, 97)
        Me.tb_pedido.TabIndex = 25
        '
        'bt_agregar_materiales
        '
        Me.bt_agregar_materiales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_agregar_materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.bt_agregar_materiales.Location = New System.Drawing.Point(272, 337)
        Me.bt_agregar_materiales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_agregar_materiales.Name = "bt_agregar_materiales"
        Me.bt_agregar_materiales.Size = New System.Drawing.Size(162, 32)
        Me.bt_agregar_materiales.TabIndex = 23
        Me.bt_agregar_materiales.Text = "Agregar materiales al pedido"
        Me.bt_agregar_materiales.UseVisualStyleBackColor = True
        '
        'lb_materiales_agregados
        '
        Me.lb_materiales_agregados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_materiales_agregados.AutoSize = True
        Me.lb_materiales_agregados.Cursor = System.Windows.Forms.Cursors.Default
        Me.lb_materiales_agregados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lb_materiales_agregados.Location = New System.Drawing.Point(279, 371)
        Me.lb_materiales_agregados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_materiales_agregados.Name = "lb_materiales_agregados"
        Me.lb_materiales_agregados.Size = New System.Drawing.Size(117, 13)
        Me.lb_materiales_agregados.TabIndex = 22
        Me.lb_materiales_agregados.Text = "Materiales agregados..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label5.Location = New System.Drawing.Point(236, 234)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 17)
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 451)
        Me.Panel1.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(44, 402)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 32)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Ver todo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cb_seleccion_pedido
        '
        Me.cb_seleccion_pedido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_seleccion_pedido.FormattingEnabled = True
        Me.cb_seleccion_pedido.Location = New System.Drawing.Point(2, 74)
        Me.cb_seleccion_pedido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cb_seleccion_pedido.Name = "cb_seleccion_pedido"
        Me.cb_seleccion_pedido.Size = New System.Drawing.Size(206, 21)
        Me.cb_seleccion_pedido.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pedidos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label3.Location = New System.Drawing.Point(236, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Pedido:"
        '
        'tb_index
        '
        Me.tb_index.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_index.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.tb_index.Location = New System.Drawing.Point(694, 43)
        Me.tb_index.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_index.Name = "tb_index"
        Me.tb_index.Size = New System.Drawing.Size(73, 23)
        Me.tb_index.TabIndex = 29
        '
        'tb_cliente
        '
        Me.tb_cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.tb_cliente.Location = New System.Drawing.Point(341, 41)
        Me.tb_cliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_cliente.Name = "tb_cliente"
        Me.tb_cliente.Size = New System.Drawing.Size(302, 23)
        Me.tb_cliente.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(237, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Cliente:"
        '
        'Frm_Vista_Previa_Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 451)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Frm_Vista_Previa_Pedidos"
        Me.Text = "Frm_Vista_Previa_Pedidos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
End Class
