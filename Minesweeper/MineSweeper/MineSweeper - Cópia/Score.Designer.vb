<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Score
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Facil1 = New System.Windows.Forms.Label()
        Me.Facil2 = New System.Windows.Forms.Label()
        Me.Facil3 = New System.Windows.Forms.Label()
        Me.Medio3 = New System.Windows.Forms.Label()
        Me.Medio2 = New System.Windows.Forms.Label()
        Me.Medio1 = New System.Windows.Forms.Label()
        Me.Dificil3 = New System.Windows.Forms.Label()
        Me.Dificil2 = New System.Windows.Forms.Label()
        Me.Dificil1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FACIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MEDIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DIFICIL"
        '
        'Facil1
        '
        Me.Facil1.AutoSize = True
        Me.Facil1.Location = New System.Drawing.Point(19, 50)
        Me.Facil1.Name = "Facil1"
        Me.Facil1.Size = New System.Drawing.Size(39, 13)
        Me.Facil1.TabIndex = 3
        Me.Facil1.Text = "Label4"
        '
        'Facil2
        '
        Me.Facil2.AutoSize = True
        Me.Facil2.Location = New System.Drawing.Point(19, 85)
        Me.Facil2.Name = "Facil2"
        Me.Facil2.Size = New System.Drawing.Size(39, 13)
        Me.Facil2.TabIndex = 4
        Me.Facil2.Text = "Label5"
        '
        'Facil3
        '
        Me.Facil3.AutoSize = True
        Me.Facil3.Location = New System.Drawing.Point(19, 120)
        Me.Facil3.Name = "Facil3"
        Me.Facil3.Size = New System.Drawing.Size(39, 13)
        Me.Facil3.TabIndex = 5
        Me.Facil3.Text = "Label6"
        '
        'Medio3
        '
        Me.Medio3.AutoSize = True
        Me.Medio3.Location = New System.Drawing.Point(211, 120)
        Me.Medio3.Name = "Medio3"
        Me.Medio3.Size = New System.Drawing.Size(39, 13)
        Me.Medio3.TabIndex = 8
        Me.Medio3.Text = "Label6"
        '
        'Medio2
        '
        Me.Medio2.AutoSize = True
        Me.Medio2.Location = New System.Drawing.Point(211, 85)
        Me.Medio2.Name = "Medio2"
        Me.Medio2.Size = New System.Drawing.Size(39, 13)
        Me.Medio2.TabIndex = 7
        Me.Medio2.Text = "Label5"
        '
        'Medio1
        '
        Me.Medio1.AutoSize = True
        Me.Medio1.Location = New System.Drawing.Point(211, 50)
        Me.Medio1.Name = "Medio1"
        Me.Medio1.Size = New System.Drawing.Size(39, 13)
        Me.Medio1.TabIndex = 6
        Me.Medio1.Text = "Label4"
        '
        'Dificil3
        '
        Me.Dificil3.AutoSize = True
        Me.Dificil3.Location = New System.Drawing.Point(394, 120)
        Me.Dificil3.Name = "Dificil3"
        Me.Dificil3.Size = New System.Drawing.Size(39, 13)
        Me.Dificil3.TabIndex = 11
        Me.Dificil3.Text = "Label6"
        '
        'Dificil2
        '
        Me.Dificil2.AutoSize = True
        Me.Dificil2.Location = New System.Drawing.Point(394, 85)
        Me.Dificil2.Name = "Dificil2"
        Me.Dificil2.Size = New System.Drawing.Size(39, 13)
        Me.Dificil2.TabIndex = 10
        Me.Dificil2.Text = "Label5"
        '
        'Dificil1
        '
        Me.Dificil1.AutoSize = True
        Me.Dificil1.Location = New System.Drawing.Point(394, 50)
        Me.Dificil1.Name = "Dificil1"
        Me.Dificil1.Size = New System.Drawing.Size(39, 13)
        Me.Dificil1.TabIndex = 9
        Me.Dificil1.Text = "Label4"
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 311)
        Me.Controls.Add(Me.Dificil3)
        Me.Controls.Add(Me.Dificil2)
        Me.Controls.Add(Me.Dificil1)
        Me.Controls.Add(Me.Medio3)
        Me.Controls.Add(Me.Medio2)
        Me.Controls.Add(Me.Medio1)
        Me.Controls.Add(Me.Facil3)
        Me.Controls.Add(Me.Facil2)
        Me.Controls.Add(Me.Facil1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Score"
        Me.Text = "Pontuação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Facil1 As System.Windows.Forms.Label
    Friend WithEvents Facil2 As System.Windows.Forms.Label
    Friend WithEvents Facil3 As System.Windows.Forms.Label
    Friend WithEvents Medio3 As System.Windows.Forms.Label
    Friend WithEvents Medio2 As System.Windows.Forms.Label
    Friend WithEvents Medio1 As System.Windows.Forms.Label
    Friend WithEvents Dificil3 As System.Windows.Forms.Label
    Friend WithEvents Dificil2 As System.Windows.Forms.Label
    Friend WithEvents Dificil1 As System.Windows.Forms.Label
End Class
