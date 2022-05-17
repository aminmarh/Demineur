Public Class FormJeu
    Dim tim As Integer = 60

    Private Sub init(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        afficheHeure(sender, e)
    End Sub

    Private Sub afficheHeure(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelChrono.Text = tim
        tim -= 1
        If tim < 0 Then
            Timer1.Stop()
            MsgBox("Finit")
        End If
    End Sub

    Private Sub PanelJeu_Click(sender As Object, e As EventArgs) Handles PanelJeu.Click
        Timer1.Start()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
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

    Public Sub Placer_boutons(taille As Integer)
        For i As Integer = 1 To taille * 40 Step 40
            For j As Integer = 1 To taille * 33 Step 33
                Dim mines As Button = New Button()
                mines.Size = New Size(40, 33)
                mines.Location = New Point(i, j)
                PanelJeu.Controls.Add(mines)
            Next
        Next
    End Sub

    Public Sub setTim(time As String)
        tim = time
    End Sub
End Class