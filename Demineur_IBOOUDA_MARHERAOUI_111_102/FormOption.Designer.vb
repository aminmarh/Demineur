<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOption
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelOption = New System.Windows.Forms.Label()
        Me.RadioButtonFacile = New System.Windows.Forms.RadioButton()
        Me.RadioMoyen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDifficile = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPersonnalisé = New System.Windows.Forms.RadioButton()
        Me.LabelNbreMines = New System.Windows.Forms.Label()
        Me.TextBoxNbreMines = New System.Windows.Forms.TextBox()
        Me.LabelMimiteTemps = New System.Windows.Forms.Label()
        Me.TextBoxLimiteTemps = New System.Windows.Forms.TextBox()
        Me.LabelTheme = New System.Windows.Forms.Label()
        Me.ComboBoxTheme = New System.Windows.Forms.ComboBox()
        Me.ButtonSauvegarder = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.LabelTailleTab = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxTailleGrille = New System.Windows.Forms.ComboBox()
        Me.TextBoxCheminFichier = New System.Windows.Forms.TextBox()
        Me.ButtonChoisirFichier = New System.Windows.Forms.Button()
        Me.LabelChoixFichier = New System.Windows.Forms.Label()
        Me.ButtonLock = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Difficulté"
        '
        'LabelOption
        '
        Me.LabelOption.AutoSize = True
        Me.LabelOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption.Location = New System.Drawing.Point(233, 9)
        Me.LabelOption.Name = "LabelOption"
        Me.LabelOption.Size = New System.Drawing.Size(134, 42)
        Me.LabelOption.TabIndex = 1
        Me.LabelOption.Text = "Option"
        '
        'RadioButtonFacile
        '
        Me.RadioButtonFacile.AutoSize = True
        Me.RadioButtonFacile.Location = New System.Drawing.Point(24, 118)
        Me.RadioButtonFacile.Name = "RadioButtonFacile"
        Me.RadioButtonFacile.Size = New System.Drawing.Size(53, 17)
        Me.RadioButtonFacile.TabIndex = 2
        Me.RadioButtonFacile.Text = "Facile"
        Me.RadioButtonFacile.UseVisualStyleBackColor = True
        '
        'RadioMoyen
        '
        Me.RadioMoyen.AutoSize = True
        Me.RadioMoyen.Location = New System.Drawing.Point(162, 118)
        Me.RadioMoyen.Name = "RadioMoyen"
        Me.RadioMoyen.Size = New System.Drawing.Size(57, 17)
        Me.RadioMoyen.TabIndex = 3
        Me.RadioMoyen.Text = "Moyen"
        Me.RadioMoyen.UseVisualStyleBackColor = True
        '
        'RadioButtonDifficile
        '
        Me.RadioButtonDifficile.AutoSize = True
        Me.RadioButtonDifficile.Location = New System.Drawing.Point(308, 118)
        Me.RadioButtonDifficile.Name = "RadioButtonDifficile"
        Me.RadioButtonDifficile.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonDifficile.TabIndex = 4
        Me.RadioButtonDifficile.Text = "Difficile"
        Me.RadioButtonDifficile.UseVisualStyleBackColor = True
        '
        'RadioButtonPersonnalisé
        '
        Me.RadioButtonPersonnalisé.AutoSize = True
        Me.RadioButtonPersonnalisé.Location = New System.Drawing.Point(481, 118)
        Me.RadioButtonPersonnalisé.Name = "RadioButtonPersonnalisé"
        Me.RadioButtonPersonnalisé.Size = New System.Drawing.Size(85, 17)
        Me.RadioButtonPersonnalisé.TabIndex = 5
        Me.RadioButtonPersonnalisé.Text = "Personnalisé"
        Me.RadioButtonPersonnalisé.UseVisualStyleBackColor = True
        '
        'LabelNbreMines
        '
        Me.LabelNbreMines.AutoSize = True
        Me.LabelNbreMines.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNbreMines.Location = New System.Drawing.Point(31, 263)
        Me.LabelNbreMines.Name = "LabelNbreMines"
        Me.LabelNbreMines.Size = New System.Drawing.Size(89, 13)
        Me.LabelNbreMines.TabIndex = 6
        Me.LabelNbreMines.Text = "Nombre de mines"
        '
        'TextBoxNbreMines
        '
        Me.TextBoxNbreMines.Enabled = False
        Me.TextBoxNbreMines.Location = New System.Drawing.Point(26, 288)
        Me.TextBoxNbreMines.Name = "TextBoxNbreMines"
        Me.TextBoxNbreMines.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNbreMines.TabIndex = 7
        '
        'LabelMimiteTemps
        '
        Me.LabelMimiteTemps.AutoSize = True
        Me.LabelMimiteTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMimiteTemps.Location = New System.Drawing.Point(266, 263)
        Me.LabelMimiteTemps.Name = "LabelMimiteTemps"
        Me.LabelMimiteTemps.Size = New System.Drawing.Size(80, 13)
        Me.LabelMimiteTemps.TabIndex = 8
        Me.LabelMimiteTemps.Text = "Limite de temps"
        '
        'TextBoxLimiteTemps
        '
        Me.TextBoxLimiteTemps.Enabled = False
        Me.TextBoxLimiteTemps.Location = New System.Drawing.Point(259, 288)
        Me.TextBoxLimiteTemps.Name = "TextBoxLimiteTemps"
        Me.TextBoxLimiteTemps.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLimiteTemps.TabIndex = 9
        '
        'LabelTheme
        '
        Me.LabelTheme.AutoSize = True
        Me.LabelTheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTheme.Location = New System.Drawing.Point(488, 263)
        Me.LabelTheme.Name = "LabelTheme"
        Me.LabelTheme.Size = New System.Drawing.Size(40, 13)
        Me.LabelTheme.TabIndex = 10
        Me.LabelTheme.Text = "Thème"
        '
        'ComboBoxTheme
        '
        Me.ComboBoxTheme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxTheme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxTheme.FormattingEnabled = True
        Me.ComboBoxTheme.Location = New System.Drawing.Point(451, 288)
        Me.ComboBoxTheme.Name = "ComboBoxTheme"
        Me.ComboBoxTheme.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTheme.TabIndex = 11
        Me.ComboBoxTheme.Text = "Clair"
        '
        'ButtonSauvegarder
        '
        Me.ButtonSauvegarder.Location = New System.Drawing.Point(354, 348)
        Me.ButtonSauvegarder.Name = "ButtonSauvegarder"
        Me.ButtonSauvegarder.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSauvegarder.TabIndex = 12
        Me.ButtonSauvegarder.Text = "Sauvegarder"
        Me.ButtonSauvegarder.UseVisualStyleBackColor = True
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(181, 348)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuitter.TabIndex = 13
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'LabelTailleTab
        '
        Me.LabelTailleTab.AutoSize = True
        Me.LabelTailleTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTailleTab.Location = New System.Drawing.Point(12, 14)
        Me.LabelTailleTab.Name = "LabelTailleTab"
        Me.LabelTailleTab.Size = New System.Drawing.Size(85, 13)
        Me.LabelTailleTab.TabIndex = 14
        Me.LabelTailleTab.Text = "Taille de la grille "
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ComboBoxTailleGrille)
        Me.Panel1.Controls.Add(Me.LabelTailleTab)
        Me.Panel1.Location = New System.Drawing.Point(415, 141)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 41)
        Me.Panel1.TabIndex = 18
        Me.Panel1.Visible = False
        '
        'ComboBoxTailleGrille
        '
        Me.ComboBoxTailleGrille.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxTailleGrille.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxTailleGrille.FormattingEnabled = True
        Me.ComboBoxTailleGrille.Location = New System.Drawing.Point(104, 11)
        Me.ComboBoxTailleGrille.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxTailleGrille.Name = "ComboBoxTailleGrille"
        Me.ComboBoxTailleGrille.Size = New System.Drawing.Size(45, 21)
        Me.ComboBoxTailleGrille.TabIndex = 15
        '
        'TextBoxCheminFichier
        '
        Me.TextBoxCheminFichier.Location = New System.Drawing.Point(24, 216)
        Me.TextBoxCheminFichier.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCheminFichier.Name = "TextBoxCheminFichier"
        Me.TextBoxCheminFichier.Size = New System.Drawing.Size(493, 20)
        Me.TextBoxCheminFichier.TabIndex = 19
        '
        'ButtonChoisirFichier
        '
        Me.ButtonChoisirFichier.Location = New System.Drawing.Point(527, 216)
        Me.ButtonChoisirFichier.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonChoisirFichier.Name = "ButtonChoisirFichier"
        Me.ButtonChoisirFichier.Size = New System.Drawing.Size(26, 23)
        Me.ButtonChoisirFichier.TabIndex = 20
        Me.ButtonChoisirFichier.Text = "..."
        Me.ButtonChoisirFichier.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonChoisirFichier.UseVisualStyleBackColor = True
        '
        'LabelChoixFichier
        '
        Me.LabelChoixFichier.AutoSize = True
        Me.LabelChoixFichier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChoixFichier.Location = New System.Drawing.Point(245, 175)
        Me.LabelChoixFichier.Name = "LabelChoixFichier"
        Me.LabelChoixFichier.Size = New System.Drawing.Size(113, 20)
        Me.LabelChoixFichier.TabIndex = 22
        Me.LabelChoixFichier.Text = "Choix du ficher"
        '
        'ButtonLock
        '
        Me.ButtonLock.Location = New System.Drawing.Point(569, 216)
        Me.ButtonLock.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonLock.Name = "ButtonLock"
        Me.ButtonLock.Size = New System.Drawing.Size(26, 23)
        Me.ButtonLock.TabIndex = 23
        Me.ButtonLock.Text = "L"
        Me.ButtonLock.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonLock.UseVisualStyleBackColor = True
        '
        'FormOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 389)
        Me.Controls.Add(Me.ButtonLock)
        Me.Controls.Add(Me.LabelChoixFichier)
        Me.Controls.Add(Me.ButtonChoisirFichier)
        Me.Controls.Add(Me.TextBoxCheminFichier)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonSauvegarder)
        Me.Controls.Add(Me.ComboBoxTheme)
        Me.Controls.Add(Me.LabelTheme)
        Me.Controls.Add(Me.TextBoxLimiteTemps)
        Me.Controls.Add(Me.LabelMimiteTemps)
        Me.Controls.Add(Me.TextBoxNbreMines)
        Me.Controls.Add(Me.LabelNbreMines)
        Me.Controls.Add(Me.RadioButtonPersonnalisé)
        Me.Controls.Add(Me.RadioButtonDifficile)
        Me.Controls.Add(Me.RadioMoyen)
        Me.Controls.Add(Me.RadioButtonFacile)
        Me.Controls.Add(Me.LabelOption)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormOption"
        Me.Text = "Option"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelOption As Label
    Friend WithEvents RadioButtonFacile As RadioButton
    Friend WithEvents RadioMoyen As RadioButton
    Friend WithEvents RadioButtonDifficile As RadioButton
    Friend WithEvents RadioButtonPersonnalisé As RadioButton
    Friend WithEvents LabelNbreMines As Label
    Friend WithEvents TextBoxNbreMines As TextBox
    Friend WithEvents LabelMimiteTemps As Label
    Friend WithEvents TextBoxLimiteTemps As TextBox
    Friend WithEvents LabelTheme As Label
    Friend WithEvents ComboBoxTheme As ComboBox
    Friend WithEvents ButtonSauvegarder As Button
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents LabelTailleTab As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxTailleGrille As ComboBox
    Friend WithEvents TextBoxCheminFichier As TextBox
    Friend WithEvents ButtonChoisirFichier As Button
    Friend WithEvents LabelChoixFichier As Label
    Friend WithEvents ButtonLock As Button
End Class
