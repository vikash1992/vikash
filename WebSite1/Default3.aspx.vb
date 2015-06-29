Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Web.Services
Partial Class Default3
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    <WebMethod()> _
    Public Shared Function GetAutoCompleteData(ByVal SEARCH As String) As List(Of String)
        ''  MsgBox("bmbj")
        Dim result As New List(Of String)()
        Using con As New SqlConnection("Data Source=vikash;Integrated Security=true;Initial Catalog=clg2015")
            Using cmd As New SqlCommand("select DISTINCT SEARCH from SEARCH where SEARCH LIKE '%'+@SearchText+'%'", con)
                con.Open()
                cmd.Parameters.AddWithValue("@SearchText", SEARCH)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    ''MsgBox("COMMENT")
                    result.Add(dr("SEARCH").ToString())
                End While
                Return result
            End Using
        End Using
    End Function
  
   

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.ForeColor = Drawing.Color.Red
         Label1.Text = ""
    End Sub

    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton2.Click
        Response.Redirect("ForgetPassword.aspx")
    End Sub

    

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ss As String
        Dim NAME As String
        Dim PASS As String
        Dim aa As String = ""
        Dim id As String = ""
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        ss = " select * from REGIS WHERE EMAIL='" & TextBox1.Text & "' AND PASSWORD='" & TextBox2.Text & "'"
        cmd.CommandText = ss
        dtr = cmd.ExecuteReader()
        While dtr.Read() = True
            NAME = dtr("EMAIL")
            PASS = dtr("PASSWORD")
            aa = dtr("NAME")
            id = dtr("ID")
            Session.Add("MOBILE", dtr("MOBILE"))
        End While
        c.cnn.Close()
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            Label1.Text = "Please Enter User_Name and PassWord..."

        ElseIf TextBox1.Text = NAME And TextBox2.Text = PASS Then
            Session.Add("uname", aa)
            Session.Add("ID", id)
            ''''''   Server.MapPath("pro\" + Session("ID") + ".jpg")
            Response.Redirect("Profile.aspx")
        Else
            Label1.Text = "User_Name and PassWord is Wrong..."

        End If

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Response.Redirect("Reg.aspx")
    End Sub
End Class
