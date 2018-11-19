Public Class page2
    Dim chapter As new Integer
    Dim page As Integer
    Dim str As Integer
    Dim int As Integer
    Dim agi As Integer
    Dim wp As Integer
    Dim elem As Integer
    Dim skills As Integer
    Public kahihinatnan = 0
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

    Private Sub page2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Module1.connect()
        konek.Close()
        ds.Clear()
        grupage.Refresh()
        Refresh()

        konek.Open()
        adapt = New OleDb.OleDbDataAdapter("SELECT * FROM Table1", konek)
        adapt.Fill(ds, "Table1")
        grupage.DataSource = ""
        grupage.DataSource = ds.Tables("Table1")
        chapter = grupage.Item(1, 0).Value
        page = grupage.Item(2, 0).Value
        str = grupage.Item(3, 0).Value
        agi = grupage.Item(4, 0).Value
        int = grupage.Item(5, 0).Value
        wp = grupage.Item(6, 0).Value
        elem = grupage.Item(7, 0).Value
        skills = grupage.Item(8, 0).Value
        If kahihinatnan = 5 Then
            RichTextBox1.Text =
                ""
        ElseIf kahihinatnan = 1 Then
            RichTextBox1.Text =
                "There's no time to think, i run through the other door of our house and use every ounce of my" +
                " energy to run, i really don't care if something hit me just to get away from what i saw and " +
                " someone whom i saw. It lasted a few minutes before i knew i hit the tree and lost consciousness..."
        ElseIf kahihinatnan = 2 Then
            RichTextBox1.Text =
                "I fall silent........................................................... thinking of what happen, someone murdered my mom and dad, if they're gone" +
                " my family is broken,........... my life is not just the same as always if this will continue, oh I remembered someone is coming in my position" +
                " ..............................I don't really care, perhaps I might use my strength to the fullest........, so what............ if i die anyway?." +
                vbCrLf + "I started to walk like him with no expression on my face to him, when we were 2 meters apart" +
                "He tried to stab me in head but i hold it with my left hand and now it's bleeding, after that my other hands" +
                " reached his neck and with my rage, I squeeze it as much as i can but he grab my hand and release it but then" +
                " I bit his arm like a mad dog and I think it doesn't matter if my teeth comes off, and then he screams so loud" +
                " he jumps back and he realized our neighbors are starting to turn on their lights and then he says :'I'll come back! be prepared" +
                " that words echoed into my mind and then lost consciousness and fall from where i'm standing..."
        ElseIf kahihinatnan = 3 Then
            RichTextBox1.Text =
                "........... I'm starting to cry....I can't believe this!. My mom and dad are dead just like that? I mean look at me!!.. I'm still young!" +
                " and they left me so soon; but that's not the case, it didn't seems like they wanted to left me, someone murdered them... Tears started to fall..." +
                " .....sniff...sniff!!... HUGHAAAAAAAAAAAA~~~~.......I cried and yelled at the top of my lungs!!" + "and now the unknown man shocked" +
                " he realized someone might heared the noises i made and come over to our house." + ".. ' I'll Come Back!! ' the unknown man said as he left our house" +
                "....................................." + vbCrLf + "Dad......mom...........I'm sorr-- it didn't finish my word and i lost consciousness to the floor..."
        ElseIf kahihinatnan = 4 Then
            RichTextBox1.Text =
                "At a time like this, being freaked out means you lose, to think is to made a possibilities" +
                " I remembered what dad told me when i was a kid, there's a hidden door there and it leads to the other place" +
                " he also said that it can be used when hiding so I started to throw something at him for distraction" +
                " and then run to my room and i reached the secret button which'll lead me to other side and then closes the door" +
                " there's no time to cry, to feel anger, i think my mind is so full that i can't think of anything except my survival..." +
                " an hour later of hiding, i fell asleep....."
        End If
    End Sub

    Private Sub SaveGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveGameToolStripMenuItem.Click
        adapt = New OleDb.OleDbDataAdapter("Update Table1 set chapter = " + chapter.ToString + ", page = " + page.ToString + ", str = " + Str.ToString + ", [int] = " + Int.ToString + ", wp = " + wp.ToString + ", agi = " + agi.ToString + ", elem = " + elem.ToString + ", skills = " + skills.ToString + "", konek)
        adapt.Fill(ds, "Table1")
        grupage.DataSource = ds.Tables("Table1")
        MsgBox("Game Saved!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        page += 1
        adapt = New OleDb.OleDbDataAdapter("Update Table1 set chapter = page = 3", konek)
        adapt.Fill(ds, "Table1")
        grupage.DataSource = ds.Tables("Table1")
        Close()
        konek.Close()
        page3.Show()

    End Sub
End Class