

Option Explicit On
Imports System.IO
Imports System.Text.RegularExpressions

Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Data

Partial Class test1
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    Dim i As String

    
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim hfc As HttpFileCollection = Request.Files
        If hfc.Count > 0 Then

            Dim hpf As HttpPostedFile = hfc(0)
            If hpf.ContentLength > 0 Then

                Dim sImageName As String = hpf.FileName

                ' FIRST SAVE THE FILE ON THE SERVER.
                hpf.SaveAs(Server.MapPath("~/" & Path.GetFileName(sImageName)))

                ' ORIGINAL WIDTH AND HEIGHT.
                Dim bitmap As New Bitmap(Server.MapPath("~/" & Path.GetFileName(hpf.FileName)))

                Dim iwidth As Integer = bitmap.Width
                Dim iheight As Integer = bitmap.Height
                bitmap.Dispose()

                ' SHOW DETAILS OF ORIGINAL IMAGE WITH SIZE.
                Info.InnerHtml = "<b>Original Image</b> "
                Info.InnerHtml = Info.InnerHtml & "<br /> Width: " & iwidth & ", Height: " & iheight & "<br /> " & Double.Parse(hpf.ContentLength / 1024).ToString("N0") & " KB <br>"


                ' ONCE WE GOT ALL THE INFORMATION, WE NOW PROCESS IT.

                ' CREATE AN IMAGE OBJECT USING ORIGINAL WIDTH AND HEIGHT.
                ' ALSO DEFINE A PIXEL FORMAT (FOR RICH RGB COLOR).

                Dim objOptImage As System.Drawing.Image = New System.Drawing.Bitmap(iwidth, iheight, System.Drawing.Imaging.PixelFormat.Format16bppRgb555)

                ' GET THE ORIGINAL IMAGE.
                Using objImg As System.Drawing.Image = System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/" & sImageName))

                    ' RE-DRAW THE IMAGE USING THE NEWLY OBTAINED PIXEL FORMAT.
                    Using oGraphic As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(objOptImage)
                        With oGraphic
                            Dim oRectangle As New System.Drawing.Rectangle(0, 0, iwidth, iheight)

                            .DrawImage(objImg, oRectangle)
                        End With
                    End Using

                    ' SAVE THE OPTIMIZED IMAGE.
                    objOptImage.Save(HttpContext.Current.Server.MapPath("~/pro_image/" & sImageName), System.Drawing.Imaging.ImageFormat.Png)

                    objImg.Dispose()
                End Using

                objOptImage.Dispose()

                ' FINALLY SHOW THE OPTIMIZED IMAGE DETAILS WITH SIZE.
                Dim bitmap_Opt As New Bitmap(Server.MapPath("~/pro_image/" & Path.GetFileName(sImageName)))

                Dim iwidth_Opt As Integer = bitmap_Opt.Width
                Dim iheight_Opt As Integer = bitmap_Opt.Height
                bitmap_Opt.Dispose()

                ' FOR SIZE.
                Dim OptImgInfo As New FileInfo(Server.MapPath("~/pro_image/" & Path.GetFileName(sImageName)))
                Dim ifileSize As Integer = OptImgInfo.Length    ' GET THE SIZE IN BYTES.

                Info.InnerHtml = Info.InnerHtml & "<br / ><b>Optimized Image</b>"
                Info.InnerHtml = Info.InnerHtml & "<br /> Width: " & iwidth_Opt & ", Height: " & iheight_Opt
                Info.InnerHtml = Info.InnerHtml & "<br /><span style=color:green>" & Double.Parse(ifileSize / 1024).ToString("N0") & " KB</span>"
            End If
        End If


    End Sub
    Public Function ThumbnailCallback() As Boolean
        Return False
    End Function

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click



        Try
            Dim ss As String

            Dim path As String = Server.MapPath("~/pro_image/4.jpg")
            MsgBox(path)
            Dim image As System.Drawing.Image = System.Drawing.Image.FromFile(path)
            Using thumbnail As System.Drawing.Image = image.GetThumbnailImage(200, 220, New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback), IntPtr.Zero)
                Using memoryStream As New MemoryStream()
                    thumbnail.Save(memoryStream, ImageFormat.Png)
                    Dim bytes As [Byte]() = New [Byte](memoryStream.Length - 1) {}
                    memoryStream.Position = 0
                    memoryStream.Read(bytes, 0, CInt(bytes.Length))
                    Dim base64String As String = Convert.ToBase64String(bytes, 0, bytes.Length)
                    ss = "data:image/png;base64," & base64String
                    Image1.ImageUrl = ss
                    ss = Server.MapPath("data:image/png;base64," & base64String)
                    image = System.Drawing.Image.FromFile(ss)
                    image.Save(Server.MapPath("~\pro_image\456.jpg"))
                End Using

            End Using
        Catch ex As Exception
        End Try


    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
      
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
       
    End Sub
     Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim a As Integer
        For a = 1 To 10
            Dim img As New ImageButton
            'img.Width = 200
            'img.Height = 150
            img.ImageUrl = "~/img/18.jpg"
            ''    img.ID = a
            AddHandler img.Click, AddressOf img_Click
            img.CssClass = "vis"
            Panel3.CssClass = "vis"
            Panel3.Controls.Add(img)

        Next


    End Sub
    Protected Sub img_Click(ByVal sender As Object, ByVal e As ImageClickEventArgs)
        If TypeOf sender Is ImageButton Then
          End If
        
    End Sub
    Protected Sub iamgevis()

    End Sub

     
    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim phoneNumber As New Regex("\d{11}")

 
        If phoneNumber.IsMatch(TextBox1.Text) And TextBox1.Text.Length = 11 Then
            MsgBox("true")
        Else
            MsgBox("false")
        End If
     End Sub
End Class
