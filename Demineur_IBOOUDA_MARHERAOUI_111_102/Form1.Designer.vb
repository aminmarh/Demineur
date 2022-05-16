<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ComboBoxNomJoueur = New System.Windows.Forms.ComboBox()
        Me.LabelNomJoueur = New System.Windows.Forms.Label()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.ButtonScore = New System.Windows.Forms.Button()
        Me.ButtonNvPartie = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonOption = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxNomJoueur
        '
        Me.ComboBoxNomJoueur.AllowDrop = True
        Me.ComboBoxNomJoueur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxNomJoueur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxNomJoueur.FormattingEnabled = True
        Me.ComboBoxNomJoueur.Location = New System.Drawing.Point(291, 192)
        Me.ComboBoxNomJoueur.Name = "ComboBoxNomJoueur"
        Me.ComboBoxNomJoueur.Size = New System.Drawing.Size(466, 28)
        Me.ComboBoxNomJoueur.TabIndex = 0
        '
        'LabelNomJoueur
        '
        Me.LabelNomJoueur.AutoSize = True
        Me.LabelNomJoueur.Location = New System.Drawing.Point(84, 205)
        Me.LabelNomJoueur.Name = "LabelNomJoueur"
        Me.LabelNomJoueur.Size = New System.Drawing.Size(117, 20)
        Me.LabelNomJoueur.TabIndex = 1
        Me.LabelNomJoueur.Text = "Nom du Joueur"
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(16, 371)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(162, 48)
        Me.ButtonQuitter.TabIndex = 2
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'ButtonScore
        '
        Me.ButtonScore.Location = New System.Drawing.Point(321, 371)
        Me.ButtonScore.Name = "ButtonScore"
        Me.ButtonScore.Size = New System.Drawing.Size(162, 48)
        Me.ButtonScore.TabIndex = 3
        Me.ButtonScore.Text = "Score"
        Me.ButtonScore.UseVisualStyleBackColor = True
        '
        'ButtonNvPartie
        '
        Me.ButtonNvPartie.Location = New System.Drawing.Point(621, 371)
        Me.ButtonNvPartie.Name = "ButtonNvPartie"
        Me.ButtonNvPartie.Size = New System.Drawing.Size(162, 48)
        Me.ButtonNvPartie.TabIndex = 4
        Me.ButtonNvPartie.Text = "Nouvelle Partie"
        Me.ButtonNvPartie.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 61)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Démineur"
        '
        'ButtonOption
        '
        Me.ButtonOption.Location = New System.Drawing.Point(670, 18)
        Me.ButtonOption.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonOption.Name = "ButtonOption"
        Me.ButtonOption.Size = New System.Drawing.Size(112, 35)
        Me.ButtonOption.TabIndex = 6
        Me.ButtonOption.Text = "Option"
        Me.ButtonOption.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 449)
        Me.Controls.Add(Me.ButtonOption)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonNvPartie)
        Me.Controls.Add(Me.ButtonScore)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.LabelNomJoueur)
        Me.Controls.Add(Me.ComboBoxNomJoueur)
        Me.Name = "Form1"
        Me.Text = "Acceuil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxNomJoueur As ComboBox
    Friend WithEvents LabelNomJoueur As Label
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents ButtonScore As Button
    Friend WithEvents ButtonNvPartie As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonOption As Button
End Class
