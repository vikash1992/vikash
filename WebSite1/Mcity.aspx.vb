
Partial Class Mcity
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    Dim i As String
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        If DropDownList1.Text = "State" Then
            Label1.Text = "Select State"
        ElseIf TextBox8.Text = "" Then
            Label1.Text = "Enter City"
        Else
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            cmd.CommandText = "insert into CITY(SID,CITY) VALUES('" & DropDownList1.Text & "','" & TextBox8.Text & "')"
            cmd.ExecuteNonQuery()

            c.cnn.Close()
            TextBox8.Text = ""
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            DropDownList1.Items.Add("State")

            Dim ss As String
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = "SELECT * FROM STATE"
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                DropDownList1.Items.Add(dtr("STATE"))
            End While
            c.cnn.Close()
        End If
    End Sub
End Class
