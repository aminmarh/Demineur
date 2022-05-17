Imports System.IO

Module ModuleEnregistrementJoueurs
    Public Sub lectureFichier(fichier As String)

        Dim monStreamReader As StreamReader = New StreamReader(fichier)
        Dim ligne As String = "test"
        While ligne <> ""
            ligne = monStreamReader.ReadLine()
            If ligne <> "" Then
                Form1.ComboBoxNomJoueur.Items.Add(ligne)
            End If
        End While
        monStreamReader.Close()
    End Sub

    Public Sub ecritureFichier(fichier As String)
        Dim monStreamWriter As StreamWriter = New StreamWriter(fichier)

        For Each element As String In Form1.ComboBoxNomJoueur.Items
            monStreamWriter.WriteLine(element)
        Next
        monStreamWriter.Close()
    End Sub

    Public Sub Choisir_fichier()
        Dim choisir As New OpenFileDialog()
        If choisir.ShowDialog() = 1 Then
            FormOption.TextBoxCheminFichier.Text = choisir.FileName
        End If
    End Sub
End Module
