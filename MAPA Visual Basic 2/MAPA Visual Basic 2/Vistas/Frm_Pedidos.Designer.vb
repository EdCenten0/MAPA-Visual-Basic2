<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Pedidos
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
        Me.PedidosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_pedidos = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bt_refrescar = New System.Windows.Forms.Button()
        Me.Textbox_date = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Textbox_descripcion = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_vaciar = New System.Windows.Forms.Button()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.text_id = New System.Windows.Forms.TextBox()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bt_editar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PedidosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_pedidos = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.PedidosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PedidosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PedidosBindingSource2
        '
        Me.PedidosBindingSource2.DataMember = "pedidos"
        '
        'PedidosBindingSource1
        '
        Me.PedidosBindingSource1.DataMember = "pedidos"
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "pedidos"
        '
        'cb_pedidos
        '
        Me.cb_pedidos.FormattingEnabled = True
        Me.cb_pedidos.Location = New System.Drawing.Point(152, 46)
        Me.cb_pedidos.Name = "cb_pedidos"
        Me.cb_pedidos.Size = New System.Drawing.Size(224, 21)
        Me.cb_pedidos.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(3, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 20)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "ID:"
        '
        'bt_refrescar
        '
        Me.bt_refrescar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_refrescar.Location = New System.Drawing.Point(630, 185)
        Me.bt_refrescar.Name = "bt_refrescar"
        Me.bt_refrescar.Size = New System.Drawing.Size(130, 29)
        Me.bt_refrescar.TabIndex = 47
        Me.bt_refrescar.Text = "Refrescar tabla"
        Me.bt_refrescar.UseVisualStyleBackColor = True
        '
        'Textbox_date
        '
        Me.Textbox_date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textbox_date.Location = New System.Drawing.Point(152, 83)
        Me.Textbox_date.Name = "Textbox_date"
        Me.Textbox_date.Size = New System.Drawing.Size(224, 20)
        Me.Textbox_date.TabIndex = 46
        Me.Textbox_date.Value = New Date(2023, 5, 15, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(3, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Fecha de ingreso:"
        '
        'Textbox_descripcion
        '
        Me.Textbox_descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textbox_descripcion.Location = New System.Drawing.Point(152, 128)
        Me.Textbox_descripcion.Name = "Textbox_descripcion"
        Me.Textbox_descripcion.Size = New System.Drawing.Size(458, 71)
        Me.Textbox_descripcion.TabIndex = 44
        Me.Textbox_descripcion.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(3, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Descripcion:"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        '
        'bt_vaciar
        '
        Me.bt_vaciar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_vaciar.Location = New System.Drawing.Point(630, 140)
        Me.bt_vaciar.Name = "bt_vaciar"
        Me.bt_vaciar.Size = New System.Drawing.Size(130, 29)
        Me.bt_vaciar.TabIndex = 34
        Me.bt_vaciar.Text = "Vaciar"
        Me.bt_vaciar.UseVisualStyleBackColor = True
        '
        'bt_guardar
        '
        Me.bt_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_guardar.Location = New System.Drawing.Point(630, 3)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(130, 29)
        Me.bt_guardar.TabIndex = 31
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'text_id
        '
        Me.text_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_id.BackColor = System.Drawing.Color.White
        Me.text_id.Enabled = False
        Me.text_id.Location = New System.Drawing.Point(152, 10)
        Me.text_id.Name = "text_id"
        Me.text_id.Size = New System.Drawing.Size(100, 20)
        Me.text_id.TabIndex = 27
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_eliminar.Location = New System.Drawing.Point(630, 47)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(130, 29)
        Me.bt_eliminar.TabIndex = 32
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(3, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Cliente:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 561)
        Me.Panel1.TabIndex = 32
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.cb_pedidos)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.bt_refrescar)
        Me.Panel2.Controls.Add(Me.Textbox_date)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Textbox_descripcion)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.bt_vaciar)
        Me.Panel2.Controls.Add(Me.bt_guardar)
        Me.Panel2.Controls.Add(Me.bt_editar)
        Me.Panel2.Controls.Add(Me.text_id)
        Me.Panel2.Controls.Add(Me.bt_eliminar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 217)
        Me.Panel2.TabIndex = 28
        '
        'bt_editar
        '
        Me.bt_editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_editar.Location = New System.Drawing.Point(630, 94)
        Me.bt_editar.Name = "bt_editar"
        Me.bt_editar.Size = New System.Drawing.Size(130, 29)
        Me.bt_editar.TabIndex = 33
        Me.bt_editar.Text = "Ediitar"
        Me.bt_editar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label4.Location = New System.Drawing.Point(6, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 31)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Pedidos"
        '
        'PedidosBindingSource3
        '
        Me.PedidosBindingSource3.DataMember = "pedidos"
        '
        'tb_pedidos
        '
        Me.tb_pedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tb_pedidos.Location = New System.Drawing.Point(12, 280)
        Me.tb_pedidos.Name = "tb_pedidos"
        Me.tb_pedidos.Size = New System.Drawing.Size(760, 269)
        Me.tb_pedidos.TabIndex = 33
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 280)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(760, 269)
        Me.DataGridView1.TabIndex = 32
        '
        'Frm_Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tb_pedidos)
        Me.Name = "Frm_Pedidos"
        Me.Text = "Form7"
        CType(Me.PedidosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PedidosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PedidosBindingSource2 As BindingSource
    Friend WithEvents PedidosBindingSource1 As BindingSource
    Friend WithEvents PedidosBindingSource As BindingSource
    Friend WithEvents cb_pedidos As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bt_refrescar As Button
    Friend WithEvents Textbox_date As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Textbox_descripcion As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents bt_vaciar As Button
    Friend WithEvents bt_guardar As Button
    Friend WithEvents text_id As TextBox
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bt_editar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PedidosBindingSource3 As BindingSource
    Friend WithEvents tb_pedidos As DataGridView
End Class
