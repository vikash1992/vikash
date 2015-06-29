
Partial Class Subtype
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        cmd.CommandText = "insert into SUBITEM(ITEM,SUB_ITEM) VALUES('" & DropDownList1.Text & "','" & TextBox1.Text & "')"
        cmd.ExecuteNonQuery()
        c.cnn.Close()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then


            Dim ss As String
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = " select DISTINCT ITEM_TYPE  from TYPE"
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                DropDownList1.Items.Add(dtr("ITEM_TYPE"))
            End While
            c.cnn.Close()
        End If
    End Sub
End Class
