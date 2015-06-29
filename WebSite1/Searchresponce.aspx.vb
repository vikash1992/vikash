
Partial Class Searchresponce
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.Visible = False
        Image2.Visible = False
        Image1.BorderColor = Drawing.Color.SkyBlue
        Image1.BorderWidth = 1
        Try
            If Session("ID").ToString <> "" Then
                TextBox1.Visible = True
                Image2.Visible = True
                Image2.ImageUrl = "~/pro_image/" + Session("img") + ".png"
            End If
        Catch ex As Exception

        End Try
        Dim ss As String
        '' MsgBox(Session("img"))

        ''    Panel3.BackColor = Drawing.Color.CornflowerBlue
        If Not IsPostBack Then
            Image1.ImageUrl = Session("imageurl")
        End If
        If Session("imagelink").ToString <> "" Then


            Dim i As Integer = 0
             cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = "select * from ITEMS_IMAGES,ITEM_DETAIL ,REGIS where ITEMS_IMAGES .PID =ITEM_DETAIL .PID and ITEM_DETAIL .RID = REGIS .id and ITEMS_IMAGES .PID = " & Val(Session("imagelink")) & " "
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                Dim image As New ImageButton
                image.Width = 60
                image.Height = 40
                image.ImageUrl = dtr("IMAGE")
                image.ID = dtr("IPID")
                Panel4.GroupingText = " ₹ " + dtr("XYX")
                AddHandler image.Click, AddressOf PrintMessage
                Label1.Text = dtr("NAME")
                Label2.Text = dtr("ADDRESS")
                Label3.Text = dtr("CITY")
                Label4.Text = dtr("STATE")
                Label5.Text = dtr("MOBILE")
                Label6.Text = dtr("EMAIL")
                Label7.Text = dtr("TYPE")
                Label8.Text = dtr("ITEM_TYPE")
                Label9.Text = dtr("SUB_ITEM_TYPE")
                Label10.Text = dtr("ABOUT")
                Session.Add("PID", dtr("PID"))
                ''    Panel4.BorderColor = Drawing.Color.SkyBlue
                Panel3.Controls.Add(image)
            End While
            c.cnn.Close()
            'Else

            '    Dim i As Integer = 0
            '    cmd.Connection = c.connect()
            '    cmd.CommandType = Data.CommandType.Text
            '    ss = "select * from ITEMS_IMAGES,ITEM_DETAIL ,REGIS where ITEMS_IMAGES .PID =ITEM_DETAIL .PID and ITEM_DETAIL .RID = REGIS .id and ITEMS_IMAGES.IMAGE = " & Val(Session("imagelink1")) & " "
            '    cmd.CommandText = ss
            '    dtr = cmd.ExecuteReader()
            '    While dtr.Read() = True
            '        Dim image As New ImageButton
            '        image.Width = 60
            '        image.Height = 40
            '        image.ImageUrl = dtr("IMAGE")
            '        image.ID = dtr("IPID")
            '        Panel4.GroupingText = " ₹ " + dtr("XYX")
            '        AddHandler image.Click, AddressOf PrintMessage
            '        Label1.Text = dtr("NAME")
            '        Label2.Text = dtr("ADDRESS")
            '        Label3.Text = dtr("CITY")
            '        Label4.Text = dtr("STATE")
            '        Label5.Text = dtr("MOBILE")
            '        Label6.Text = dtr("EMAIL")
            '        Label7.Text = dtr("TYPE")
            '        Label8.Text = dtr("ITEM_TYPE")
            '        Label9.Text = dtr("SUB_ITEM_TYPE")
            '        Label10.Text = dtr("ABOUT")
            '        Session.Add("PID", dtr("PID"))

            '        Panel3.Controls.Add(image)
            '    End While
            '    c.cnn.Close()

        End If

         cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        ss = "select  * from COMMENT,IREGI,REGIS  where COMMENT.ID = IREGI .RID and COMMENT .ID = REGIS .id AND COMMENT.PID=" & Val(Session("PID")) & " order by CID "
        cmd.CommandText = ss
        dtr = cmd.ExecuteReader()
        While dtr.Read() = True
            Dim table1 As New Table()
            table1.BorderWidth = 1
            table1.BorderColor = Drawing.Color.SkyBlue
            Dim row As New TableRow()
            Dim cal1 As New TableCell()
            Dim cal2 As New TableCell()
            cal2.Width = 400
            Dim pro As New Image
            pro.ImageUrl = "~/pro_image/" + dtr("IMAGE") + ".png"
            Dim comm, comm1 As New Label
            comm.ForeColor = Drawing.Color.Blue
            ''  comm.Font.Bold = True
            comm.Text = dtr("NAME") + " Say "
            comm1.Text = dtr("COMMENT")
            Dim name As New Label
            comm.Font.Size = 10
            comm1.Font.Size = 10
            name.Font.Bold = True
            name.Text = dtr("NAME")
            name.Width = 340
            pro.Height = 35
            pro.Width = 45
            cal1.VerticalAlign = VerticalAlign.Top
            cal1.VerticalAlign = VerticalAlign.Top
            cal1.Controls.Add(pro)
            row.Cells.Add(cal1)
            cal2.Controls.Add(name)
            cal2.Controls.Add(comm)
            cal2.Controls.Add(comm1)
            row.Cells.Add(cal2)
            table1.Rows.Add(row)
            Panel5.Controls.Add(table1)
            
        End While
        c.cnn.Close()
    End Sub
    Private Sub PrintMessage(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TypeOf sender Is ImageButton Then
            Image1.ImageUrl = CType(sender, ImageButton).ImageUrl
        End If
    End Sub

    Protected Sub TextBox1_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.DataBinding

    End Sub

    Protected Sub TextBox1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Disposed

    End Sub

    Protected Sub TextBox1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Init

    End Sub

    Protected Sub TextBox1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Load

    End Sub

    Protected Sub TextBox1_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.PreRender

    End Sub
    
    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            cmd.CommandText = "insert into COMMENT(ID,PID,COMMENT) VALUES(" & Val(Session("id")) & "," & Session("PID") & ",'" & TextBox1.Text & "')"
            cmd.ExecuteNonQuery()
            ''   MsgBox("your data are saved")
            TextBox1.Text = ""
            ''    Dim ss As String
            c.cnn.Close()
            'cmd.Connection = c.connect()
            'cmd.CommandType = Data.CommandType.Text
            'ss = "select  * from COMMENT,IREGI,REGIS  where COMMENT.ID = IREGI .RID and COMMENT .ID = REGIS .id AND COMMENT.PID=" & Val(Session("PID")) & ""
            'cmd.CommandText = ss
            'dtr = cmd.ExecuteReader()
            'While dtr.Read() = True
            '    Dim table1 As New Table()
            '    table1.BorderWidth = 1
            '    table1.BorderColor = Drawing.Color.SkyBlue
            '    Dim row As New TableRow()
            '    Dim cal1 As New TableCell()
            '    Dim cal2 As New TableCell()
            '    cal2.Width = 400
            '    Dim pro As New Image
            '    pro.ImageUrl = "~/pro_image/" + dtr("IMAGE") + ".png"
            '    Dim comm, comm1 As New Label
            '    comm.ForeColor = Drawing.Color.Blue
            '    ''  comm.Font.Bold = True
            '    comm.Text = dtr("NAME") + "Say "
            '    comm1.Text = dtr("COMMENT")
            '    Dim name As New Label
            '    comm.Font.Size = 10
            '    comm1.Font.Size = 10
            '    name.Font.Bold = True
            '    name.Text = dtr("NAME")
            '    name.Width = 340
            '    pro.Height = 35
            '    pro.Width = 45
            '    cal1.VerticalAlign = VerticalAlign.Top
            '    cal1.VerticalAlign = VerticalAlign.Top
            '    cal1.Controls.Add(pro)
            '    row.Cells.Add(cal1)
            '    cal2.Controls.Add(name)
            '    cal2.Controls.Add(comm)
            '    cal2.Controls.Add(comm1)
            '    row.Cells.Add(cal2)
            '    table1.Rows.Add(row)
            '    Panel5.Controls.Add(table1)
            'End While
            'c.cnn.Close()
            Response.Redirect("Searchresponce.aspx")

        End If
        ''    Response.Redirect("Searchresponce.aspx")

    End Sub

    Protected Sub TextBox1_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Unload
      
    End Sub
End Class
