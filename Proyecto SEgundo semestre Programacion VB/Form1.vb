
Public Class FrmInicio

    Public Structure Datos
        Public edad As Integer
        Public nombre As String
    End Structure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFood.Click
        Dim formulario As New Form2()
        formulario.ShowDialog()
    End Sub



    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnFood.Visible = False
        btnDessert.Visible = False
        btnDrink.Visible = False
    End Sub

    Private Sub BtnDrink_Click(sender As Object, e As EventArgs) Handles btnDrink.Click
        Dim formulario As New Form3()
        formulario.ShowDialog()
    End Sub

    Private Sub BtnDessert_Click(sender As Object, e As EventArgs) Handles btnDessert.Click
        Dim formulario As New Form4()
        formulario.ShowDialog()
    End Sub

    Private Sub BtnEdad_Click(sender As Object, e As EventArgs) Handles BtnEdad.Click
        Dim info As Datos
        info.edad = nudEdad.Value
        info.nombre = TbxName.Text
        While info.edad = 0
            MessageBox.Show("No a ingresado su edad")

        End While
        While info.nombre = ""
            MessageBox.Show("No a ingrsado su nombre")
        End While

        Dim edad As Integer = nudEdad.Value
        If edad <= 10 Then
            MessageBox.Show("Su edad es muy poca para poder usar este programa")
        ElseIf edad >= 11 Then
            btnDessert.Visible = True
            btnDrink.Visible = True
            btnFood.Visible = True
        End If
        LblText.Visible = False
        BtnEdad.Visible = False
        nudEdad.Visible = False


    End Sub

End Class
