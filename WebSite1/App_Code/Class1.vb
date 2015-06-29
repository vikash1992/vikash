

Imports System.Data.OleDb

Public Class conn



    Public cnn As New OleDbConnection
    Public Function connect() As OleDbConnection
        '  cnn = New OleDbConnection("Data Source=.\SQLEXPRESS;Initial Catalog=db1;Integrated Security=SSPI;Pooling=False;Provider=SQLOLEDB.1")
        cnn = New OleDbConnection("Data Source=vikash;Initial Catalog=clg2015;Integrated Security=SSPI;Pooling=False;Provider=SQLOLEDB.1")

        cnn.Close()
        If cnn.State = 0 Then
            cnn.Open()
        End If
        Return cnn

    End Function
End Class
