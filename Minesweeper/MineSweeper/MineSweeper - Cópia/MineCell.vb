Public Class MineCell
    'Enumeracoes para MineCell
    Public Enum VisaoMineCell
        Botao
        Mina
        Numero
        Bandeira
    End Enum
    'valores do Campo
    Private mView As VisaoMineCell
    Private mNumero As Integer
    Private mTivouMina As Boolean
    Private myX As Integer
    Private myY As Integer
    Private mButtonColor As Color = Color.LightGray

    'Propriedades
    Public Property ButtonColor() As Color
        Get
            Return mButtonColor
        End Get
        Set(ByVal value As Color)
            mButtonColor = value
        End Set
    End Property
    Public Property TivouMina() As Boolean
        Get
            Return mTivouMina
        End Get
        Set(ByVal value As Boolean)
            mTivouMina = value
        End Set
    End Property

    Public Property X() As Integer
        Get
            Return myX
        End Get
        Set(ByVal value As Integer)
            myX = value
        End Set
    End Property


    Public Property Y() As Integer
        Get
            Return myY
        End Get
        Set(ByVal value As Integer)
            myY = value
        End Set
    End Property

    Public Property Numero As Integer
        Get
            Return mNumero
        End Get
        Set(ByVal value As Integer)
            mNumero = value
            Me.Invalidate()
        End Set
    End Property


    Public Property Ver As VisaoMineCell
        Get
            Return mView
        End Get
        Set(ByVal value As VisaoMineCell)
            mView = value
        End Set
    End Property

    Private Sub MineCell_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Select Case mView
            Case VisaoMineCell.Mina
                With e.Graphics
                    .ResetTransform()
                    .TranslateTransform(Me.Width / 2, Me.Height / 2)
                    .ScaleTransform(Me.Width / 2, Me.Height / 2)
                    .Clear(Color.WhiteSmoke)

                    'Circulo
                    Dim CRect As New RectangleF(-0.6, -0.6, 1.2, 1.2)
                    Dim CBrush As New SolidBrush(Color.Black)
                    .FillEllipse(CBrush, CRect)

                    'Picos
                    Dim IRad As Single = 0.5
                    Dim ERad As Single = 0.8
                    Dim PPen As New Pen(Color.Black, 0.15)
                    PPen.EndCap = Drawing2D.LineCap.Round 'Formato das Pontas
                    For Angulo As Single = 0 To 1.75 * Math.PI Step 0.25 * Math.PI
                        Dim Interior As New PointF(IRad * Math.Cos(Angulo), IRad * Math.Sin(Angulo))
                        Dim Esterior As New PointF(ERad * Math.Cos(Angulo), ERad * Math.Sin(Angulo))
                        .DrawLine(PPen, Interior, Esterior)
                    Next

                    'Brilho
                    Dim HRect As New RectangleF(-0.3, -0.3, 0.2, 0.2)
                    Dim WBrush As New SolidBrush(Color.White)
                    .FillRectangle(WBrush, HRect)

                    'Contronos da caixa da mina
                    Dim BRect As New Rectangle(-1, -1, 2, 2)
                    Dim BPen As New Pen(Color.Gray, 0.05)
                    .DrawRectangle(BPen, BRect)


                End With

            Case VisaoMineCell.Numero
                Dim NColors() As Color = {Color.Blue, Color.Green, Color.Red, Color.Navy, Color.DarkGreen, Color.DarkRed, Color.Brown, Color.Black}
                With e.Graphics
                    .ResetTransform()
                    .TranslateTransform(Me.Width / 2, Me.Height / 2)
                    .ScaleTransform(Me.Width / 2, Me.Height / 2)
                    .Clear(Color.WhiteSmoke)

                    'Sair o Numero
                    If mNumero > 0 And mNumero <= 8 Then
                        Dim NBrush As New SolidBrush(NColors(mNumero - 1))
                        Dim myFont As New Font("Times", 1.5, FontStyle.Bold, GraphicsUnit.World)
                        Dim SS As SizeF = .MeasureString(mNumero.ToString, myFont)
                        .DrawString(mNumero.ToString, myFont, NBrush, -SS.Width / 2, -SS.Height / 2)
                    End If

                    'Controno da caixa
                    Dim BRect As New Rectangle(-1, -1, 2, 2)
                    Dim BPen As New Pen(Color.Gray, 0.05)
                    .DrawRectangle(BPen, BRect)


                End With

            Case VisaoMineCell.Bandeira
                With e.Graphics
                    .ResetTransform()
                    .TranslateTransform(Me.Width / 2, Me.Height / 2)
                    .ScaleTransform(Me.Width / 2, Me.Height / 2)
                    .Clear(Color.LightGray)

                    'Contronos
                    Dim TopLeft As New Point(-1, -1)
                    Dim TopRight As New Point(1, -1)
                    Dim BotLeft As New Point(-1, 1)
                    Dim BotRight As New Point(1, 1)

                    Dim mPen As New Pen(Color.Gray, 0.3)
                    .DrawLine(mPen, BotRight, BotLeft)
                    .DrawLine(mPen, BotRight, TopRight)

                    mPen = New Pen(Color.White, 0.3)
                    .DrawLine(mPen, TopLeft, BotLeft)
                    .DrawLine(mPen, TopLeft, TopRight)

                    'Pontos da Bandeira
                    Dim PoleTop As New PointF(0, -0.7)
                    Dim PoleBottom As New PointF(0, 0.5)
                    Dim FlagTip As New Point(-0.7, -0.3)
                    Dim FlagBottom As New PointF(0, 0.1)
                    Dim BaseBT As New PointF(-0.5, 0.5)
                    Dim BaseBL As New PointF(-0.7, 0.7)
                    Dim BaseTR As New PointF(0.5, 0.5)
                    Dim BaseBR As New PointF(0.7, 0.7)

                    'pole
                    mPen = New Pen(Color.Brown, 0.1)
                    .DrawLine(mPen, PoleTop, PoleBottom)

                    'Bandeira
                    Dim FPts() As PointF = {PoleTop, FlagTip, FlagBottom}
                    Dim FBrush As New SolidBrush(Color.Red)
                    .FillPolygon(FBrush, FPts)

                    'Base
                    Dim BPts() As PointF = {BaseBL, BaseBT, BaseTR, BaseBR}
                    FBrush.Color = Color.Black
                    .FillPolygon(FBrush, BPts)

                End With

            Case VisaoMineCell.Botao
                With e.Graphics
                    .ResetTransform()
                    .TranslateTransform(Me.Width / 2, Me.Height / 2)
                    .ScaleTransform(Me.Width / 2, Me.Height / 2)
                    .Clear(mButtonColor)

                    'Contronos
                    Dim TopLeft As New Point(-1, -1)
                    Dim TopRight As New Point(1, -1)
                    Dim BotLeft As New Point(-1, 1)
                    Dim BotRight As New Point(1, 1)

                    Dim mPen As New Pen(Color.Gray, 0.3)
                    .DrawLine(mPen, BotRight, BotLeft)
                    .DrawLine(mPen, BotRight, TopRight)

                    mPen = New Pen(Color.White, 0.3)
                    .DrawLine(mPen, TopLeft, BotLeft)
                    .DrawLine(mPen, TopLeft, TopRight)
                End With
        End Select
    End Sub
End Class
