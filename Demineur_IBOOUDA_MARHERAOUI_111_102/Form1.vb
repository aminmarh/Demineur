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
    End Sub

    Private Sub ButtonNvPartie_Click(sender As Object, e As EventArgs) Handles ButtonNvPartie.Click
        If (ComboBoxNomJoueur.Text.Length >= 3) Then
            ComboBoxNomJoueur.Items.Add(ComboBoxNomJoueur.Text)
            ModuleEnregistrementJoueurs.ecritureFichier("Z:\Semestre 2\Période D\Démineur\Demineur_IBOOUDA_MARHERAOUI_111_102\bin\Debug\monfichier.txt")
            FormJeu.Show()
            FormJeu.LabelNomJoueur.Text = ComboBoxNomJoueur.Text
            ComboBoxNomJoueur.Text = ""
            Me.Hide()
        ElseIf (ComboBoxNomJoueur.Text = "") Then
            MessageBox.Show("Renseigner un nom de joueur")
        ElseIf (ComboBoxNomJoueur.Text.Length < 3) Then
            MessageBox.Show("Erreur, nom trop court")
            ComboBoxNomJoueur.Text = ""
        End If
    End Sub

    Private Sub ButtonOption_Click(sender As Object, e As EventArgs) Handles ButtonOption.Click
        FormOption.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lectureFichier("Z:\Semestre 2\Période D\Démineur\Demineur_IBOOUDA_MARHERAOUI_111_102\bin\Debug\monfichier.txt")
    End Sub

    Private Sub ComboBoxNomJoueur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNomJoueur.SelectedIndexChanged

    End Sub
End Class
