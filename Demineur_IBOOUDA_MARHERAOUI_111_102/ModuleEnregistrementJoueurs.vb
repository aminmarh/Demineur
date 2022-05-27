Imports System.IO

Module ModuleEnregistrementJoueurs
    Public Sub lectureFichier(fichier As String)
        Dim monStreamReader As StreamReader = New StreamReader(fichier)
        Dim ligne As String = "test"
        While ligne <> ""
            ligne = monStreamReader.ReadLine()
            If ligne <> "" Then
                Form1.ComboBoxNomJoueur.Items.Add(ligne)
                FormScore.ComboBoxNomJoueurScore.Items.Add(ligne)
                FormScore.ListBoxNomJoueur.Items.Add(ligne)
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


    'Nous avons essayé d'utiliser le fichier binaire pour crypter les données sensibles
    'afin qu'une personne mal intentionnée ne puisse pas y toucher mais nous n'avons pas réussi
    Sub ecritureBinaire(ByVal NomFichier As String)
        Dim br As BinaryReader
        Dim bw As BinaryWriter
        Dim fs As FileStream
        Dim i As Integer
        Try
            If Not File.Exists(NomFichier) Then
                'Le fichier n'existe pas. On le crée
                bw = New BinaryWriter(File.Create(NomFichier))
                For Each element As String In Form1.ComboBoxNomJoueur.Items
                    bw.Write(element)
                Next
                bw.Close()
            End If
            'Ouverture du fichier et Ecriture du contenu du fichier sur la console
        Finally
            If Not IsNothing(bw) Then bw.Close()
        End Try
    End Sub
    Sub lectureBinaire(ByVal NomFichier As String)
        Dim br As BinaryReader
        Dim fs As FileStream
        Dim nom As String
        Try
            fs = File.Open(NomFichier, FileMode.Open)
            br = New BinaryReader(fs)
            While fs.Position < Form1.ComboBoxNomJoueur.Items.Count
                nom = br.ReadInt32()
                Form1.ComboBoxNomJoueur.Items.Add(nom)
            End While
        Finally
            'Fermeture Binarywriter
            If Not IsNothing(br) Then br.Close()
        End Try
    End Sub
End Module
