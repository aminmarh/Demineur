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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButtonFacile = New System.Windows.Forms.RadioButton()
        Me.RadioMoyen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDifficile = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPersonnalisé = New System.Windows.Forms.RadioButton()
        Me.Label = New System.Windows.Forms.Label()
        Me.TextBoxNbreMines = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxLimiteTemps = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxTheme = New System.Windows.Forms.ComboBox()
        Me.ButtonSauvegarder = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.LabelNbreLigne = New System.Windows.Forms.Label()
        Me.LabelNbreColone = New System.Windows.Forms.Label()
        Me.TextBoxNbreligne = New System.Windows.Forms.TextBox()
        Me.TextBoxNbreColone = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Difficulté"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(174, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Option"
        '
        'RadioButtonFacile
        '
        Me.RadioButtonFacile.AutoSize = True
        Me.RadioButtonFacile.Location = New System.Drawing.Point(24, 107)
        Me.RadioButtonFacile.Name = "RadioButtonFacile"
        Me.RadioButtonFacile.Size = New System.Drawing.Size(53, 17)
        Me.RadioButtonFacile.TabIndex = 2
        Me.RadioButtonFacile.TabStop = True
        Me.RadioButtonFacile.Text = "Facile"
        Me.RadioButtonFacile.UseVisualStyleBackColor = True
        '
        'RadioMoyen
        '
        Me.RadioMoyen.AutoSize = True
        Me.RadioMoyen.Location = New System.Drawing.Point(24, 141)
        Me.RadioMoyen.Name = "RadioMoyen"
        Me.RadioMoyen.Size = New System.Drawing.Size(57, 17)
        Me.RadioMoyen.TabIndex = 3
        Me.RadioMoyen.TabStop = True
        Me.RadioMoyen.Text = "Moyen"
        Me.RadioMoyen.UseVisualStyleBackColor = True
        '
        'RadioButtonDifficile
        '
        Me.RadioButtonDifficile.AutoSize = True
        Me.RadioButtonDifficile.Location = New System.Drawing.Point(24, 178)
        Me.RadioButtonDifficile.Name = "RadioButtonDifficile"
        Me.RadioButtonDifficile.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonDifficile.TabIndex = 4
        Me.RadioButtonDifficile.TabStop = True
        Me.RadioButtonDifficile.Text = "Difficile"
        Me.RadioButtonDifficile.UseVisualStyleBackColor = True
        '
        'RadioButtonPersonnalisé
        '
        Me.RadioButtonPersonnalisé.AutoSize = True
        Me.RadioButtonPersonnalisé.Location = New System.Drawing.Point(24, 214)
        Me.RadioButtonPersonnalisé.Name = "RadioButtonPersonnalisé"
        Me.RadioButtonPersonnalisé.Size = New System.Drawing.Size(85, 17)
        Me.RadioButtonPersonnalisé.TabIndex = 5
        Me.RadioButtonPersonnalisé.TabStop = True
        Me.RadioButtonPersonnalisé.Text = "Personnalisé"
        Me.RadioButtonPersonnalisé.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(178, 79)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(89, 13)
        Me.Label.TabIndex = 6
        Me.Label.Text = "Nombre de mines"
        '
        'TextBoxNbreMines
        '
        Me.TextBoxNbreMines.Location = New System.Drawing.Point(167, 104)
        Me.TextBoxNbreMines.Name = "TextBoxNbreMines"
        Me.TextBoxNbreMines.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNbreMines.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(178, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Limite de temps"
        '
        'TextBoxLimiteTemps
        '
        Me.TextBoxLimiteTemps.Location = New System.Drawing.Point(167, 178)
        Me.TextBoxLimiteTemps.Name = "TextBoxLimiteTemps"
        Me.TextBoxLimiteTemps.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLimiteTemps.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(382, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Thème"
        '
        'ComboBoxTheme
        '
        Me.ComboBoxTheme.FormattingEnabled = True
        Me.ComboBoxTheme.Location = New System.Drawing.Point(347, 103)
        Me.ComboBoxTheme.Name = "ComboBoxTheme"
        Me.ComboBoxTheme.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTheme.TabIndex = 11
        '
        'ButtonSauvegarder
        '
        Me.ButtonSauvegarder.Location = New System.Drawing.Point(305, 275)
        Me.ButtonSauvegarder.Name = "ButtonSauvegarder"
        Me.ButtonSauvegarder.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSauvegarder.TabIndex = 12
        Me.ButtonSauvegarder.Text = "Sauvegarder"
        Me.ButtonSauvegarder.UseVisualStyleBackColor = True
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(125, 275)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuitter.TabIndex = 13
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'LabelNbreLigne
        '
        Me.LabelNbreLigne.AutoSize = True
        Me.LabelNbreLigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNbreLigne.Location = New System.Drawing.Point(12, 14)
        Me.LabelNbreLigne.Name = "LabelNbreLigne"
        Me.LabelNbreLigne.Size = New System.Drawing.Size(84, 13)
        Me.LabelNbreLigne.TabIndex = 14
        Me.LabelNbreLigne.Text = "Nombre de ligne"
        '
        'LabelNbreColone
        '
        Me.LabelNbreColone.AutoSize = True
        Me.LabelNbreColone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNbreColone.Location = New System.Drawing.Point(12, 51)
        Me.LabelNbreColone.Name = "LabelNbreColone"
        Me.LabelNbreColone.Size = New System.Drawing.Size(94, 13)
        Me.LabelNbreColone.TabIndex = 15
        Me.LabelNbreColone.Text = "Nombre de colone"
        '
        'TextBoxNbreligne
        '
        Me.TextBoxNbreligne.Location = New System.Drawing.Point(112, 11)
        Me.TextBoxNbreligne.Name = "TextBoxNbreligne"
        Me.TextBoxNbreligne.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxNbreligne.TabIndex = 16
        '
        'TextBoxNbreColone
        '
        Me.TextBoxNbreColone.Location = New System.Drawing.Point(112, 48)
        Me.TextBoxNbreColone.Name = "TextBoxNbreColone"
        Me.TextBoxNbreColone.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxNbreColone.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TextBoxNbreColone)
        Me.Panel1.Controls.Add(Me.TextBoxNbreligne)
        Me.Panel1.Controls.Add(Me.LabelNbreColone)
        Me.Panel1.Controls.Add(Me.LabelNbreLigne)
        Me.Panel1.Location = New System.Drawing.Point(305, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 85)
        Me.Panel1.TabIndex = 18
        Me.Panel1.Visible = False
        '
        'FormOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 310)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonSauvegarder)
        Me.Controls.Add(Me.ComboBoxTheme)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxLimiteTemps)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNbreMines)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.RadioButtonPersonnalisé)
        Me.Controls.Add(Me.RadioButtonDifficile)
        Me.Controls.Add(Me.RadioMoyen)
        Me.Controls.Add(Me.RadioButtonFacile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormOption"
        Me.Text = "Option"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButtonFacile As RadioButton
    Friend WithEvents RadioMoyen As RadioButton
    Friend WithEvents RadioButtonDifficile As RadioButton
    Friend WithEvents RadioButtonPersonnalisé As RadioButton
    Friend WithEvents Label As Label
    Friend WithEvents TextBoxNbreMines As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxLimiteTemps As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxTheme As ComboBox
    Friend WithEvents ButtonSauvegarder As Button
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents LabelNbreLigne As Label
    Friend WithEvents LabelNbreColone As Label
    Friend WithEvents TextBoxNbreligne As TextBox
    Friend WithEvents TextBoxNbreColone As TextBox
    Friend WithEvents Panel1 As Panel
End Class
