<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.check_Mostrar = New System.Windows.Forms.CheckBox()
        Me.txt_Clave = New System.Windows.Forms.TextBox()
        Me.bt_Ingresar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.background_Login = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.background_Login.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.check_Mostrar)
        Me.Panel1.Controls.Add(Me.txt_Clave)
        Me.Panel1.Controls.Add(Me.bt_Ingresar)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_Usuario)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(4, 263)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1041, 420)
        Me.Panel1.TabIndex = 2
        '
        'check_Mostrar
        '
        Me.check_Mostrar.AutoSize = True
        Me.check_Mostrar.Location = New System.Drawing.Point(337, 229)
        Me.check_Mostrar.Margin = New System.Windows.Forms.Padding(4)
        Me.check_Mostrar.Name = "check_Mostrar"
        Me.check_Mostrar.Size = New System.Drawing.Size(153, 21)
        Me.check_Mostrar.TabIndex = 21
        Me.check_Mostrar.Text = "Mostrar contraseña"
        Me.check_Mostrar.UseVisualStyleBackColor = True
        '
        'txt_Clave
        '
        Me.txt_Clave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Clave.Location = New System.Drawing.Point(247, 171)
        Me.txt_Clave.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Clave.MaximumSize = New System.Drawing.Size(532, 35)
        Me.txt_Clave.Name = "txt_Clave"
        Me.txt_Clave.Size = New System.Drawing.Size(329, 22)
        Me.txt_Clave.TabIndex = 20
        '
        'bt_Ingresar
        '
        Me.bt_Ingresar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Ingresar.Location = New System.Drawing.Point(247, 331)
        Me.bt_Ingresar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_Ingresar.MaximumSize = New System.Drawing.Size(533, 43)
        Me.bt_Ingresar.Name = "bt_Ingresar"
        Me.bt_Ingresar.Size = New System.Drawing.Size(333, 43)
        Me.bt_Ingresar.TabIndex = 19
        Me.bt_Ingresar.Text = "Iniciar sesión"
        Me.bt_Ingresar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(413, 276)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Crear un nuevo usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label5.Location = New System.Drawing.Point(224, 276)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "No tienes un usuario?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(16, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Ingresa de Contraseña:"
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Usuario.Location = New System.Drawing.Point(249, 119)
        Me.txt_Usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Usuario.MaximumSize = New System.Drawing.Size(532, 35)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(329, 22)
        Me.txt_Usuario.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(16, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nombre de Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(16, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(405, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Inicio de sesión con tu usuario de MAPA Interface"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 39)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Inicio de sesión"
        '
        'background_Login
        '
        Me.background_Login.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.background_Login.Controls.Add(Me.Panel1)
        Me.background_Login.Controls.Add(Me.PictureBox1)
        Me.background_Login.Location = New System.Drawing.Point(0, -2)
        Me.background_Login.Margin = New System.Windows.Forms.Padding(4)
        Me.background_Login.Name = "background_Login"
        Me.background_Login.Size = New System.Drawing.Size(1045, 695)
        Me.background_Login.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1045, 256)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 690)
        Me.Controls.Add(Me.background_Login)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Sistema MAPA VB - Inicio de Sesión"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.background_Login.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents check_Mostrar As CheckBox
    Friend WithEvents txt_Clave As TextBox
    Friend WithEvents bt_Ingresar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents background_Login As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
