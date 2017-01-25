Public Class Form1

    Private Sub tmrAcross_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAcross.Tick
        Dim ptNew As Point
        If picMove.Location.X = 0 Then
            ptNew.X = 587
        Else
            ptNew.X = picMove.Location.X - 5
        End If
        ptNew.Y = picMove.Location.Y
        picMove.Location = ptNew
    End Sub

    Private Sub tmrDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDown.Tick
        Dim ptNew As Point
        ptNew.X = picMove.Location.X
        ptNew.Y = picMove.Location.Y + 5
        picMove.Location = ptNew
    End Sub

    Private Sub tmrDiag_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDiag.Tick
        Dim ptNew As Point
        ptNew.X = picMove.Location.X - 5
        ptNew.Y = picMove.Location.Y + 5
        picMove.Location = ptNew
    End Sub

    Private Sub btnDiag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiag.Click
        tmrDiag.Start()
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        tmrDown.Start()
    End Sub

    Private Sub btnAcross_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcross.Click
        tmrAcross.Start()
    End Sub

    Private Sub tmrAnimate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAnimate.Tick
        Static intCounter As Integer = 0
        If intCounter = 0 Then
            picAnimate.Image = My.Resources.Wave00
            intCounter += 1
        ElseIf intCounter = 1 Then
            picAnimate.Image = My.Resources.Wave01
            intCounter += 1
        ElseIf intCounter = 2 Then
            picAnimate.Image = My.Resources.Wave02
            intCounter += 1
        ElseIf intCounter = 3 Then
            picAnimate.Image = My.Resources.Wave03
            intCounter += 1
        ElseIf intCounter = 4 Then
            picAnimate.Image = My.Resources.Wave04
            intCounter += 1
        ElseIf intCounter = 5 Then
            picAnimate.Image = My.Resources.Wave05
            intCounter += 1
        ElseIf intCounter = 6 Then
            picAnimate.Image = My.Resources.Wave06
            intCounter += 1
        ElseIf intCounter = 7 Then
            picAnimate.Image = My.Resources.Wave07
            intCounter += 1
        ElseIf intCounter = 8 Then
            picAnimate.Image = My.Resources.Wave08
            intCounter += 1
        ElseIf intCounter = 9 Then
            picAnimate.Image = My.Resources.Wave09
            intCounter += 1
        ElseIf intCounter = 10 Then
            picAnimate.Image = My.Resources.Wave10
            intCounter += 1
        ElseIf intCounter = 11 Then
            picAnimate.Image = My.Resources.Wave11
            intCounter += 1
        ElseIf intCounter = 12 Then
            picAnimate.Image = My.Resources.Wave12
            intCounter += 1
        ElseIf intCounter = 13 Then
            picAnimate.Image = My.Resources.Wave13
            intCounter += 1
        ElseIf intCounter = 14 Then
            picAnimate.Image = My.Resources.Wave14
            intCounter += 1
        ElseIf intCounter = 15 Then
            picAnimate.Image = My.Resources.Wave15
            intCounter += 1
        ElseIf intCounter = 16 Then
            picAnimate.Image = My.Resources.Wave16
            intCounter += 1
        ElseIf intCounter = 17 Then
            picAnimate.Image = My.Resources.Wave17
            intCounter += 1
        ElseIf intCounter = 18 Then
            picAnimate.Image = My.Resources.Wave18
            intCounter += 1
        ElseIf intCounter = 19 Then
            picAnimate.Image = My.Resources.Wave19
            intCounter += 1
        ElseIf intCounter = 20 Then
            picAnimate.Image = My.Resources.Wave20
            intCounter += 1
        ElseIf intCounter = 21 Then
            picAnimate.Image = My.Resources.Wave21
            intCounter = 0
        End If
    End Sub
End Class
