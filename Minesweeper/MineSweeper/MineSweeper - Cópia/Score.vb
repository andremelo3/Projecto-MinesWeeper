Public Class Score

    Private Sub Score_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Facil1.Text = "1º - " & Globais.Fprimeiro & " secundos"
        Facil2.Text = "2º - " & Globais.Fsecundo & " secundos"
        Facil3.Text = "3º - " & Globais.Fterceiro & " secundos"

        Medio1.Text = "1º - " & Globais.Mprimeiro & " secundos"
        Medio2.Text = "2º - " & Globais.Msecundo & " secundos"
        Medio3.Text = "3º - " & Globais.Mterceiro & " secundos"

        Dificil1.Text = "1º - " & Globais.Dprimeiro & " secundos"
        Dificil2.Text = "2º - " & Globais.Dsecundo & " secundos"
        Dificil3.Text = "3º - " & Globais.Dterceiro & " secundos"
    End Sub

End Class