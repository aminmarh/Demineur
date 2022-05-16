Imports System.IO

Module ModuleEnregistrementJoueurs
    'Public Sub lectureFichier(ByVal fichier As String)

    '    Try
    '        ' Création d'une instance de StreamReader pour permettre la lecture de notre fichier
    '        Dim monStreamReader As StreamReader = New StreamReader(Server.MapPath(fichier))
    '        Dim ligne As String

    '        'Lecture de toutes les lignes et affichage de chacune sur la page
    '        Do
    '            ligne = monStreamReader.ReadLine()
    '            Response.Write(ligne)
    '            Response.Write("</BR>")

    '        Loop Until ligne Is Nothing

    '        'Fermeture du StreamReader (attention très important)
    '        monStreamReader.Close()

    '    Catch ex As Exception

    '        'Code exécuté en cas d'exception
    '        Response.Write("Une erreur est survenue au cours de la lecture !")
    '        Response.Write("</BR>")
    '        Response.Write(ex.Message)

    '    End Try

    'End Sub

    'Public Sub ecritureFichier(ByVal fichier As String)

    '    Try

    '        'Instanciation du StreamWriter avec passage du nom du fichier 
    '        Dim monStreamWriter As StreamWriter = New StreamWriter(Server.MapPath("./") & "admin\logs\" & fichier)

    '        'Ecriture du texte dans votre fichier
    '        monStreamWriter.WriteLine(Form1.ComboBoxNomJoueur.Text)

    '        'Fermeture du StreamWriter (Très important)
    '        monStreamWriter.Close()

    '    Catch ex As Exception

    '        'Code exécuté en cas d'exception
    '        MsgBox.Write(ex.Message)

    '    End Try

    'End Sub




    'Dim R As New StreamReader(FormOption.TextBoxCheminFichier.Text)
    'Dim W As New StreamWriter(FormOption.TextBoxCheminFichier.Text)
    'Public Sub Choisir_fichier()
    '    Dim choisir As New OpenFileDialog
    '    If choisir.ShowDialog() = 1 Then
    '        FormOption.TextBoxCheminFichier.Text = choisir.FileName
    '    End If
    'End Sub

    'Public Sub Importer_joueurs()
    '    If IO.File.Exists(FormOption.TextBoxCheminFichier.Text) Then
    '        File.Open(FormOption.TextBoxCheminFichier.Text, OpenMode.Input)
    '        Do While R.Peek() >= 0
    '            Form1.ComboBoxNomJoueur.Items.Add(R.ReadLine)
    '        Loop
    '    End If
    'End Sub

    'Public Sub enregistrement_joueur()
    '    W.WriteLine(Form1.ComboBoxNomJoueur.Text)
    '    W.Close()
    'End Sub
    'Dim num As Integer = FreeFile()
    'Dim nextLine As String
    'Dim W As New StreamWriter("C:\Users\Yasser\OneDrive\Documents\BUT\Semestre 2\Periode D\IHM Demineur GIT\Demineur_IBOOUDA_MARHERAOUI_111_102\bin\Debug\monfichier.txt", True)
    'Dim R As New StreamReader("C:\Users\Yasser\OneDrive\Documents\BUT\Semestre 2\Periode D\IHM Demineur GIT\Demineur_IBOOUDA_MARHERAOUI_111_102\bin\Debug\monfichier.txt", True)

    'Public Sub enregistrement_joueur()
    '    W.WriteLine(Form1.ComboBoxNomJoueur.Text)
    '    W.Close()
    '    FileOpen(num, "monFichier.txt", OpenMode.Output)
    '    Write("monfichier.txt", Form1.ComboBoxNomJoueur.Text)
    '    FileClose(num)
    'End Sub

    'Public Sub lire_noms_joueurs()
    '    If IO.File.Exists("C:\Users\Yasser\OneDrive\Documents\BUT\Semestre 2\Periode D\IHM Demineur GIT\Demineur_IBOOUDA_MARHERAOUI_111_102\bin\Debug\monfichier.txt") Then
    '        Do While R.Peek() >= 0
    '            Form1.ComboBoxNomJoueur.Items.Add(R.ReadLine())
    '        Loop
    '        R.Close()
    '    Else
    '    MessageBox.Show("Le fichier n'existe pas")
    '    End If
    'End Sub
End Module
