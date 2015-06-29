
Partial Class Home
    Inherits System.Web.UI.Page

    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    Private Sub PrintMessage(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TypeOf sender Is ImageButton Then
            Dim ss As String
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = "SELECT * FROM ITEMS_IMAGES where IPID = " & Val(CType(sender, ImageButton).ID) & ""
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                Session.Add("imagelink", dtr("PID"))
                Session.Add("imageurl", dtr("IMAGE"))
                ''   MsgBox(dtr("PID"))
            End While
            c.cnn.Close()
        End If
        Response.Redirect("Searchresponce.aspx")
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim i As Integer = 0
        Dim ss As String
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        ss = "select top 15 * from ITEMS_IMAGES,ITEM_DETAIL ,REGIS where ITEMS_IMAGES .PID =ITEM_DETAIL .PID and ITEM_DETAIL .RID = REGIS .id order by ITEMS_IMAGES.PID desc "
        cmd.CommandText = ss
        dtr = cmd.ExecuteReader()
        While dtr.Read() = True

            If dtr("PID") <> i Then
                Dim pan As New Panel
                Dim img As New ImageButton
                'img.Height = 60
                'img.Width = 93
                img.CssClass = "zoom1"
                img.BorderWidth = 1
                img.ImageUrl = dtr("IMAGE")
                img.BorderColor = Drawing.Color.SkyBlue
                img.ImageAlign = ImageAlign.Left
                pan.Controls.Add(img)

                Dim rs As New Label
                '  rs.CssClass = "info"
                Dim subt As New Label
                subt.Height = 28
                '  subt.CssClass = "info"
                Dim city As New Label
                '  city.CssClass = "info"
                city.Text = dtr("CITY")
                city.Font.Size = 9
                subt.Font.Size = 9
                img.ID = dtr("IPID")
                AddHandler img.Click, AddressOf PrintMessage
                city.Width = 85
                city.Font.Bold = True
                '' subt.Height = 20
                subt.Width = 85
                ''  subt.ForeColor = Drawing.Color.Black
                subt.Text = dtr("SUB_ITEM_TYPE") + " " + dtr("TYPE")
                rs.ForeColor = Drawing.Color.Blue
                rs.Text = " ₹ " + dtr("XYX")
                rs.Width = 85
                pan.Controls.Add(rs)

                pan.Controls.Add(subt)
                pan.Controls.Add(city)
                pan.BorderWidth = 1

                pan.BorderColor = Drawing.Color.BlanchedAlmond
                pan.Height = 62
                pan.Width = 185

                Panel2.Controls.Add(pan)
                i = dtr("PID")
            End If


        End While
        c.cnn.Close()
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Session.Add("two", "House")

        Response.Redirect("search.aspx")
    End Sub

    Protected Sub ImageButton13_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton13.Click
        Session.Add("two", "Car")

        Response.Redirect("search.aspx")
    End Sub

    Protected Sub ImageButton3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Session.Add("two", "Bike")

        Response.Redirect("search.aspx")
    End Sub

    Protected Sub ImageButton4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Session.Add("two", "Painter")

        Response.Redirect("search.aspx")
    End Sub

    Protected Sub ImageButton7_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        Session.Add("two", "Electicition")

        Response.Redirect("search.aspx")
    End Sub

    Protected Sub ImageButton12_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton12.Click
        Session.Add("two", "Carpenter")

        Response.Redirect("search.aspx")
    End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        Session.Add("two", "Cook")

        Response.Redirect("search.aspx")
    End Sub

    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click
        Session.Add("two", "Painter")

        Response.Redirect("search.aspx")
    End Sub

    Protected Sub ImageButton11_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton11.Click
        Session.Add("two", "Laptop")

        Response.Redirect("search.aspx")
    End Sub

    Protected Sub ImageButton6_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        Session.Add("two", "House")

        Response.Redirect("search.aspx")
    End Sub

    Protected Sub ImageButton9_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton9.Click
        Session.Add("two", "Mobile")

        Response.Redirect("search.aspx")
    End Sub

    Protected Sub ImageButton10_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton10.Click
        Session.Add("two", "Tab")

        Response.Redirect("search.aspx")
    End Sub
End Class
