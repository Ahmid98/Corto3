<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUSCARVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_nit = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_consultanit = New System.Windows.Forms.TextBox()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_doas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_habitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_com = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb_tipopago = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_tipohabi = New System.Windows.Forms.ComboBox()
        Me.txt_impuesto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nodias = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULOToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.CONSULTARToolStripMenuItem, Me.ELIMINARToolStripMenuItem, Me.BUSCARVEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1004, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULOToolStripMenuItem
        '
        Me.CALCULOToolStripMenuItem.Name = "CALCULOToolStripMenuItem"
        Me.CALCULOToolStripMenuItem.Size = New System.Drawing.Size(102, 29)
        Me.CALCULOToolStripMenuItem.Text = "CALCULO"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(111, 29)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'CONSULTARToolStripMenuItem
        '
        Me.CONSULTARToolStripMenuItem.Name = "CONSULTARToolStripMenuItem"
        Me.CONSULTARToolStripMenuItem.Size = New System.Drawing.Size(126, 29)
        Me.CONSULTARToolStripMenuItem.Text = "CONSULTAR"
        '
        'ELIMINARToolStripMenuItem
        '
        Me.ELIMINARToolStripMenuItem.Name = "ELIMINARToolStripMenuItem"
        Me.ELIMINARToolStripMenuItem.Size = New System.Drawing.Size(107, 29)
        Me.ELIMINARToolStripMenuItem.Text = "ELIMINAR"
        '
        'BUSCARVEToolStripMenuItem
        '
        Me.BUSCARVEToolStripMenuItem.Name = "BUSCARVEToolStripMenuItem"
        Me.BUSCARVEToolStripMenuItem.Size = New System.Drawing.Size(195, 29)
        Me.BUSCARVEToolStripMenuItem.Text = "ELIMINAR VECTORES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_nit)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.tabla)
        Me.GroupBox1.Controls.Add(Me.cb_tipopago)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cb_tipohabi)
        Me.GroupBox1.Controls.Add(Me.txt_impuesto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_nodias)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(980, 566)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DE DATOS:"
        '
        'txt_nit
        '
        Me.txt_nit.Location = New System.Drawing.Point(182, 105)
        Me.txt_nit.Name = "txt_nit"
        Me.txt_nit.Size = New System.Drawing.Size(147, 26)
        Me.txt_nit.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_consultanit)
        Me.GroupBox2.Location = New System.Drawing.Point(722, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 150)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONSULTAR:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "NIT:"
        '
        'txt_consultanit
        '
        Me.txt_consultanit.Location = New System.Drawing.Point(37, 87)
        Me.txt_consultanit.Name = "txt_consultanit"
        Me.txt_consultanit.Size = New System.Drawing.Size(147, 26)
        Me.txt_consultanit.TabIndex = 3
        '
        'tabla
        '
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.nit, Me.no_doas, Me.valor_impuesto, Me.tipo_habitacion, Me.tipo_pago, Me.total_pagar, Me.descuento, Me.recargo, Me.total_com})
        Me.tabla.Location = New System.Drawing.Point(7, 253)
        Me.tabla.Name = "tabla"
        Me.tabla.RowHeadersWidth = 62
        Me.tabla.RowTemplate.Height = 28
        Me.tabla.Size = New System.Drawing.Size(967, 295)
        Me.tabla.TabIndex = 12
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.MinimumWidth = 8
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 150
        '
        'nit
        '
        Me.nit.HeaderText = "Nit"
        Me.nit.MinimumWidth = 8
        Me.nit.Name = "nit"
        Me.nit.Width = 150
        '
        'no_doas
        '
        Me.no_doas.HeaderText = "No. dias"
        Me.no_doas.MinimumWidth = 8
        Me.no_doas.Name = "no_doas"
        Me.no_doas.Width = 150
        '
        'valor_impuesto
        '
        Me.valor_impuesto.HeaderText = "Valor impuesto"
        Me.valor_impuesto.MinimumWidth = 8
        Me.valor_impuesto.Name = "valor_impuesto"
        Me.valor_impuesto.Width = 150
        '
        'tipo_habitacion
        '
        Me.tipo_habitacion.HeaderText = "Tipo habitacion"
        Me.tipo_habitacion.MinimumWidth = 8
        Me.tipo_habitacion.Name = "tipo_habitacion"
        Me.tipo_habitacion.Width = 150
        '
        'tipo_pago
        '
        Me.tipo_pago.HeaderText = "Tipo pago"
        Me.tipo_pago.MinimumWidth = 8
        Me.tipo_pago.Name = "tipo_pago"
        Me.tipo_pago.Width = 150
        '
        'total_pagar
        '
        Me.total_pagar.HeaderText = "Total a pagar"
        Me.total_pagar.MinimumWidth = 8
        Me.total_pagar.Name = "total_pagar"
        Me.total_pagar.Width = 150
        '
        'descuento
        '
        Me.descuento.HeaderText = "Descuento"
        Me.descuento.MinimumWidth = 8
        Me.descuento.Name = "descuento"
        Me.descuento.Width = 150
        '
        'recargo
        '
        Me.recargo.HeaderText = "Recargo"
        Me.recargo.MinimumWidth = 8
        Me.recargo.Name = "recargo"
        Me.recargo.Width = 150
        '
        'total_com
        '
        Me.total_com.HeaderText = "Total Final"
        Me.total_com.MinimumWidth = 8
        Me.total_com.Name = "total_com"
        Me.total_com.Width = 150
        '
        'cb_tipopago
        '
        Me.cb_tipopago.FormattingEnabled = True
        Me.cb_tipopago.Items.AddRange(New Object() {"Efectivo", "Tarjeta de C o D", "Transferencia" & Global.Microsoft.VisualBasic.ChrW(9), "Deposito"})
        Me.cb_tipopago.Location = New System.Drawing.Point(522, 165)
        Me.cb_tipopago.Name = "cb_tipopago"
        Me.cb_tipopago.Size = New System.Drawing.Size(147, 28)
        Me.cb_tipopago.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(370, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tipo pago:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(370, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo habitacion:"
        '
        'cb_tipohabi
        '
        Me.cb_tipohabi.FormattingEnabled = True
        Me.cb_tipohabi.Items.AddRange(New Object() {"Sencilla", "Doble", "Cabaña"})
        Me.cb_tipohabi.Location = New System.Drawing.Point(522, 105)
        Me.cb_tipohabi.Name = "cb_tipohabi"
        Me.cb_tipohabi.Size = New System.Drawing.Size(147, 28)
        Me.cb_tipohabi.TabIndex = 8
        '
        'txt_impuesto
        '
        Me.txt_impuesto.Location = New System.Drawing.Point(522, 43)
        Me.txt_impuesto.Name = "txt_impuesto"
        Me.txt_impuesto.Size = New System.Drawing.Size(147, 26)
        Me.txt_impuesto.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(370, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Valor impuesto:"
        '
        'txt_nodias
        '
        Me.txt_nodias.Location = New System.Drawing.Point(182, 159)
        Me.txt_nodias.Name = "txt_nodias"
        Me.txt_nodias.Size = New System.Drawing.Size(147, 26)
        Me.txt_nodias.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No. dias:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIT:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(182, 46)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(147, 26)
        Me.txt_nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre huesped:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 639)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "SISTEMA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BUSCARVEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cb_tipopago As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_tipohabi As ComboBox
    Friend WithEvents txt_impuesto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nodias As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_consultanit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tabla As DataGridView
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents nit As DataGridViewTextBoxColumn
    Friend WithEvents no_doas As DataGridViewTextBoxColumn
    Friend WithEvents valor_impuesto As DataGridViewTextBoxColumn
    Friend WithEvents tipo_habitacion As DataGridViewTextBoxColumn
    Friend WithEvents tipo_pago As DataGridViewTextBoxColumn
    Friend WithEvents total_pagar As DataGridViewTextBoxColumn
    Friend WithEvents descuento As DataGridViewTextBoxColumn
    Friend WithEvents recargo As DataGridViewTextBoxColumn
    Friend WithEvents total_com As DataGridViewTextBoxColumn
    Friend WithEvents txt_nit As TextBox
End Class
