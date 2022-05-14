Public Class FormJeu
    Inherits System.Windows.Forms.Form
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub init(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        afficheHeure(sender, e)
    End Sub
    Private Sub afficheHeure(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (FormOption.TextBoxLimiteTemps.Text = "") Then
            Me.LabelChrono.Text = 60
        Else
            Me.LabelChrono.Text = FormOption.TextBoxLimiteTemps.Text
        End If
        LabelChrono.Text -= 1
        If LabelChrono.Text < 0 Then
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

    'Private Sub FormJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    Public Function Placer_boutons(ByVal taille As Integer) As Button
        For i As Integer = 1 To taille * 40 Step 40
            For j As Integer = 1 To taille * 33 Step 33
                Dim mines As Button = New Button()
                mines.Size = New Size(40, 33)
                'mines = New Button
                mines.Location = New Point(i, j)
                PanelJeu.Controls.Add(mines)
            Next
        Next
    End Function

    'Public void creerBoutons(sender As Object, e As EventArgs) 
End Class