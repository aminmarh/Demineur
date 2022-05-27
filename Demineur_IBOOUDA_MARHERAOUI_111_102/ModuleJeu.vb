Module ModuleJeu
    'Private COLONNES_MAX As Integer
    'Private LIGNES_MAX As Integer
    'Private BOMBES_MAX As Integer
    'Private BOMBE As Integer

    'Private score As Integer = 0
    'Private estPerdue As Boolean = False

    'Dim terrainMine(0, 0) As Integer
    'Dim grille(0, 0) As Button

    'Private listeCaseExplorer As ArrayList = New ArrayList()

    'Public Sub init(ByVal lignesMax As Integer, ByVal colonnesMax As Integer, ByVal BombesMax As Integer, ByVal codeBombe As Integer)
    '    COLONNES_MAX = colonnesMax
    '    LIGNES_MAX = lignesMax
    '    BOMBES_MAX = BombesMax
    '    BOMBE = codeBombe

    '    score = 0
    '    estPerdue = False
    '    Dim tab_case(0, 0) As Button
    '    ReDim terrainMine(LIGNES_MAX - 1, COLONNES_MAX - 1)
    '    ReDim grille(LIGNES_MAX - 1, COLONNES_MAX - 1)
    '    For i = 0 To LIGNES_MAX - 1
    '        For j = 0 To COLONNES_MAX - 1
    '            grille(i, j).Text = "?"
    '        Next
    '    Next
    'End Sub

    'Public Sub mineTerrain(ByVal nbMines As Integer)
    '    Randomize()
    '    videTerrainMine()

    '    For idxMine = 1 To nbMines
    '        Dim caseEstMinee As Boolean = vbFalse
    '        While (Not (caseEstMinee))
    '            ' valeur aléatoire comprise entre 0 et LIGNES_MAX-1.
    '            Dim i As Integer = CInt(Int((LIGNES_MAX * Rnd())))
    '            ' valeur aléatoire comprise entre 0 et COLONNES_MAX-1.
    '            Dim j As Integer = CInt(Int((COLONNES_MAX * Rnd())))

    '            If (terrainMine(i, j) <> BOMBE) Then
    '                caseEstMinee = vbTrue
    '                terrainMine(i, j) = BOMBE
    '                exploreCasesVoisines(i, j)
    '            End If
    '        End While
    '    Next
    'End Sub
    'Private Sub exploreCasesVoisines(ByRef i As Integer, ByRef j As Integer)
    '    If (i - 1) >= 0 And (j - 1) >= 0 Then
    '        If terrainMine(i - 1, j - 1) <> BOMBE Then
    '            terrainMine(i - 1, j - 1) = terrainMine(i - 1, j - 1) + 1
    '        End If
    '    End If
    '    If (j - 1) >= 0 Then
    '        If terrainMine(i, j - 1) <> BOMBE Then
    '            terrainMine(i, j - 1) = terrainMine(i, j - 1) + 1
    '        End If
    '    End If
    '    If (i + 1) < LIGNES_MAX And (j - 1) >= 0 Then
    '        If terrainMine(i + 1, j - 1) <> BOMBE Then
    '            terrainMine(i + 1, j - 1) = terrainMine(i + 1, j - 1) + 1
    '        End If
    '    End If

    '    If (i - 1) >= 0 Then
    '        If terrainMine(i - 1, j) <> BOMBE Then
    '            terrainMine(i - 1, j) = terrainMine(i - 1, j) + 1
    '        End If
    '    End If
    '    If (i + 1) < LIGNES_MAX Then
    '        If terrainMine(i + 1, j) <> BOMBE Then
    '            terrainMine(i + 1, j) = terrainMine(i + 1, j) + 1
    '        End If
    '    End If

    '    If (i - 1) >= 0 And (j + 1) < COLONNES_MAX Then
    '        If terrainMine(i - 1, j + 1) <> BOMBE Then
    '            terrainMine(i - 1, j + 1) = terrainMine(i - 1, j + 1) + 1
    '        End If
    '    End If
    '    If (j + 1) < COLONNES_MAX Then
    '        If terrainMine(i, j + 1) <> BOMBE Then
    '            terrainMine(i, j + 1) = terrainMine(i, j + 1) + 1
    '        End If
    '    End If
    '    If (i + 1) < LIGNES_MAX And (j + 1) < COLONNES_MAX Then
    '        If terrainMine(i + 1, j + 1) <> BOMBE Then
    '            terrainMine(i + 1, j + 1) = terrainMine(i + 1, j + 1) + 1
    '        End If
    '    End If
    'End Sub
    'Private Sub videTerrainMine()
    '    For i = 1 To LIGNES_MAX
    '        For j = 1 To COLONNES_MAX
    '            terrainMine(i - 1, j - 1) = 0
    '        Next
    '    Next
    'End Sub

    'Public Function grilleTerrainMines()
    '    Return terrainMine
    'End Function
    'Public Function getGrille()
    '    Return grille
    'End Function

    'Public Sub explore(ByRef uneCase As Point)
    '    listeCaseExplorer.Add(uneCase)

    '    While listeCaseExplorer.Count > 0
    '        Dim caseAExplorer As Point = listeCaseExplorer(0)
    '        Dim i As Integer = caseAExplorer.X
    '        Dim j As Integer = caseAExplorer.Y
    '        'MsgBox("i=" & i & "-j=" & j)
    '        If terrainMine(i, j) = 0 Then
    '            grille(i, j).Text = " "
    '            score = score + 1
    '            If (i - 1) >= 0 And (j - 1) >= 0 Then
    '                If grille(i - 1, j - 1).Text = "?" Then
    '                    addPoint(New Point(i - 1, j - 1))
    '                End If
    '            End If
    '            If (j - 1) >= 0 Then
    '                If grille(i, j - 1).Text = "?" Then
    '                    addPoint(New Point(i, j - 1))
    '                End If
    '            End If
    '            If (i + 1) < LIGNES_MAX And (j - 1) >= 0 Then
    '                If grille(i + 1, j - 1).Text = "?" Then
    '                    addPoint(New Point(i + 1, j - 1))
    '                End If
    '            End If
    '            If (i - 1) >= 0 Then
    '                If grille(i - 1, j).Text = "?" Then
    '                    addPoint(New Point(i - 1, j))
    '                End If
    '            End If
    '            If (i + 1) < LIGNES_MAX Then
    '                If grille(i + 1, j).Text = "?" Then
    '                    addPoint(New Point(i + 1, j))
    '                End If
    '            End If
    '            If (i - 1) >= 0 And (j + 1) < COLONNES_MAX Then
    '                If grille(i - 1, j + 1).Text = "?" Then
    '                    addPoint(New Point(i - 1, j + 1))
    '                End If
    '            End If
    '            If (j + 1) < COLONNES_MAX Then
    '                If grille(i, j + 1).Text = "?" Then
    '                    addPoint(New Point(i, j + 1))
    '                End If
    '            End If
    '            If (i + 1) < LIGNES_MAX And (j + 1) < COLONNES_MAX Then
    '                If grille(i + 1, j + 1).Text = "?" Then
    '                    addPoint(New Point(i + 1, j + 1))
    '                End If
    '            End If
    '            'MsgBox(listeCaseExplorer.Count)
    '        ElseIf terrainMine(i, j) < BOMBE Then
    '            grille(i, j).Text = terrainMine(i, j)
    '            score = score + 1
    '        ElseIf terrainMine(i, j) = BOMBE Then
    '            estPerdue = True
    '            grille(i, j).Text = BOMBE
    '        End If

    '        listeCaseExplorer.RemoveAt(0)
    '    End While
    'End Sub
    'Private Sub addPoint(p As Point)
    '    Dim estTrouve As Boolean = False
    '    Dim i As Integer = 0

    '    While (Not estTrouve) And i < (listeCaseExplorer.Count)
    '        If comparePoint(p, listeCaseExplorer(i)) Then
    '            estTrouve = True
    '        End If
    '        i = i + 1
    '    End While

    '    If Not estTrouve Then
    '        listeCaseExplorer.Add(p)
    '    End If
    'End Sub
    'Private Function comparePoint(ByRef p1 As Point, ByRef p2 As Point)
    '    If (p1.X = p2.X) And (p1.Y = p2.Y) Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
    'Public Function partiePerdue()
    '    Return estPerdue
    'End Function
    'Public Function estGagnee()
    '    Return (score + BOMBES_MAX) = (COLONNES_MAX * LIGNES_MAX)
    'End Function
    'Public Function getScore()
    '    Return score
    'End Function

End Module
