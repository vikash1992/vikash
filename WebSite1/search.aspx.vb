Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Configuration

Partial Class search

    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    Public Function ThumbnailCallback() As Boolean
        Return False
    End Function
    Private Sub PrintMessage(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TypeOf sender Is LinkButton Then
            ''   Session.Add("imagelink1", CType(sender, LinkButton).ID)
            '   Session.Add("imageurl", dtr("IMAGE"))
            Dim ss As String
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = "SELECT * FROM ITEMS_IMAGES where IMAGE ='" & (CType(sender, LinkButton).ID).ToString & "'"
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                Session.Add("imagelink", dtr("PID"))
                Session.Add("imageurl", dtr("IMAGE"))
                ''  MsgBox(dtr("PID"))
            End While
            c.cnn.Close()

            Response.Redirect("Searchresponce.aspx")

        End If
    End Sub
    Private Sub PrintMessage1(ByVal sender As System.Object, ByVal e As System.EventArgs)

         If TypeOf sender Is LinkButton Then
            Dim ss As String
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = "SELECT * FROM ITEMS_IMAGES where IPID = " & Val(CType(sender, LinkButton).ID) & ""
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                Session.Add("imagelink", dtr("PID"))
                Session.Add("imageurl", dtr("IMAGE"))
                '' MsgBox(dtr("PID"))
            End While
            c.cnn.Close()
           
            Response.Redirect("Searchresponce.aspx")
            ''  MsgBox(CType(sender, LinkButton).ID)


        End If
    End Sub
    

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ss As String
        Dim i As Integer = 0
        ''Dim ss As String
        'cmd.Connection = c.connect()
        'cmd.CommandType = Data.CommandType.Text
        'ss = "select top 15 * from ITEMS_IMAGES,ITEM_DETAIL ,REGIS where ITEMS_IMAGES .PID =ITEM_DETAIL .PID and ITEM_DETAIL .RID = REGIS .id order by ITEMS_IMAGES.PID desc "
        'cmd.CommandText = ss
        'dtr = cmd.ExecuteReader()
        'While dtr.Read() = True

        '    If dtr("PID") <> i Then
        '        Dim pan As New Panel
        '        Dim img As New ImageButton
        '        img.Height = 60
        '        img.Width = 93
        '        img.BorderWidth = 1
        '        img.ImageUrl = dtr("IMAGE")
        '        img.BorderColor = Drawing.Color.SkyBlue
        '        img.ImageAlign = ImageAlign.Left
        '        pan.Controls.Add(img)

        '        Dim rs As New Label
        '        '  rs.CssClass = "info"
        '        Dim subt As New Label
        '        subt.Height = 28
        '        '  subt.CssClass = "info"
        '        Dim city As New Label
        '        '  city.CssClass = "info"
        '        city.Text = dtr("CITY")
        '        city.Font.Size = 9
        '        subt.Font.Size = 9
        '        img.ID = dtr("IPID")
        '        AddHandler img.Click, AddressOf PrintMessage
        '        city.Width = 85
        '        city.Font.Bold = True
        '        '' subt.Height = 20
        '        subt.Width = 85
        '        ''  subt.ForeColor = Drawing.Color.Black
        '        subt.Text = dtr("SUB_ITEM_TYPE") + " " + dtr("TYPE")
        '        rs.ForeColor = Drawing.Color.Blue
        '        rs.Text = " ₹ " + dtr("XYX")
        '        rs.Width = 85
        '        pan.Controls.Add(rs)

        '        pan.Controls.Add(subt)
        '        pan.Controls.Add(city)
        '        pan.BorderWidth = 1

        '        pan.BorderColor = Drawing.Color.BlanchedAlmond
        '        pan.Height = 62
        '        pan.Width = 185

        '        Panel2.Controls.Add(pan)
        '        i = dtr("PID")
        '    End If


        'End While
        'c.cnn.Close()




        If Session("state") <> "" Then
            DropDownList1.Items.Add(Session("state"))
            DropDownList2.Items.Add(Session("city"))
        End If
        If Session("two") <> "" Then
            '  DropDownList3.Items.Add(Session("one"))
            DropDownList4.Items.Add(Session("two"))

        End If

        
        If Not IsPostBack Then
            DropDownList1.Items.Add("State")
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = "SELECT * FROM STATE"
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                DropDownList1.Items.Add(dtr("STATE"))
            End While
            c.cnn.Close()

            DropDownList3.Items.Add("Type")
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = "SELECT DISTINCT TYPE FROM TYPE "
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                DropDownList3.Items.Add(dtr("TYPE"))
            End While
            c.cnn.Close()

        End If
        '' MsgBox(Session("one"))
        ''  MsgBox(Session("search"))
        'If Not IsPostBack Then
        Dim script As String = "$(document).ready(function () { $('[id*=btnSubmit]').click(); });"
        ClientScript.RegisterStartupScript(Me.GetType, "load", script, True)
        'End If


        imgprv.ImageUrl = "~/pro_image/vikashgupta81476364376.png"


        i = 0


        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text

        ss = "select * from ITEMS_IMAGES,ITEM_DETAIL ,REGIS where ITEMS_IMAGES .PID =ITEM_DETAIL .PID and ITEM_DETAIL .RID = REGIS .id and ITEM_TYPE like '%'+'" & Session("two") & "' +'%' and TYPE LIKE '%'+'" & Session("one") & "'+'%' and SUB_ITEM_TYPE LIKE '%'+'" & Session("three") & "' +'%' and STATE LIKE '%'+'" & Session("state") & "' + '%' and CITY like '%'+'" & Session("city") & "'+'%' order by ITEMS_IMAGES.PID desc "
        'ss = " select *  from ITEMS_IMAGES order by PID "
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
                ' line.ID = dtr("IPID")
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
                AddHandler info.Click, AddressOf PrintMessage1
                Session.Add("PIC", "hello ")
                info.Text = " ₹  " + dtr("XYX") + ".00 \-"
                info.ID = dtr("IPID")
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

    End Sub

    Protected Sub imgprv_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgprv.Load
       End Sub

   
    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged


        Session("one") = ""
        Session("three") = ""

        Session("two") = ""

        DropDownList2.Items.Clear()
        DropDownList2.Items.Add("City")
        Dim ss As String
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        ss = "SELECT * FROM CITY WHERE SID='" & DropDownList1.Text & "'"
        cmd.CommandText = ss
        dtr = cmd.ExecuteReader()
        While dtr.Read() = True
            DropDownList2.Items.Add(dtr("CITY"))
        End While
        c.cnn.Close()


    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList2.SelectedIndexChanged

        Session.Add("city", DropDownList2.Text)
        Session.Add("state", DropDownList1.Text)
        Response.Redirect("search.aspx")
        'Dim i As Integer = 0

        'MsgBox("")
        'Dim SS As String
        'cmd.Connection = c.connect()
        'cmd.CommandType = Data.CommandType.Text

        'SS = "select * from ITEMS_IMAGES,ITEM_DETAIL ,REGIS where ITEMS_IMAGES .PID =ITEM_DETAIL .PID and ITEM_DETAIL .RID = REGIS .id and STATE='" & DropDownList1.Text & "'  and CITY='" & DropDownList2.Text & "' order by ITEMS_IMAGES.PID desc "
        ''ss = " select *  from ITEMS_IMAGES order by PID "
        'cmd.CommandText = ss
        'dtr = cmd.ExecuteReader()
        'While dtr.Read() = True
        '    Dim pic As New ImageButton
        '    pic.ID = dtr("IPID")
        '    AddHandler pic.Click, AddressOf PrintMessage
        '    If dtr("PID") <> i Then
        '        Dim line As New ImageButton
        '        line.Height = 5
        '        line.Width = 450
        '        ' line.ID = dtr("IPID")
        '        line.ImageUrl = "~/bootstrap/img/stoper.png"
        '        Panel3.Controls.Add(line)
        '        i = Val(dtr("PID"))

        '        Dim pa As New Panel
        '        Try


        '            Dim path As String = Server.MapPath(dtr("IMAGE"))

        '            Dim image As System.Drawing.Image = System.Drawing.Image.FromFile(path)
        '            Using thumbnail As System.Drawing.Image = image.GetThumbnailImage(450, 200, New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback), IntPtr.Zero)
        '                Using memoryStream As New MemoryStream()
        '                    thumbnail.Save(memoryStream, ImageFormat.Png)
        '                    Dim bytes As [Byte]() = New [Byte](memoryStream.Length - 1) {}
        '                    memoryStream.Position = 0
        '                    memoryStream.Read(bytes, 0, CInt(bytes.Length))
        '                    Dim base64String As String = Convert.ToBase64String(bytes, 0, bytes.Length)
        '                    pa.BackImageUrl = "data:image/png;base64," & base64String
        '                End Using

        '            End Using
        '        Catch ex As Exception

        '        End Try
        '        'pa.BackImageUrl = dtr("IMAGE")

        '        pa.Width = 450
        '        pa.Height = 200
        '        pa.BorderWidth = 1
        '        pa.BorderColor = Drawing.Color.SkyBlue
        '        Dim info As New LinkButton
        '        '' info.CssClass = "info"

        '        info.Width = 600
        '        info.Height = 170
        '        info.Font.Underline = False
        '        info.BackColor = Color.Transparent
        '        AddHandler info.Click, AddressOf PrintMessage1
        '        Session.Add("PIC", "hello ")
        '        info.Text = " ₹  " + dtr("XYX") + ".00 \-"
        '        info.ID = dtr("IPID")
        '        pa.Controls.Add(info)

        '        'Dim inf As New LinkButton
        '        'inf.Text = dtr("SUB_ITEM_TYPE") + "-"
        '        'inf.Font.Bold = True
        '        'inf.Font.Italic = True
        '        'inf.Font.Underline = True
        '        'inf.CssClass = "info"
        '        'info.ForeColor = Color.Black
        '        'pa.Controls.Add(inf)
        '        'Dim infos As New LinkButton
        '        'infos.Text = dtr("ABOUT")
        '        'infos.CssClass = "info"
        '        'infos.Font.Italic = True
        '        '' infos.Font.Underline = True
        '        'infos.ForeColor = Color.Black
        '        'infos.Font.Underline = False
        '        'pa.Controls.Add(infos)

        '        Dim mob As New LinkButton
        '        mob.Text = dtr("SUB_ITEM_TYPE").ToString + "," + dtr("ABOUT").ToString + "  -  " + dtr("MOBILE").ToString
        '        mob.Width = 450
        '        mob.CssClass = "info"
        '        ''  ''   mob.ForeColor = Color.Black
        '        mob.ID = dtr("IMAGE")
        '        AddHandler mob.Click, AddressOf PrintMessage
        '        ''   mob.Font.Underline = False
        '        ' mob.Font.Bold = True
        '        ''  pa.ControlStyle.CssClass = "info"
        '        pa.Controls.Add(mob)
        '        Panel3.Controls.Add(pa)

        '    Else
        '        pic.BorderColor = Drawing.Color.CornflowerBlue
        '        pic.ImageAlign = ImageAlign.Top
        '        pic.BorderWidth = 2
        '        pic.Width = 60
        '        pic.Height = 35
        '        pic.ImageUrl = dtr("IMAGE")
        '        Panel3.Controls.Add(pic)

        '    End If
        'End While
        'c.cnn.Close()


    End Sub

    Protected Sub DropDownList3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList3.SelectedIndexChanged
        Dim SS As String
        DropDownList4.Items.Clear()
        DropDownList4.Items.Add("Sub Type")
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        SS = "SELECT DISTINCT ITEM_TYPE FROM TYPE where TYPE='" & DropDownList3.Text & "' "
        cmd.CommandText = ss
        dtr = cmd.ExecuteReader()
        While dtr.Read() = True
            DropDownList4.Items.Add(dtr("ITEM_TYPE"))
        End While
        c.cnn.Close()

    End Sub

    Protected Sub DropDownList4_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList4.SelectedIndexChanged
        Session.Add("two", DropDownList4.Text)
        Response.Redirect("search.aspx")
    End Sub
End Class
