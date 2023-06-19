<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Agregar_Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Agregar_Usuario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb_rol = New System.Windows.Forms.ComboBox()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAPADataSet = New MAPA_Visual_Basic_2.MAPADataSet()
        Me.RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.check_mostrar_clave = New System.Windows.Forms.CheckBox()
        Me.bt_registrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UsuariosTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.usuariosTableAdapter()
        Me.RolesTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.rolesTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-3, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1183, 704)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.cb_rol)
        Me.Panel3.Controls.Add(Me.txt_correo)
        Me.Panel3.Controls.Add(Me.txt_clave)
        Me.Panel3.Controls.Add(Me.txt_usuario)
        Me.Panel3.Controls.Add(Me.check_mostrar_clave)
        Me.Panel3.Controls.Add(Me.bt_registrar)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(601, 4)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1183, 697)
        Me.Panel3.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(248, 647)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cb_rol
        '
        Me.cb_rol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_rol.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UsuariosBindingSource, "id_rol", True))
        Me.cb_rol.DataSource = Me.RolesBindingSource
        Me.cb_rol.DisplayMember = "nombre_rol"
        Me.cb_rol.FormattingEnabled = True
        Me.cb_rol.Location = New System.Drawing.Point(117, 529)
        Me.cb_rol.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_rol.Name = "cb_rol"
        Me.cb_rol.Size = New System.Drawing.Size(445, 24)
        Me.cb_rol.TabIndex = 5
        Me.cb_rol.ValueMember = "id_rol"
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.MAPADataSet
        '
        'MAPADataSet
        '
        Me.MAPADataSet.DataSetName = "MAPADataSet"
        Me.MAPADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RolesBindingSource
        '
        Me.RolesBindingSource.DataMember = "roles"
        Me.RolesBindingSource.DataSource = Me.MAPADataSet
        '
        'txt_correo
        '
        Me.txt_correo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_correo.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsuariosBindingSource, "correo_electronico", True))
        Me.txt_correo.Location = New System.Drawing.Point(115, 459)
        Me.txt_correo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(448, 22)
        Me.txt_correo.TabIndex = 4
        '
        'txt_clave
        '
        Me.txt_clave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_clave.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsuariosBindingSource, "clave", True))
        Me.txt_clave.HideSelection = False
        Me.txt_clave.Location = New System.Drawing.Point(115, 367)
        Me.txt_clave.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(448, 22)
        Me.txt_clave.TabIndex = 2
        '
        'txt_usuario
        '
        Me.txt_usuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_usuario.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsuariosBindingSource, "nombre", True))
        Me.txt_usuario.Location = New System.Drawing.Point(117, 303)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(445, 22)
        Me.txt_usuario.TabIndex = 1
        '
        'check_mostrar_clave
        '
        Me.check_mostrar_clave.AutoSize = True
        Me.check_mostrar_clave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.check_mostrar_clave.Location = New System.Drawing.Point(115, 399)
        Me.check_mostrar_clave.Margin = New System.Windows.Forms.Padding(4)
        Me.check_mostrar_clave.Name = "check_mostrar_clave"
        Me.check_mostrar_clave.Size = New System.Drawing.Size(153, 21)
        Me.check_mostrar_clave.TabIndex = 3
        Me.check_mostrar_clave.Text = "Mostrar contraseña"
        Me.check_mostrar_clave.UseVisualStyleBackColor = True
        '
        'bt_registrar
        '
        Me.bt_registrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_registrar.AutoSize = True
        Me.bt_registrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_registrar.Location = New System.Drawing.Point(176, 588)
        Me.bt_registrar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_registrar.Name = "bt_registrar"
        Me.bt_registrar.Size = New System.Drawing.Size(287, 36)
        Me.bt_registrar.TabIndex = 6
        Me.bt_registrar.Text = "Registrar"
        Me.bt_registrar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(173, 228)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(276, 39)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Registrar usuario"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MAPA_Visual_Basic_2.My.Resources.Resources.Logo_MAPA
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(219, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 457)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 25)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Correo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(13, 367)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 25)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Clave:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 527)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 25)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Rol:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 303)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Usuario:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackgroundImage = Global.MAPA_Visual_Basic_2.My.Resources.Resources.Fondo_Registrar
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(4, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(599, 697)
        Me.Panel2.TabIndex = 0
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'RolesTableAdapter
        '
        Me.RolesTableAdapter.ClearBeforeFill = True
        '
        'Frm_Agregar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 690)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Frm_Agregar_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema MAPA VB - Ingresar usuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_rol As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bt_registrar As Button
    Friend WithEvents MAPADataSet As MAPADataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As MAPADataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents RolesBindingSource As BindingSource
    Friend WithEvents RolesTableAdapter As MAPADataSetTableAdapters.rolesTableAdapter
    Friend WithEvents check_mostrar_clave As CheckBox
    Friend WithEvents Button1 As Button
End Class
