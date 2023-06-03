<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Tienda
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bt_vaciar = New System.Windows.Forms.Button()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_rol = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bt_editar = New System.Windows.Forms.Button()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.TiendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAPADataSet = New MAPA_Visual_Basic_2.MAPADataSet()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TiendaTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.tiendaTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.TiendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1051, 568)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.bt_vaciar)
        Me.Panel2.Controls.Add(Me.bt_guardar)
        Me.Panel2.Controls.Add(Me.txt_id)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_rol)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(12, 309)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1026, 236)
        Me.Panel2.TabIndex = 32
        Me.Panel2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.TextBox3.Location = New System.Drawing.Point(95, 204)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(430, 24)
        Me.TextBox3.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label11.Location = New System.Drawing.Point(14, 204)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 20)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Email:"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.TextBox2.Location = New System.Drawing.Point(95, 153)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(430, 24)
        Me.TextBox2.TabIndex = 38
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.TextBox1.Location = New System.Drawing.Point(95, 105)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(430, 24)
        Me.TextBox1.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label10.Location = New System.Drawing.Point(8, 157)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 20)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Teléfono:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label9.Location = New System.Drawing.Point(8, 109)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Dirección:"
        '
        'bt_vaciar
        '
        Me.bt_vaciar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_vaciar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.bt_vaciar.Location = New System.Drawing.Point(811, 109)
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
        Me.bt_guardar.Location = New System.Drawing.Point(811, 55)
        Me.bt_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(207, 36)
        Me.bt_guardar.TabIndex = 31
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id.BackColor = System.Drawing.Color.White
        Me.txt_id.Enabled = False
        Me.txt_id.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.txt_id.Location = New System.Drawing.Point(95, 18)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id.MaximumSize = New System.Drawing.Size(106, 24)
        Me.txt_id.MinimumSize = New System.Drawing.Size(106, 24)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(106, 24)
        Me.txt_id.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label2.Location = New System.Drawing.Point(8, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "ID:"
        '
        'txt_rol
        '
        Me.txt_rol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_rol.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.txt_rol.Location = New System.Drawing.Point(95, 62)
        Me.txt_rol.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rol.Name = "txt_rol"
        Me.txt_rol.Size = New System.Drawing.Size(430, 24)
        Me.txt_rol.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label3.Location = New System.Drawing.Point(8, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Nombre:"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.bt_editar)
        Me.Panel3.Controls.Add(Me.lbl_email)
        Me.Panel3.Controls.Add(Me.lbl_telefono)
        Me.Panel3.Controls.Add(Me.lbl_direccion)
        Me.Panel3.Controls.Add(Me.lbl_nombre)
        Me.Panel3.Controls.Add(Me.lbl_id)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(12, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1026, 237)
        Me.Panel3.TabIndex = 33
        '
        'bt_editar
        '
        Me.bt_editar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.bt_editar.Location = New System.Drawing.Point(516, 53)
        Me.bt_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_editar.MaximumSize = New System.Drawing.Size(207, 36)
        Me.bt_editar.MinimumSize = New System.Drawing.Size(207, 36)
        Me.bt_editar.Name = "bt_editar"
        Me.bt_editar.Size = New System.Drawing.Size(207, 36)
        Me.bt_editar.TabIndex = 45
        Me.bt_editar.Text = "Editar"
        Me.bt_editar.UseVisualStyleBackColor = True
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiendaBindingSource, "email", True))
        Me.lbl_email.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.lbl_email.Location = New System.Drawing.Point(579, 11)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(30, 20)
        Me.lbl_email.TabIndex = 44
        Me.lbl_email.Text = "ID:"
        '
        'TiendaBindingSource
        '
        Me.TiendaBindingSource.DataMember = "tienda"
        Me.TiendaBindingSource.DataSource = Me.MAPADataSet
        '
        'MAPADataSet
        '
        Me.MAPADataSet.DataSetName = "MAPADataSet"
        Me.MAPADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiendaBindingSource, "telefono", True))
        Me.lbl_telefono.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.lbl_telefono.Location = New System.Drawing.Point(127, 140)
        Me.lbl_telefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(30, 20)
        Me.lbl_telefono.TabIndex = 43
        Me.lbl_telefono.Text = "ID:"
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiendaBindingSource, "direccion", True))
        Me.lbl_direccion.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.lbl_direccion.Location = New System.Drawing.Point(127, 96)
        Me.lbl_direccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(30, 20)
        Me.lbl_direccion.TabIndex = 42
        Me.lbl_direccion.Text = "ID:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiendaBindingSource, "nombre", True))
        Me.lbl_nombre.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.lbl_nombre.Location = New System.Drawing.Point(127, 53)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(30, 20)
        Me.lbl_nombre.TabIndex = 41
        Me.lbl_nombre.Text = "ID:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiendaBindingSource, "id_tienda", True))
        Me.lbl_id.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.lbl_id.Location = New System.Drawing.Point(127, 11)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(30, 20)
        Me.lbl_id.TabIndex = 40
        Me.lbl_id.Text = "ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label8.Location = New System.Drawing.Point(486, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label7.Location = New System.Drawing.Point(9, 140)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Teléfono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label6.Location = New System.Drawing.Point(9, 96)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label5.Location = New System.Drawing.Point(14, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label4.Location = New System.Drawing.Point(63, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 40)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Tienda"
        '
        'TiendaTableAdapter
        '
        Me.TiendaTableAdapter.ClearBeforeFill = True
        '
        'Frm_Tienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 568)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_Tienda"
        Me.Text = "Nombre:"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.TiendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents lbl_direccion As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MAPADataSet As MAPADataSet
    Friend WithEvents TiendaBindingSource As BindingSource
    Friend WithEvents TiendaTableAdapter As MAPADataSetTableAdapters.tiendaTableAdapter
    Friend WithEvents bt_editar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bt_vaciar As Button
    Friend WithEvents bt_guardar As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_rol As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
