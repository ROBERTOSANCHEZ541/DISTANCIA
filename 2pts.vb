Public Class Form1
    Inherits Coordenadas
    'clase hijo
    Private Sub BtnCalcula_Click(sender As Object, e As EventArgs) Handles btnCalcula.Click

        CoordX1 = txtx1.Text
        CoordX2 = txtx2.Text
        CoordY1 = txty1.Text
        CoordY2 = txty2.Text
        'txtD.Text = Math.Round(Math.Sqrt(Math.Pow(CoordX2 - CoordX1, 2) + Math.Pow(CoordY2 - CoordY1, 2)), 4)
        txtD.Text = Math.Sqrt((CoordX1 - CoordX2) * (CoordX1 - CoordX2) + (CoordY1 - CoordY2) * (CoordY1 - CoordY2))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Registre las cordenadas de los puntos en cada uno de los recuadros blancos")

    End Sub

    Public Sub New(X1 As Double, X2 As Double, Y1 As Double, Y2 As Double)
        MyBase.New(X1, X2, Y1, Y2)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtx1.Text = ""
        txtx2.Text = ""
        txty1.Text = ""
        txty2.Text = ""
        txtD.Text = ""

    End Sub

End Class
