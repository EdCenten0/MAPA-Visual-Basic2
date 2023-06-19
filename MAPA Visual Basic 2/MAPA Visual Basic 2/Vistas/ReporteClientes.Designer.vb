<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteClientes
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CrystalReport11 = New MAPA_Visual_Basic_2.CrystalReport1()
        Me.cryreport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport21 = New MAPA_Visual_Basic_2.CrystalReport2()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Filtrado:"
        '
        'Buscar
        '
        Me.Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Buscar.Location = New System.Drawing.Point(873, 10)
        Me.Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(163, 28)
        Me.Buscar.TabIndex = 2
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(117, 12)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(733, 22)
        Me.TextBox1.TabIndex = 1
        '
        'cryreport
        '
        Me.cryreport.ActiveViewIndex = 0
        Me.cryreport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cryreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cryreport.Cursor = System.Windows.Forms.Cursors.Default
        Me.cryreport.Location = New System.Drawing.Point(-1, 41)
        Me.cryreport.Margin = New System.Windows.Forms.Padding(4)
        Me.cryreport.Name = "cryreport"
        Me.cryreport.ReportSource = Me.CrystalReport21
        Me.cryreport.Size = New System.Drawing.Size(1071, 651)
        Me.cryreport.TabIndex = 15
        Me.cryreport.ToolPanelWidth = 267
        '
        'ReporteClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 690)
        Me.Controls.Add(Me.cryreport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.TextBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ReporteClientes"
        Me.Text = "Sistema MAPA VB - Reporte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReport11 As CrystalReport1
    Friend WithEvents Label2 As Label
    Friend WithEvents Buscar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cryreport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport21 As CrystalReport2
End Class
