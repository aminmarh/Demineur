Public Class FormScore
    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim Msg, Style, Title, Response
        Msg = "Etes-vous sûr de vouloir quitter ?"
        Style = vbYesNo + vbCritical + vbDefaultButton2
        Title = "Attention"
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then
            Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub ButtonRechercher_Click(sender As Object, e As EventArgs) Handles ButtonRechercher.Click
        MessageBox.Show("Le Joueur " & ComboBoxNomJoueurScore.SelectedItem & vbCrLf & "a un temps cumulé de : " &
                        "..." & vbCrLf & "Le nombre de cases trouvées est de : " & "..." & vbCrLf &
                        "Le nombre de parties jouées est de :" & "...")
    End Sub
End Class