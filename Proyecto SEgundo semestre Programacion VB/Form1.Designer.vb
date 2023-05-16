<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.btnDrink = New System.Windows.Forms.Button()
        Me.btnDessert = New System.Windows.Forms.Button()
        Me.BtnInfo = New System.Windows.Forms.Button()
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.BtnPay = New System.Windows.Forms.Button()
        Me.LblText = New System.Windows.Forms.Label()
        Me.nudEdad = New System.Windows.Forms.NumericUpDown()
        Me.BtnEdad = New System.Windows.Forms.Button()
        Me.TbxName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFood
        '
        Me.btnFood.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFood.Location = New System.Drawing.Point(164, 0)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(155, 60)
        Me.btnFood.TabIndex = 0
        Me.btnFood.Text = "Comida"
        Me.btnFood.UseVisualStyleBackColor = True
        '
        'btnDrink
        '
        Me.btnDrink.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDrink.Location = New System.Drawing.Point(319, 0)
        Me.btnDrink.Name = "btnDrink"
        Me.btnDrink.Size = New System.Drawing.Size(155, 60)
        Me.btnDrink.TabIndex = 1
        Me.btnDrink.Text = "Bebida"
        Me.btnDrink.UseVisualStyleBackColor = True
        '
        'btnDessert
        '
        Me.btnDessert.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDessert.Location = New System.Drawing.Point(480, 0)
        Me.btnDessert.Name = "btnDessert"
        Me.btnDessert.Size = New System.Drawing.Size(155, 60)
        Me.btnDessert.TabIndex = 2
        Me.btnDessert.Text = "Postre"
        Me.btnDessert.UseVisualStyleBackColor = True
        '
        'BtnInfo
        '
        Me.BtnInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnInfo.Location = New System.Drawing.Point(509, 697)
        Me.BtnInfo.Name = "BtnInfo"
        Me.BtnInfo.Size = New System.Drawing.Size(75, 50)
        Me.BtnInfo.TabIndex = 3
        Me.BtnInfo.Text = "Info"
        Me.BtnInfo.UseVisualStyleBackColor = True
        '
        'BtnOrder
        '
        Me.BtnOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOrder.Location = New System.Drawing.Point(590, 697)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(75, 50)
        Me.BtnOrder.TabIndex = 4
        Me.BtnOrder.Text = "Order"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'BtnPay
        '
        Me.BtnPay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPay.Location = New System.Drawing.Point(671, 697)
        Me.BtnPay.Name = "BtnPay"
        Me.BtnPay.Size = New System.Drawing.Size(75, 50)
        Me.BtnPay.TabIndex = 5
        Me.BtnPay.Text = "Pay"
        Me.BtnPay.UseVisualStyleBackColor = True
        '
        'LblText
        '
        Me.LblText.AutoSize = True
        Me.LblText.Location = New System.Drawing.Point(289, 131)
        Me.LblText.Name = "LblText"
        Me.LblText.Size = New System.Drawing.Size(94, 15)
        Me.LblText.TabIndex = 6
        Me.LblText.Text = "Cual es su edad?"
        '
        'nudEdad
        '
        Me.nudEdad.Location = New System.Drawing.Point(289, 149)
        Me.nudEdad.Name = "nudEdad"
        Me.nudEdad.Size = New System.Drawing.Size(120, 23)
        Me.nudEdad.TabIndex = 7
        '
        'BtnEdad
        '
        Me.BtnEdad.Location = New System.Drawing.Point(308, 178)
        Me.BtnEdad.Name = "BtnEdad"
        Me.BtnEdad.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdad.TabIndex = 8
        Me.BtnEdad.Text = "Continuar"
        Me.BtnEdad.UseVisualStyleBackColor = True
        '
        'TbxName
        '
        Me.TbxName.Location = New System.Drawing.Point(183, 149)
        Me.TbxName.Name = "TbxName"
        Me.TbxName.Size = New System.Drawing.Size(100, 23)
        Me.TbxName.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cual es su nombre?"
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbxName)
        Me.Controls.Add(Me.BtnEdad)
        Me.Controls.Add(Me.nudEdad)
        Me.Controls.Add(Me.LblText)
        Me.Controls.Add(Me.BtnPay)
        Me.Controls.Add(Me.BtnOrder)
        Me.Controls.Add(Me.BtnInfo)
        Me.Controls.Add(Me.btnDessert)
        Me.Controls.Add(Me.btnDrink)
        Me.Controls.Add(Me.btnFood)
        Me.Name = "FrmInicio"
        Me.Text = "Form1"
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFood As Button
    Friend WithEvents btnDrink As Button
    Friend WithEvents btnDessert As Button
    Friend WithEvents BtnInfo As Button
    Friend WithEvents BtnOrder As Button
    Friend WithEvents BtnPay As Button
    Friend WithEvents LblText As Label
    Friend WithEvents nudEdad As NumericUpDown
    Friend WithEvents BtnEdad As Button
    Friend WithEvents TbxName As TextBox
    Friend WithEvents Label1 As Label
End Class
