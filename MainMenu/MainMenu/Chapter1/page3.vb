Public Class page3
    Dim chapter As New Integer
    Dim page As Integer
    Dim str As Integer
    Dim int As Integer
    Dim agi As Integer
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

    Private Sub page3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        nickname = grupage.Item(0, 0).Value.ToString
        chapter = grupage.Item(1, 0).Value
        page = grupage.Item(2, 0).Value
        str = grupage.Item(3, 0).Value
        agi = grupage.Item(4, 0).Value
        int = grupage.Item(5, 0).Value
        wp = grupage.Item(6, 0).Value
        elem = grupage.Item(7, 0).Value
        skills = grupage.Item(8, 0).Value
        adapt = New OleDb.OleDbDataAdapter("update Table1 set page = 3", konek)
        adapt.Fill(ds, "Table1")
        RichTextBox1.Text =
            "1 year later, after from that, someone saw me lying on the ground and then took me over their home, and now, it's our home!" +
            " I am living a well life, today is my school day, second year high school, 16 years old and my name is " + nickname.ToString + vbCrLf + vbCrLf +
            "here at the school, it's recess time! all of my classmates go downstares and the only person left in the room is me and the guy holding a baseball bat...     'Heey! " + nickname + "' someone's calling me from my seat. 'hey buddy, i'm kinda broke today, so i'm sure you'll borro-- eeerg i mean you'll give me all of your money right?'" +
            " as the guy said while holding his baseball bat, I spoke. 'I don't have any, if I have some I won't give it to you, go away!'. and I said that to him. 'You really wanted to die, do you?'. he say and now he's holding the bat with more grip" +
            " at a time like this i would definitely...."
    End Sub

    Private Sub SaveGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveGameToolStripMenuItem.Click
        adapt = New OleDb.OleDbDataAdapter("Update Table1 set chapter = " + chapter.ToString + ", page = " + page.ToString + ", str = " + str.ToString + ", [int] = " + int.ToString + ", wp = " + wp.ToString + ", agi = " + agi.ToString + ", elem = " + elem.ToString + ", skills = " + skills.ToString + "", konek)
        adapt.Fill(ds, "Table1")
        grupage.DataSource = ds.Tables("Table1")
        MsgBox("Game Saved!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(str.ToString) >= 1 Then
            MsgBox("Strength = 1 Detected!", MsgBoxStyle.Information)
            Button1.Visible = False
            Button2.Text = "Continue"
            Button3.Visible = False
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + vbCrLf + "I stayed calm and resist of what's coming, he suddenly swing the bat at the back of my head and" +
                " the bat broke into pieces but i still remain without moving an inch. 'is that all you've got?' i said, and some trickle of sweat down on his face" +
                " his knees are shaking and after few seconds, he run away!. I guess that strength i've got from the past is really helpful but the class came back, the teachers came" +
                " they get me to the guidance office, he was ther!, what he's telling are all lies, and they ended up believing the guy just because he was frightened and I am calm. They suspended me for 1 week"
        Else
            MsgBox("Strength = 1 Failed!", MsgBoxStyle.Critical)
            Button1.Visible = False
            Button2.Text = "Game Over"
            Button3.Visible = False
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + vbCrLf + "I stay still, I guess a student at highschool wouldn't do something that bad. But then he swings his bat at the back of my head behind neck and it crushes my skull that'll cause more blood, I didn't know this would happen, as I lost consciousness that will lead to death!"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Game Over" Then
            Close()
            konek.Close()
            page2.Close()
            page1.Close()
            Prophecy.Show()
        ElseIf Button2.Text = "Continue" Then
            Me.Close()
            konek.Close()
            page4.Show()
        Else
            If Val(agi.ToString) >= 1 Then
                MsgBox("Agility = 1 Detected!", MsgBoxStyle.Information)
                Button1.Visible = False
                Button2.Text = "Continue"
                Button3.Visible = False
                RichTextBox1.Text = "He's about to hit the bat at the back of my head behind my neck, an inch apart between the bat and my head when i suddenly disappeared and show behind him " +
                    "Staring with devilish smile on my face, he gulped and then he swing again his bat but he missed, looking him behind again I started to kick him in his face, losing his balance" +
                    "and throwing him off outside the classroom... he shout and cried. After few minutes, the bell rang and the class came back again and I ended lectured and suspended for 1 week"
            Else
                MsgBox("Agility = 1 Failed!", MsgBoxStyle.Critical)
                Button1.Visible = False
                Button2.Text = "Game Over"
                Button3.Visible = False
                RichTextBox1.Text = "I tried to get behind him, but i was too slow to react, the bat swings behind me and that'll lead me to bleed alot, and then before i know, I was swimming in my own blood. I died."
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Val(int.ToString) >= 1 Then
            MsgBox("Intelligence = 1 Detected!", MsgBoxStyle.Information)
            Button1.Visible = False
            Button2.Text = "Continue"
            Button3.Visible = False
            RichTextBox1.Text = "I stared at him for  few seconds. 'Okay I'll give you my money' I said while getting something from my pocket and I hold something pointy, it's definitely a ballpen. 'HAHAHA, that's the " +
                "way more like it' he said and started to come closer. I think, and it's like the time is slowed down for 80%... he's about 7 meters away from me, while walking his head is waving 20 centimeters horizontally every footstep " +
                " , from his stance, the guy uses approximately 7% of his strength. The color of his skin, his facial expression, the guy's eyelid is opened a little differ from default which will prove and cost 400% evidences that he " +
                "is calm, acting like a boss and he is thinking like i'm innocent. and i finished thinking like it cost me like 1.3 seconds, for the next 2 seconds, he's now 5 meters away, I throw the ballpen with an angle of 390 degrees from starter " +
                " and the force is 1.1 kilo joules and the attack is spinning so the air resistant is reduced and the 390 degrees become 360 horizontally straight for exact 4.6 meters through his eyes with the prediction of his last footstep is left foot and it hit his eyes!." +
                vbCrLf + "'AAARRRGGHH!!~~~~' he shout and cried to ground, the bell rang and the class came back again and I ended lectured and suspended for 1 week"
        Else
            MsgBox("Intelligence = 1 Failed!", MsgBoxStyle.Critical)
            Button1.Visible = False
            Button2.Text = "Game Over"
            Button3.Visible = False
            RichTextBox1.Text = "I stay still, I guess a student at highschool wouldn't do something that bad. But then he swings his bat at the back of my head behind neck and it crushes my skull that'll cause more blood, I didn't know this would happen, as I lost consciousness that will lead to death!"
        End If
    End Sub
End Class