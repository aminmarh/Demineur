Public Class FormOption
    Dim tabtaille As Integer() = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
    Dim theme As String() = {"Sombre", "Clair"}

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
        TextBoxNbreMines.Enabled = True
        TextBoxLimiteTemps.Enabled = True
        If (RadioButtonPersonnalisé.Checked = False) Then
            Panel1.Visible = False
            TextBoxNbreMines.Enabled = False
            TextBoxLimiteTemps.Enabled = False
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
        For i As Integer = 0 To tabtaille.Length - 1
            ComboBoxTailleGrille.Items.Add(tabtaille(i))
        Next
        For Each element As String In theme
            ComboBoxTheme.Items.Add(element)
        Next
    End Sub

    Private Sub ButtonChoisirFichier_Click(sender As Object, e As EventArgs) Handles ButtonChoisirFichier.Click
        ModuleEnregistrementJoueurs.Choisir_fichier()
        lectureFichier(Me.TextBoxCheminFichier.Text)
    End Sub

    Private Sub TextBoxLimiteTemps_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLimiteTemps.TextChanged
        FormJeu.setTim(TextBoxLimiteTemps.Text)
    End Sub

    Private Sub ButtonLock_Click(sender As Object, e As EventArgs) Handles ButtonLock.Click
        If (TextBoxCheminFichier.Enabled = True) Then
            TextBoxCheminFichier.Enabled = False
        Else
            TextBoxCheminFichier.Enabled = True
        End If
    End Sub

    Private Sub TextBoxCheminFichier_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCheminFichier.TextChanged
        If TextBoxCheminFichier.Text <> "" Then
            Form1.LabelChoisirFichier.Visible = False
        End If
    End Sub

    Private Sub ComboBoxTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTheme.SelectedIndexChanged
        'Dim b = RGB(105, 105, 105)
        If ComboBoxTheme.SelectedIndex = 0 Then
            Form1.BackColor = Color.FromArgb(64, 64, 64)
            Form1.Label1.ForeColor = Color.White
            Form1.LabelNomJoueur.ForeColor = Color.White
            Form1.LabelChoisirFichier.ForeColor = Color.White

            Me.BackColor = Color.FromArgb(64, 64, 64)
            Me.LabelChoixFichier.ForeColor = Color.White
            Me.LabelOption.ForeColor = Color.White
            Me.LabelMimiteTemps.ForeColor = Color.White
            Me.LabelTheme.ForeColor = Color.White
            Me.LabelChoixFichier.ForeColor = Color.White
            Me.LabelNbreMines.ForeColor = Color.White
            Me.LabelTailleTab.ForeColor = Color.White
            Me.RadioButtonDifficile.ForeColor = Color.White
            Me.RadioButtonFacile.ForeColor = Color.White
            Me.RadioMoyen.ForeColor = Color.White
            Me.RadioButtonPersonnalisé.ForeColor = Color.White

            FormJeu.BackColor = Color.FromArgb(64, 64, 64)
            FormJeu.LabelChrono.ForeColor = Color.White
            FormJeu.LabelNomJoueur.ForeColor = Color.White
            FormJeu.LabelTemps.ForeColor = Color.White

        Else
            Form1.BackColor = Color.White
            Form1.Label1.ForeColor = Color.Black
            Form1.LabelNomJoueur.ForeColor = Color.Black
            Form1.LabelChoisirFichier.ForeColor = Color.Black

            Me.BackColor = Color.White
            Me.LabelChoixFichier.ForeColor = Color.Black
            Me.LabelOption.ForeColor = Color.Black
            Me.LabelMimiteTemps.ForeColor = Color.Black
            Me.LabelTheme.ForeColor = Color.Black
            Me.LabelChoixFichier.ForeColor = Color.Black
            Me.LabelNbreMines.ForeColor = Color.Black
            Me.LabelTailleTab.ForeColor = Color.Black
            Me.RadioButtonDifficile.ForeColor = Color.Black
            Me.RadioButtonFacile.ForeColor = Color.Black
            Me.RadioMoyen.ForeColor = Color.Black
            Me.RadioButtonPersonnalisé.ForeColor = Color.Black

            FormJeu.BackColor = Color.White
            FormJeu.LabelChrono.ForeColor = Color.Black
            FormJeu.LabelNomJoueur.ForeColor = Color.Black
            FormJeu.LabelTemps.ForeColor = Color.Black
        End If
    End Sub
End Class