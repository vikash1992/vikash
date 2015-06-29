
Partial Class Changepassword
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    

    Protected Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

   

    

    

    

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" And TextBox3.Text = "" Then
            Label1.Text = "Enter password"
        ElseIf TextBox2.Text <> TextBox3.Text Then
            Label1.Text = "Password not match"
        ElseIf Session("code") = TextBox1.Text Then

            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            cmd.CommandText = "update REGIS set PASSWORD='" & TextBox2.Text & "' where EMAIL='" & Session("mail") & "'"
            cmd.ExecuteNonQuery()

            c.cnn.Close()
            Response.Redirect("Default3.aspx")
        End If
    End Sub
End Class
