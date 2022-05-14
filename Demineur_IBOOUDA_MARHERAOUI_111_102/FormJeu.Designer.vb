<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelChrono = New System.Windows.Forms.Label()
        Me.LabelTemps = New System.Windows.Forms.Label()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.LabelNomJoueur = New System.Windows.Forms.Label()
        Me.PanelJeu = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'LabelChrono
        '
        Me.LabelChrono.AutoSize = True
        Me.LabelChrono.Location = New System.Drawing.Point(170, 704)
        Me.LabelChrono.Name = "LabelChrono"
        Me.LabelChrono.Size = New System.Drawing.Size(18, 20)
        Me.LabelChrono.TabIndex = 64
        Me.LabelChrono.Text = "T"
        '
        'LabelTemps
        '
        Me.LabelTemps.AutoSize = True
        Me.LabelTemps.Location = New System.Drawing.Point(25, 704)
        Me.LabelTemps.Name = "LabelTemps"
        Me.LabelTemps.Size = New System.Drawing.Size(118, 20)
        Me.LabelTemps.TabIndex = 65
        Me.LabelTemps.Text = "Temps Restant"
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(257, 691)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(116, 42)
        Me.ButtonStart.TabIndex = 66
        Me.ButtonStart.Text = "Commencer"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(393, 691)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(116, 42)
        Me.ButtonClose.TabIndex = 67
        Me.ButtonClose.Text = "Quitter"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'LabelNomJoueur
        '
        Me.LabelNomJoueur.AutoSize = True
        Me.LabelNomJoueur.Location = New System.Drawing.Point(57, 730)
        Me.LabelNomJoueur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNomJoueur.Name = "LabelNomJoueur"
        Me.LabelNomJoueur.Size = New System.Drawing.Size(42, 20)
        Me.LabelNomJoueur.TabIndex = 124
        Me.LabelNomJoueur.Text = "Nom"
        '
        'PanelJeu
        '
        Me.PanelJeu.Location = New System.Drawing.Point(12, 12)
        Me.PanelJeu.Name = "PanelJeu"
        Me.PanelJeu.Size = New System.Drawing.Size(992, 661)
        Me.PanelJeu.TabIndex = 125
        '
        'FormJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 792)
        Me.Controls.Add(Me.PanelJeu)
        Me.Controls.Add(Me.LabelNomJoueur)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.LabelTemps)
        Me.Controls.Add(Me.LabelChrono)
        Me.Name = "FormJeu"
        Me.Text = "Jeu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelChrono As Label
    Friend WithEvents LabelTemps As Label
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents LabelNomJoueur As Label
    Friend WithEvents PanelJeu As Panel
End Class
