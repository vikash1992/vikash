
Partial Class AddPictureItem
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    Dim i As String
    'Protected Sub Uplode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Uplode.Click


    'End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      


        Dim ss As String
            Dim I As Integer = 1
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        ss = " select * from ITEMS_IMAGES,ITEM_DETAIL,REGIS  WHERE ITEM_DETAIL.PID=ITEMS_IMAGES.PID AND REGIS .ID =ITEM_DETAIL .RID AND ITEMS_IMAGES.PID=" & Val(Session("PID")) & " "
        cmd.CommandText = ss
        dtr = cmd.ExecuteReader()
        While dtr.Read() = True
                Dim pic As New ImageButton
            If I = 1 Then
                Image1.ImageUrl = dtr("IMAGE")
                Image1.ImageAlign = ImageAlign.Top

                Panel3.GroupingText = " ₹ " + dtr("XYX")
                Label1.Text = dtr("NAME")
                Label2.Text = dtr("ADDRESS")
                Label3.Text = dtr("CITY")
                Label11.Text = " ₹ " + dtr("xyx")
                Label4.Text = dtr("STATE")
                Label5.Text = dtr("MOBILE")
                Label6.Text = dtr("EMAIL")
                Label7.Text = dtr("TYPE")
                Label8.Text = dtr("ITEM_TYPE")
                Label9.Text = dtr("SUB_ITEM_TYPE")
                Label10.Text = dtr("ABOUT")

            End If
            pic.Width = 80
            pic.Height = 60
            pic.ImageAlign = ImageAlign.Left
            pic.BorderWidth = 1
            pic.BorderColor = Drawing.Color.BlueViolet
                I = I + 1
            pic.ID = I
            AddHandler pic.Click, AddressOf PrintMessage

                pic.ImageUrl = dtr("IMAGE")
                Panel3.Controls.Add(pic)

        End While
        c.cnn.Close()
        Dim addbtn As New ImageButton
        addbtn.Height = 60
        addbtn.Width = 80
        addbtn.BorderWidth = 1
        addbtn.BorderColor = Drawing.Color.BlueViolet
        addbtn.ImageAlign = ImageAlign.Left
        addbtn.CssClass = "openModal"
        addbtn.ImageUrl = "~/img/addd.png"
        Panel3.Controls.Add(addbtn)

         'Dim pic As New Image
        'pic.Width = 600
        'pic.Height = 400
        'pic.ImageUrl = "~/image/addd.png"
        'Panel3.Controls.Add(pic)


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

      
        Image2.ImageUrl = "~/pro_image/" + Session("img") + ".png"

    End Sub
    Private Sub PrintMessage(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TypeOf sender Is ImageButton Then
            Image1.ImageUrl = CType(sender, ImageButton).ImageUrl
        End If
    End Sub
    'Protected Sub Uplode_Command(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.CommandEventArgs) Handles Uplode.Command

    'End Sub

    'Protected Sub Uplode_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Uplode.DataBinding

    'End Sub

    'Protected Sub Uplode_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Uplode.Disposed

    'End Sub
    

    
     
    Protected Sub btnUpload_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Dim pic As String
        pic = Session("PID").ToString + Now.Day.ToString + Now.Millisecond.ToString
        If fupload.FileName <> "" Then
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            cmd.CommandText = "insert into ITEMS_IMAGES(PID,IMAGE,DETAIL,ID) VALUES(" & Val(Session("PID")) & ",'" & "~/ITEM_IMAGE/" + pic + ".png" & "','" & "HELLO" & "'," & Val(Session("ID")) & ")"
            cmd.ExecuteNonQuery()
            MsgBox("your data are saved")

            c.cnn.Close()

            fupload.PostedFile.SaveAs(Server.MapPath("ITEM_IMAGE\" + pic + ".png"))
        Else
            '    Label1.Visible = True
            '' Label1.Text = "Select Picture"
            MsgBox("select pic")
        End If
        Response.Redirect("AddPictureItem.aspx")
    End Sub

    Protected Sub btn_open_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_open.Click

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Response.Redirect("Edit.aspx")
    End Sub
End Class
