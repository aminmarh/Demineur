Public Class FormOption
    Dim tabtaille As Integer() = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
    Dim theme As String() = {"Sombre", "Clair"}
    'Dim chemin As String
    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim Msg, Style, Title, Response
        Msg = "Etes-vous sûr de vouloir quitter ?"
        Style = vbYesNo + vbCritical + vbDefaultButton2
        Title = "Attention"
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub ButtonSauvegarder_Click(sender As Object, e As EventArgs) Handles ButtonSauvegarder.Click
        Dim Msg, Style, Title, Response
        Msg = "Vous voulez vraiment sauvegarder ?"
        Style = vbYesNo + vbCritical + vbDefaultButton2
        Title = "Attention"
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then
            If RadioButtonPersonnalisé.Checked Then
                FormJeu.Placer_boutons(ComboBoxTailleGrille.SelectedItem)
            End If
            Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub RadioButtonPersonnalisé_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPersonnalisé.CheckedChanged
        Panel1.Visible = True
        If (RadioButtonPersonnalisé.Checked = False) Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub RadioButtonFacile_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFacile.CheckedChanged
        FormJeu.Placer_boutons(8)
    End Sub

    Private Sub RadioMoyen_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMoyen.CheckedChanged
        FormJeu.Placer_boutons(10)
    End Sub

    Private Sub RadioButtonDifficile_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDifficile.CheckedChanged
        FormJeu.Placer_boutons(16)
    End Sub

    Private Sub FormOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextBoxCheminFichier.Text = chemin
        For i As Integer = 0 To tabtaille.Length - 1
            ComboBoxTailleGrille.Items.Add(tabtaille(i))
        Next

        For Each element As String In theme
            ComboBoxTheme.Items.Add(element)
        Next
    End Sub

    Private Sub ButtonChoisirFichier_Click(sender As Object, e As EventArgs) Handles ButtonChoisirFichier.Click
        ModuleEnregistrementJoueurs.Choisir_fichier()
    End Sub

    Private Sub ButtonLireChemin_Click(sender As Object, e As EventArgs) Handles ButtonLireChemin.Click
        lectureFichier(Me.TextBoxCheminFichier.Text)
    End Sub

    Private Sub TextBoxLimiteTemps_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLimiteTemps.TextChanged
        FormJeu.setTim(TextBoxLimiteTemps.Text)
    End Sub

    Private Sub ButtonLock_Click(sender As Object, e As EventArgs) Handles ButtonLock.Click
        If (TextBoxCheminFichier.Enabled = True) Then
            TextBoxCheminFichier.Enabled = False
            ButtonChoisirFichier.Enabled = False
            ButtonLireChemin.Enabled = False
        Else
            TextBoxCheminFichier.Enabled = True
            ButtonChoisirFichier.Enabled = True
            ButtonLireChemin.Enabled = True
        End If
    End Sub

End Class