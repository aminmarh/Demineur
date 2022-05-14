Public Class FormOption
    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim Msg, Style, Title, Response
        Msg = "Etes-vous sûr de vouloir quitter ?"
        Style = vbYesNo + vbCritical + vbDefaultButton2
        Title = "Attention"
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then
            Close()
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
            Close()
            Form1.Show()
        End If
        If (RadioButtonPersonnalisé.Checked = True) Then
            FormJeu.Placer_boutons(TextBoxTailleTab.Text)
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
End Class