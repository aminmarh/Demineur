﻿Public Class FormJeu
    Dim tim As Integer
    Private Sub init(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        If FormOption.RadioButtonPersonnalisé.Checked = True Then
            tim = FormOption.TextBoxLimiteTemps.Text
        Else
            tim = 60
        End If
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
            Close()
            Form1.Show()
        End If
    End Sub
    Public Sub Placer_boutons(taille As Integer)
        PanelJeu.Controls.Clear()
        For i As Integer = 1 To taille * 40 Step 40
            For j As Integer = 1 To taille * 33 Step 33
                Dim cases As Button = New Button()
                cases.Size = New Size(40, 33)
                cases.Location = New Point(i, j)
                PanelJeu.Controls.Add(cases)
            Next
        Next
    End Sub
    Public Sub setTim(time As String)
        tim = time
    End Sub
    Private Sub ButtonPause_Click(sender As Object, e As EventArgs) Handles ButtonPause.Click
        If Timer1.Enabled = True Then
            Timer1.Stop()
        End If
    End Sub
End Class