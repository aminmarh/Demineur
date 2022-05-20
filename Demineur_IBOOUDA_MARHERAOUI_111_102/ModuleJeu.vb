Module ModuleJeu

    Friend Structure Probleme
        Dim taille_tab, nbMines, nbmines_maximum As Integer
        Dim position_mines() As Boolean
    End Structure

    Private Structure Bouton_Case
        Dim nbMines As Integer
        Dim estMine As Boolean
        Dim estDesmasquee As Boolean
        Dim estMarquee As Boolean
        Dim Chiffre As String
        Dim position As Integer
    End Structure

    Private Structure Grille
        Dim bouton_case() As Bouton_Case
    End Structure

    '    void produire_probleme() {
    '	Probleme probleme;
    '	srand(time(NULL));
    '	cin >> probleme.nbLignes >> probleme.nbColonnes >> probleme.nbMines;
    '	placement_Mines(&probleme);
    '	std:cout << probleme.nbLignes << " " << probleme.nbColonnes << " " << probleme.nbMines;
    '	For (int i = 0; i < probleme.nbMines; i++) {
    '		std:cout << " " << probleme.positions_mines[i];
    '	}
    '};
    Public Sub placement_mines(pb As Probleme)
        Dim nbRandom_max = pb.taille_tab
        Dim relancer As Boolean = False
        For i As Integer = 0 To pb.nbMines - 1
            Dim nbRandom As Integer = CInt(Math.Ceiling(Rnd() Mod nbRandom_max)) + 1
            For k As Integer = 0 To pb.nbMines - 1
                If pb.position_mines(k) = nbRandom Then
                    relancer = True
                End If
            Next
            If relancer = True Then
                i -= i
                relancer = False
            Else
                pb.position_mines(i) = True
            End If
        Next

    End Sub

    Public Sub produire_probleme()
        Dim pb As Probleme
        'On déclare une variable Classe Random() et une variable Int
        Dim random As New Random(), rndnbr As Integer

        '.Next permet de retourner un nombre aléatoire contenu dans la plage spécifiée entre parenthèses.
        rndnbr = random.Next(0, 9)

        placement_mines(pb)
    End Sub

End Module
