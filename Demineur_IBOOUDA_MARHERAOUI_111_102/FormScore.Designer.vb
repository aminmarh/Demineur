<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScore
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
        Me.ListBoxNomJoueur = New System.Windows.Forms.ListBox()
        Me.ListBoxNombredeCases = New System.Windows.Forms.ListBox()
        Me.ListBoxNombredePartiesJouees = New System.Windows.Forms.ListBox()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.ComboBoxNomJoueurScore = New System.Windows.Forms.ComboBox()
        Me.ButtonRechercher = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxCumulTemps = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxNomJoueur
        '
        Me.ListBoxNomJoueur.FormattingEnabled = True
        Me.ListBoxNomJoueur.ItemHeight = 20
        Me.ListBoxNomJoueur.Location = New System.Drawing.Point(23, 147)
        Me.ListBoxNomJoueur.Name = "ListBoxNomJoueur"
        Me.ListBoxNomJoueur.Size = New System.Drawing.Size(207, 304)
        Me.ListBoxNomJoueur.TabIndex = 0
        '
        'ListBoxNombredeCases
        '
        Me.ListBoxNombredeCases.FormattingEnabled = True
        Me.ListBoxNombredeCases.ItemHeight = 20
        Me.ListBoxNombredeCases.Location = New System.Drawing.Point(304, 147)
        Me.ListBoxNombredeCases.Name = "ListBoxNombredeCases"
        Me.ListBoxNombredeCases.Size = New System.Drawing.Size(207, 304)
        Me.ListBoxNombredeCases.TabIndex = 1
        '
        'ListBoxNombredePartiesJouees
        '
        Me.ListBoxNombredePartiesJouees.FormattingEnabled = True
        Me.ListBoxNombredePartiesJouees.ItemHeight = 20
        Me.ListBoxNombredePartiesJouees.Location = New System.Drawing.Point(596, 147)
        Me.ListBoxNombredePartiesJouees.Name = "ListBoxNombredePartiesJouees"
        Me.ListBoxNombredePartiesJouees.Size = New System.Drawing.Size(207, 304)
        Me.ListBoxNombredePartiesJouees.TabIndex = 2
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(1004, 486)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(90, 30)
        Me.ButtonQuitter.TabIndex = 3
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'ComboBoxNomJoueurScore
        '
        Me.ComboBoxNomJoueurScore.AllowDrop = True
        Me.ComboBoxNomJoueurScore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxNomJoueurScore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxNomJoueurScore.FormattingEnabled = True
        Me.ComboBoxNomJoueurScore.Location = New System.Drawing.Point(372, 36)
        Me.ComboBoxNomJoueurScore.Name = "ComboBoxNomJoueurScore"
        Me.ComboBoxNomJoueurScore.Size = New System.Drawing.Size(277, 28)
        Me.ComboBoxNomJoueurScore.TabIndex = 4
        '
        'ButtonRechercher
        '
        Me.ButtonRechercher.Location = New System.Drawing.Point(680, 34)
        Me.ButtonRechercher.Name = "ButtonRechercher"
        Me.ButtonRechercher.Size = New System.Drawing.Size(123, 30)
        Me.ButtonRechercher.TabIndex = 5
        Me.ButtonRechercher.Text = "Rechercher"
        Me.ButtonRechercher.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nom du joueur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre de case"
        '
        'ListBoxCumulTemps
        '
        Me.ListBoxCumulTemps.FormattingEnabled = True
        Me.ListBoxCumulTemps.ItemHeight = 20
        Me.ListBoxCumulTemps.Location = New System.Drawing.Point(887, 147)
        Me.ListBoxCumulTemps.Name = "ListBoxCumulTemps"
        Me.ListBoxCumulTemps.Size = New System.Drawing.Size(207, 304)
        Me.ListBoxCumulTemps.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(608, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre de partie jouées"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(930, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Cumul du temps"
        '
        'FormScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 528)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBoxCumulTemps)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonRechercher)
        Me.Controls.Add(Me.ComboBoxNomJoueurScore)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ListBoxNombredePartiesJouees)
        Me.Controls.Add(Me.ListBoxNombredeCases)
        Me.Controls.Add(Me.ListBoxNomJoueur)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormScore"
        Me.Text = "Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxNomJoueur As ListBox
    Friend WithEvents ListBoxNombredeCases As ListBox
    Friend WithEvents ListBoxNombredePartiesJouees As ListBox
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents ComboBoxNomJoueurScore As ComboBox
    Friend WithEvents ButtonRechercher As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBoxCumulTemps As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
