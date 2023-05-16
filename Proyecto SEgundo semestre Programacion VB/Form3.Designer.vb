<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.BtnBebidasAlcoholicas = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnGaseosas = New System.Windows.Forms.Button()
        Me.BtnAguasDeSabor = New System.Windows.Forms.Button()
        Me.BtnAguasMineralizadas = New System.Windows.Forms.Button()
        Me.LblText2 = New System.Windows.Forms.Label()
        Me.nudNumeroDePedidos = New System.Windows.Forms.NumericUpDown()
        Me.LblText = New System.Windows.Forms.Label()
        Me.BtnOpcion3 = New System.Windows.Forms.Button()
        Me.BtnOpcion2 = New System.Windows.Forms.Button()
        Me.BtnOpcion1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumeroDePedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBebidasAlcoholicas
        '
        Me.BtnBebidasAlcoholicas.Location = New System.Drawing.Point(12, 12)
        Me.BtnBebidasAlcoholicas.Name = "BtnBebidasAlcoholicas"
        Me.BtnBebidasAlcoholicas.Size = New System.Drawing.Size(164, 59)
        Me.BtnBebidasAlcoholicas.TabIndex = 0
        Me.BtnBebidasAlcoholicas.Text = "Bebidas alcohólicas"
        Me.BtnBebidasAlcoholicas.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(688, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'BtnGaseosas
        '
        Me.BtnGaseosas.Location = New System.Drawing.Point(182, 12)
        Me.BtnGaseosas.Name = "BtnGaseosas"
        Me.BtnGaseosas.Size = New System.Drawing.Size(159, 59)
        Me.BtnGaseosas.TabIndex = 3
        Me.BtnGaseosas.Text = "Gaseosas"
        Me.BtnGaseosas.UseVisualStyleBackColor = True
        '
        'BtnAguasDeSabor
        '
        Me.BtnAguasDeSabor.Location = New System.Drawing.Point(347, 12)
        Me.BtnAguasDeSabor.Name = "BtnAguasDeSabor"
        Me.BtnAguasDeSabor.Size = New System.Drawing.Size(145, 59)
        Me.BtnAguasDeSabor.TabIndex = 4
        Me.BtnAguasDeSabor.Text = "Aguas de Sabor"
        Me.BtnAguasDeSabor.UseVisualStyleBackColor = True
        '
        'BtnAguasMineralizadas
        '
        Me.BtnAguasMineralizadas.Location = New System.Drawing.Point(12, 77)
        Me.BtnAguasMineralizadas.Name = "BtnAguasMineralizadas"
        Me.BtnAguasMineralizadas.Size = New System.Drawing.Size(164, 54)
        Me.BtnAguasMineralizadas.TabIndex = 5
        Me.BtnAguasMineralizadas.Text = "Aguas Mineralizadas"
        Me.BtnAguasMineralizadas.UseVisualStyleBackColor = True
        '
        'LblText2
        '
        Me.LblText2.AutoSize = True
        Me.LblText2.BackColor = System.Drawing.Color.Transparent
        Me.LblText2.ForeColor = System.Drawing.Color.Black
        Me.LblText2.Location = New System.Drawing.Point(12, 262)
        Me.LblText2.Name = "LblText2"
        Me.LblText2.Size = New System.Drawing.Size(195, 15)
        Me.LblText2.TabIndex = 18
        Me.LblText2.Text = "De que le gustaria pedir las gringas?"
        '
        'nudNumeroDePedidos
        '
        Me.nudNumeroDePedidos.Location = New System.Drawing.Point(12, 227)
        Me.nudNumeroDePedidos.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNumeroDePedidos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumeroDePedidos.Name = "nudNumeroDePedidos"
        Me.nudNumeroDePedidos.Size = New System.Drawing.Size(120, 23)
        Me.nudNumeroDePedidos.TabIndex = 17
        Me.nudNumeroDePedidos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LblText
        '
        Me.LblText.AutoSize = True
        Me.LblText.BackColor = System.Drawing.Color.Transparent
        Me.LblText.Location = New System.Drawing.Point(12, 209)
        Me.LblText.Name = "LblText"
        Me.LblText.Size = New System.Drawing.Size(185, 15)
        Me.LblText.TabIndex = 16
        Me.LblText.Text = "Cuantas Gringas le gustaria pedir?"
        '
        'BtnOpcion3
        '
        Me.BtnOpcion3.BackColor = System.Drawing.Color.Transparent
        Me.BtnOpcion3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnOpcion3.Location = New System.Drawing.Point(206, 289)
        Me.BtnOpcion3.Name = "BtnOpcion3"
        Me.BtnOpcion3.Size = New System.Drawing.Size(97, 44)
        Me.BtnOpcion3.TabIndex = 15
        Me.BtnOpcion3.UseVisualStyleBackColor = False
        '
        'BtnOpcion2
        '
        Me.BtnOpcion2.BackColor = System.Drawing.Color.Transparent
        Me.BtnOpcion2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnOpcion2.Location = New System.Drawing.Point(103, 289)
        Me.BtnOpcion2.Name = "BtnOpcion2"
        Me.BtnOpcion2.Size = New System.Drawing.Size(97, 44)
        Me.BtnOpcion2.TabIndex = 14
        Me.BtnOpcion2.Text = "Harina"
        Me.BtnOpcion2.UseVisualStyleBackColor = False
        '
        'BtnOpcion1
        '
        Me.BtnOpcion1.Location = New System.Drawing.Point(0, 289)
        Me.BtnOpcion1.Name = "BtnOpcion1"
        Me.BtnOpcion1.Size = New System.Drawing.Size(97, 44)
        Me.BtnOpcion1.TabIndex = 13
        Me.BtnOpcion1.Text = "Maiz"
        Me.BtnOpcion1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblText2)
        Me.Controls.Add(Me.nudNumeroDePedidos)
        Me.Controls.Add(Me.LblText)
        Me.Controls.Add(Me.BtnOpcion3)
        Me.Controls.Add(Me.BtnOpcion2)
        Me.Controls.Add(Me.BtnOpcion1)
        Me.Controls.Add(Me.BtnAguasMineralizadas)
        Me.Controls.Add(Me.BtnAguasDeSabor)
        Me.Controls.Add(Me.BtnGaseosas)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnBebidasAlcoholicas)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumeroDePedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBebidasAlcoholicas As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnGaseosas As Button
    Friend WithEvents BtnAguasDeSabor As Button
    Friend WithEvents BtnAguasMineralizadas As Button
    Friend WithEvents LblText2 As Label
    Friend WithEvents nudNumeroDePedidos As NumericUpDown
    Friend WithEvents LblText As Label
    Friend WithEvents BtnOpcion3 As Button
    Friend WithEvents BtnOpcion2 As Button
    Friend WithEvents BtnOpcion1 As Button
End Class
