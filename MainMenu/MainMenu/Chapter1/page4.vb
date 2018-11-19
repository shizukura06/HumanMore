Public Class page4

    Dim chapter As New Integer
    Dim page As Integer
    Dim str As Integer
    Dim int As Integer
    Dim agi1 As Integer
    Dim wp As Integer
    Dim elem As Integer
    Dim skills As Integer
    Dim nickname

    Private Sub StatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatsToolStripMenuItem.Click
        Stats.ShowDialog()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        Close()
        konek.Close()
        Prophecy.Show()
        page1.Close()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub page4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.connect()
        konek.Close()
        ds.Clear()
        grupage1.Refresh()
        Refresh()
        konek.Open()

        adapt = New OleDb.OleDbDataAdapter("update Table1 set page = 4", konek)
        adapt.Fill(ds, "Table1")
        adapt = New OleDb.OleDbDataAdapter("SELECT * FROM Table1", konek)
        adapt.Fill(ds, "Table1")
        grupage1.DataSource = ""
        grupage1.DataSource = ds.Tables("Table1")
        nickname = grupage1.Item(0, 0).Value.ToString
        chapter = grupage1.Item(1, 0).Value
        page = grupage1.Item(2, 0).Value
        str = grupage1.Item(3, 0).Value
        agi1 = grupage1.Item(4, 0).Value
        int = grupage1.Item(5, 0).Value
        wp = grupage1.Item(6, 0).Value
        elem = grupage1.Item(7, 0).Value
        skills = grupage1.Item(8, 0).Value

        RichTextBox1.Text =
    "'Huffs!!!! I'm so bored here at my room, walking and circling around, playing video games at my phones such a boring life!'. I said when I got home and my guardian believes me and said that I should rest and do something what I like" +
    " 'Hmmmmm yeah!, what should I do?' I throw myself into bed and stared at the ceiling... 'Think! " + nickname.ToString + "... just think " + nickname.ToString + "!" + vbCrLf +
    "Maybe I should....."

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Strength +3", MsgBoxStyle.Information)
        str += 3
        adapt = New OleDb.OleDbDataAdapter("Update Table1 set chapter = " + chapter.ToString + ", page = " + page.ToString + ", str = " + str.ToString + ", [int] = " + int.ToString + ", wp = " + wp.ToString + ", agi = " + agi1.ToString + ", elem = " + elem.ToString + ", skills = " + skills.ToString + ", kahihinatnan = 4", konek)
        adapt.Fill(ds, "Table1")
        MsgBox("Sorry but this is all i've got!, tell me if i should continue doing this. BTW thanks for playing")
        If MsgBoxResult.Ok Then
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Element +1" + vbCrLf + "Will Power +1" + vbCrLf + "Intelligence +1" + vbCrLf + "Agility +1" + vbCrLf + "Strength +1", MsgBoxStyle.Information)
        elem += 1
        str += 1
        int += 1
        wp += 1
        agi1 += 1
        adapt = New OleDb.OleDbDataAdapter("Update Table1 set chapter = " + chapter.ToString + ", page = " + page.ToString + ", str = " + str.ToString + ", [int] = " + int.ToString + ", wp = " + wp.ToString + ", agi = " + agi1.ToString + ", elem = " + elem.ToString + ", skills = " + skills.ToString + ", kahihinatnan = 4", konek)
        adapt.Fill(ds, "Table1")
        MsgBox("Sorry but this is all i've got!, tell me if i should continue doing this. BTW thanks for playing")
        If MsgBoxResult.Ok Then
            End
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Element +1" + vbCrLf + "Will Power +1", MsgBoxStyle.Exclamation)
        MsgBox("Sorry but this is all i've got!, tell me if i should continue doing this. BTW thanks for playing")
        If MsgBoxResult.Ok Then
            End
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Intelligence +4", MsgBoxStyle.Information)
        int += 4
        adapt = New OleDb.OleDbDataAdapter("Update Table1 set chapter = " + chapter.ToString + ", page = " + page.ToString + ", str = " + str.ToString + ", [int] = " + int.ToString + ", wp = " + wp.ToString + ", agi = " + agi1.ToString + ", elem = " + elem.ToString + ", skills = " + skills.ToString + ", kahihinatnan = 4", konek)
        adapt.Fill(ds, "Table1")
        MsgBox("Sorry but this is all i've got!, tell me if i should continue doing this. BTW thanks for playing")
        If MsgBoxResult.Ok Then
            End
        End If
    End Sub
End Class