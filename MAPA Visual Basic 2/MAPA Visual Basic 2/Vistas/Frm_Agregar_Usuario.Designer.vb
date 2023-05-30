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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_rol = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bt_registrar = New System.Windows.Forms.Button()
        Me.MAPADataSet = New MAPA_Visual_Basic_2.MAPADataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.usuariosTableAdapter()
        Me.RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RolesTableAdapter = New MAPA_Visual_Basic_2.MAPADataSetTableAdapters.rolesTableAdapter()
        Me.check_mostrar_clave = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-2, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 572)
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
        Me.Panel3.Location = New System.Drawing.Point(451, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(887, 566)
        Me.Panel3.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MAPA_Visual_Basic_2.My.Resources.Resources.Logo_MAPA
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(164, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'txt_correo
        '
        Me.txt_correo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_correo.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsuariosBindingSource, "correo_electronico", True))
        Me.txt_correo.Location = New System.Drawing.Point(86, 373)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(337, 20)
        Me.txt_correo.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(9, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Correo:"
        '
        'txt_clave
        '
        Me.txt_clave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_clave.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsuariosBindingSource, "clave", True))
        Me.txt_clave.HideSelection = False
        Me.txt_clave.Location = New System.Drawing.Point(86, 298)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(337, 20)
        Me.txt_clave.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(10, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Clave:"
        '
        'cb_rol
        '
        Me.cb_rol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_rol.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UsuariosBindingSource, "id_rol", True))
        Me.cb_rol.DataSource = Me.RolesBindingSource
        Me.cb_rol.DisplayMember = "nombre_rol"
        Me.cb_rol.FormattingEnabled = True
        Me.cb_rol.Location = New System.Drawing.Point(88, 430)
        Me.cb_rol.Name = "cb_rol"
        Me.cb_rol.Size = New System.Drawing.Size(335, 21)
        Me.cb_rol.TabIndex = 50
        Me.cb_rol.ValueMember = "id_rol"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(9, 428)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Rol:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_usuario.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsuariosBindingSource, "nombre", True))
        Me.txt_usuario.Location = New System.Drawing.Point(88, 246)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(335, 20)
        Me.txt_usuario.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(9, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
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
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(449, 566)
        Me.Panel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(130, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 31)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Registrar usuario"
        '
        'bt_registrar
        '
        Me.bt_registrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_registrar.AutoSize = True
        Me.bt_registrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_registrar.Location = New System.Drawing.Point(132, 478)
        Me.bt_registrar.Name = "bt_registrar"
        Me.bt_registrar.Size = New System.Drawing.Size(215, 29)
        Me.bt_registrar.TabIndex = 57
        Me.bt_registrar.Text = "Registrar"
        Me.bt_registrar.UseVisualStyleBackColor = True
        '
        'MAPADataSet
        '
        Me.MAPADataSet.DataSetName = "MAPADataSet"
        Me.MAPADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.MAPADataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'RolesBindingSource
        '
        Me.RolesBindingSource.DataMember = "roles"
        Me.RolesBindingSource.DataSource = Me.MAPADataSet
        '
        'RolesTableAdapter
        '
        Me.RolesTableAdapter.ClearBeforeFill = True
        '
        'check_mostrar_clave
        '
        Me.check_mostrar_clave.AutoSize = True
        Me.check_mostrar_clave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.check_mostrar_clave.Location = New System.Drawing.Point(86, 324)
        Me.check_mostrar_clave.Name = "check_mostrar_clave"
        Me.check_mostrar_clave.Size = New System.Drawing.Size(117, 17)
        Me.check_mostrar_clave.TabIndex = 59
        Me.check_mostrar_clave.Text = "Mostrar contraseña"
        Me.check_mostrar_clave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(186, 526)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_Agregar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.Panel1)
        Me.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MaximizeBox = False
        Me.Name = "Frm_Agregar_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar usuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
