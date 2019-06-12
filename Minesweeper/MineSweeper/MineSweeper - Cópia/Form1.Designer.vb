<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tabuleiro
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FacilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DificilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelMinas = New System.Windows.Forms.Label()
        Me.LabelRelogio = New System.Windows.Forms.Label()
        Me.Recomecar = New System.Windows.Forms.Button()
        Me.PanelMine = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(341, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'JogoToolStripMenuItem
        '
        Me.JogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.ToolStripMenuItem1, Me.FacilToolStripMenuItem, Me.MedioToolStripMenuItem, Me.DificilToolStripMenuItem, Me.ToolStripMenuItem2, Me.ScoreToolStripMenuItem})
        Me.JogoToolStripMenuItem.Name = "JogoToolStripMenuItem"
        Me.JogoToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.JogoToolStripMenuItem.Text = "&Jogo"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NovoToolStripMenuItem.Text = "&Novo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'FacilToolStripMenuItem
        '
        Me.FacilToolStripMenuItem.Name = "FacilToolStripMenuItem"
        Me.FacilToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FacilToolStripMenuItem.Text = "&Facil V"
        '
        'MedioToolStripMenuItem
        '
        Me.MedioToolStripMenuItem.Name = "MedioToolStripMenuItem"
        Me.MedioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MedioToolStripMenuItem.Text = "&Medio"
        '
        'DificilToolStripMenuItem
        '
        Me.DificilToolStripMenuItem.Name = "DificilToolStripMenuItem"
        Me.DificilToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DificilToolStripMenuItem.Text = "&Dificil"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'ScoreToolStripMenuItem
        '
        Me.ScoreToolStripMenuItem.Name = "ScoreToolStripMenuItem"
        Me.ScoreToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ScoreToolStripMenuItem.Text = "Score"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelMinas, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelRelogio, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Recomecar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelMine, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(341, 380)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'LabelMinas
        '
        Me.LabelMinas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelMinas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelMinas.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMinas.Location = New System.Drawing.Point(9, 9)
        Me.LabelMinas.Margin = New System.Windows.Forms.Padding(9)
        Me.LabelMinas.Name = "LabelMinas"
        Me.LabelMinas.Size = New System.Drawing.Size(122, 42)
        Me.LabelMinas.TabIndex = 0
        Me.LabelMinas.Text = "0"
        Me.LabelMinas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelRelogio
        '
        Me.LabelRelogio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelRelogio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelRelogio.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRelogio.Location = New System.Drawing.Point(209, 9)
        Me.LabelRelogio.Margin = New System.Windows.Forms.Padding(9)
        Me.LabelRelogio.Name = "LabelRelogio"
        Me.LabelRelogio.Size = New System.Drawing.Size(123, 42)
        Me.LabelRelogio.TabIndex = 1
        Me.LabelRelogio.Text = "0"
        Me.LabelRelogio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Recomecar
        '
        Me.Recomecar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Recomecar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Recomecar.Location = New System.Drawing.Point(149, 9)
        Me.Recomecar.Margin = New System.Windows.Forms.Padding(9)
        Me.Recomecar.Name = "Recomecar"
        Me.Recomecar.Size = New System.Drawing.Size(42, 42)
        Me.Recomecar.TabIndex = 2
        Me.Recomecar.Text = "O_O"
        Me.Recomecar.UseVisualStyleBackColor = False
        '
        'PanelMine
        '
        Me.PanelMine.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.PanelMine, 3)
        Me.PanelMine.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PanelMine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMine.Location = New System.Drawing.Point(9, 69)
        Me.PanelMine.Margin = New System.Windows.Forms.Padding(9)
        Me.PanelMine.Name = "PanelMine"
        Me.PanelMine.Size = New System.Drawing.Size(323, 302)
        Me.PanelMine.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Tabuleiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 404)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tabuleiro"
        Me.Text = "Minesweeper"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelMinas As System.Windows.Forms.Label
    Friend WithEvents LabelRelogio As System.Windows.Forms.Label
    Friend WithEvents Recomecar As System.Windows.Forms.Button
    Friend WithEvents PanelMine As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents JogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FacilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DificilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ScoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
