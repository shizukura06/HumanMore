Module Module1

    Public konek As OleDb.OleDbConnection
    Public adapt As OleDb.OleDbDataAdapter
    Public ds As New DataSet

    Sub connect()


        konek = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Steven Dale Lucero\Documents\dbdb.mdb;Persist Security Info=False;")
        konek.Open()

    End Sub
End Module
