Public Class page1
    Dim chapter As Integer
    Dim page As Integer
    Dim str As Integer
    Dim int As Integer
    Dim agi1 As Integer
    Dim wp As Integer
    Dim elem As Integer
    Dim skills As Integer
    Dim kahihinatnan As Integer

    Private Sub StatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatsToolStripMenuItem.Click
        Stats.ShowDialog()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        Me.Hide()
        Prophecy.Show()
        konek.Close()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub page1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.connect()

        adapt = New OleDb.OleDbDataAdapter("SELECT * FROM Table1", konek)
        ds.Clear()
        adapt.Fill(ds, "Table1")
        grupage1.Refresh()
        grupage1.DataSource = ds.Tables("Table1")
        chapter = grupage1.Item(1, 0).Value
        page = grupage1.Item(2, 0).Value
        str = grupage1.Item(3, 0).Value
        agi1 = grupage1.Item(4, 0).Value
        int = grupage1.Item(5, 0).Value
        wp = grupage1.Item(6, 0).Value
        elem = grupage1.Item(7, 0).Value
        skills = grupage1.Item(8, 0).Value
        kahihinatnan = grupage1.Item(9, 0).Value

        RichTextBox1.Text =
            "I woke up from my bed by some weird noises, I think I heard someone scream, sounds like its their loudest voice then suddenly the scream stopped. " +
            "I stretched my arm to reach my phone and seeing it's still 2am at my phone's time, walking to the door then turn the lights on and i saw someone lying on the ground covered with blood. " +
            "It's mom and dad!!!" + vbCrLf + "As i saw them, there is someone standing in the shadows holding a long knife " +
            "Our eyes met and he's coming where i stand right now." + vbCrLf +
            "I can't hold my mind and i think i'm about to..."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeadEnd.ending = 1
        DeadEnd.Show()
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DeadEnd.ending = 2
        DeadEnd.Show()
        Close()
    End Sub

    Private Sub SaveGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveGameToolStripMenuItem.Click
        ds.Clear()
        adapt = New OleDb.OleDbDataAdapter("Update Table1 set chapter = " + chapter.ToString + ", page = " + page.ToString + ", str = " + str.ToString + ", [int] = " + int.ToString + ", wp = " + wp.ToString + ", agi = " + agi1.ToString + ", elem = " + elem.ToString + ", skills = " + skills.ToString + "", konek)
        adapt.Fill(ds, "Table1")
        MsgBox("Game Saved!")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Intelligence +1", MsgBoxStyle.Information)
        int = int + 1
        page += 1
        kahihinatnan = 4
        adapt = New OleDb.OleDbDataAdapter("Update Table1 set chapter = " + chapter.ToString + ", page = " + page.ToString + ", str = " + str.ToString + ", [int] = " + int.ToString + ", wp = " + wp.ToString + ", agi = " + agi1.ToString + ", elem = " + elem.ToString + ", skills = " + skills.ToString + ", kahihinatnan = 4", konek)
        ds.Clear()
        adapt.Fill(ds, "Table1")
        grupage1.Refresh()
        page2.kahihinatnan = 4
        page2.Show()
        konek.Close()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Will Power +1", MsgBoxStyle.Information)
        wp += 1
        page += 1
        kahihinatnan = 3
        ds.Clear()
        adapt = New OleDb.OleDbDataAdapter("Update Table1 set chapter = " + chapter.ToString + ", page = " + page.ToString + ", str = " + str.ToString + ", [int] = " + int.ToString + ", wp = " + wp.ToString + ", agi = " + agi1.ToString + ", elem = " + elem.ToString + ", skills = " + skills.ToString + ", kahihinatnan = 3", konek)
        adapt.Fill(ds, "Table1")
        page2.kahihinatnan = 3
        page2.Show()
        konek.Close()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        page += 1
        kahihinatnan = 1
        ds.Clear()

        adapt = New OleDb.OleDbDataAdapter("Update Table1 set chapter = " + chapter.ToString + ", page = " + page.ToString + ", str = " + str.ToString + ", [int] = " + int.ToString + ", wp = " + wp.ToString + ", agi = " + agi1.ToString + ", elem = " + elem.ToString + ", skills = " + skills.ToString + ", kahihinatnan = 1", konek)
        adapt.Fill(ds, "Table1")
        page2.kahihinatnan = 1
        page2.Show()
        Close()
        konek.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Will Power +1" + vbCrLf + "Intelligence +1" + vbCrLf + "Strength +1" + vbCrLf + "Agility +1", MsgBoxStyle.Information)
        wp += 1
        agi1 += 1
        int += 1
        str += 1
        page += 1
        kahihinatnan = 2
        ds.Clear()
        adapt = New OleDb.OleDbDataAdapter("Update Table1 set chapter = " + chapter.ToString + ", page = " + page.ToString + ", str = " + str.ToString + ", [int] = " + int.ToString + ", wp = " + wp.ToString + ", agi = " + agi1.ToString + ", elem = " + elem.ToString + ", skills = " + skills.ToString + ", kahihinatnan = 2", konek)
        adapt.Fill(ds, "Table1")
        page2.kahihinatnan = 2
        page2.Show()
        Close()
        konek.Close()
    End Sub


End Class