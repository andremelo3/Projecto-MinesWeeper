Public Class Tabuleiro
    Dim CellSize As Integer = 25
    Dim BoardRows As Integer = 9
    Dim BoardCols As Integer = 9
    Dim MinasJogo As Integer = 10
    Dim Secundos As Integer = 0
    Dim MinasMarcadas As Integer = 0
    Dim MineField(8, 8) As MineCell


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        BuildBoard()

    End Sub

    Private Sub BuildBoard()
        PanelMine.Enabled = True
        Secundos = 0
        Timer1.Enabled = False
        MinasMarcadas = 0
        DoLabels()

        Me.Hide()
        carregar()
        'loop entre as colunas e linhas
        ReDim MineField(BoardRows - 1, BoardCols - 1)
        PanelMine.Controls.Clear()
        For Row As Integer = 0 To BoardRows - 1
            For col As Integer = 0 To BoardCols - 1
                Dim C As New MineCell
                PanelMine.Controls.Add(C)
                C.Left = CellSize * col
                C.Top = CellSize * Row
                C.Width = CellSize
                C.Height = CellSize
                C.TivouMina = False
                C.Numero = 0
                C.X = col
                C.Y = Row
                MineField(Row, col) = C
                AddHandler C.MouseClick, AddressOf MineClick
            Next
        Next

        'Random Mine
        Dim RX As New Random
        For i As Integer = 1 To MinasJogo
            Dim X As Integer = 0
            Dim Y As Integer = 0
            Do
                X = RX.Next(0, BoardCols)
                Y = RX.Next(0, BoardRows)

            Loop Until Not MineField(Y, X).TivouMina
            MineField(Y, X).TivouMina = True
            'CHEATS
            'MineField(Y, X).Ver = MineCell.VisaoMineCell.Mina
            'MineField(Y, X).ButtonColor = Color.Red
        Next

        'Contar as Minas
        For Row As Integer = 0 To BoardRows - 1
            For Col As Integer = 0 To BoardCols - 1
                If Not MineField(Row, Col).TivouMina Then
                    For R As Integer = Row - 1 To Row + 1
                        For C As Integer = Col - 1 To Col + 1
                            If R >= 0 And R < BoardRows And C >= 0 And C < BoardCols And Not (Row = R And Col = C) Then
                                If MineField(R, C).TivouMina Then
                                    MineField(Row, Col).Numero += 1
                                End If
                            End If
                        Next
                    Next
                End If
                'CHEATS
                'If MineField(Row, Col).Numero > 0 Then MineField(Row, Col).Ver = MineCell.VisaoMineCell.Numero
                'If MineField(Row, Col).Numero > 0 Then MineField(Row, Col).ButtonColor = Color.Green
            Next
        Next


        'Dimencionar o Painel
        Me.Width = BoardCols * CellSize
        Do Until Me.PanelMine.Width = BoardCols * CellSize
            Me.Width += 1
        Loop
        Me.Height = BoardRows * CellSize
        Do Until Me.PanelMine.Height = BoardRows * CellSize
            Me.Height += 1
        Loop


        Me.Show()
    End Sub

    Private Sub ComecarJogo(ByVal Rows As Integer, ByVal Cols As Integer, ByVal Minas As Integer)
        BoardCols = Cols
        BoardRows = Rows
        MinasJogo = Minas
        BuildBoard()
    End Sub

    Private Sub Recomecar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Recomecar.Click, NovoToolStripMenuItem.Click
        BuildBoard()
    End Sub

    Private Sub MineClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim M As MineCell = sender
        Timer1.Enabled = True

        If e.Button = Windows.Forms.MouseButtons.Left Then
            If M.TivouMina Then
                For r As Integer = 0 To BoardRows - 1
                    For c As Integer = 0 To BoardCols - 1
                        Dim CC As MineCell = MineField(c, r)
                        If CC.TivouMina Then
                            CC.Ver = MineCell.VisaoMineCell.Mina
                            CC.Refresh()
                            Timer1.Enabled = False
                            PanelMine.Enabled = False
                        End If
                    Next
                Next

            ElseIf M.Numero > 0 Then
                M.Ver = MineCell.VisaoMineCell.Numero
                M.Refresh()
                If Ganhar() Then
                    Timer1.Enabled = False
                    PanelMine.Enabled = False
                    Posicao()
                    Guardar()
                End If
            ElseIf M.Numero = 0 Then
                EspacoBranco(M)
                If Ganhar() Then
                    Timer1.Enabled = False
                    PanelMine.Enabled = False
                    Posicao()
                    Guardar()
                End If
            End If

            M.Enabled = False
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            Select Case M.Ver
                Case MineCell.VisaoMineCell.Botao
                    M.Ver = MineCell.VisaoMineCell.Bandeira
                    MinasMarcadas += 1
                    DoLabels()
                    M.Refresh()
                Case Else
                    M.Ver = MineCell.VisaoMineCell.Botao
                    MinasMarcadas -= 1
                    DoLabels()
                    M.Refresh()
            End Select
        End If
    End Sub

    Private Sub EspacoBranco(ByVal M As MineCell)
        M.Ver = MineCell.VisaoMineCell.Numero
        For R As Integer = M.Y - 1 To M.Y + 1
            For C As Integer = M.X - 1 To M.X + 1
                If R >= 0 And R < BoardRows And C >= 0 And C < BoardCols Then

                    Dim MC As MineCell = MineField(R, C)

                    If MC.Ver = MineCell.VisaoMineCell.Botao Then
                        If MC.Numero = 0 Then
                            EspacoBranco(MC)
                        Else
                            MC.Ver = MineCell.VisaoMineCell.Numero
                        End If
                    End If
                    MC.Refresh()
                    MC.Enabled = False
                End If
            Next
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Secundos += 1
        DoLabels()
    End Sub

    Private Sub DoLabels()
        LabelRelogio.Text = Secundos.ToString
        LabelMinas.Text = (MinasJogo - MinasMarcadas).ToString
    End Sub
    Private Function Ganhar()

        Dim Vitoria As Boolean = True
        For Each MC As MineCell In MineField
            If Not MC.TivouMina And Not MC.Ver = MineCell.VisaoMineCell.Numero Then
                Vitoria = False
            End If
        Next
        Return Vitoria
    End Function

    Private Sub FacilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacilToolStripMenuItem.Click
        Globais.Tamanho = 1
        FacilToolStripMenuItem.Text = "Facil *"
        MedioToolStripMenuItem.Text = "Medio"
        DificilToolStripMenuItem.Text = "Dificil"
        ComecarJogo(9, 9, 10)
    End Sub

    Private Sub MedioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedioToolStripMenuItem.Click
        Globais.Tamanho = 2
        FacilToolStripMenuItem.Text = "Facil"
        MedioToolStripMenuItem.Text = "Medio *"
        DificilToolStripMenuItem.Text = "Dificil"
        ComecarJogo(18, 18, 50)
    End Sub

    Private Sub DificilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DificilToolStripMenuItem.Click
        Globais.Tamanho = 3
        FacilToolStripMenuItem.Text = "Facil"
        MedioToolStripMenuItem.Text = "Medio"
        DificilToolStripMenuItem.Text = "Dificil *"
        ComecarJogo(22, 22, 75)
    End Sub

    Private Sub ScoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScoreToolStripMenuItem.Click
        Score.Show()
    End Sub
    Private Sub Posicao()
        Globais.teste = LabelRelogio.Text
        Select Case Globais.Tamanho
            Case 1

                If Globais.teste < Globais.Fprimeiro Or Globais.Fprimeiro = 0 Then
                    Globais.Fterceiro = Globais.Fsecundo
                    Globais.Fsecundo = Globais.Fprimeiro
                    Globais.Fprimeiro = Globais.teste
                ElseIf Globais.teste < Globais.Fsecundo Or Globais.Fsecundo = 0 Then
                    Globais.Fterceiro = Globais.Fsecundo
                    Globais.Fsecundo = Globais.teste
                ElseIf Globais.teste < Globais.Fterceiro Or Globais.Fterceiro = 0 Then
                    Globais.Fterceiro = Globais.teste
                End If
            Case 2
                If Globais.teste < Globais.Mprimeiro Or Globais.Mprimeiro = 0 Then
                    Globais.Mterceiro = Globais.Msecundo
                    Globais.Msecundo = Globais.Mprimeiro
                    Globais.Mprimeiro = Globais.teste
                ElseIf Globais.teste < Globais.Msecundo Or Globais.Msecundo = 0 Then
                    Globais.Mterceiro = Globais.Msecundo
                    Globais.Msecundo = Globais.teste
                ElseIf Globais.teste < Globais.Mterceiro Or Globais.Mterceiro = 0 Then
                    Globais.Mterceiro = Globais.teste
                End If
            Case Else
                If Globais.teste < Globais.Dprimeiro Or Globais.Dprimeiro = 0 Then
                    Globais.Dterceiro = Globais.Dsecundo
                    Globais.Dsecundo = Globais.Dprimeiro
                    Globais.Dprimeiro = Globais.teste
                ElseIf Globais.teste < Globais.Dsecundo Or Globais.Dsecundo = 0 Then
                    Globais.Dterceiro = Globais.Dsecundo
                    Globais.Dsecundo = Globais.teste
                ElseIf Globais.teste < Globais.Dterceiro Or Globais.Dterceiro = 0 Then
                    Globais.Dterceiro = Globais.teste
                End If
        End Select
    End Sub

    Private Sub ClassicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassicoToolStripMenuItem.Click
        Globais.ECor = Color.LightGray
        ClassicoToolStripMenuItem.Text = "Classico *"
        VerdeToolStripMenuItem.Text = "Verde"
        AzulToolStripMenuItem.Text = "Azul"
        VermelhoToolStripMenuItem.Text = "Vermelho"
        MagentaToolStripMenuItem.Text = "Magenta"
        Guardar()
        BuildBoard()
    End Sub

    Private Sub VerdeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerdeToolStripMenuItem.Click
        Globais.ECor = Color.Green
        ClassicoToolStripMenuItem.Text = "Classico"
        VerdeToolStripMenuItem.Text = "Verde *"
        AzulToolStripMenuItem.Text = "Azul"
        VermelhoToolStripMenuItem.Text = "Vermelho"
        MagentaToolStripMenuItem.Text = "Magenta"
        Guardar()
        BuildBoard()
    End Sub

    Private Sub AzulToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AzulToolStripMenuItem.Click
        Globais.ECor = Color.Blue
        ClassicoToolStripMenuItem.Text = "Classico"
        VerdeToolStripMenuItem.Text = "Verde"
        AzulToolStripMenuItem.Text = "Azul *"
        VermelhoToolStripMenuItem.Text = "Vermelho"
        MagentaToolStripMenuItem.Text = "Magenta"
        Guardar()
        BuildBoard()
    End Sub

    Private Sub VermelhoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VermelhoToolStripMenuItem.Click
        Globais.ECor = Color.Red
        ClassicoToolStripMenuItem.Text = "Classico"
        VerdeToolStripMenuItem.Text = "Verde"
        AzulToolStripMenuItem.Text = "Azul"
        VermelhoToolStripMenuItem.Text = "Vermelho *"
        MagentaToolStripMenuItem.Text = "Magenta"
        Guardar()
        BuildBoard()
    End Sub

    Private Sub MagentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagentaToolStripMenuItem.Click
        Globais.ECor = Color.Magenta
        ClassicoToolStripMenuItem.Text = "Classico"
        VerdeToolStripMenuItem.Text = "Verde"
        AzulToolStripMenuItem.Text = "Azul"
        VermelhoToolStripMenuItem.Text = "Vermelho"
        MagentaToolStripMenuItem.Text = "Magenta *"
        Guardar()
        BuildBoard()
    End Sub


    Private Sub carregar()
        Dim filereader As System.IO.StreamReader
        filereader = My.Computer.FileSystem.OpenTextFileReader(Globais.pasta + "\" + Globais.Gravado)
        Dim lugar As Integer

        lugar = CInt(filereader.ReadLine())
        Globais.Fprimeiro = lugar
        lugar = CInt(filereader.ReadLine())
        Globais.Fsecundo = lugar
        lugar = CInt(filereader.ReadLine())
        Globais.Fterceiro = lugar

        lugar = CInt(filereader.ReadLine())
        Globais.Mprimeiro = lugar
        lugar = CInt(filereader.ReadLine())
        Globais.Msecundo = lugar
        lugar = CInt(filereader.ReadLine())
        Globais.Mterceiro = lugar

        lugar = CInt(filereader.ReadLine())
        Globais.Dprimeiro = lugar
        lugar = CInt(filereader.ReadLine())
        Globais.Dsecundo = lugar
        lugar = CInt(filereader.ReadLine())
        Globais.Dterceiro = lugar

        filereader.Close()
    End Sub

    Private Sub Tabuleiro_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Guardar()
    End Sub

    Private Sub Guardar()
        'gravar pontuacoes
        Dim file As System.IO.StreamWriter = Nothing
        file = My.Computer.FileSystem.OpenTextFileWriter(Globais.pasta + "\" + Globais.Gravado, False)
        file.WriteLine(Globais.Fprimeiro)
        file.WriteLine(Globais.Fsecundo)
        file.WriteLine(Globais.Fterceiro)

        file.WriteLine(Globais.Mprimeiro)
        file.WriteLine(Globais.Msecundo)
        file.WriteLine(Globais.Mterceiro)

        file.WriteLine(Globais.Dprimeiro)
        file.WriteLine(Globais.Dsecundo)
        file.WriteLine(Globais.Dterceiro)
        file.Close()
    End Sub

End Class
