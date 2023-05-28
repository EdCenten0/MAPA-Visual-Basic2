<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Rol
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
        Me.RolesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_refrescar = New System.Windows.Forms.Button()
        Me.bt_vaciar = New System.Windows.Forms.Button()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.bt_editar = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.RolesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAPADataSet = New MAPA_Visual_Basic_2.MAPADataSet()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_rol = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdrolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrerolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RolesTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.rolesTableAdapter()
        CType(Me.RolesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RolesBindingSource1
        '
        Me.RolesBindingSource1.DataMember = "roles"
        '
        'RolesBindingSource
        '
        Me.RolesBindingSource.DataMember = "roles"
        '
        'bt_refrescar
        '
        Me.bt_refrescar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_refrescar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.bt_refrescar.Location = New System.Drawing.Point(798, 194)
        Me.bt_refrescar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_refrescar.Name = "bt_refrescar"
        Me.bt_refrescar.Size = New System.Drawing.Size(207, 36)
        Me.bt_refrescar.TabIndex = 35
        Me.bt_refrescar.Text = "Refrescar tabla"
        Me.bt_refrescar.UseVisualStyleBackColor = True
        '
        'bt_vaciar
        '
        Me.bt_vaciar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_vaciar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.bt_vaciar.Location = New System.Drawing.Point(798, 150)
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
        Me.bt_guardar.Location = New System.Drawing.Point(798, 18)
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
        Me.bt_editar.Location = New System.Drawing.Point(798, 106)
        Me.bt_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_editar.Name = "bt_editar"
        Me.bt_editar.Size = New System.Drawing.Size(207, 36)
        Me.bt_editar.TabIndex = 33
        Me.bt_editar.Text = "Editar"
        Me.bt_editar.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id.BackColor = System.Drawing.Color.White
        Me.txt_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RolesBindingSource2, "id_rol", True))
        Me.txt_id.Enabled = False
        Me.txt_id.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.txt_id.Location = New System.Drawing.Point(66, 21)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(93, 24)
        Me.txt_id.TabIndex = 27
        '
        'RolesBindingSource2
        '
        Me.RolesBindingSource2.DataMember = "roles"
        Me.RolesBindingSource2.DataSource = Me.MAPADataSet
        '
        'MAPADataSet
        '
        Me.MAPADataSet.DataSetName = "MAPADataSet"
        Me.MAPADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_eliminar.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.bt_eliminar.Location = New System.Drawing.Point(798, 62)
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
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ID:"
        '
        'txt_rol
        '
        Me.txt_rol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_rol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RolesBindingSource2, "nombre_rol", True))
        Me.txt_rol.Font = New System.Drawing.Font("Inter", 8.0!)
        Me.txt_rol.Location = New System.Drawing.Point(68, 62)
        Me.txt_rol.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rol.Name = "txt_rol"
        Me.txt_rol.Size = New System.Drawing.Size(417, 24)
        Me.txt_rol.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter", 10.2!)
        Me.Label2.Location = New System.Drawing.Point(8, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Rol:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(11, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1045, 690)
        Me.Panel1.TabIndex = 27
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdrolDataGridViewTextBoxColumn, Me.NombrerolDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RolesBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(16, 299)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1009, 377)
        Me.DataGridView1.TabIndex = 29
        '
        'IdrolDataGridViewTextBoxColumn
        '
        Me.IdrolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdrolDataGridViewTextBoxColumn.DataPropertyName = "id_rol"
        Me.IdrolDataGridViewTextBoxColumn.HeaderText = "id_rol"
        Me.IdrolDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdrolDataGridViewTextBoxColumn.Name = "IdrolDataGridViewTextBoxColumn"
        Me.IdrolDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombrerolDataGridViewTextBoxColumn
        '
        Me.NombrerolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombrerolDataGridViewTextBoxColumn.DataPropertyName = "nombre_rol"
        Me.NombrerolDataGridViewTextBoxColumn.HeaderText = "nombre_rol"
        Me.NombrerolDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombrerolDataGridViewTextBoxColumn.Name = "NombrerolDataGridViewTextBoxColumn"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.bt_refrescar)
        Me.Panel2.Controls.Add(Me.bt_vaciar)
        Me.Panel2.Controls.Add(Me.bt_guardar)
        Me.Panel2.Controls.Add(Me.bt_editar)
        Me.Panel2.Controls.Add(Me.txt_id)
        Me.Panel2.Controls.Add(Me.bt_eliminar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_rol)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(16, 55)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1013, 236)
        Me.Panel2.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Inter Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(16, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 40)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Rol"
        '
        'RolesTableAdapter
        '
        Me.RolesTableAdapter.ClearBeforeFill = True
        '
        'Frm_Rol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 690)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Rol"
        Me.Text = "Form5"
        CType(Me.RolesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RolesBindingSource1 As BindingSource
    Friend WithEvents RolesBindingSource As BindingSource
    Friend WithEvents bt_refrescar As Button
    Friend WithEvents bt_vaciar As Button
    Friend WithEvents bt_guardar As Button
    Friend WithEvents bt_editar As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_rol As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents MAPADataSet As MAPADataSet
    Friend WithEvents RolesBindingSource2 As BindingSource
    Friend WithEvents RolesTableAdapter As MAPADataSetTableAdapters.rolesTableAdapter
    Friend WithEvents IdrolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombrerolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
