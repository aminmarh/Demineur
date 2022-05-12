Public Class FormJeu

    Dim tim As Integer = 60

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

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

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Timer1.Start()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
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
End Class