
Imports System.IO
'Imports System.Drawing
'Imports System.Drawing.Imaging
Imports System.Data


Partial Class test
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    ''Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    Dim i As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub GenerateThumbnail(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerate.Click
        'Dim path As String = Server.MapPath("~/img/1.jpg")
        'Dim image As System.Drawing.Image = System.Drawing.Image.FromFile(path)
        'Using thumbnail As System.Drawing.Image = image.GetThumbnailImage(100, 100, New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback), IntPtr.Zero)
        '    Using memoryStream As New MemoryStream()
        '        thumbnail.Save(memoryStream, ImageFormat.Png)
        '        Dim bytes As [Byte]() = New [Byte](memoryStream.Length - 1) {}
        '        memoryStream.Position = 0
        '        memoryStream.Read(bytes, 0, CInt(bytes.Length))
        '        Dim base64String As String = Convert.ToBase64String(bytes, 0, bytes.Length)
        '        Image2.ImageUrl = "data:image/png;base64," & base64String


        '    End Using
        'End Using
    End Sub

    'Public Function ThumbnailCallback() As Boolean
    '    Return False
    'End Function

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        FileUpload1.PostedFile.SaveAs(Server.MapPath("pro\aa.jpg"))


    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim Ds As New DataSet
        'Dim ss As String
        'Dim I As Integer
        'I = 1

        'Dim dt As New DataTable()
        ' ''  dt.Columns.AddRange(New DataColumn(8) {New DataColumn("ID"), New DataColumn("Q.EmpId"), New DataColumn("Q.Type"), New DataColumn("Q.Stream"), New DataColumn("Q.Name"), New DataColumn("Passing Year"), New DataColumn("University"), New DataColumn("College"), New DataColumn("MCI Reg No")})
        'dt.Columns.AddRange(New DataColumn(2) {New DataColumn("IPID"), New DataColumn("PID"), New DataColumn("IMAGE")})
        'cmd.Connection = c.connect()
        'cmd.CommandType = CommandType.Text
        'ss = " select * from ITEMS_IMAGES"
        'cmd.CommandText = ss
        'dtr = cmd.ExecuteReader()
        'While dtr.Read() = True
        '    Dim ii As New Image
        '    Dim sas As New PlaceHolder
        '    ii.ImageUrl = dtr("IMAGE")
        '    ii.Height = 50
        '    ii.Width = 100
        '    sas.Controls.Add(ii)
        '    dt.Rows.Add(dtr("IPID"), dtr("PID"), sas)

        '    GridView1.DataSource = dt
        '    GridView1.DataBind()
        '    ' MsgBox(dtr("state"))
        '    I = I + 1
        'End While
        'c.connect.Close()
        Dim ds As New data.DataSet
        Dim adt As New Data.OleDb.OleDbDataAdapter("select IPID,PID,IMAGE from ITEMS_IMAGES", c.connect)
        adt.Fill(ds)
        GridView1.DataSource = ds
        GridView1.DataBind()

        ' conn.Open();  // open the connection 
        'SqlDataAdapter Sqa = new SqlDataAdapter("select * from picture", conn);
        'DataSet ds = new DataSet();
        'Sqa.Fill(ds);   // fill the dataset 
        'GridView1.DataSource = ds; // give data to GridView
        'GridView1.DataBind();
        'conn.Close();


    End Sub
End Class
