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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxNomJoueur
        '
        Me.ComboBoxNomJoueur.AllowDrop = True
        Me.ComboBoxNomJoueur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxNomJoueur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxNomJoueur.FormattingEnabled = True
        Me.ComboBoxNomJoueur.Location = New System.Drawing.Point(194, 125)
        Me.ComboBoxNomJoueur.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxNomJoueur.Name = "ComboBoxNomJoueur"
        Me.ComboBoxNomJoueur.Size = New System.Drawing.Size(312, 21)
        Me.ComboBoxNomJoueur.TabIndex = 0
        '
        'LabelNomJoueur
        '
        Me.LabelNomJoueur.AutoSize = True
        Me.LabelNomJoueur.Location = New System.Drawing.Point(56, 133)
        Me.LabelNomJoueur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNomJoueur.Name = "LabelNomJoueur"
        Me.LabelNomJoueur.Size = New System.Drawing.Size(79, 13)
        Me.LabelNomJoueur.TabIndex = 1
        Me.LabelNomJoueur.Text = "Nom du Joueur"
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(11, 241)
        Me.ButtonQuitter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(108, 31)
        Me.ButtonQuitter.TabIndex = 2
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'ButtonScore
        '
        Me.ButtonScore.Location = New System.Drawing.Point(214, 241)
        Me.ButtonScore.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonScore.Name = "ButtonScore"
        Me.ButtonScore.Size = New System.Drawing.Size(108, 31)
        Me.ButtonScore.TabIndex = 3
        Me.ButtonScore.Text = "Score"
        Me.ButtonScore.UseVisualStyleBackColor = True
        '
        'ButtonNvPartie
        '
        Me.ButtonNvPartie.Location = New System.Drawing.Point(414, 241)
        Me.ButtonNvPartie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonNvPartie.Name = "ButtonNvPartie"
        Me.ButtonNvPartie.Size = New System.Drawing.Size(108, 31)
        Me.ButtonNvPartie.TabIndex = 4
        Me.ButtonNvPartie.Text = "Nouvelle Partie"
        Me.ButtonNvPartie.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Démineur"
        '
        'ButtonOption
        '
        Me.ButtonOption.Location = New System.Drawing.Point(447, 12)
        Me.ButtonOption.Name = "ButtonOption"
        Me.ButtonOption.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOption.TabIndex = 6
        Me.ButtonOption.Text = "Option"
        Me.ButtonOption.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 173)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(450, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Veuillez sélectionner vos préférences dans le menu option avant de lancer une nou" &
    "velle partie"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonOption)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonNvPartie)
        Me.Controls.Add(Me.ButtonScore)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.LabelNomJoueur)
        Me.Controls.Add(Me.ComboBoxNomJoueur)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents Label2 As Label
End Class
