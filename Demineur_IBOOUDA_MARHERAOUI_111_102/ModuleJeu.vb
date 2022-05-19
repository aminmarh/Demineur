Module ModuleJeu

    Private Structure Buton
        Dim nbMines As Integer
        Dim estMine As Boolean
        Dim estDesmasquee As Boolean
        Dim estMarquee As Boolean
    End Structure

    Public Sub genererMines()
        Dim c As Buton
        c.estMine = True
        c.estDesmasquee = False
        c.nbMines = 0


    End Sub

End Module
