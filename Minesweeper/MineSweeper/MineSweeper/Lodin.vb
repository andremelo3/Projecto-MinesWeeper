Public Class Lodin

    Private Sub Lodin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()


        If Not System.IO.Directory.Exists(Globais.pasta) Then
            System.IO.Directory.CreateDirectory(Globais.pasta)
        End If

        If Not System.IO.File.Exists(Globais.pasta + "\" + Globais.Gravado) Then
            System.IO.File.Create(Globais.pasta + "\" + Globais.Gravado)
        End If
        Me.Close()

    End Sub
End Class