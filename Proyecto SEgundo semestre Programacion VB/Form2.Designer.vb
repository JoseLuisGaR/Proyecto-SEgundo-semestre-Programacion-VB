<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BtnTacosAlPastor = New System.Windows.Forms.Button()
        Me.BtnChilaquiles = New System.Windows.Forms.Button()
        Me.BtnTamales = New System.Windows.Forms.Button()
        Me.BtnPozole = New System.Windows.Forms.Button()
        Me.BtnGringa = New System.Windows.Forms.Button()
        Me.BtnBarbacoa = New System.Windows.Forms.Button()
        Me.BtnOpcion1 = New System.Windows.Forms.Button()
        Me.BtnOpcion2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnOpcion3 = New System.Windows.Forms.Button()
        Me.LblText = New System.Windows.Forms.Label()
        Me.nudNumeroDePedidos = New System.Windows.Forms.NumericUpDown()
        Me.LblText2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumeroDePedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTacosAlPastor
        '
        Me.BtnTacosAlPastor.BackColor = System.Drawing.SystemColors.Control
        Me.BtnTacosAlPastor.Image = CType(resources.GetObject("BtnTacosAlPastor.Image"), System.Drawing.Image)
        Me.BtnTacosAlPastor.Location = New System.Drawing.Point(2, 30)
        Me.BtnTacosAlPastor.Name = "BtnTacosAlPastor"
        Me.BtnTacosAlPastor.Size = New System.Drawing.Size(130, 83)
        Me.BtnTacosAlPastor.TabIndex = 0
        Me.BtnTacosAlPastor.Tag = ""
        Me.BtnTacosAlPastor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnTacosAlPastor.UseVisualStyleBackColor = False
        '
        'BtnChilaquiles
        '
        Me.BtnChilaquiles.Location = New System.Drawing.Point(138, 46)
        Me.BtnChilaquiles.Name = "BtnChilaquiles"
        Me.BtnChilaquiles.Size = New System.Drawing.Size(130, 67)
        Me.BtnChilaquiles.TabIndex = 1
        Me.BtnChilaquiles.Text = "Chilaquiles"
        Me.BtnChilaquiles.UseVisualStyleBackColor = True
        '
        'BtnTamales
        '
        Me.BtnTamales.Location = New System.Drawing.Point(274, 46)
        Me.BtnTamales.Name = "BtnTamales"
        Me.BtnTamales.Size = New System.Drawing.Size(130, 67)
        Me.BtnTamales.TabIndex = 2
        Me.BtnTamales.Text = "Tamales"
        Me.BtnTamales.UseVisualStyleBackColor = True
        '
        'BtnPozole
        '
        Me.BtnPozole.Location = New System.Drawing.Point(2, 155)
        Me.BtnPozole.Name = "BtnPozole"
        Me.BtnPozole.Size = New System.Drawing.Size(130, 67)
        Me.BtnPozole.TabIndex = 3
        Me.BtnPozole.Text = "Pozole"
        Me.BtnPozole.UseVisualStyleBackColor = True
        '
        'BtnGringa
        '
        Me.BtnGringa.Location = New System.Drawing.Point(138, 155)
        Me.BtnGringa.Name = "BtnGringa"
        Me.BtnGringa.Size = New System.Drawing.Size(130, 67)
        Me.BtnGringa.TabIndex = 4
        Me.BtnGringa.Text = "Gringa"
        Me.BtnGringa.UseVisualStyleBackColor = True
        '
        'BtnBarbacoa
        '
        Me.BtnBarbacoa.Location = New System.Drawing.Point(274, 155)
        Me.BtnBarbacoa.Name = "BtnBarbacoa"
        Me.BtnBarbacoa.Size = New System.Drawing.Size(130, 67)
        Me.BtnBarbacoa.TabIndex = 5
        Me.BtnBarbacoa.Text = "Barbacoa"
        Me.BtnBarbacoa.UseVisualStyleBackColor = True
        '
        'BtnOpcion1
        '
        Me.BtnOpcion1.Location = New System.Drawing.Point(12, 305)
        Me.BtnOpcion1.Name = "BtnOpcion1"
        Me.BtnOpcion1.Size = New System.Drawing.Size(97, 44)
        Me.BtnOpcion1.TabIndex = 6
        Me.BtnOpcion1.Text = "Maiz"
        Me.BtnOpcion1.UseVisualStyleBackColor = True
        '
        'BtnOpcion2
        '
        Me.BtnOpcion2.BackColor = System.Drawing.Color.Transparent
        Me.BtnOpcion2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnOpcion2.Location = New System.Drawing.Point(115, 305)
        Me.BtnOpcion2.Name = "BtnOpcion2"
        Me.BtnOpcion2.Size = New System.Drawing.Size(97, 44)
        Me.BtnOpcion2.TabIndex = 7
        Me.BtnOpcion2.Text = "Harina"
        Me.BtnOpcion2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(672, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 56)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'BtnOpcion3
        '
        Me.BtnOpcion3.BackColor = System.Drawing.Color.Transparent
        Me.BtnOpcion3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnOpcion3.Location = New System.Drawing.Point(218, 305)
        Me.BtnOpcion3.Name = "BtnOpcion3"
        Me.BtnOpcion3.Size = New System.Drawing.Size(97, 44)
        Me.BtnOpcion3.TabIndex = 9
        Me.BtnOpcion3.UseVisualStyleBackColor = False
        '
        'LblText
        '
        Me.LblText.AutoSize = True
        Me.LblText.BackColor = System.Drawing.Color.Transparent
        Me.LblText.Location = New System.Drawing.Point(24, 225)
        Me.LblText.Name = "LblText"
        Me.LblText.Size = New System.Drawing.Size(185, 15)
        Me.LblText.TabIndex = 10
        Me.LblText.Text = "Cuantas Gringas le gustaria pedir?"
        '
        'nudNumeroDePedidos
        '
        Me.nudNumeroDePedidos.Location = New System.Drawing.Point(24, 243)
        Me.nudNumeroDePedidos.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNumeroDePedidos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumeroDePedidos.Name = "nudNumeroDePedidos"
        Me.nudNumeroDePedidos.Size = New System.Drawing.Size(120, 23)
        Me.nudNumeroDePedidos.TabIndex = 11
        Me.nudNumeroDePedidos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LblText2
        '
        Me.LblText2.AutoSize = True
        Me.LblText2.BackColor = System.Drawing.Color.Transparent
        Me.LblText2.ForeColor = System.Drawing.Color.Black
        Me.LblText2.Location = New System.Drawing.Point(24, 278)
        Me.LblText2.Name = "LblText2"
        Me.LblText2.Size = New System.Drawing.Size(195, 15)
        Me.LblText2.TabIndex = 12
        Me.LblText2.Text = "De que le gustaria pedir las gringas?"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.LblText2)
        Me.Controls.Add(Me.nudNumeroDePedidos)
        Me.Controls.Add(Me.LblText)
        Me.Controls.Add(Me.BtnOpcion3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnTacosAlPastor)
        Me.Controls.Add(Me.BtnOpcion2)
        Me.Controls.Add(Me.BtnOpcion1)
        Me.Controls.Add(Me.BtnBarbacoa)
        Me.Controls.Add(Me.BtnGringa)
        Me.Controls.Add(Me.BtnPozole)
        Me.Controls.Add(Me.BtnTamales)
        Me.Controls.Add(Me.BtnChilaquiles)
        Me.Name = "Form2"
        Me.Tag = "Menu Comida"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumeroDePedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTacosAlPastor As Button
    Friend WithEvents BtnChilaquiles As Button
    Friend WithEvents BtnTamales As Button
    Friend WithEvents BtnPozole As Button
    Friend WithEvents BtnGringa As Button
    Friend WithEvents BtnBarbacoa As Button
    Friend WithEvents BtnOpcion1 As Button
    Friend WithEvents BtnOpcion2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnOpcion3 As Button
    Friend WithEvents LblText As Label
    Friend WithEvents nudNumeroDePedidos As NumericUpDown
    Friend WithEvents LblText2 As Label
End Class
