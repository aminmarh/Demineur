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
        'Instanciation du StreamWriter avec passage du nom du fichier 
        Dim monStreamWriter As StreamWriter = New StreamWriter(fichier)

        For Each element As String In Form1.ComboBoxNomJoueur.Items
            'If element <> Form1.ComboBoxNomJoueur.Text Then
            monStreamWriter.WriteLine(element)
            'End If


        Next

        'Fermeture du StreamWriter (Très important)
        monStreamWriter.Close()



    End Sub

    Public Sub Choisir_fichier()
        Dim choisir As New OpenFileDialog()
        If choisir.ShowDialog() = 1 Then
            FormOption.TextBoxCheminFichier.Text = choisir.FileName
        End If
    End Sub

End Module
