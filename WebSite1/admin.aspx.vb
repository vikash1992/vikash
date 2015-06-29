
Partial Class admin
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim ss As String
        Dim i As Integer = 0
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text

        ss = "select * from ITEMS_IMAGES,ITEM_DETAIL ,REGIS where ITEMS_IMAGES .PID =ITEM_DETAIL .PID and ITEM_DETAIL .RID = REGIS .id"
        cmd.CommandText = ss
        dtr = cmd.ExecuteReader()
        While dtr.Read() = True
            Dim table1 As New Table
            table1.BackColor = Drawing.Color.IndianRed
            Dim row1 As New TableRow
            Dim cal1 As New TableCell
            Dim cal2 As New TableCell
            Dim cal3 As New TableCell
            Dim cal4 As New TableCell
            Dim cal5 As New TableCell
            Dim name As New Label
            name.Text = dtr("NAME")
            Dim addr As New Label
            addr.Text = dtr("ADDRESS")
            Dim regi As New Label
            regi.Text = dtr("ID")
            Dim itemid As New Label
            itemid.Text = dtr("PID")
            Dim img As New ImageButton
            img.Height = 35
            img.Width = 45
            '  cal5.CssClass = "zoom4"
            img.CssClass = "zoom4"
            img.ImageUrl = dtr("IMAGE")
            cal1.Controls.Add(name)
            cal1.Width = 70
            cal2.Controls.Add(addr)
            cal2.Width = 120
            cal3.Controls.Add(regi)
            cal3.Width = 50
            cal4.Controls.Add(itemid)
            cal4.Width = 70
            ''  cal5.CssClass = "zoom4"
            cal5.Controls.Add(img)
            row1.Cells.Add(cal1)
            row1.Cells.Add(cal2)
            row1.Cells.Add(cal3)
            row1.Cells.Add(cal4)
            row1.Cells.Add(cal5)
            row1.BorderWidth = 2
            row1.BorderColor = Drawing.Color.Black

            table1.Rows.Add(row1)
            Panel2.Controls.Add(table1)

 
        End While
        c.cnn.Close()



    End Sub

    

    

  
End Class
