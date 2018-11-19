Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Enter your name!")
        Else
            adapt = New OleDb.OleDbDataAdapter("Update Table1 set nickname = '" + TextBox1.Text + "', chapter = 1, page = 1, str = 0, [int] = 0, wp = 0, agi = 0, elem = 0, skills = 0, kahihinatnan = 0", konek)
            adapt.Fill(ds, "Table1")
            gruname.DataSource = ds.Tables("Table1")
            konek.Close()
            Me.Close()
            page1.Show()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
        Prophecy.Show()
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds.Clear()
        Module1.connect()
        adapt = New OleDb.OleDbDataAdapter("SELECT * FROM Table1", konek)
        adapt.Fill(ds, "Table1")
        gruname.DataSource = ds.Tables("Table1")
    End Sub
End Class
