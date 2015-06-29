Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Configuration
Partial Class Profile
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    Dim i As String
    Public Function ThumbnailCallback() As Boolean
        Return False
    End Function
    Private Sub PrintMessage(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TypeOf sender Is LinkButton Then
            Session.Add("PID", CType(sender, LinkButton).ID)
            '   Session.Add("imageurl", dtr("IMAGE"))
            Response.Redirect("AddPictureItem.aspx")

        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim ss As String
        Dim i As Integer = 0
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text

        ss = "select * from ITEMS_IMAGES,ITEM_DETAIL ,REGIS where ITEMS_IMAGES .PID =ITEM_DETAIL .PID and ITEM_DETAIL .RID = REGIS .id  and ITEM_DETAIL.RID=" & Val(Session("ID")) & " order by ITEMS_IMAGES.PID desc  "
        cmd.CommandText = ss
        dtr = cmd.ExecuteReader()
        While dtr.Read() = True
            Dim pic As New ImageButton
            pic.ID = dtr("IPID")
            AddHandler pic.Click, AddressOf PrintMessage
            If dtr("PID") <> i Then
                Dim line As New ImageButton
                line.Height = 5
                line.Width = 450
                '' line.ID = dtr("IPID")
                line.ImageUrl = "~/bootstrap/img/stoper.png"
                Panel3.Controls.Add(line)
                i = Val(dtr("PID"))
                Dim pa As New Panel
                Try
                    Dim path As String = Server.MapPath(dtr("IMAGE"))

                    Dim image As System.Drawing.Image = System.Drawing.Image.FromFile(path)
                    Using thumbnail As System.Drawing.Image = image.GetThumbnailImage(450, 200, New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback), IntPtr.Zero)
                        Using memoryStream As New MemoryStream()
                            thumbnail.Save(memoryStream, ImageFormat.Png)
                            Dim bytes As [Byte]() = New [Byte](memoryStream.Length - 1) {}
                            memoryStream.Position = 0
                            memoryStream.Read(bytes, 0, CInt(bytes.Length))
                            Dim base64String As String = Convert.ToBase64String(bytes, 0, bytes.Length)
                            pa.BackImageUrl = "data:image/png;base64," & base64String
                        End Using

                    End Using
                Catch ex As Exception

                End Try
                pa.Width = 450
                pa.Height = 200
                pa.BorderWidth = 1
                pa.BorderColor = Drawing.Color.SkyBlue
                Dim info As New LinkButton
                info.Width = 450
                info.Height = 170
                info.Font.Underline = False
                info.BackColor = Color.Transparent
                AddHandler info.Click, AddressOf PrintMessage
                Session.Add("PIC", "hello ")
                info.Text = " ₹  " + dtr("XYX") + ".00 \-"
                info.ID = dtr("PID")
                pa.Controls.Add(info)



                Dim mob As New LinkButton
                mob.Text = dtr("SUB_ITEM_TYPE").ToString + "," + dtr("ABOUT").ToString + "  -  " + dtr("MOBILE").ToString
                mob.Width = 450
                mob.CssClass = "info"
                ''  ''   mob.ForeColor = Color.Black
                mob.ID = dtr("IMAGE")
                AddHandler mob.Click, AddressOf PrintMessage
                ''   mob.Font.Underline = False
                ' mob.Font.Bold = True
                ''  pa.ControlStyle.CssClass = "info"
                pa.Controls.Add(mob)
                Panel3.Controls.Add(pa)

            Else

                pic.CssClass = "zoom"
                pic.BorderColor = Drawing.Color.CornflowerBlue
                pic.ImageAlign = ImageAlign.Top
                pic.BorderWidth = 2
                '  pic.Width = 60
                ' pic.Height = 35
                pic.ImageUrl = dtr("IMAGE")
                Panel3.Controls.Add(pic)
            End If

        End While
        c.cnn.Close()


        
      
        Dim img As String = ""
        ''  Dim ss As String
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        ss = " select top 1 *  from IREGI,REGIS WHERE REGIS.id=IREGI.RID AND IREGI.RID=" & Val(Session("ID")) & " order by IID DESC"
        cmd.CommandText = ss
        dtr = cmd.ExecuteReader()
        While dtr.Read() = True
            img = dtr("IMAGE")
            i = dtr("IID")
        End While
        c.cnn.Close()
        Session.Add("img", img)
        If img <> "" Then
            Try
                Dim path As String = Server.MapPath("~/pro_image/" + img + ".png")
                ''   MsgBox(path)
                Dim image As System.Drawing.Image = System.Drawing.Image.FromFile(path)
                Using thumbnail As System.Drawing.Image = image.GetThumbnailImage(200, 220, New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback), IntPtr.Zero)
                    Using memoryStream As New MemoryStream()
                        thumbnail.Save(memoryStream, ImageFormat.Png)
                        Dim bytes As [Byte]() = New [Byte](memoryStream.Length - 1) {}
                        memoryStream.Position = 0
                        memoryStream.Read(bytes, 0, CInt(bytes.Length))
                        Dim base64String As String = Convert.ToBase64String(bytes, 0, bytes.Length)
                        ss = "data:image/png;base64," & base64String
                    End Using

                End Using
            Catch ex As Exception

            End Try

        End If


         
        ImageButton1.ImageUrl = ss
        '' ImageButton2.ImageUrl = "~/pro_image/" + img + ".jpg"
        Label1.Visible = False
        FileUpload1.Visible = False
        Button5.Visible = False
        
    
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        

        FileUpload1.Visible = True
        Button5.Visible = True


    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim tem As String
        tem = Session("uname") + Session("MOBILE").ToString + (Now.Second).ToString


     
        If FileUpload1.PostedFile.FileName <> "" Then
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            cmd.CommandText = "delete IREGI where RID=" & Val(Session("ID")) & ""
            cmd.ExecuteNonQuery()
            MsgBox("your data are saved")

            c.cnn.Close()
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            cmd.CommandText = "insert into IREGI(RID,IMAGE) VALUES(" & Val(Session("ID")) & ",'" & tem & "')"
            cmd.ExecuteNonQuery()
            MsgBox("your data are saved")

            c.cnn.Close()

            FileUpload1.PostedFile.SaveAs(Server.MapPath("pro_image\" + tem + ".png"))
        Else
            Label1.Visible = True
            Label1.Text = "Select Picture"
        End If
        'Dim ss As String

        'cmd.Connection = c.connect()
        'cmd.CommandType = Data.CommandType.Text
        'ss = " select count(RID) as coun from IREGI WHERE RID=" & Val(Session("ID")) & ""
        'cmd.CommandText = ss
        'dtr = cmd.ExecuteReader()
        'While dtr.Read() = True
        '    MsgBox(dtr("coun"))
        'End While
        'c.cnn.Close()


        Response.Redirect("Profile.aspx")


    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Session.Add("type", "New Item")
        Session.Add("TID", 1)

        Response.Redirect("itemadd.aspx")

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Session.Add("type", "Old Item")
        Session.Add("TID", 2)

        Response.Redirect("itemadd.aspx")

    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Session.Add("type", "On_Rent")
        Session.Add("TID", 3)

        Response.Redirect("itemadd.aspx")

    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Session.Add("type", "Service Provider")
        Session.Add("TID", 4)

        Response.Redirect("itemadd.aspx")

    End Sub

    

    'Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    'End Sub
    'Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand

    '    Dim Ind As Integer = Int32.Parse(e.CommandArgument.ToString)
    '    '' Dim ss As String
    '    Dim rowid As Integer
    '    rowid = Val(GridView1.DataKeys(Ind).Value)
    '    Session.Add("PID", rowid)
    '    Response.Redirect("AddPictureItem.aspx")

    'End Sub
End Class
