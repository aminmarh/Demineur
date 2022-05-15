Imports System.IO

Module ModuleEnregistrementJoueurs
    Dim R As New StreamReader(FormOption.TextBoxCheminFichier.Text)
    Dim W As New StreamWriter(FormOption.TextBoxCheminFichier.Text)
    Public Sub Choisir_fichier()
        Dim choisir As New OpenFileDialog
        If choisir.ShowDialog() = 1 Then
            FormOption.TextBoxCheminFichier.Text = choisir.FileName
        End If
    End Sub

    Public Sub Importer_joueurs()
        If IO.File.Exists(FormOption.TextBoxCheminFichier.Text) Then
            File.Open(FormOption.TextBoxCheminFichier.Text, OpenMode.Input)
            Do While R.Peek() >= 0
                Form1.ComboBoxNomJoueur.Items.Add(R.ReadLine)
            Loop
        End If
    End Sub

    Public Sub enregistrement_joueur()
        W.WriteLine(Form1.ComboBoxNomJoueur.Text)
        W.Close()
    End Sub
    'Dim num As Integer = FreeFile()
    'Dim nextLine As String
    'Dim W As New StreamWriter("C:\Users\Yasser\OneDrive\Documents\BUT\Semestre 2\Periode D\IHM Demineur GIT\Demineur_IBOOUDA_MARHERAOUI_111_102\bin\Debug\monfichier.txt", True)
    'Dim R As New StreamReader("C:\Users\Yasser\OneDrive\Documents\BUT\Semestre 2\Periode D\IHM Demineur GIT\Demineur_IBOOUDA_MARHERAOUI_111_102\bin\Debug\monfichier.txt", True)

    'Public Sub enregistrement_joueur()
    '    W.WriteLine(Form1.ComboBoxNomJoueur.Text)
    '    W.Close()
    '    'FileOpen(num, "monFichier.txt", OpenMode.Output)
    '    'Write("monfichier.txt", Form1.ComboBoxNomJoueur.Text)
    '    'FileClose(num)
    'End Sub

    'Public Sub lire_noms_joueurs()
    '    'If IO.File.Exists("C:\Users\Yasser\OneDrive\Documents\BUT\Semestre 2\Periode D\IHM Demineur GIT\Demineur_IBOOUDA_MARHERAOUI_111_102\bin\Debug\monfichier.txt") Then
    '    Do While R.Peek() >= 0
    '        Form1.ComboBoxNomJoueur.Items.Add(R.ReadLine())
    '    Loop
    '    R.Close()
    '    'Else
    '    '    MessageBox.Show("Le fichier n'existe pas")
    '    'End If
    'End Sub
End Module
