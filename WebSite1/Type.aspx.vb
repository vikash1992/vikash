
Partial Class Type
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DropDownList4.Text = "Select_Type" Then
            Label1.Text = "Select Type"
        ElseIf TextBox1.Text = "" Then
            Label1.Text = "Enter Product Type"
        Else




            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            cmd.CommandText = "insert into TYPE(TYPE,ITEM_TYPE) VALUES('" & DropDownList4.Text & "','" & TextBox1.Text & "')"
            cmd.ExecuteNonQuery()
            c.cnn.Close()
            Response.Redirect("Subtype.aspx")
        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class
