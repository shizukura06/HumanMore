Public Class Stats

    'Private pCn As OleDb.OleDbConnection
    Private Sub Stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh()
        gru.Refresh()
        ds.Clear()
        Dim getAll = "Select * From Table1"
        'TODO: This line of code loads data into the 'Ds1.Table1' table. You can move, or remove it, as needed.
        'Me.Table1TableAdapter.Fill(Me.Ds1.Table1)


        'Dim quer = "Update Table1 set str = 1 where str = 0"

        'Dim ds As New DataSet
        'Dim row As DataRow

        'pCn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Steven Dale Lucero\Documents\dbdb.mdb;Persist Security Info=False;")

        'Try

        '         Call pCn.Open()
        '      Catch ex As Exception
        '           MessageBox.Show("Could not connect for some reason.... is the file on the right location? --> check connectionstring")
        '        End Try


        'If pCn.State = ConnectionState.Open Then
        'Dim adaptor As New OleDb.OleDbDataAdapter(quer, pCn)
        'adaptor.Fillds(, "Table1")

        'Dim sql As New OleDb.OleDbCommand("SELECT * FROM Table1", pCn)


        'End If

        Module1.connect()
        adapt = New OleDb.OleDbDataAdapter("SELECT * FROM Table1", konek)
        adapt.Fill(ds, "Table1")

        gru.DataSource = ds.Tables("Table1")
        gru.Refresh()
        str.Text = gru.Item(3, 0).Value
        agi.Text = gru.Item(4, 0).Value
        int.Text = gru.Item(5, 0).Value
        wp.Text = gru.Item(6, 0).Value
        elem.Text = gru.Item(7, 0).Value
        skills.Text = gru.Item(8, 0).Value
    End Sub

End Class