Public Class DeadEnd
    Public ending = 0
    Private Sub StatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatsToolStripMenuItem.Click
        Stats.ShowDialog()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        Prophecy.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub DeadEnd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ending = 1 Then
            RichTextBox1.Text =
                "Of course I'll fight him! No matter who he is, I can't think of anything else and" +
                " the moment like this can't just sunk in very easily." + vbCrLf +
                "I breathe heavilyy and release in one blow and then rush to the unknown man, tried to punch him" +
                " but he grab me like a flash and then something sharp is coming out on his hand and it" +
                " stab me in the chest, i started to feel coldness and i can't feel anything even my eyes" +
                " Until i lost consciousness"
        ElseIf ending = 2 Then
            RichTextBox1.Text =
                "I hurriedly get anything i can see around me and throw it to the person standing there" +
                " he's just avoiding it while walking very calm and i tried to lift a heavy thing and throw it to him" +
                " but he grab me like a flash behind me and then something sharp is coming out on his hand and it" +
                " stab me in the chest, i started to feel coldness and i can't feel anything even my eyes" +
                " Until i lost consciousness"
        ElseIf ending = 3 Then
        ElseIf ending = 4 Then
        ElseIf ending = 5 Then
        ElseIf ending = 6 Then
        ElseIf ending = 7 Then
        ElseIf ending = 8 Then
        ElseIf ending = 9 Then
        ElseIf ending = 10 Then
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class