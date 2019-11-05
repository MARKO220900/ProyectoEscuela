<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarNotas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtañoAcademico = New System.Windows.Forms.TextBox()
        Me.txtnivelAcademico = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdniAlumno = New System.Windows.Forms.TextBox()
        Me.cmbtrimestre = New System.Windows.Forms.ComboBox()
        Me.cmbcurso = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbcompetencia = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnota = New System.Windows.Forms.TextBox()
        Me.dgvnotas = New System.Windows.Forms.DataGridView()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvnotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(647, 53)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(100, 20)
        Me.txtusuario.TabIndex = 31
        '
        'txtañoAcademico
        '
        Me.txtañoAcademico.Location = New System.Drawing.Point(428, 53)
        Me.txtañoAcademico.Name = "txtañoAcademico"
        Me.txtañoAcademico.Size = New System.Drawing.Size(100, 20)
        Me.txtañoAcademico.TabIndex = 29
        '
        'txtnivelAcademico
        '
        Me.txtnivelAcademico.Location = New System.Drawing.Point(159, 53)
        Me.txtnivelAcademico.Name = "txtnivelAcademico"
        Me.txtnivelAcademico.Size = New System.Drawing.Size(100, 20)
        Me.txtnivelAcademico.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 56)
        Me.Panel1.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "REGISTRO DE NOTAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 164)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "DNI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(294, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 19)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Año Académico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 19)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Nivel Académico"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 25)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "I.E.15144"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(574, 52)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 19)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(260, 164)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 19)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "TRIMESTRE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(544, 164)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 19)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "CURSO"
        '
        'txtdniAlumno
        '
        Me.txtdniAlumno.Location = New System.Drawing.Point(84, 165)
        Me.txtdniAlumno.Name = "txtdniAlumno"
        Me.txtdniAlumno.Size = New System.Drawing.Size(100, 20)
        Me.txtdniAlumno.TabIndex = 40
        '
        'cmbtrimestre
        '
        Me.cmbtrimestre.FormattingEnabled = True
        Me.cmbtrimestre.Location = New System.Drawing.Point(367, 165)
        Me.cmbtrimestre.Name = "cmbtrimestre"
        Me.cmbtrimestre.Size = New System.Drawing.Size(121, 21)
        Me.cmbtrimestre.TabIndex = 41
        '
        'cmbcurso
        '
        Me.cmbcurso.FormattingEnabled = True
        Me.cmbcurso.Location = New System.Drawing.Point(626, 165)
        Me.cmbcurso.Name = "cmbcurso"
        Me.cmbcurso.Size = New System.Drawing.Size(121, 21)
        Me.cmbcurso.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(25, 216)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 19)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "COMPETENCIA"
        '
        'cmbcompetencia
        '
        Me.cmbcompetencia.FormattingEnabled = True
        Me.cmbcompetencia.Location = New System.Drawing.Point(159, 217)
        Me.cmbcompetencia.Name = "cmbcompetencia"
        Me.cmbcompetencia.Size = New System.Drawing.Size(232, 21)
        Me.cmbcompetencia.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(426, 216)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 19)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "NOTA"
        '
        'txtnota
        '
        Me.txtnota.Location = New System.Drawing.Point(485, 217)
        Me.txtnota.Name = "txtnota"
        Me.txtnota.Size = New System.Drawing.Size(43, 20)
        Me.txtnota.TabIndex = 46
        '
        'dgvnotas
        '
        Me.dgvnotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvnotas.Location = New System.Drawing.Point(29, 264)
        Me.dgvnotas.Name = "dgvnotas"
        Me.dgvnotas.Size = New System.Drawing.Size(577, 196)
        Me.dgvnotas.TabIndex = 47
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnagregar.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.ForeColor = System.Drawing.Color.White
        Me.btnagregar.Location = New System.Drawing.Point(652, 216)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(95, 46)
        Me.btnagregar.TabIndex = 48
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnbuscar.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ForeColor = System.Drawing.Color.White
        Me.btnbuscar.Location = New System.Drawing.Point(652, 294)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(95, 46)
        Me.btnbuscar.TabIndex = 49
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneditar.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar.ForeColor = System.Drawing.Color.White
        Me.btneditar.Location = New System.Drawing.Point(652, 367)
        Me.btneditar.Margin = New System.Windows.Forms.Padding(2)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(95, 46)
        Me.btneditar.TabIndex = 50
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'frmRegistrarNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(784, 481)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.dgvnotas)
        Me.Controls.Add(Me.txtnota)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbcompetencia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbcurso)
        Me.Controls.Add(Me.cmbtrimestre)
        Me.Controls.Add(Me.txtdniAlumno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.txtañoAcademico)
        Me.Controls.Add(Me.txtnivelAcademico)
        Me.Name = "frmRegistrarNotas"
        Me.Text = "frmRegistrarNotas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvnotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents txtañoAcademico As System.Windows.Forms.TextBox
    Friend WithEvents txtnivelAcademico As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdniAlumno As System.Windows.Forms.TextBox
    Friend WithEvents cmbtrimestre As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbcompetencia As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtnota As System.Windows.Forms.TextBox
    Friend WithEvents dgvnotas As System.Windows.Forms.DataGridView
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
End Class
