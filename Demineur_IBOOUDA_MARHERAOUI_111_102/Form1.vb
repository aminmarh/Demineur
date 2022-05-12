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

    Private Sub ComboBoxNomJoueur_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxNomJoueur.DropDown

    End Sub

    Private Sub ComboBoxNomJoueur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNomJoueur.SelectedIndexChanged

    End Sub

    Private Sub LabelNomJoueur_Click(sender As Object, e As EventArgs) Handles LabelNomJoueur.Click

    End Sub

    Private Sub ButtonOption_Click(sender As Object, e As EventArgs) Handles ButtonOption.Click
        FormOption.Show()
        Me.Hide()
    End Sub
End Class
