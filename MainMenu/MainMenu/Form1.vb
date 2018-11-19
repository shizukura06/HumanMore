Public Class Prophecy
    Dim chapter
    Dim page
    Dim kahihinatnan
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        About.ShowDialog()
    End Sub

    Private Sub StatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatsToolStripMenuItem.Click
        Stats.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grumenu.Refresh()

        Me.Hide()
        Dialog1.ShowDialog()
    End Sub

    Private Sub Prophecy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.connect()
        grumenu.DataSource = ""
        grumenu.Refresh()
        ds.Clear()
        adapt = New OleDb.OleDbDataAdapter("SELECT * FROM Table1", konek)
        adapt.Fill(ds, "Table1")
        grumenu.DataSource = ds.Tables("Table1")
        chapter = grumenu.Item(1, 0).Value
        page = grumenu.Item(2, 0).Value
        kahihinatnan = grumenu.Item(9, 0).Value
        konek.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Module1.connect()
        grumenu.DataSource = ""
        grumenu.Refresh()
        ds.Clear()
        adapt = New OleDb.OleDbDataAdapter("SELECT * FROM Table1", konek)
        adapt.Fill(ds, "Table1")
        grumenu.DataSource = ds.Tables("Table1")
        chapter = grumenu.Item(1, 0).Value
        page = grumenu.Item(2, 0).Value
        kahihinatnan = grumenu.Item(9, 0).Value
        If grumenu.Item(0, 0).Value = "" Then
            MsgBox("No Saved game found!")
        Else
            If page = 1 Then
                Me.Hide()
                page1.Show()
            ElseIf page = 2 Then
                page2.Close()
                page2.kahihinatnan = kahihinatnan
                page2.Show()
                Me.Hide()
                page1.Close()
            ElseIf page = 3 Then
                page1.Close()
                page2.Close()
                page3.Close()
                page3.Show()
                Me.Hide()
            ElseIf page = 4 Then
                page1.Close()
                page2.Close()
                page3.Close()
                page4.Close()
                page4.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Help doesn't exist!, the interface is super user-friendly/ child-friendly. you don't need help, you're a grown person... just kidding :)")
    End Sub
End Class
