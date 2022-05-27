Public Class Form1

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim Msg, Style, Title, Response
        Msg = "Etes-vous sûr de vouloir quitter ?"
        Style = vbYesNo + vbCritical + vbDefaultButton2
        Title = "Attention"
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then
            Close()
        End If
    End Sub

    Private Sub ButtonScore_Click(sender As Object, e As EventArgs) Handles ButtonScore.Click
        FormScore.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonNvPartie_Click(sender As Object, e As EventArgs) Handles ButtonNvPartie.Click
        caracteristiques_comboboxNomJoueurs()
    End Sub

    Private Sub ButtonOption_Click(sender As Object, e As EventArgs) Handles ButtonOption.Click
        FormOption.Show()
        Me.Hide()
    End Sub

    Private Sub caracteristiques_comboboxNomJoueurs()
        If (ComboBoxNomJoueur.Text.Length >= 3) Then
            If ComboBoxNomJoueur.Text <> ComboBoxNomJoueur.SelectedItem Then
                ComboBoxNomJoueur.Items.Add(ComboBoxNomJoueur.Text)
                ModuleEnregistrementJoueurs.ecritureFichier(FormOption.TextBoxCheminFichier.Text)
                'ecritureBinaire(".\fichier")
                FormJeu.Show()
                ComboBoxNomJoueur.Text = ""
                Me.Hide()
            Else
                FormJeu.Show()
                FormJeu.LabelNomJoueur.Text = ComboBoxNomJoueur.Text
                ComboBoxNomJoueur.Text = ""
                Me.Hide()
            End If
        ElseIf (ComboBoxNomJoueur.Text = "") Then
            MessageBox.Show("Renseigner un nom de joueur")
        ElseIf (ComboBoxNomJoueur.Text.Length < 3) Then
            MessageBox.Show("Erreur, nom trop court")
            ComboBoxNomJoueur.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormOption.RadioButtonFacile.Checked = True
        lectureFichier(".\monfichier.txt")
        'lectureBinaire(".\fichier")
        FormOption.TextBoxCheminFichier.Text = ".\fichier"
        FormOption.TextBoxCheminFichier.Enabled = False
        FormOption.ButtonChoisirFichier.Enabled = False
    End Sub
End Class
