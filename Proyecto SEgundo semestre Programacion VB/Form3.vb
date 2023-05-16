Imports System.Windows

Public Class Form3
    Inherits FrmInicio



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblText.Visible = False
        LblText2.Visible = False
        nudNumeroDePedidos.Visible = False
        BtnOpcion1.Visible = False
        BtnOpcion2.Visible = False
        BtnOpcion3.Visible = False
        Dim edad As Integer = RevisionEdad


        If edad <= 17 Then
            BtnBebidasAlcoholicas.Visible = False
            BtnAguasMineralizadas.Location = New Point(12, 12)
        Else
            BtnBebidasAlcoholicas.Visible = True
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim edad As Integer = RevisionEdad
        If edad <= 17 Then
            LblText.Visible = False
            LblText2.Visible = False
            nudNumeroDePedidos.Visible = False
            BtnOpcion1.Visible = False
            BtnOpcion2.Visible = False
            BtnOpcion3.Visible = False
            BtnAguasDeSabor.Visible = True
            BtnAguasMineralizadas.Visible = True
            BtnBebidasAlcoholicas.Visible = False
            BtnGaseosas.Visible = True
        Else
            LblText.Visible = False
            LblText2.Visible = False
            nudNumeroDePedidos.Visible = False
            BtnOpcion1.Visible = False
            BtnOpcion2.Visible = False
            BtnOpcion3.Visible = False
            BtnAguasDeSabor.Visible = True
            BtnAguasMineralizadas.Visible = True
            BtnBebidasAlcoholicas.Visible = True
            BtnGaseosas.Visible = True
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnGaseosas.Click
        LblText.Text = "Cuantas Gaseosas le gustaria pedir?"
        LblText.Text = "Que Gaseosa le gustaria pedir?"
        BtnOpcion1.Text = "Coca Cola"
        BtnOpcion2.Text = "Sprite"
        BtnOpcion3.Text = "Fanta"
        nudNumeroDePedidos.Maximum = 5
        nudNumeroDePedidos.Minimum = 1
        nudNumeroDePedidos.Increment = 1
        LblText.Visible = True
        LblText2.Visible = True
        nudNumeroDePedidos.Visible = True
        BtnOpcion1.Visible = True
        BtnOpcion2.Visible = True
        BtnOpcion3.Visible = True
        BtnAguasDeSabor.Visible = False
        BtnAguasMineralizadas.Visible = False
        BtnBebidasAlcoholicas.Visible = False
        BtnGaseosas.Visible = False

    End Sub
End Class