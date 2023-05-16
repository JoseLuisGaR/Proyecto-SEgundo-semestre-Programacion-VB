Public Class Form2
    Private Sub BtnTacosAlPastor_Clic(sender As Object, e As EventArgs) Handles BtnTacosAlPastor.Click
        BtnTacosAlPastor.Visible = False
        BtnChilaquiles.Visible = False
        BtnTamales.Visible = False
        BtnPozole.Visible = False
        BtnGringa.Visible = False
        BtnBarbacoa.Visible = False

        BtnOpcion1.Text = "Harina"
        BtnOpcion1.Visible = True
        BtnOpcion2.Text = "Maiz"
        BtnOpcion2.Visible = True
        LblText.Text = "Cuantos Tacos al Pastor le gustaria pedir?"
        nudNumeroDePedidos.Visible = True
        LblText.Visible = True
        nudNumeroDePedidos.Maximum = 15
        nudNumeroDePedidos.Minimum = 5
        nudNumeroDePedidos.Increment = 5
        nudNumeroDePedidos.Visible = True
        LblText2.Text = "Tortilla de Harina o Maiz?"
        LblText2.Visible = True

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnOpcion1.Visible = False
        BtnOpcion2.Visible = False
        BtnOpcion3.Visible = False
        nudNumeroDePedidos.Visible = False
        LblText.Visible = False
        LblText2.Visible = False
    End Sub

    Private Sub BtnChilaquiles_Click(sender As Object, e As EventArgs) Handles BtnChilaquiles.Click
        'btn para abriri la opcion de chilaquiles y modificar las opciones y el numero maximo , minimo y de incremento del pedido
        BtnTacosAlPastor.Visible = False
        BtnChilaquiles.Visible = False
        BtnTamales.Visible = False
        BtnPozole.Visible = False
        BtnGringa.Visible = False
        BtnBarbacoa.Visible = False
        BtnOpcion1.Text = "Salsa verde"
        BtnOpcion1.Visible = True
        BtnOpcion2.Text = "Salsa roja"
        BtnOpcion2.Visible = True
        LblText.Text = "Cuantos platos de Chilaquiles le gustaria pedir?"
        nudNumeroDePedidos.Maximum = 5
        nudNumeroDePedidos.Minimum = 1
        nudNumeroDePedidos.Increment = 1
        LblText2.Text = "Que tipo de Chilaquiles le gustaria pedir?"
        LblText2.Visible = True
        nudNumeroDePedidos.Maximum = 5
        nudNumeroDePedidos.Minimum = 1
        nudNumeroDePedidos.Increment = 1
        nudNumeroDePedidos.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'flecha para regresar al menu de comidas
        BtnTacosAlPastor.Visible = True
        BtnChilaquiles.Visible = True
        BtnTamales.Visible = True
        BtnPozole.Visible = True
        BtnGringa.Visible = True
        BtnBarbacoa.Visible = True
        BtnOpcion1.Visible = False
        BtnOpcion2.Visible = False
        BtnOpcion3.Visible = False
        LblText.Visible = False
        LblText2.Visible = False
        nudNumeroDePedidos.Visible = False

    End Sub

    Private Sub BtnOpcion2_Click(sender As Object, e As EventArgs) Handles BtnOpcion2.Click

    End Sub

    Private Sub BtnTamales_Click(sender As Object, e As EventArgs) Handles BtnTamales.Click
        BtnTacosAlPastor.Visible = False
        BtnChilaquiles.Visible = False
        BtnTamales.Visible = False
        BtnPozole.Visible = False
        BtnGringa.Visible = False
        BtnBarbacoa.Visible = False
        BtnOpcion1.Text = "Puerco"
        BtnOpcion1.Visible = True
        BtnOpcion2.Text = "Pollo"
        BtnOpcion2.Visible = True
        BtnOpcion3.Text = "Frijoles"
        BtnOpcion3.Visible = True
        LblText.Text = "Cuantos Tamales le gustaria pedir?"
        LblText.Visible = True
        LblText2.Text = "De que tipo le gustaria pedir?"
        LblText2.Visible = True
        nudNumeroDePedidos.Maximum = 24
        nudNumeroDePedidos.Minimum = 6
        nudNumeroDePedidos.Increment = 6
        nudNumeroDePedidos.Visible = True
    End Sub

    Private Sub BtnPozole_Click(sender As Object, e As EventArgs) Handles BtnPozole.Click
        BtnTacosAlPastor.Visible = False
        BtnChilaquiles.Visible = False
        BtnTamales.Visible = False
        BtnPozole.Visible = False
        BtnGringa.Visible = False
        BtnBarbacoa.Visible = False
        BtnOpcion1.Text = "Rojo"
        BtnOpcion1.Visible = True
        BtnOpcion2.Text = "Verde"
        BtnOpcion2.Visible = True
        BtnOpcion3.Text = "Blanco"
        BtnOpcion3.Visible = True
        LblText.Text = "Cuantos platos de pozole le gustaria pedir?"
        LblText2.Text = "De que tipo le gustaria pedir?"
        nudNumeroDePedidos.Maximum = 5
        nudNumeroDePedidos.Minimum = 1
        nudNumeroDePedidos.Increment = 1
        nudNumeroDePedidos.Visible = True
        LblText.Visible = True
        LblText2.Visible = True
    End Sub

    Private Sub BtnGringa_Click(sender As Object, e As EventArgs) Handles BtnGringa.Click
        BtnTacosAlPastor.Visible = False
        BtnChilaquiles.Visible = False
        BtnTamales.Visible = False
        BtnPozole.Visible = False
        BtnGringa.Visible = False
        BtnBarbacoa.Visible = False
        LblText.Text = "Cuantas Gringas le gustaria pedir?"
        BtnOpcion1.Text = "Si"
        BtnOpcion2.Text = "No"
        BtnOpcion1.Visible = True
        BtnOpcion2.Visible = True
        BtnOpcion3.Visible = False
        nudNumeroDePedidos.Maximum = 5
        nudNumeroDePedidos.Minimum = 1
        nudNumeroDePedidos.Increment = 1
        nudNumeroDePedidos.Visible = True
        LblText.Visible = True
        LblText2.Visible = True
        LblText2.Text = "La ponemos cilatro y cebolla?"

    End Sub

    Private Sub BtnBarbacoa_Click(sender As Object, e As EventArgs) Handles BtnBarbacoa.Click
        BtnTacosAlPastor.Visible = False
        BtnChilaquiles.Visible = False
        BtnTamales.Visible = False
        BtnPozole.Visible = False
        BtnGringa.Visible = False
        BtnBarbacoa.Visible = False
        BtnOpcion1.Text = "Harina"
        BtnOpcion1.Visible = True
        BtnOpcion2.Text = "Maiz"
        BtnOpcion2.Visible = True
        LblText.Text = "Cuantos platos de Barbacoa le gustaria pedir?"
        nudNumeroDePedidos.Visible = True
        LblText.Visible = True
        nudNumeroDePedidos.Maximum = 5
        nudNumeroDePedidos.Minimum = 1
        nudNumeroDePedidos.Increment = 1
        nudNumeroDePedidos.Visible = True
        LblText2.Text = "Con tortillas de Harina o Maiz?"
        LblText2.Visible = True

    End Sub
End Class