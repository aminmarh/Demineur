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
        Me.Label1.Location = New System.Drawing.Point(398, 125)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Difficulté"
        '
        'LabelOption
        '
        Me.LabelOption.AutoSize = True
        Me.LabelOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption.Location = New System.Drawing.Point(350, 14)
        Me.LabelOption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelOption.Name = "LabelOption"
        Me.LabelOption.Size = New System.Drawing.Size(200, 64)
        Me.LabelOption.TabIndex = 1
        Me.LabelOption.Text = "Option"
        '
        'RadioButtonFacile
        '
        Me.RadioButtonFacile.AutoSize = True
        Me.RadioButtonFacile.Location = New System.Drawing.Point(36, 182)
        Me.RadioButtonFacile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonFacile.Name = "RadioButtonFacile"
        Me.RadioButtonFacile.Size = New System.Drawing.Size(76, 24)
        Me.RadioButtonFacile.TabIndex = 2
        Me.RadioButtonFacile.Text = "Facile"
        Me.RadioButtonFacile.UseVisualStyleBackColor = True
        '
        'RadioMoyen
        '
        Me.RadioMoyen.AutoSize = True
        Me.RadioMoyen.Location = New System.Drawing.Point(243, 182)
        Me.RadioMoyen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioMoyen.Name = "RadioMoyen"
        Me.RadioMoyen.Size = New System.Drawing.Size(81, 24)
        Me.RadioMoyen.TabIndex = 3
        Me.RadioMoyen.Text = "Moyen"
        Me.RadioMoyen.UseVisualStyleBackColor = True
        '
        'RadioButtonDifficile
        '
        Me.RadioButtonDifficile.AutoSize = True
        Me.RadioButtonDifficile.Location = New System.Drawing.Point(462, 182)
        Me.RadioButtonDifficile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonDifficile.Name = "RadioButtonDifficile"
        Me.RadioButtonDifficile.Size = New System.Drawing.Size(85, 24)
        Me.RadioButtonDifficile.TabIndex = 4
        Me.RadioButtonDifficile.Text = "Difficile"
        Me.RadioButtonDifficile.UseVisualStyleBackColor = True
        '
        'RadioButtonPersonnalisé
        '
        Me.RadioButtonPersonnalisé.AutoSize = True
        Me.RadioButtonPersonnalisé.Location = New System.Drawing.Point(722, 182)
        Me.RadioButtonPersonnalisé.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonPersonnalisé.Name = "RadioButtonPersonnalisé"
        Me.RadioButtonPersonnalisé.Size = New System.Drawing.Size(125, 24)
        Me.RadioButtonPersonnalisé.TabIndex = 5
        Me.RadioButtonPersonnalisé.Text = "Personnalisé"
        Me.RadioButtonPersonnalisé.UseVisualStyleBackColor = True
        '
        'LabelNbreMines
        '
        Me.LabelNbreMines.AutoSize = True
        Me.LabelNbreMines.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNbreMines.Location = New System.Drawing.Point(46, 405)
        Me.LabelNbreMines.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNbreMines.Name = "LabelNbreMines"
        Me.LabelNbreMines.Size = New System.Drawing.Size(141, 20)
        Me.LabelNbreMines.TabIndex = 6
        Me.LabelNbreMines.Text = "Nombre de mines"
        '
        'TextBoxNbreMines
        '
        Me.TextBoxNbreMines.Enabled = False
        Me.TextBoxNbreMines.Location = New System.Drawing.Point(39, 443)
        Me.TextBoxNbreMines.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxNbreMines.Name = "TextBoxNbreMines"
        Me.TextBoxNbreMines.Size = New System.Drawing.Size(148, 26)
        Me.TextBoxNbreMines.TabIndex = 7
        '
        'LabelMimiteTemps
        '
        Me.LabelMimiteTemps.AutoSize = True
        Me.LabelMimiteTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMimiteTemps.Location = New System.Drawing.Point(399, 405)
        Me.LabelMimiteTemps.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMimiteTemps.Name = "LabelMimiteTemps"
        Me.LabelMimiteTemps.Size = New System.Drawing.Size(129, 20)
        Me.LabelMimiteTemps.TabIndex = 8
        Me.LabelMimiteTemps.Text = "Limite de temps"
        '
        'TextBoxLimiteTemps
        '
        Me.TextBoxLimiteTemps.Enabled = False
        Me.TextBoxLimiteTemps.Location = New System.Drawing.Point(388, 443)
        Me.TextBoxLimiteTemps.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxLimiteTemps.Name = "TextBoxLimiteTemps"
        Me.TextBoxLimiteTemps.Size = New System.Drawing.Size(148, 26)
        Me.TextBoxLimiteTemps.TabIndex = 9
        Me.TextBoxLimiteTemps.Text = "60"
        '
        'LabelTheme
        '
        Me.LabelTheme.AutoSize = True
        Me.LabelTheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTheme.Location = New System.Drawing.Point(732, 405)
        Me.LabelTheme.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTheme.Name = "LabelTheme"
        Me.LabelTheme.Size = New System.Drawing.Size(60, 20)
        Me.LabelTheme.TabIndex = 10
        Me.LabelTheme.Text = "Thème"
        '
        'ComboBoxTheme
        '
        Me.ComboBoxTheme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxTheme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxTheme.FormattingEnabled = True
        Me.ComboBoxTheme.Location = New System.Drawing.Point(676, 443)
        Me.ComboBoxTheme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxTheme.Name = "ComboBoxTheme"
        Me.ComboBoxTheme.Size = New System.Drawing.Size(180, 28)
        Me.ComboBoxTheme.TabIndex = 11
        Me.ComboBoxTheme.Text = "Clair"
        '
        'ButtonSauvegarder
        '
        Me.ButtonSauvegarder.Location = New System.Drawing.Point(373, 549)
        Me.ButtonSauvegarder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonSauvegarder.Name = "ButtonSauvegarder"
        Me.ButtonSauvegarder.Size = New System.Drawing.Size(199, 35)
        Me.ButtonSauvegarder.TabIndex = 12
        Me.ButtonSauvegarder.Text = "Sauvegarder et Quitter"
        Me.ButtonSauvegarder.UseVisualStyleBackColor = True
        '
        'LabelTailleTab
        '
        Me.LabelTailleTab.AutoSize = True
        Me.LabelTailleTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTailleTab.Location = New System.Drawing.Point(18, 22)
        Me.LabelTailleTab.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTailleTab.Name = "LabelTailleTab"
        Me.LabelTailleTab.Size = New System.Drawing.Size(136, 20)
        Me.LabelTailleTab.TabIndex = 14
        Me.LabelTailleTab.Text = "Taille de la grille "
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ComboBoxTailleGrille)
        Me.Panel1.Controls.Add(Me.LabelTailleTab)
        Me.Panel1.Location = New System.Drawing.Point(622, 217)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 61)
        Me.Panel1.TabIndex = 18
        Me.Panel1.Visible = False
        '
        'ComboBoxTailleGrille
        '
        Me.ComboBoxTailleGrille.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxTailleGrille.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxTailleGrille.FormattingEnabled = True
        Me.ComboBoxTailleGrille.Location = New System.Drawing.Point(156, 17)
        Me.ComboBoxTailleGrille.Name = "ComboBoxTailleGrille"
        Me.ComboBoxTailleGrille.Size = New System.Drawing.Size(66, 28)
        Me.ComboBoxTailleGrille.TabIndex = 15
        '
        'TextBoxCheminFichier
        '
        Me.TextBoxCheminFichier.Location = New System.Drawing.Point(36, 332)
        Me.TextBoxCheminFichier.Name = "TextBoxCheminFichier"
        Me.TextBoxCheminFichier.Size = New System.Drawing.Size(738, 26)
        Me.TextBoxCheminFichier.TabIndex = 19
        '
        'ButtonChoisirFichier
        '
        Me.ButtonChoisirFichier.Location = New System.Drawing.Point(790, 332)
        Me.ButtonChoisirFichier.Name = "ButtonChoisirFichier"
        Me.ButtonChoisirFichier.Size = New System.Drawing.Size(39, 35)
        Me.ButtonChoisirFichier.TabIndex = 20
        Me.ButtonChoisirFichier.Text = "..."
        Me.ButtonChoisirFichier.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonChoisirFichier.UseVisualStyleBackColor = True
        '
        'LabelChoixFichier
        '
        Me.LabelChoixFichier.AutoSize = True
        Me.LabelChoixFichier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChoixFichier.Location = New System.Drawing.Point(368, 269)
        Me.LabelChoixFichier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelChoixFichier.Name = "LabelChoixFichier"
        Me.LabelChoixFichier.Size = New System.Drawing.Size(172, 29)
        Me.LabelChoixFichier.TabIndex = 22
        Me.LabelChoixFichier.Text = "Choix du ficher"
        '
        'ButtonLock
        '
        Me.ButtonLock.Location = New System.Drawing.Point(854, 332)
        Me.ButtonLock.Name = "ButtonLock"
        Me.ButtonLock.Size = New System.Drawing.Size(39, 35)
        Me.ButtonLock.TabIndex = 23
        Me.ButtonLock.Text = "L"
        Me.ButtonLock.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonLock.UseVisualStyleBackColor = True
        '
        'FormOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 598)
        Me.Controls.Add(Me.ButtonLock)
        Me.Controls.Add(Me.LabelChoixFichier)
        Me.Controls.Add(Me.ButtonChoisirFichier)
        Me.Controls.Add(Me.TextBoxCheminFichier)
        Me.Controls.Add(Me.Panel1)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents LabelTailleTab As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxTailleGrille As ComboBox
    Friend WithEvents TextBoxCheminFichier As TextBox
    Friend WithEvents ButtonChoisirFichier As Button
    Friend WithEvents LabelChoixFichier As Label
    Friend WithEvents ButtonLock As Button
End Class
