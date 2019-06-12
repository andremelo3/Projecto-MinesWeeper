Public Class Score

    Private Sub Score_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ValoresScore()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        Globais.Fprimeiro = 0
        Globais.Fsecundo = 0
        Globais.Fterceiro = 0

        Globais.Mprimeiro = 0
        Globais.Msecundo = 0
        Globais.Mterceiro = 0

        Globais.Dprimeiro = 0
        Globais.Dsecundo = 0
        Globais.Dterceiro = 0

        ValoresScore()

    End Sub

    Private Sub ValoresScore()
        Facil1.Text = "1º - " & Globais.Fprimeiro & " segundos"
        Facil2.Text = "2º - " & Globais.Fsecundo & " segundos"
        Facil3.Text = "3º - " & Globais.Fterceiro & " segundos"

        Medio1.Text = "1º - " & Globais.Mprimeiro & " segundos"
        Medio2.Text = "2º - " & Globais.Msecundo & " segundos"
        Medio3.Text = "3º - " & Globais.Mterceiro & " segundos"

        Dificil1.Text = "1º - " & Globais.Dprimeiro & " segundos"
        Dificil2.Text = "2º - " & Globais.Dsecundo & " segundos"
        Dificil3.Text = "3º - " & Globais.Dterceiro & " segundos"
    End Sub
End Class